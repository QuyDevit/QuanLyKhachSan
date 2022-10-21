using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
   public class ThietbiDAO
    {
        private static ThietbiDAO instance;
        public static ThietbiDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThietbiDAO();
                return ThietbiDAO.instance;
            }
            private set
            {
                ThietbiDAO.instance = value;
            }
        }
        private ThietbiDAO()
        {
        }
        public DataTable GetTableTB()
        {
            string query = "Select  * from THIETBI_tbl";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool ThemTB(string tentb, float gia)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_ThemTB @tentb , @gia", new object[] { tentb, gia }) > 0)
                return true;
            return false;
        }
        public bool SuaTB(int id, string tentb, float gia)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_SuaTB @idtb , @tentb , @gia", new object[] { id, tentb, gia }) > 0)
                return true;
            return false;
        }

        public bool XoaTB(int id)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_XOATB @id ", new object[] { id }) > 0)
                return true;
            return false;
        }

        public Thietbi LayIDTBbyTenTB(string tentb)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_LayIDByTenTB @tentb", new object[] { tentb });
            if (data.Rows.Count > 0)
            {
                Thietbi tb = new Thietbi(data.Rows[0]);
                return tb;
            }
            return null;
        }
    }
}
