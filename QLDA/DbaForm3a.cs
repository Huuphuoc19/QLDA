using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLDA
{
    public partial class DbaForm3a : QLDA.BaseForm
    {
        public DbaForm3a()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NhanVien.createRole(textBox1.Text))
            {
                MessageBox.Show("Create Success!!!");
                DbaForm dbaForm = new DbaForm();
                dbaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
