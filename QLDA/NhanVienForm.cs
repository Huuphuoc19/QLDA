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
            }
        }
    }
}
