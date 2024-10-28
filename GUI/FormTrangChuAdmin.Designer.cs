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
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.btn_QuanLySanPham = new Sunny.UI.UIButton();
            this.btn_QuanLyTaiKhoam = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
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
            this.toolStripMenuItem5.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem5.Text = "Thông tin tài khoản";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(220, 26);
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
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(431, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(818, 803);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiButton4);
            this.uiPanel1.Controls.Add(this.uiButton3);
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
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.Green;
            this.uiButton3.FillHoverColor = System.Drawing.Color.Red;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton3.Location = new System.Drawing.Point(1, 438);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.Lime;
            this.uiButton3.RectHoverColor = System.Drawing.Color.Black;
            this.uiButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiButton3.RectSelectedColor = System.Drawing.Color.Fuchsia;
            this.uiButton3.Size = new System.Drawing.Size(330, 61);
            this.uiButton3.TabIndex = 3;
            this.uiButton3.Text = "uiButton3";
            this.uiButton3.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton btn_QuanLySanPham;
    }
}