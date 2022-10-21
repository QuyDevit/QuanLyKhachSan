
namespace QUANLYKS.Usercontrol
{
    partial class UserControlPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabSearchUser = new System.Windows.Forms.TabPage();
            this.txtIDloaiphongup = new System.Windows.Forms.TextBox();
            this.cbbTrangthaiup = new System.Windows.Forms.ComboBox();
            this.cbbLoaiRoomup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenphongup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDRoom = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabUser.SuspendLayout();
            this.tabSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabUser.Controls.Add(this.tabSearchUser);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabUser.Location = new System.Drawing.Point(42, 48);
            this.tabUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(1118, 567);
            this.tabUser.TabIndex = 1;
            // 
            // tabSearchUser
            // 
            this.tabSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.tabSearchUser.Controls.Add(this.txtIDloaiphongup);
            this.tabSearchUser.Controls.Add(this.cbbTrangthaiup);
            this.tabSearchUser.Controls.Add(this.cbbLoaiRoomup);
            this.tabSearchUser.Controls.Add(this.label4);
            this.tabSearchUser.Controls.Add(this.txtTenphongup);
            this.tabSearchUser.Controls.Add(this.label6);
            this.tabSearchUser.Controls.Add(this.label7);
            this.tabSearchUser.Controls.Add(this.txtIDRoom);
            this.tabSearchUser.Controls.Add(this.btnAdd);
            this.tabSearchUser.Controls.Add(this.btnDel);
            this.tabSearchUser.Controls.Add(this.dataRoom);
            this.tabSearchUser.Controls.Add(this.label16);
            this.tabSearchUser.Controls.Add(this.txtSearchRoom);
            this.tabSearchUser.Controls.Add(this.label15);
            this.tabSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabSearchUser.Name = "tabSearchUser";
            this.tabSearchUser.Padding = new System.Windows.Forms.Padding(2);
            this.tabSearchUser.Size = new System.Drawing.Size(1110, 537);
            this.tabSearchUser.TabIndex = 1;
            // 
            // txtIDloaiphongup
            // 
            this.txtIDloaiphongup.Enabled = false;
            this.txtIDloaiphongup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDloaiphongup.Location = new System.Drawing.Point(134, 69);
            this.txtIDloaiphongup.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDloaiphongup.Name = "txtIDloaiphongup";
            this.txtIDloaiphongup.Size = new System.Drawing.Size(219, 27);
            this.txtIDloaiphongup.TabIndex = 63;
            this.txtIDloaiphongup.Visible = false;
            // 
            // cbbTrangthaiup
            // 
            this.cbbTrangthaiup.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTrangthaiup.FormattingEnabled = true;
            this.cbbTrangthaiup.Items.AddRange(new object[] {
            "Trống",
            "Bận"});
            this.cbbTrangthaiup.Location = new System.Drawing.Point(157, 298);
            this.cbbTrangthaiup.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangthaiup.Name = "cbbTrangthaiup";
            this.cbbTrangthaiup.Size = new System.Drawing.Size(219, 25);
            this.cbbTrangthaiup.TabIndex = 61;
            // 
            // cbbLoaiRoomup
            // 
            this.cbbLoaiRoomup.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLoaiRoomup.FormattingEnabled = true;
            this.cbbLoaiRoomup.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cbbLoaiRoomup.Location = new System.Drawing.Point(157, 194);
            this.cbbLoaiRoomup.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiRoomup.Name = "cbbLoaiRoomup";
            this.cbbLoaiRoomup.Size = new System.Drawing.Size(219, 25);
            this.cbbLoaiRoomup.TabIndex = 60;
            this.cbbLoaiRoomup.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiRoomup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(41, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Trạng thái:";
            // 
            // txtTenphongup
            // 
            this.txtTenphongup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenphongup.Location = new System.Drawing.Point(157, 247);
            this.txtTenphongup.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenphongup.Name = "txtTenphongup";
            this.txtTenphongup.Size = new System.Drawing.Size(219, 27);
            this.txtTenphongup.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(41, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tên phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(41, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Loại phòng:";
            // 
            // txtIDRoom
            // 
            this.txtIDRoom.Enabled = false;
            this.txtIDRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDRoom.Location = new System.Drawing.Point(134, 39);
            this.txtIDRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDRoom.Name = "txtIDRoom";
            this.txtIDRoom.Size = new System.Drawing.Size(219, 26);
            this.txtIDRoom.TabIndex = 55;
            this.txtIDRoom.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(157, 366);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 50);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(284, 366);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 50);
            this.btnDel.TabIndex = 40;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataRoom
            // 
            this.dataRoom.AllowUserToAddRows = false;
            this.dataRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataRoom.ColumnHeadersHeight = 22;
            this.dataRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataRoom.EnableHeadersVisualStyles = false;
            this.dataRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoom.Location = new System.Drawing.Point(460, 126);
            this.dataRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dataRoom.Name = "dataRoom";
            this.dataRoom.ReadOnly = true;
            this.dataRoom.RowHeadersVisible = false;
            this.dataRoom.RowHeadersWidth = 51;
            this.dataRoom.RowTemplate.Height = 24;
            this.dataRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRoom.Size = new System.Drawing.Size(598, 339);
            this.dataRoom.TabIndex = 32;
            this.dataRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataRoom.ThemeStyle.HeaderStyle.Height = 22;
            this.dataRoom.ThemeStyle.ReadOnly = true;
            this.dataRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dataRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRoom_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Idphong";
            this.Column5.HeaderText = "ID Phòng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Idloaiphong";
            this.Column6.HeaderText = "ID Loại Phòng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tenphong";
            this.Column7.HeaderText = "Tên Phòng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Roomstatus";
            this.Column8.HeaderText = "Trạng thái";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label16.Location = new System.Drawing.Point(494, 51);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Tìm kiếm:";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchRoom.Location = new System.Drawing.Point(635, 51);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(226, 26);
            this.txtSearchRoom.TabIndex = 30;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label15.Location = new System.Drawing.Point(17, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Chi tiết Phòng:";
            // 
            // UserControlPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.tabUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlPhong";
            this.Size = new System.Drawing.Size(1216, 633);
            this.Load += new System.EventHandler(this.UserControlPhong_Load);
            this.tabUser.ResumeLayout(false);
            this.tabSearchUser.ResumeLayout(false);
            this.tabSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tabSearchUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView dataRoom;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIDloaiphongup;
        private System.Windows.Forms.ComboBox cbbTrangthaiup;
        private System.Windows.Forms.ComboBox cbbLoaiRoomup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenphongup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDRoom;
    }
}
