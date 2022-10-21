using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmThongtinPhong : DevExpress.XtraEditors.XtraForm
    {
 
        public int iddv;
        public frmThongtinPhong()
        {
            InitializeComponent();
        }
        public int getIDPHONG;
        public int idloaiphong;
        public float TienPhong;
        public float TienDV;
        public float TongTien;
        void loaddsdvphong()
        {
            dataDSDV.DataSource = DichVuPhongDAO.Instance.LoadPhong(getIDPHONG);
        }

        #region KLOPER
        void loatDSphong()
        {
            List<Phong> listphong = PhongDAO.Instance.GetListPhong();
            cbbTenPhong.DataSource = listphong;
            cbbTenPhong.DisplayMember = "TENPHONG";
        }
        void loatDSDV()
        {
            List<DichVu> listdichVu = DichVuDAO.Instance.GetListDV();
            cbbDV.DataSource = listdichVu;
            cbbDV.DisplayMember = "TENDV";
        }
        #endregion

        int TongTienThueDVLa()
        {
            int kq = 0;
            for (int i = 0; i <= dataDSDV.RowCount-1; i++)
            {
                kq = kq + int.Parse(dataDSDV.Rows[i].Cells[3].Value.ToString());
            }
            return kq;
        }
        void LoadAll()
        {
            int iddatphong = DatphongDAO.Instance.LayIdDatPhongbangID(getIDPHONG).Iddp;
            int idkh = DatphongDAO.Instance.LayIdDatPhongbangID(getIDPHONG).Idkh;
            Khachhang khachhang = KhachhangDAO.Instance.LayTTKhbangIDDP(idkh);
            Datphong datphong = DatphongDAO.Instance.LayDPbangID(iddatphong);
            CultureInfo culture = new CultureInfo("vi-VN");
            loaddsdvphong();
            Phong phong = PhongDAO.Instance.GetPhongByID(getIDPHONG);
            DateTime START = datphong.Ngaydat.Date;
            double ngayo = DateTime.Today.Subtract(START).TotalDays;
            txtTenPhong.Text = DichVuPhongDAO.Instance.tenphong(getIDPHONG);
            LBLGIAP.Text = phong.Idloaiphong.ToString("c",culture);
            double giaPhongTong;
            if (ngayo > 0)
            {
                lblO.Text = ngayo.ToString();
                giaPhongTong = ngayo * Convert.ToDouble(DichVuPhongDAO.Instance.giaphong(getIDPHONG));
                TienPhong = (float)ngayo * (float)Convert.ToDouble(phong.Idloaiphong.ToString("#,##0"));
                lbldongia.Text = giaPhongTong.ToString("c",culture) ;
            }
            else
            {
                lblO.Text = "1";
                giaPhongTong = phong.Idloaiphong;
                lbldongia.Text = phong.Idloaiphong.ToString("c", culture);
                TienPhong =  (float) Convert.ToDouble( phong.Idloaiphong.ToString("#,##0"));
            }

            TienDV = TongTienThueDVLa();
            lbTongDV.Text = TienDV.ToString("c", culture);
            if (khachhang.Loaikh == 0)
            {
                TongTien = Convert.ToInt32(giaPhongTong) + TienDV;
            }
            else
            {
                TongTien = (Convert.ToInt32(giaPhongTong) + TienDV)*0.9f;
                btnSale.Text = "Giảm 10%";
            } 
                   
            lblTongtien.Text= TongTien.ToString("c", culture);
            txtCCCD.Text = khachhang.Cccd;
            string[] t1 = datphong.Ngaydat.ToString().Split(' ');
            string[] t2 = DateTime.Now.ToString().Split(' ');
            dateVao.Text = t1[0];
            DateRa.Text = t2[0];
            txtQT.Text = khachhang.Quoctich;
            txtDC.Text = khachhang.Diachi;
            txtTenKH.Text = khachhang.Hokh + " " + khachhang.Tenkh;
            txtGiaphong.Text = phong.Idloaiphong.ToString("c", culture);
            txtLoaiphong.Text = DichVuPhongDAO.Instance.loaiphong(getIDPHONG);
            txtStatus.Text = DichVuPhongDAO.Instance.trangthaiphong(getIDPHONG);
            loatDSphong();
            loatDSDV();
        }
        private void frmThongtinPhong_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (cbbDV.Text == "")
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] iddv = cbbDV.Text.Split('-');

                if (DichVuPhongDAO.Instance.ThemDVPHONG(getIDPHONG,DatphongDAO.Instance.LayIdDatPhong(getIDPHONG).Iddp, Convert.ToInt32(iddv[0]),1))
                {
                    MessageBox.Show("Thêm thành công");
                    loaddsdvphong();
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm");
                }

            }
        }

        private void btnDoiphong_Click(object sender, EventArgs e)
        {
            int iddatphong = DatphongDAO.Instance.LayIdDatPhongbangID(getIDPHONG).Iddp;
            string[] tenphong = cbbTenPhong.Text.Split('-');
            int idphongmoi = PhongDAO.Instance.GetPhongByTenphong(tenphong[0]).Idphong;
            if (DatphongDAO.Instance.Doiphong(iddatphong, idphongmoi))
            {
                
                DialogResult result = MessageBox.Show("Đổi phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();                
                }
                
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    


        }

        private void frmThongtinPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlDSPhong.instance.LoadPhong();
        }

        private void btnTraphong_Click(object sender, EventArgs e)
        {
            int iddatphong = DatphongDAO.Instance.LayIdDatPhongbangID(getIDPHONG).Iddp;
            DialogResult d;
            d = MessageBox.Show("Bạn có thực sự muốn trả phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (HoaDonDAO.Instance.THemHoadon(iddatphong, txtTenPhong.Text, txtLoaiphong.Text, Convert.ToDateTime(dateVao.Text), Convert.ToDateTime(DateRa.Text),txtTenKH.Text, txtQT.Text, txtDC.Text, TienPhong, TienDV, TongTien))
                {
                    if(PhongDAO.Instance.SuaTrangThaiTraPhong(getIDPHONG, iddatphong))
                    {
                        DialogResult d1 = MessageBox.Show("Trả phong thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(d1 == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
             
                }
                
            }
            else
            {
                return;
            }    
      
        }

        private void btnDeldv_Click(object sender, EventArgs e)
        {
            if (iddv <1)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               

                if (DichVuPhongDAO.Instance.ThemDVPHONG(getIDPHONG, DatphongDAO.Instance.LayIdDatPhong(getIDPHONG).Iddp, iddv,-1))
                {
                    MessageBox.Show("Xóa Thành Công");
                    loaddsdvphong();
                    LoadAll();
                    iddv = -1;
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm");
                }

            }
        }



        private void dataDSDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {   
                string[] id = dataDSDV.SelectedRows[0].Cells[0].Value.ToString().Split('.');
                iddv = Convert.ToInt32(id[0]);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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
            rp.DataSource = DichVuPhongDAO.Instance.LoadPhong(getIDPHONG);      
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();         
        }
    }
}