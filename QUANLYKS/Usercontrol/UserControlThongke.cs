using DevExpress.XtraEditors;
using QUANLYKS.DAO;
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
    public partial class UserControlThongke : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlThongke()
        {
            InitializeComponent();
        }

        private void UserControlThongke_Load(object sender, EventArgs e)
        {

        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            chart1.DataSource = HoaDonDAO.Instance.DoanhThuTheoThang(Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text));
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "THÁNG";
            chart1.Series["Doanh Thu"].XValueMember = "THANG";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
           

            chart2.DataSource = HoaDonDAO.Instance.DoanhThuTheoLoaiPhong(Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text));
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "LOẠI PHÒNG";
            chart2.Series["Doanh Thu"].XValueMember = "LOAIPHONG";
            chart2.Series["Doanh Thu"].YValueMembers = "TONGTIEN";


            chart3.DataSource = HoaDonDAO.Instance.DoanhThuTheoDV(Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text));
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Dịch Vụ";
            chart3.Series["Số lượng"].XValueMember = "TENDV";
            chart3.Series["Số lượng"].YValueMembers = "SOLAN";
        }
    }
}
