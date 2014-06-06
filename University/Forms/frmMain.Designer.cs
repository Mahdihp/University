namespace University.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.link_Daneshjoo = new System.Windows.Forms.LinkLabel();
            this.link_Karnameh = new System.Windows.Forms.LinkLabel();
            this.link_UserManager = new System.Windows.Forms.LinkLabel();
            this.link_DarsManager = new System.Windows.Forms.LinkLabel();
            this.link_OstadManager = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Status.Location = new System.Drawing.Point(0, 24);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_Status.Size = new System.Drawing.Size(863, 43);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(406, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 150, 0, 150);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 457);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel5);
            this.panel1.Controls.Add(this.link_Daneshjoo);
            this.panel1.Controls.Add(this.link_Karnameh);
            this.panel1.Controls.Add(this.link_UserManager);
            this.panel1.Controls.Add(this.link_DarsManager);
            this.panel1.Controls.Add(this.link_OstadManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 151);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabel5.Location = new System.Drawing.Point(237, 115);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(58, 33);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "درباره";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // link_Daneshjoo
            // 
            this.link_Daneshjoo.AutoSize = true;
            this.link_Daneshjoo.BackColor = System.Drawing.Color.Transparent;
            this.link_Daneshjoo.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link_Daneshjoo.Location = new System.Drawing.Point(321, 115);
            this.link_Daneshjoo.Name = "link_Daneshjoo";
            this.link_Daneshjoo.Size = new System.Drawing.Size(121, 33);
            this.link_Daneshjoo.TabIndex = 5;
            this.link_Daneshjoo.TabStop = true;
            this.link_Daneshjoo.Text = "مدیریت دانشجو";
            this.link_Daneshjoo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.link_Daneshjoo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Daneshjoo_LinkClicked);
            // 
            // link_Karnameh
            // 
            this.link_Karnameh.AutoSize = true;
            this.link_Karnameh.BackColor = System.Drawing.Color.Transparent;
            this.link_Karnameh.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link_Karnameh.Location = new System.Drawing.Point(176, 67);
            this.link_Karnameh.Name = "link_Karnameh";
            this.link_Karnameh.Size = new System.Drawing.Size(119, 33);
            this.link_Karnameh.TabIndex = 2;
            this.link_Karnameh.TabStop = true;
            this.link_Karnameh.Text = "مدیریت کارنامه";
            this.link_Karnameh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.link_Karnameh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Karnameh_LinkClicked);
            // 
            // link_UserManager
            // 
            this.link_UserManager.AutoSize = true;
            this.link_UserManager.BackColor = System.Drawing.Color.Transparent;
            this.link_UserManager.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link_UserManager.Location = new System.Drawing.Point(319, 18);
            this.link_UserManager.Name = "link_UserManager";
            this.link_UserManager.Size = new System.Drawing.Size(123, 33);
            this.link_UserManager.TabIndex = 0;
            this.link_UserManager.TabStop = true;
            this.link_UserManager.Text = "مدیریت کاربران";
            this.link_UserManager.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.link_UserManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_UserManager_LinkClicked);
            // 
            // link_DarsManager
            // 
            this.link_DarsManager.AutoSize = true;
            this.link_DarsManager.BackColor = System.Drawing.Color.Transparent;
            this.link_DarsManager.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link_DarsManager.Location = new System.Drawing.Point(188, 18);
            this.link_DarsManager.Name = "link_DarsManager";
            this.link_DarsManager.Size = new System.Drawing.Size(107, 33);
            this.link_DarsManager.TabIndex = 1;
            this.link_DarsManager.TabStop = true;
            this.link_DarsManager.Text = "مدیریت درس";
            this.link_DarsManager.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.link_DarsManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DarsManager_LinkClicked);
            // 
            // link_OstadManager
            // 
            this.link_OstadManager.AutoSize = true;
            this.link_OstadManager.BackColor = System.Drawing.Color.Transparent;
            this.link_OstadManager.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link_OstadManager.Location = new System.Drawing.Point(336, 67);
            this.link_OstadManager.Name = "link_OstadManager";
            this.link_OstadManager.Size = new System.Drawing.Size(106, 33);
            this.link_OstadManager.TabIndex = 3;
            this.link_OstadManager.TabStop = true;
            this.link_OstadManager.Text = "مدیریت استاد";
            this.link_OstadManager.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.link_OstadManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_OstadManager_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItem1.Text = "مدیریت کاربران";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem2.Text = "مدیریت استاد";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(105, 20);
            this.toolStripMenuItem3.Text = "مدیریت دانشجو";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem4.Text = "مدیریت درس";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItem5.Text = "مدیریت کارنامه";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem6.Text = "درباره";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::University.Properties.Resources._390b43aa_5103_4f36_ab20_3b218edaf702_16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت دانشگاه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel link_UserManager;
        private System.Windows.Forms.LinkLabel link_Daneshjoo;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel link_OstadManager;
        private System.Windows.Forms.LinkLabel link_Karnameh;
        private System.Windows.Forms.LinkLabel link_DarsManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}