using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QUANLYKS.DAO;
using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKS
{
    public partial class frmThongtinHD : DevExpress.XtraEditors.XtraForm
    {
        public frmThongtinHD()
        {
            InitializeComponent();
        }
        public int IDHD;
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        Hoadon hd;
        Datphong dp;
        Phong phong;
        Khachhang kh;
        public void all()
        {
            hd = HoaDonDAO.Instance.ListHD(IDHD);
            dp = DatphongDAO.Instance.LayDPbangID(hd.Iddp);
            phong = PhongDAO.Instance.GetPhongByID(dp.Idphong);
            kh = KhachhangDAO.Instance.LayTTKhbangIDDP(dp.Idkh);
        }
       
        private void frmThongtinHD_Load(object sender, EventArgs e)
        {
            all();
            dataDSDV.DataSource = DichVuPhongDAO.Instance.LoadPhonghd(dp.Iddp);
            txtDC.Text = kh.Diachi;
            txtQT.Text = kh.Quoctich;
            LBLGIAP.Text= phong.Idloaiphong.ToString("c", culture);
            lblO.Text = (hd.Tienphong / phong.Idloaiphong).ToString();
            lblTongtien.Text = hd.Tongtien.ToString("c", culture);
            lbTongDV.Text = hd.Tiendv.ToString("c", culture);
            lbldongia.Text = hd.Tienphong.ToString("c", culture);
            txtTenKH.Text = hd.Tenkh;
            txtGiaphong.Text = phong.Idloaiphong.ToString("c",culture);
            txtTenPhong.Text = hd.Tenphong;
            txtLoaiphong.Text = hd.Loaiphong;
            string[] t1 = hd.Ngaydat.ToString().Split(' ');
            string[] t2 = hd.Ngaytra.ToString().Split(' ');
            dateVao.Text = t1[0];
            DateRa.Text = t2[0];
            txtCCCD.Text = kh.Cccd;
            if (hd.Tienphong + hd.Tiendv > hd.Tongtien)
            {
                btnSale.Text = "Giảm 10%";
            }
            else btnSale.Text = "Giảm 0%";
        }
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            rptnHD rp = new rptnHD();
            rptnHD.tenkh = txtTenKH.Text;
            rptnHD.tenphong = txtTenPhong.Text;
            rptnHD.giaphong = txtGiaphong.Text;
            rptnHD.giaphong2 = LBLGIAP.Text;
            rptnHD.loaiphong = txtLoaiphong.Text;
            rptnHD.ngayvao = dateVao.Text;
            rptnHD.ngayra = DateRa.Text;
            rptnHD.quoctich = txtQT.Text;
            rptnHD.diachi = txtDC.Text;
            rptnHD.songayo = lblO.Text;
            rptnHD.tienphong = lbldongia.Text;
            rptnHD.tiendv = lbTongDV.Text;
            rptnHD.tongtien = lblTongtien.Text;
            rptnHD.cccd = txtCCCD.Text;
            rptnHD.sale = btnSale.Text;
            rptnHD.instance.setText();
            rp.DataSource = DichVuPhongDAO.Instance.LoadPhonghd(dp.Iddp);
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

    }
}