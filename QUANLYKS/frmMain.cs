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

namespace QUANLYKS
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public static frmMain instance;
        public string hienthiname;
        public string capquyen;
        public frmMain()
        {
            InitializeComponent();
            instance = this;
        }
        //Di chuyển panel
        private void MovePanel(Control btn)
        {
            pnlSlide.Top = btn.Top;
            pnlSlide.Height = btn.Height;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
            else return;
        }
        //Hiển thị ngày
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblChao.Text = hienthiname;
            if (capquyen == "1") 
            { 
                movePanelBDK(); 
            }
            else { 
                MovePanel(btnDSphong); 
                userDSphong1.Show(); 
            }
        }
        public void movePanelBDK()
        {
            MovePanel(btnBDK);
            userDSphong1.Hide();
            userControlBDK1.Show();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlKhachHang1.Hide();
            userControlNhanvien1.Hide();
            userControlBaocao1.Hide();
            userControlHoadon1.Hide();
            userControlDatphong1.Hide();
            userControlThongke1.Hide();
        }
        private void btnBDK_Click(object sender, EventArgs e)
        {
            if (capquyen == "1")
            {
                movePanelBDK();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền của Admin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            MovePanel(btnKH);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlKhachHang1.Show();
            userControlNhanvien1.Hide();
            userControlDatphong1.Hide();
            userControlBaocao1.Hide();
            userControlThongke1.Hide();
            userControlHoadon1.Hide();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            MovePanel(btnDatPhong);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlCaidat1.Hide();
            userControlKhachHang1.Hide();
            userControlPhong1.Hide();
            userControlNhanvien1.Hide();
            userControlBaocao1.Hide();
            userControlHoadon1.Hide();
            userControlDatphong1.Show();
            userControlThongke1.Hide();
        }
        public void movePanelTK()
        {
            MovePanel(btnCaiDat);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlPhong1.Hide();
            userControlKhachHang1.Hide();
            userControlCaidat1.Show();
            userControlNhanvien1.Hide();
            userControlDatphong1.Hide();
            userControlBaocao1.Hide();
            userControlHoadon1.Hide();
            userControlThongke1.Hide();
        }
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (capquyen == "1")
            {
                movePanelTK();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền của Admin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDSphong_Click(object sender, EventArgs e)
        {
            MovePanel(btnDSphong);
            userDSphong1.Show();
            userControlBDK1.Hide();
            userControlKhachHang1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlNhanvien1.Hide();
            userControlHoadon1.Hide();
            userControlBaocao1.Hide();
            userControlDatphong1.Hide();
            userControlThongke1.Hide();
        }
        public void movePanelNV()
        {
            MovePanel(btnNhanvien);
            userDSphong1.Show();
            userControlBDK1.Hide();
            userControlKhachHang1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlDatphong1.Hide();
            userControlHoadon1.Hide();
            userControlBaocao1.Hide();
            userControlThongke1.Hide();
            userControlNhanvien1.Show();
        }
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            if (capquyen == "1")
            {
                movePanelNV();
 
            }
            else
            {
                MessageBox.Show("Bạn không có quyền của Admin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            MovePanel(btnHoadon);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlKhachHang1.Hide();
            userControlDatphong1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlNhanvien1.Hide();
            userControlBaocao1.Hide();
            userControlHoadon1.Show();
            userControlThongke1.Hide();
        }
        public void movePanelBC()
        {
            MovePanel(btnBaoCao);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlKhachHang1.Hide();
            userControlDatphong1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlNhanvien1.Hide();
            userControlHoadon1.Hide();
            userControlBaocao1.Show();
            userControlThongke1.Hide();
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (capquyen == "1")
            {
                movePanelBC();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền của Admin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void movePanelChart()
        {
            MovePanel(btnChart);
            userDSphong1.Hide();
            userControlBDK1.Hide();
            userControlKhachHang1.Hide();
            userControlDatphong1.Hide();
            userControlCaidat1.Hide();
            userControlPhong1.Hide();
            userControlNhanvien1.Hide();
            userControlHoadon1.Hide();
            userControlBaocao1.Hide();
            userControlThongke1.Show();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            if(capquyen == "1")
            {
                movePanelChart();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền của Admin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool temp = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if (panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!temp)
                {
                    temp = true;
                    panel1.Width = 305;
                }

            }
            else
            {
                if (temp)
                {
                    temp = false;
                    panel1.Visible = false;
                    panel1.Width = 305;
                    guna2Transition1.Show(panel1);
                }
            }
        }
    }
}