using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYKS
{
    public partial class rptnHD : DevExpress.XtraReports.UI.XtraReport
    {
        public static rptnHD instance;
        public rptnHD()
        {
            InitializeComponent();
            instance = this;
            
        }
        public static string cccd;
        public static string sale;
        public static string tenkh;
        public static string tenphong;
        public static string giaphong;
        public static string loaiphong;
        public static string ngayvao;
        public static string ngayra; 
        public static string quoctich;
        public static string diachi;
        public static string songayo;
        public static string giaphong2;
        public static string tienphong;
        public static string tiendv;
        public static string tongtien;
        public void setText()
        {
            lblsale.Text = sale +" :";
            lblCCCD.Text = cccd;
            lblTenkh.Text = tenkh;
            lblTenphong.Text = tenphong;
            lblNgayvao.Text = ngayvao;
            lblNgayra.Text = ngayra;
            lblGiaphong.Text = giaphong;
            lblLoaiphong.Text = loaiphong;
            lblDiachi.Text = diachi;
            lblQuoctich.Text = quoctich;
            lblGiaphongx.Text = giaphong2;
            lblSongayo.Text = songayo;
            lblTienphong.Text = tienphong;
            lblTienDV.Text = tiendv;
            lblTongtien.Text = tongtien;
        }    
 
    }
}
