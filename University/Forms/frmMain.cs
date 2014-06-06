using System;
using System.Windows.Forms;

namespace University.Forms
{
    public partial class frmMain : Form
    {


        string UserEnter;
        public frmMain(string userenter)
        {
            InitializeComponent();
            UserEnter = userenter;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_UserManager_Click(object sender, EventArgs e)
        {
                    }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetConfig();
        }
        private void SetConfig()
        {
            lbl_Status.Text += UserEnter + " : کاربر  ";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("آیا مابل به خروج هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void link_UserManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                frmUsers objuser = new frmUsers();
                objuser.ShowDialog();
            
        }

        private void link_OstadManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOstad objostad = new frmOstad();
            objostad.ShowDialog();
        }

        private void link_Daneshjoo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDaneshjoo objdaneshjoo = new frmDaneshjoo();
            objdaneshjoo.ShowDialog();
        }

        private void link_Karnameh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKarnameh objKarnameh = new frmKarnameh();
            objKarnameh.ShowDialog();
        }

        private void link_DarsManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDars objDars = new frmDars();
            objDars.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsers objuser = new frmUsers();
            objuser.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOstad objostad = new frmOstad();
            objostad.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmDaneshjoo objdaneshjoo = new frmDaneshjoo();
            objdaneshjoo.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDars objDars = new frmDars();
            objDars.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmKarnameh objKarnameh = new frmKarnameh();
            objKarnameh.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int s, m, h;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            s++;
            if (s==60)
            {
                s = 0;
                m++;
            }else if(m==60)
            {
                m = 0;
                h++;
            }else if(h ==60)
            {
                h = 0;
            }
            lbl_Status.Text = h.ToString()+":"+m.ToString()+":"+s.ToString() +"  :مدت ورود  "+ UserEnter + " : کاربر  " ;
        }
    }
}
