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
    public partial class TruongPhongNotNSForm : QLDA.BaseForm
    {
        public TruongPhongNotNSForm()
        {
            InitializeComponent();
        }

        private void TruongPhongNotNSForm_Load(object sender, EventArgs e)
        {
            DataTable nhanVien = NhanVien.getInfoNhanVienTP();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGridView1.DataSource = nhanVien;
            }
        }

        private void nhanVienDeAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThucHienDeAnTPForm thucHienDeAnTPForm = new ThucHienDeAnTPForm();
            thucHienDeAnTPForm.Show();
        }
    }
}
