using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYKS
{
    public partial class rpTheoloaikh : DevExpress.XtraReports.UI.XtraReport
    {
        public static rpTheoloaikh instance;
        public rpTheoloaikh()
        {
            InitializeComponent();
            instance = this;
        }
        public void setText(string tongtienkh)
        {
            lbltongtienkh.Text = tongtienkh;
        }
    }
}
