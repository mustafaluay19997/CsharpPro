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
    public partial class QnatForm : Form
    {
        BL.CLASS_QNAT qnat = new BL.CLASS_QNAT();
        int ID = 0;
        public QnatForm()
        {
            InitializeComponent();
            filldvg();
        }
        void filldvg()
        {
            dgv.DataSource = qnat.GET_ALL_QNAT();
            DataGridViewColumn newco = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newco.CellTemplate = cell;
            newco.HeaderText = "Delete";
            newco.Name = "test";
            newco.Visible = true;
            
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "de";
            }
            dgv.Columns.Add(newco);
            //dgv.Rows[1].Cells[2].Value = "de";
        }

        Boolean check(string word)
        {
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (item.Cells["اسم القناة"].Value.ToString() == word)
                    return true;

            }
            return false;
        }

        private void txtQnat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (txtQnat.Text != "")
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

        private void QnatForm_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtQnat.Clear();
            txtQnat.Focus();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check(txtQnat.Text))
                {
                    qnat.ADD_QNAT(txtQnat.Text);
                    MessageBox.Show("تمت الاضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldvg();
                    btnNew_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("اسم القناة الذي ادخلته موجود", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.ID = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value.ToString());
            this.txtQnat.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد فلا حذف : " + txtQnat.Text, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    qnat.DELETE_QNAT(this.ID);
                    MessageBox.Show("تمت الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    filldvg();
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
                if (MessageBox.Show("هل تريد فعلا تعديل : " + txtQnat.Text, "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    qnat.UPDATE_QNAT(this.ID, txtQnat.Text);
                    MessageBox.Show("تمت تعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldvg();
                    btnNew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dgv.Columns[e.ColumnIndex].Name == "حذف")
            //{
            //    if (MessageBox.Show("هل تريد فلا حذف : " + txtQnat.Text, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("تمت الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        MessageBox.Show(dgv.CurrentRow.Cells[1].Value.ToString());

            //    }
            //}
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            int x = dgv.Rows.Count;
            int y = dgv.CurrentRow.Index;

        }
    }
}
