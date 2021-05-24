using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBI.JD.Forms
{
    public partial class SheetFilters : Form
    {
        private static string[] filters = new string[2] { "#", "Name" };
        private SheetRenumbering formParent;
        public List<Rule> rules;

        public SheetFilters(SheetRenumbering formParent)
        {
            this.formParent = formParent;

            InitializeComponent();
        }

        private void SheetFilters_Load(object sender, EventArgs e)
        {
            cmb_Filter1.Items.AddRange(filters);
            cmb_Filter1.SelectedIndex = 0;
        }

        private void SheetFilters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void SheetFilters_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplyFilters();

            Hide();
            e.Cancel = true;
        }

        private void cmb_Filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (none)
            if (cmb_Filter1.SelectedIndex == 0)
            {
                cmb_Criteria1.Enabled = false;
                txt_Value1.Enabled = false;

                cmb_Filter2.Enabled = false;
                cmb_Criteria2.Enabled = false;
                txt_Value2.Enabled = false;
            }
            else
            {
                if (cmb_Criteria1.SelectedIndex == -1)
                {
                    cmb_Criteria1.SelectedIndex = 0;
                }
                
                cmb_Criteria1.Enabled = true;
                txt_Value1.Enabled = true;

                cmb_Filter2.Items.Clear();
                cmb_Filter2.Items.Add("(none)");
                cmb_Filter2.Items.AddRange(filters);

                // Exclude one filter by rule
                /*foreach (string filter in filters)
                {
                    if (filter != cmb_Filter1.Text)
                    {
                        cmb_Filter2.Items.Add(filter);
                    }
                }*/

                cmb_Filter2.SelectedIndex = 0;
                cmb_Filter2.Enabled = true;

                btn_Clear.Enabled = true;
            }
        }

        private void cmb_Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (none)
            if (cmb_Filter2.SelectedIndex == 0)
            {
                cmb_Criteria2.Enabled = false;
                txt_Value2.Enabled = false;
            }
            else
            {
                if (cmb_Criteria2.SelectedIndex == -1)
                {
                    cmb_Criteria2.SelectedIndex = 0;
                }

                cmb_Criteria2.Enabled = true;
                txt_Value2.Enabled = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Filter1.SelectedIndex = 0;
            cmb_Criteria1.SelectedIndex = 0;
            txt_Value1.Clear();

            cmb_Filter2.SelectedIndex = 0;
            cmb_Criteria2.SelectedIndex = 0;
            txt_Value2.Clear();

            btn_Clear.Enabled = false;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyFilters()
        {
            rules = new List<Rule>();

            if (cmb_Filter1.Enabled & cmb_Criteria1.Enabled & txt_Value1.Enabled)
            {
                rules.Add(new Rule(
                    cmb_Filter1.Text,
                    cmb_Criteria1.Text,
                    txt_Value1.Text,
                    chk_Sensitive.Checked
                ));
            }

            if (cmb_Filter2.Enabled & cmb_Criteria2.Enabled & txt_Value2.Enabled)
            {
                rules.Add(new Rule(
                    cmb_Filter2.Text,
                    cmb_Criteria2.Text,
                    txt_Value2.Text,
                    chk_Sensitive.Checked
                ));
            }

            formParent.SetFilters(rules);
        }
    }
}
