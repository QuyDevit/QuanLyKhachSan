
namespace QUANLYKS.Usercontrol
{
    partial class UserControlDatphong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabNV = new System.Windows.Forms.TabControl();
            this.tabSearchDP = new System.Windows.Forms.TabPage();
            this.dataDP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchDP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabNV.SuspendLayout();
            this.tabSearchDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNV
            // 
            this.tabNV.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabNV.Controls.Add(this.tabSearchDP);
            this.tabNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabNV.Location = new System.Drawing.Point(63, 54);
            this.tabNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV.Name = "tabNV";
            this.tabNV.SelectedIndex = 0;
            this.tabNV.Size = new System.Drawing.Size(1489, 655);
            this.tabNV.TabIndex = 3;
            // 
            // tabSearchDP
            // 
            this.tabSearchDP.BackColor = System.Drawing.Color.White;
            this.tabSearchDP.Controls.Add(this.dataDP);
            this.tabSearchDP.Controls.Add(this.label16);
            this.tabSearchDP.Controls.Add(this.txtSearchDP);
            this.tabSearchDP.Controls.Add(this.label15);
            this.tabSearchDP.Location = new System.Drawing.Point(4, 4);
            this.tabSearchDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchDP.Name = "tabSearchDP";
            this.tabSearchDP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchDP.Size = new System.Drawing.Size(1481, 625);
            this.tabSearchDP.TabIndex = 1;
            this.tabSearchDP.Text = "Chi Tiết";
            // 
            // dataDP
            // 
            this.dataDP.AllowUserToAddRows = false;
            this.dataDP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataDP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDP.BackgroundColor = System.Drawing.Color.White;
            this.dataDP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataDP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDP.ColumnHeadersHeight = 22;
            this.dataDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDP.EnableHeadersVisualStyles = false;
            this.dataDP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDP.Location = new System.Drawing.Point(159, 124);
            this.dataDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDP.Name = "dataDP";
            this.dataDP.ReadOnly = true;
            this.dataDP.RowHeadersVisible = false;
            this.dataDP.RowHeadersWidth = 51;
            this.dataDP.RowTemplate.Height = 24;
            this.dataDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDP.Size = new System.Drawing.Size(1184, 339);
            this.dataDP.TabIndex = 32;
            this.dataDP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataDP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDP.ThemeStyle.HeaderStyle.Height = 22;
            this.dataDP.ThemeStyle.ReadOnly = true;
            this.dataDP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataDP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDP.ThemeStyle.RowsStyle.Height = 24;
            this.dataDP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDP_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ID";
            this.Column5.HeaderText = "ID Đặt phòng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TENPHONG";
            this.Column7.HeaderText = "ID Phòng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TENKH";
            this.Column6.HeaderText = "ID Khách hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NGAYDAT";
            this.Column8.HeaderText = "Ngày Đặt";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NGAYTRA";
            this.Column1.HeaderText = "Ngày Trả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "STATUS";
            this.Column2.HeaderText = "Trạng thái phòng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label16.Location = new System.Drawing.Point(360, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Tìm kiếm:";
            // 
            // txtSearchDP
            // 
            this.txtSearchDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchDP.Location = new System.Drawing.Point(477, 68);
            this.txtSearchDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchDP.Name = "txtSearchDP";
            this.txtSearchDP.Size = new System.Drawing.Size(258, 26);
            this.txtSearchDP.TabIndex = 30;
            this.txtSearchDP.TextChanged += new System.EventHandler(this.txtSearchDP_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label15.Location = new System.Drawing.Point(20, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Chi tiết Đặt phòng";
            // 
            // UserControlDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDatphong";
            this.Size = new System.Drawing.Size(1573, 730);
            this.Load += new System.EventHandler(this.UserControlDatphong_Load);
            this.tabNV.ResumeLayout(false);
            this.tabSearchDP.ResumeLayout(false);
            this.tabSearchDP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNV;
        private System.Windows.Forms.TabPage tabSearchDP;
        private Guna.UI2.WinForms.Guna2DataGridView dataDP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchDP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
