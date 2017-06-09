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
    }
}
