using QUANLYKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QUANLYKS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picThunho_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picThunho, "Thu màn hình");
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Đóng chương trình");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Hiện mật khẩu");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picHide, "Ẩn mật khẩu");
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            picShow.Hide();
            txtPass.UseSystemPasswordChar = false;
            picHide.Show();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picHide.Hide();
            txtPass.UseSystemPasswordChar = true;
            picShow.Show();
        }

        private void txtUser_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool Login(string user,string pass)
        {
            return AcountDAO.Instance.Login(user, pass);
        }
        string tenLogin(string user, string pass)
        {
            return AcountDAO.Instance.tenLogin(user, pass);
        }
        string capquyenuser(string user,string pass)
        {
            return AcountDAO.Instance.capquyen(user, pass);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản và Mật Khẩu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if(Login(user,pass)==true )
                {
                    frmMain frm = new frmMain();
                    frm.hienthiname = tenLogin(user, pass);
                    frm.capquyen = capquyenuser(user, pass);
                    txtUser.Clear();
                    txtPass.Clear();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu", "Tài Khoản hoặc Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
