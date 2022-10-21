using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Nhanvien
    {
        private int idnv;
        private int iduser;
        private string hotennv;
        private string sdt;
        private int luong;
        private string diachi;
        private string chucvu;
        private string email;

        public int Idnv { get => idnv; set => idnv = value; }
        public int Iduser { get => iduser; set => iduser = value; }
        public string Hotennv { get => hotennv; set => hotennv = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public string Diachi { get => diachi; set => diachi = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Email { get => email; set => email = value; }
        public int Luong { get => luong; set => luong = value; }

        public Nhanvien(DataRow row)
        {
            this.Idnv = (int)row["IDNV"];
            this.Iduser = (int)row["IDUSER"];
            this.Hotennv = row["HOTEN"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.Luong = (int)row["LUONG"];
            this.Diachi = row["DIACHI"].ToString();
            this.Chucvu = row["CHUCVU"].ToString();
            this.Email = row["EMAIL"].ToString();
        }
    }
}
