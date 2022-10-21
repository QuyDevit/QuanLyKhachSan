using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYKS.DTO
{
    public class User
    {
        private int iduser;
        private string hoten;
        private string username;
        private string userpass;
        private string email;
        private int usertype;

        public User(int iduser,string hoten,string username,string userpass,string email,int usertype)
        {
            this.iduser = iduser;
            this.hoten = hoten;
            this.username = username;
            this.userpass = userpass;
            this.email = email;
            this.usertype = usertype;
        }
        public User(DataRow row)
        {
            this.iduser= (int)row["ID"];
            this.hoten = row["DISPLAYNAME"].ToString();
            this.username= row["USER_NAME"].ToString();
            this.userpass = row["USER_PASS"].ToString();
            this.email = row["EMAIL"].ToString();
            this.usertype = (int)row["USER_TYPE"];
        }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Username { get => username; set => username = value; }
        public string Userpass { get => userpass; set => userpass = value; }
        public string Email { get => email; set => email = value; }
        public int Usertype { get => usertype; set => usertype = value; }
        public int Iduser { get => iduser; set => iduser = value; }
    }
}
