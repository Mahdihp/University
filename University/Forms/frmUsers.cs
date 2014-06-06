using System;
using System.Linq;
using System.Windows.Forms;
using University.ORM;

namespace University.Forms
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

       
        private void frmUsers_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                UniversityDataContext udc = new UniversityDataContext();
                var query = from p in udc.Users
                            select p;
                gridviewUser.DataSource = query;

            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }
        }

        

        int Id_edit;

        
        private void btn_SaveNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserAddNew.Text != "" && txt_PassAddNew.Text != "")
                {
                    if (txt_PassAddNew.Text == txt_PassAddNewAllow.Text)
                    {
                        UniversityDataContext udc = new UniversityDataContext();
                        User objuser = new User();
                        objuser.nuser = txt_UserAddNew.Text.Trim();
                        objuser.npass = txt_PassAddNew.Text.Trim();
                        udc.Users.InsertOnSubmit(objuser);
                        udc.SubmitChanges();
                        FillGrid();
                        MessageBox.Show(".با موفقیت درج شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_UserAddNew.Clear();
                        txt_PassAddNew.Clear();
                        txt_PassAddNewAllow.Clear();

                    }
                    else
                    {
                        MessageBox.Show("پسورد مطابقت ندارد");
                        txt_PassAddNewAllow.Select();
                    }

                }
                else
                {
                    MessageBox.Show(".لطفا نام کاربری و رمز عبور را وارد کنید");
                    txt_UserAddNew.Select();
                }
            }
            catch (Exception e2) { MessageBox.Show(e2.Message); }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            txt_UserAddNew.Clear();
            txt_PassAddNew.Clear();
            txt_PassAddNewAllow.Clear();
            txt_UserAddNew.Select();
        }

        private void gridviewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("آیا مابل به حذف این کاربر هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Id_edit = Convert.ToInt16(gridviewUser.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        UniversityDataContext udc = new UniversityDataContext();
                        var q = udc.Users.Single(p => p.id == Id_edit);
                        udc.Users.DeleteOnSubmit(q);
                        udc.SubmitChanges();
                        FillGrid();

                    }
                }
                if (e.ColumnIndex == 1)
                {
                    txt_UserEdit.Text = gridviewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_PassEdit.Text = gridviewUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                    Id_edit = Convert.ToInt16(gridviewUser.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    allow_edit = true;
                }
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
        }
        bool allow_edit = false;
        private void btn_SaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (allow_edit == true)
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Users
                            where p.id == Id_edit
                            select p;
                    foreach (User item in q)
                    {
                        item.nuser = txt_UserEdit.Text;
                        item.npass = txt_PassEdit.Text;
                    }

                    udc.SubmitChanges();
                    allow_edit = false;
                    FillGrid();
                    MessageBox.Show(".با موفقیت ذخیره شد");
                    txt_UserEdit.Clear();
                    txt_PassEdit.Clear();
                }
            }
            catch (Exception e4) { MessageBox.Show(e4.Message); }
        }

       
    }
}
