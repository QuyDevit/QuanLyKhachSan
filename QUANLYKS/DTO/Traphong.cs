using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Traphong
    {
        private int idtp;
        private int idkh;
        private int idphong;
        private DateTime ngaytra;

        public int Idtp { get => idtp; set => idtp = value; }
        public int Idkh { get => idkh; set => idkh = value; }
        public int Idphong { get => idphong; set => idphong = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }

        public Traphong(int idtp, int idkh, int idphong, DateTime ngaytra)
        {
            this.idtp = idtp;
            this.idkh = idkh;
            this.idphong = idphong;
            this.ngaytra = ngaytra;
        }
        public Traphong(DataRow row)
        {
            this.idtp = (int)row["IDTRAPHONG"];
            this.idkh = (int)row["IDKH"];
            this.idphong = (int)row["IDPHONG"];
            this.ngaytra = (DateTime)row["NGAYTRA"];
        }
    }
}
