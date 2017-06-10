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
    public partial class DangKiThucHienDeAnForm : QLDA.BaseForm
    {
        public DangKiThucHienDeAnForm()
        {
            InitializeComponent();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienPTHDAForm nhanVienPTHDAForm = new NhanVienPTHDAForm();
            nhanVienPTHDAForm.Show();
        }

        private void DangKiThucHienDeAnForm_Load(object sender, EventArgs e)
        {
            DataTable dt = NhanVien.getInfoThucHienDeAnNVPTHDA();
            comboBox1.DisplayMember = "TenDA";
            comboBox1.ValueMember = "MaDA";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mada;
            mada = comboBox1.SelectedValue.ToString();
            DataTable dt = NhanVien.getDeAnById(mada);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String mada;
                mada = comboBox1.SelectedValue.ToString();

                var result = NhanVien.insetPhanCong(mada);
                if (result == 1)
                {
                    MessageBox.Show("Inserted");
                }
                else if (result == -1)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Phân công đã tồn tại");
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show("Đề án không thể trống");
            }
        }
    }
}
