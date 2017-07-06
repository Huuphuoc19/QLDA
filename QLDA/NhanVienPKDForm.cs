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
    public partial class NhanVienPKDForm : QLDA.BaseForm
    {
        public NhanVienPKDForm()
        {
            InitializeComponent();
            Load_ThongTin();
            Load_DeAn();
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
            }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                //Load_ThongTin();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
