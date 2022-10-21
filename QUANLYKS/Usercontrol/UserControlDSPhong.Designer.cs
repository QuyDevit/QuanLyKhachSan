
namespace QUANLYKS.Usercontrol
{
    partial class UserControlDSPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDSPhong));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.cbbTenPhong = new System.Windows.Forms.ComboBox();
            this.cbbDV = new System.Windows.Forms.ComboBox();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.trong = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataDV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIDPhong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.btnThemDV);
            this.panel2.Controls.Add(this.cbbTenPhong);
            this.panel2.Controls.Add(this.cbbDV);
            this.panel2.Location = new System.Drawing.Point(1104, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 180);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // dataDV
            // 
            this.dataDV.AllowUserToAddRows = false;
            this.dataDV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDV.BackgroundColor = System.Drawing.Color.White;
            this.dataDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDV.ColumnHeadersHeight = 27;
            this.dataDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDV.EnableHeadersVisualStyles = false;
            this.dataDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.dataDV.Location = new System.Drawing.Point(16, 196);
            this.dataDV.Margin = new System.Windows.Forms.Padding(2);
            this.dataDV.Name = "dataDV";
            this.dataDV.ReadOnly = true;
            this.dataDV.RowHeadersVisible = false;
            this.dataDV.RowHeadersWidth = 51;
            this.dataDV.RowTemplate.Height = 24;
            this.dataDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDV.Size = new System.Drawing.Size(541, 359);
            this.dataDV.TabIndex = 12;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.dataDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDV.ThemeStyle.HeaderStyle.Height = 27;
            this.dataDV.ThemeStyle.ReadOnly = true;
            this.dataDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDV.ThemeStyle.RowsStyle.Height = 24;
            this.dataDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENPHONG";
            this.Column1.HeaderText = "Tên Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDV";
            this.Column2.HeaderText = "Tên Dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(43, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Phòng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Enabled = false;
            this.txtIDPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDPhong.Location = new System.Drawing.Point(136, 60);
            this.txtIDPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(290, 26);
            this.txtIDPhong.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(45, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(45, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại DV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Phòng";
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(136, 145);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(290, 26);
            this.txtGia.TabIndex = 5;
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(455, 64);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(79, 84);
            this.btnThemDV.TabIndex = 3;
            this.btnThemDV.Text = "Thêm Dịch Vụ";
            this.btnThemDV.UseVisualStyleBackColor = false;
            // 
            // cbbTenPhong
            // 
            this.cbbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenPhong.FormattingEnabled = true;
            this.cbbTenPhong.Location = new System.Drawing.Point(136, 21);
            this.cbbTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenPhong.Name = "cbbTenPhong";
            this.cbbTenPhong.Size = new System.Drawing.Size(290, 28);
            this.cbbTenPhong.TabIndex = 2;
            // 
            // cbbDV
            // 
            this.cbbDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbDV.FormattingEnabled = true;
            this.cbbDV.Items.AddRange(new object[] {
            "Dọn Phòng",
            "Giặt ủi",
            "Massage",
            "Personal Trainer Gym"});
            this.cbbDV.Location = new System.Drawing.Point(136, 103);
            this.cbbDV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDV.Name = "cbbDV";
            this.cbbDV.Size = new System.Drawing.Size(290, 28);
            this.cbbDV.TabIndex = 0;
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.Location = new System.Drawing.Point(124, 102);
            this.flpPhong.Margin = new System.Windows.Forms.Padding(2);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(1338, 670);
            this.flpPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(585, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh Sách Phòng";
            // 
            // trong
            // 
            this.trong.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trong.ImageStream")));
            this.trong.TransparentColor = System.Drawing.Color.Transparent;
            this.trong.Images.SetKeyName(0, "canhbao.png");
            this.trong.Images.SetKeyName(1, "roomfree.png");
            // 
            // UserControlDSPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpPhong);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDSPhong";
            this.Size = new System.Drawing.Size(1415, 782);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTenPhong;
        private System.Windows.Forms.ComboBox cbbDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPhong;
        private Guna.UI2.WinForms.Guna2DataGridView dataDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ImageList trong;
    }
}
