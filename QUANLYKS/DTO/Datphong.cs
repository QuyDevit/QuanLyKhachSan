using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Datphong
    {
        private int iddp;
        private int idkh;
        private int idphong;
        private DateTime ngaydat;
        private DateTime ngaytra;
        private int status;
        public int Iddp { get => iddp; set => iddp = value; }
        public int Idkh { get => idkh; set => idkh = value; }
        public int Idphong { get => idphong; set => idphong = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public int Status
        {
            get => status;
            set => status = value;
        }

        public Datphong(DataRow row)
        {
            this.Iddp = (int)row["ID"];
            this.Idkh = (int)row["IDKH"];
            this.Idphong = (int)row["IDPHONG"];
            this.Ngaydat = (DateTime)row["NGAYDAT"];
            this.Ngaytra = (DateTime)row["NGAYTRA"];
            this.Status = (int)row["STATUS"];
        }
        public Datphong(int iddp, int idkh, int idphong, DateTime ngaydat, DateTime ngaytra)
        {
            this.iddp = iddp;
            this.idkh = idkh;
            this.idphong = idphong;
            this.ngaydat = ngaydat;
            this.ngaytra = ngaytra;
        }
    }
}
