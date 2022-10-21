using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYKS.DAO
{
    public class BangDKDAO
    {
        private static BangDKDAO instance;

        public static BangDKDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BangDKDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private BangDKDAO() { }

        public string LaySoDV()
        {
            string query= "SELECT COUNT(*) FROM DICHVU_tbl";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string so = dt.Rows[0][0].ToString();
            return so;
        }
        public string LaySoTB()
        {
            string query = "SELECT COUNT(*) FROM THIETBI_tbl";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string so = dt.Rows[0][0].ToString();
            return so;
        }
        public string Laysophong()
        {
            string query = "getsoPhong";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string sophong = dt.Rows[0][0].ToString();
            return sophong;
        }
        public string LayNV()
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN_tbl";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string so= dt.Rows[0][0].ToString();
            return so;
        }
        public string LayTK()
        {
            string query = "SELECT COUNT(*) FROM USER_tbl";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string so = dt.Rows[0][0].ToString();
            return so;
        }

    }
}
