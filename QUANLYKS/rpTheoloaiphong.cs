using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYKS
{
    public partial class rpTheoloaiphong : DevExpress.XtraReports.UI.XtraReport
    {
        public static rpTheoloaiphong instance;
        public rpTheoloaiphong()
        {
            InitializeComponent();
            instance = this;
        }
        public void setText(string tongtienLP)
        {
            lbltongtienLP.Text = tongtienLP;
        }
    }
}
