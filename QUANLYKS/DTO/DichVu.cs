using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class DichVu
    {
        private int iDDV;
        private string tENDV;
        private float dONGIA;

        public DichVu(int iDDV, string tENDV, float dONGIA)
        {
            this.IDDV = iDDV;
            this.TENDV = tENDV;
            this.DONGIA = dONGIA;
        }

        public DichVu(DataRow row)
        {
            this.IDDV = (int)row["IDDV"];
            this.TENDV = row["TENDV"].ToString();
            this.DONGIA = (float)Convert.ToDouble(row["DONGIA"].ToString());
        }
        public int IDDV
        {
            get => iDDV;
            set => iDDV = value;
        }

        public float DONGIA
        {
            get => dONGIA;
            set => dONGIA = value;
        }
        public string TENDV
        {
            get => tENDV;
            set => tENDV = value;
        }
    }
}
