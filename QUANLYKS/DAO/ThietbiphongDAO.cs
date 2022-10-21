using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    public class ThietbiphongDAO
    {
        private static ThietbiphongDAO instance;
        public static ThietbiphongDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThietbiphongDAO();
                return ThietbiphongDAO.instance;
            }
            private set
            {
                ThietbiphongDAO.instance = value;
            }
        }
        private ThietbiphongDAO()
        {
        }
        public DataTable GetTableTBP(string tenPhong)
        {
            string query = "USP_GetListThietBiPhong @tenPhong";

            DataTable data = DataProvider.Instance.ExcuteQuery(query,new object[] { tenPhong });
            return data;
        }
        public List<Thietbi> GetListTB()
        {
            List<Thietbi> tbList = new List<Thietbi>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_LAYTENTB");

            foreach (DataRow item in data.Rows)
            {
                Thietbi room = new Thietbi(item);
                tbList.Add(room);
            }

            return tbList;
        }
        public bool ThemTBPHONG(int idphong , int idtb,int soluong)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_ThemTBPHONG @idphong , @idtb , @soluong", new object[] { idphong, idtb, soluong }) > 0)
                return true;
            return false;
        }
        public bool SuaTBPHONG(int idtbp,int idphong, int idtb, int soluong)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_SuaTBP @idtbp , @idphong , @idTB , @SL", new object[] { idtbp, idphong, idtb, soluong }) > 0)
                return true;
            return false;
        }

        public bool XoaTBPHONG(int idtbp)
        {

            if (DataProvider.Instance.ExcuteNonQuery("USP_XoaTBP @idtbp ", new object[] { idtbp }) > 0)
                return true;
            return false;
        }

    }
}
