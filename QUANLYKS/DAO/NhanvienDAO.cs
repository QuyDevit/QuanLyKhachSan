using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    class NhanvienDAO
    {
        private static NhanvienDAO instance;

        public static NhanvienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanvienDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private NhanvienDAO() { }
        public List<Nhanvien> loadNV()
        {
            List<Nhanvien> listnv = new List<Nhanvien>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("getlistNV");
            foreach (DataRow item in dt.Rows)
            {
                Nhanvien nv = new Nhanvien(item);
                listnv.Add(nv);
            }
            return listnv;
        }

        public bool ADDNV(int iduser, string hoten, string sdt, int luong, string diachi,string chucvu ,string email)
        {
            string query = "ThemNV @iduser , @hoten , @sdt , @luong , @diachi , @chucvu , @email";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { iduser, hoten, sdt, luong, diachi, chucvu , email }) > 0)
            {
                return true;
            }
            return false;

        }
        public bool SuaNV(int idnv, int iduser, string hoten, string sdt, int luong, string diachi, string chucvu ,string email)
        {
            string query = "SuaNV @idnv , @iduser , @hoten , @sdt , @luong , @diachi , @chucvu , @email";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idnv, iduser, hoten, sdt, luong, diachi, chucvu ,email }) > 0)
            {
                return true;
            }
            return false;

        }
        public bool XoaNV(int idnv)
        {
            string query = "Xoanv @idnv";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idnv }) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable timNV(string ten)
        {
            string query = "timNV @ten";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { ten });
            return dt;
        }
    }
}
