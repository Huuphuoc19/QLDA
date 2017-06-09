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
    public partial class NhanVienPNS1aForm : QLDA.BaseForm
    {
        public NhanVienPNS1aForm()
        {
            InitializeComponent();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienPNSForm nhanVienPNSForm = new NhanVienPNSForm();
            nhanVienPNSForm.Show();
        }

        private void NhanVienPNS1aForm_Load(object sender, EventArgs e)
        {
           
        }

        private void NhanVienPNS1aForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.NHANVIEN_VIEW_NS' table. You can move, or remove it, as needed.
            this.nHANVIEN_VIEW_NSTableAdapter1.Fill(this.dataSet3.NHANVIEN_VIEW_NS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 11)
            {
                return;
            }

            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            String[] values = new String[4];
            values[0] = row.Cells[0].Value.ToString();
            values[1] = row.Cells[5].Value.ToString();
            values[2] = row.Cells[9].Value.ToString();
            values[3] = row.Cells[10].Value.ToString();
            if(NhanVien.updateThongTinNVPNS(values))
            {
                MessageBox.Show("Updated");
            } else
            {
                MessageBox.Show("Error");
            }
        }

        private void thucHienDeAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThucHienDeAnForm thucHienDeAnForm = new ThucHienDeAnForm();
            thucHienDeAnForm.Show();
        }
    }
}
