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
    public partial class TruongPTHDAForm : QLDA.BaseForm
    {
        public TruongPTHDAForm()
        {
            InitializeComponent();
        }

        private void TruongPTHDAForm_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.ColumnIndex;
            if(index != 4)
            {
                return;
            }
            string value = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            value = (value == "1") ? "0" : "1"; 
            string mada = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string manv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if(NhanVien.updateDuyet(mada, manv, value))
            {

                dataGridView1.Rows[e.RowIndex].Cells[3].Value = value;
                MessageBox.Show("Updated");
            } else
            {
                MessageBox.Show("Internal Error");
            }
        }


        private void fillGridView()
        {
            DataTable dt = NhanVien.getAllPhanCong();
            if (dt.Rows.Count > 0 && dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.HeaderText = "Duyệt";
            dataGridView1.Columns.Add(c);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].ReadOnly = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            var count = dataGridView1.Rows.Count;
            for (var i = 0; i < count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells[3].Value.ToString() == "1")
                {
                    row.Cells[4].Value = true;
                }
            }
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamCongForm chamCongForm = new ChamCongForm();
            chamCongForm.Show();
        }
    }
}
