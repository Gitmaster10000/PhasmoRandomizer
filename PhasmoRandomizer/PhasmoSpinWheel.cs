using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace PhasmoRandomizer
{
    public partial class PhasmoSpinWheel : UserControl
    {
        private static Random rng = new Random();
        private Series series;
        private Timer closingTimer = new Timer();
        private Timer startTimer = new Timer();
        private List<string> wheelData;
        private int lastRoll;
        private float usedFont;

        public event EventHandler<EventArgs> WheelHasStopped;
        protected virtual void OnWheelHasStoppedEvent(object sender, EventArgs e)
        {
            WheelHasStopped?.Invoke(sender, e);
        }
        public bool IsReady { get; private set; }
        public PhasmoSpinWheel()
        {
            InitializeComponent();
            chartControlWheel.AnimationEnded -= ChartControlWheel_AnimationEnded;
            chartControlWheel.AnimationEnded += ChartControlWheel_AnimationEnded;
            closingTimer.Interval = 2000;
            startTimer.Interval = 50;
            closingTimer.Tick += ClosingTimer_Tick;
            startTimer.Tick += StartTimer_Tick;
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            startTimer.Stop();
            SpinTheWheel(lastRoll);
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            wheelData.Clear();
            closingTimer.Stop();
            OnWheelHasStoppedEvent(sender, e);
        }

        private void SpinTheWheel(int roll)
        {
            if (series != null)
            {
                PieSeriesView view = series.View as PieSeriesView;
                if (view != null)
                {
                    view.MinAllowedSizePercentage = 1;
                    double onePieRadius = 360 / (double)wheelData.Count;
                    double rotation = (onePieRadius / 2) + (onePieRadius * (double)(wheelData.Count - (roll + 1.0)));
                    view.Rotation = Convert.ToInt32(Math.Round(rotation));
                    PieSpinAnimation spin = new PieSpinAnimation();
                    spin.Enabled = true;
                    spin.Duration = new TimeSpan(0, 0, 3);
                    spin.Direction = PieSweepDirection.Clockwise;
                    view.Animation = spin;
                    spin.RotationCount = (float)rng.NextDouble() + 1.0f * rng.Next(2, 6);
                    spin.PointOrder = PointAnimationOrder.Random;

                    (series.Label as PieSeriesLabel).TextPattern = " ";
                    (series.Label as PieSeriesLabel).Font = new Font(Font.FontFamily, 0.01f, FontStyle.Regular);
                }
            }
            chartControlWheel.Animate();
        }

        private void ChartControlWheel_AnimationEnded(object sender, EventArgs e)
        {
            if (series != null)
            {
                if (series.Label is PieSeriesLabel)
                {
                    (series.Label as PieSeriesLabel).TextPattern = "{A}";
                    (series.Label as PieSeriesLabel).Font = new Font(Font.FontFamily, usedFont, FontStyle.Bold);
                }
            }
            closingTimer.Start();
        }

        public void SetWheelData(List<string> data, float fontSize = 10.5f)
        {
            usedFont = fontSize;
            wheelData = data;
            chartControlWheel.Series.Clear();
            series = new Series("Maps", ViewType.Pie);
            foreach (var d in data)
            {
                series.Points.Add(new SeriesPoint(d, 1));
            }

            (series.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Radial;
            (series.Label as PieSeriesLabel).TextPattern = "{A}";
            (series.Label as PieSeriesLabel).Font = new Font(Font.FontFamily, fontSize, FontStyle.Bold);
            chartControlWheel.Legend.Visibility = DefaultBoolean.False;
            chartControlWheel.Series.Add(series);
            IsReady = true;
        }

        public void Spin(int roll, int startTimeMs = 50)
        {
            IsReady = false;
            lastRoll = roll;
            startTimer.Interval = startTimeMs;
            startTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
