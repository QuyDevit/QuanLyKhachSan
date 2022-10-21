using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYKS
{
    public partial class rptTheoDV : DevExpress.XtraReports.UI.XtraReport
    {
        public static rptTheoDV instance;

        public rptTheoDV()
        {
            InitializeComponent();
            instance = this;
        }
        public void setText(string tongtienDV)
        {
            lbltongtienDV.Text = tongtienDV;
        }
    }
}
