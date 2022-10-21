using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class Thietbi
    {
        private int idtb;
        private string tentb;
        private float gia;

        public int Idtb
        {
            get => idtb;
            set => idtb = value;
        }
        public string Tentb
        {
            get => tentb;
            set => tentb = value;
        }
        public float Gia
        {
            get => gia;
            set => gia = value;
        }


        public Thietbi(DataRow row)
        {
          
            this.Idtb = (int)row["IDTB"];
            this.Tentb = row["TENTB"].ToString();
            this.Gia = (float)Convert.ToDouble(row["DONGIA"].ToString());
        }
    }
}
