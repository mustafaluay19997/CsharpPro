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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQnat_Click(object sender, EventArgs e)
        {
            PL.QnatForm frm = new PL.QnatForm();
            frm.ShowDialog();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            PL.DeptForm frm = new PL.DeptForm();
            frm.ShowDialog();
        }
    }
}
