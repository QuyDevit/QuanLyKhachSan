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
using System.Xml;

namespace QUANLYKS.Usercontrol
{
    public partial class UserControlPhong : UserControl
    {
        public static UserControlPhong instance;
        public UserControlPhong()
        {
            InitializeComponent();
            instance = this;
            loadCTPhong();
        }
        public void loadCTPhong()
        {
            dataRoom.DataSource = PhongDAO.Instance.LoadPhong();
        }

        private void UserControlPhong_Load(object sender, EventArgs e)
        {
            loadCTPhong();
        }

    

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            dataRoom.DataSource = PhongDAO.Instance.timPhong(txtSearchRoom.Text);
        }

        private void dataRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDRoom.Text = dataRoom.SelectedRows[0].Cells[0].Value.ToString();
            txtIDloaiphongup.Text = dataRoom.SelectedRows[0].Cells[3].Value.ToString();
            txtTenphongup.Text = dataRoom.SelectedRows[0].Cells[1].Value.ToString();
            cbbTrangthaiup.Text = dataRoom.SelectedRows[0].Cells[2].Value.ToString();
            if (txtIDloaiphongup.Text == "1")
            {
                cbbLoaiRoomup.Text = "Single";
            }
            if (txtIDloaiphongup.Text == "2")
            {
                cbbLoaiRoomup.Text = "Double";
            }
            if (txtIDloaiphongup.Text == "3")
            {
                cbbLoaiRoomup.Text = "Family";
            }
            if (txtIDloaiphongup.Text == "4")
            {
                cbbLoaiRoomup.Text = "Suite";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbLoaiRoomup.Text) || string.IsNullOrEmpty(txtTenphongup.Text) || string.IsNullOrEmpty(cbbTrangthaiup.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (PhongDAO.Instance.ADDPHONG(Convert.ToInt32(txtIDloaiphongup.Text), txtTenphongup.Text, cbbTrangthaiup.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    loadCTPhong();
                    UserControlDSPhong.instance.LoadPhong();
                    UserControlBDK.instance.sophong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtIDRoom.Text =="")
            {
                MessageBox.Show("Vui lòng chọn id để xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
            }
            else
            {
                if (cbbTrangthaiup.Text == "Bận")
                {
                    MessageBox.Show("Phòng Đang Được Sử Dụng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (PhongDAO.Instance.XoaPHONG(Convert.ToInt32(txtIDRoom.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    loadCTPhong();
                    UserControlBDK.instance.sophong();
                    UserControlDSPhong.instance.LoadPhong();
                    txtIDRoom.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void cbbLoaiRoomup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDloaiphongup.Text= PhongDAO.Instance.LoadidloaiPhong(cbbLoaiRoomup.Text);
        }

    }
}
