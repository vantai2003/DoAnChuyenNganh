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
            this.txt_TestMaNV = new System.Windows.Forms.TextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.txt_ThongTintt = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.btnSaoLuuPhucHoi = new Sunny.UI.UIButton();
            this.btn_QuanLySanPham = new Sunny.UI.UIButton();
            this.btn_QuanLyTaiKhoam = new Sunny.UI.UIButton();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem1.Text = "Cài đặt";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 26);
            this.toolStripMenuItem3.Text = "Đổi màu nền";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 26);
            this.toolStripMenuItem4.Text = "Đổi màu chữ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 24);
            this.toolStripMenuItem2.Text = "Quản lý thông tin tài khoản";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem5.Text = "Thông tin tài khoản";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "Đổi mật khẩu";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.uiPanel2);
            this.panel_body.Controls.Add(this.uiPanel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 28);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1249, 803);
            this.panel_body.TabIndex = 1;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.txt_TestMaNV);
            this.uiPanel2.Controls.Add(this.uiTextBox2);
            this.uiPanel2.Controls.Add(this.uiTextBox1);
            this.uiPanel2.Controls.Add(this.txt_ThongTintt);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(431, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(818, 803);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TestMaNV
            // 
            this.txt_TestMaNV.Location = new System.Drawing.Point(145, 418);
            this.txt_TestMaNV.Name = "txt_TestMaNV";
            this.txt_TestMaNV.Size = new System.Drawing.Size(100, 30);
            this.txt_TestMaNV.TabIndex = 3;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(504, 232);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox2.TabIndex = 2;
            this.uiTextBox2.Text = "uiTextBox2";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(230, 233);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // txt_ThongTintt
            // 
            this.txt_ThongTintt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThongTintt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ThongTintt.Location = new System.Drawing.Point(245, 130);
            this.txt_ThongTintt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThongTintt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ThongTintt.Name = "txt_ThongTintt";
            this.txt_ThongTintt.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ThongTintt.ShowText = false;
            this.txt_ThongTintt.Size = new System.Drawing.Size(150, 29);
            this.txt_ThongTintt.TabIndex = 0;
            this.txt_ThongTintt.Text = "uiTextBox1";
            this.txt_ThongTintt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ThongTintt.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btn_DangXuat);
            this.uiPanel1.Controls.Add(this.uiButton4);
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
            this.uiPanel1.Size = new System.Drawing.Size(431, 803);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.FillColor = System.Drawing.Color.Green;
            this.uiButton4.FillHoverColor = System.Drawing.Color.Red;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton4.Location = new System.Drawing.Point(1, 493);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.RectColor = System.Drawing.Color.Lime;
            this.uiButton4.RectHoverColor = System.Drawing.Color.Black;
            this.uiButton4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiButton4.RectSelectedColor = System.Drawing.Color.Fuchsia;
            this.uiButton4.Size = new System.Drawing.Size(330, 61);
            this.uiButton4.TabIndex = 4;
            this.uiButton4.Text = "uiButton4";
            this.uiButton4.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 218);
            this.panel1.TabIndex = 0;
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
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
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
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton btnSaoLuuPhucHoi;
        private Sunny.UI.UIButton btn_QuanLySanPham;
        private System.Windows.Forms.Button btn_DangXuat;
        private Sunny.UI.UITextBox txt_ThongTintt;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.TextBox txt_TestMaNV;
    }
}