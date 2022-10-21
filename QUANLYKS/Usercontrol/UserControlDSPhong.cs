using QUANLYKS.DAO;
using QUANLYKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKS.Usercontrol
{
    public partial class UserControlDSPhong : UserControl
    {
        public static UserControlDSPhong instance;
        public UserControlDSPhong()
        {
            instance = this;
            InitializeComponent();
            LoadPhong();
        }
        public void LoadPhong()
        {
            flpPhong.Controls.Clear();
           List<Phong> phonglist = PhongDAO.Instance.LoadPhong();
            foreach (Phong item in phonglist)
            {
                Button btn = new Button() { Width = 180, Height = 160 };
                btn.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                string tenloaiphong;
                switch (item.Idloaiphong)
                {
                    case 1:
                        {
                            tenloaiphong = "Single";
                            break;
                        }
                    case 2:
                        {
                            tenloaiphong = "Double";
                            break;
                        }
                    case 3:
                        {
                            tenloaiphong = "Family";
                            break;
                        }
                    default:
                        {
                            tenloaiphong = "Suite";
                            break;
                        }
                }
                btn.Text = item.Tenphong +" - "+tenloaiphong + Environment.NewLine + item.Roomstatus;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Roomstatus)
                {
                    case "Trống":
                        {
                            btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                            btn.ImageIndex = 1;
                            btn.ImageList = this.trong;
                            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                            btn.UseVisualStyleBackColor = false;
                            break;
                        }
                    default:
                        {
                            btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                            btn.ImageIndex = 0;
                            btn.ImageList = this.trong;
                            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                            btn.UseVisualStyleBackColor = false;
                            break;
                        }
                }
                flpPhong.Controls.Add(btn);
            }
        }
        void showttphong(int idphong, int idloaiphong)
        {
            frmThongtinPhong phong = new frmThongtinPhong();
            phong.getIDPHONG = idphong;
            phong.idloaiphong = idloaiphong;
            phong.Show();
        }
        void showBangDatphong(int IDphong)
        {
            frmNhanPhong f = new frmNhanPhong();
            f.idphong = IDphong;
            f.Show();
        }
        public void Btn_Click(object sender,EventArgs e)
        {
            string status = ((sender as Button).Tag as Phong).Roomstatus;
            int IDphong = ((sender as Button).Tag as Phong).Idphong;
            int idloaiphong = ((sender as Button).Tag as Phong).Idloaiphong;
            if (status == "Bận")
            {
                showttphong(IDphong,idloaiphong);
            }
            else
            {
                showBangDatphong(IDphong);
            }
        }
    }
}
