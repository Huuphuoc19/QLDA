using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using DAO;

namespace QLDA
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = NhanVien.getAllNhanVien();
            if (dt.Rows.Count > 0 && dt != null)
            {
                dataGridView1.DataSource = dt;
            }
         }*/

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
