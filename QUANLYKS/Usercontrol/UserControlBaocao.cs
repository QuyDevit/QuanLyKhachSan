using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QUANLYKS.DAO;
using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKS.Usercontrol
{
    public partial class UserControlBaocao : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlBaocao()
        {
            InitializeComponent();
            LoadDV();
            LoadDSP();
            cbbLoaiPhong.Text = "Single";
            cbbLoaikh.Text = "Thường";

        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            rptBaocao rp = new rptBaocao();
            rp.DataSource = HoaDonDAO.Instance.LoadHoaDonrp(Convert.ToDateTime(dtpTuNgay.Value.ToString()), Convert.ToDateTime(dtpDenNgay.Value.ToString()));
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnTheoLP_Click(object sender, EventArgs e)
        {
            rpTheoloaiphong rp = new rpTheoloaiphong();
            rp.DataSource = HoaDonDAO.Instance.LoadHoaDonLPrp(cbbLoaiPhong.Text,Convert.ToDateTime(dtpTuNgayB.Value.ToString()), Convert.ToDateTime(dtpDenNgayB.Value.ToString()));
            string tt = HoaDonDAO.Instance.TongDTLoaiPhong(cbbLoaiPhong.Text, Convert.ToDateTime(dtpTuNgayB.Value.ToString()), Convert.ToDateTime(dtpDenNgayB.Value.ToString()));
            rpTheoloaiphong.instance.setText(tt+"  đ");
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }
        void LoadDV()
        {
            List<DichVu> listdichVu = DichVuDAO.Instance.GetListDV();
            cbbDV.DataSource = listdichVu;
            cbbDV.DisplayMember = "TENDV";
        }
        void LoadDSP()
        {
            List<Phong> list= PhongDAO.Instance.GetAllListPhong();
            cbbPhong.DataSource = list;
            cbbPhong.DisplayMember = "TENPHONG";
        }

        private void btnBaoCaoTDV_Click(object sender, EventArgs e)
        {
            rptTheoDV rp = new rptTheoDV();
            string[] str = cbbDV.Text.Split('-');
            rp.DataSource = HoaDonDAO.Instance.LoadHoaDonDVrp(Convert.ToInt32(str[0]), Convert.ToDateTime(dtpTheoDVS.Value.ToString()), Convert.ToDateTime(dtpTheoDVE.Value.ToString()));
            string tt = HoaDonDAO.Instance.TongDVrp(Convert.ToInt32(str[0]), Convert.ToDateTime(dtpTheoDVS.Value.ToString()), Convert.ToDateTime(dtpTheoDVE.Value.ToString()));
            rptTheoDV.instance.setText(tt + "  đ");
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnTheophong_Click(object sender, EventArgs e)
        {
            rpTheophong rp = new rpTheophong();
            string[] str = cbbPhong.Text.Split('-');
            rp.DataSource = HoaDonDAO.Instance.LoadHoaDonPhongrp(str[0], Convert.ToDateTime(dtpTheoPhongV.Value.ToString()), Convert.ToDateTime(dtpTheoPhongR.Value.ToString()));
            string tt = HoaDonDAO.Instance.TongPhongrp(str[0], Convert.ToDateTime(dtpTheoPhongV.Value.ToString()), Convert.ToDateTime(dtpTheoPhongR.Value.ToString()));
            rpTheophong.instance.setText(tt + "  đ");
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }

        private void btnTheoKH_Click(object sender, EventArgs e)
        {
            int temp;
            if (cbbLoaikh.Text == "Thường")
            {
                temp = 0;
            }
            else
                temp = 1;
            rpTheoloaikh rp = new rpTheoloaikh();
            rp.DataSource = HoaDonDAO.Instance.LoadHoaDonKHrp(temp, Convert.ToDateTime(dtpTheokhV.Value.ToString()), Convert.ToDateTime(dtpTheokhR.Value.ToString()));
            string tt = HoaDonDAO.Instance.TongKHrp(temp, Convert.ToDateTime(dtpTheokhV.Value.ToString()), Convert.ToDateTime(dtpTheokhR.Value.ToString()));
            rpTheoloaikh.instance.setText(tt + "  đ");
            ReportPrintTool tool = new ReportPrintTool(rp);
            tool.ShowPreview();
        }
    }
}
