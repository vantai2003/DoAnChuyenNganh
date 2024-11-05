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
            this.btn_DangXuat = new System.Windows.Forms.Button();
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
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1293, 732);
            this.panel_body.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(392, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(901, 732);
            this.panel_right.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pane_left.Controls.Add(this.btn_DangXuat);
            this.pane_left.Controls.Add(this.btn_QLHangHoa);
            this.pane_left.Controls.Add(this.btn_LapPhieuBanHang);
            this.pane_left.Controls.Add(this.btn_HuyDonHang);
            this.pane_left.Controls.Add(this.btn_CapNhatDanhMuc);
            this.pane_left.Controls.Add(this.menu_NhanVienBanHang);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(392, 732);
            this.pane_left.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout1;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(99, 550);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(129, 58);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QLHangHoa
            // 
            this.btn_QLHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLHangHoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QLHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHangHoa.Location = new System.Drawing.Point(-1, 160);
            this.btn_QLHangHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QLHangHoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QLHangHoa.Name = "btn_QLHangHoa";
            this.btn_QLHangHoa.Size = new System.Drawing.Size(392, 62);
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
            this.btn_LapPhieuBanHang.Location = new System.Drawing.Point(0, 368);
            this.btn_LapPhieuBanHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LapPhieuBanHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LapPhieuBanHang.Name = "btn_LapPhieuBanHang";
            this.btn_LapPhieuBanHang.Size = new System.Drawing.Size(392, 62);
            this.btn_LapPhieuBanHang.TabIndex = 3;
            this.btn_LapPhieuBanHang.Text = "Lập phiếu bán hàng";
            this.btn_LapPhieuBanHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LapPhieuBanHang.Click += new System.EventHandler(this.btn_LapPhieuBanHang_Click);
            // 
            // btn_HuyDonHang
            // 
            this.btn_HuyDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_HuyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_HuyDonHang.Location = new System.Drawing.Point(0, 300);
            this.btn_HuyDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_HuyDonHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_HuyDonHang.Name = "btn_HuyDonHang";
            this.btn_HuyDonHang.Size = new System.Drawing.Size(392, 60);
            this.btn_HuyDonHang.TabIndex = 2;
            this.btn_HuyDonHang.Text = "Hủy đơn hàng";
            this.btn_HuyDonHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btn_CapNhatDanhMuc
            // 
            this.btn_CapNhatDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CapNhatDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatDanhMuc.Location = new System.Drawing.Point(0, 230);
            this.btn_CapNhatDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CapNhatDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CapNhatDanhMuc.Name = "btn_CapNhatDanhMuc";
            this.btn_CapNhatDanhMuc.Size = new System.Drawing.Size(392, 62);
            this.btn_CapNhatDanhMuc.TabIndex = 1;
            this.btn_CapNhatDanhMuc.Text = "Cập nhật danh mục";
            this.btn_CapNhatDanhMuc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CapNhatDanhMuc.Click += new System.EventHandler(this.btn_CapNhatDanhMuc_Click);
            // 
            // menu_NhanVienBanHang
            // 
            this.menu_NhanVienBanHang.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_NhanVienBanHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_NhanVienBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem});
            this.menu_NhanVienBanHang.Location = new System.Drawing.Point(0, 0);
            this.menu_NhanVienBanHang.Name = "menu_NhanVienBanHang";
            this.menu_NhanVienBanHang.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_NhanVienBanHang.Size = new System.Drawing.Size(392, 33);
            this.menu_NhanVienBanHang.TabIndex = 0;
            this.menu_NhanVienBanHang.Text = "menuStrip1";
            // 
            // cậpNhậtThôngTinTàiKhoảnToolStripMenuItem
            // 
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Name = "cậpNhậtThôngTinTàiKhoảnToolStripMenuItem";
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(255, 29);
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Text = "Cập nhật thông tin tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // FormNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 732);
            this.Controls.Add(this.panel_body);
            this.MainMenuStrip = this.menu_NhanVienBanHang;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btn_DangXuat;
    }
}