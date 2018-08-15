namespace EdiZonScriptMaker
{
    partial class CreateNewForm
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
            this.OKbtn = new System.Windows.Forms.Button();
            this.SaveFilePathLabel = new System.Windows.Forms.Label();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.TitleVersionLabel = new System.Windows.Forms.Label();
            this.SaveFilePathTextBox = new System.Windows.Forms.TextBox();
            this.FilesTextBox = new System.Windows.Forms.TextBox();
            this.FileTypeTextBox = new System.Windows.Forms.TextBox();
            this.TitleVersionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(12, 110);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // SaveFilePathLabel
            // 
            this.SaveFilePathLabel.AutoSize = true;
            this.SaveFilePathLabel.Location = new System.Drawing.Point(12, 9);
            this.SaveFilePathLabel.Name = "SaveFilePathLabel";
            this.SaveFilePathLabel.Size = new System.Drawing.Size(78, 13);
            this.SaveFilePathLabel.TabIndex = 1;
            this.SaveFilePathLabel.Text = "SaveFilePaths:";
            // 
            // FilesLabel
            // 
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Location = new System.Drawing.Point(12, 35);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(31, 13);
            this.FilesLabel.TabIndex = 2;
            this.FilesLabel.Text = "Files:";
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(12, 61);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.FileTypeLabel.TabIndex = 3;
            this.FileTypeLabel.Text = "FileType:";
            // 
            // TitleVersionLabel
            // 
            this.TitleVersionLabel.AutoSize = true;
            this.TitleVersionLabel.Location = new System.Drawing.Point(12, 87);
            this.TitleVersionLabel.Name = "TitleVersionLabel";
            this.TitleVersionLabel.Size = new System.Drawing.Size(65, 13);
            this.TitleVersionLabel.TabIndex = 4;
            this.TitleVersionLabel.Text = "TitleVersion:";
            // 
            // SaveFilePathTextBox
            // 
            this.SaveFilePathTextBox.Location = new System.Drawing.Point(96, 6);
            this.SaveFilePathTextBox.Name = "SaveFilePathTextBox";
            this.SaveFilePathTextBox.Size = new System.Drawing.Size(100, 20);
            this.SaveFilePathTextBox.TabIndex = 5;
            this.SaveFilePathTextBox.Text = "path,to,save";
            // 
            // FilesTextBox
            // 
            this.FilesTextBox.Location = new System.Drawing.Point(96, 32);
            this.FilesTextBox.Name = "FilesTextBox";
            this.FilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilesTextBox.TabIndex = 6;
            this.FilesTextBox.Text = "save\\.bin";
            // 
            // FileTypeTextBox
            // 
            this.FileTypeTextBox.Location = new System.Drawing.Point(96, 58);
            this.FileTypeTextBox.Name = "FileTypeTextBox";
            this.FileTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FileTypeTextBox.TabIndex = 7;
            this.FileTypeTextBox.Text = "bin";
            // 
            // TitleVersionTextBox
            // 
            this.TitleVersionTextBox.Location = new System.Drawing.Point(96, 84);
            this.TitleVersionTextBox.Name = "TitleVersionTextBox";
            this.TitleVersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleVersionTextBox.TabIndex = 8;
            // 
            // CreateNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 153);
            this.Controls.Add(this.TitleVersionTextBox);
            this.Controls.Add(this.FileTypeTextBox);
            this.Controls.Add(this.FilesTextBox);
            this.Controls.Add(this.SaveFilePathTextBox);
            this.Controls.Add(this.TitleVersionLabel);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.SaveFilePathLabel);
            this.Controls.Add(this.OKbtn);
            this.Name = "CreateNewForm";
            this.Text = "Create new config";
            this.Load += new System.EventHandler(this.CreateNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label SaveFilePathLabel;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Label TitleVersionLabel;
        private System.Windows.Forms.TextBox SaveFilePathTextBox;
        private System.Windows.Forms.TextBox FilesTextBox;
        private System.Windows.Forms.TextBox FileTypeTextBox;
        private System.Windows.Forms.TextBox TitleVersionTextBox;
    }
}