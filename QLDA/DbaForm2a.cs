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
    public partial class DbaForm2a : QLDA.BaseForm
    {
        public DbaForm2a()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NhanVien.createUser(textBox1.Text, textBox2.Text))
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
