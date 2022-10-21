using DevExpress.XtraEditors;
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
    public partial class UserControlTB : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlTB()
        {
            InitializeComponent();
        }
        public void loadtb()
        {
            dataTB.DataSource = ThietbiDAO.Instance.GetTableTB();
        }
        public void loadtbp()
        {

            string[] tenphong = cbbtenPhong.Text.Split('-');
            dataTBP.DataSource = ThietbiphongDAO.Instance.GetTableTBP(tenphong[0]);
        }
        void loadDSphong()
        {
            List<Phong> loadtenphong = PhongDAO.Instance.GetAllListPhong();
            cbbtenPhong.DataSource = loadtenphong;
            cbbtenPhong.DisplayMember = "TENPHONG";
        }
        void loadDSTB()
        {
            List<Thietbi> loadtenTB = ThietbiphongDAO.Instance.GetListTB();
            cbbtebtb.DataSource = loadtenTB;
            cbbtebtb.DisplayMember = "TENTB";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenTB.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ThietbiDAO.Instance.ThemTB(txtTenTB.Text, (float)Convert.ToDouble(txtGia.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    loadtb();
                    loadDSTB();
                    UserControlDSPhong.instance.LoadPhong();
                    UserControlBDK.instance.soTb();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDTB.Text) || txtTenTB.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui Chọn ID Để Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ThietbiDAO.Instance.SuaTB(Convert.ToInt32(txtIDTB.Text), txtTenTB.Text, (float)Convert.ToDouble(txtGia.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    loadtb();
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
            if (string.IsNullOrEmpty(txtIDTB.Text))
            {
                MessageBox.Show("Vui Chọn ID Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ThietbiDAO.Instance.XoaTB(Convert.ToInt32(txtIDTB.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    loadtb();
                    loadDSTB();
                    UserControlDSPhong.instance.LoadPhong();
                    UserControlBDK.instance.soTb();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void UserControlTB_Load(object sender, EventArgs e)
        {
            loadDSphong();
            loadDSTB();
            loadtbp();
            loadtb();
        }

        private void btnAddTBP_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "" )
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] tenphong = cbbtenPhong.Text.Split('-');
                int idphong = PhongDAO.Instance.GetPhongByTenphong(tenphong[0]).Idphong;
                int idtb = ThietbiDAO.Instance.LayIDTBbyTenTB(cbbtebtb.Text).Idtb;
                if (ThietbiphongDAO.Instance.ThemTBPHONG(idphong,idtb ,Convert.ToInt32(txtSL.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    loadtbp();
                    UserControlDSPhong.instance.LoadPhong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnUpTBP_Click(object sender, EventArgs e)
        {
            if (txtIDtbp.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn ID ĐỂ Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] tenphong = cbbtenPhong.Text.Split('-');
                int idphong = PhongDAO.Instance.GetPhongByTenphong(tenphong[0]).Idphong;
                int idtb = ThietbiDAO.Instance.LayIDTBbyTenTB(cbbtebtb.Text).Idtb;
                if (ThietbiphongDAO.Instance.SuaTBPHONG(Convert.ToInt32(txtIDtbp.Text),idphong, idtb, Convert.ToInt32(txtSL.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    loadtbp();
                    UserControlDSPhong.instance.LoadPhong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnDelTBP_Click(object sender, EventArgs e)
        {
            if (txtIDtbp.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn ID ĐỂ Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] tenphong = cbbtenPhong.Text.Split('-');
                int idphong = PhongDAO.Instance.GetPhongByTenphong(tenphong[0]).Idphong;            
                int idtb = ThietbiDAO.Instance.LayIDTBbyTenTB(cbbtebtb.Text).Idtb;
                if (ThietbiphongDAO.Instance.XoaTBPHONG(Convert.ToInt32(txtIDtbp.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    loadtbp();
                    UserControlDSPhong.instance.LoadPhong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dataTBP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDtbp.Text = dataTB.SelectedRows[0].Cells[0].Value.ToString();
            cbbtenPhong.Text = dataTB.SelectedRows[0].Cells[1].Value.ToString();
            cbbtebtb.Text = dataTB.SelectedRows[0].Cells[2].Value.ToString();
            txtSL.Text = dataTB.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void cbbtenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tenphong = cbbtenPhong.Text.Split('-');
            dataTBP.DataSource = ThietbiphongDAO.Instance.GetTableTBP(tenphong[0]);
        }

        private void dataTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTB.Text = dataTB.SelectedRows[0].Cells[0].Value.ToString();
            txtTenTB.Text = dataTB.SelectedRows[0].Cells[1].Value.ToString();
            txtGia.Text = dataTB.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
