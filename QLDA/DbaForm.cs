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
    public partial class DbaForm : QLDA.BaseForm
    {
        public DbaForm()
        {
            InitializeComponent();
            Load_User();
            Load_Role();
            Load_Table();
            Load_View();
            load_Procedure();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //Ham load thong tin user
        private void Load_User()
        {
            DataTable nhanVien = NhanVien.getAllUser();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView1.DataSource = nhanVien;
            }

        }
        //Ham load toan bo thong ti role trong database
        private void Load_Role()
        {
            DataTable nhanVien = NhanVien.getAllRole();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView2.DataSource = nhanVien;
            }
        }
        //ham load thong tin toan bo table
        private void Load_Table()
        {
            DataTable nhanVien = NhanVien.getAllTable();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView3.DataSource = nhanVien;
            }
        }
        //ham load toan bo thong tin view
        private void Load_View()
        {
            DataTable nhanVien = NhanVien.getAllView();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView4.DataSource = nhanVien;
            }
        }
        //Ham load toan bo stored procedure
        private void load_Procedure()
        {
            DataTable nhanVien = NhanVien.getAllProcedure();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView5.DataSource = nhanVien;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbaForm2a dbaForm2a = new DbaForm2a();
            dbaForm2a.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }

            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            String[] values = new String[3];
            values[0] = row.Cells[1].Value.ToString();
            values[1] = row.Cells[2].Value.ToString();
            values[2] = row.Cells[3].Value.ToString();
            DbaForm1a dbaForm1a = new DbaForm1a(values);
            dbaForm1a.Show();
            this.Hide();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbaForm3a dbaForm2a = new DbaForm3a();
            dbaForm2a.Show();
            this.Hide();
        }
    }
}
