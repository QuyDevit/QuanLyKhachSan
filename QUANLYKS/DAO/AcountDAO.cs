using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QUANLYKS.DTO;

namespace QUANLYKS.DAO
{
    public class AcountDAO
    {
        private static AcountDAO instance;

        public static AcountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AcountDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AcountDAO() { }

        public List<User> LoadUser()
        {
            List<User> listuser = new List<User>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("getlistUser");
            foreach(DataRow item in dt.Rows)
            {
                User user = new User(item);
                listuser.Add(user);
            }
            return listuser;
        }
        public DataTable timUser(string ten)
        {
            string query = "timUser @ten";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query,new object[] { ten});
            return dt;
        }
        public bool AddUser(string ten,string tk,string pass,string email,int type)
        {
            string query = "ThemUser @ten , @tk , @mk , @email , @type";
            if(DataProvider.Instance.ExcuteNonQuery(query,new object[] { ten, tk, pass, email, type }) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaUser(int id, string ten, string tk, string pass, string email, int type)
        {
            string query = "SuaUser @id , @ten , @tk , @mk , @email , @type";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] {id, ten, tk, pass, email, type }) > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaUser(int id)
        {
            string query = "XoaUser @id";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] {  id}) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Login(string user,string pass)
        {
            string query = "USP_Login @userName , @pass";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query,new object[] {user,pass });
            return kq.Rows.Count>0;
        }
        public string tenLogin(string user, string pass)
        {
            string query = "USP_Login @userName , @pass";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { user, pass });
            string ten = kq.Rows[0][0].ToString();
            return ten;
        }
        public string capquyen(string user, string pass)
        {
            string query = "kiemtratUser @userName , @pass";
            DataTable kq = DataProvider.Instance.ExcuteQuery(query, new object[] { user, pass });
            string quyen = kq.Rows[0][0].ToString();
            return quyen;
        }
        public bool kiemtratontaiEmail(string email)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_LayUserbangEmailNV @email", new object[] { email });
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public User LayNVBangEmail(string email)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_LayUserbangEmailNV @email", new object[] { email });
            User user = new User(dt.Rows[0]);
            return user;
        }
    }
}
