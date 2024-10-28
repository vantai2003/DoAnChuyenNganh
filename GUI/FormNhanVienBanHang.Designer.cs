namespace DACN.GUI
{
    partial class FormNhanVienBanHang
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
            this.panel_right = new System.Windows.Forms.Panel();
            this.pane_left = new System.Windows.Forms.Panel();
            this.btn_QLHangHoa = new Sunny.UI.UIButton();
            this.btn_LapPhieuBanHang = new Sunny.UI.UIButton();
            this.btn_HuyDonHang = new Sunny.UI.UIButton();
            this.btn_CapNhatDanhMuc = new Sunny.UI.UIButton();
            this.menu_NhanVienBanHang = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body.SuspendLayout();
            this.pane_left.SuspendLayout();
            this.menu_NhanVienBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Controls.Add(this.pane_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1149, 586);
            this.panel_body.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(348, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(801, 586);
            this.panel_right.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pane_left.Controls.Add(this.btn_QLHangHoa);
            this.pane_left.Controls.Add(this.btn_LapPhieuBanHang);
            this.pane_left.Controls.Add(this.btn_HuyDonHang);
            this.pane_left.Controls.Add(this.btn_CapNhatDanhMuc);
            this.pane_left.Controls.Add(this.menu_NhanVienBanHang);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(348, 586);
            this.pane_left.TabIndex = 0;
            // 
            // btn_QLHangHoa
            // 
            this.btn_QLHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLHangHoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QLHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHangHoa.Location = new System.Drawing.Point(-1, 128);
            this.btn_QLHangHoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QLHangHoa.Name = "btn_QLHangHoa";
            this.btn_QLHangHoa.Size = new System.Drawing.Size(348, 50);
            this.btn_QLHangHoa.TabIndex = 4;
            this.btn_QLHangHoa.Text = "Quản lý hàng hóa";
            this.btn_QLHangHoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLHangHoa.Click += new System.EventHandler(this.btn_QLHangHoa_Click);
            // 
            // btn_LapPhieuBanHang
            // 
            this.btn_LapPhieuBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuBanHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_LapPhieuBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LapPhieuBanHang.Location = new System.Drawing.Point(0, 294);
            this.btn_LapPhieuBanHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LapPhieuBanHang.Name = "btn_LapPhieuBanHang";
            this.btn_LapPhieuBanHang.Size = new System.Drawing.Size(348, 50);
            this.btn_LapPhieuBanHang.TabIndex = 3;
            this.btn_LapPhieuBanHang.Text = "Lập phiếu bán hàng";
            this.btn_LapPhieuBanHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btn_HuyDonHang
            // 
            this.btn_HuyDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_HuyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_HuyDonHang.Location = new System.Drawing.Point(0, 240);
            this.btn_HuyDonHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_HuyDonHang.Name = "btn_HuyDonHang";
            this.btn_HuyDonHang.Size = new System.Drawing.Size(348, 48);
            this.btn_HuyDonHang.TabIndex = 2;
            this.btn_HuyDonHang.Text = "Hủy đơn hàng";
            this.btn_HuyDonHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btn_CapNhatDanhMuc
            // 
            this.btn_CapNhatDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CapNhatDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatDanhMuc.Location = new System.Drawing.Point(0, 184);
            this.btn_CapNhatDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CapNhatDanhMuc.Name = "btn_CapNhatDanhMuc";
            this.btn_CapNhatDanhMuc.Size = new System.Drawing.Size(348, 50);
            this.btn_CapNhatDanhMuc.TabIndex = 1;
            this.btn_CapNhatDanhMuc.Text = "Cập nhật danh mục";
            this.btn_CapNhatDanhMuc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CapNhatDanhMuc.Click += new System.EventHandler(this.btn_CapNhatDanhMuc_Click);
            // 
            // menu_NhanVienBanHang
            // 
            this.menu_NhanVienBanHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_NhanVienBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem});
            this.menu_NhanVienBanHang.Location = new System.Drawing.Point(0, 0);
            this.menu_NhanVienBanHang.Name = "menu_NhanVienBanHang";
            this.menu_NhanVienBanHang.Size = new System.Drawing.Size(348, 28);
            this.menu_NhanVienBanHang.TabIndex = 0;
            this.menu_NhanVienBanHang.Text = "menuStrip1";
            // 
            // cậpNhậtThôngTinTàiKhoảnToolStripMenuItem
            // 
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Name = "cậpNhậtThôngTinTàiKhoảnToolStripMenuItem";
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Text = "Cập nhật thông tin tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // FormNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 586);
            this.Controls.Add(this.panel_body);
            this.MainMenuStrip = this.menu_NhanVienBanHang;
            this.Name = "FormNhanVienBanHang";
            this.Text = "FormNhanVienBanHang";
            this.panel_body.ResumeLayout(false);
            this.pane_left.ResumeLayout(false);
            this.pane_left.PerformLayout();
            this.menu_NhanVienBanHang.ResumeLayout(false);
            this.menu_NhanVienBanHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel pane_left;
        private System.Windows.Forms.MenuStrip menu_NhanVienBanHang;
        private Sunny.UI.UIButton btn_CapNhatDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private Sunny.UI.UIButton btn_LapPhieuBanHang;
        private Sunny.UI.UIButton btn_HuyDonHang;
        private Sunny.UI.UIButton btn_QLHangHoa;
    }
}