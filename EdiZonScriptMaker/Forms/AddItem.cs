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
    public partial class AddItemForm : Form
    {
        public bool ProperExit { get; set; }

        public string Type { get => (string)TypeComboBox.SelectedItem; }
        public string ItemName { get => ItemNameTextBox.Text; }
        public string ItemCategory { get => (ItemCategoryTextBox.Text == String.Empty) ? null : ItemCategoryTextBox.Text; }
        public IEnumerable<int> IntArgs
        {
            get => IntArgsTextBox.Text.Trim('\r', '\n', ' ').Split(',')
                        .Select(i => Convert.ToInt32(i));
        }
        public IEnumerable<string> StrArgs
        {
            get => StrArgsTextBox.Text.Trim('\r', '\n', ' ').Split(',');
        }

        public int? StepSize { get => (StepSizeTextBox.Text == String.Empty) ? null : (int?)Convert.ToInt32(StepSizeTextBox.Text); }

        public int MinValue { get => (minValue.Text == String.Empty) ? 0 : Convert.ToInt32(minValue.Text); }
        public int MaxValue { get => (maxValue.Text == String.Empty) ? 0 : Convert.ToInt32(maxValue.Text); }

        public int OnValue { get => (onValue.Text == String.Empty) ? 0 : Convert.ToInt32(onValue.Text); }
        public int OffValue { get => (offValue.Text == String.Empty) ? 0 : Convert.ToInt32(offValue.Text); }

        public IEnumerable<string> ListItemNames { get => listItemNames.Text.Trim('\r', '\n', ' ').Split(','); }
        public IEnumerable<int> ListItemValues { get => listItemValues.Text.Trim('\r', '\n', ' ').Split(',').Select(i => Convert.ToInt32(i)); }

        public AddItemForm()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            switch ((string)TypeComboBox.Items[TypeComboBox.SelectedIndex])
            {
                case "int":
                    minValue.Visible = maxValue.Visible = StepSizeTextBox.Visible = true;
                    onValue.Visible = offValue.Visible = listItemNames.Visible = listItemValues.Visible = false;

                    minValueLabel.Visible = maxValueLabel.Visible = stepSizeLabel.Visible = true;
                    onValueLabel.Visible = offValueLabel.Visible = listItemNamesLabel.Visible = listItemValuesLabel.Visible = false;
                    break;
                case "bool":
                    onValue.Visible = offValue.Visible = true;
                    minValueLabel.Visible = maxValue.Visible = listItemNames.Visible = listItemValues.Visible = StepSizeTextBox.Visible = false;

                    onValueLabel.Visible = offValueLabel.Visible = true;
                    minValueLabel.Visible = maxValueLabel.Visible = listItemNamesLabel.Visible = listItemValuesLabel.Visible = stepSizeLabel.Visible = false;
                    break;
                case "list":
                    listItemNames.Visible = listItemValues.Visible = true;
                    onValue.Visible = offValue.Visible = minValueLabel.Visible = maxValue.Visible = StepSizeTextBox.Visible = false;

                    listItemNamesLabel.Visible = listItemValuesLabel.Visible = true;
                    onValueLabel.Visible = offValueLabel.Visible = minValueLabel.Visible = maxValueLabel.Visible = stepSizeLabel.Visible = false;
                    break;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (ItemNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("A name must be assigned to an item.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IntArgsTextBox.Text.Trim('\r', '\n', ' ').Split(',').Select(i => i.IsNumeric()).Any(i => i == false))
            {
                MessageBox.Show("IntArgs can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (TypeComboBox.Text)
            {
                case "int":
                    if (minValue.Text == String.Empty)
                    {
                        MessageBox.Show("MinValue can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!minValue.Text.IsNumeric())
                    {
                        MessageBox.Show("MinValue can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (maxValue.Text == String.Empty)
                    {
                        MessageBox.Show("MaxValue can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!maxValue.Text.IsNumeric())
                    {
                        MessageBox.Show("MaxValue can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (StepSizeTextBox.Text != String.Empty && !StepSizeTextBox.Text.IsNumeric())
                    {
                        MessageBox.Show("StepSize can only be empty or numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "bool":
                    if (onValue.Text == String.Empty)
                    {
                        MessageBox.Show("OnValue can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!onValue.Text.IsNumeric())
                    {
                        MessageBox.Show("OnValue can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (offValue.Text == String.Empty)
                    {
                        MessageBox.Show("OffValue can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!offValue.Text.IsNumeric())
                    {
                        MessageBox.Show("OffValue can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "list":
                    if (listItemNames.Text.Trim('\r', '\n', ' ').Split(',').Where(i => i != String.Empty).Count() != listItemValues.Text.Trim('\r', '\n', ' ').Split(',').Where(i => i != String.Empty).Count())
                    {
                        MessageBox.Show("listItemNames and listItemValues need equal count of elements.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (listItemNames.Text == String.Empty)
                    {
                        MessageBox.Show("listItemNames can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (listItemValues.Text == String.Empty)
                    {
                        MessageBox.Show("listItemValues can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (listItemValues.Text.Trim('\r', '\n', ' ').Split(',').Where(i => i != String.Empty).Select(i => i.IsNumeric()).Any(i => i == false))
                    {
                        MessageBox.Show("Elements in listItemValues can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            ProperExit = true;
            Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            ProperExit = false;
        }
    }
}
