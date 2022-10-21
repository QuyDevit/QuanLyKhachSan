using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Hoadon
    {
        private int idhd;
        private int iddp;
        private string tenphong;
        private string loaiphong;
        private DateTime ngaydat;
        private DateTime ngaytra;
        private string tenkh;
        private string quoctich;
        private string diachi;
        private float tienphong;
        private float tiendv;
        private float tongtien;
        public Hoadon(DataRow row)
        {
            this.Idhd = (int)row["IDHD"];
            this.Iddp = (int)row["IDDATPHONG"];
            this.Tenphong = row["TENPHONG"].ToString();
            this.Loaiphong = row["LOAIPHONG"].ToString();
            this.Ngaydat = (DateTime)row["NGAYVAO"];
            this.Ngaytra = (DateTime)row["NGAYRA"];
            this.Tenkh = row["HOTEN"].ToString();
            this.Quoctich = row["QUOCTICH"].ToString();
            this.Diachi = row["DIACHI"].ToString();
            this.Tienphong = (float)Convert.ToDouble( row["TIENPHONG"].ToString());
            this.Tiendv = (float)Convert.ToDouble(row["TIENDV"].ToString());
            this.Tongtien = (float)Convert.ToDouble(row["TONGTIEN"].ToString());
        }

        public int Idhd { get => idhd; set => idhd = value; }
        public int Iddp { get => iddp; set => iddp = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public float Tienphong { get => tienphong; set => tienphong = value; }
        public float Tiendv { get => tiendv; set => tiendv = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
    }
}
