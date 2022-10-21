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
    public partial class UserControlKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlKhachHang()
        {
            InitializeComponent();
            LoadKH();
        }

        public void LoadKH()
        {
            dataKH.DataSource = KhachhangDAO.Instance.loadKH();
        }


        private void txtSearchKH_TextChanged(object sender, EventArgs e)
        {
            dataKH.DataSource = KhachhangDAO.Instance.timKH(txtSearchKH.Text);
        }

        private void btnUPKH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDkh.Text) || string.IsNullOrEmpty(cbbQuoctichup.Text) || string.IsNullOrEmpty(txtHoup.Text) || string.IsNullOrEmpty(txtSDTup.Text) || string.IsNullOrEmpty(txtDiachiup.Text) || string.IsNullOrEmpty(txtTenup.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (KhachhangDAO.Instance.SuaKH(Convert.ToInt32(txtIDkh.Text), txtHoup.Text, txtTenup.Text, txtSDTup.Text, cbbQuoctichup.Text, txtDiachiup.Text, txtCCCD.Text, Convert.ToInt32(txtLoaikh.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDkh.Text))
            {
                MessageBox.Show("Vui lòng nhập ID Khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (KhachhangDAO.Instance.XoaKH(Convert.ToInt32(txtIDkh.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadKH();

                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dataKH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtIDkh.Text = dataKH.SelectedRows[0].Cells[0].Value.ToString();
            txtHoup.Text = dataKH.SelectedRows[0].Cells[1].Value.ToString();
            txtTenup.Text = dataKH.SelectedRows[0].Cells[2].Value.ToString();
            txtSDTup.Text = dataKH.SelectedRows[0].Cells[3].Value.ToString();
            cbbQuoctichup.Text = dataKH.SelectedRows[0].Cells[4].Value.ToString();
            txtDiachiup.Text = dataKH.SelectedRows[0].Cells[5].Value.ToString();
            txtCCCD.Text = dataKH.SelectedRows[0].Cells[6].Value.ToString();
            txtLoaikh.Text = dataKH.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
