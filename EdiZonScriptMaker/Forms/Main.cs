using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Windows.Input;

using EdiZonScriptMaker.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EdiZonScriptMaker
{
    public partial class Main : Form
    {
        private EdiZonScript _json = null;
        private bool _fileOpened = false;

        private AddItemForm _addItem = new AddItemForm();
        private CreateNewForm _createNew = new CreateNewForm();

        #region Init
        public Main(string initFile = null)
        {
            InitializeComponent();

            if (initFile != null)
                OpenFile(initFile);
            else
                UpdateUI();
        }
        #endregion

        #region Events
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var od = new OpenFileDialog();
            od.Filter = "(*.json)|*.json";

            if (od.ShowDialog() == DialogResult.OK)
                OpenFile(od.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sd = new SaveFileDialog();
            sd.Filter = "(*.json)|*.json";

            if (sd.ShowDialog() == DialogResult.OK)
                SaveFile(sd.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _createNew.ShowDialog();
            if (_createNew.ProperExit)
            {
                _json = new EdiZonScript
                {
                    saveFilePaths = _createNew.SaveFilePaths,
                    files = _createNew.Files,
                    filetype = _createNew.FileType,
                    titleVersion = _createNew.TitleVersion,
                    items = new List<Item>()
                };

                _fileOpened = true;

                UpdateJSON();
                UpdateUI();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by onepiecefreak.\r\n" +
                "Help and inspiration by madhatter.\r\n" +
                "Credits to WerWolv98 and thomasnet-mc for creating EdiZon, a save editor for the Nintendo Switch.\r\n" +
                "This program is not affiliated with the EdiZon devs in any way and was developed independantly.",
                "Credits",
                MessageBoxButtons.OK);
        }

        private void ediZonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreditLinks().ShowDialog();
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search:\r\n" +
                "The search function works automatically. While you type the app already searches through the table for the desired text. The app also only searches through the \"Name\" column.\r\n" +
                "Pressing Enter will move the table to the next entry matching the search text.\r\n" +
                "\r\n" +
                "Copy/Paste:\r\n" +
                "You can copy and paste multiple rows of a table. Just mark them and press CTRL+C and CTRL+V. You can't copy and paste items from one table into another.", "Controls", MessageBoxButtons.OK);
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            _addItem.ShowDialog();
            if (_addItem.ProperExit)
            {
                var item = new Item
                {
                    category = _addItem.ItemCategory,
                    name = _addItem.ItemName,
                    intArgs = _addItem.IntArgs.ToList(),
                    strArgs = _addItem.StrArgs.ToList(),

                    widget = new Widget()
                };

                switch (_addItem.Type)
                {
                    case "int":
                        item.widget.type = "int";

                        item.widget.stepSize = _addItem.StepSize;

                        item.widget.minValue = _addItem.MinValue;
                        item.widget.maxValue = _addItem.MaxValue;
                        break;
                    case "bool":
                        item.widget.type = "bool";

                        item.widget.onValue = _addItem.OnValue;
                        item.widget.offValue = _addItem.OffValue;
                        break;
                    case "list":
                        item.widget.type = "list";

                        item.widget.listItemNames = _addItem.ListItemNames.ToList();
                        item.widget.listItemValues = _addItem.ListItemValues.ToList();
                        break;
                }

                _json.items.Add(item);
            }

            UpdateDataGrids();
            UpdateJSON();
            UpdateUI();
        }

        private void searchTextBox1_TextChanged(object sender, EventArgs e)
        {
            Search(IntItemsDataGrid, searchTextBox1.Text, "NameColumn");
        }

        private void searchTextBox2_TextChanged(object sender, EventArgs e)
        {
            Search(BoolItemsDataGrid, searchTextBox2.Text, "NameColumn2");
        }

        private void searchTextBox3_TextChanged(object sender, EventArgs e)
        {
            Search(ListItemsDataGrid, searchTextBox3.Text, "NameColumn3");
        }

        private void searchTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(IntItemsDataGrid, searchTextBox1.Text, "NameColumn", IntItemsDataGrid.FirstDisplayedScrollingRowIndex);
        }

        private void searchTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(BoolItemsDataGrid, searchTextBox2.Text, "NameColumn2", BoolItemsDataGrid.FirstDisplayedScrollingRowIndex);
        }

        private void searchTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(ListItemsDataGrid, searchTextBox3.Text, "NameColumn3", ListItemsDataGrid.FirstDisplayedScrollingRowIndex);
        }

        private void IntItemsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            ExecuteDataGridKeyEvent(IntItemsDataGrid, e);
        }

        private void BoolItemsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            ExecuteDataGridKeyEvent(BoolItemsDataGrid, e);
        }

        private void ListItemsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            ExecuteDataGridKeyEvent(ListItemsDataGrid, e);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            var startPoint = IntItemsDataGrid.Location.Y;
            var startPointText = searchTextBox1.Location.Y;
            var startPointLabel = searchLabel1.Location.Y;
            var delta = 32;
            var bottomDelta = 7;

            var newGridSize = (ClientSize.Height - startPoint - 2 * delta - bottomDelta) / 3;

            IntItemsDataGrid.Size = new Size(IntItemsDataGrid.Width, newGridSize);
            BoolItemsDataGrid.Size = new Size(BoolItemsDataGrid.Width, newGridSize);
            ListItemsDataGrid.Size = new Size(ListItemsDataGrid.Width, newGridSize);

            BoolItemsDataGrid.Location = new Point(BoolItemsDataGrid.Location.X, startPoint + newGridSize + delta);
            ListItemsDataGrid.Location = new Point(ListItemsDataGrid.Location.X, startPoint + newGridSize * 2 + delta * 2);

            searchTextBox2.Location = new Point(searchTextBox2.Location.X, startPointText + newGridSize + delta);
            searchTextBox3.Location = new Point(searchTextBox3.Location.X, startPointText + newGridSize * 2 + delta * 2);

            searchLabel2.Location = new Point(searchLabel2.Location.X, startPointText + newGridSize + delta);
            searchLabel3.Location = new Point(searchLabel3.Location.X, startPointText + newGridSize * 2 + delta * 2);
        }
        #endregion

        #region Drag'n'Drop
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenFile(files[0]);
        }
        #endregion

        #region Functions
        private void OpenFile(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    var readJson = File.ReadAllText(file);
                    _json = JsonConvert.DeserializeObject<EdiZonScript>(readJson);

                    _fileOpened = true;

                    Text = "EdiZon ScriptEditor - " + Path.GetFileName(file);

                    UpdateDataGrids();

                    UpdateUI();
                    UpdateJSON();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message + "\r\nCheck your json with an online JSON Validator.", "Exception", MessageBoxButtons.OK);
                }
            }
        }

        private void SaveFile(string file)
        {
            if (DataGridToJSON())
            {
                UpdateJSON();

                var writeJson = JsonConvert.SerializeObject(_json, Formatting.Indented);
                File.WriteAllText(file, writeJson);

                Text = "EdiZon ScriptEditor - " + Path.GetFileName(file);
            }
        }

        private void CloseFile()
        {
            _json = null;
            _fileOpened = false;

            Text = "EdiZon ScriptEditor";

            UpdateDataGrids();
            UpdateUI();
            UpdateJSON();
        }

        private void UpdateDataGrids()
        {
            IntItemsDataGrid.Rows.Clear();
            BoolItemsDataGrid.Rows.Clear();
            ListItemsDataGrid.Rows.Clear();

            if (_json != null)
            {
                foreach (var item in _json.items)
                {
                    switch (item.widget.type)
                    {
                        case "int":
                            IntItemsDataGrid.Rows.Add(
                                item.category,
                                item.name,
                                item.intArgs.Select(a => a.ToString()).Aggregate((a, b) => $"{a},{b}"),
                                item.strArgs.Aggregate((a, b) => $"{a},{b}"),
                                item.widget.minValue,
                                item.widget.maxValue,
                                item.widget.stepSize);
                            IntItemsDataGrid.Rows[IntItemsDataGrid.Rows.Count - 1].HeaderCell.Value = String.Format("{0}", IntItemsDataGrid.Rows.Count - 1);
                            break;
                        case "bool":
                            BoolItemsDataGrid.Rows.Add(
                                item.category,
                                item.name,
                                item.intArgs.Select(a => a.ToString()).Aggregate((a, b) => $"{a},{b}"),
                                item.strArgs.Aggregate((a, b) => $"{a},{b}"),
                                item.widget.onValue,
                                item.widget.offValue);
                            BoolItemsDataGrid.Rows[BoolItemsDataGrid.Rows.Count - 1].HeaderCell.Value = String.Format("{0}", BoolItemsDataGrid.Rows.Count - 1);
                            break;
                        case "list":
                            ListItemsDataGrid.Rows.Add(
                                item.category,
                                item.name,
                                item.intArgs.Select(a => a.ToString()).Aggregate((a, b) => $"{a},{b}"),
                                item.strArgs.Aggregate((a, b) => $"{a},{b}"),
                                item.widget.listItemNames.Aggregate((a, b) => $"{a},{b}"),
                                item.widget.listItemValues.Select(a => a.ToString()).Aggregate((a, b) => $"{a},{b}"));
                            ListItemsDataGrid.Rows[ListItemsDataGrid.Rows.Count - 1].HeaderCell.Value = String.Format("{0}", ListItemsDataGrid.Rows.Count - 1);
                            break;
                    }
                }
            }
        }

        private void UpdateUI()
        {
            saveToolStripMenuItem.Enabled = closeToolStripMenuItem.Enabled = _fileOpened;
            searchTextBox1.Enabled = searchTextBox2.Enabled = searchTextBox3.Enabled = _fileOpened;

            addItemBtn.Enabled = _fileOpened;

            UpdateDataGrids();

            IntItemsDataGrid.Enabled = _json?.items.Where(i => i.widget.type == "int").Any() ?? false;
            BoolItemsDataGrid.Enabled = _json?.items.Where(i => i.widget.type == "bool").Any() ?? false;
            ListItemsDataGrid.Enabled = _json?.items.Where(i => i.widget.type == "list").Any() ?? false;
        }

        private void UpdateJSON()
        {
            if (_json != null)
            {
                _json.SetShouldSerializeTitleVersion(_json.titleVersion != null);

                foreach (var item in _json.items)
                {
                    item.SetShouldSerializeCategory(item.category != null);

                    switch (item.widget.type)
                    {
                        case "int":
                            item.widget.SetShouldSerializeStepSize(item.widget.stepSize != null);

                            item.widget.SetShouldSerializeMinValue(true);
                            item.widget.SetShouldSerializeMaxValue(true);
                            item.widget.SetShouldSerializeOnValue(false);
                            item.widget.SetShouldSerializeOffValue(false);
                            item.widget.SetShouldSerializeListItemNames(false);
                            item.widget.SetShouldSerializeListItemValues(false);

                            break;
                        case "bool":
                            item.widget.SetShouldSerializeStepSize(false);
                            item.widget.SetShouldSerializeMinValue(false);
                            item.widget.SetShouldSerializeMaxValue(false);
                            item.widget.SetShouldSerializeOnValue(true);
                            item.widget.SetShouldSerializeOffValue(true);
                            item.widget.SetShouldSerializeListItemNames(false);
                            item.widget.SetShouldSerializeListItemValues(false);
                            break;
                        case "list":
                            item.widget.SetShouldSerializeStepSize(false);
                            item.widget.SetShouldSerializeMinValue(false);
                            item.widget.SetShouldSerializeMaxValue(false);
                            item.widget.SetShouldSerializeOnValue(false);
                            item.widget.SetShouldSerializeOffValue(false);
                            item.widget.SetShouldSerializeListItemNames(true);
                            item.widget.SetShouldSerializeListItemValues(true);
                            break;
                    }
                }
            }
        }

        private bool DataGridToJSON()
        {
            _json.items.Clear();

            for (int i = 0; i < IntItemsDataGrid.Rows.Count; i++)
            {
                var row = IntItemsDataGrid.Rows[i];
                #region Check data
                if (row.Cells[1].Value == null)
                {
                    MessageBox.Show($"A name must be assigned to item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => it.IsNumeric()).Any(it => it == false) ?? false)
                {
                    MessageBox.Show($"IntArgs for item {i} in IntItems can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[4].Value == null)
                {
                    MessageBox.Show($"MinValue can't be empty for item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!row.Cells[4].Value.ToString().IsNumeric())
                {
                    MessageBox.Show($"MinValue can only be numeric for item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[5].Value == null)
                {
                    MessageBox.Show($"MaxValue can't be empty for item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!row.Cells[5].Value.ToString().IsNumeric())
                {
                    MessageBox.Show($"MaxValue can only be numeric for item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[6].Value?.ToString() != null && !row.Cells[6].Value.ToString().IsNumeric())
                {
                    MessageBox.Show($"StepSize can only be empty or numeric for item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                #endregion

                _json.items.Add(new Item
                {
                    category = row.Cells[0].Value?.ToString(),
                    name = row.Cells[1].Value.ToString(),
                    intArgs = row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => Convert.ToInt32(it)).ToList() ?? new List<int>(),
                    strArgs = row.Cells[3].Value?.ToString().Trim('\r', '\n', ' ').Split(',').ToList() ?? new List<string>(),
                    widget = new Widget
                    {
                        type = "int",
                        minValue = Convert.ToInt32(row.Cells[4].Value),
                        maxValue = Convert.ToInt32(row.Cells[5].Value),
                        stepSize = (row.Cells[6].Value == null) ? null : (int?)Convert.ToInt32(row.Cells[6].Value)
                    }
                });
            }

            for (int i = 0; i < BoolItemsDataGrid.Rows.Count; i++)
            {
                var row = BoolItemsDataGrid.Rows[i];
                #region Check data
                if (row.Cells[1].Value == null)
                {
                    MessageBox.Show($"A name must be assigned to item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => it.IsNumeric()).Any(it => it == false) ?? false)
                {
                    MessageBox.Show($"IntArgs for item {i} in IntItems can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[4].Value == null)
                {
                    MessageBox.Show($"OnValue can't be empty for item {i} in BoolItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!row.Cells[4].Value.ToString().IsNumeric())
                {
                    MessageBox.Show($"OnValue can only be numeric for item {i} in BoolItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[5].Value == null)
                {
                    MessageBox.Show($"OffValue can't be empty for item {i} in BoolItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!row.Cells[5].Value.ToString().IsNumeric())
                {
                    MessageBox.Show($"OffValue can only be numeric for item {i} in BoolItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                #endregion

                _json.items.Add(new Item
                {
                    category = row.Cells[0].Value?.ToString(),
                    name = row.Cells[1].Value.ToString(),
                    intArgs = row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => Convert.ToInt32(it)).ToList() ?? new List<int>(),
                    strArgs = row.Cells[3].Value?.ToString().Trim('\r', '\n', ' ').Split(',').ToList() ?? new List<string>(),
                    widget = new Widget
                    {
                        type = "bool",
                        onValue = Convert.ToInt32(row.Cells[4].Value),
                        offValue = Convert.ToInt32(row.Cells[5].Value)
                    }
                });
            }

            for (int i = 0; i < ListItemsDataGrid.Rows.Count; i++)
            {
                var row = ListItemsDataGrid.Rows[i];
                #region Check data
                if ((string)row.Cells[1].Value == String.Empty)
                {
                    MessageBox.Show($"A name must be assigned to item {i} in IntItems.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => it.IsNumeric()).Any(it => it == false) ?? false)
                {
                    MessageBox.Show($"IntArgs for item {i} in IntItems can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[4].Value == null)
                {
                    MessageBox.Show("ListItemNames can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[5].Value == null)
                {
                    MessageBox.Show("ListItemValues can't be empty.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[5].Value.ToString().Trim('\r', '\n', ' ').Split(',').Where(it => it != String.Empty).Select(it => it.IsNumeric()).Any(it => it == false))
                {
                    MessageBox.Show("ListItemValues can only be numeric.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (row.Cells[4].Value.ToString().Trim('\r', '\n', ' ').Split(',').Where(it => it != String.Empty).Count() != row.Cells[5].Value.ToString().Trim('\r', '\n', ' ').Split(',').Where(it => it != String.Empty).Count())
                {
                    MessageBox.Show("ListItemNames and ListItemValues need equal count of elements.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                #endregion

                _json.items.Add(new Item
                {
                    category = row.Cells[0].Value?.ToString(),
                    name = row.Cells[1].Value.ToString(),
                    intArgs = row.Cells[2].Value?.ToString().Trim('\r', '\n', ' ').Split(',').Select(it => Convert.ToInt32(it)).ToList() ?? new List<int>(),
                    strArgs = row.Cells[3].Value?.ToString().Trim('\r', '\n', ' ').Split(',').ToList() ?? new List<string>(),
                    widget = new Widget
                    {
                        type = "list",
                        listItemNames = row.Cells[4].Value.ToString().Trim('\r', '\n', ' ').Split(',').Where(it => it != String.Empty).ToList(),
                        listItemValues = row.Cells[5].Value.ToString().Trim('\r', '\n', ' ').Split(',').Where(it => it != String.Empty).Select(it => Convert.ToInt32(it)).ToList(),
                    }
                });
            }

            return true;
        }

        private void Search(DataGridView view, string searchText, string searchColumn, int startIndex = -1)
        {
            if (searchText.Length > 0)
            {
                foreach (var row in view.Rows.Where(r => r.Index > startIndex))
                {
                    var minLength = Math.Min(row.Cells[searchColumn].Value?.ToString().Length ?? -1, searchText.Length);
                    if (minLength >= 0)
                        if (row.Cells[searchColumn].Value?.ToString().Substring(0, minLength) == searchText.Substring(0, minLength))
                        {
                            view.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                }
            }
        }

        private void ExecuteDataGridKeyEvent(DataGridView view, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteRows(view);

            if (e.Control && e.KeyCode == Keys.C)
                CopyRows(view);

            if (e.Control && e.KeyCode == Keys.V)
                PasteRows(view);
        }

        private void DeleteRows(DataGridView view)
        {
            var rowIndeces = view.SelectedCells.Select(c => c.RowIndex).Distinct().Reverse().ToList();
            foreach (var index in rowIndeces)
                view.Rows.RemoveAt(index);

            DataGridToJSON();
            UpdateJSON();
            UpdateDataGrids();
        }

        Dictionary<string, DataGridViewRow[]> copied = new Dictionary<string, DataGridViewRow[]>();
        private void CopyRows(DataGridView view)
        {
            var selRowsInds = view.SelectedCells.Select(c => c.RowIndex).Distinct();
            if (copied.ContainsKey(view.Name))
                copied[view.Name] = view.Rows.Where(r => selRowsInds.Contains(r.Index)).ToArray();
            else
                copied.Add(view.Name, view.Rows.Where(r => selRowsInds.Contains(r.Index)).ToArray());
        }

        private void PasteRows(DataGridView view)
        {
            if (copied != null && copied.ContainsKey(view.Name) && !copied[view.Name].Any(r => r.Index == -1))
            {
                foreach (var c in copied[view.Name])
                {
                    var add = new object[c.Cells.Count];
                    for (int i = 0; i < add.Length; i++)
                        add[i] = c.Cells[i].Value;
                    view.Rows.Add(add);
                }

                DataGridToJSON();
                UpdateJSON();
                UpdateDataGrids();

                view.FirstDisplayedScrollingRowIndex = view.Rows.Count - copied[view.Name].Length;
            }
        }
        #endregion
    }
}
