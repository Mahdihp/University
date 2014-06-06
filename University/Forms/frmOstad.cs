using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using University.ORM;

namespace University.Forms
{
    public partial class frmOstad : Form
    {
        public frmOstad()
        {
            InitializeComponent();
        }

        private void frmOstad_Load(object sender, EventArgs e)
        {

            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                UniversityDataContext udc = new UniversityDataContext();
                var query = from p in udc.Ostads
                            select p;
                gridviewOstad.DataSource = query;
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            CleartxtAddNew();
        }
        private void CleartxtAddNew()
        {
            txt_CodeOstadAddNew.Clear();
            txt_NameAddNew.Clear();
            txt_LNameAddNew.Clear();
            txt_CodemelliAddNew.Clear();
            txt_SSAddNew.Clear();
              txt_NumberMobileAddNEw.Clear();
              txt_NumberHomeAddNew.Clear();
              txt_AddressAddNew.Clear();
        }
        private void CleartxtEdit()
        {
            txt_CodeOstadEdit.Clear();
            txt_NameEdit.Clear();
            txt_LNameEdit.Clear();
            txt_CodemellEdit.Clear();
            txt_SSEdit.Clear();
            txt_NumberMobileEdit.Clear();
            txt_NumberHomeEdit.Clear();
            txt_AddressEdit.Clear();
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
                    if (chk.Text =="")
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
            if(com_AddNew.SelectedIndex < 0)
            {
                tf = true;
            }
            return tf;
        }
        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmpty() != true)
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    Ostad objOstad = new Ostad();
                    objOstad.id_ostad = Convert.ToInt32(txt_CodeOstadAddNew.Text.Trim());
                    objOstad.name = txt_NameAddNew.Text.Trim();
                    objOstad.family = txt_LNameAddNew.Text.Trim();
                    objOstad.id_meli = txt_CodemelliAddNew.Text.ToString();
                    objOstad.sh_sh = txt_SSAddNew.Text.Trim();
                    objOstad.madrak = com_AddNew.Items[com_AddNew.SelectedIndex].ToString();
                    objOstad.mobile = txt_NumberMobileAddNEw.Text.ToString();
                    objOstad.tel = txt_NumberHomeAddNew.Text.Trim();
                    objOstad.address = txt_AddressAddNew.Text;

                    udc.Ostads.InsertOnSubmit(objOstad);
                    udc.SubmitChanges();
                    FillGrid();
                    MessageBox.Show(".با موفقیت درج شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleartxtAddNew();
                }
                else
                {
                    MessageBox.Show(".لطفا اطلاعات را کامل کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_CodeOstadAddNew.Select();
                }
            }
            catch (Exception e2) { MessageBox.Show(e2.Message); }
        }

        int Id_edit;
        private void gridviewOstad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("آیا مابل به حذف این استاد هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Id_edit = Convert.ToInt16(gridviewOstad.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        UniversityDataContext udc = new UniversityDataContext();
                        var q = udc.Ostads.Single(p => p.id == Id_edit);
                        udc.Ostads.DeleteOnSubmit(q);
                        udc.SubmitChanges();
                        FillGrid();
                        MessageBox.Show(".با موفقیت حذف شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                if (e.ColumnIndex == 1)
                {
                    Id_edit = Convert.ToInt32(gridviewOstad.Rows[e.RowIndex].Cells["id"].Value);
                    txt_CodeOstadEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["id_ostad"].Value.ToString();
                    txt_NameEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txt_LNameEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["family"].Value.ToString();
                    txt_CodemellEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["id_meli"].Value.ToString();
                    txt_SSEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["sh_sh"].Value.ToString();
                    setComobox(gridviewOstad.Rows[e.RowIndex].Cells["madrak"].Value.ToString());
                    txt_NumberMobileEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
                    txt_NumberHomeEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["tel"].Value.ToString();
                    txt_AddressEdit.Text = gridviewOstad.Rows[e.RowIndex].Cells["address"].Value.ToString();
                    allow_edit = true;
                }
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
        }
        bool allow_edit = false;
        private void setComobox(string item)
        {
            for (int i = 0; i < com_MadrakEdit.Items.Count; i++)
            {
                if(item==com_MadrakEdit.Items[i].ToString())
                {
                    com_MadrakEdit.SelectedIndex = i;
                }
            }
        }

        private void btn_SaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (allow_edit == true)
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Ostads
                            where p.id == Id_edit
                            select p;
                    foreach (Ostad item in q)
                    {
                        item.id_ostad = Convert.ToInt32(txt_CodeOstadEdit.Text);
                        item.name = txt_NameEdit.Text;
                        item.family = txt_LNameEdit.Text;
                        item.id_meli = txt_CodemellEdit.Text;
                        item.sh_sh = txt_SSEdit.Text;
                        item.madrak = com_MadrakEdit.Items[com_MadrakEdit.SelectedIndex].ToString();
                        item.mobile = txt_NumberMobileEdit.Text;
                        item.tel = txt_NumberHomeEdit.Text;
                        item.address = txt_AddressEdit.Text;

                        udc.SubmitChanges();
                        allow_edit = false;
                        FillGrid();
                        MessageBox.Show(".با موفقیت ذخیره شد");
                        CleartxtEdit();

                    }

                }
            }
            catch (Exception e4) { MessageBox.Show(e4.Message); }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_codeOstadSearch.Text !="")
                {
                    int idostad = Convert.ToInt32(txt_codeOstadSearch.Text);
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Ostads
                            where p.id_ostad == idostad 
                            select p;
                    gridviewOstad.DataSource = q;
                }

                if (txt_LNameSearch.Text !="")
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Ostads
                            where p.family.StartsWith(txt_LNameSearch.Text)
                            select p;
                    gridviewOstad.DataSource = q;
                }
            }
            catch (Exception e5) { MessageBox.Show(e5.Message); }
        }

     

        private void txt_codeOstadSearch_TextChanged(object sender, EventArgs e)
        {
             try
            {
                if(txt_codeOstadSearch.Text =="")
                {
                    FillGrid();
                }
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message);

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
            catch (Exception e7)
            {
                MessageBox.Show(e7.Message);

            }
        }
    }
}
