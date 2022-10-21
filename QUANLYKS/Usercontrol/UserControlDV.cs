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
    public partial class UserControlDV : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlDV()
        {
            InitializeComponent();
            loadDV();
        }

        void loadDV()
        {
            dataDV.DataSource = DichVuDAO.Instance.GetTableDV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtTenDV.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DichVuDAO.Instance.ThemDV( txtTenDV.Text, (float)Convert.ToDouble(txtGia.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDV();
                    UserControlDSPhong.instance.LoadPhong();
                    UserControlBDK.instance.soDV();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDDV.Text)|| txtTenDV.Text =="" || txtGia.Text=="")
            {
                MessageBox.Show("Vui Chọn ID Để Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DichVuDAO.Instance.SuaDV(Convert.ToInt32(txtIDDV.Text),txtTenDV.Text,(float)Convert.ToDouble( txtGia.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    loadDV();
                    UserControlDSPhong.instance.LoadPhong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDDV.Text))
            {
                MessageBox.Show("Vui Chọn ID Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DichVuDAO.Instance.XoaDVCHECK(Convert.ToInt32(txtIDDV.Text)))
                {
                    MessageBox.Show("Dịch Vụ Đang Được Sử Dụng Không Thể Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (DichVuDAO.Instance.XoaDV(Convert.ToInt32(txtIDDV.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadDV();
                        UserControlBDK.instance.soDV();
                        UserControlDSPhong.instance.LoadPhong();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
        }

        private void dataDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDV.Text = dataDV.SelectedRows[0].Cells[0].Value.ToString();
            txtTenDV.Text = dataDV.SelectedRows[0].Cells[1].Value.ToString();
            txtGia.Text = dataDV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txtSearchDV_TextChanged(object sender, EventArgs e)
        {
            dataDV.DataSource = DichVuDAO.Instance.TimDichVutheoten(txtSearchDV.Text);
        }
    }
}
