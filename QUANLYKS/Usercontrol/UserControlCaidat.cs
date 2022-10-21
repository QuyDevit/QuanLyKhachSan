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
    public partial class UserControlCaidat : UserControl
    {
        public UserControlCaidat()
        {
            InitializeComponent();
        }

        public void listUser()
        {
            dataUser.DataSource = AcountDAO.Instance.LoadUser();
        }

   
        public void loadchucvuUP()
        {
            if (cbbloaiUserup.SelectedItem.ToString() == "0")
            {
                txtCVup.Text = "User";
            }
            else
                txtCVup.Text = "Admin";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameuserup.Text) || string.IsNullOrEmpty(txtTKup.Text) || string.IsNullOrEmpty(txtMKup.Text) || string.IsNullOrEmpty(txtEmailup.Text) || string.IsNullOrEmpty(cbbloaiUserup.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               if( AcountDAO.Instance.AddUser(txtNameuserup.Text, txtTKup.Text, txtMKup.Text, txtEmailup.Text, Convert.ToInt32(cbbloaiUserup.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    listUser();
                    UserControlBDK.instance.soTKNV();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNameuserup.Text) || string.IsNullOrEmpty(txtTKup.Text) || string.IsNullOrEmpty(txtMKup.Text) || string.IsNullOrEmpty(txtEmailup.Text) || string.IsNullOrEmpty(cbbloaiUserup.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (AcountDAO.Instance.SuaUser(Convert.ToInt32(txtID.Text), txtNameuserup.Text, txtTKup.Text, txtMKup.Text, txtEmailup.Text, Convert.ToInt32(cbbloaiUserup.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                     listUser();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn ID để xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (AcountDAO.Instance.XoaUser(Convert.ToInt32(txtID.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    listUser();
                    UserControlBDK.instance.soTKNV();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void UserControlCaidat_Load(object sender, EventArgs e)
        {
            listUser();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            dataUser.DataSource = AcountDAO.Instance.timUser(txtSearchUser.Text);
        }

        private void dataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataUser.SelectedRows[0].Cells[5].Value.ToString();
            txtNameuserup.Text = dataUser.SelectedRows[0].Cells[0].Value.ToString();
            txtTKup.Text = dataUser.SelectedRows[0].Cells[1].Value.ToString();
            txtMKup.Text = dataUser.SelectedRows[0].Cells[2].Value.ToString();
            txtEmailup.Text = dataUser.SelectedRows[0].Cells[3].Value.ToString();
            cbbloaiUserup.Text = dataUser.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void cbbloaiUserup_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadchucvuUP();
        }


    }
}

