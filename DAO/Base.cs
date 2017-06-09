using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Base
    {

        public const string GIAM_DOC = "GIAM_DOC";
        public const string NV_PNS = "NV_PNS";
        public const string DBA = "DBA";
        public const string NHAN_VIEN_PHONG_THDA = "NHAV_VIEN_PHONG_THDA";
        public const string TRUONG_PTHDA = "TRUONG_PTHDA";
        public const string NV_PKD = "NV_PHONG_KD";
        public const string NV_PTHKH = "NV_PTHKH";
        public const string TRG_PHONG_NOT_NS = "TRUONG_PHONG_NO_NS";
        public const string NV = "NHAN_VIEN";

        private static string daConnectionString = "User Id=DA;Password=123;Data Source=localhost:1521/orcl;";

        public static string DaConnectionString
        {
            get
            {
                return daConnectionString;
            }

            set
            {
                daConnectionString = value;
            }
        }
    }
}
