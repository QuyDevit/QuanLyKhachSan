
namespace QUANLYKS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDSphong = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.btnBDK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.userControlThongke1 = new QUANLYKS.Usercontrol.UserControlThongke();
            this.userControlBaocao1 = new QUANLYKS.Usercontrol.UserControlBaocao();
            this.userControlHoadon1 = new QUANLYKS.Usercontrol.UserControlHoadon();
            this.userControlDatphong1 = new QUANLYKS.Usercontrol.UserControlDatphong();
            this.userControlNhanvien1 = new QUANLYKS.Usercontrol.UserControlNhanvien();
            this.userControlKhachHang1 = new QUANLYKS.Usercontrol.UserControlKhachHang();
            this.userControlPhong1 = new QUANLYKS.Usercontrol.UserControlPhong();
            this.userControlCaidat1 = new QUANLYKS.Usercontrol.UserControlCaidat();
            this.userControlBDK1 = new QUANLYKS.Usercontrol.UserControlBDK();
            this.userDSphong1 = new QUANLYKS.Usercontrol.UserControlDSPhong();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.btnDSphong);
            this.panel1.Controls.Add(this.btnChart);
            this.panel1.Controls.Add(this.btnKH);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnDatPhong);
            this.panel1.Controls.Add(this.btnHoadon);
            this.panel1.Controls.Add(this.btnCaiDat);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Controls.Add(this.pnlSlide);
            this.panel1.Controls.Add(this.btnBDK);
            this.panel1.Controls.Add(this.panel4);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 1068);
            this.panel1.TabIndex = 0;
            // 
            // btnDSphong
            // 
            this.btnDSphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnDSphong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDSphong.FlatAppearance.BorderSize = 0;
            this.btnDSphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSphong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSphong.ForeColor = System.Drawing.Color.White;
            this.btnDSphong.Image = global::QUANLYKS.Properties.Resources.living_room_icon_18_ffffff_24;
            this.btnDSphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSphong.Location = new System.Drawing.Point(47, 338);
            this.btnDSphong.Name = "btnDSphong";
            this.btnDSphong.Size = new System.Drawing.Size(256, 54);
            this.btnDSphong.TabIndex = 15;
            this.btnDSphong.Text = "        Danh Sách Phòng";
            this.btnDSphong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSphong.UseVisualStyleBackColor = true;
            this.btnDSphong.Click += new System.EventHandler(this.btnDSphong_Click);
            // 
            // btnChart
            // 
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnChart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.Image = global::QUANLYKS.Properties.Resources.line_chart_24;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.Location = new System.Drawing.Point(49, 698);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(256, 54);
            this.btnChart.TabIndex = 19;
            this.btnChart.Text = "        Thống Kê";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnKH
            // 
            this.btnKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnKH, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKH.FlatAppearance.BorderSize = 0;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.Image = global::QUANLYKS.Properties.Resources.user_24;
            this.btnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.Location = new System.Drawing.Point(47, 398);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(256, 54);
            this.btnKH.TabIndex = 12;
            this.btnKH.Text = "        Khách Hàng";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnBaoCao, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = global::QUANLYKS.Properties.Resources.report_3_24;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(49, 638);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(256, 54);
            this.btnBaoCao.TabIndex = 18;
            this.btnBaoCao.Text = "        Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnDatPhong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Image = global::QUANLYKS.Properties.Resources.ticket_24;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(47, 458);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(256, 54);
            this.btnDatPhong.TabIndex = 13;
            this.btnDatPhong.Text = "        Đặt Phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnHoadon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoadon.ForeColor = System.Drawing.Color.White;
            this.btnHoadon.Image = global::QUANLYKS.Properties.Resources.invoice_24;
            this.btnHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.Location = new System.Drawing.Point(47, 518);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(256, 54);
            this.btnHoadon.TabIndex = 17;
            this.btnHoadon.Text = "        Hóa Đơn";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnCaiDat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::QUANLYKS.Properties.Resources.settings_24;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(49, 758);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(256, 54);
            this.btnCaiDat.TabIndex = 14;
            this.btnCaiDat.Text = "        Tài Khoản";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnNhanvien, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = global::QUANLYKS.Properties.Resources.manager_24;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(47, 578);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(256, 54);
            this.btnNhanvien.TabIndex = 16;
            this.btnNhanvien.Text = "        Nhân Viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.pnlSlide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSlide.Location = new System.Drawing.Point(29, 278);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(12, 54);
            this.pnlSlide.TabIndex = 6;
            // 
            // btnBDK
            // 
            this.btnBDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnBDK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBDK.FlatAppearance.BorderSize = 0;
            this.btnBDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBDK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBDK.ForeColor = System.Drawing.Color.White;
            this.btnBDK.Image = global::QUANLYKS.Properties.Resources.dashboard_2_24;
            this.btnBDK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBDK.Location = new System.Drawing.Point(47, 278);
            this.btnBDK.Name = "btnBDK";
            this.btnBDK.Size = new System.Drawing.Size(256, 54);
            this.btnBDK.TabIndex = 1;
            this.btnBDK.Text = "        Bảng Điều Khiển";
            this.btnBDK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBDK.UseVisualStyleBackColor = true;
            this.btnBDK.Click += new System.EventHandler(this.btnBDK_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.guna2Transition1.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 244);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Sạn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phần Mềm Quản Lý";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::QUANLYKS.Properties.Resources.PikPng_com_logo_instagram_blanco_png_4574987;
            this.pictureBox2.Location = new System.Drawing.Point(90, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(305, 1007);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1615, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bản quyền © 2022 mọi quyền được bảo lưu. Nhóm Design";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel3.Controls.Add(this.lblChao);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel5);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(305, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1615, 244);
            this.panel3.TabIndex = 0;
            // 
            // lblChao
            // 
            this.lblChao.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblChao, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblChao.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChao.ForeColor = System.Drawing.Color.White;
            this.lblChao.Location = new System.Drawing.Point(192, 167);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(118, 27);
            this.lblChao.TabIndex = 4;
            this.lblChao.Text = "Xin Chào:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xin Chào:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblDatetime);
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1615, 115);
            this.panel5.TabIndex = 0;
            // 
            // lblDatetime
            // 
            this.lblDatetime.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblDatetime, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDatetime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDatetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblDatetime.Location = new System.Drawing.Point(22, 82);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(18, 19);
            this.lblDatetime.TabIndex = 2;
            this.lblDatetime.Text = "?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.linkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.Location = new System.Drawing.Point(1490, 63);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Xuất";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::QUANLYKS.Properties.Resources.userlogin;
            this.pictureBox1.Location = new System.Drawing.Point(1420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userControlThongke1);
            this.panel6.Controls.Add(this.userControlBaocao1);
            this.panel6.Controls.Add(this.userControlHoadon1);
            this.panel6.Controls.Add(this.userControlDatphong1);
            this.panel6.Controls.Add(this.userControlNhanvien1);
            this.panel6.Controls.Add(this.userControlKhachHang1);
            this.panel6.Controls.Add(this.userControlPhong1);
            this.panel6.Controls.Add(this.userControlCaidat1);
            this.panel6.Controls.Add(this.userControlBDK1);
            this.panel6.Controls.Add(this.userDSphong1);
            this.guna2Transition1.SetDecoration(this.panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(305, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1615, 763);
            this.panel6.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // userControlThongke1
            // 
            this.guna2Transition1.SetDecoration(this.userControlThongke1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlThongke1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlThongke1.Location = new System.Drawing.Point(0, 0);
            this.userControlThongke1.Name = "userControlThongke1";
            this.userControlThongke1.Size = new System.Drawing.Size(1615, 763);
            this.userControlThongke1.TabIndex = 9;
            this.userControlThongke1.Visible = false;
            // 
            // userControlBaocao1
            // 
            this.guna2Transition1.SetDecoration(this.userControlBaocao1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlBaocao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBaocao1.Location = new System.Drawing.Point(0, 0);
            this.userControlBaocao1.Name = "userControlBaocao1";
            this.userControlBaocao1.Size = new System.Drawing.Size(1615, 763);
            this.userControlBaocao1.TabIndex = 8;
            this.userControlBaocao1.Visible = false;
            // 
            // userControlHoadon1
            // 
            this.guna2Transition1.SetDecoration(this.userControlHoadon1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlHoadon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHoadon1.Location = new System.Drawing.Point(0, 0);
            this.userControlHoadon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlHoadon1.Name = "userControlHoadon1";
            this.userControlHoadon1.Size = new System.Drawing.Size(1615, 763);
            this.userControlHoadon1.TabIndex = 7;
            this.userControlHoadon1.Visible = false;
            // 
            // userControlDatphong1
            // 
            this.guna2Transition1.SetDecoration(this.userControlDatphong1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlDatphong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDatphong1.Location = new System.Drawing.Point(0, 0);
            this.userControlDatphong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlDatphong1.Name = "userControlDatphong1";
            this.userControlDatphong1.Size = new System.Drawing.Size(1615, 763);
            this.userControlDatphong1.TabIndex = 6;
            this.userControlDatphong1.Visible = false;
            // 
            // userControlNhanvien1
            // 
            this.guna2Transition1.SetDecoration(this.userControlNhanvien1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlNhanvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlNhanvien1.Location = new System.Drawing.Point(0, 0);
            this.userControlNhanvien1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlNhanvien1.Name = "userControlNhanvien1";
            this.userControlNhanvien1.Size = new System.Drawing.Size(1615, 763);
            this.userControlNhanvien1.TabIndex = 5;
            this.userControlNhanvien1.Visible = false;
            // 
            // userControlKhachHang1
            // 
            this.guna2Transition1.SetDecoration(this.userControlKhachHang1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.userControlKhachHang1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlKhachHang1.Name = "userControlKhachHang1";
            this.userControlKhachHang1.Size = new System.Drawing.Size(1615, 763);
            this.userControlKhachHang1.TabIndex = 4;
            this.userControlKhachHang1.Visible = false;
            // 
            // userControlPhong1
            // 
            this.userControlPhong1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControlPhong1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPhong1.Location = new System.Drawing.Point(0, 0);
            this.userControlPhong1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlPhong1.Name = "userControlPhong1";
            this.userControlPhong1.Size = new System.Drawing.Size(1615, 763);
            this.userControlPhong1.TabIndex = 3;
            this.userControlPhong1.Visible = false;
            // 
            // userControlCaidat1
            // 
            this.userControlCaidat1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControlCaidat1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlCaidat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCaidat1.Location = new System.Drawing.Point(0, 0);
            this.userControlCaidat1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlCaidat1.Name = "userControlCaidat1";
            this.userControlCaidat1.Size = new System.Drawing.Size(1615, 763);
            this.userControlCaidat1.TabIndex = 2;
            this.userControlCaidat1.Visible = false;
            // 
            // userControlBDK1
            // 
            this.userControlBDK1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControlBDK1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControlBDK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBDK1.Location = new System.Drawing.Point(0, 0);
            this.userControlBDK1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlBDK1.Name = "userControlBDK1";
            this.userControlBDK1.Size = new System.Drawing.Size(1615, 763);
            this.userControlBDK1.TabIndex = 1;
            this.userControlBDK1.Visible = false;
            // 
            // userDSphong1
            // 
            this.userDSphong1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userDSphong1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userDSphong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDSphong1.Location = new System.Drawing.Point(0, 0);
            this.userDSphong1.Margin = new System.Windows.Forms.Padding(2);
            this.userDSphong1.Name = "userDSphong1";
            this.userDSphong1.Size = new System.Drawing.Size(1615, 763);
            this.userDSphong1.TabIndex = 0;
            this.userDSphong1.Visible = false;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1068);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::QUANLYKS.Properties.Resources.hotel_building_stars_holiday_vacation_icon_196768;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBDK;
        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Usercontrol.UserControlDSPhong userDSphong1;
        private Usercontrol.UserControlBDK userControlBDK1;
        private Usercontrol.UserControlCaidat userControlCaidat1;
        private Usercontrol.UserControlPhong userControlPhong1;
        private Usercontrol.UserControlKhachHang userControlKhachHang1;
        private Usercontrol.UserControlNhanvien userControlNhanvien1;
        private Usercontrol.UserControlDatphong userControlDatphong1;
        private Usercontrol.UserControlHoadon userControlHoadon1;
        private Usercontrol.UserControlBaocao userControlBaocao1;
        private Usercontrol.UserControlThongke userControlThongke1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnDSphong;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnNhanvien;
    }
}