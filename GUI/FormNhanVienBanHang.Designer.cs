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
            this.btn_QLKhuyenMai = new Sunny.UI.UIButton();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_QLHangHoa = new Sunny.UI.UIButton();
            this.btn_LapPhieuBanHang = new Sunny.UI.UIButton();
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
            this.panel_body.Size = new System.Drawing.Size(1471, 813);
            this.panel_body.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(348, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(1123, 813);
            this.panel_right.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.Silver;
            this.pane_left.Controls.Add(this.btn_QLKhuyenMai);
            this.pane_left.Controls.Add(this.btn_DangXuat);
            this.pane_left.Controls.Add(this.btn_QLHangHoa);
            this.pane_left.Controls.Add(this.btn_LapPhieuBanHang);
            this.pane_left.Controls.Add(this.btn_CapNhatDanhMuc);
            this.pane_left.Controls.Add(this.menu_NhanVienBanHang);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(348, 813);
            this.pane_left.TabIndex = 0;
            // 
            // btn_QLKhuyenMai
            // 
            this.btn_QLKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLKhuyenMai.FillColor = System.Drawing.Color.White;
            this.btn_QLKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.btn_QLKhuyenMai.Location = new System.Drawing.Point(1, 126);
            this.btn_QLKhuyenMai.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QLKhuyenMai.Name = "btn_QLKhuyenMai";
            this.btn_QLKhuyenMai.Size = new System.Drawing.Size(347, 50);
            this.btn_QLKhuyenMai.TabIndex = 6;
            this.btn_QLKhuyenMai.Text = "Quản lý khuyến mãi";
            this.btn_QLKhuyenMai.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLKhuyenMai.Click += new System.EventHandler(this.btn_QLKhuyenMai_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout1;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(91, 465);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(172, 53);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QLHangHoa
            // 
            this.btn_QLHangHoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_QLHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLHangHoa.FillColor = System.Drawing.Color.Snow;
            this.btn_QLHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHangHoa.ForeColor = System.Drawing.Color.Black;
            this.btn_QLHangHoa.Location = new System.Drawing.Point(0, 30);
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
            this.btn_LapPhieuBanHang.BackColor = System.Drawing.Color.Black;
            this.btn_LapPhieuBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuBanHang.FillColor = System.Drawing.Color.White;
            this.btn_LapPhieuBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LapPhieuBanHang.ForeColor = System.Drawing.Color.Black;
            this.btn_LapPhieuBanHang.Location = new System.Drawing.Point(0, 176);
            this.btn_LapPhieuBanHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LapPhieuBanHang.Name = "btn_LapPhieuBanHang";
            this.btn_LapPhieuBanHang.Size = new System.Drawing.Size(347, 50);
            this.btn_LapPhieuBanHang.TabIndex = 3;
            this.btn_LapPhieuBanHang.Text = "Lập phiếu bán hàng";
            this.btn_LapPhieuBanHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LapPhieuBanHang.Click += new System.EventHandler(this.btn_LapPhieuBanHang_Click);
            // 
            // btn_CapNhatDanhMuc
            // 
            this.btn_CapNhatDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatDanhMuc.FillColor = System.Drawing.Color.White;
            this.btn_CapNhatDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhatDanhMuc.Location = new System.Drawing.Point(0, 78);
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
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);

            // 
            // FormNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 813);
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
        private Sunny.UI.UIButton btn_QLHangHoa;
        private System.Windows.Forms.Button btn_DangXuat;
        private Sunny.UI.UIButton btn_QLKhuyenMai;
    }
}