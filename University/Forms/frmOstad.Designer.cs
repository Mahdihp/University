namespace University.Forms
{
    partial class frmOstad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NumberHomeAddNew = new System.Windows.Forms.MaskedTextBox();
            this.txt_NumberMobileAddNEw = new System.Windows.Forms.MaskedTextBox();
            this.txt_SSAddNew = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodemelliAddNew = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodeOstadAddNew = new System.Windows.Forms.MaskedTextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_SaveAddNew = new System.Windows.Forms.Button();
            this.txt_AddressAddNew = new System.Windows.Forms.TextBox();
            this.com_AddNew = new System.Windows.Forms.ComboBox();
            this.txt_LNameAddNew = new System.Windows.Forms.TextBox();
            this.txt_NameAddNew = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_LNameSearch = new System.Windows.Forms.TextBox();
            this.txt_codeOstadSearch = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gridviewOstad = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ostad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_meli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sh_sh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_NumberHomeEdit = new System.Windows.Forms.MaskedTextBox();
            this.txt_NumberMobileEdit = new System.Windows.Forms.MaskedTextBox();
            this.txt_SSEdit = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodemellEdit = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodeOstadEdit = new System.Windows.Forms.MaskedTextBox();
            this.btn_SaveEdit = new System.Windows.Forms.Button();
            this.txt_AddressEdit = new System.Windows.Forms.TextBox();
            this.com_MadrakEdit = new System.Windows.Forms.ComboBox();
            this.txt_LNameEdit = new System.Windows.Forms.TextBox();
            this.txt_NameEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewOstad)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(662, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(654, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "استاد جدید";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NumberHomeAddNew);
            this.groupBox1.Controls.Add(this.txt_NumberMobileAddNEw);
            this.groupBox1.Controls.Add(this.txt_SSAddNew);
            this.groupBox1.Controls.Add(this.txt_CodemelliAddNew);
            this.groupBox1.Controls.Add(this.txt_CodeOstadAddNew);
            this.groupBox1.Controls.Add(this.btn_AddNew);
            this.groupBox1.Controls.Add(this.btn_SaveAddNew);
            this.groupBox1.Controls.Add(this.txt_AddressAddNew);
            this.groupBox1.Controls.Add(this.com_AddNew);
            this.groupBox1.Controls.Add(this.txt_LNameAddNew);
            this.groupBox1.Controls.Add(this.txt_NameAddNew);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(634, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // txt_NumberHomeAddNew
            // 
            this.txt_NumberHomeAddNew.Location = new System.Drawing.Point(227, 107);
            this.txt_NumberHomeAddNew.Mask = "00000000";
            this.txt_NumberHomeAddNew.Name = "txt_NumberHomeAddNew";
            this.txt_NumberHomeAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NumberHomeAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_NumberHomeAddNew.TabIndex = 7;
            this.txt_NumberHomeAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_NumberMobileAddNEw
            // 
            this.txt_NumberMobileAddNEw.Location = new System.Drawing.Point(449, 107);
            this.txt_NumberMobileAddNEw.Mask = "00000000000";
            this.txt_NumberMobileAddNEw.Name = "txt_NumberMobileAddNEw";
            this.txt_NumberMobileAddNEw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NumberMobileAddNEw.Size = new System.Drawing.Size(100, 22);
            this.txt_NumberMobileAddNEw.TabIndex = 6;
            this.txt_NumberMobileAddNEw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SSAddNew
            // 
            this.txt_SSAddNew.Location = new System.Drawing.Point(227, 67);
            this.txt_SSAddNew.Mask = "00000";
            this.txt_SSAddNew.Name = "txt_SSAddNew";
            this.txt_SSAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SSAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_SSAddNew.TabIndex = 4;
            this.txt_SSAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CodemelliAddNew
            // 
            this.txt_CodemelliAddNew.Location = new System.Drawing.Point(449, 67);
            this.txt_CodemelliAddNew.Mask = "0000000000";
            this.txt_CodemelliAddNew.Name = "txt_CodemelliAddNew";
            this.txt_CodemelliAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodemelliAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_CodemelliAddNew.TabIndex = 3;
            this.txt_CodemelliAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CodeOstadAddNew
            // 
            this.txt_CodeOstadAddNew.Location = new System.Drawing.Point(449, 27);
            this.txt_CodeOstadAddNew.Mask = "00000";
            this.txt_CodeOstadAddNew.Name = "txt_CodeOstadAddNew";
            this.txt_CodeOstadAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeOstadAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_CodeOstadAddNew.TabIndex = 0;
            this.txt_CodeOstadAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(6, 244);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_AddNew.TabIndex = 10;
            this.btn_AddNew.Text = "جدید";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_SaveAddNew
            // 
            this.btn_SaveAddNew.Location = new System.Drawing.Point(104, 244);
            this.btn_SaveAddNew.Name = "btn_SaveAddNew";
            this.btn_SaveAddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveAddNew.TabIndex = 9;
            this.btn_SaveAddNew.Text = "ذخیره";
            this.btn_SaveAddNew.UseVisualStyleBackColor = true;
            this.btn_SaveAddNew.Click += new System.EventHandler(this.btn_SaveAddNew_Click);
            // 
            // txt_AddressAddNew
            // 
            this.txt_AddressAddNew.Location = new System.Drawing.Point(208, 148);
            this.txt_AddressAddNew.Multiline = true;
            this.txt_AddressAddNew.Name = "txt_AddressAddNew";
            this.txt_AddressAddNew.Size = new System.Drawing.Size(375, 74);
            this.txt_AddressAddNew.TabIndex = 8;
            // 
            // com_AddNew
            // 
            this.com_AddNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_AddNew.FormattingEnabled = true;
            this.com_AddNew.Items.AddRange(new object[] {
            "لیسانس",
            "فوق لیسانس",
            "دکتری",
            "فوق دکتری"});
            this.com_AddNew.Location = new System.Drawing.Point(6, 67);
            this.com_AddNew.Name = "com_AddNew";
            this.com_AddNew.Size = new System.Drawing.Size(170, 22);
            this.com_AddNew.TabIndex = 5;
            // 
            // txt_LNameAddNew
            // 
            this.txt_LNameAddNew.Location = new System.Drawing.Point(6, 27);
            this.txt_LNameAddNew.Name = "txt_LNameAddNew";
            this.txt_LNameAddNew.Size = new System.Drawing.Size(170, 22);
            this.txt_LNameAddNew.TabIndex = 2;
            // 
            // txt_NameAddNew
            // 
            this.txt_NameAddNew.Location = new System.Drawing.Point(264, 27);
            this.txt_NameAddNew.Name = "txt_NameAddNew";
            this.txt_NameAddNew.Size = new System.Drawing.Size(147, 22);
            this.txt_NameAddNew.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "آدرس:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "شماره منزل:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "شماره همراه:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "مدرک:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره شناسنامه:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "کد ملی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام خانوادگی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد مدرسی: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(654, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ویرایش استاد";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_LNameSearch);
            this.groupBox2.Controls.Add(this.txt_codeOstadSearch);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.gridviewOstad);
            this.groupBox2.Controls.Add(this.txt_NumberHomeEdit);
            this.groupBox2.Controls.Add(this.txt_NumberMobileEdit);
            this.groupBox2.Controls.Add(this.txt_SSEdit);
            this.groupBox2.Controls.Add(this.txt_CodemellEdit);
            this.groupBox2.Controls.Add(this.txt_CodeOstadEdit);
            this.groupBox2.Controls.Add(this.btn_SaveEdit);
            this.groupBox2.Controls.Add(this.txt_AddressEdit);
            this.groupBox2.Controls.Add(this.com_MadrakEdit);
            this.groupBox2.Controls.Add(this.txt_LNameEdit);
            this.groupBox2.Controls.Add(this.txt_NameEdit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(634, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ورود اطلاعات";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 239);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 31);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_LNameSearch
            // 
            this.txt_LNameSearch.Location = new System.Drawing.Point(154, 243);
            this.txt_LNameSearch.Name = "txt_LNameSearch";
            this.txt_LNameSearch.Size = new System.Drawing.Size(147, 22);
            this.txt_LNameSearch.TabIndex = 15;
            this.txt_LNameSearch.TextChanged += new System.EventHandler(this.txt_LNameSearch_TextChanged);
            // 
            // txt_codeOstadSearch
            // 
            this.txt_codeOstadSearch.Location = new System.Drawing.Point(449, 243);
            this.txt_codeOstadSearch.Mask = "00000";
            this.txt_codeOstadSearch.Name = "txt_codeOstadSearch";
            this.txt_codeOstadSearch.Size = new System.Drawing.Size(100, 22);
            this.txt_codeOstadSearch.TabIndex = 14;
            this.txt_codeOstadSearch.TextChanged += new System.EventHandler(this.txt_codeOstadSearch_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 14);
            this.label20.TabIndex = 13;
            this.label20.Text = "نام خانوادگی :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(549, 247);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 14);
            this.label19.TabIndex = 12;
            this.label19.Text = "کد مدرسی: ";
            // 
            // gridviewOstad
            // 
            this.gridviewOstad.AllowUserToAddRows = false;
            this.gridviewOstad.AllowUserToDeleteRows = false;
            this.gridviewOstad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewOstad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewOstad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_ostad,
            this.name,
            this.family,
            this.id_meli,
            this.sh_sh,
            this.madrak,
            this.mobile,
            this.tel,
            this.address,
            this.delete,
            this.edit});
            this.gridviewOstad.Location = new System.Drawing.Point(6, 276);
            this.gridviewOstad.Name = "gridviewOstad";
            this.gridviewOstad.ReadOnly = true;
            this.gridviewOstad.RowTemplate.Height = 30;
            this.gridviewOstad.Size = new System.Drawing.Size(619, 334);
            this.gridviewOstad.TabIndex = 11;
            this.gridviewOstad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewOstad_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_ostad
            // 
            this.id_ostad.DataPropertyName = "id_ostad";
            this.id_ostad.HeaderText = "کد مدرسی";
            this.id_ostad.Name = "id_ostad";
            this.id_ostad.ReadOnly = true;
            this.id_ostad.Width = 80;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "فامیلی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            // 
            // id_meli
            // 
            this.id_meli.DataPropertyName = "id_meli";
            this.id_meli.HeaderText = "کد ملی";
            this.id_meli.Name = "id_meli";
            this.id_meli.ReadOnly = true;
            // 
            // sh_sh
            // 
            this.sh_sh.DataPropertyName = "sh_sh";
            this.sh_sh.HeaderText = "ش ش";
            this.sh_sh.Name = "sh_sh";
            this.sh_sh.ReadOnly = true;
            this.sh_sh.Visible = false;
            // 
            // madrak
            // 
            this.madrak.DataPropertyName = "madrak";
            this.madrak.HeaderText = "مدرک";
            this.madrak.Name = "madrak";
            this.madrak.ReadOnly = true;
            this.madrak.Visible = false;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "موبایل";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Visible = false;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "تلفن";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Visible = false;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "آدرس";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // delete
            // 
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "حذف";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 90;
            // 
            // edit
            // 
            this.edit.HeaderText = "ویرایش";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "ویرایش";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 90;
            // 
            // txt_NumberHomeEdit
            // 
            this.txt_NumberHomeEdit.Location = new System.Drawing.Point(227, 107);
            this.txt_NumberHomeEdit.Mask = "00000000";
            this.txt_NumberHomeEdit.Name = "txt_NumberHomeEdit";
            this.txt_NumberHomeEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NumberHomeEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_NumberHomeEdit.TabIndex = 7;
            this.txt_NumberHomeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_NumberMobileEdit
            // 
            this.txt_NumberMobileEdit.Location = new System.Drawing.Point(449, 107);
            this.txt_NumberMobileEdit.Mask = "00000000000";
            this.txt_NumberMobileEdit.Name = "txt_NumberMobileEdit";
            this.txt_NumberMobileEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NumberMobileEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_NumberMobileEdit.TabIndex = 6;
            this.txt_NumberMobileEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SSEdit
            // 
            this.txt_SSEdit.Location = new System.Drawing.Point(227, 67);
            this.txt_SSEdit.Mask = "00000";
            this.txt_SSEdit.Name = "txt_SSEdit";
            this.txt_SSEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SSEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_SSEdit.TabIndex = 4;
            this.txt_SSEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CodemellEdit
            // 
            this.txt_CodemellEdit.Location = new System.Drawing.Point(449, 67);
            this.txt_CodemellEdit.Mask = "0000000000";
            this.txt_CodemellEdit.Name = "txt_CodemellEdit";
            this.txt_CodemellEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodemellEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_CodemellEdit.TabIndex = 3;
            this.txt_CodemellEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CodeOstadEdit
            // 
            this.txt_CodeOstadEdit.Location = new System.Drawing.Point(449, 27);
            this.txt_CodeOstadEdit.Mask = "00000";
            this.txt_CodeOstadEdit.Name = "txt_CodeOstadEdit";
            this.txt_CodeOstadEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeOstadEdit.Size = new System.Drawing.Size(100, 22);
            this.txt_CodeOstadEdit.TabIndex = 0;
            this.txt_CodeOstadEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SaveEdit
            // 
            this.btn_SaveEdit.Location = new System.Drawing.Point(6, 202);
            this.btn_SaveEdit.Name = "btn_SaveEdit";
            this.btn_SaveEdit.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveEdit.TabIndex = 9;
            this.btn_SaveEdit.Text = "ذخیره";
            this.btn_SaveEdit.UseVisualStyleBackColor = true;
            this.btn_SaveEdit.Click += new System.EventHandler(this.btn_SaveEdit_Click);
            // 
            // txt_AddressEdit
            // 
            this.txt_AddressEdit.Location = new System.Drawing.Point(208, 148);
            this.txt_AddressEdit.Multiline = true;
            this.txt_AddressEdit.Name = "txt_AddressEdit";
            this.txt_AddressEdit.Size = new System.Drawing.Size(375, 74);
            this.txt_AddressEdit.TabIndex = 8;
            // 
            // com_MadrakEdit
            // 
            this.com_MadrakEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MadrakEdit.FormattingEnabled = true;
            this.com_MadrakEdit.Items.AddRange(new object[] {
            "لیسانس",
            "فوق لیسانس",
            "دکتری",
            "فوق دکتری"});
            this.com_MadrakEdit.Location = new System.Drawing.Point(6, 67);
            this.com_MadrakEdit.Name = "com_MadrakEdit";
            this.com_MadrakEdit.Size = new System.Drawing.Size(170, 22);
            this.com_MadrakEdit.TabIndex = 5;
            // 
            // txt_LNameEdit
            // 
            this.txt_LNameEdit.Location = new System.Drawing.Point(6, 27);
            this.txt_LNameEdit.Name = "txt_LNameEdit";
            this.txt_LNameEdit.Size = new System.Drawing.Size(170, 22);
            this.txt_LNameEdit.TabIndex = 2;
            // 
            // txt_NameEdit
            // 
            this.txt_NameEdit.Location = new System.Drawing.Point(264, 27);
            this.txt_NameEdit.Name = "txt_NameEdit";
            this.txt_NameEdit.Size = new System.Drawing.Size(147, 22);
            this.txt_NameEdit.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 14);
            this.label10.TabIndex = 8;
            this.label10.Text = "آدرس:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "شماره منزل:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 6;
            this.label12.Text = "شماره همراه:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 14);
            this.label13.TabIndex = 5;
            this.label13.Text = "مدرک:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "شماره شناسنامه:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(574, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 14);
            this.label15.TabIndex = 3;
            this.label15.Text = "کد ملی :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(182, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "نام خانوادگی:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(405, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 14);
            this.label17.TabIndex = 1;
            this.label17.Text = "نام: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(555, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "کد مدرسی: ";
            // 
            // frmOstad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 663);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOstad";
            this.Text = "مدیریت استاد";
            this.Load += new System.EventHandler(this.frmOstad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewOstad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LNameAddNew;
        private System.Windows.Forms.TextBox txt_NameAddNew;
        private System.Windows.Forms.ComboBox com_AddNew;
        private System.Windows.Forms.TextBox txt_AddressAddNew;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_SaveAddNew;
        private System.Windows.Forms.MaskedTextBox txt_CodemelliAddNew;
        private System.Windows.Forms.MaskedTextBox txt_CodeOstadAddNew;
        private System.Windows.Forms.MaskedTextBox txt_SSAddNew;
        private System.Windows.Forms.MaskedTextBox txt_NumberHomeAddNew;
        private System.Windows.Forms.MaskedTextBox txt_NumberMobileAddNEw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_NumberHomeEdit;
        private System.Windows.Forms.MaskedTextBox txt_NumberMobileEdit;
        private System.Windows.Forms.MaskedTextBox txt_SSEdit;
        private System.Windows.Forms.MaskedTextBox txt_CodemellEdit;
        private System.Windows.Forms.MaskedTextBox txt_CodeOstadEdit;
        private System.Windows.Forms.Button btn_SaveEdit;
        private System.Windows.Forms.TextBox txt_AddressEdit;
        private System.Windows.Forms.ComboBox com_MadrakEdit;
        private System.Windows.Forms.TextBox txt_LNameEdit;
        private System.Windows.Forms.TextBox txt_NameEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView gridviewOstad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_codeOstadSearch;
        private System.Windows.Forms.TextBox txt_LNameSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_meli;
        private System.Windows.Forms.DataGridViewTextBoxColumn sh_sh;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrak;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}