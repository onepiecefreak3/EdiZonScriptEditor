namespace EdiZonScriptMaker
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediZonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.IntItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntArgsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrArgsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoolItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.CategoryColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntArgsColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrArgsColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.CategoryColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntArgsColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrArgsColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListItemNamesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListItemValuesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox1 = new System.Windows.Forms.TextBox();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.searchTextBox3 = new System.Windows.Forms.TextBox();
            this.searchLabel1 = new System.Windows.Forms.Label();
            this.searchLabel2 = new System.Windows.Forms.Label();
            this.searchLabel3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntItemsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoolItemsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.ediZonToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // ediZonToolStripMenuItem
            // 
            this.ediZonToolStripMenuItem.Name = "ediZonToolStripMenuItem";
            this.ediZonToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ediZonToolStripMenuItem.Text = "EdiZon";
            this.ediZonToolStripMenuItem.Click += new System.EventHandler(this.ediZonToolStripMenuItem_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(12, 27);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // IntItemsDataGrid
            // 
            this.IntItemsDataGrid.AllowUserToAddRows = false;
            this.IntItemsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IntItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryColumn,
            this.NameColumn,
            this.IntArgsColumn,
            this.StrArgsColumn,
            this.MinValueColumn,
            this.MaxValueColumn,
            this.StepSizeColumn});
            this.IntItemsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.IntItemsDataGrid.Location = new System.Drawing.Point(12, 82);
            this.IntItemsDataGrid.Name = "IntItemsDataGrid";
            this.IntItemsDataGrid.RowHeadersWidth = 60;
            this.IntItemsDataGrid.Size = new System.Drawing.Size(619, 104);
            this.IntItemsDataGrid.TabIndex = 22;
            this.IntItemsDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntItemsDataGrid_KeyDown);
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // IntArgsColumn
            // 
            this.IntArgsColumn.HeaderText = "IntArgs";
            this.IntArgsColumn.Name = "IntArgsColumn";
            // 
            // StrArgsColumn
            // 
            this.StrArgsColumn.HeaderText = "StrArgs";
            this.StrArgsColumn.Name = "StrArgsColumn";
            // 
            // MinValueColumn
            // 
            this.MinValueColumn.HeaderText = "MinValue";
            this.MinValueColumn.Name = "MinValueColumn";
            // 
            // MaxValueColumn
            // 
            this.MaxValueColumn.HeaderText = "MaxValue";
            this.MaxValueColumn.Name = "MaxValueColumn";
            // 
            // StepSizeColumn
            // 
            this.StepSizeColumn.HeaderText = "StepSize";
            this.StepSizeColumn.Name = "StepSizeColumn";
            // 
            // BoolItemsDataGrid
            // 
            this.BoolItemsDataGrid.AllowUserToAddRows = false;
            this.BoolItemsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoolItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoolItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoolItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryColumn2,
            this.NameColumn2,
            this.IntArgsColumn2,
            this.StrArgsColumn2,
            this.OnValueColumn,
            this.OffValueColumn});
            this.BoolItemsDataGrid.Location = new System.Drawing.Point(12, 218);
            this.BoolItemsDataGrid.Name = "BoolItemsDataGrid";
            this.BoolItemsDataGrid.RowHeadersWidth = 60;
            this.BoolItemsDataGrid.Size = new System.Drawing.Size(619, 104);
            this.BoolItemsDataGrid.TabIndex = 23;
            this.BoolItemsDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoolItemsDataGrid_KeyDown);
            // 
            // CategoryColumn2
            // 
            this.CategoryColumn2.HeaderText = "Category";
            this.CategoryColumn2.Name = "CategoryColumn2";
            this.CategoryColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameColumn2
            // 
            this.NameColumn2.HeaderText = "Name";
            this.NameColumn2.Name = "NameColumn2";
            // 
            // IntArgsColumn2
            // 
            this.IntArgsColumn2.HeaderText = "IntArgs";
            this.IntArgsColumn2.Name = "IntArgsColumn2";
            // 
            // StrArgsColumn2
            // 
            this.StrArgsColumn2.HeaderText = "StrArgs";
            this.StrArgsColumn2.Name = "StrArgsColumn2";
            // 
            // OnValueColumn
            // 
            this.OnValueColumn.HeaderText = "OnValue";
            this.OnValueColumn.Name = "OnValueColumn";
            // 
            // OffValueColumn
            // 
            this.OffValueColumn.HeaderText = "OffValue";
            this.OffValueColumn.Name = "OffValueColumn";
            // 
            // ListItemsDataGrid
            // 
            this.ListItemsDataGrid.AllowUserToAddRows = false;
            this.ListItemsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryColumn3,
            this.NameColumn3,
            this.IntArgsColumn3,
            this.StrArgsColumn3,
            this.ListItemNamesColumn,
            this.ListItemValuesColumn});
            this.ListItemsDataGrid.Location = new System.Drawing.Point(12, 354);
            this.ListItemsDataGrid.Name = "ListItemsDataGrid";
            this.ListItemsDataGrid.RowHeadersWidth = 60;
            this.ListItemsDataGrid.Size = new System.Drawing.Size(619, 104);
            this.ListItemsDataGrid.TabIndex = 24;
            this.ListItemsDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListItemsDataGrid_KeyDown);
            // 
            // CategoryColumn3
            // 
            this.CategoryColumn3.HeaderText = "Category";
            this.CategoryColumn3.Name = "CategoryColumn3";
            this.CategoryColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameColumn3
            // 
            this.NameColumn3.HeaderText = "Name";
            this.NameColumn3.Name = "NameColumn3";
            // 
            // IntArgsColumn3
            // 
            this.IntArgsColumn3.HeaderText = "IntArgs";
            this.IntArgsColumn3.Name = "IntArgsColumn3";
            // 
            // StrArgsColumn3
            // 
            this.StrArgsColumn3.HeaderText = "StrArgs";
            this.StrArgsColumn3.Name = "StrArgsColumn3";
            // 
            // ListItemNamesColumn
            // 
            this.ListItemNamesColumn.HeaderText = "ListItemNames";
            this.ListItemNamesColumn.Name = "ListItemNamesColumn";
            // 
            // ListItemValuesColumn
            // 
            this.ListItemValuesColumn.HeaderText = "ListItemValues";
            this.ListItemValuesColumn.Name = "ListItemValuesColumn";
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.Location = new System.Drawing.Point(93, 56);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox1.TabIndex = 25;
            this.searchTextBox1.TextChanged += new System.EventHandler(this.searchTextBox1_TextChanged);
            this.searchTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox1_KeyDown);
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.Location = new System.Drawing.Point(93, 192);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox2.TabIndex = 26;
            this.searchTextBox2.TextChanged += new System.EventHandler(this.searchTextBox2_TextChanged);
            this.searchTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox2_KeyDown);
            // 
            // searchTextBox3
            // 
            this.searchTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox3.Location = new System.Drawing.Point(93, 328);
            this.searchTextBox3.Name = "searchTextBox3";
            this.searchTextBox3.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox3.TabIndex = 27;
            this.searchTextBox3.TextChanged += new System.EventHandler(this.searchTextBox3_TextChanged);
            this.searchTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox3_KeyDown);
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.Location = new System.Drawing.Point(12, 59);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(75, 13);
            this.searchLabel1.TabIndex = 28;
            this.searchLabel1.Text = "Search Name:";
            // 
            // searchLabel2
            // 
            this.searchLabel2.AutoSize = true;
            this.searchLabel2.Location = new System.Drawing.Point(12, 195);
            this.searchLabel2.Name = "searchLabel2";
            this.searchLabel2.Size = new System.Drawing.Size(75, 13);
            this.searchLabel2.TabIndex = 29;
            this.searchLabel2.Text = "Search Name:";
            // 
            // searchLabel3
            // 
            this.searchLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchLabel3.AutoSize = true;
            this.searchLabel3.Location = new System.Drawing.Point(12, 331);
            this.searchLabel3.Name = "searchLabel3";
            this.searchLabel3.Size = new System.Drawing.Size(75, 13);
            this.searchLabel3.TabIndex = 30;
            this.searchLabel3.Text = "Search Name:";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 466);
            this.Controls.Add(this.searchLabel3);
            this.Controls.Add(this.searchLabel2);
            this.Controls.Add(this.searchLabel1);
            this.Controls.Add(this.searchTextBox3);
            this.Controls.Add(this.searchTextBox2);
            this.Controls.Add(this.searchTextBox1);
            this.Controls.Add(this.ListItemsDataGrid);
            this.Controls.Add(this.BoolItemsDataGrid);
            this.Controls.Add(this.IntItemsDataGrid);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "EdiZon ScriptEditor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntItemsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoolItemsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediZonToolStripMenuItem;
        private System.Windows.Forms.DataGridView IntItemsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntArgsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrArgsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepSizeColumn;
        private System.Windows.Forms.DataGridView BoolItemsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntArgsColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrArgsColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffValueColumn;
        private System.Windows.Forms.DataGridView ListItemsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntArgsColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrArgsColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListItemNamesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListItemValuesColumn;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextBox1;
        private System.Windows.Forms.TextBox searchTextBox2;
        private System.Windows.Forms.TextBox searchTextBox3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel1;
        private System.Windows.Forms.Label searchLabel2;
        private System.Windows.Forms.Label searchLabel3;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
    }
}

