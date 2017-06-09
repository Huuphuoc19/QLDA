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
    public partial class ThucHienDeAnTPForm : QLDA.BaseForm
    {
        public ThucHienDeAnTPForm()
        {
            InitializeComponent();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruongPhongNotNSForm truongPhongNotNSForm = new TruongPhongNotNSForm();
            truongPhongNotNSForm.Show();
        }

        private void ThucHienDeAnTPForm_Load(object sender, EventArgs e)
        {
            DataTable nhanVien = NhanVien.getInfoNhanVienDeAnTP();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView1.DataSource = nhanVien;
            }
        }
    }
}
