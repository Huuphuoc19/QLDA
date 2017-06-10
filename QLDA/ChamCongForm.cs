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
    public partial class ChamCongForm : QLDA.BaseForm
    {
        public ChamCongForm()
        {
            InitializeComponent();
        }
        DateTimePicker dateTimePicker = new DateTimePicker();
        private void duyệtĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruongPTHDAForm truongPTHDAForm = new TruongPTHDAForm();
            truongPTHDAForm.Show();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.PHANCONG' table. You can move, or remove it, as needed.
            this.pHANCONGTableAdapter.Fill(this.dataSet4.PHANCONG);
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Visible = false;
            dateTimePicker.Width = 222;
            dataGridView1.Controls.Add(dateTimePicker);
            dateTimePicker.ValueChanged += this.dateTimePicker_ValueChanged;
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if((dataGridView1.Focused) && dataGridView1.CurrentCell.ColumnIndex == 2)
                {
                    dateTimePicker.Location = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dateTimePicker.Visible = true;
                    if(dataGridView1.CurrentCell.Value!=DBNull.Value)
                    {
                        dateTimePicker.Value = (DateTime)dataGridView1.CurrentCell.Value;
                    }
                    else
                    {
                        dateTimePicker.Value = DateTime.Today;
                    }
                } else
                {
                    dateTimePicker.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((dataGridView1.Focused) && dataGridView1.CurrentCell.ColumnIndex == 2)
                {
                    dataGridView1.CurrentCell.Value = dateTimePicker.Value.Date;
                    dateTimePicker.Visible = false;
                    string time = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string manv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string mada = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if(NhanVien.updateThoiGianPC(time, mada, manv))
                    {
                        MessageBox.Show("Updated");
                    } else
                    {
                        MessageBox.Show("Internal Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker_ValueChanged(Object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dateTimePicker.Text;
        }
    }
}
