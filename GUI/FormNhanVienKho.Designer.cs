namespace DACN.GUI
{
    partial class FormNhanVienKho
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_QLTraHang = new System.Windows.Forms.Button();
            this.btn_QLGiaNhap = new System.Windows.Forms.Button();
            this.btn_QLNhaCungUng = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_LapPhieuNH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_caidat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_tttk = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_ThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel_body.Location = new System.Drawing.Point(0, 34);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1364, 829);
            this.panel_body.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_QLTraHang);
            this.panel1.Controls.Add(this.btn_QLGiaNhap);
            this.panel1.Controls.Add(this.btn_QLNhaCungUng);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_LapPhieuNH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 829);
            this.panel1.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(46, 190);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(247, 36);
            this.lbUserName.TabIndex = 9;
            this.lbUserName.Text = "Nhân viên kho";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DACN.Properties.Resources.Image_NV;
            this.pictureBox1.Location = new System.Drawing.Point(85, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_QLTraHang
            // 
            this.btn_QLTraHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_QLTraHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLTraHang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTraHang.ForeColor = System.Drawing.Color.Snow;
            this.btn_QLTraHang.Location = new System.Drawing.Point(-56, 534);
            this.btn_QLTraHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QLTraHang.Name = "btn_QLTraHang";
            this.btn_QLTraHang.Size = new System.Drawing.Size(465, 69);
            this.btn_QLTraHang.TabIndex = 7;
            this.btn_QLTraHang.Text = "QUẢN LÝ TRẢ HÀNG";
            this.btn_QLTraHang.UseVisualStyleBackColor = false;
            this.btn_QLTraHang.Click += new System.EventHandler(this.btn_QLTraHang_Click);
            // 
            // btn_QLGiaNhap
            // 
            this.btn_QLGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_QLGiaNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLGiaNhap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLGiaNhap.ForeColor = System.Drawing.Color.Snow;
            this.btn_QLGiaNhap.Location = new System.Drawing.Point(-68, 470);
            this.btn_QLGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QLGiaNhap.Name = "btn_QLGiaNhap";
            this.btn_QLGiaNhap.Size = new System.Drawing.Size(465, 69);
            this.btn_QLGiaNhap.TabIndex = 6;
            this.btn_QLGiaNhap.Text = "QUẢN LÝ GIÁ NHẬP";
            this.btn_QLGiaNhap.UseVisualStyleBackColor = false;
            this.btn_QLGiaNhap.Click += new System.EventHandler(this.btn_QLGiaNhap_Click_1);
            // 
            // btn_QLNhaCungUng
            // 
            this.btn_QLNhaCungUng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_QLNhaCungUng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLNhaCungUng.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNhaCungUng.ForeColor = System.Drawing.Color.Snow;
            this.btn_QLNhaCungUng.Location = new System.Drawing.Point(-3, 380);
            this.btn_QLNhaCungUng.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QLNhaCungUng.Name = "btn_QLNhaCungUng";
            this.btn_QLNhaCungUng.Size = new System.Drawing.Size(356, 91);
            this.btn_QLNhaCungUng.TabIndex = 5;
            this.btn_QLNhaCungUng.Text = "QUẢN LÝ CUNG ỨNG";
            this.btn_QLNhaCungUng.UseVisualStyleBackColor = false;
            this.btn_QLNhaCungUng.Click += new System.EventHandler(this.btn_QLGiaNhap_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Logout.Image = global::DACN.Properties.Resources.icon_logout2;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(98, 626);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(143, 57);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_LapPhieuNH
            // 
            this.btn_LapPhieuNH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LapPhieuNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapPhieuNH.ForeColor = System.Drawing.Color.Snow;
            this.btn_LapPhieuNH.Location = new System.Drawing.Point(-3, 305);
            this.btn_LapPhieuNH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LapPhieuNH.Name = "btn_LapPhieuNH";
            this.btn_LapPhieuNH.Size = new System.Drawing.Size(356, 80);
            this.btn_LapPhieuNH.TabIndex = 1;
            this.btn_LapPhieuNH.Text = "QUẢN LÝ NHẬP HÀNG";
            this.btn_LapPhieuNH.UseVisualStyleBackColor = false;
            this.btn_LapPhieuNH.Click += new System.EventHandler(this.btn_LapPhieuNH_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_body);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 863);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_caidat,
            this.mn_tttk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1364, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_caidat
            // 
            this.mn_caidat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mn_caidat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mn_caidat.Name = "mn_caidat";
            this.mn_caidat.Size = new System.Drawing.Size(87, 32);
            this.mn_caidat.Text = "Cài đặt";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 32);
            this.toolStripMenuItem3.Text = "Đổi màu nền";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 32);
            this.toolStripMenuItem4.Text = "Đổi màu chữ";
            // 
            // mn_tttk
            // 
            this.mn_tttk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItem_ThongTinTK,
            this.toolStripMenuItem_DoiMK});
            this.mn_tttk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mn_tttk.Name = "mn_tttk";
            this.mn_tttk.Size = new System.Drawing.Size(265, 32);
            this.mn_tttk.Text = "Quản lý thông tin tài khoản";
            // 
            // tStripMenuItem_ThongTinTK
            // 
            this.tStripMenuItem_ThongTinTK.Name = "tStripMenuItem_ThongTinTK";
            this.tStripMenuItem_ThongTinTK.Size = new System.Drawing.Size(268, 32);
            this.tStripMenuItem_ThongTinTK.Text = "Thông tin tài khoản";
            this.tStripMenuItem_ThongTinTK.Click += new System.EventHandler(this.tStripMenuItem_ThongTinTK_Click);
            // 
            // toolStripMenuItem_DoiMK
            // 
            this.toolStripMenuItem_DoiMK.Name = "toolStripMenuItem_DoiMK";
            this.toolStripMenuItem_DoiMK.Size = new System.Drawing.Size(268, 32);
            this.toolStripMenuItem_DoiMK.Text = "Đổi mật khẩu";
            this.toolStripMenuItem_DoiMK.Click += new System.EventHandler(this.toolStripMenuItem_DoiMK_Click);
            // 
            // FormNhanVienKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 863);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNhanVienKho";
            this.Text = "NHÂN VIÊN KHO";
            this.panel_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_LapPhieuNH;
        private System.Windows.Forms.Button btn_QLTonKho;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_tttk;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_ThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DoiMK;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_QLNhaCungUng;
        private System.Windows.Forms.Button btn_QLGiaNhap;
        private System.Windows.Forms.Button btn_QLTraHang;
        private System.Windows.Forms.ToolStripMenuItem mn_caidat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}