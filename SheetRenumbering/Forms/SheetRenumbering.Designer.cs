namespace BBI.JD.Forms
{
    partial class SheetRenumbering
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheetRenumbering));
            this.grid_Sheets = new System.Windows.Forms.DataGridView();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNewNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SetType = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Format = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_Start = new System.Windows.Forms.NumericUpDown();
            this.num_Pad = new System.Windows.Forms.NumericUpDown();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sheets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Pad)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Sheets
            // 
            this.grid_Sheets.AllowUserToAddRows = false;
            this.grid_Sheets.AllowUserToDeleteRows = false;
            this.grid_Sheets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Sheets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Sheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Sheets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIndex,
            this.cId,
            this.cNumber,
            this.cNewNumber,
            this.cName});
            this.grid_Sheets.Location = new System.Drawing.Point(15, 138);
            this.grid_Sheets.MultiSelect = false;
            this.grid_Sheets.Name = "grid_Sheets";
            this.grid_Sheets.ReadOnly = true;
            this.grid_Sheets.Size = new System.Drawing.Size(499, 293);
            this.grid_Sheets.TabIndex = 7;
            // 
            // cIndex
            // 
            this.cIndex.HeaderText = "Index";
            this.cIndex.Name = "cIndex";
            this.cIndex.ReadOnly = true;
            this.cIndex.Visible = false;
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cNumber
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = null;
            this.cNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.cNumber.FillWeight = 74.6193F;
            this.cNumber.HeaderText = "#";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            this.cNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNumber.ToolTipText = "Sheet number";
            // 
            // cNewNumber
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cNewNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.cNewNumber.FillWeight = 75.49043F;
            this.cNewNumber.HeaderText = "New #";
            this.cNewNumber.Name = "cNewNumber";
            this.cNewNumber.ReadOnly = true;
            this.cNewNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cName
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = null;
            this.cName.DefaultCellStyle = dataGridViewCellStyle6;
            this.cName.FillWeight = 149.8903F;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(260, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sheets";
            // 
            // cmb_SetType
            // 
            this.cmb_SetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SetType.FormattingEnabled = true;
            this.cmb_SetType.Items.AddRange(new object[] {
            "Sheets in the file",
            "Sheets in the selection"});
            this.cmb_SetType.Location = new System.Drawing.Point(15, 30);
            this.cmb_SetType.Name = "cmb_SetType";
            this.cmb_SetType.Size = new System.Drawing.Size(239, 21);
            this.cmb_SetType.TabIndex = 1;
            this.cmb_SetType.SelectedIndexChanged += new System.EventHandler(this.cmb_SetType_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Cancel.Location = new System.Drawing.Point(439, 442);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Ok.Location = new System.Drawing.Point(351, 442);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Up.Location = new System.Drawing.Point(526, 204);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(33, 41);
            this.btn_Up.TabIndex = 8;
            this.btn_Up.Text = "↑";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Down.Location = new System.Drawing.Point(526, 285);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(33, 41);
            this.btn_Down.TabIndex = 9;
            this.btn_Down.Text = "↓";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Format";
            // 
            // txt_Format
            // 
            this.txt_Format.Location = new System.Drawing.Point(15, 82);
            this.txt_Format.Name = "txt_Format";
            this.txt_Format.Size = new System.Drawing.Size(184, 20);
            this.txt_Format.TabIndex = 3;
            this.txt_Format.Text = "#";
            this.txt_Format.TextChanged += new System.EventHandler(this.txt_Format_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(242, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Start #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(367, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Zero padding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Italic);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ex: ";
            // 
            // num_Start
            // 
            this.num_Start.Location = new System.Drawing.Point(245, 82);
            this.num_Start.Name = "num_Start";
            this.num_Start.Size = new System.Drawing.Size(72, 20);
            this.num_Start.TabIndex = 4;
            this.num_Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Start.ValueChanged += new System.EventHandler(this.num_Start_ValueChanged);
            // 
            // num_Pad
            // 
            this.num_Pad.Location = new System.Drawing.Point(370, 82);
            this.num_Pad.Name = "num_Pad";
            this.num_Pad.Size = new System.Drawing.Size(72, 20);
            this.num_Pad.TabIndex = 5;
            this.num_Pad.ValueChanged += new System.EventHandler(this.num_Pad_ValueChanged);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Enabled = false;
            this.btn_Apply.Image = ((System.Drawing.Image)(resources.GetObject("btn_Apply.Image")));
            this.btn_Apply.Location = new System.Drawing.Point(486, 79);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(28, 26);
            this.btn_Apply.TabIndex = 6;
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filter.Image")));
            this.btn_Filter.Location = new System.Drawing.Point(302, 25);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(35, 30);
            this.btn_Filter.TabIndex = 2;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // SheetRenumbering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(570, 477);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.num_Pad);
            this.Controls.Add(this.num_Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Format);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SetType);
            this.Controls.Add(this.grid_Sheets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SheetRenumbering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = GetTiTleForm(); /*"Sheet Renumbering - TEST";*/
            this.Load += new System.EventHandler(this.SheetRenumbering_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SheetRenumbering_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sheets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Pad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_Sheets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SetType;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Format;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_Start;
        private System.Windows.Forms.NumericUpDown num_Pad;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNewNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
    }
}