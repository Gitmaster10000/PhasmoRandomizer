using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PhasmoRandomizer
{
    public partial class PhasmoRandomizer : Form
    {
        private int MAX_ITEMS_PER_PLAYER = 3;
        private Configuration config;
        private Configuration defaultConfig;
        private int rolledPlayerCount = 1;
        private string rolledMap = "";
        private int currentRollingPlayer = 1;
        private int currentRolledItemCount = 0;
        private int currentItemRerollCnt = 0;
        private Random rng = new Random();
        private List<RolledItem> rolledItemList;
        private Dictionary<string, int> itemPool;
        private List<string> currentPlayerItemRolls;
        private Dictionary<string, List<string>> rolledItemDictionary;
        private bool itemRollsCompleted;
        private bool wheelIsSpinning;
        public PhasmoRandomizer()
        {
            InitializeComponent();
            dataGridView1.AutoSize = true;
            CreateDefaultConfig();
            rolledItemDictionary = new Dictionary<string, List<string>>();
            rolledItemList = new List<RolledItem>();
            currentPlayerItemRolls = new List<string>();
            LoadJsonConfig();
            if (config != null)
            {
                currentItemRerollCnt = config.MaxItemRerolls;
                rolledPlayerCount = config.MinPlayerCount; //initialize rolledPlayers with the min to prevent bugs
                buttonReroll.Text = "Roll selected item again (" + currentItemRerollCnt + ")";
                if (currentItemRerollCnt > 0)
                {
                    buttonReroll.Enabled = true;
                }
            }
            itemPool = new Dictionary<string, int>(config.AvailableItems);
            tabPageMap.Enabled = false;
            tabPageItem.Enabled = false;
            itemRollsCompleted = false;
            BringToFront();
            CenterToScreen();
            playerWheel.WheelHasStopped -= PlayerWheel_WheelHasStopped;
            playerWheel.WheelHasStopped += PlayerWheel_WheelHasStopped;
            mapWheel.WheelHasStopped -= MapWheel_WheelHasStopped;
            mapWheel.WheelHasStopped += MapWheel_WheelHasStopped;
            itemWheel.WheelHasStopped -= ItemWheel_WheelHasStopped;
            itemWheel.WheelHasStopped += ItemWheel_WheelHasStopped;
            if (config.SpinningWheel)
            {
                if (config.MinPlayerCount != config.MaxPlayerCount)
                {
                    DrawPlayerWheel();
                    labelPlayerCount.Visible = false;
                    playerWheel.Visible = true;
                }
                else
                {
                    tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.Percent;
                    tableLayoutPanel7.ColumnStyles[0].Width = 100F;
                    labelPlayerCount.Size = tableLayoutPanel7.Size;
                }
                labelMap.Visible = false;
                mapWheel.Visible = true;
                DrawMapWheel();
            }
            else
            {
                tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel7.ColumnStyles[0].Width = 100F;
                labelPlayerCount.Size = tableLayoutPanel7.Size;
                tableLayoutPanel8.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel8.ColumnStyles[0].Width = 100F;
                labelMap.Size = tableLayoutPanel8.Size;
            }

            if (config.MinPlayerCount == config.MaxPlayerCount)
            {
                labelPlayerCount.Text = "Players: " + config.MinPlayerCount;
                rolledPlayerCount = config.MinPlayerCount;
                buttonRollPlayers.Visible = false;
                tabPageMap.Enabled = true;
                tabPageItem.Enabled = true;
                tabControlMain.Refresh();
            }

            if (dataGridView1.Visible)
            {
                dataGridView1.Size = tableLayoutPanel9.Size;
            }
        }

        #region wheel stuff
        private void DrawPlayerWheel()
        {
            int min = config.MinPlayerCount < 1 ? 1 : config.MinPlayerCount;
            int max = config.MaxPlayerCount < config.MinPlayerCount ? config.MinPlayerCount : config.MaxPlayerCount;
            List<string> playerList = new List<string>();
            for (int i = min; i <= max; i++)
            {
                playerList.Add("" + i);
            }
            playerWheel.SetWheelData(playerList, 30f);
        }

        private void DrawMapWheel()
        {
            List<string> mapPool = config.AvailableMaps.Keys.Where(x => config.AvailableMaps[x]).ToList();
            mapWheel.SetWheelData(mapPool, 17.5f);
        }
        private void PlayerWheel_WheelHasStopped(object sender, EventArgs e)
        {
            buttonNew.Enabled = true;
            playerWheel.Visible = false;
            labelPlayerCount.Visible = true;
            wheelIsSpinning = false;
            tableLayoutPanel7.GetColumn(labelPlayerCount);
            tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel7.ColumnStyles[0].Width = 100F;
            labelPlayerCount.Size = tableLayoutPanel7.Size;
        }
        private void MapWheel_WheelHasStopped(object sender, EventArgs e)
        {
            buttonNew.Enabled = true;
            mapWheel.Visible = false;
            labelMap.Visible = true;
            wheelIsSpinning = false;
            tableLayoutPanel8.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel8.ColumnStyles[0].Width = 100F;
            labelMap.Size = tableLayoutPanel8.Size;
        }
        private void ItemWheel_WheelHasStopped(object sender, EventArgs e)
        {
            buttonNew.Enabled = true;
            itemWheel.Visible = false;
            dataGridView1.Visible = true;
            buttonRollItems.Enabled = true;
            buttonRollAll.Enabled = true;
            buttonReroll.Enabled = currentItemRerollCnt > 0;
            dataGridView1.Size = tableLayoutPanel9.Size;
            wheelIsSpinning = false;
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void textBoxMaxItems_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MAX_ITEMS_PER_PLAYER = Convert.ToInt32(textBoxMaxItems.Text);
            }
            catch
            {
                textBoxMaxItems.Text = "3";
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            PhasmoConfigDialog configDialog = new PhasmoConfigDialog(config);
            if (configDialog.ShowConfigDialog() == DialogResult.OK)
            {
                config = configDialog.GetConfiguration();
            }
        }
        private void buttonRollPlayers_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                int min = config.MinPlayerCount < 1 ? 1 : config.MinPlayerCount;
                int max = config.MaxPlayerCount < config.MinPlayerCount ? config.MinPlayerCount : config.MaxPlayerCount;
                rolledPlayerCount = rng.Next(min, max + 1);
                if (config.SpinningWheel && playerWheel.IsReady)
                {
                    buttonNew.Enabled = false;
                    playerWheel.Spin(rolledPlayerCount - 1);
                }
                labelPlayerCount.Text = "Players: "+rolledPlayerCount;
                buttonRollPlayers.Visible = false;
                tabPageMap.Enabled = true;
                tabPageItem.Enabled = true;
                tabControlMain.Refresh();
                dataGridView1.Refresh();
            }
        }

        private void buttonRollMap_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                List<string> mapPool = config.AvailableMaps.Keys.Where(x => config.AvailableMaps[x]).ToList();
                if (mapPool.Count > 0)
                {
                    int roll = rng.Next(1, mapPool.Count + 1) - 1;
                    rolledMap = mapPool[roll];
                    if (config.SpinningWheel && mapWheel.IsReady)
                    {
                        buttonNew.Enabled = false;
                        mapWheel.Spin(roll);
                    }
                    labelMap.Text = "Map: " + rolledMap;
                    buttonRollMap.Visible = false;
                    tabControlMain.Refresh();
                }
                else
                {
                    labelMap.Text = "No map available in config!";
                }
            }
        }

        private void DrawItemWheel(List<string> data)
        {
            itemWheel.SetWheelData(data);
        }

        private void RollItems(bool keepRolling)
        {
            do
            {
                if (currentRolledItemCount <= 0)
                {
                    currentPlayerItemRolls.Clear();
                }
                RolledItem item = new RolledItem();
                textBoxMaxItems.ReadOnly = true;
                textBoxMaxItems.Enabled = false;
                item.Id = rolledItemList.Count;
                if (currentRollingPlayer <= config.PlayerNames.Count)
                {
                    item.Player = config.PlayerNames[currentRollingPlayer - 1];
                }
                else
                {
                    item.Player = "Player " + currentRollingPlayer;
                }
                List<string> currentItemPool = new List<string>(itemPool.Keys.ToList());
                if (!config.PlayerCanHaveDoubleItems)
                {
                    foreach (var iRoll in currentPlayerItemRolls)
                    {
                        if (currentItemPool.Contains(iRoll))
                        {
                            currentItemPool.Remove(iRoll);
                        }
                    }
                }

                if (currentItemPool.Count <= 0)
                {
                    buttonRollItems.Visible = false;
                    buttonRollAll.Text = "Clipboard";
                    itemRollsCompleted = true;
                    return;
                }
                
                int roll = rng.Next(1, currentItemPool.Count + 1) - 1;
                string rolledItemName = currentItemPool[roll];
                if (config.SpinningWheel && !keepRolling)
                {
                    buttonNew.Enabled = false;
                    wheelIsSpinning = true;
                    buttonRollItems.Enabled = false;
                    buttonRollAll.Enabled = false;
                    buttonReroll.Enabled = false;
                    dataGridView1.Visible = false;
                    itemWheel.Visible = true;
                    DrawItemWheel(currentItemPool);
                    itemWheel.Spin(roll, 1500);
                }
                itemPool[rolledItemName] -= 1;
                if (itemPool[rolledItemName] <= 0)
                {
                    itemPool.Remove(rolledItemName);
                }

                item.Item = rolledItemName;
                currentPlayerItemRolls.Add(rolledItemName);
                if (!rolledItemDictionary.ContainsKey(item.Player))
                {
                    rolledItemDictionary.Add(item.Player, new List<string>(currentPlayerItemRolls));
                }
                else
                {
                    rolledItemDictionary[item.Player] = new List<string>(currentPlayerItemRolls);
                }
                currentRolledItemCount++;
                if (currentRolledItemCount >= MAX_ITEMS_PER_PLAYER)
                {
                    currentRollingPlayer++;
                    currentRolledItemCount = 0;
                }

                if (currentRollingPlayer > rolledPlayerCount)
                {
                    buttonRollItems.Visible = false;
                    buttonRollAll.Text = "Clipboard";
                    keepRolling = false;
                    itemRollsCompleted = true;
                }
                rolledItemList.Add(item);
                dataGridView1.DataSource = rolledItemList.ToArray();
                try
                {
                    //try selecting last row
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Selected = true;
                }
                catch
                {
                    //selection failed, just ignore it :D
                }

            } while (keepRolling);
            if (dataGridView1.Visible)
            {
                dataGridView1.Size = tableLayoutPanel9.Size;
            }
        }
        private void buttonReroll_Click(object sender, EventArgs e)
        {
            if (currentItemRerollCnt > 0)
            {
                RolledItem item = dataGridView1.CurrentRow.DataBoundItem as RolledItem;
                if (item != null)
                {
                    RolledItem rerolledItem = new RolledItem();
                    rerolledItem.Id = item.GetId();
                    rerolledItem.Player = item.Player;
                    rolledItemList.Remove(item);
                    List<string> currentItemPool = new List<string>(itemPool.Keys.ToList());
                    if (!config.PlayerCanHaveDoubleItems)
                    {
                        //remove items the player already has if
                        foreach (var iRoll in rolledItemDictionary[item.Player])
                        {
                            if (currentItemPool.Contains(iRoll))
                            {
                                currentItemPool.Remove(iRoll);
                            }
                        }
                    }
                    else
                    {
                        //remove the current rerolled item from the pool so you can't reroll to the same item
                        if (currentItemPool.Contains(item.Item))
                        {
                            currentItemPool.Remove(item.Item);
                        }
                    }

                    int roll = rng.Next(1, currentItemPool.Count + 1) - 1;
                    rerolledItem.Item = currentItemPool[roll];
                    if (config.SpinningWheel)
                    {
                        buttonNew.Enabled = false;
                        wheelIsSpinning = true;
                        buttonRollItems.Enabled = false;
                        buttonRollAll.Enabled = false;
                        buttonReroll.Enabled = false;
                        dataGridView1.Visible = false;
                        itemWheel.Visible = true;
                        DrawItemWheel(currentItemPool);
                        itemWheel.Spin(roll, 1500);
                    }
                    itemPool[rerolledItem.Item] -= 1;
                    if (itemPool[rerolledItem.Item] <= 0)
                    {
                        itemPool.Remove(rerolledItem.Item);
                    }
                    //update the rolledItemDictionary
                    rolledItemDictionary[item.Player].Add(rerolledItem.Item);
                    rolledItemDictionary[item.Player].Remove(item.Item);

                    currentItemRerollCnt -= 1;
                    buttonReroll.Text = "Roll selected item again (" + currentItemRerollCnt + ")";
                    rolledItemList.Add(rerolledItem);
                    rolledItemList.Sort();
                    int selectedRowIndex = dataGridView1.CurrentRow.Index; 
                    dataGridView1.DataSource = rolledItemList.ToArray();
                    dataGridView1.Rows[selectedRowIndex].Selected = true;
                    dataGridView1.Rows[selectedRowIndex].Cells[0].Selected = true;
                    dataGridView1.Refresh();
                    if (currentItemRerollCnt <= 0)
                    {
                        buttonReroll.Enabled = false;
                        buttonReroll.Visible = false;
                    }
                }
            }
        }
        private void buttonRollItems_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                RollItems(false);
            }
        }
        private void buttonRollAll_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                if (!itemRollsCompleted)
                {
                    //roll function
                    RollItems(true);
                }
                else
                {
                    //copy to clipboard function
                    string clipBoardText = string.Empty;
                    foreach (var item in rolledItemList)
                    {
                        clipBoardText += item.Player + ": " + item.Item+"\n";
                    }
                    Clipboard.SetText(clipBoardText);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            RolledItem item = dataGridView1.CurrentRow.DataBoundItem as RolledItem;
            buttonReroll.Enabled = !wheelIsSpinning && item != null && currentItemRerollCnt > 0;
        }

        public void LoadJsonConfig()
        {

            StreamReader r = null;
            try
            {
                r = new StreamReader("PhasmoSettings.json");
            }
            catch
            {
                OpenFileDialog openConfigFile = new OpenFileDialog();
                openConfigFile.Multiselect = false;
                openConfigFile.Filter = "(*.json)|*.json";
                openConfigFile.Title = "Please open the PhasmoSettings.json file in order to use the randomizer!";
                if (openConfigFile.ShowDialog() == DialogResult.OK)
                {
                    r = new StreamReader(openConfigFile.OpenFile());
                }
            }

            if (r != null)
            {
                try
                {
                    string json = r.ReadToEnd();
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    config = jss.Deserialize<Configuration>(json);
                }
                catch
                {
                    config = defaultConfig;
                    throw new Exception(
                        "Config file not found.\nPlease make sure to locate the PhasmoSettings.json in the same folder as the .exe file!\nYou can press continue and the default config will be used.");
                }
            }
            else
            {
                config = defaultConfig;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //LoadJsonConfig();
            if (config != null)
            {
                rolledItemDictionary.Clear();
                tabControlMain.SelectedTab = tabPagePlayers;
                buttonRollAll.Text = "Roll all";
                textBoxMaxItems.ReadOnly = false;
                textBoxMaxItems.Enabled = true;
                tabPageMap.Enabled = false;
                itemRollsCompleted = false;
                tabPageItem.Enabled = false;
                rolledItemList.Clear();
                itemPool.Clear();
                foreach (var item in config.AvailableItems)
                {
                    if (item.Value > 0)
                    {
                        itemPool.Add(item.Key,item.Value);
                    }    
                }
                labelPlayerCount.Text = string.Empty;
                labelMap.Text = string.Empty;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                currentRollingPlayer = 1;
                currentRolledItemCount = 0;
                buttonRollPlayers.Visible = true;
                buttonRollMap.Visible = true;
                buttonRollItems.Visible = true;
                buttonRollAll.Visible = true;
                tabControlMain.Refresh();
                currentItemRerollCnt = config.MaxItemRerolls;
                buttonReroll.Text = "Roll selected item again (" + currentItemRerollCnt + ")";
                if (currentItemRerollCnt > 0)
                {
                    buttonReroll.Enabled = true;
                    buttonReroll.Visible = true;
                }

                if (config.MinPlayerCount == config.MaxPlayerCount)
                {
                    labelPlayerCount.Text = "Players: " + config.MinPlayerCount;
                    rolledPlayerCount = config.MinPlayerCount;
                    buttonRollPlayers.Visible = false;
                    tabPageMap.Enabled = true;
                    tabPageItem.Enabled = true;
                    tabControlMain.Refresh();
                }
                if (config.SpinningWheel)
                {
                    if (config.MinPlayerCount != config.MaxPlayerCount)
                    {
                        DrawPlayerWheel();
                        labelPlayerCount.Visible = false;
                        playerWheel.Visible = true;
                        tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.AutoSize;
                        tableLayoutPanel7.ColumnStyles[0].Width = 0;
                    }
                    else
                    {
                        tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.Percent;
                        tableLayoutPanel7.ColumnStyles[0].Width = 100F;
                        labelPlayerCount.Size = tableLayoutPanel7.Size;
                        labelPlayerCount.Visible = true;
                        playerWheel.Visible = false;
                    }
                    labelMap.Visible = false;
                    mapWheel.Visible = true;
                    DrawMapWheel();
                    tableLayoutPanel8.ColumnStyles[0].SizeType = SizeType.AutoSize;
                    tableLayoutPanel8.ColumnStyles[0].Width = 0;
                }
                else
                {
                    tableLayoutPanel7.ColumnStyles[0].SizeType = SizeType.Percent;
                    tableLayoutPanel7.ColumnStyles[0].Width = 100F;
                    labelPlayerCount.Size = tableLayoutPanel7.Size;
                    tableLayoutPanel8.ColumnStyles[0].SizeType = SizeType.Percent;
                    tableLayoutPanel8.ColumnStyles[0].Width = 100F;
                    labelMap.Size = tableLayoutPanel8.Size;
                }
                dataGridView1.Refresh();
            }
        }

        private void tabControlMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled) e.Cancel = true;
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tp = tabControlMain.TabPages[e.Index];
            using (SolidBrush brush =
                new SolidBrush(Color.LightGray))
            using (SolidBrush textBrush =
                new SolidBrush(tp.Enabled ? Color.Black : Color.Gray))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(tp.Text, e.Font, textBrush, e.Bounds.X + 3, e.Bounds.Y + 4);
            }
        }

        #region default config
        private void CreateDefaultConfig()
        {
            defaultConfig = new Configuration();
            defaultConfig.MinPlayerCount = 1;
            defaultConfig.MaxPlayerCount = 4;
            defaultConfig.MaxItemRerolls = 3;
            defaultConfig.PlayerCanHaveDoubleItems = false;
            defaultConfig.AvailableMaps = new Dictionary<string, bool>
            {
                {"Tanglewood",true},
                {"Edgefield",true},
                {"Ridgeview",true},
                {"Grafton",true},
                {"Bleasdale",true},
                {"High school",true},
                {"Asylum",true}
            };
            defaultConfig.AvailableItems = new Dictionary<string, int>
            {
                {"Flashlight", 4},
                {"EMF Reader", 2},
                {"Photo Camera", 3},
                {"Lighter", 2},
                { "Candle", 4},
                {"UV Light", 2},
                {"Crucifix", 2},
                {"Video Camera", 6},
                {"Spirit Box", 2},
                {"Salt", 2},
                {"Smudge Sticks", 4},
                {"Strong Flashlight", 4},
                {"Thermometer", 3},
                {"Sanity Pills", 4},
                {"Ghost Writing Book", 2},
                {"Glowstick", 2},
                {"Tripod", 5},
                {"Motion Sensor", 4},
                {"Sound Sensor", 4},
                {"Infrared Light Sensor", 4},
                {"Parabolic Microphone", 2},
                {"Head-Mounted Camera", 4}
            };
            defaultConfig.PlayerNames = new List<string>
            {
                "Player 1",
                "Player 2",
                "Player 3",
                "Player 4"
            };
            defaultConfig.SpinningWheel = true;
        }
        #endregion

        private void PhasmoRandomizer_ResizeEnd(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void PhasmoRandomizer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if(tabControlMain.SelectedTab == tabPageItem && buttonRollItems.Enabled && !wheelIsSpinning)
                {
                    buttonRollItems.PerformClick();
                }
            }
        }
    }
    public class RolledItem : IComparable
    {
        public int Id { private get; set; }
        public string Player { get; set; }
        public string Item { get; set; }
        public int GetId()
        {
            return Id;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            // throws exception if type is wrong
            RolledItem other = (RolledItem)obj;
            return Id.CompareTo(other.Id);
        }

        #endregion
    }

    [Serializable]
    public class Configuration
    {
        public int MinPlayerCount;
        public int MaxPlayerCount;
        public int MaxItemRerolls;
        public Dictionary<string, bool> AvailableMaps;
        public Dictionary<string, int> AvailableItems;
        public List<string> PlayerNames;
        public bool PlayerCanHaveDoubleItems;
        public bool SpinningWheel;
    }
}
