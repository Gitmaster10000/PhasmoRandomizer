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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhasmoRandomizer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlayerCount = new System.Windows.Forms.Label();
            this.buttonRollPlayers = new System.Windows.Forms.Button();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMap = new System.Windows.Forms.Label();
            this.buttonRollMap = new System.Windows.Forms.Button();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRollItems = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaxItems = new System.Windows.Forms.Label();
            this.textBoxMaxItems = new System.Windows.Forms.TextBox();
            this.buttonRollAll = new System.Windows.Forms.Button();
            this.buttonReroll = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNew, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePlayers);
            this.tabControlMain.Controls.Add(this.tabPageMap);
            this.tabControlMain.Controls.Add(this.tabPageItem);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(8, 49);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(413, 364);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlMain_Selecting);
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.BackColor = System.Drawing.Color.Black;
            this.tabPagePlayers.Controls.Add(this.tableLayoutPanel2);
            this.tabPagePlayers.ForeColor = System.Drawing.Color.Black;
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(405, 335);
            this.tabPagePlayers.TabIndex = 0;
            this.tabPagePlayers.Text = "Players";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.labelPlayerCount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonRollPlayers, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 329);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelPlayerCount
            // 
            this.labelPlayerCount.AutoSize = true;
            this.labelPlayerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerCount.ForeColor = System.Drawing.Color.White;
            this.labelPlayerCount.Location = new System.Drawing.Point(13, 49);
            this.labelPlayerCount.Name = "labelPlayerCount";
            this.labelPlayerCount.Size = new System.Drawing.Size(373, 270);
            this.labelPlayerCount.TabIndex = 0;
            this.labelPlayerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRollPlayers
            // 
            this.buttonRollPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollPlayers.Location = new System.Drawing.Point(13, 13);
            this.buttonRollPlayers.Name = "buttonRollPlayers";
            this.buttonRollPlayers.Size = new System.Drawing.Size(373, 33);
            this.buttonRollPlayers.TabIndex = 1;
            this.buttonRollPlayers.Text = "Roll";
            this.buttonRollPlayers.UseVisualStyleBackColor = true;
            this.buttonRollPlayers.Click += new System.EventHandler(this.buttonRollPlayers_Click);
            // 
            // tabPageMap
            // 
            this.tabPageMap.BackColor = System.Drawing.Color.Black;
            this.tabPageMap.Controls.Add(this.tableLayoutPanel3);
            this.tabPageMap.ForeColor = System.Drawing.Color.Black;
            this.tabPageMap.Location = new System.Drawing.Point(4, 25);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(405, 335);
            this.tabPageMap.TabIndex = 1;
            this.tabPageMap.Text = "Map";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Controls.Add(this.labelMap, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonRollMap, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 329);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.ForeColor = System.Drawing.Color.White;
            this.labelMap.Location = new System.Drawing.Point(13, 49);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(373, 270);
            this.labelMap.TabIndex = 0;
            this.labelMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRollMap
            // 
            this.buttonRollMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollMap.Location = new System.Drawing.Point(13, 13);
            this.buttonRollMap.Name = "buttonRollMap";
            this.buttonRollMap.Size = new System.Drawing.Size(373, 33);
            this.buttonRollMap.TabIndex = 1;
            this.buttonRollMap.Text = "Roll";
            this.buttonRollMap.UseVisualStyleBackColor = true;
            this.buttonRollMap.Click += new System.EventHandler(this.buttonRollMap_Click);
            // 
            // tabPageItem
            // 
            this.tabPageItem.BackColor = System.Drawing.Color.Black;
            this.tabPageItem.Controls.Add(this.tableLayoutPanel4);
            this.tabPageItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageItem.ForeColor = System.Drawing.Color.Black;
            this.tabPageItem.Location = new System.Drawing.Point(4, 25);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItem.Size = new System.Drawing.Size(405, 335);
            this.tabPageItem.TabIndex = 2;
            this.tabPageItem.Text = "Items";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Controls.Add(this.buttonRollItems, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.buttonReroll, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(399, 329);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonRollItems
            // 
            this.buttonRollItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRollItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollItems.Location = new System.Drawing.Point(13, 13);
            this.buttonRollItems.Name = "buttonRollItems";
            this.buttonRollItems.Size = new System.Drawing.Size(373, 33);
            this.buttonRollItems.TabIndex = 1;
            this.buttonRollItems.Text = "Roll";
            this.buttonRollItems.UseVisualStyleBackColor = true;
            this.buttonRollItems.Click += new System.EventHandler(this.buttonRollItems_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(373, 196);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.labelMaxItems, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMaxItems, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonRollAll, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 49);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(379, 29);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // labelMaxItems
            // 
            this.labelMaxItems.AutoSize = true;
            this.labelMaxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxItems.ForeColor = System.Drawing.Color.White;
            this.labelMaxItems.Location = new System.Drawing.Point(3, 0);
            this.labelMaxItems.Name = "labelMaxItems";
            this.labelMaxItems.Size = new System.Drawing.Size(183, 29);
            this.labelMaxItems.TabIndex = 0;
            this.labelMaxItems.Text = "Max items per player";
            this.labelMaxItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMaxItems
            // 
            this.textBoxMaxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxItems.Location = new System.Drawing.Point(192, 4);
            this.textBoxMaxItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBoxMaxItems.MaxLength = 2;
            this.textBoxMaxItems.Name = "textBoxMaxItems";
            this.textBoxMaxItems.Size = new System.Drawing.Size(88, 20);
            this.textBoxMaxItems.TabIndex = 1;
            this.textBoxMaxItems.Text = "3";
            this.textBoxMaxItems.TextChanged += new System.EventHandler(this.textBoxMaxItems_TextChanged);
            // 
            // buttonRollAll
            // 
            this.buttonRollAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRollAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollAll.Location = new System.Drawing.Point(286, 3);
            this.buttonRollAll.Name = "buttonRollAll";
            this.buttonRollAll.Size = new System.Drawing.Size(90, 23);
            this.buttonRollAll.TabIndex = 2;
            this.buttonRollAll.Text = "Roll all";
            this.buttonRollAll.UseVisualStyleBackColor = true;
            this.buttonRollAll.Click += new System.EventHandler(this.buttonRollAll_Click);
            // 
            // buttonReroll
            // 
            this.buttonReroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReroll.Enabled = false;
            this.buttonReroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReroll.Location = new System.Drawing.Point(13, 283);
            this.buttonReroll.Name = "buttonReroll";
            this.buttonReroll.Size = new System.Drawing.Size(373, 33);
            this.buttonReroll.TabIndex = 4;
            this.buttonReroll.Text = "Roll selected item again (5)";
            this.buttonReroll.UseVisualStyleBackColor = true;
            this.buttonReroll.Click += new System.EventHandler(this.buttonReroll_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(8, 8);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(413, 35);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // PhasmoRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(445, 460);
            this.Name = "PhasmoRandomizer";
            this.Text = "Phasmophobia Randomizer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPageItem.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
    }
}

