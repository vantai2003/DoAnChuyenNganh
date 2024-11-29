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
            this.pn0 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbAdmin = new System.Windows.Forms.PictureBox();
            this.menu_NhanVienBanHang = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_QLKhuyenMai = new Sunny.UI.UIButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_CapNhatDanhMuc = new Sunny.UI.UIButton();
            this.btn_LapPhieuBanHang = new Sunny.UI.UIButton();
            this.btn_QLHangHoa = new Sunny.UI.UIButton();
            this.panel_body.SuspendLayout();
            this.pane_left.SuspendLayout();
            this.pn0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).BeginInit();
            this.menu_NhanVienBanHang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Controls.Add(this.pane_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1692, 1050);
            this.panel_body.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(394, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(1298, 1050);
            this.panel_right.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.Teal;
            this.pane_left.Controls.Add(this.pn0);
            this.pane_left.Controls.Add(this.ptbAdmin);
            this.pane_left.Controls.Add(this.menu_NhanVienBanHang);
            this.pane_left.Controls.Add(this.panel1);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(394, 1050);
            this.pane_left.TabIndex = 0;
            // 
            // pn0
            // 
            this.pn0.BackColor = System.Drawing.Color.Teal;
            this.pn0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn0.Controls.Add(this.lbUserName);
            this.pn0.Controls.Add(this.pictureBox1);
            this.pn0.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn0.Location = new System.Drawing.Point(0, 33);
            this.pn0.Margin = new System.Windows.Forms.Padding(18);
            this.pn0.Name = "pn0";
            this.pn0.Size = new System.Drawing.Size(394, 249);
            this.pn0.TabIndex = 8;
            this.pn0.Paint += new System.Windows.Forms.PaintEventHandler(this.pn0_Paint);
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(50, 175);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(278, 45);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Nhân viên Bán Hàng";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DACN.Properties.Resources.Image_NV;
            this.pictureBox1.Location = new System.Drawing.Point(108, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbAdmin
            // 
            this.ptbAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdmin.Location = new System.Drawing.Point(142, 54);
            this.ptbAdmin.Name = "ptbAdmin";
            this.ptbAdmin.Size = new System.Drawing.Size(110, 111);
            this.ptbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbAdmin.TabIndex = 7;
            this.ptbAdmin.TabStop = false;
            // 
            // menu_NhanVienBanHang
            // 
            this.menu_NhanVienBanHang.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_NhanVienBanHang.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu_NhanVienBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem});
            this.menu_NhanVienBanHang.Location = new System.Drawing.Point(0, 0);
            this.menu_NhanVienBanHang.Name = "menu_NhanVienBanHang";
            this.menu_NhanVienBanHang.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu_NhanVienBanHang.Size = new System.Drawing.Size(394, 33);
            this.menu_NhanVienBanHang.TabIndex = 0;
            this.menu_NhanVienBanHang.Text = "menuStrip1";
            // 
            // cậpNhậtThôngTinTàiKhoảnToolStripMenuItem
            // 
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Name = "cậpNhậtThôngTinTàiKhoảnToolStripMenuItem";
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.cậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Text = "Cập nhật thông tin";
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
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btn_QLKhuyenMai);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btn_CapNhatDanhMuc);
            this.panel1.Controls.Add(this.btn_LapPhieuBanHang);
            this.panel1.Controls.Add(this.btn_QLHangHoa);
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 765);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Teal;
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.MintCream;
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout1;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(-4, 454);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(411, 122);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DACN.Properties.Resources.analytics;
            this.pictureBox2.Location = new System.Drawing.Point(3, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Teal;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::DACN.Properties.Resources.window;
            this.pictureBox5.Location = new System.Drawing.Point(13, 357);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // btn_QLKhuyenMai
            // 
            this.btn_QLKhuyenMai.BackColor = System.Drawing.Color.Teal;
            this.btn_QLKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLKhuyenMai.FillColor = System.Drawing.Color.Teal;
            this.btn_QLKhuyenMai.FillColor2 = System.Drawing.Color.Tomato;
            this.btn_QLKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLKhuyenMai.Location = new System.Drawing.Point(0, 5);
            this.btn_QLKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_QLKhuyenMai.MinimumSize = new System.Drawing.Size(2, 2);
            this.btn_QLKhuyenMai.Name = "btn_QLKhuyenMai";
            this.btn_QLKhuyenMai.RectColor = System.Drawing.Color.Teal;
            this.btn_QLKhuyenMai.Size = new System.Drawing.Size(392, 100);
            this.btn_QLKhuyenMai.TabIndex = 6;
            this.btn_QLKhuyenMai.Text = "Quản lý khuyến mãi";
            this.btn_QLKhuyenMai.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLKhuyenMai.Click += new System.EventHandler(this.btn_QLKhuyenMai_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::DACN.Properties.Resources.Vat_lieu;
            this.pictureBox4.Location = new System.Drawing.Point(3, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DACN.Properties.Resources.order1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btn_CapNhatDanhMuc
            // 
            this.btn_CapNhatDanhMuc.BackColor = System.Drawing.Color.Teal;
            this.btn_CapNhatDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatDanhMuc.FillColor = System.Drawing.Color.Teal;
            this.btn_CapNhatDanhMuc.FillColor2 = System.Drawing.Color.Tomato;
            this.btn_CapNhatDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatDanhMuc.Location = new System.Drawing.Point(-3, 338);
            this.btn_CapNhatDanhMuc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CapNhatDanhMuc.MinimumSize = new System.Drawing.Size(2, 2);
            this.btn_CapNhatDanhMuc.Name = "btn_CapNhatDanhMuc";
            this.btn_CapNhatDanhMuc.RectColor = System.Drawing.Color.Teal;
            this.btn_CapNhatDanhMuc.Size = new System.Drawing.Size(392, 93);
            this.btn_CapNhatDanhMuc.TabIndex = 1;
            this.btn_CapNhatDanhMuc.Text = "Cập nhật danh mục";
            this.btn_CapNhatDanhMuc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CapNhatDanhMuc.Click += new System.EventHandler(this.btn_CapNhatDanhMuc_Click);
            // 
            // btn_LapPhieuBanHang
            // 
            this.btn_LapPhieuBanHang.BackColor = System.Drawing.Color.Teal;
            this.btn_LapPhieuBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuBanHang.FillColor = System.Drawing.Color.Teal;
            this.btn_LapPhieuBanHang.FillColor2 = System.Drawing.Color.Tomato;
            this.btn_LapPhieuBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LapPhieuBanHang.Location = new System.Drawing.Point(0, 115);
            this.btn_LapPhieuBanHang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_LapPhieuBanHang.MinimumSize = new System.Drawing.Size(2, 2);
            this.btn_LapPhieuBanHang.Name = "btn_LapPhieuBanHang";
            this.btn_LapPhieuBanHang.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btn_LapPhieuBanHang.RectColor = System.Drawing.Color.Teal;
            this.btn_LapPhieuBanHang.Size = new System.Drawing.Size(392, 100);
            this.btn_LapPhieuBanHang.TabIndex = 3;
            this.btn_LapPhieuBanHang.Text = "Lập phiếu bán hàng";
            this.btn_LapPhieuBanHang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LapPhieuBanHang.Click += new System.EventHandler(this.btn_LapPhieuBanHang_Click);
            // 
            // btn_QLHangHoa
            // 
            this.btn_QLHangHoa.BackColor = System.Drawing.Color.Teal;
            this.btn_QLHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLHangHoa.FillColor = System.Drawing.Color.Teal;
            this.btn_QLHangHoa.FillColor2 = System.Drawing.Color.Tomato;
            this.btn_QLHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHangHoa.Location = new System.Drawing.Point(-3, 225);
            this.btn_QLHangHoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_QLHangHoa.MinimumSize = new System.Drawing.Size(2, 2);
            this.btn_QLHangHoa.Name = "btn_QLHangHoa";
            this.btn_QLHangHoa.RectColor = System.Drawing.Color.Teal;
            this.btn_QLHangHoa.Size = new System.Drawing.Size(392, 103);
            this.btn_QLHangHoa.TabIndex = 4;
            this.btn_QLHangHoa.Text = "Quản lý hàng hóa";
            this.btn_QLHangHoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLHangHoa.Click += new System.EventHandler(this.btn_QLHangHoa_Click);
            // 
            // FormNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 1050);
            this.Controls.Add(this.panel_body);
            this.MainMenuStrip = this.menu_NhanVienBanHang;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormNhanVienBanHang";
            this.Text = "FormNhanVienBanHang";
            this.panel_body.ResumeLayout(false);
            this.pane_left.ResumeLayout(false);
            this.pane_left.PerformLayout();
            this.pn0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).EndInit();
            this.menu_NhanVienBanHang.ResumeLayout(false);
            this.menu_NhanVienBanHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn0;
        private System.Windows.Forms.PictureBox ptbAdmin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}