namespace DACN.GUI
{
    partial class FormTrangChuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChuAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btnSaoLuuPhucHoi = new Sunny.UI.UIButton();
            this.btn_QuanLySanPham = new Sunny.UI.UIButton();
            this.btn_QuanLyTaiKhoam = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1249, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItem1.Text = "Cài đặt";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 30);
            this.toolStripMenuItem3.Text = "Đổi màu nền";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(206, 30);
            this.toolStripMenuItem4.Text = "Đổi màu chữ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(256, 29);
            this.toolStripMenuItem2.Text = "Quản lý thông tin tài khoản";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Purple;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(262, 30);
            this.toolStripMenuItem5.Text = "Thông tin tài khoản";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.Purple;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(262, 30);
            this.toolStripMenuItem6.Text = "Đổi mật khẩu";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.uiPanel2);
            this.panel_body.Controls.Add(this.uiPanel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 33);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1249, 798);
            this.panel_body.TabIndex = 1;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(383, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(866, 798);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btn_DangXuat);
            this.uiPanel1.Controls.Add(this.btnSaoLuuPhucHoi);
            this.uiPanel1.Controls.Add(this.btn_QuanLySanPham);
            this.uiPanel1.Controls.Add(this.btn_QuanLyTaiKhoam);
            this.uiPanel1.Controls.Add(this.panel1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.Green;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(383, 798);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(108, 606);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(142, 52);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btnSaoLuuPhucHoi
            // 
            this.btnSaoLuuPhucHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaoLuuPhucHoi.FillColor = System.Drawing.Color.Green;
            this.btnSaoLuuPhucHoi.FillHoverColor = System.Drawing.Color.Red;
            this.btnSaoLuuPhucHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaoLuuPhucHoi.ForeColor = System.Drawing.Color.Yellow;
            this.btnSaoLuuPhucHoi.Location = new System.Drawing.Point(1, 438);
            this.btnSaoLuuPhucHoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaoLuuPhucHoi.Name = "btnSaoLuuPhucHoi";
            this.btnSaoLuuPhucHoi.RectColor = System.Drawing.Color.Lime;
            this.btnSaoLuuPhucHoi.RectHoverColor = System.Drawing.Color.Black;
            this.btnSaoLuuPhucHoi.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaoLuuPhucHoi.RectSelectedColor = System.Drawing.Color.Fuchsia;
            this.btnSaoLuuPhucHoi.Size = new System.Drawing.Size(330, 61);
            this.btnSaoLuuPhucHoi.TabIndex = 3;
            this.btnSaoLuuPhucHoi.Text = "Sao lưu phục hồi";
            this.btnSaoLuuPhucHoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaoLuuPhucHoi.Click += new System.EventHandler(this.btnSaoLuuPhucHoi_Click);
            // 
            // btn_QuanLySanPham
            // 
            this.btn_QuanLySanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLySanPham.FillColor = System.Drawing.Color.Green;
            this.btn_QuanLySanPham.FillHoverColor = System.Drawing.Color.Red;
            this.btn_QuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QuanLySanPham.ForeColor = System.Drawing.Color.Yellow;
            this.btn_QuanLySanPham.Location = new System.Drawing.Point(1, 380);
            this.btn_QuanLySanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QuanLySanPham.Name = "btn_QuanLySanPham";
            this.btn_QuanLySanPham.RectColor = System.Drawing.Color.Lime;
            this.btn_QuanLySanPham.RectHoverColor = System.Drawing.Color.Black;
            this.btn_QuanLySanPham.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_QuanLySanPham.RectSelectedColor = System.Drawing.Color.Fuchsia;
            this.btn_QuanLySanPham.Size = new System.Drawing.Size(330, 61);
            this.btn_QuanLySanPham.TabIndex = 2;
            this.btn_QuanLySanPham.Text = "Quản lý sản phẩm";
            this.btn_QuanLySanPham.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QuanLySanPham.Click += new System.EventHandler(this.btn_QuanLySanPham_Click);
            // 
            // btn_QuanLyTaiKhoam
            // 
            this.btn_QuanLyTaiKhoam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyTaiKhoam.FillColor = System.Drawing.Color.Green;
            this.btn_QuanLyTaiKhoam.FillHoverColor = System.Drawing.Color.Red;
            this.btn_QuanLyTaiKhoam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QuanLyTaiKhoam.ForeColor = System.Drawing.Color.Gold;
            this.btn_QuanLyTaiKhoam.ForeSelectedColor = System.Drawing.Color.IndianRed;
            this.btn_QuanLyTaiKhoam.Location = new System.Drawing.Point(1, 322);
            this.btn_QuanLyTaiKhoam.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QuanLyTaiKhoam.Name = "btn_QuanLyTaiKhoam";
            this.btn_QuanLyTaiKhoam.RectColor = System.Drawing.Color.Lime;
            this.btn_QuanLyTaiKhoam.RectHoverColor = System.Drawing.Color.Black;
            this.btn_QuanLyTaiKhoam.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_QuanLyTaiKhoam.RectSelectedColor = System.Drawing.Color.Fuchsia;
            this.btn_QuanLyTaiKhoam.Size = new System.Drawing.Size(330, 61);
            this.btn_QuanLyTaiKhoam.TabIndex = 1;
            this.btn_QuanLyTaiKhoam.Text = "Quản lý tài khoản";
            this.btn_QuanLyTaiKhoam.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QuanLyTaiKhoam.Click += new System.EventHandler(this.btn_QuanLyTaiKhoam_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 218);
            this.panel1.TabIndex = 0;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1249, 831);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChuAdmin";
            this.Text = "FormTrangChuAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Panel panel_body;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btn_QuanLyTaiKhoam;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btnSaoLuuPhucHoi;
        private Sunny.UI.UIButton btn_QuanLySanPham;
        private System.Windows.Forms.Button btn_DangXuat;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
    }
}