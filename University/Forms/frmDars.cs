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
    public partial class frmDars : Form
    {
        public frmDars()
        {
            InitializeComponent();
        }

       

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codeDarsSearch.Text != "")
                {
                    int idostad = Convert.ToInt32(txt_codeDarsSearch.Text);
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Darses
                            where p.id_dars == idostad
                            select p;
                    gridviewDars.DataSource = q;
                }

                if (txt_NameDarsSearch.Text != "")
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.Darses
                            where p.name.StartsWith(txt_NameDarsSearch.Text)
                            select p;
                    gridviewDars.DataSource = q;
                }
            }
            catch (Exception e6) { MessageBox.Show(e6.Message); }
        }

        private void frmDars_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                UniversityDataContext udc = new UniversityDataContext();
                var query = from p in udc.Darses
                            select p;
                gridviewDars.DataSource = query;
            }
            catch (Exception e2) { MessageBox.Show(e2.Message); }
        }
        private void ClearAddNew()
        {
            txt_CodeDarsAddNew.Clear();
            txt_NameDarsAddNew.Clear();
            txt_CountVahedAddNew.Clear();
            com_TypeAddNew.SelectedIndex = 0;
        }
        private void ClearEdit()
        {
            txt_CodeDarsEdit.Clear();
            txt_NameDarsEdit.Clear();
            txt_CountVahedEdit.Clear();
            com_TypeEdit.SelectedIndex = 0;
        }

        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodeDarsAddNew.Text != "" && txt_NameDarsAddNew.Text != "" && txt_CountVahedAddNew.Text != "" && com_TypeAddNew.SelectedIndex >= 0)
                {
                    UniversityDataContext udc = new UniversityDataContext();
                    Darse objDars = new Darse();
                    objDars.id_dars = Convert.ToInt32(txt_CodeDarsAddNew.Text);
                    objDars.name = txt_NameDarsAddNew.Text;
                    objDars.tedad_vahed = Convert.ToInt16(txt_CountVahedAddNew.Text);
                    objDars.type = com_TypeAddNew.Items[com_TypeAddNew.SelectedIndex].ToString();

                    udc.Darses.InsertOnSubmit(objDars);
                    udc.SubmitChanges();
                    FillGrid();
                    MessageBox.Show(".با موفقیت درج شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddNew();
                }
                else
                {
                    MessageBox.Show(".لطفا اطلاعات را کامل کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_CodeDarsAddNew.Select();
                }
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
        }
        int Id_edit;

        private void gridviewDars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("آیا مابل به حذف این درس هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Id_edit = Convert.ToInt16(gridviewDars.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        UniversityDataContext udc = new UniversityDataContext();
                        var q = udc.Darses.Single(p => p.id == Id_edit);
                        udc.Darses.DeleteOnSubmit(q);
                        udc.SubmitChanges();
                        FillGrid();
                        MessageBox.Show(".با موفقیت حذف شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (e.ColumnIndex == 1)
                {
                    Id_edit = Convert.ToInt32(gridviewDars.Rows[e.RowIndex].Cells["id"].Value);
                    txt_CodeDarsEdit.Text = gridviewDars.Rows[e.RowIndex].Cells["id_dars"].Value.ToString();
                    txt_NameDarsEdit.Text = gridviewDars.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txt_CountVahedEdit.Text = gridviewDars.Rows[e.RowIndex].Cells["tedad_vahed"].Value.ToString();
                    setComobox(gridviewDars.Rows[e.RowIndex].Cells["type"].Value.ToString());
                    allow_edit = true;
                }
            }
            catch (Exception e4) { MessageBox.Show(e4.Message); }
        }
        bool allow_edit = false;
        private void setComobox(string item)
        {
            for (int i = 0; i < com_TypeEdit.Items.Count; i++)
            {
                if (item == com_TypeEdit.Items[i].ToString())
                {
                    com_TypeEdit.SelectedIndex = i;
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
                    var q = from p in udc.Darses
                            where p.id == Id_edit
                            select p;
                    foreach (Darse item in q)
                    {
                        item.id_dars = Convert.ToInt32(txt_CodeDarsEdit.Text);
                        item.name = txt_NameDarsEdit.Text;
                        item.tedad_vahed = Convert.ToInt16(txt_CountVahedEdit.Text);
                        item.type = com_TypeEdit.Items[com_TypeEdit.SelectedIndex].ToString();
                    }
                    udc.SubmitChanges();
                    allow_edit = false;
                    FillGrid();
                    MessageBox.Show(".با موفقیت ذخیره شد");
                    ClearEdit();

                }
            }
            catch (Exception e5) { MessageBox.Show(e5.Message); }
        }

        private void txt_codeDarsSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_codeDarsSearch.Text=="")
                {
                    FillGrid();
                }
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message);
            }
        }

        private void txt_NameDarsSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_NameDarsSearch.Text == "")
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
