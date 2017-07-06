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
    public partial class DbaForm1a : QLDA.BaseForm
    {
       // public String[] values = new String[3];
        public DbaForm1a(String[] values)
        {
            InitializeComponent();
            Load_thongtiUser(values);
            Load_priTable(values[0]);
            Load_priRole(values[0]);
            Load_priSys(values[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DbaForm dbaForm = new DbaForm();
            dbaForm.Show();
        }
        //
        private void Load_thongtiUser(String[] values)
        {
           textBox1.Text = values[0];
           textBox2.Text = values[1];
           textBox3.Text = values[2];
        }
        private void DbaForm1a_Load(object sender, EventArgs e)
        {

        }
        //tao ham load nhưng quyen tren table cua user
        private void Load_priTable(String arr)
        {
            DataTable nhanVien = NhanVien.getAllPriTable(arr);
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView1.DataSource = nhanVien;
            }
        }
        //tao ham load toan bo quyen cua user tren role
        private void Load_priRole(String arr)
        {
            DataTable nhanVien = NhanVien.getAllPriRole(arr);
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView2.DataSource = nhanVien;
            }
        }
        //ham load toan bo quyen của user tren sys
        private void Load_priSys(String arr)
        {
            DataTable nhanVien = NhanVien.getAllPriSys(arr);
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView3.DataSource = nhanVien;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = values[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "gjg";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.Text = values[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
