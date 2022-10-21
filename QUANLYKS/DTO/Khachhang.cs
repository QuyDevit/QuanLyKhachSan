using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Khachhang
    {
        private int idkh;
        private string hokh;
        private string tenkh;
        private string sdtkh;
        private string quoctich;
        private string diachi;
        private string cccd;
        private int loaikh;

        public Khachhang(int idkh,string hokh,string tenkh,string sdtkh,string quoctich,string diachi,string cccd,int loaikh)
        {
            this.idkh = idkh;
            this.hokh = hokh;
            this.tenkh = tenkh;
            this.sdtkh = sdtkh;
            this.quoctich = quoctich;
            this.diachi = diachi;
            this.cccd = cccd;
            this.loaikh = loaikh;
        }
        public Khachhang(DataRow row)
        {
            this.Idkh = (int)row["IDKH"];
            this.Hokh = row["HO"].ToString();
            this.Tenkh = row["TEN"].ToString();
            this.Sdtkh = row["SDT"].ToString();
            this.Quoctich = row["QUOCTICH"].ToString();
            this.Diachi = row["DIACHI"].ToString();
            this.Cccd = row["CCCD"].ToString();
            this.Loaikh = (int)row["IDLOAIKH"];
        }

        public int Idkh { get => idkh; set => idkh = value; }
        public string Hokh { get => hokh; set => hokh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdtkh { get => sdtkh; set => sdtkh = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cccd
        {
            get => cccd;
            set => cccd = value;
        }
        public int Loaikh
        {
            get => loaikh;
            set => loaikh = value;
        }
    }
}
