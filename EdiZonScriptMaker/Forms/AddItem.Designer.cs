namespace EdiZonScriptMaker
{
    partial class AddItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemCategoryTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.IntArgsTextBox = new System.Windows.Forms.TextBox();
            this.StrArgsTextBox = new System.Windows.Forms.TextBox();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.onValueLabel = new System.Windows.Forms.Label();
            this.offValueLabel = new System.Windows.Forms.Label();
            this.listItemNamesLabel = new System.Windows.Forms.Label();
            this.listItemValuesLabel = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.onValue = new System.Windows.Forms.TextBox();
            this.offValue = new System.Windows.Forms.TextBox();
            this.listItemNames = new System.Windows.Forms.TextBox();
            this.listItemValues = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.stepSizeLabel = new System.Windows.Forms.Label();
            this.StepSizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "intArgs:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "int",
            "bool",
            "list"});
            this.TypeComboBox.Location = new System.Drawing.Point(101, 162);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.TypeComboBox.TabIndex = 4;
            this.TypeComboBox.Text = "int";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "strArgs:";
            // 
            // ItemCategoryTextBox
            // 
            this.ItemCategoryTextBox.Location = new System.Drawing.Point(101, 6);
            this.ItemCategoryTextBox.Name = "ItemCategoryTextBox";
            this.ItemCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemCategoryTextBox.TabIndex = 6;
            this.ItemCategoryTextBox.Text = "Category";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(101, 32);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameTextBox.TabIndex = 7;
            this.ItemNameTextBox.Text = "Name";
            // 
            // IntArgsTextBox
            // 
            this.IntArgsTextBox.Location = new System.Drawing.Point(101, 58);
            this.IntArgsTextBox.Multiline = true;
            this.IntArgsTextBox.Name = "IntArgsTextBox";
            this.IntArgsTextBox.Size = new System.Drawing.Size(100, 46);
            this.IntArgsTextBox.TabIndex = 8;
            this.IntArgsTextBox.Text = "4,4";
            // 
            // StrArgsTextBox
            // 
            this.StrArgsTextBox.Location = new System.Drawing.Point(101, 110);
            this.StrArgsTextBox.Multiline = true;
            this.StrArgsTextBox.Name = "StrArgsTextBox";
            this.StrArgsTextBox.Size = new System.Drawing.Size(100, 46);
            this.StrArgsTextBox.TabIndex = 10;
            this.StrArgsTextBox.Text = "0000,0020";
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Location = new System.Drawing.Point(11, 192);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(53, 13);
            this.minValueLabel.TabIndex = 11;
            this.minValueLabel.Text = "minValue:";
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Location = new System.Drawing.Point(11, 218);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(56, 13);
            this.maxValueLabel.TabIndex = 12;
            this.maxValueLabel.Text = "maxValue:";
            // 
            // onValueLabel
            // 
            this.onValueLabel.AutoSize = true;
            this.onValueLabel.Location = new System.Drawing.Point(11, 192);
            this.onValueLabel.Name = "onValueLabel";
            this.onValueLabel.Size = new System.Drawing.Size(49, 13);
            this.onValueLabel.TabIndex = 13;
            this.onValueLabel.Text = "onValue:";
            // 
            // offValueLabel
            // 
            this.offValueLabel.AutoSize = true;
            this.offValueLabel.Location = new System.Drawing.Point(11, 218);
            this.offValueLabel.Name = "offValueLabel";
            this.offValueLabel.Size = new System.Drawing.Size(49, 13);
            this.offValueLabel.TabIndex = 14;
            this.offValueLabel.Text = "offValue:";
            // 
            // listItemNamesLabel
            // 
            this.listItemNamesLabel.AutoSize = true;
            this.listItemNamesLabel.Location = new System.Drawing.Point(11, 192);
            this.listItemNamesLabel.Name = "listItemNamesLabel";
            this.listItemNamesLabel.Size = new System.Drawing.Size(75, 13);
            this.listItemNamesLabel.TabIndex = 15;
            this.listItemNamesLabel.Text = "listItemNames:";
            // 
            // listItemValuesLabel
            // 
            this.listItemValuesLabel.AutoSize = true;
            this.listItemValuesLabel.Location = new System.Drawing.Point(11, 218);
            this.listItemValuesLabel.Name = "listItemValuesLabel";
            this.listItemValuesLabel.Size = new System.Drawing.Size(74, 13);
            this.listItemValuesLabel.TabIndex = 16;
            this.listItemValuesLabel.Text = "listItemValues:";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(101, 189);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(100, 20);
            this.minValue.TabIndex = 17;
            this.minValue.Text = "0";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(101, 215);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(100, 20);
            this.maxValue.TabIndex = 18;
            this.maxValue.Text = "99";
            // 
            // onValue
            // 
            this.onValue.Location = new System.Drawing.Point(101, 189);
            this.onValue.Name = "onValue";
            this.onValue.Size = new System.Drawing.Size(100, 20);
            this.onValue.TabIndex = 19;
            this.onValue.Text = "0";
            // 
            // offValue
            // 
            this.offValue.Location = new System.Drawing.Point(101, 215);
            this.offValue.Name = "offValue";
            this.offValue.Size = new System.Drawing.Size(100, 20);
            this.offValue.TabIndex = 20;
            this.offValue.Text = "1";
            // 
            // listItemNames
            // 
            this.listItemNames.Location = new System.Drawing.Point(101, 189);
            this.listItemNames.Multiline = true;
            this.listItemNames.Name = "listItemNames";
            this.listItemNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listItemNames.Size = new System.Drawing.Size(100, 20);
            this.listItemNames.TabIndex = 21;
            this.listItemNames.Text = "Item1,Item2";
            // 
            // listItemValues
            // 
            this.listItemValues.Location = new System.Drawing.Point(101, 215);
            this.listItemValues.Multiline = true;
            this.listItemValues.Name = "listItemValues";
            this.listItemValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listItemValues.Size = new System.Drawing.Size(100, 20);
            this.listItemValues.TabIndex = 22;
            this.listItemValues.Text = "0,1";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(14, 268);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 23;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // stepSizeLabel
            // 
            this.stepSizeLabel.AutoSize = true;
            this.stepSizeLabel.Location = new System.Drawing.Point(11, 244);
            this.stepSizeLabel.Name = "stepSizeLabel";
            this.stepSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.stepSizeLabel.TabIndex = 24;
            this.stepSizeLabel.Text = "StepSize:";
            // 
            // StepSizeTextBox
            // 
            this.StepSizeTextBox.Location = new System.Drawing.Point(101, 241);
            this.StepSizeTextBox.Name = "StepSizeTextBox";
            this.StepSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepSizeTextBox.TabIndex = 25;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 303);
            this.Controls.Add(this.StepSizeTextBox);
            this.Controls.Add(this.stepSizeLabel);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.listItemValues);
            this.Controls.Add(this.listItemNames);
            this.Controls.Add(this.offValue);
            this.Controls.Add(this.onValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.listItemValuesLabel);
            this.Controls.Add(this.listItemNamesLabel);
            this.Controls.Add(this.offValueLabel);
            this.Controls.Add(this.onValueLabel);
            this.Controls.Add(this.maxValueLabel);
            this.Controls.Add(this.minValueLabel);
            this.Controls.Add(this.StrArgsTextBox);
            this.Controls.Add(this.IntArgsTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.ItemCategoryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemCategoryTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox IntArgsTextBox;
        private System.Windows.Forms.TextBox StrArgsTextBox;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label onValueLabel;
        private System.Windows.Forms.Label offValueLabel;
        private System.Windows.Forms.Label listItemNamesLabel;
        private System.Windows.Forms.Label listItemValuesLabel;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.TextBox onValue;
        private System.Windows.Forms.TextBox offValue;
        private System.Windows.Forms.TextBox listItemNames;
        private System.Windows.Forms.TextBox listItemValues;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label stepSizeLabel;
        private System.Windows.Forms.TextBox StepSizeTextBox;
    }
}