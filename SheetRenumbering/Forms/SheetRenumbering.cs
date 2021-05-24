using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Form = System.Windows.Forms.Form;

namespace BBI.JD.Forms
{
    public partial class SheetRenumbering : System.Windows.Forms.Form
    {
        private UIApplication application;
        private UIDocument uiDoc;
        private Document document;
        private string format;
        private Form formFilter;
        private IList<Element> elements;
        private List<Rule> filters;

        public SheetRenumbering(UIApplication application)
        {
            this.application = application;
            uiDoc = application.ActiveUIDocument;
            document = uiDoc.Document;
            format = "#";
            filters = new List<Rule>();

            InitializeComponent();
        }

        private void SheetRenumbering_Load(object sender, EventArgs e)
        {
            FilteredElementCollector collector = new FilteredElementCollector(document)
                .OfCategory(BuiltInCategory.OST_Sheets);
            
            if (collector.Count() > 0)
            {
                if (uiDoc.Selection.GetElementIds().Count > 0)
                {
                    collector = new FilteredElementCollector(document, uiDoc.Selection.GetElementIds())
                        .OfCategory(BuiltInCategory.OST_Sheets);

                    if (collector.Count() > 0)
                    {
                        cmb_SetType.SelectedIndex = 1;
                    }
                    else
                    {
                        cmb_SetType.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmb_SetType.SelectedIndex = 0;
                }

                ShowExFormat();
            }
            else
            {
                btn_Ok.Enabled = false;

                MessageBox.Show("No Sheet found for renumbering.", "No Sheet", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SheetRenumbering_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void cmb_SetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteredElementCollector collector = null;

            switch (cmb_SetType.SelectedIndex)
            {
                case 0:
                    collector = new FilteredElementCollector(document);
                    break;

                case 1:
                    var selectedIds = uiDoc.Selection.GetElementIds();
                    if (selectedIds.Count > 0)
                    {
                        collector = new FilteredElementCollector(document, selectedIds);
                    }
                    break;

                default:
                    collector = new FilteredElementCollector(document);
                    break;
            }

            if (collector != null)
            {
                collector.OfCategory(BuiltInCategory.OST_Sheets);

                elements = collector.ToElements();
            }
            else
            {
                elements = new List<Element>();
            }

            label4.Text = elements.Count.ToString();

            LoadSheetData();
        }

        private void txt_Format_TextChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;

            ShowExFormat();
        }

        private void num_Start_ValueChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;

            ShowExFormat();
        }

        private void num_Pad_ValueChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;

            ShowExFormat();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            format = txt_Format.Text;

            LoadSheetData();

            btn_Apply.Enabled = false;
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            if (grid_Sheets.SelectedCells.Count > 0)
            {
                row = grid_Sheets.Rows[grid_Sheets.SelectedCells[0].RowIndex];
            }

            if (row != null)
            {
                if (row.Index > 0)
                {
                    int index = row.Index;
                    object[] data = new object[5] { row.Cells["cIndex"].Value, row.Cells["cId"].Value, row.Cells["cNumber"].Value, row.Cells["cNewNumber"].Value, row.Cells["cName"].Value };

                    grid_Sheets.Rows.RemoveAt(index);
                    grid_Sheets.Rows.Insert(index - 1, data);

                    // Update set
                    for (int i = index - 1; i < grid_Sheets.Rows.Count; i++)
                    {
                        row = grid_Sheets.Rows[i];

                        row.Cells["cNewNumber"].Value = GenerateFormat((int)num_Start.Value + i, (int)num_Pad.Value + 1);
                    }

                    // Clear selection
                    grid_Sheets.ClearSelection();
                    // Select row
                    grid_Sheets.Rows[index - 1].Selected = true;
                }
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            if (grid_Sheets.SelectedCells.Count > 0)
            {
                row = grid_Sheets.Rows[grid_Sheets.SelectedCells[0].RowIndex];
            }

            if (row != null)
            {
                if (row.Index < grid_Sheets.Rows.Count - 1)
                {
                    int index = row.Index;
                    object[] data = new object[5] { row.Cells["cIndex"].Value, row.Cells["cId"].Value, row.Cells["cNumber"].Value, row.Cells["cNewNumber"].Value, row.Cells["cName"].Value };

                    grid_Sheets.Rows.RemoveAt(index);
                    grid_Sheets.Rows.Insert(index + 1, data);

                    // Update set
                    for (int i = index; i < grid_Sheets.Rows.Count; i++)
                    {
                        row = grid_Sheets.Rows[i];

                        row.Cells["cNewNumber"].Value = GenerateFormat((int)num_Start.Value + i, (int)num_Pad.Value + 1);
                    }

                    // Clear selection
                    grid_Sheets.ClearSelection();
                    // Select row
                    grid_Sheets.Rows[index + 1].Selected = true;
                }
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Transaction transaction = null;

            try
            {
                transaction = new Transaction(document, "Renumbering Sheets");

                transaction.Start();

                foreach (DataGridViewRow row in grid_Sheets.Rows)
                {
                    if (Equals(row.Cells["cNumber"].Value, row.Cells["cNewNumber"].Value))
                    {
                        // No changed, nothing to do
                        continue;
                    }

                    ViewSheet sheet = (ViewSheet)elements[(int)row.Cells["cIndex"].Value];

                    string number = row.Cells["cNewNumber"].Value.ToString();

                    try
                    {
                        sheet.SheetNumber = number;
                    }
                    catch (Exception ex) // Number in use
                    {
                        // Find sheet in element list
                        ViewSheet repeated = elements.Cast<ViewSheet>().Where(x => x.SheetNumber == number && IsShowingInGrid(x)).FirstOrDefault();

                        if (repeated != null)
                        {
                            // Try to temporarily change number
                            repeated.SheetNumber = "_" + repeated.SheetNumber;

                            // Try to set again new number
                            sheet.SheetNumber = number;
                        }
                        else
                        {
                            MessageBox.Show("There are duplicate numbers. Please take a look to all sheets.", "Renumbering Sheets", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            transaction.RollBack();

                            row.Cells["cNewNumber"].ErrorText = "There is already a sheet named like this.";

                            return;
                        }
                    }
                }

                transaction.Commit();

                // Force refresh Project Browser
                DockablePane dp = new DockablePane(DockablePanes.BuiltInDockablePanes.ProjectBrowser);
                dp.Show();

                MessageBox.Show("The sheets were correctly renumbered.", "Renumbering Sheets", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                if (null != transaction)
                {
                    MessageBox.Show("Error while renumbering sheets.\n" + ex.Message, "Renumbering Sheets", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    transaction.RollBack();
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (formFilter == null)
            {
                formFilter = new SheetFilters(this);
            }

            formFilter.Show(this);
        }

        private void LoadSheetData()
        {
            grid_Sheets.Rows.Clear();

            for (int i = 0, index = 0; i < elements.Count; i++)
            {
                ViewSheet sheet = (ViewSheet)elements[i];

                bool passed = true;

                for (int j = 0; j < filters.Count && passed; j++)
                {
                    passed &= filters[j].Evaluate(sheet);
                }

                if (passed)
                {
                    grid_Sheets.Rows.Add(i, sheet.Id, sheet.SheetNumber, GenerateFormat((int)num_Start.Value + index++, (int)num_Pad.Value + 1), sheet.Name);
                }
            }
        }

        private void ShowExFormat()
        {
            string format;

            try
            {
                format = GenerateFormat((int)num_Start.Value, (int)num_Pad.Value + 1, txt_Format.Text);
            }
            catch (Exception ex)
            {
                label6.Text = ex.Message;
                label6.ForeColor = Color.Red;
                btn_Apply.Enabled = false;

                return;
            }

            label6.Text = string.Format("Ex: {0}", format);
            label6.ForeColor = Color.Black;
        }

        private string GenerateFormat(int index, int pad, string format = null)
        {
            char[] invalidCharacters = new char[13] { '\\', ':', '{', '}', '[', ']', '|', ';', '<', '>', '?', '`', '~' };
            string f;

            if (format != null)
            {
                f = format;
            }
            else
            {
                f = this.format;
            }

            foreach (char c in invalidCharacters)
            {
                if (f.Contains(c))
                {
                    throw new Exception(string.Format("Name cannot contain any of the following characters:\n{0}", new string(invalidCharacters)));
                }
            }

            if (!f.Contains('#'))
            {
                throw new Exception("The format must contain the character #");
            }

            string num = index.ToString().PadLeft(pad, '0');

            return f.Replace("#", num);
        }

        private bool IsShowingInGrid(ViewSheet sheet)
        {
            return grid_Sheets.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["cId"].Value.Equals(sheet.Id)) != null;
        }

        public void SetFilters(List<Rule> filters)
        {
            bool changed = false;

            if (this.filters.Count == filters.Count)
            {
                for (int i = 0; i < this.filters.Count && !changed; i++)
                {
                    changed |= !this.filters[i].Equals(filters[i]);
                }
            }
            else
            {
                changed = true;
            }

            if (changed)
            {
                if (filters.Count > 0)
                {
                    label4.Font = new Font("Tahoma", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Strikeout))), GraphicsUnit.Point, ((byte)(0)));
                    btn_Filter.BackColor = Color.Yellow;
                }
                else
                {
                    label4.Font = new Font("Tahoma", 9.75F, ((FontStyle)((FontStyle.Bold))), GraphicsUnit.Point, ((byte)(0)));
                    btn_Filter.UseVisualStyleBackColor = true;
                }

                this.filters = filters;                

                LoadSheetData();
            }
        }
    }

    public class Rule
    {
        private string filter;
        private string criteria;
        private string value;
        private bool caseSensitive;

        public Rule(string filter, string criteria, string value, bool caseSensitive = true)
        {
            this.filter = filter;
            this.criteria = criteria;
            this.value = value;
            this.caseSensitive = caseSensitive;
        }

        public bool Equals(Rule rule)
        {
            return filter.Equals(rule.filter) && criteria.Equals(rule.criteria) && value.Equals(rule.value) && caseSensitive.Equals(rule.caseSensitive);
        }

        public bool Evaluate(ViewSheet sheet)
        {
            bool passed;

            switch (filter)
            {
                case "#":
                    passed = EvaluateCriteria(sheet.SheetNumber);
                    break;

                case "Name":
                    passed = EvaluateCriteria(sheet.Name);
                    break;

                default:
                    passed = false;
                    break;
            }

            return passed;
        }

        private bool EvaluateCriteria(string value)
        {
            bool passed;

            switch (criteria)
            {
                case "equals":
                    passed = !caseSensitive ? value.Equals(this.value, StringComparison.OrdinalIgnoreCase) : value.Equals(this.value);
                    break;

                case "does not equal":
                    passed = !caseSensitive ? !value.Equals(this.value, StringComparison.OrdinalIgnoreCase) : !value.Equals(this.value);
                    break;

                case "contains":
                    passed = !caseSensitive ? value.ToUpper().Contains(this.value.ToUpper()) : value.Contains(this.value);
                    break;

                case "not contains":
                    passed = !caseSensitive ? !value.ToUpper().Contains(this.value.ToUpper()) : !value.Contains(this.value);
                    break;

                case "is greater than":
                    try
                    {
                        passed = NumericToken(value) > NumericToken(this.value);
                    }
                    catch (Exception)
                    {
                        passed = false;
                    }
                    break;

                case "is greater than or equal to":
                    try
                    {
                        passed = NumericToken(value) >= NumericToken(this.value);
                    }
                    catch (Exception)
                    {
                        passed = false;
                    }
                    break;

                case "is less than":
                    try
                    {
                        passed = NumericToken(value) < NumericToken(this.value);
                    }
                    catch (Exception)
                    {
                        passed = false;
                    }
                    break;

                case "is less than or equal to":
                    try
                    {
                        passed = NumericToken(value) <= NumericToken(this.value);
                    }
                    catch (Exception)
                    {
                        passed = false;
                    }
                    break;

                default:
                    passed = false;
                    break;
            }

            return passed;
        }

        private int NumericToken(string value)
        {
            string token = string.Empty;
            int d;
            bool stop = false;

            for (int i = value.Length - 1; i >= 0 && !stop; i--)
            {
                if (int.TryParse(value[i].ToString(), out d))
                {
                    token = d.ToString() + token;
                }
                else if (token.Length > 0)
                {
                    stop = true;
                }
            }

            return int.Parse(token);
        }
    }
}
