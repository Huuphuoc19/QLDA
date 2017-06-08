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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string connectionString = "User Id=" + userName + ";Password=" + password + ";Data Source=localhost:1521/orcl;";
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {   
                try
                {
                    conn.Open();

                    switch (NhanVien.getRoleNhanVien(userName))
                    {
                        case Base.DBA:
                            {
                                this.Hide();
                                DbaForm dbaForm = new DbaForm();
                                dbaForm.Show(); 
                            }
                            break;
                        case Base.GIAM_DOC:
                            {
                                this.Hide();
                                GiamDocForm giamDocForm = new GiamDocForm();
                                giamDocForm.Show();
                            }
                            break;
                        case Base.NV_PKD:
                            {
                                this.Hide();
                                NhanVienPKDForm nhanVienPKDForm = new NhanVienPKDForm();
                                nhanVienPKDForm.Show();
                            }
                            break;
                        case Base.NV_PNS:
                            {
                                this.Hide();
                                NhanVienPNSForm nhanVienPNSForm = new NhanVienPNSForm();
                                nhanVienPNSForm.Show();
                            }
                            break;
                        case Base.NV_PTHKH:
                            {
                                this.Hide();
                                NhanVienPTHKHForm nhanVienPTHKHForm = new NhanVienPTHKHForm();
                                nhanVienPTHKHForm.Show();
                            }
                            break;
                        case Base.NHAN_VIEN_PHONG_THDA:
                            {
                                this.Hide();
                                NhanVienPTHDAForm nhanVienPTHDAForm = new NhanVienPTHDAForm();
                                nhanVienPTHDAForm.Show();
                            }
                            break;
                        case Base.TRUONG_PTHDA:
                            {
                                this.Hide();
                                TruongPTHDAForm truongPTHDAForm = new TruongPTHDAForm();
                                truongPTHDAForm.Show();
                            }
                            break;
                        case Base.TRG_PHONG_NOT_NS:
                            {
                                this.Hide();
                                TruongPTHDAForm truongPTHDAForm = new TruongPTHDAForm();
                                truongPTHDAForm.Show();
                            }
                            break;
                        default:
                            {
                                this.Hide();
                                NhanVienForm nhanVienFrom = new NhanVienForm();
                                nhanVienFrom.Show();
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username or password invalid");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
