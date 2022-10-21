using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    public class DatphongDAO
    {
        private static DatphongDAO instance;

        public static DatphongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatphongDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private DatphongDAO() { }

        #region KLOPER
        public Datphong LayIdDatPhong(int idphong)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_LayBillCuaPhong @idphong" , new object[] { idphong });
            if (data.Rows.Count > 0)
            {
                Datphong idmax = new Datphong(data.Rows[0]);
                return idmax;
            }
            return null;
        }

        public Datphong LayIdDatPhongbangID(int idphong)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery(" USP_LayiddatphongbyIDphong @idphong", new object[] { idphong });
            if (data.Rows.Count > 0)
            {
                Datphong idmax = new Datphong(data.Rows[0]);
                return idmax;
            }
            return null;
        }

        public bool KiemTraVIP(string CCCD)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("KiemTraVip @CCCD ", new object[] { CCCD });
            if (data.Rows.Count >= 5)
            {
                return true;
            }
            return false;
        }
        public string layloaiphong(string tenp)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT TENLOAIPHONG FROM PHONG_tbl a join LOAIPHONG_tbl b on a.IDLOAIPHONG=b.IDLOAIPHONG where a.TENPHONG='"+ tenp+"'");
            string loaiphong = data.Rows[0][0].ToString();
            return loaiphong;
        }
        public void UpdateVIP(string CCCD)
        {
            DataProvider.Instance.ExcuteNonQuery("UpdateVip @CCCD  ", new object[] { CCCD });
        }
        public bool  Doiphong(int iddatphong , int idphongmoi)
        {
            int data = DataProvider.Instance.ExcuteNonQuery("USP_Suaphongvacapnhat @iddatphong , @idphongmoi ", new object[] { iddatphong, idphongmoi});
            if (data > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        public Datphong LayDPbangID(int  id)
        {

            DataTable dt = DataProvider.Instance.ExcuteQuery(" SELECT *FROM dbo.DATPHONG_tbl WHERE ID = " + id);
            Datphong dp = new Datphong(dt.Rows[0]);
            return dp;
        }
        public DataTable LoadPhong()
        {
         
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_ListDATPHONG");
            return dt;
        }
        public DataTable SearchDATPHONG(string text)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_SearchDATPHONG @text",new object[] { text });
            return dt;
        }
        public bool ADDDP( int idkh, int idphong, DateTime ngaydat, DateTime ngaytra, int status )
        {
            string query = " USP_ThemBillDatPhong @idkh , @idphong , @ngaydat , @ngayra , @status " ;
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idkh, idphong, ngaydat, ngaytra ,status}) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
