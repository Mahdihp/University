using System;
using System.Linq;
using System.Windows.Forms;
using University.ORM;

namespace University.Forms
{
    public partial class frmDaneshjoo : Form
    {
        public frmDaneshjoo()
        {
            InitializeComponent();
        }

        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmpty() != true)
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    Student objStudent = new Student();
                    objStudent.id_student = Convert.ToInt32(txt_CodeDaneshjooAddNew.Text);
                    objStudent.name = txt_NameAddNew.Text.Trim();
                    objStudent.family = txt_LNameAddNew.Text.Trim();
                    objStudent.id_meli = txt_CodemelliAddNew.Text;
                    objStudent.sh_sh = txt_SSAddNew.Text;
                    objStudent.vorodi = txt_VorodiAddNew.Text;
                    objStudent.maghtae = com_AddNew.Items[com_AddNew.SelectedIndex].ToString();
                    objStudent.mobile = txt_NumberMobileAddNEw.Text;
                    objStudent.tel = txt_NumberHomeAddNew.Text;
                    objStudent.address = txt_AddressAddNew.Text;

                    udc.Students.InsertOnSubmit(objStudent);
                    udc.SubmitChanges();
                    FillGrid();
                    MessageBox.Show(".با موفقیت درج شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddNew();

                }
                else
                {
                    MessageBox.Show(".لطفا اطلاعات را کامل کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_CodeDaneshjooAddNew.Select();
                }
            }
            catch (Exception e2) { MessageBox.Show(e2.Message); }
        }
        private bool CheckEmpty()
        {
            //به وسیله حلقه فورایچ  بین کنترل های جسجو می کند
            bool tf = false;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox chk = (System.Windows.Forms.TextBox)c;
                    // چک میکند که ببیند ایا این کنترل مقدار تکس دارد یا نه
                    if (chk.Text == "")
                    {
                        tf = true;
                    }
                }
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is System.Windows.Forms.MaskedTextBox)
                {
                    System.Windows.Forms.MaskedTextBox chk = (System.Windows.Forms.MaskedTextBox)c;
                    if (chk.Text == "")
                    {
                        tf = true;
                    }
                }
            }
            if (com_AddNew.SelectedIndex < 0)
            {
                tf = true;
            }
            return tf;
        }
        private void ClearAddNew()
        {
            txt_CodeDaneshjooAddNew.Clear();
            txt_NameAddNew.Clear();
            txt_LNameAddNew.Clear();
            txt_CodemelliAddNew.Clear();
            txt_SSAddNew.Clear();
            txt_VorodiAddNew.Clear();
            com_AddNew.SelectedIndex = 0;
            txt_NumberMobileAddNEw.Clear();
            txt_NumberHomeAddNew.Clear();
            txt_AddressAddNew.Clear();
        }
        private void ClearEdit()
        {
            txt_CodeDaneshjooEdit.Clear();
            txt_NameEdit.Clear();
            txt_LNameEdit.Clear();
            txt_CodemelliEdit.Clear();
            txt_SSEdit.Clear();
            txt_VorodiEdit.Clear();
            com_MagtahEdit.SelectedIndex = 0;
            txt_MobileEdit.Clear();
            txt_HomeEdit.Clear();
            txt_AddressEdit.Clear();
        }

        private void frmDaneshjoo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                UniversityDataContext udc = new UniversityDataContext();
                var query = from p in udc.Students
                            select p;
                gridviewDaneshjoo.DataSource = query;
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            ClearAddNew();
        }
        int Id_edit;
        bool allow_edit = false;
        private void gridviewDaneshjoo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            
            if (e.ColumnIndex==0)
            {
                if (MessageBox.Show("آیا مابل به حذف این دانشجو هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Id_edit = Convert.ToInt16(gridviewDaneshjoo.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = udc.Students.Single(p => p.id == Id_edit);
                    udc.Students.DeleteOnSubmit(q);
                    udc.SubmitChanges();
                    FillGrid();
                    MessageBox.Show(".با موفقیت حذف شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == 1)
            {
                Id_edit = Convert.ToInt32(gridviewDaneshjoo.Rows[e.RowIndex].Cells["id"].Value);
                txt_CodeDaneshjooEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["id_student"].Value.ToString();
                txt_NameEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txt_LNameEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["family"].Value.ToString();
                txt_CodemelliEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["id_meli"].Value.ToString();
                txt_SSEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["sh_sh"].Value.ToString();
                txt_VorodiEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["vorodi"].Value.ToString();
                setComobox(gridviewDaneshjoo.Rows[e.RowIndex].Cells["maghtae"].Value.ToString());
                txt_MobileEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
                txt_HomeEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["tel"].Value.ToString();
                txt_AddressEdit.Text = gridviewDaneshjoo.Rows[e.RowIndex].Cells["address"].Value.ToString();
                allow_edit = true;

            }
            }
            catch (Exception e4) { MessageBox.Show(e4.Message); }
        }
        private void setComobox(string item)
        {
            for (int i = 0; i < com_MagtahEdit.Items.Count; i++)
            {
                if (item == com_MagtahEdit.Items[i].ToString())
                {
                    com_MagtahEdit.SelectedIndex = i;
                }
            }
        }

        private void btn_SaveEdit1_Click(object sender, EventArgs e)
        {
            try
            {
            
            if (allow_edit == true)
            {
                UniversityDataContext udc = new UniversityDataContext();
                var q = from p in udc.Students
                        where p.id == Id_edit
                        select p;
                foreach (Student item in q)
                {
                    item.id_student = Convert.ToInt32(txt_CodeDaneshjooEdit.Text);
                    item.name = txt_NameEdit.Text.Trim();
                    item.family = txt_LNameEdit.Text.Trim();
                    item.id_meli = txt_CodemelliEdit.Text;
                    item.sh_sh = txt_SSEdit.Text;
                    item.vorodi = txt_VorodiEdit.Text;
                    item.maghtae = com_MagtahEdit.Items[com_MagtahEdit.SelectedIndex].ToString();
                    item.mobile = txt_MobileEdit.Text;
                    item.tel = txt_HomeEdit.Text;
                    item.address = txt_AddressEdit.Text;

                    udc.SubmitChanges();
                    allow_edit = false;
                    FillGrid();
                    MessageBox.Show(".با موفقیت ذخیره شد");
                    ClearEdit();
                }
            }
            }
            catch (Exception e5) { MessageBox.Show(e5.Message); }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_codeDaneshjooSearch.Text != "")
                {
                    int idostad = Convert.ToInt32(txt_codeDaneshjooSearch.Text);
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Students
                            where p.id_student == idostad
                            select p;
                    gridviewDaneshjoo.DataSource = q;
                }


                if (txt_LNameSearch.Text != "")
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Students
                            where p.family.StartsWith(txt_LNameSearch.Text)
                            select p;
                    gridviewDaneshjoo.DataSource = q;

                }
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }

        }

        private void txt_codeDaneshjooSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_codeDaneshjooSearch.Text=="")
                {
                    FillGrid();
                }
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);
            }
        
        }

        private void txt_LNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_LNameSearch.Text == "")
                {
                    FillGrid();
                }
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message);
            }

        }
    }
}
