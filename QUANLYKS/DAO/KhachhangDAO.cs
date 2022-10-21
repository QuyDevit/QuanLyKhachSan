using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    public class KhachhangDAO
    {
        private static KhachhangDAO instance;

        public static KhachhangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachhangDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private KhachhangDAO() { }

        #region KLOPER
        public int LayIDByCCCD(string cccd)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT IDKH FROM dbo.KHACHHANG_tbl WHERE CCCD ="+cccd);
            DataRow row = data.Rows[0];
            int id = (int)row["IDKH"];
            return id;
     
        }
        public bool KiemtraTontaibyCCCD(string cccd)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT CCCD FROM dbo.KHACHHANG_tbl WHERE CCCD =" + cccd);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        public List<Khachhang> loadKH()
        {
            List<Khachhang> listkh = new List<Khachhang>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("getlistkh");
            foreach(DataRow item in dt.Rows)
            {
                Khachhang kh = new Khachhang(item);
                listkh.Add(kh);
            }
            return listkh;
        }
        public Khachhang LayTTKhbangCCCD(string cccd)
        {

            DataTable dt = DataProvider.Instance.ExcuteQuery(" SELECT *FROM dbo.KHACHHANG_tbl WHERE CCCD = "+ cccd);          
            Khachhang kh = new Khachhang(dt.Rows[0]);
            return kh;
        }
        public Khachhang LayTTKhbangIDDP(int idkh)
        {

            DataTable dt = DataProvider.Instance.ExcuteQuery(" SELECT *FROM dbo.KHACHHANG_tbl WHERE IDKH = " + idkh);
            Khachhang kh = new Khachhang(dt.Rows[0]);
            return kh;
        }
        public bool ADDkh( string ho, string ten,string sdt,string quoctich,string diachi,string cccd)
        {
            string query = "ThemKH @ho , @ten , @sdt , @quoctich , @diachi , @cccd";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ho, ten, sdt , quoctich, diachi,cccd }) > 0)
            {
                return true;
            }
            return false;
        }
        public bool KiemTraKHByCCCD(string ho, string ten, string sdt, string quoctich, string diachi, string cccd)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_KiemTraCCCD @ho , @ten , @sdt , @quoctich , @diachi , @cccd", new object[] { ho,  ten,  sdt,  quoctich,diachi, cccd });
            if (data.Rows.Count > 0)
            {
                 return true;
            }
            return false;
        }
        public bool SuaKH(int idkh, string ho,string ten, string sdt, string quoctich, string diachi,string cccd,int loaikh)
        {
            string query = "SuaKH @idkh , @ho , @ten , @sdt , @quoctich , @diachi , @cccd , @loaikh";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idkh, ho, ten, sdt, quoctich , diachi , cccd , loaikh }) > 0)
            {
                return true;
            }
            return false;

        }
        public bool XoaKH(int idkh)
        {
            string query = "XoaKH @idkh";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idkh }) > 0)
            {
                return true;
            }
            return false;

        }
        public DataTable timKH(string ten)
        {
            string query = "Timkhtheoten @ten";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { ten });
            return dt;
        }
    }
}
