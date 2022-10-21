
namespace QUANLYKS.Usercontrol
{
    partial class UserControlDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabSearchUser = new System.Windows.Forms.TabPage();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDDV = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchDV = new System.Windows.Forms.TextBox();
            this.tabUser.SuspendLayout();
            this.tabSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabUser.Controls.Add(this.tabSearchUser);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabUser.Location = new System.Drawing.Point(56, 45);
            this.tabUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(1104, 543);
            this.tabUser.TabIndex = 2;
            // 
            // tabSearchUser
            // 
            this.tabSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tabSearchUser.Controls.Add(this.txtTenDV);
            this.tabSearchUser.Controls.Add(this.btnUpdate);
            this.tabSearchUser.Controls.Add(this.txtGia);
            this.tabSearchUser.Controls.Add(this.label6);
            this.tabSearchUser.Controls.Add(this.label7);
            this.tabSearchUser.Controls.Add(this.txtIDDV);
            this.tabSearchUser.Controls.Add(this.btnAdd);
            this.tabSearchUser.Controls.Add(this.btnDel);
            this.tabSearchUser.Controls.Add(this.dataDV);
            this.tabSearchUser.Controls.Add(this.label16);
            this.tabSearchUser.Controls.Add(this.txtSearchDV);
            this.tabSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabSearchUser.Name = "tabSearchUser";
            this.tabSearchUser.Padding = new System.Windows.Forms.Padding(2);
            this.tabSearchUser.Size = new System.Drawing.Size(1096, 513);
            this.tabSearchUser.TabIndex = 1;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDV.Location = new System.Drawing.Point(157, 199);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(219, 26);
            this.txtTenDV.TabIndex = 65;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(174, 366);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 50);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(157, 247);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(219, 27);
            this.txtGia.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(56, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Đơn Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(28, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tên Dịch Vụ:";
            // 
            // txtIDDV
            // 
            this.txtIDDV.Enabled = false;
            this.txtIDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDDV.Location = new System.Drawing.Point(157, 67);
            this.txtIDDV.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDV.Name = "txtIDDV";
            this.txtIDDV.Size = new System.Drawing.Size(219, 26);
            this.txtIDDV.TabIndex = 55;
            this.txtIDDV.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(60, 366);
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
            // dataDV
            // 
            this.dataDV.AllowUserToAddRows = false;
            this.dataDV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDV.BackgroundColor = System.Drawing.Color.White;
            this.dataDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataDV.ColumnHeadersHeight = 22;
            this.dataDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDV.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataDV.EnableHeadersVisualStyles = false;
            this.dataDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDV.Location = new System.Drawing.Point(460, 126);
            this.dataDV.Margin = new System.Windows.Forms.Padding(2);
            this.dataDV.Name = "dataDV";
            this.dataDV.ReadOnly = true;
            this.dataDV.RowHeadersVisible = false;
            this.dataDV.RowHeadersWidth = 51;
            this.dataDV.RowTemplate.Height = 24;
            this.dataDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDV.Size = new System.Drawing.Size(598, 339);
            this.dataDV.TabIndex = 32;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDV.ThemeStyle.HeaderStyle.Height = 22;
            this.dataDV.ThemeStyle.ReadOnly = true;
            this.dataDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDV.ThemeStyle.RowsStyle.Height = 24;
            this.dataDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDV_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IDDV";
            this.Column5.HeaderText = "ID DV";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TENDV";
            this.Column6.HeaderText = "Tên DV";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DONGIA";
            this.Column7.HeaderText = "Giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            // txtSearchDV
            // 
            this.txtSearchDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchDV.Location = new System.Drawing.Point(635, 51);
            this.txtSearchDV.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchDV.Name = "txtSearchDV";
            this.txtSearchDV.Size = new System.Drawing.Size(226, 26);
            this.txtSearchDV.TabIndex = 30;
            this.txtSearchDV.TextChanged += new System.EventHandler(this.txtSearchDV_TextChanged);
            // 
            // UserControlDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabUser);
            this.Name = "UserControlDV";
            this.Size = new System.Drawing.Size(1216, 633);
            this.tabUser.ResumeLayout(false);
            this.tabSearchUser.ResumeLayout(false);
            this.tabSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tabSearchUser;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDDV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private Guna.UI2.WinForms.Guna2DataGridView dataDV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchDV;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
