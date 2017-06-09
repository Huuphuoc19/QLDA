using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace QLDA
{
    public partial class NhanVienForm : QLDA.BaseForm
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            DataTable nhanVien = NhanVien.getThongTinNhanVien();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                gridThongTinNhanVien.DataSource = nhanVien;
                gridThongTinNhanVien.Columns[7].ReadOnly = true;
                gridThongTinNhanVien.Columns[8].ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridThongTinNhanVien.Rows[0];
            String[] values = new String[6];
            for(var i = 1; i <= 6; i++)
            {
                values[i - 1] = row.Cells[i].Value.ToString();
            }
            if(NhanVien.updateNhanVien(values))
            {
                MessageBox.Show("Updated");
            } else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
