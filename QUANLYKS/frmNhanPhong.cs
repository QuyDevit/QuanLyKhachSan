using DevExpress.XtraEditors;
using QUANLYKS.DAO;
using QUANLYKS.DTO;
using QUANLYKS.Usercontrol;
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
    public partial class frmNhanPhong : DevExpress.XtraEditors.XtraForm
    {
        public int idphong;
        public frmNhanPhong()
        {
            InitializeComponent();

        }

        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {
            updngay();
        }

        private void dtpNgayRa_ValueChanged(object sender, EventArgs e)
        {
            updngay();
        }
        void updngay()
        {
            DateTime start = dtpNgayDat.Value.Date;
            DateTime end = dtpNgayRa.Value.Date;
            TimeSpan diffResult = end.Subtract(start);
            if (diffResult.Days > 0)
            {
                lbSongay.Text = diffResult.Days.ToString();
            }
            else
            {
                lbSongay.Text = "1";
            }
        }
        void upForminfo()
        {
            Phong phong = PhongDAO.Instance.GetPhongByID(idphong);
            txtTenPhong.Text = phong.Tenphong;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtGiaphong.Text = phong.Idloaiphong.ToString("c", culture);
            txtLoaiphong.Text = phong.Roomstatus;
        }

        private void frmNhanPhong_Load(object sender, EventArgs e)
        {
            upForminfo();
            updngay();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtHo.Text == "" || txtSDT.Text == "" || cbbQuoctich.Text == "" || txtDC.Text == "" ||txtCCCD.Text =="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                ThemKHThemBillChuyenStatusRoom();
            }
        }
        void ThemKHThemBillChuyenStatusRoom()
        {
            //Co KH thì thêm Datphong

           
            if (KhachhangDAO.Instance.ADDkh(txtHo.Text, txtTenKH.Text, txtSDT.Text, cbbQuoctich.Text, txtDC.Text, txtCCCD.Text))
            {
                int idkh = KhachhangDAO.Instance.LayIDByCCCD(txtCCCD.Text);
                if (DatphongDAO.Instance.ADDDP(idkh, idphong,Convert.ToDateTime( dtpNgayDat.Text), Convert.ToDateTime(dtpNgayRa.Text), 0))
                {
                    if(DatphongDAO.Instance.KiemTraVIP(txtCCCD.Text))
                    {
                        DatphongDAO.Instance.UpdateVIP(txtCCCD.Text);
                    }    
                    MessageBox.Show("Nhận Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserControlDSPhong.instance.LoadPhong();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (KhachhangDAO.Instance.KiemtraTontaibyCCCD(txtCCCD.Text))
            {
                Khachhang khachhang = KhachhangDAO.Instance.LayTTKhbangCCCD(txtCCCD.Text);
                txtTenKH.Enabled = false;
                txtHo.Enabled = false;
                txtSDT.Enabled = false;
                cbbQuoctich.Enabled = false;
                txtDC.Enabled = false;
                txtTenKH.Text = khachhang.Tenkh;
                txtHo.Text = khachhang.Hokh;
                txtSDT.Text = khachhang.Sdtkh;
                cbbQuoctich.Text = khachhang.Quoctich;
                txtDC.Text = khachhang.Diachi;

            }
            else
            {
                txtTenKH.Enabled = true;
                txtHo.Enabled = true;
                txtSDT.Enabled = true;
                cbbQuoctich.Enabled = true;
                txtDC.Enabled = true;
                txtTenKH.Text = "";
                txtHo.Text = "";
                txtSDT.Text = "";
                cbbQuoctich.Text = "";
                txtDC.Text = "";
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}