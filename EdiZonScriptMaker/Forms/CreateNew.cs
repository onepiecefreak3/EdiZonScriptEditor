using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdiZonScriptMaker
{
    public partial class CreateNewForm : Form
    {
        public bool ProperExit = false;

        public List<string> SaveFilePaths { get => SaveFilePathTextBox.Text.Trim('\r', '\n', ' ').Split(',').ToList(); }
        public string Files { get => FilesTextBox.Text; }
        public string FileType { get => FileTypeTextBox.Text; }
        public string TitleVersion { get => TitleVersionTextBox.Text == String.Empty ? null : TitleVersionTextBox.Text; }

        public CreateNewForm()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (FileTypeTextBox.Text == String.Empty)
            {
                MessageBox.Show("FileType can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProperExit = true;
            Close();
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {
            ProperExit = false;
        }
    }
}
