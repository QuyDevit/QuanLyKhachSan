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
    public partial class UserControlNhanvien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlNhanvien()
        {
            InitializeComponent();
      
            loadNV();
        }

        public void loadNV()
        {
            dataNV.DataSource = NhanvienDAO.Instance.loadNV();
        }
        void clear()
        {
            
            txtIDNV.Text = "";
            txtHotenup.Text = "";
            txtSDTup.Text = "";
            txtLuongup.Text = "";
            txtDiachiup.Text = "";
            cbbChucvuup.Text = "";

        }
        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Text = dataNV.SelectedRows[0].Cells[6].Value.ToString();
            txtIDNV.Text = dataNV.SelectedRows[0].Cells[0].Value.ToString();
            txtHotenup.Text = dataNV.SelectedRows[0].Cells[2].Value.ToString();
            txtSDTup.Text = dataNV.SelectedRows[0].Cells[3].Value.ToString();
            txtLuongup.Text = dataNV.SelectedRows[0].Cells[7].Value.ToString();
            txtDiachiup.Text = dataNV.SelectedRows[0].Cells[4].Value.ToString();
            cbbChucvuup.Text = dataNV.SelectedRows[0].Cells[5].Value.ToString();
                    
        }

        private void txtSearchNV_TextChanged(object sender, EventArgs e)
        {
            dataNV.DataSource = NhanvienDAO.Instance.timNV(txtSearchNV.Text);
        }


        private void btnUPNV_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDNV.Text) || string.IsNullOrEmpty(txtDiachiup.Text) || string.IsNullOrEmpty(cbbChucvuup.Text) || string.IsNullOrEmpty(txtHotenup.Text) || string.IsNullOrEmpty(txtSDTup.Text) || string.IsNullOrEmpty(txtLuongup.Text) || string.IsNullOrEmpty(txtidUser.Text))
            {
                MessageBox.Show("Vui Chọn ID Nhân Viên Cần Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NhanvienDAO.Instance.SuaNV(Convert.ToInt32(txtIDNV.Text), Convert.ToInt32(txtidUser.Text), txtHotenup.Text, txtSDTup.Text, Convert.ToInt32(txtLuongup.Text), txtDiachiup.Text, cbbChucvuup.Text,txtEmail.Text))
                {
                    MessageBox.Show("Sửa thành công");
                    loadNV();
             
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnADDNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachiup.Text) || string.IsNullOrEmpty(cbbChucvuup.SelectedItem.ToString()) || string.IsNullOrEmpty(txtHotenup.Text) || string.IsNullOrEmpty(txtSDTup.Text) || string.IsNullOrEmpty(txtLuongup.Text)||txtEmail.Text    =="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NhanvienDAO.Instance.ADDNV(Convert.ToInt32(txtidUser.Text), txtHotenup.Text, txtSDTup.Text, Convert.ToInt32(txtLuongup.Text), txtDiachiup.Text, cbbChucvuup.Text,txtEmail.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    loadNV();
                    UserControlBDK.instance.soTKNV();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnXoanv_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDNV.Text))
            {
                MessageBox.Show("Vui Chọn ID Nhân Viên Cần Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (NhanvienDAO.Instance.XoaNV(Convert.ToInt32(txtIDNV.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    loadNV();
                    UserControlBDK.instance.soTKNV();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (AcountDAO.Instance.kiemtratontaiEmail(txtEmail.Text))
            {

                cbbChucvuup.Items.Clear();
                txtidUser.Text = AcountDAO.Instance.LayNVBangEmail(txtEmail.Text).Iduser.ToString();
                txtHotenup.Text = AcountDAO.Instance.LayNVBangEmail(txtEmail.Text).Hoten;
                txtHotenup.Enabled = false;
                cbbChucvuup.Items.Add("Thu Ngân");
                cbbChucvuup.Items.Add("Quản Lý");
                cbbChucvuup.Items.Add("Lễ Tân");
            }
            else
            {
                cbbChucvuup.Items.Clear();
                txtHotenup.Enabled = true;
                txtHotenup.Text = "";
                txtidUser.Text = "-1";
                cbbChucvuup.Items.Add("Bảo Vệ");
                cbbChucvuup.Items.Add("Tạp Vụ");
                clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
 
        }
    }
}
