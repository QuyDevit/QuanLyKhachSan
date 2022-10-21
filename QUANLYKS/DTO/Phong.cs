using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYKS.DTO
{
    public class Phong
    {
        private int idphong;
        private int idloaiphong;
        private string tenphong;
        private string roomstatus;

        public Phong(int idphong, int idloaiphong, string tenphong, string roomstatus)
        {
            this.idphong = idphong;
            this.Idloaiphong = idloaiphong;
            this.tenphong = tenphong;
            this.roomstatus = roomstatus;
        }

        public Phong(DataRow row)
        {
            this.idphong = (int)row["IDPHONG"];
            this.Idloaiphong = (int)row["IDLOAIPHONG"];
            this.tenphong = row["TENPHONG"].ToString();
            this.roomstatus = row["ROOM_STATUS"].ToString();
        }

        public int Idphong { get => idphong; set => idphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Roomstatus { get => roomstatus; set => roomstatus = value; }
        public int Idloaiphong
        {
            get => idloaiphong;
            set => idloaiphong = value;
        }
    }
}
