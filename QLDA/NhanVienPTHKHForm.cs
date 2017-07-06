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
    public partial class NhanVienPTHKHForm : QLDA.BaseForm
    {
        public NhanVienPTHKHForm()
        {
            InitializeComponent();
            Load_ThongTin();
            Load_DeAn();
            Load_listDA();
            load_MADA();
        }

        //ham lay thong tin user
        private void Load_ThongTin()
        {
            DataTable nhanVien = NhanVien.getThongTinNhanVien();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView1.DataSource = nhanVien;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;
            }
        }
        //lay toan bo thong tin de an
        private void Load_DeAn()
        {
            DataTable nhanVien = NhanVien.getInfoThucHienDeAn();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView2.DataSource = nhanVien;
                for(int i = 0; i < 6; i++)
                {
                    dataGridView2.Columns[i].ReadOnly = true;
                }
            }

        }
        //lay toan bo thong tin de an cho nhan vien thuc hien de an
        private void Load_listDA()
        {
            DataTable nhanVien = NhanVien.getAllDA();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView3.DataSource = nhanVien;
                dataGridView3.Columns[4].ReadOnly = true;
                dataGridView3.Columns[5].ReadOnly = true;

            }
        }
        //load du lieu maDA cho nhan vien phong ke hoạch
        private void load_MADA()
        {
            DataTable nhanVien = NhanVien.getMaDAKeHoach();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {

                comboBox1.DataSource = nhanVien;
                comboBox1.DisplayMember = "MAPB";


            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];
            String[] values = new String[6];
            for (var i = 1; i <= 6; i++)
            {
                values[i - 1] = row.Cells[i].Value.ToString();
            }
            if (NhanVien.updateNhanVien(values))
            {
                Load_ThongTin();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {
                return;
            }
            else if(e.ColumnIndex == 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView3.Rows[index];
                String[] values = new String[3];
                values[0] = row.Cells[2].Value.ToString();
                values[1] = row.Cells[3].Value.ToString();
                values[2] = row.Cells[6].Value.ToString();
                if (NhanVien.updateThongTinDeAn(values))
                {
                    Load_listDA();
                    MessageBox.Show("Updated");
                }
                else
                {

                    MessageBox.Show("Error");
                }
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView3.Rows[index];
                String[] values = new String[1];
                values[0] = row.Cells[2].Value.ToString();
                if (NhanVien.deleteThongTinDeAn(values))
                {
                    Load_listDA();
                    Load_DeAn();
                    MessageBox.Show("delete");
                }
                else
                {

                    MessageBox.Show("Error");
                }

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] values = new String[3];
            values[0] = textBox1.Text.ToString();
            values[1] = comboBox1.Text.ToString();
            values[2] = textBox2.Text.ToString();

            if (NhanVien.insertKeHoach(values))
            {
                Load_listDA();
                MessageBox.Show("Insert successful!!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
