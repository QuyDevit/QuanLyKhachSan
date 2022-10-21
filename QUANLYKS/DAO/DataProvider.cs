using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QUANLYKS.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        { get
            { if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set {
                instance = value;
            }
        }

        private DataProvider() { }

        private string connection = @"Data Source=LAPTOP-8PK1OHBQ\SQLEXPRESS01;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public DataTable ExcuteQuery(string query,object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Con = new SqlConnection(connection))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                if(parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sql = new SqlDataAdapter(cmd);
                sql.Fill(dt);
                Con.Close();
            }
            return dt;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection Con = new SqlConnection(connection))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
                Con.Close();
            }
            return dt;
        }
        public DataTable ExcuteQuery1(string query,string colum, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Con = new SqlConnection(connection))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                dt.Columns.Add(colum, typeof(string));
                dt.Load(rdr);
                Con.Close();
            }
            return dt;
        }

    }
}
