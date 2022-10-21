using DevExpress.XtraEditors;
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
    public partial class frmthongtinDP : DevExpress.XtraEditors.XtraForm
    {
        public frmthongtinDP()
        {
            InitializeComponent();
        }
        public int IDDP;
        public string Status;
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        Datphong dp;
        Phong phong;
        Khachhang kh;
        public void all()
        {
            dp = DatphongDAO.Instance.LayDPbangID(IDDP);
            phong = PhongDAO.Instance.GetPhongByID(dp.Idphong);
            kh = KhachhangDAO.Instance.LayTTKhbangIDDP(dp.Idkh);
        }
        private void frmthongtinDP_Load(object sender, EventArgs e)
        {
            all();
            txtDC.Text = kh.Diachi;
            txtQT.Text = kh.Quoctich;
            txtTenKH.Text = kh.Tenkh;
            txtHo.Text = kh.Hokh;
            txtCCCD.Text = kh.Cccd;
            txtSDT.Text = kh.Sdtkh;
            txtGiaphong.Text = phong.Idloaiphong.ToString("c", culture);
            txtTenPhong.Text = phong.Tenphong;
            txtLoaiphong.Text = DatphongDAO.Instance.layloaiphong(phong.Tenphong);
            string[] t1 = dp.Ngaydat.ToString().Split(' ');
            string[] t2 = dp.Ngaytra.ToString().Split(' ');
            txtNgayvao.Text = t1[0];
            txtNgayra.Text = t2[0];
            btnNhanPhong.Text = Status;
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}