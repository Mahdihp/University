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
    public partial class frmKarnameh : Form
    {
        public frmKarnameh()
        {
            InitializeComponent();
        }

        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodeDaneshjooAddNew.Text != "" && txt_CountVahedAddNew.Text != "" && txt_ScoreAddNew.Text != "")
                {

                    UniversityDataContext udc = new UniversityDataContext();
                    entekhab obj = new entekhab();
                    obj.id_student = Convert.ToInt32(txt_CodeDaneshjooAddNew.Text);
                    obj.id_ostad = Convert.ToInt32(com_OstadAddNew.Text);
                    obj.id_dars = Convert.ToInt32(com_DarsAddNew.Text);
                    obj.tedad_vahed = Convert.ToInt32(txt_CountVahedAddNew.Text);
                    obj.nomre = Convert.ToInt32(txt_ScoreAddNew.Text);

                    udc.entekhabs.InsertOnSubmit(obj);
                    udc.SubmitChanges();
                    FillFeild();
                    MessageBox.Show(".با موفقیت درج شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_CodeDaneshjooAddNew.Clear();
                    txt_CountVahedAddNew.Clear();
                    txt_ScoreAddNew.Clear();
                }
                else
                {
                    MessageBox.Show(".لطفا اطلاعات را کامل کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            catch (Exception e1) { MessageBox.Show(e1.Message); }
        }

        private void frmKarnameh_Load(object sender, EventArgs e)
        {
            FillFeild();
        }
        private void FillFeild()
        {
            try
            {
                UniversityDataContext udc = new UniversityDataContext();
                var query1 = from p in udc.Ostads.AsEnumerable()
                             select new { p.id_ostad };

                com_OstadAddNew.ValueMember = "id_ostad";
                com_OstadAddNew.DataSource = query1.ToList();
                com_OstadAddNew.SelectedIndex = 0;

                var query2 = from p in udc.Darses.AsEnumerable()
                             select new { p.id_dars };

                com_DarsAddNew.ValueMember = "id_dars";
                com_DarsAddNew.DataSource = query2.ToList();
                com_DarsAddNew.SelectedIndex = 0;

                var query3 = from p in udc.entekhabs
                             select p;
                gridviewKarnameh.DataSource = query3;

            }
            catch (Exception e2) { MessageBox.Show(e2.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDaneshjoo objdaneshjoo = new frmDaneshjoo();
            objdaneshjoo.Show();
        }

        private void com_OstadAddNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(com_OstadAddNew.Text.ToString());
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            txt_CodeDaneshjooAddNew.Clear();
            txt_CountVahedAddNew.Clear();
            txt_ScoreAddNew.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codeDaneshjooSearch.Text != "")
                {
                    int idostad = Convert.ToInt32(txt_codeDaneshjooSearch.Text);
                    UniversityDataContext udc = new UniversityDataContext();
                    var q = from p in udc.entekhabs
                            where p.id_student == idostad
                            select p;
                    
                    gridviewKarnameh.DataSource = q;
                }
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
        }
        int Id_edit;
        private void gridviewKarnameh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("آیا مابل به حذف این نمره هستید؟ ", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Id_edit = Convert.ToInt16(gridviewKarnameh.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        UniversityDataContext udc = new UniversityDataContext();
                        var q = udc.entekhabs.Single(p => p.id == Id_edit);
                        udc.entekhabs.DeleteOnSubmit(q);
                        udc.SubmitChanges();
                        FillFeild();
                        MessageBox.Show(".با موفقیت حذف شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e4) { MessageBox.Show(e4.Message); }
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodeDaneshjoo2.Text != "")
                {

                    UniversityDataContext udc = new UniversityDataContext();
                    var query = from p in udc.entekhabs
                                where p.id_student == Convert.ToInt32(txt_CodeDaneshjoo2.Text)
                                select p;

                    gridviewKarnameh.DataSource = query;
                    if (gridviewKarnameh.Rows.Count > 0)
                    {
                        int count_rows = gridviewKarnameh.Rows.Count;
                        int[] sum = new int[count_rows];

                        int[] vaheds = new int[count_rows];

                        for (int i = 0; i < gridviewKarnameh.Rows.Count; i++)
                        {
                            int vahed = Convert.ToInt32(gridviewKarnameh.Rows[i].Cells["tedad_vahed"].Value.ToString());
                            int nomreh = Convert.ToInt32(gridviewKarnameh.Rows[i].Cells["nomre"].Value.ToString());
                            sum[i] = (vahed * nomreh);
                            vaheds[i] = Convert.ToInt32(gridviewKarnameh.Rows[i].Cells["tedad_vahed"].Value.ToString());
                        }

                        double sumVahed = vaheds.Sum();
                        double sumScore = sum.Sum();

                        double ave = sumScore / sumVahed;

                        lbl_CountCources.Text = count_rows.ToString();
                        lbl_SumScore.Text = sumScore.ToString();
                        lbl_Average.Text = ave.ToString();
                    }
                    else
                    {
                        MessageBox.Show(".دانشجویی موجود نیست", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(".لطفا شماره دانشجویی را وارد کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CodeDaneshjoo2.Select();
                }

            }
            catch (Exception e5) { MessageBox.Show(e5.Message); }
        }

        private void txt_codeDaneshjooSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_codeDaneshjooSearch.Text == "")
                {
                    FillFeild();
                }
            }
            catch (Exception e7)
            {
                MessageBox.Show(e7.Message);
            }
        }
    }
}
