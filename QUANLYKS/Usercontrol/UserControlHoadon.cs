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
    public partial class UserControlHoadon : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlHoadon()
        {
            InitializeComponent();

   
        }

        private void UserControlHoadon_Load(object sender, EventArgs e)
        {
            dataHD.DataSource = HoaDonDAO.Instance.LoadHoaDon();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataHD.DataSource = HoaDonDAO.Instance.SearchHD(txtSearch.Text);
        }

        private void dataHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmThongtinHD frm = new frmThongtinHD();
            frm.IDHD = Convert.ToInt32(dataHD.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}