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
    public partial class UserControlBDK : UserControl
    {
        public static UserControlBDK instance;
        public UserControlBDK()
        {
            instance = this;
            InitializeComponent();
        }
        public void sophong()
        {
            lblRoom.Text = BangDKDAO.Instance.Laysophong();
        }
        public void soDV()
        {
            lblDV.Text = BangDKDAO.Instance.LaySoDV();
        }
        public void soTb()
        {
            lblTB.Text = BangDKDAO.Instance.LaySoTB();
        }
        public void soTKNV()
        {
            lblTK.Text = BangDKDAO.Instance.LayTK();
            lblNV.Text = BangDKDAO.Instance.LayNV();
        }
        public void UserControlBDK_Load(object sender, EventArgs e)
        {
            sophong();
            soDV();
            soTb();
            soTKNV();
        }

        private void pnPhong_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Brown;
        }

        private void pnPhong_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(255, 128, 128);
        }


        private void pnPhong_Click(object sender, EventArgs e)
        {
            frmPhong f = new frmPhong();
            f.ShowDialog();
        }

        private void pnDichVu_MouseHover(object sender, EventArgs e)
        {
            pnDichVu.BackColor = Color.Brown;
        }

        private void pnDichVu_MouseLeave(object sender, EventArgs e)
        {
            pnDichVu.BackColor = Color.FromArgb(70, 90, 101);
        }

        private void pnDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu f = new frmDichVu();
            f.ShowDialog();
        }

        private void pnlTB_Click(object sender, EventArgs e)
        {
            frmThietbi f = new frmThietbi();
            f.ShowDialog();
        }

        private void pnlTB_MouseHover(object sender, EventArgs e)
        {
            pnlTB.BackColor = Color.Brown;
        }

        private void pnlTB_MouseLeave(object sender, EventArgs e)
        {
            pnlTB.BackColor = Color.FromArgb(207, 147, 217);
        }

        private void pnTK_MouseLeave(object sender, EventArgs e)
        {          
             pnTK.BackColor = Color.FromArgb(78, 209, 166);
        }

        private void pnTK_MouseHover(object sender, EventArgs e)
        {
            pnTK.BackColor = Color.Brown;
        }

        private void pnTK_Click(object sender, EventArgs e)
        {
            frmMain.instance.movePanelTK();
        }

        private void pnNV_Click(object sender, EventArgs e)
        {
            frmMain.instance.movePanelNV();
        }

        private void pnNV_MouseHover(object sender, EventArgs e)
        {
            pnNV.BackColor = Color.Brown;
        }

        private void pnNV_MouseLeave(object sender, EventArgs e)
        {
            pnNV.BackColor = Color.FromArgb(238, 232, 150);
        }
    }
}
