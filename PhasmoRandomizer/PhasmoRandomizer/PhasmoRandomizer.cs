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
        public PhasmoRandomizer()
        {
            InitializeComponent();
            CreateDefaultConfig();
            rolledItemDictionary = new Dictionary<string, List<string>>();
            rolledItemList = new List<RolledItem>();
            currentPlayerItemRolls = new List<string>();
            LoadJsonConfig();
            if (config != null)
            {
                currentItemRerollCnt = config.MaxItemRerolls;
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
        private void buttonRollPlayers_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                rolledPlayerCount = rng.Next(config.MinPlayerCount, config.MaxPlayerCount + 1);
                labelPlayerCount.Text = "Players: "+rolledPlayerCount;
                buttonRollPlayers.Visible = false;
                tabPageMap.Enabled = true;
                tabControlMain.Refresh();
            }
        }

        private void buttonRollMap_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                rolledMap = config.AvailableMaps[rng.Next(1, config.AvailableMaps.Count + 1) - 1];
                labelMap.Text = "Map: "+ rolledMap;
                buttonRollMap.Visible = false;
                tabPageItem.Enabled = true;
                tabControlMain.Refresh();
            }
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
                item.Id = rolledItemList.Count;
                item.Player = config.PlayerNames[currentRollingPlayer - 1];
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
                string rolledItemName = currentItemPool[rng.Next(1, currentItemPool.Count + 1) - 1];

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
                dataGridView1.Refresh();
            } while (keepRolling);
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
                    
                    rerolledItem.Item = currentItemPool[rng.Next(1, currentItemPool.Count + 1) - 1];
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
                    clipBoardText += "Players: " + rolledPlayerCount + "\n";
                    clipBoardText += "Map: " + rolledMap + "\n";
                    clipBoardText += "Items:\n";
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
            buttonReroll.Enabled = item != null && currentItemRerollCnt > 0;
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
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            LoadJsonConfig();
            if (config != null)
            {
                rolledItemDictionary.Clear();
                tabControlMain.SelectedTab = tabPagePlayers;
                buttonRollAll.Text = "Roll all";
                textBoxMaxItems.ReadOnly = false;
                tabPageMap.Enabled = false;
                itemRollsCompleted = false;
                tabPageItem.Enabled = false;
                rolledItemList.Clear();
                itemPool = new Dictionary<string, int>(config.AvailableItems);
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
            defaultConfig.AvailableMaps = new List<string>
            {
                "Tanglewood",
                "Edgefield",
                "Ridgeview",
                "Grafton",
                "Bleadsdale",
                "High school",
                "Asylum"
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
        }
        #endregion
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
        public List<string> AvailableMaps;
        public Dictionary<string, int> AvailableItems;
        public List<string> PlayerNames;
        public bool PlayerCanHaveDoubleItems;
    }
}
