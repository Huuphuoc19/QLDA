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
    public partial class GiamDocForm : QLDA.BaseForm
    {
       // private object dataSet1;
       // private object nHANVIEN_VIEW_NSTableAdapter1;

        public GiamDocForm()
        {
            InitializeComponent();
            Load_ThongTin();//load thong tin giam doc len dau tien
            Load_DeAn();//lấy toàn bộ thông tin đề án
        }
        //tao ham lay thong tin giam doc len
        private void Load_ThongTin()
        {
            DataTable nhanVien = NhanVien.getThongTinNhanVien();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGV_GD.DataSource = nhanVien;
                dataGV_GD.Columns[0].ReadOnly = true;
                dataGV_GD.Columns[7].ReadOnly = true;
                dataGV_GD.Columns[8].ReadOnly = true;
            }
        }
        //lay toan bo thong tin de an
        private void Load_DeAn()
        {
            DataTable nhanVien = NhanVien.getInfoThucHienDeAn_GiamDoc();
            if (nhanVien.Rows.Count > 0 && nhanVien != null)
            {
                dataGV_DA.DataSource = nhanVien;
            }

        }
        private void GiamDocForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHANVIEN_VIEW_NS' table. You can move, or remove it, as needed.
            this.dataGridView1.AutoGenerateColumns = false;
            this.nHANVIEN_VIEW_NSTableAdapter.Fill(this.dataSet1.NHANVIEN_VIEW_NS);
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGV_GD.Rows[0];
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGV_GD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 11)
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
            if (NhanVien.updateThongTin_GD(values))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
