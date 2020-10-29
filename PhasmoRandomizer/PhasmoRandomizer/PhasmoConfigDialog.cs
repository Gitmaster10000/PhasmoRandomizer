using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PhasmoRandomizer
{
    public partial class PhasmoConfigDialog : Form
    {
        private const string MIN_PLAYER_COUNT = "MinPlayerCount";
        private const string MAX_PLAYER_COUNT = "MaxPlayerCount";
        private const string MAX_ITEM_REROLLS = "MaxItemRerolls";
        private Configuration config;
        private BindingList<MapConfig> loadedMapConfig;
        private BindingList<ItemConfig> loadedItemConfig;
        private BindingList<GeneralConfig> loadedGeneralConfig;
        private GeneralConfig minPlayerConfig = new GeneralConfig();
        private GeneralConfig maxPlayerConfig = new GeneralConfig();
        private GeneralConfig maxRerolls = new GeneralConfig();
        public PhasmoConfigDialog(Configuration c)
        {
            InitializeComponent();
            loadedMapConfig = new BindingList<MapConfig>();
            loadedItemConfig = new BindingList<ItemConfig>();
            loadedGeneralConfig = new BindingList<GeneralConfig>();
            config = c;
            FillGridsWithData();
            BringToFront();
            CenterToScreen();
        }

        public DialogResult ShowConfigDialog()
        {
            if (config != null)
            {
                return ShowDialog();
            }
            return DialogResult.Cancel;
        }

        private void FillGridsWithData()
        {
            loadedMapConfig.Clear();
            loadedItemConfig.Clear();
            loadedGeneralConfig.Clear();
            minPlayerConfig = new GeneralConfig();
            minPlayerConfig.SetName(MIN_PLAYER_COUNT);
            minPlayerConfig.Count = config.MinPlayerCount;
            maxPlayerConfig = new GeneralConfig();
            maxPlayerConfig.SetName(MAX_PLAYER_COUNT);
            maxPlayerConfig.Count = config.MaxPlayerCount;
            maxRerolls = new GeneralConfig();
            maxRerolls.SetName(MAX_ITEM_REROLLS);
            maxRerolls.Count = config.MaxItemRerolls;
            loadedGeneralConfig.Add(minPlayerConfig);
            loadedGeneralConfig.Add(maxPlayerConfig);
            loadedGeneralConfig.Add(maxRerolls);
            dataGridViewGeneral.DataSource = loadedGeneralConfig;
            foreach (var map in config.AvailableMaps)
            {
                MapConfig newMapConfig = new MapConfig();
                newMapConfig.SetMapName(map.Key);
                newMapConfig.Enabled = map.Value;
                loadedMapConfig.Add(newMapConfig);
            }
            dataGridViewMaps.DataSource = loadedMapConfig;
            foreach (var item in config.AvailableItems)
            {
                ItemConfig newItemConfig = new ItemConfig();
                newItemConfig.SetItemName(item.Key);
                newItemConfig.Amount = item.Value;
                loadedItemConfig.Add(newItemConfig);
            }
            dataGridViewItems.DataSource = loadedItemConfig;
        }

        public Configuration GetConfiguration()
        {
            config.MinPlayerCount = minPlayerConfig.Count;
            config.MaxPlayerCount = maxPlayerConfig.Count;
            config.MaxItemRerolls = maxRerolls.Count;
            foreach (var map in loadedMapConfig)
            {
                config.AvailableMaps[map.Name] = map.Enabled;
            }
            foreach (var item in loadedItemConfig)
            {
                config.AvailableItems[item.Name] = item.Amount;
            }
            return config;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            StreamReader r = null;
            OpenFileDialog openConfigFile = new OpenFileDialog();
            openConfigFile.Multiselect = false;
            openConfigFile.Filter = "(*.json)|*.json";
            openConfigFile.Title = "Please open a PhasmoSettings.json file!";
            if (openConfigFile.ShowDialog() == DialogResult.OK)
            {
                r = new StreamReader(openConfigFile.OpenFile());
            }

            if (r != null)
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                config = jss.Deserialize<Configuration>(json);
                FillGridsWithData();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (config != null)
            {
                SaveFileDialog saveConfigFile = new SaveFileDialog();
                saveConfigFile.FileName = "PhasmoSettings.json";
                saveConfigFile.Filter = "(*.json)|*.json";
                if (saveConfigFile.ShowDialog() == DialogResult.OK)
                {
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    var json = jss.Serialize(GetConfiguration());
                    string json_pretty = JSON_PrettyPrinter.Process(json);
                    System.IO.FileStream fs =
                        (System.IO.FileStream)saveConfigFile.OpenFile();
                    byte[] data = new UTF8Encoding(true).GetBytes(json_pretty);
                    fs.Write(data, 0 ,data.Length);
                    fs.Close();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridViewItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    int testAmount = Convert.ToInt32(e.FormattedValue);
                }
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewGeneral_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    int testAmount = Convert.ToInt32(e.FormattedValue);
                }
            }
            catch
            {
                e.Cancel = true;
            }
        }
    }
    public class GeneralConfig
    {
        public string Name { get; private set; }
        public int Count { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    public class MapConfig
    {
        public string Name { get; private set; }
        public bool Enabled { get; set; }

        public void SetMapName(string name)
        {
            Name = name;
        }
    }

    public class ItemConfig
    {
        public string Name { get; private set; }
        public int Amount { get; set; }

        public void SetItemName(string name)
        {
            Name = name;
        }
    }

    public class JSON_PrettyPrinter
    {
        public static string Process(string inputText)
        {
            bool escaped = false;
            bool inquotes = false;
            int column = 0;
            int indentation = 0;
            Stack<int> indentations = new Stack<int>();
            int TABBING = 8;
            StringBuilder sb = new StringBuilder();
            foreach (char x in inputText)
            {
                sb.Append(x);
                column++;
                if (escaped)
                {
                    escaped = false;
                }
                else
                {
                    if (x == '\\')
                    {
                        escaped = true;
                    }
                    else if (x == '\"')
                    {
                        inquotes = !inquotes;
                    }
                    else if (!inquotes)
                    {
                        if (x == ',')
                        {
                            // if we see a comma, go to next line, and indent to the same depth
                            sb.Append("\r\n");
                            column = 0;
                            for (int i = 0; i < indentation; i++)
                            {
                                sb.Append(" ");
                                column++;
                            }
                        }
                        else if (x == '[' || x == '{')
                        {
                            // if we open a bracket or brace, indent further (push on stack)
                            indentations.Push(indentation);
                            indentation = column;
                        }
                        else if (x == ']' || x == '}')
                        {
                            // if we close a bracket or brace, undo one level of indent (pop)
                            indentation = indentations.Pop();
                        }
                        else if (x == ':')
                        {
                            // if we see a colon, add spaces until we get to the next
                            // tab stop, but without using tab characters!
                            while ((column % TABBING) != 0)
                            {
                                sb.Append(' ');
                                column++;
                            }
                        }
                    }
                }
            }
            return sb.ToString();
        }

    }
}
