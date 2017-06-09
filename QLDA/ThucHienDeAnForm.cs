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
    public partial class ThucHienDeAnForm : QLDA.BaseForm
    {
        public ThucHienDeAnForm()
        {
            InitializeComponent();
        }

        private void nhanVienPNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienPNS1aForm nhanVienPNS1aForm = new NhanVienPNS1aForm();
            nhanVienPNS1aForm.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienPNSForm nhanVienPNSForm = new NhanVienPNSForm();
            nhanVienPNSForm.Show();
        }

        private void ThucHienDeAnForm_Load(object sender, EventArgs e)
        {
            DataTable dt = NhanVien.getInfoThucHienDeAn();
            if(dt.Rows.Count > 0 && dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
