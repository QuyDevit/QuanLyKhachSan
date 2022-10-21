using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKS.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return HoaDonDAO.instance;
            }
            private set
            {
                HoaDonDAO.instance = value;
            }
        }
        
        private HoaDonDAO()
        {
        }
        public Hoadon ListHD(int idhd)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.HOADON_tbl where IDHD="+ idhd );
            Hoadon hd = new Hoadon(dt.Rows[0]);
            return hd;
        }
        public bool THemHoadon(int iddp ,string tenphong ,string loaiphong ,DateTime NgayVao,DateTime NgayRa,string HoTen, string QuocTich,string DiaChi,float TienPhong,float TienDV,float TongTien)
        {
            string query = "USP_ThemHoaDonThongKe @IDDP , @TENPHONG , @LOAIPHONG , @NGAYVAO , @NGAYRA , @HOTEN , @QUOCTICH , @DIACHI , @TIENPHONG , @TIENDV , @TONGTIEN";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { iddp, tenphong,  loaiphong,  NgayVao,  NgayRa,  HoTen,  QuocTich,  DiaChi,  TienPhong,  TienDV,  TongTien }) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable LoadHoaDon()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.HOADON_tbl");
            return dt;
        }
        public DataTable SearchHD(string text)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_SearchHD @text", new object[] { text });
            return dt;
        }
        public DataTable LoadHoaDonrp(DateTime tungay,DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("Loadrptheongay @tungay , @denngay", new object[] { tungay, denngay });
            return dt;
        }
        public DataTable LoadHoaDonLPrp(string loaiphong ,DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("LoadrptheongayLoaiPhong @loaiphong , @tungay , @denngay", new object[] { loaiphong,tungay, denngay });
            return dt;
        }
        public string TongDTLoaiPhong(string loaiphong, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("TongTienLoaiPhong @loaiphong , @tungay , @denngay", new object[] { loaiphong, tungay, denngay });
            string tt = dt.Rows[0][0].ToString();
            return tt;
        }
        public DataTable LoadHoaDonDVrp(int iddv, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("BaoCaoTheoDV @iddv , @ngayvao , @ngayra", new object[] { iddv, tungay, denngay });
            return dt;
        }
        public string TongDVrp(int iddv, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("TongTienTheoDVP @iddv , @ngayvao , @ngayra", new object[] { iddv, tungay, denngay });
            string tt = dt.Rows[0][0].ToString();
            return tt;
        }
        public DataTable LoadHoaDonPhongrp(string ten, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("BaoCaoTheoPhong @tenPhong , @ngayvao , @ngayra", new object[] { ten, tungay, denngay });
            return dt;
        }
        public string TongPhongrp(string ten, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("TongTienTheoPhong @tenPhong , @ngayvao , @ngayra", new object[] { ten, tungay, denngay });
            string tt = dt.Rows[0][0].ToString();
            return tt;
        }
        public DataTable LoadHoaDonKHrp(int idlkh, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("BaoCaoTheoKhachHang @loaikh , @ngayvao , @ngayra", new object[] { idlkh, tungay, denngay });
            return dt;
        }
        public string TongKHrp(int idlkh, DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("TongTheoKhachHang @loaikh , @ngayvao , @ngayra", new object[] { idlkh, tungay, denngay });
            string tt = dt.Rows[0][0].ToString();
            return tt;
        }
        public DataTable DoanhThuTheoThang(DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("ThongKeTheoThang @tungay , @denngay", new object[] {  tungay, denngay });
            return dt;
        }
        public DataTable DoanhThuTheoLoaiPhong(DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("ThongKeTheoLoaiPhong @tungay , @denngay", new object[] { tungay, denngay });
            return dt;
        }
        public DataTable DoanhThuTheoDV(DateTime tungay, DateTime denngay)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("ThongKeTheoDV @tungay , @denngay", new object[] { tungay, denngay });
            return dt;
        }
    }
}
