using System;
using System.Linq;
using System.Windows.Forms;
using University.ORM;
using University.Forms;

namespace University
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        string username;
        string password;
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                username = txt_Username.Text.Trim();
                password = txt_Password.Text.Trim();
                UniversityDataContext udc = new UniversityDataContext();
                var query = from p in udc.Users
                            where p.nuser == username && p.npass == password
                            select p;
                //  MessageBox.Show(query.Count().ToString());
                if (query.Count() == 1)
                {
                    this.Hide();
                    frmMain obj1 = new frmMain(username);
                    obj1.Show();

                }
                else
                {
                    MessageBox.Show(".نام کاربری و رمز عبور اشتباه است");
                    txt_Username.Select();
                }
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
