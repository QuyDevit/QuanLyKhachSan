using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DTO
{
    public class DichVuphong
    {
        private int iDDVPHONG;
        private int iDPHONG;
        private int iDDATPHONG;
        private int iDDV;
        private int sOLAN;

        public int IDDVPHONG
        {
            get => iDDVPHONG;
            set => iDDVPHONG = value;
        }
        public int IDPHONG
        {
            get => iDPHONG;
            set => iDPHONG = value;
        }
        public int IDDATPHONG
        {
            get => iDDATPHONG;
            set => iDDATPHONG = value;
        }
        public int IDDV
        {
            get => iDDV;
            set => iDDV = value;
        }
        public int SOLAN
        {
            get => sOLAN;
            set => sOLAN = value;
        }

        public DichVuphong(int iDDVPHONG, int iDPHONG, int iDDATPHONG, int iDDV,int sOLAN)
        {
            this.IDDVPHONG = iDDVPHONG;
            this.IDPHONG = iDPHONG;
            this.IDDATPHONG = iDDATPHONG;
            this.IDDV = iDDV;
            this.SOLAN = sOLAN;
        }
        public DichVuphong(DataRow row)
        {
            this.IDDVPHONG = (int)row["IDDVPHONG"];
            this.IDPHONG = (int)row["IDPHONG"];
            this.IDDATPHONG = (int)row["IDDATPHONG"];
            this.IDDV = (int)row["IDDV"];
            this.SOLAN = (int)row["SOLAN"];
        }

    }
}
