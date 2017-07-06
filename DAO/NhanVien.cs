using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace DAO
{
    public class NhanVien
    {
        private const string GIAM_DOC = "NV02";
        private const string DBA = "da";
        private const string PNS = "HR";
        private const string PHONG_THDA = "Thuc hien de an";
        private const string PHONG_KD = "Kinh doanh";
        private const string PHONG_THKH = "Thuc hien ke hoach";
  

        public static DataTable getAllNhanVien()
        {
            DataTable dt = new DataTable();
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Base.DaConnectionString;
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select TenNV from NhanVien";
            OracleDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public static DataTable getAllNhanVienForGD()
        {
            DataTable dt = new DataTable();
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Base.DaConnectionString;
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from NhanVien";
            OracleDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public static string getRoleNhanVien(string userName)
        {
            string cmdTrgPTHDA = @"select null
                                    from PhongBan p 
                                    where p.TRPHG = '" + userName + "' and p.TENPB='" + PHONG_THDA + "'";
            string cmdTruongPhongNoTNS = @"select *
                                            from PhongBan p 
                                            where p.TRPHG = '" + userName + "' and p.TenPB != '" + PNS + "'";
            string cmdNVPNS = @"select null
                                    from NHANVIEN nv
                                    join PHONGBAN p on p.MAPB = nv.PHG
                                    where p.TENPB='" + PNS + "' and nv.MANV = '" + userName + "'";
            string cmdPVPTHDA = @"select null
                                    from NHANVIEN nv
                                    join PHONGBAN p on p.MAPB = nv.PHG
                                    where p.TENPB='" + PHONG_THDA + "' and nv.MANV = '" + userName + "'";
            string cmdNVPKD = @"select *
                                from NhanVien nv
                                join PhongBan p on p.MaPB = nv.PHG
                                where p.TenPB = '" + PHONG_KD + "' and nv.MaNV = '" + userName + "'";
            string cmdNVPTHKH = @"select *
                                    from NhanVien nv
                                    join PhongBan p on p.MaPB = nv.PHG
                                    where p.TenPB = '" + PHONG_THKH + "' and nv.MaNV = '" + userName + "'";
            string cmdNV = @"select *
                                    from NhanVien nv
                                    where nv.MANV = '" + userName + "'";
            using (OracleConnection conn = new OracleConnection(Base.DaConnectionString))
            {
                if(userName == GIAM_DOC)
                {
                    return Base.GIAM_DOC;
                }
                if(userName == DBA)
                {
                    return Base.DBA;
                }
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = cmdTrgPTHDA;
                if(cmd.ExecuteReader().HasRows)
                {
                    return Base.TRUONG_PTHDA;
                }
                cmd.CommandText = cmdTruongPhongNoTNS;
                if (cmd.ExecuteReader().HasRows)
                {
                    return Base.TRG_PHONG_NOT_NS;
                }
                cmd.CommandText = cmdNVPNS;
                if(cmd.ExecuteReader().HasRows)
                {
                    return Base.NV_PNS;
                }
                cmd.CommandText = cmdPVPTHDA;
                if (cmd.ExecuteReader().HasRows)
                {
                    return Base.NHAN_VIEN_PHONG_THDA;
                }
                cmd.CommandText = cmdNVPKD;
                if(cmd.ExecuteReader().HasRows)
                {
                    return Base.NV_PKD;
                }
                cmd.CommandText = cmdNVPTHKH;
                if(cmd.ExecuteReader().HasRows)
                {
                    return Base.NV_PTHKH;
                }
                
            }
            return Base.NV;
        }

        public static DataTable getThongTinNhanVien()
        {
            DataTable tbl = new DataTable();    
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select  MANV, HONV, TENLOT, TENNV, PHAI, da.ENC_DEC.DECRYPT_SALARY(HASHLUONG,MANV||MANV)as LUONG,DIACHI, NGAYSINH, MANQL, PHG, PHUCAP from da.NHANVIEN_VIEW";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static bool updateNhanVien(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.UpdateNhanvien_1a", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NV_HONV", array[0]);
                    cmd.Parameters.Add("@NV_TENLOT", array[1]);
                    cmd.Parameters.Add("@NV_TENNV", array[2]);
                    cmd.Parameters.Add("@NV_PHAI", array[3]);
                    cmd.Parameters.Add("@NV_DIACHI", array[4]);
                    DateTime t = DateTime.Parse(array[5]);
          
                    cmd.Parameters.Add("@NV_NGAYSINH", t);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        public static DataTable thongTinNVForNVPNS()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.NHANVIEN_VIEW_NS";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao ham update cho giam doc
        public static bool updateThongTin_GD(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.UpdateNhanvien_GD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NV_MANV", array[0]);
                    cmd.Parameters.Add("@NV_LUONG", array[1]);
                    cmd.Parameters.Add("@NV_PHG", array[2]);
                    cmd.Parameters.Add("@NV_PHUCAP", array[3]);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        public static bool updateThongTinNVPNS(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.UpdateNhanvien_NS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NV_MANV", array[0]);
                    cmd.Parameters.Add("@NV_LUONG", array[1]);
                    cmd.Parameters.Add("@NV_PHG", array[2]);
                    cmd.Parameters.Add("@NV_PHUCAP", array[3]);
                    
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        //xay dung function update thông tin de an cho phog ke hoach
        public static bool updateThongTinDeAn(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.UpdateDA_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@DA_MADEAN", array[0]);
                    cmd.Parameters.Add("@DA_TENDEAN", array[1]);
                    cmd.Parameters.Add("@DA_DIADIEM_DA", array[2]);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        //xay dung function delete dean cho nhan vien phong ke hoach
        public static bool deleteThongTinDeAn(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.DeleteDA_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@DA_MADEAN", array[0]);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        //lay thong tin ma phong len cho phong ke hoach
       public static DataTable getMaDAKeHoach()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select MAPB from da.PhongBan";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao function insert cho phong ke hoach
        public static bool insertKeHoach(String[] array)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.InsertDA_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@DA_TENDEAN", array[0]);
                    cmd.Parameters.Add("@DA_PHONG", array[1]);
                    cmd.Parameters.Add("@DA_DIADIEM_DA", array[2]);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        public static DataTable getInfoThucHienDeAn()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.THUC_HIEN_DE_AN_V";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static DataTable getInfoNhanVienTP()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {

                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.NHAN_VIEN_1a_v";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static DataTable getInfoNhanVienDeAnTP()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.THUC_HIEN_DA_TP_V";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static DataTable getInfoThucHienDeAnNVPTHDA()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select da.MaDa, da.TenDA
                                    from da.DeAn da
                                    where da.MaDA not in ( select pc.MaDA from da.PhanCong pc where pc.ManV = user)";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //ham lay toan bo thong tin de an cho giam doc
        public static DataTable getInfoThucHienDeAn_GiamDoc()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select nv.MANV, nv.TENNV, d.MaDa, d.TenDA, d.NGAYBD, d.PHONG, d.DIADIEM_DA
                                    from da.DeAn d, da.NhanVien nv
                                    where d.MaDA in ( select pc.MaDA from da.PhanCong pc, da.NhanVien n  where pc.ManV = n.ManV )";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static DataTable getDeAnById(String mada)
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.DeAn where MaDA = '" + mada + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static int insetPhanCong(String mada)
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.INSERT_PHANCONG_1a", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PC_MADA", mada);
                    cmd.Parameters.Add("@RES", OracleDbType.Int32).Direction = ParameterDirection.Output;
                    
                    cmd.ExecuteNonQuery();

                    int result = int.Parse(cmd.Parameters["@RES"].Value.ToString());
                    return result;
                }
                catch(Exception ex)
                {
                    return -1 ;
                }
            }
            return -1;
        }

        public static DataTable getAllPhanCong()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.PhanCong";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }

        public static bool updateDuyet(string mada, string manv, string value)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"update da.PhanCong 
                                        set duyet = " + value + " where MANV = '" + manv + "' and MADA = '" + mada + "'";
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
               
            }
            return false;
        }

        public static bool updateThoiGianPC(string time, string mada, string manv)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"update da.PhanCong 
                                        set ThoiGian = TO_DATE('" + time + "', 'mm/dd/yyyy hh:mi:ss am') where MANV = '" + manv + "' and MADA = '" + mada + "'";
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            return false;
        }
        //ham lay thong tin bang de an
        public static DataTable getAllDA()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from da.DeAn";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao function load toan bo thong tin user
        public static DataTable getAllUser()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from all_users";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //TAO FUNCION LOAD TOAN BO ROLE 
        public static DataTable getAllRole()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Role_tab_privs";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao function load table name
        public static DataTable getAllTable()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT table_name FROM user_tables";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao function load view name
        public static DataTable getAllView()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select VIEW_NAME from USER_VIEWS";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //tao ham load toan bo procedure
        public static DataTable getAllProcedure()
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT object_name, object_id, created FROM USER_OBJECTS  WHERE object_type = 'PROCEDURE'";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //ham load toan bo thong tin quyền trên table
        public static DataTable getAllPriTable(String Arr)
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Arr, "123")))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from User_tab_privs";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //ham load toan bo thong tin quyen cua user tren role
        public static DataTable getAllPriRole(String Arr)
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Arr, "123")))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from User_role_privs";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //ham load toan bo quyen cua user tren SYS
        public static DataTable getAllPriSys(String Arr)
        {
            DataTable tbl = new DataTable();
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Arr, "123")))
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from User_sys_privs";
                OracleDataReader reader = cmd.ExecuteReader();
                tbl.Load(reader);
            }
            return tbl;
        }
        //ham tao user
        public static bool createUser(String name, String pass)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.createUser1a", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", name);
                    cmd.Parameters.Add("@passphare", pass);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            return false;
        }
        //ham tao role cho quan ly
        public static bool createRole(String name)
        {
            using (OracleConnection conn = new OracleConnection(Base.nvConnectionString(Global.Username, Global.Password)))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("da.createRole1a", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", name);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            return false;
        }
    }
}
