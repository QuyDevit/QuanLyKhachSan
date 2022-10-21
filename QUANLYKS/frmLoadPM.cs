using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKS
{
    public partial class frmLoadPM : DevExpress.XtraEditors.XtraForm
    {
        public frmLoadPM()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void Loadtime_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            Splah.Value = startpoint;
            if (startpoint == 100)
            {
                Splah.Value = 0;
                Loadtime.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void frmLoadPM_Load(object sender, EventArgs e)
        {
            this.Loadtime.Start();
        }
    }
}