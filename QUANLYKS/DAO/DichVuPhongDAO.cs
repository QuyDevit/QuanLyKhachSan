using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QUANLYKS.DTO;
using System.Windows.Forms;

namespace QUANLYKS.DAO
{
    public class DichVuPhongDAO
    {
        private static DichVuPhongDAO instance;

        public static DichVuPhongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DichVuPhongDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private DichVuPhongDAO() { }



        public bool ThemDVPHONG(int idphong,int iddatphong,int iddv,int soluong)
        {
            string query = "USP_ThemDichvuVaoBill @idphong , @iddatphong , @iddv , @soluong";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idphong, iddatphong, iddv , soluong }) > 0)
            {
                return true;
            }
            else return false;
        }
        public DataTable LoadPhong(int idphong)
        {
            int iddatphong = DatphongDAO.Instance.LayIdDatPhong(idphong).Iddp;
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_LayDVChitiet @iddatphong",new object[] { iddatphong });
            return dt;
        }
        public DataTable LoadPhonghd(int iddatphong)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_LayDVChitiet @iddatphong", new object[] { iddatphong });
            return dt;
        }
        public string tenphong(int idphong)
        {
            string query = "gettenphong @idphong";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { idphong });
            string ten = kq.Rows[0][0].ToString();
            return ten;
        }
        public string giaphong(int idphong)
        {
            string query = "getgiaphong @idphong";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { idphong });
            string gia = kq.Rows[0][0].ToString();
            return gia;
        }
        public string trangthaiphong(int idphong)
        {
            string query = "gettrangthaiphong @idphong";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { idphong });
            string status = kq.Rows[0][0].ToString();
            return status;
        }
        public string loaiphong(int idphong)
        {
            string query = "idloaiphong @idphong";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { idphong });
            string loaiphong = kq.Rows[0][0].ToString();
            return loaiphong;
        }

    }
}
