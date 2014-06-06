namespace University.Forms
{
    partial class frmKarnameh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarnameh));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.com_DarsAddNew = new System.Windows.Forms.ComboBox();
            this.com_OstadAddNew = new System.Windows.Forms.ComboBox();
            this.txt_ScoreAddNew = new System.Windows.Forms.MaskedTextBox();
            this.txt_CountVahedAddNew = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodeDaneshjooAddNew = new System.Windows.Forms.MaskedTextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_SaveAddNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_CodeDaneshjoo2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Average = new System.Windows.Forms.Label();
            this.lbl_CountCources = new System.Windows.Forms.Label();
            this.lbl_SumScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_codeDaneshjooSearch = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gridviewKarnameh = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ostad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad_vahed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewKarnameh)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(685, 651);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(677, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "نمره جدید";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.com_DarsAddNew);
            this.groupBox1.Controls.Add(this.com_OstadAddNew);
            this.groupBox1.Controls.Add(this.txt_ScoreAddNew);
            this.groupBox1.Controls.Add(this.txt_CountVahedAddNew);
            this.groupBox1.Controls.Add(this.txt_CodeDaneshjooAddNew);
            this.groupBox1.Controls.Add(this.btn_AddNew);
            this.groupBox1.Controls.Add(this.btn_SaveAddNew);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(657, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "؟";
            this.toolTip1.SetToolTip(this.button1, "جستجوی دانشجو");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // com_DarsAddNew
            // 
            this.com_DarsAddNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_DarsAddNew.FormattingEnabled = true;
            this.com_DarsAddNew.Location = new System.Drawing.Point(6, 28);
            this.com_DarsAddNew.Name = "com_DarsAddNew";
            this.com_DarsAddNew.Size = new System.Drawing.Size(121, 22);
            this.com_DarsAddNew.TabIndex = 3;
            // 
            // com_OstadAddNew
            // 
            this.com_OstadAddNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_OstadAddNew.FormattingEnabled = true;
            this.com_OstadAddNew.Location = new System.Drawing.Point(208, 27);
            this.com_OstadAddNew.Name = "com_OstadAddNew";
            this.com_OstadAddNew.Size = new System.Drawing.Size(121, 22);
            this.com_OstadAddNew.TabIndex = 2;
            this.com_OstadAddNew.SelectedIndexChanged += new System.EventHandler(this.com_OstadAddNew_SelectedIndexChanged);
            // 
            // txt_ScoreAddNew
            // 
            this.txt_ScoreAddNew.Location = new System.Drawing.Point(355, 64);
            this.txt_ScoreAddNew.Mask = "00";
            this.txt_ScoreAddNew.Name = "txt_ScoreAddNew";
            this.txt_ScoreAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ScoreAddNew.Size = new System.Drawing.Size(57, 22);
            this.txt_ScoreAddNew.TabIndex = 5;
            this.txt_ScoreAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CountVahedAddNew
            // 
            this.txt_CountVahedAddNew.Location = new System.Drawing.Point(472, 64);
            this.txt_CountVahedAddNew.Mask = "00";
            this.txt_CountVahedAddNew.Name = "txt_CountVahedAddNew";
            this.txt_CountVahedAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CountVahedAddNew.Size = new System.Drawing.Size(46, 22);
            this.txt_CountVahedAddNew.TabIndex = 4;
            this.txt_CountVahedAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CodeDaneshjooAddNew
            // 
            this.txt_CodeDaneshjooAddNew.Location = new System.Drawing.Point(419, 27);
            this.txt_CodeDaneshjooAddNew.Mask = "00000";
            this.txt_CodeDaneshjooAddNew.Name = "txt_CodeDaneshjooAddNew";
            this.txt_CodeDaneshjooAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeDaneshjooAddNew.Size = new System.Drawing.Size(100, 22);
            this.txt_CodeDaneshjooAddNew.TabIndex = 1;
            this.txt_CodeDaneshjooAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(6, 105);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_AddNew.TabIndex = 7;
            this.btn_AddNew.Text = "جدید";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_SaveAddNew
            // 
            this.btn_SaveAddNew.Location = new System.Drawing.Point(104, 105);
            this.btn_SaveAddNew.Name = "btn_SaveAddNew";
            this.btn_SaveAddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveAddNew.TabIndex = 6;
            this.btn_SaveAddNew.Text = "ذخیره";
            this.btn_SaveAddNew.UseVisualStyleBackColor = true;
            this.btn_SaveAddNew.Click += new System.EventHandler(this.btn_SaveAddNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "نمره:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "تعداد واحد:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد درس:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد استاد:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد دانشجویی:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(677, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اطلاعات نمره";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_codeDaneshjooSearch);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.gridviewKarnameh);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(657, 604);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ورود اطلاعات";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_CodeDaneshjoo2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbl_Average);
            this.groupBox3.Controls.Add(this.lbl_CountCources);
            this.groupBox3.Controls.Add(this.lbl_SumScore);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_Compute);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "محاسبه معدل";
            // 
            // txt_CodeDaneshjoo2
            // 
            this.txt_CodeDaneshjoo2.Location = new System.Drawing.Point(347, 25);
            this.txt_CodeDaneshjoo2.Mask = "00000";
            this.txt_CodeDaneshjoo2.Name = "txt_CodeDaneshjoo2";
            this.txt_CodeDaneshjoo2.Size = new System.Drawing.Size(105, 22);
            this.txt_CodeDaneshjoo2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "کد دانشجویی:";
            // 
            // lbl_Average
            // 
            this.lbl_Average.AutoSize = true;
            this.lbl_Average.Location = new System.Drawing.Point(89, 30);
            this.lbl_Average.Name = "lbl_Average";
            this.lbl_Average.Size = new System.Drawing.Size(14, 14);
            this.lbl_Average.TabIndex = 24;
            this.lbl_Average.Text = "0";
            // 
            // lbl_CountCources
            // 
            this.lbl_CountCources.AutoSize = true;
            this.lbl_CountCources.Location = new System.Drawing.Point(226, 57);
            this.lbl_CountCources.Name = "lbl_CountCources";
            this.lbl_CountCources.Size = new System.Drawing.Size(14, 14);
            this.lbl_CountCources.TabIndex = 23;
            this.lbl_CountCources.Text = "0";
            // 
            // lbl_SumScore
            // 
            this.lbl_SumScore.AutoSize = true;
            this.lbl_SumScore.Location = new System.Drawing.Point(226, 29);
            this.lbl_SumScore.Name = "lbl_SumScore";
            this.lbl_SumScore.Size = new System.Drawing.Size(14, 14);
            this.lbl_SumScore.TabIndex = 22;
            this.lbl_SumScore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "تعداد درس:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "معدل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "جمع نمرات :";
            // 
            // btn_Compute
            // 
            this.btn_Compute.Location = new System.Drawing.Point(553, 21);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(92, 31);
            this.btn_Compute.TabIndex = 18;
            this.btn_Compute.Text = "محاسبه";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(339, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 31);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_codeDaneshjooSearch
            // 
            this.txt_codeDaneshjooSearch.Location = new System.Drawing.Point(437, 33);
            this.txt_codeDaneshjooSearch.Mask = "00000";
            this.txt_codeDaneshjooSearch.Name = "txt_codeDaneshjooSearch";
            this.txt_codeDaneshjooSearch.Size = new System.Drawing.Size(121, 22);
            this.txt_codeDaneshjooSearch.TabIndex = 14;
            this.txt_codeDaneshjooSearch.TextChanged += new System.EventHandler(this.txt_codeDaneshjooSearch_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(564, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 14);
            this.label19.TabIndex = 12;
            this.label19.Text = "کد دانشجویی:";
            // 
            // gridviewKarnameh
            // 
            this.gridviewKarnameh.AllowUserToAddRows = false;
            this.gridviewKarnameh.AllowUserToDeleteRows = false;
            this.gridviewKarnameh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewKarnameh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewKarnameh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_student,
            this.id_ostad,
            this.id_dars,
            this.tedad_vahed,
            this.nomre,
            this.delete});
            this.gridviewKarnameh.Location = new System.Drawing.Point(9, 67);
            this.gridviewKarnameh.Name = "gridviewKarnameh";
            this.gridviewKarnameh.ReadOnly = true;
            this.gridviewKarnameh.RowTemplate.Height = 30;
            this.gridviewKarnameh.Size = new System.Drawing.Size(642, 428);
            this.gridviewKarnameh.TabIndex = 11;
            this.gridviewKarnameh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewKarnameh_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_student
            // 
            this.id_student.DataPropertyName = "id_student";
            this.id_student.HeaderText = "کد دانشجویی";
            this.id_student.Name = "id_student";
            this.id_student.ReadOnly = true;
            // 
            // id_ostad
            // 
            this.id_ostad.DataPropertyName = "id_ostad";
            this.id_ostad.HeaderText = "کد مدرسی";
            this.id_ostad.Name = "id_ostad";
            this.id_ostad.ReadOnly = true;
            // 
            // id_dars
            // 
            this.id_dars.DataPropertyName = "id_dars";
            this.id_dars.HeaderText = "کد درس";
            this.id_dars.Name = "id_dars";
            this.id_dars.ReadOnly = true;
            // 
            // tedad_vahed
            // 
            this.tedad_vahed.DataPropertyName = "tedad_vahed";
            this.tedad_vahed.HeaderText = "تعداد واحد";
            this.tedad_vahed.Name = "tedad_vahed";
            this.tedad_vahed.ReadOnly = true;
            this.tedad_vahed.Width = 50;
            // 
            // nomre
            // 
            this.nomre.DataPropertyName = "nomre";
            this.nomre.HeaderText = "نمره";
            this.nomre.Name = "nomre";
            this.nomre.ReadOnly = true;
            this.nomre.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "حذف";
            this.delete.ToolTipText = "حذف";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // frmKarnameh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 651);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKarnameh";
            this.Text = "مدیریت کارنامه";
            this.Load += new System.EventHandler(this.frmKarnameh_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewKarnameh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_ScoreAddNew;
        private System.Windows.Forms.MaskedTextBox txt_CountVahedAddNew;
        private System.Windows.Forms.MaskedTextBox txt_CodeDaneshjooAddNew;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_SaveAddNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.MaskedTextBox txt_codeDaneshjooSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gridviewKarnameh;
        private System.Windows.Forms.ComboBox com_OstadAddNew;
        private System.Windows.Forms.ComboBox com_DarsAddNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dars;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad_vahed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomre;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.Label lbl_Average;
        private System.Windows.Forms.Label lbl_CountCources;
        private System.Windows.Forms.Label lbl_SumScore;
        private System.Windows.Forms.MaskedTextBox txt_CodeDaneshjoo2;
        private System.Windows.Forms.Label label9;
    }
}