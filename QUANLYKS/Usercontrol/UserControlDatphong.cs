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
    public partial class UserControlDatphong : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlDatphong()
        {
            InitializeComponent();
        }   

        void loaddatphong()
        {
            dataDP.DataSource = DatphongDAO.Instance.LoadPhong();
        }
        private void UserControlDatphong_Load(object sender, EventArgs e)
        {
            loaddatphong();
        }

        private void txtSearchDP_TextChanged(object sender, EventArgs e)
        {
            dataDP.DataSource = DatphongDAO.Instance.SearchDATPHONG(txtSearchDP.Text);
        }

        private void dataDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmthongtinDP frm = new frmthongtinDP();
            frm.IDDP = Convert.ToInt32( dataDP.SelectedRows[0].Cells[0].Value.ToString());
            frm.Status = dataDP.SelectedRows[0].Cells[5].Value.ToString();
            frm.Show();
        }
    }
}
