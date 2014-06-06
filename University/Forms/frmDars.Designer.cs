namespace University.Forms
{
    partial class frmDars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDars));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CodeDarsAddNew = new System.Windows.Forms.MaskedTextBox();
            this.btn_SaveAddNew = new System.Windows.Forms.Button();
            this.com_TypeAddNew = new System.Windows.Forms.ComboBox();
            this.txt_CountVahedAddNew = new System.Windows.Forms.TextBox();
            this.txt_NameDarsAddNew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SaveEdit1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CodeDarsEdit = new System.Windows.Forms.MaskedTextBox();
            this.com_TypeEdit = new System.Windows.Forms.ComboBox();
            this.txt_CountVahedEdit = new System.Windows.Forms.TextBox();
            this.txt_NameDarsEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_NameDarsSearch = new System.Windows.Forms.TextBox();
            this.txt_codeDarsSearch = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gridviewDars = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad_vahed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_SaveEdit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDars)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 558);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(560, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "درس جدید";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CodeDarsAddNew);
            this.groupBox1.Controls.Add(this.btn_SaveAddNew);
            this.groupBox1.Controls.Add(this.com_TypeAddNew);
            this.groupBox1.Controls.Add(this.txt_CountVahedAddNew);
            this.groupBox1.Controls.Add(this.txt_NameDarsAddNew);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(540, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // txt_CodeDarsAddNew
            // 
            this.txt_CodeDarsAddNew.Location = new System.Drawing.Point(373, 21);
            this.txt_CodeDarsAddNew.Mask = "0000";
            this.txt_CodeDarsAddNew.Name = "txt_CodeDarsAddNew";
            this.txt_CodeDarsAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeDarsAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_CodeDarsAddNew.TabIndex = 0;
            this.txt_CodeDarsAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SaveAddNew
            // 
            this.btn_SaveAddNew.Location = new System.Drawing.Point(6, 104);
            this.btn_SaveAddNew.Name = "btn_SaveAddNew";
            this.btn_SaveAddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveAddNew.TabIndex = 4;
            this.btn_SaveAddNew.Text = "ذخیره";
            this.btn_SaveAddNew.UseVisualStyleBackColor = true;
            this.btn_SaveAddNew.Click += new System.EventHandler(this.btn_SaveAddNew_Click);
            // 
            // com_TypeAddNew
            // 
            this.com_TypeAddNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_TypeAddNew.FormattingEnabled = true;
            this.com_TypeAddNew.Items.AddRange(new object[] {
            "اجباری",
            "اختیاری",
            "پیش نیاز",
            "هم نیاز"});
            this.com_TypeAddNew.Location = new System.Drawing.Point(303, 63);
            this.com_TypeAddNew.Name = "com_TypeAddNew";
            this.com_TypeAddNew.Size = new System.Drawing.Size(170, 22);
            this.com_TypeAddNew.TabIndex = 3;
            // 
            // txt_CountVahedAddNew
            // 
            this.txt_CountVahedAddNew.Location = new System.Drawing.Point(12, 22);
            this.txt_CountVahedAddNew.Name = "txt_CountVahedAddNew";
            this.txt_CountVahedAddNew.Size = new System.Drawing.Size(60, 22);
            this.txt_CountVahedAddNew.TabIndex = 2;
            // 
            // txt_NameDarsAddNew
            // 
            this.txt_NameDarsAddNew.Location = new System.Drawing.Point(160, 21);
            this.txt_NameDarsAddNew.Name = "txt_NameDarsAddNew";
            this.txt_NameDarsAddNew.Size = new System.Drawing.Size(147, 22);
            this.txt_NameDarsAddNew.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "نوع درس:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "تعداد واحد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام درس:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد درس:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(560, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ویرایش درس";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SaveEdit1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_CodeDarsEdit);
            this.groupBox2.Controls.Add(this.com_TypeEdit);
            this.groupBox2.Controls.Add(this.txt_CountVahedEdit);
            this.groupBox2.Controls.Add(this.txt_NameDarsEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_NameDarsSearch);
            this.groupBox2.Controls.Add(this.txt_codeDarsSearch);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.gridviewDars);
            this.groupBox2.Controls.Add(this.btn_SaveEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(540, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ورود اطلاعات";
            // 
            // btn_SaveEdit1
            // 
            this.btn_SaveEdit1.Location = new System.Drawing.Point(6, 109);
            this.btn_SaveEdit1.Name = "btn_SaveEdit1";
            this.btn_SaveEdit1.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveEdit1.TabIndex = 4;
            this.btn_SaveEdit1.Text = "ذخیره";
            this.btn_SaveEdit1.UseVisualStyleBackColor = true;
            this.btn_SaveEdit1.Click += new System.EventHandler(this.btn_SaveEdit1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "کد درس:";
            // 
            // txt_CodeDarsEdit
            // 
            this.txt_CodeDarsEdit.Location = new System.Drawing.Point(367, 20);
            this.txt_CodeDarsEdit.Mask = "00000";
            this.txt_CodeDarsEdit.Name = "txt_CodeDarsEdit";
            this.txt_CodeDarsEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeDarsEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_CodeDarsEdit.TabIndex = 0;
            this.txt_CodeDarsEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // com_TypeEdit
            // 
            this.com_TypeEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_TypeEdit.FormattingEnabled = true;
            this.com_TypeEdit.Items.AddRange(new object[] {
            "اجباری",
            "اختیاری",
            "هم نیاز",
            "پیش نیاز"});
            this.com_TypeEdit.Location = new System.Drawing.Point(297, 62);
            this.com_TypeEdit.Name = "com_TypeEdit";
            this.com_TypeEdit.Size = new System.Drawing.Size(170, 22);
            this.com_TypeEdit.TabIndex = 3;
            // 
            // txt_CountVahedEdit
            // 
            this.txt_CountVahedEdit.Location = new System.Drawing.Point(6, 21);
            this.txt_CountVahedEdit.Name = "txt_CountVahedEdit";
            this.txt_CountVahedEdit.Size = new System.Drawing.Size(60, 22);
            this.txt_CountVahedEdit.TabIndex = 2;
            // 
            // txt_NameDarsEdit
            // 
            this.txt_NameDarsEdit.Location = new System.Drawing.Point(154, 20);
            this.txt_NameDarsEdit.Name = "txt_NameDarsEdit";
            this.txt_NameDarsEdit.Size = new System.Drawing.Size(147, 22);
            this.txt_NameDarsEdit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "نوع درس:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "تعداد واحد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "نام درس:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "کد درس:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 146);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 31);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_NameDarsSearch
            // 
            this.txt_NameDarsSearch.Location = new System.Drawing.Point(104, 151);
            this.txt_NameDarsSearch.Name = "txt_NameDarsSearch";
            this.txt_NameDarsSearch.Size = new System.Drawing.Size(147, 22);
            this.txt_NameDarsSearch.TabIndex = 6;
            this.txt_NameDarsSearch.TextChanged += new System.EventHandler(this.txt_NameDarsSearch_TextChanged);
            // 
            // txt_codeDarsSearch
            // 
            this.txt_codeDarsSearch.Location = new System.Drawing.Point(343, 152);
            this.txt_codeDarsSearch.Mask = "0000";
            this.txt_codeDarsSearch.Name = "txt_codeDarsSearch";
            this.txt_codeDarsSearch.Size = new System.Drawing.Size(100, 22);
            this.txt_codeDarsSearch.TabIndex = 5;
            this.txt_codeDarsSearch.TextChanged += new System.EventHandler(this.txt_codeDarsSearch_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(257, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 14);
            this.label20.TabIndex = 13;
            this.label20.Text = "نام درس:";
            // 
            // gridviewDars
            // 
            this.gridviewDars.AllowUserToAddRows = false;
            this.gridviewDars.AllowUserToDeleteRows = false;
            this.gridviewDars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_dars,
            this.name,
            this.tedad_vahed,
            this.type,
            this.delete,
            this.edit});
            this.gridviewDars.Location = new System.Drawing.Point(6, 183);
            this.gridviewDars.Name = "gridviewDars";
            this.gridviewDars.ReadOnly = true;
            this.gridviewDars.RowHeadersWidth = 20;
            this.gridviewDars.RowTemplate.Height = 30;
            this.gridviewDars.Size = new System.Drawing.Size(525, 322);
            this.gridviewDars.TabIndex = 8;
            this.gridviewDars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDars_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_dars
            // 
            this.id_dars.DataPropertyName = "id_dars";
            this.id_dars.HeaderText = "کد درس";
            this.id_dars.Name = "id_dars";
            this.id_dars.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام درس";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // tedad_vahed
            // 
            this.tedad_vahed.DataPropertyName = "tedad_vahed";
            this.tedad_vahed.HeaderText = "تعداد واحد";
            this.tedad_vahed.Name = "tedad_vahed";
            this.tedad_vahed.ReadOnly = true;
            this.tedad_vahed.Width = 50;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "نوع درس";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "حذف";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 80;
            // 
            // edit
            // 
            this.edit.HeaderText = "ویرایش";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "ویرایش";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 80;
            // 
            // btn_SaveEdit
            // 
            this.btn_SaveEdit.Location = new System.Drawing.Point(6, 579);
            this.btn_SaveEdit.Name = "btn_SaveEdit";
            this.btn_SaveEdit.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveEdit.TabIndex = 9;
            this.btn_SaveEdit.Text = "ذخیره";
            this.btn_SaveEdit.UseVisualStyleBackColor = true;
            // 
            // frmDars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 558);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDars";
            this.Text = "مدیریت درس";
            this.Load += new System.EventHandler(this.frmDars_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_CodeDarsAddNew;
        private System.Windows.Forms.Button btn_SaveAddNew;
        private System.Windows.Forms.ComboBox com_TypeAddNew;
        private System.Windows.Forms.TextBox txt_CountVahedAddNew;
        private System.Windows.Forms.TextBox txt_NameDarsAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_NameDarsSearch;
        private System.Windows.Forms.MaskedTextBox txt_codeDarsSearch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView gridviewDars;
        private System.Windows.Forms.Button btn_SaveEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_CodeDarsEdit;
        private System.Windows.Forms.ComboBox com_TypeEdit;
        private System.Windows.Forms.TextBox txt_CountVahedEdit;
        private System.Windows.Forms.TextBox txt_NameDarsEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SaveEdit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dars;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad_vahed;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}