namespace University.Forms
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PassAddNewAllow = new System.Windows.Forms.TextBox();
            this.btn_SaveNewUser = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.txt_UserAddNew = new System.Windows.Forms.TextBox();
            this.txt_PassAddNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridviewUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SaveEdit = new System.Windows.Forms.Button();
            this.txt_UserEdit = new System.Windows.Forms.TextBox();
            this.txt_PassEdit = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUser)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(483, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(475, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ثبت کاربر جدید";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PassAddNewAllow);
            this.groupBox1.Controls.Add(this.btn_SaveNewUser);
            this.groupBox1.Controls.Add(this.btn_AddNew);
            this.groupBox1.Controls.Add(this.txt_UserAddNew);
            this.groupBox1.Controls.Add(this.txt_PassAddNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(455, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "تایید رمز عبور: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_PassAddNewAllow
            // 
            this.txt_PassAddNewAllow.Location = new System.Drawing.Point(203, 84);
            this.txt_PassAddNewAllow.Name = "txt_PassAddNewAllow";
            this.txt_PassAddNewAllow.PasswordChar = '#';
            this.txt_PassAddNewAllow.Size = new System.Drawing.Size(146, 22);
            this.txt_PassAddNewAllow.TabIndex = 2;
            // 
            // btn_SaveNewUser
            // 
            this.btn_SaveNewUser.Location = new System.Drawing.Point(104, 111);
            this.btn_SaveNewUser.Name = "btn_SaveNewUser";
            this.btn_SaveNewUser.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveNewUser.TabIndex = 3;
            this.btn_SaveNewUser.Text = "ذخیره";
            this.btn_SaveNewUser.UseVisualStyleBackColor = true;
            this.btn_SaveNewUser.Click += new System.EventHandler(this.btn_SaveNewUser_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(6, 111);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(92, 31);
            this.btn_AddNew.TabIndex = 4;
            this.btn_AddNew.Text = "جدید";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // txt_UserAddNew
            // 
            this.txt_UserAddNew.Location = new System.Drawing.Point(203, 28);
            this.txt_UserAddNew.Name = "txt_UserAddNew";
            this.txt_UserAddNew.Size = new System.Drawing.Size(146, 22);
            this.txt_UserAddNew.TabIndex = 0;
            
            // 
            // txt_PassAddNew
            // 
            this.txt_PassAddNew.Location = new System.Drawing.Point(203, 56);
            this.txt_PassAddNew.Name = "txt_PassAddNew";
            this.txt_PassAddNew.PasswordChar = '#';
            this.txt_PassAddNew.Size = new System.Drawing.Size(146, 22);
            this.txt_PassAddNew.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(475, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ویرایش کاربران";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridviewUser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_SaveEdit);
            this.groupBox2.Controls.Add(this.txt_UserEdit);
            this.groupBox2.Controls.Add(this.txt_PassEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(455, 430);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ورود اطلاعات";
            // 
            // gridviewUser
            // 
            this.gridviewUser.AllowUserToAddRows = false;
            this.gridviewUser.AllowUserToDeleteRows = false;
            this.gridviewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user,
            this.pass,
            this.delete,
            this.edit});
            this.gridviewUser.Location = new System.Drawing.Point(6, 87);
            this.gridviewUser.Name = "gridviewUser";
            this.gridviewUser.ReadOnly = true;
            this.gridviewUser.RowHeadersWidth = 30;
            this.gridviewUser.RowTemplate.Height = 30;
            this.gridviewUser.Size = new System.Drawing.Size(436, 246);
            this.gridviewUser.TabIndex = 2;
            this.gridviewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewUser_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // user
            // 
            this.user.DataPropertyName = "nuser";
            this.user.HeaderText = "نام کاربری";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "npass";
            this.pass.HeaderText = "پسورد";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 150F;
            this.delete.HeaderText = "عملیات";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام کاربری : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "رمز عبور : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_SaveEdit
            // 
            this.btn_SaveEdit.Location = new System.Drawing.Point(6, 393);
            this.btn_SaveEdit.Name = "btn_SaveEdit";
            this.btn_SaveEdit.Size = new System.Drawing.Size(92, 31);
            this.btn_SaveEdit.TabIndex = 3;
            this.btn_SaveEdit.Text = "ذخیره";
            this.btn_SaveEdit.UseVisualStyleBackColor = true;
            this.btn_SaveEdit.Click += new System.EventHandler(this.btn_SaveEdit_Click);
            // 
            // txt_UserEdit
            // 
            this.txt_UserEdit.Location = new System.Drawing.Point(203, 22);
            this.txt_UserEdit.Name = "txt_UserEdit";
            this.txt_UserEdit.Size = new System.Drawing.Size(146, 22);
            this.txt_UserEdit.TabIndex = 0;
            // 
            // txt_PassEdit
            // 
            this.txt_PassEdit.Location = new System.Drawing.Point(203, 50);
            this.txt_PassEdit.Name = "txt_PassEdit";
            this.txt_PassEdit.Size = new System.Drawing.Size(146, 22);
            this.txt_PassEdit.TabIndex = 1;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 477);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.Text = "مدیریت کاربران";
            
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_PassAddNew;
        private System.Windows.Forms.TextBox txt_UserAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveNewUser;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SaveEdit;
        private System.Windows.Forms.TextBox txt_UserEdit;
        private System.Windows.Forms.TextBox txt_PassEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PassAddNewAllow;
        private System.Windows.Forms.DataGridView gridviewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}