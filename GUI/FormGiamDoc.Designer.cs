namespace DACN.GUI
{
    partial class FormGiamDoc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_caidat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_tttk = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_ThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_ĐuyetM = new System.Windows.Forms.Button();
            this.btn_QuanLyNV = new System.Windows.Forms.Button();
            this.btn_DuyetPNH = new System.Windows.Forms.Button();
            this.pn0 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.pn0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_caidat,
            this.mn_tttk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_caidat
            // 
            this.mn_caidat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mn_caidat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mn_caidat.Name = "mn_caidat";
            this.mn_caidat.Size = new System.Drawing.Size(68, 24);
            this.mn_caidat.Text = "Cài đặt";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 24);
            this.toolStripMenuItem3.Text = "Đổi màu nền";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(163, 24);
            this.toolStripMenuItem4.Text = "Đổi màu chữ";
            // 
            // mn_tttk
            // 
            this.mn_tttk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItem_ThongTinTK,
            this.toolStripMenuItem_DoiMK});
            this.mn_tttk.Name = "mn_tttk";
            this.mn_tttk.Size = new System.Drawing.Size(200, 24);
            this.mn_tttk.Text = "Quản lý thông tin tài khoản";
            // 
            // tStripMenuItem_ThongTinTK
            // 
            this.tStripMenuItem_ThongTinTK.Name = "tStripMenuItem_ThongTinTK";
            this.tStripMenuItem_ThongTinTK.Size = new System.Drawing.Size(206, 24);
            this.tStripMenuItem_ThongTinTK.Text = "Thông tin tài khoản";
            this.tStripMenuItem_ThongTinTK.Click += new System.EventHandler(this.tStripMenuItem_ThongTinTK_Click);
            // 
            // toolStripMenuItem_DoiMK
            // 
            this.toolStripMenuItem_DoiMK.Name = "toolStripMenuItem_DoiMK";
            this.toolStripMenuItem_DoiMK.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItem_DoiMK.Text = "Đổi mật khẩu";
            this.toolStripMenuItem_DoiMK.Click += new System.EventHandler(this.toolStripMenuItem_DoiMK_Click);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Controls.Add(this.panel_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 26);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(856, 430);
            this.panel_body.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 430);
            this.panel1.TabIndex = 1;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Teal;
            this.panel_left.Controls.Add(this.btn_ĐuyetM);
            this.panel_left.Controls.Add(this.btn_QuanLyNV);
            this.panel_left.Controls.Add(this.btn_DuyetPNH);
            this.panel_left.Controls.Add(this.pn0);
            this.panel_left.Controls.Add(this.btn_DangXuat);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(246, 430);
            this.panel_left.TabIndex = 0;
            // 
            // btn_ĐuyetM
            // 
            this.btn_ĐuyetM.BackColor = System.Drawing.Color.Teal;
            this.btn_ĐuyetM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ĐuyetM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ĐuyetM.Location = new System.Drawing.Point(0, 245);
            this.btn_ĐuyetM.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_ĐuyetM.Name = "btn_ĐuyetM";
            this.btn_ĐuyetM.Size = new System.Drawing.Size(259, 55);
            this.btn_ĐuyetM.TabIndex = 5;
            this.btn_ĐuyetM.Text = "Duyệt danh mục";
            this.btn_ĐuyetM.UseVisualStyleBackColor = false;
            this.btn_ĐuyetM.Click += new System.EventHandler(this.btn_ĐuyetM_Click);
            // 
            // btn_QuanLyNV
            // 
            this.btn_QuanLyNV.BackColor = System.Drawing.Color.Teal;
            this.btn_QuanLyNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuanLyNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QuanLyNV.Location = new System.Drawing.Point(0, 185);
            this.btn_QuanLyNV.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_QuanLyNV.Name = "btn_QuanLyNV";
            this.btn_QuanLyNV.Size = new System.Drawing.Size(259, 64);
            this.btn_QuanLyNV.TabIndex = 4;
            this.btn_QuanLyNV.Text = "Quản lý nhân vên";
            this.btn_QuanLyNV.UseVisualStyleBackColor = false;
            this.btn_QuanLyNV.Click += new System.EventHandler(this.btn_QuanLyNV_Click);
            // 
            // btn_DuyetPNH
            // 
            this.btn_DuyetPNH.BackColor = System.Drawing.Color.Teal;
            this.btn_DuyetPNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DuyetPNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DuyetPNH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DuyetPNH.Location = new System.Drawing.Point(0, 135);
            this.btn_DuyetPNH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_DuyetPNH.Name = "btn_DuyetPNH";
            this.btn_DuyetPNH.Size = new System.Drawing.Size(259, 54);
            this.btn_DuyetPNH.TabIndex = 3;
            this.btn_DuyetPNH.Text = "Duyệt phiếu nhập hàng";
            this.btn_DuyetPNH.UseVisualStyleBackColor = false;
            this.btn_DuyetPNH.Click += new System.EventHandler(this.btn_DuyetPNH_Click);
            // 
            // pn0
            // 
            this.pn0.BackColor = System.Drawing.Color.Teal;
            this.pn0.Controls.Add(this.lbUserName);
            this.pn0.Controls.Add(this.pictureBox1);
            this.pn0.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn0.Location = new System.Drawing.Point(0, 0);
            this.pn0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn0.Name = "pn0";
            this.pn0.Size = new System.Drawing.Size(246, 139);
            this.pn0.TabIndex = 9;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(26, 105);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(185, 29);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Giám đốc";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DACN.Properties.Resources.Image_NV;
            this.pictureBox1.Location = new System.Drawing.Point(62, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(77, 396);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(107, 42);
            this.btn_DangXuat.TabIndex = 6;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // FormGiamDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormGiamDoc";
            this.Text = "FormGiamDoc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.pn0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_caidat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mn_tttk;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_ThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DoiMK;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_ĐuyetM;
        private System.Windows.Forms.Button btn_QuanLyNV;
        private System.Windows.Forms.Button btn_DuyetPNH;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel pn0;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}