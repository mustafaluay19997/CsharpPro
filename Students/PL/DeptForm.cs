using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students.PL
{
    public partial class DeptForm : Form
    {
        BL.CLASS_DEPT dept = new BL.CLASS_DEPT();
        int ID;
        public DeptForm()
        {
            InitializeComponent();
            filldgv();
        }
        public void filldgv()
        {
            dgv.DataSource = dept.GET_ALL_DEPT();
        }

        Boolean check(string word)
        {
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (item.Cells["اسم القسم"].Value.ToString() == word)
                    return true;

            }
            return false;
        }

        private void txtdept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (txtdept.Text != "" )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtdept.Clear();
            txtdept.Focus();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check(txtdept.Text))
                {
                    dept.ADD_DEPT(txtdept.Text);
                    MessageBox.Show("تمت الاضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldgv();
                    btnNew_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("اسم الفرع الذي ادخلته موجود", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.ID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            this.txtdept.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد فلا حذف : " + txtdept.Text, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dept.DELETE_DEPT(this.ID);
                    MessageBox.Show("تمت الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    filldgv();
                    btnNew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد فعلا تعديل : " + txtdept.Text, "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dept.UPDATE_DEPT(this.ID, txtdept.Text);
                    MessageBox.Show("تمت تعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldgv();
                    btnNew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPrang_Click(object sender, EventArgs e)
        {
            PL.PrangForm frm = new PrangForm();
            frm.ShowDialog();
        }
    }
}
