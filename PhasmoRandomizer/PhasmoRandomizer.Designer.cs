namespace PhasmoRandomizer
{
    partial class PhasmoRandomizer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhasmoRandomizer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRollPlayers = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlayerCount = new System.Windows.Forms.Label();
            this.playerWheel = new PhasmoSpinWheel();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRollMap = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.mapWheel = new PhasmoSpinWheel();
            this.labelMap = new System.Windows.Forms.Label();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRollItems = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxItems = new System.Windows.Forms.Label();
            this.textBoxMaxItems = new System.Windows.Forms.TextBox();
            this.buttonRollAll = new System.Windows.Forms.Button();
            this.buttonReroll = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.itemWheel = new PhasmoSpinWheel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 1344);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePlayers);
            this.tabControlMain.Controls.Add(this.tabPageMap);
            this.tabControlMain.Controls.Add(this.tabPageItem);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 82);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(970, 1249);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlMain_Selecting);
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.BackColor = System.Drawing.Color.Black;
            this.tabPagePlayers.Controls.Add(this.tableLayoutPanel2);
            this.tabPagePlayers.ForeColor = System.Drawing.Color.Black;
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 41);
            this.tabPagePlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePlayers.Size = new System.Drawing.Size(962, 1204);
            this.tabPagePlayers.TabIndex = 0;
            this.tabPagePlayers.Text = "Players";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.buttonRollPlayers, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 1194);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonRollPlayers
            // 
            this.buttonRollPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollPlayers.FlatAppearance.BorderSize = 2;
            this.buttonRollPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollPlayers.ForeColor = System.Drawing.Color.Lime;
            this.buttonRollPlayers.Location = new System.Drawing.Point(19, 20);
            this.buttonRollPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRollPlayers.Name = "buttonRollPlayers";
            this.buttonRollPlayers.Size = new System.Drawing.Size(916, 51);
            this.buttonRollPlayers.TabIndex = 1;
            this.buttonRollPlayers.Text = "Roll";
            this.buttonRollPlayers.UseVisualStyleBackColor = true;
            this.buttonRollPlayers.Click += new System.EventHandler(this.buttonRollPlayers_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.labelPlayerCount, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.playerWheel, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(19, 81);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(916, 1093);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // labelPlayerCount
            // 
            this.labelPlayerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerCount.AutoSize = true;
            this.labelPlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerCount.ForeColor = System.Drawing.Color.White;
            this.labelPlayerCount.Location = new System.Drawing.Point(4, 0);
            this.labelPlayerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerCount.Name = "labelPlayerCount";
            this.labelPlayerCount.Size = new System.Drawing.Size(1, 1093);
            this.labelPlayerCount.TabIndex = 0;
            this.labelPlayerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerWheel
            // 
            this.playerWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerWheel.AutoSize = true;
            this.playerWheel.BackColor = System.Drawing.Color.Black;
            this.playerWheel.ForeColor = System.Drawing.Color.White;
            this.playerWheel.Location = new System.Drawing.Point(14, 6);
            this.playerWheel.Margin = new System.Windows.Forms.Padding(6);
            this.playerWheel.Name = "playerWheel";
            this.playerWheel.Size = new System.Drawing.Size(896, 1081);
            this.playerWheel.TabIndex = 1;
            this.playerWheel.Visible = false;
            // 
            // tabPageMap
            // 
            this.tabPageMap.BackColor = System.Drawing.Color.Black;
            this.tabPageMap.Controls.Add(this.tableLayoutPanel3);
            this.tabPageMap.ForeColor = System.Drawing.Color.Black;
            this.tabPageMap.Location = new System.Drawing.Point(4, 41);
            this.tabPageMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMap.Size = new System.Drawing.Size(962, 1204);
            this.tabPageMap.TabIndex = 1;
            this.tabPageMap.Text = "Map";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Controls.Add(this.buttonRollMap, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 1194);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonRollMap
            // 
            this.buttonRollMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollMap.FlatAppearance.BorderSize = 2;
            this.buttonRollMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollMap.ForeColor = System.Drawing.Color.Lime;
            this.buttonRollMap.Location = new System.Drawing.Point(19, 20);
            this.buttonRollMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRollMap.Name = "buttonRollMap";
            this.buttonRollMap.Size = new System.Drawing.Size(916, 51);
            this.buttonRollMap.TabIndex = 1;
            this.buttonRollMap.Text = "Roll";
            this.buttonRollMap.UseVisualStyleBackColor = true;
            this.buttonRollMap.Click += new System.EventHandler(this.buttonRollMap_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.mapWheel, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelMap, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(19, 81);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(916, 1093);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // mapWheel
            // 
            this.mapWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapWheel.AutoSize = true;
            this.mapWheel.BackColor = System.Drawing.Color.Black;
            this.mapWheel.ForeColor = System.Drawing.Color.White;
            this.mapWheel.Location = new System.Drawing.Point(14, 6);
            this.mapWheel.Margin = new System.Windows.Forms.Padding(6);
            this.mapWheel.Name = "mapWheel";
            this.mapWheel.Size = new System.Drawing.Size(896, 1081);
            this.mapWheel.TabIndex = 1;
            this.mapWheel.Visible = false;
            // 
            // labelMap
            // 
            this.labelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.ForeColor = System.Drawing.Color.White;
            this.labelMap.Location = new System.Drawing.Point(4, 0);
            this.labelMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(1, 1093);
            this.labelMap.TabIndex = 0;
            this.labelMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageItem
            // 
            this.tabPageItem.BackColor = System.Drawing.Color.Black;
            this.tabPageItem.Controls.Add(this.tableLayoutPanel4);
            this.tabPageItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageItem.ForeColor = System.Drawing.Color.Black;
            this.tabPageItem.Location = new System.Drawing.Point(4, 41);
            this.tabPageItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageItem.Size = new System.Drawing.Size(962, 1204);
            this.tabPageItem.TabIndex = 2;
            this.tabPageItem.Text = "Items";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.Controls.Add(this.buttonRollItems, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.buttonReroll, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(954, 1194);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonRollItems
            // 
            this.buttonRollItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollItems.FlatAppearance.BorderSize = 2;
            this.buttonRollItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollItems.ForeColor = System.Drawing.Color.Lime;
            this.buttonRollItems.Location = new System.Drawing.Point(19, 20);
            this.buttonRollItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRollItems.Name = "buttonRollItems";
            this.buttonRollItems.Size = new System.Drawing.Size(916, 60);
            this.buttonRollItems.TabIndex = 1;
            this.buttonRollItems.Text = "Roll";
            this.buttonRollItems.UseVisualStyleBackColor = true;
            this.buttonRollItems.Click += new System.EventHandler(this.buttonRollItems_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.labelMaxItems, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMaxItems, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonRollAll, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 85);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(924, 60);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // labelMaxItems
            // 
            this.labelMaxItems.AutoSize = true;
            this.labelMaxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxItems.ForeColor = System.Drawing.Color.White;
            this.labelMaxItems.Location = new System.Drawing.Point(4, 0);
            this.labelMaxItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxItems.Name = "labelMaxItems";
            this.labelMaxItems.Size = new System.Drawing.Size(454, 60);
            this.labelMaxItems.TabIndex = 0;
            this.labelMaxItems.Text = "Max items per player";
            this.labelMaxItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMaxItems
            // 
            this.textBoxMaxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxItems.Location = new System.Drawing.Point(466, 8);
            this.textBoxMaxItems.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.textBoxMaxItems.MaxLength = 2;
            this.textBoxMaxItems.Name = "textBoxMaxItems";
            this.textBoxMaxItems.Size = new System.Drawing.Size(223, 39);
            this.textBoxMaxItems.TabIndex = 1;
            this.textBoxMaxItems.Text = "3";
            this.textBoxMaxItems.TextChanged += new System.EventHandler(this.textBoxMaxItems_TextChanged);
            // 
            // buttonRollAll
            // 
            this.buttonRollAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRollAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollAll.ForeColor = System.Drawing.Color.Lime;
            this.buttonRollAll.Location = new System.Drawing.Point(697, 5);
            this.buttonRollAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRollAll.Name = "buttonRollAll";
            this.buttonRollAll.Size = new System.Drawing.Size(223, 50);
            this.buttonRollAll.TabIndex = 2;
            this.buttonRollAll.Text = "Roll all";
            this.buttonRollAll.UseVisualStyleBackColor = true;
            this.buttonRollAll.Click += new System.EventHandler(this.buttonRollAll_Click);
            // 
            // buttonReroll
            // 
            this.buttonReroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReroll.Enabled = false;
            this.buttonReroll.FlatAppearance.BorderSize = 2;
            this.buttonReroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReroll.ForeColor = System.Drawing.Color.Lime;
            this.buttonReroll.Location = new System.Drawing.Point(19, 1114);
            this.buttonReroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReroll.Name = "buttonReroll";
            this.buttonReroll.Size = new System.Drawing.Size(916, 60);
            this.buttonReroll.TabIndex = 4;
            this.buttonReroll.Text = "Roll selected item again (5)";
            this.buttonReroll.UseVisualStyleBackColor = true;
            this.buttonReroll.Click += new System.EventHandler(this.buttonReroll_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.itemWheel, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(15, 145);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(924, 964);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // itemWheel
            // 
            this.itemWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemWheel.AutoSize = true;
            this.itemWheel.BackColor = System.Drawing.Color.Black;
            this.itemWheel.ForeColor = System.Drawing.Color.White;
            this.itemWheel.Location = new System.Drawing.Point(24, 6);
            this.itemWheel.Margin = new System.Windows.Forms.Padding(6);
            this.itemWheel.Name = "itemWheel";
            this.itemWheel.Size = new System.Drawing.Size(894, 952);
            this.itemWheel.TabIndex = 1;
            this.itemWheel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(10, 954);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonConfig, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonNew, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(978, 69);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfig.FlatAppearance.BorderSize = 2;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.ForeColor = System.Drawing.Color.Lime;
            this.buttonConfig.Location = new System.Drawing.Point(493, 5);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(481, 59);
            this.buttonConfig.TabIndex = 2;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNew.FlatAppearance.BorderSize = 2;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.Lime;
            this.buttonNew.Location = new System.Drawing.Point(4, 5);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(481, 59);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // PhasmoRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(994, 1344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 1600);
            this.MinimumSize = new System.Drawing.Size(1000, 1400);
            this.Name = "PhasmoRandomizer";
            this.Text = "Phasmophobia Randomizer";
            this.ResizeEnd += new System.EventHandler(this.PhasmoRandomizer_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhasmoRandomizer_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabPageItem.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPageItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPlayerCount;
        private System.Windows.Forms.Button buttonRollPlayers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Button buttonRollMap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonRollItems;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelMaxItems;
        private System.Windows.Forms.TextBox textBoxMaxItems;
        private System.Windows.Forms.Button buttonRollAll;
        private System.Windows.Forms.Button buttonReroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private PhasmoSpinWheel playerWheel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private PhasmoSpinWheel mapWheel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private PhasmoSpinWheel itemWheel;
    }
}

