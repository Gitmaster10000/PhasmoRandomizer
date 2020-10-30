namespace PhasmoRandomizer
{
    partial class PhasmoSpinWheel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhasmoSpinWheel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartControlWheel = new DevExpress.XtraCharts.ChartControl();
            this.labelArrow = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.chartControlWheel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelArrow, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 798);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartControlWheel
            // 
            this.chartControlWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartControlWheel.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartControlWheel.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlWheel.Legend.Name = "Default Legend";
            this.chartControlWheel.Location = new System.Drawing.Point(5, 5);
            this.chartControlWheel.Margin = new System.Windows.Forms.Padding(0);
            this.chartControlWheel.Name = "chartControlWheel";
            this.chartControlWheel.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlWheel.Size = new System.Drawing.Size(822, 788);
            this.chartControlWheel.TabIndex = 2;
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrow.ForeColor = System.Drawing.Color.White;
            this.labelArrow.Image = ((System.Drawing.Image)(resources.GetObject("labelArrow.Image")));
            this.labelArrow.Location = new System.Drawing.Point(827, 5);
            this.labelArrow.Margin = new System.Windows.Forms.Padding(0);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(35, 788);
            this.labelArrow.TabIndex = 0;
            this.labelArrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhasmoSpinWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PhasmoSpinWheel";
            this.Size = new System.Drawing.Size(867, 798);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlWheel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelArrow;
        private DevExpress.XtraCharts.ChartControl chartControlWheel;
    }
}

