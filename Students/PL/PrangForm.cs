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
    public partial class PrangForm : Form
    {
        BL.CLASS_QNAT q = new BL.CLASS_QNAT();
        public PrangForm()
        {
            InitializeComponent();
           
        }
        void fill()
        {
            dataGridView1.DataSource = q.GET_ALL_QNAT();
            DataGridViewColumn newco = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            
            
     
            newco.CellTemplate = cell;
            newco.HeaderText = "عملية";
            newco.Name = "test2";
            newco.ReadOnly = true;
            newco.Visible = true;
            newco.Width = 50;
           
            
            dataGridView1.Columns.Add(newco);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //Icon ic = new Icon(Resource1.dlete.ToString());
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value = "حذف";
            }

            DataGridViewColumn newco1 = new DataGridViewColumn();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            newco1.CellTemplate = cell;
            newco1.ReadOnly = true;
            newco1.HeaderText = "عملية";
            newco1.Name = "test1";
            newco1.Width = 50;
            newco1.Visible = true;
            dataGridView1.Columns.Add(newco1);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount -1].Value = "تعديل";
            }

            dataGridView1.Columns.Add(new DataGridViewImageColumn());
            Icon ic = new Icon(@"C:\Users\musta\Desktop\icon\de.ico");
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewImageCell cell2 = (DataGridViewImageCell)dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1];
               
  
                cell2.Value = ic;
                
            }

            dataGridView1.Columns.Add(new DataGridViewImageColumn());
            Icon ic1 = new Icon(@"C:\Users\musta\Desktop\icon\dei.ico");
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewImageCell cell2 = (DataGridViewImageCell)dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1];


                cell2.Value = ic1;

            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void PrangForm_Load(object sender, EventArgs e)
        {
            fill();
        }

     

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //var s = dataGridView1.CurrentCell.Value;
            //switch (s)
            //{
            //    case "حذف": MessageBox.Show("تمت الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        break;
            //    case "تعديل":
            //        MessageBox.Show("تمت تعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        break;
            //    default:break;
                
            //}

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0)
            {
                var s = dataGridView1.CurrentCell.Value;
                switch (s.ToString())
                {
                    case "حذف":
                        MessageBox.Show("تمت الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "تعديل":
                        MessageBox.Show("تمت تعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "(Icon)":
                            MessageBox.Show("delete", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default: break;

                }
                //MessageBox.Show(s.ToString());
            }
           
        }
    }
}
 