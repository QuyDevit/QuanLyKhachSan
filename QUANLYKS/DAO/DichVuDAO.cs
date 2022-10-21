using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new DichVuDAO();
                return DichVuDAO.instance;
            }
            private set
            {
                DichVuDAO.instance = value;
            }
        }
        private DichVuDAO()
        {
        }
        public List<DichVu> GetListDV()
        {
            List<DichVu> listDV = new List<DichVu>();

            string query = "USP_DSDV";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DichVu dichvu = new DichVu(item);
                listDV.Add(dichvu);
            }

            return listDV;
        }

        public DataTable GetTableDV()
        {
            string query = "Select  * from DICHVU_tbl";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public DataTable TimDichVutheoten(string name)
        {
            string query = "Select  * from DICHVU_tbl where TENDV like N'%" + name+"%'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool ThemDV(string tenDV, float gia)
        {

            if(DataProvider.Instance.ExcuteNonQuery("USP_ThemDVVaGia @tenDV , @dongia", new object[] { tenDV, gia })>0)
                return true;
            return false;
        }
        public bool SuaDV(int id ,string tenDV, float gia)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_SuaDVVaGia @id , @tenDV , @dongia", new object[] { id ,tenDV, gia }) > 0)
                return true;
            return false;
        }

        public bool XoaDV(int id)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_XoaDVVaGia @id ", new object[] { id }) > 0)
                return true;
            return false;
        }
        public bool XoaDVCHECK(int id)
        {

            if (DataProvider.Instance.ExcuteQuery("CHECKDV @idDV", new object[] { id }).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
