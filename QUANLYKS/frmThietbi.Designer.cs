
namespace QUANLYKS
{
    partial class frmThietbi
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
            this.label10 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.userControlTB1 = new QUANLYKS.Usercontrol.UserControlTB();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(478, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Quản lý thiết bị";
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbClose.Image = global::QUANLYKS.Properties.Resources.close12;
            this.pbClose.Location = new System.Drawing.Point(1207, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(37, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 9;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // userControlTB1
            // 
            this.userControlTB1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.userControlTB1.Appearance.Options.UseBackColor = true;
            this.userControlTB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTB1.Location = new System.Drawing.Point(0, 0);
            this.userControlTB1.Name = "userControlTB1";
            this.userControlTB1.Size = new System.Drawing.Size(1244, 614);
            this.userControlTB1.TabIndex = 0;
            // 
            // frmThietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 614);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userControlTB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::QUANLYKS.Properties.Resources.hotel_building_stars_holiday_vacation_icon_196768;
            this.Name = "frmThietbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThietbi";
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Usercontrol.UserControlTB userControlTB1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbClose;
    }
}