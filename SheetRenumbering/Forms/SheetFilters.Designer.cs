namespace BBI.JD.Forms
{
    partial class SheetFilters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheetFilters));
            this.txt_Value1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Filter1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Criteria1 = new System.Windows.Forms.ComboBox();
            this.cmb_Criteria2 = new System.Windows.Forms.ComboBox();
            this.txt_Value2 = new System.Windows.Forms.TextBox();
            this.cmb_Filter2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.chk_Sensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_Value1
            // 
            this.txt_Value1.Location = new System.Drawing.Point(392, 66);
            this.txt_Value1.Name = "txt_Value1";
            this.txt_Value1.Size = new System.Drawing.Size(181, 20);
            this.txt_Value1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Filter by:";
            // 
            // cmb_Filter1
            // 
            this.cmb_Filter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filter1.FormattingEnabled = true;
            this.cmb_Filter1.Items.AddRange(new object[] {
            "(none)"});
            this.cmb_Filter1.Location = new System.Drawing.Point(88, 65);
            this.cmb_Filter1.Name = "cmb_Filter1";
            this.cmb_Filter1.Size = new System.Drawing.Size(120, 21);
            this.cmb_Filter1.TabIndex = 2;
            this.cmb_Filter1.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "And:";
            // 
            // cmb_Criteria1
            // 
            this.cmb_Criteria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Criteria1.FormattingEnabled = true;
            this.cmb_Criteria1.Items.AddRange(new object[] {
            "equals",
            "does not equal",
            "contains",
            "not contains",
            "is greater than",
            "is greater than or equal to",
            "is less than",
            "is less than or equal to"});
            this.cmb_Criteria1.Location = new System.Drawing.Point(236, 65);
            this.cmb_Criteria1.Name = "cmb_Criteria1";
            this.cmb_Criteria1.Size = new System.Drawing.Size(130, 21);
            this.cmb_Criteria1.TabIndex = 3;
            // 
            // cmb_Criteria2
            // 
            this.cmb_Criteria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Criteria2.FormattingEnabled = true;
            this.cmb_Criteria2.Items.AddRange(new object[] {
            "equals",
            "does not equal",
            "contains",
            "not contains",
            "is greater than",
            "is greater than or equal to",
            "is less than",
            "is less than or equal to"});
            this.cmb_Criteria2.Location = new System.Drawing.Point(236, 103);
            this.cmb_Criteria2.Name = "cmb_Criteria2";
            this.cmb_Criteria2.Size = new System.Drawing.Size(130, 21);
            this.cmb_Criteria2.TabIndex = 6;
            // 
            // txt_Value2
            // 
            this.txt_Value2.Location = new System.Drawing.Point(392, 104);
            this.txt_Value2.Name = "txt_Value2";
            this.txt_Value2.Size = new System.Drawing.Size(181, 20);
            this.txt_Value2.TabIndex = 7;
            // 
            // cmb_Filter2
            // 
            this.cmb_Filter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filter2.FormattingEnabled = true;
            this.cmb_Filter2.Location = new System.Drawing.Point(88, 103);
            this.cmb_Filter2.Name = "cmb_Filter2";
            this.cmb_Filter2.Size = new System.Drawing.Size(120, 21);
            this.cmb_Filter2.TabIndex = 5;
            this.cmb_Filter2.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(162, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Filter sheets according following criteria";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Enabled = false;
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(408, 151);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Ok.Location = new System.Drawing.Point(498, 151);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // chk_Sensitive
            // 
            this.chk_Sensitive.AutoSize = true;
            this.chk_Sensitive.Checked = true;
            this.chk_Sensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Sensitive.Location = new System.Drawing.Point(479, 32);
            this.chk_Sensitive.Name = "chk_Sensitive";
            this.chk_Sensitive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Sensitive.Size = new System.Drawing.Size(94, 17);
            this.chk_Sensitive.TabIndex = 1;
            this.chk_Sensitive.Text = "Case sensitive";
            this.chk_Sensitive.UseVisualStyleBackColor = true;
            // 
            // SheetFilters
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 186);
            this.Controls.Add(this.chk_Sensitive);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Criteria2);
            this.Controls.Add(this.txt_Value2);
            this.Controls.Add(this.cmb_Filter2);
            this.Controls.Add(this.cmb_Criteria1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Value1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Filter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 225);
            this.MinimumSize = new System.Drawing.Size(605, 225);
            this.Name = "SheetFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet filters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SheetFilters_FormClosing);
            this.Load += new System.EventHandler(this.SheetFilters_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SheetFilters_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Value1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Filter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Criteria1;
        private System.Windows.Forms.ComboBox cmb_Criteria2;
        private System.Windows.Forms.TextBox txt_Value2;
        private System.Windows.Forms.ComboBox cmb_Filter2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.CheckBox chk_Sensitive;
    }
}