using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYKS.DAO
{
    public  class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        #region KLOPER
        public List<Phong> GetListPhong()
        {
            List<Phong> roomList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExcuteQuery("EXECUTE USP_DSPhongTrong");

            foreach (DataRow item in data.Rows)
            {
                Phong room = new Phong(item);
                roomList.Add(room);
            }

            return roomList;
        }
        public List<Phong> GetAllListPhong()
        {
            List<Phong> roomList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_DSPhongAll");

            foreach (DataRow item in data.Rows)
            {
                Phong room = new Phong(item);
                roomList.Add(room);
            }

            return roomList;
        }
        public Phong GetPhongByID(int idphong)
        {

                DataTable data = DataProvider.Instance.ExcuteQuery("USP_LayTenVaGia @idphong", new object[] { idphong });
                if (data.Rows.Count > 0)
                {
                    Phong phong = new Phong(data.Rows[0]);
                    return phong;
                }
                return null;
        }
        public Phong GetPhongByTenphong(string tenphong)
        {

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_layphongbangtenphong @tenphongmoi", new object[] { tenphong });
            if (data.Rows.Count > 0)
            {
                Phong phong = new Phong(data.Rows[0]);
                return phong;
            }
            return null;
        }
        public bool SuaTrangThaiTraPhong(int idphong ,int iddatphong)
        {
            string query = "USP_DoiTrangThaiTraPhong @idphong , @iddatphong";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idphong, iddatphong }) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        private PhongDAO() { }

        public List<Phong> LoadPhong()
        {
            List<Phong> listphong = new List<Phong>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("getlistPhong");
            foreach(DataRow item in dt.Rows)
            {
                Phong phong = new Phong(item);
                listphong.Add(phong);
            }
            return listphong;
        }
        public bool ADDPHONG( int idloaiphong,string tenphong,string trangthai)
        {
            string query = "ThemRoom @idloaiphong , @tenphong , @trangthai";
            if(DataProvider.Instance.ExcuteNonQuery(query, new object[] { idloaiphong, tenphong, trangthai }) > 0)
            {
                return true;
            }
            return false;
            
        }
        public DataTable timPhong(string ten)
        {
            string query = "timPhong @tenphong";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { ten });
            return dt;
        }
 
        public bool XoaPHONG(int idphong)
        {
            string query = "XoaRoom @idphong";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idphong }) > 0)
            {
                return true;
            }
            return false;

        }
  
        public string LoadidloaiPhong(string tenphong)
        {
            string query = "getidloaiphong @tenloaiphong";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { tenphong });
            string id = dt.Rows[0][0].ToString();
            return id;
        }
    
    }
}
