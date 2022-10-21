using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYKS
{
    public partial class rpTheophong : DevExpress.XtraReports.UI.XtraReport
    {
        public static rpTheophong instance;
        public rpTheophong()
        {
            InitializeComponent();
            instance = this;
        }
        public void setText(string tongtienP)
        {
            lbltongtienPhong.Text = tongtienP;
        }
    }
}
