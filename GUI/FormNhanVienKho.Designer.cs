﻿namespace DACN.GUI
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
            this.button3 = new System.Windows.Forms.Button();
            this.btn_LapPhieuNH = new System.Windows.Forms.Button();
            this.btn_QLTonKho = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_caidat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_tttk = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItem_ThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 30);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1322, 650);
            this.panel_body.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_LapPhieuNH);
            this.panel1.Controls.Add(this.btn_QLTonKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 650);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(389, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_LapPhieuNH
            // 
            this.btn_LapPhieuNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuNH.Location = new System.Drawing.Point(3, 348);
            this.btn_LapPhieuNH.Name = "btn_LapPhieuNH";
            this.btn_LapPhieuNH.Size = new System.Drawing.Size(389, 56);
            this.btn_LapPhieuNH.TabIndex = 1;
            this.btn_LapPhieuNH.Text = "Lập phiếu nhập hàng";
            this.btn_LapPhieuNH.UseVisualStyleBackColor = true;
            this.btn_LapPhieuNH.Click += new System.EventHandler(this.btn_LapPhieuNH_Click);
            // 
            // btn_QLTonKho
            // 
            this.btn_QLTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLTonKho.Location = new System.Drawing.Point(3, 292);
            this.btn_QLTonKho.Name = "btn_QLTonKho";
            this.btn_QLTonKho.Size = new System.Drawing.Size(389, 59);
            this.btn_QLTonKho.TabIndex = 0;
            this.btn_QLTonKho.Text = "Quản lý tồn kho";
            this.btn_QLTonKho.UseVisualStyleBackColor = true;
            this.btn_QLTonKho.Click += new System.EventHandler(this.btn_QLTonKho_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_body);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 680);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_caidat,
            this.mn_tttk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_caidat
            // 
            this.mn_caidat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mn_caidat.Name = "mn_caidat";
            this.mn_caidat.Size = new System.Drawing.Size(70, 26);
            this.mn_caidat.Text = "Cài đặt";
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
            // mn_tttk
            // 
            this.mn_tttk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItem_ThongTinTK,
            this.toolStripMenuItem_DoiMK});
            this.mn_tttk.Name = "mn_tttk";
            this.mn_tttk.Size = new System.Drawing.Size(202, 26);
            this.mn_tttk.Text = "Quản lý thông tin tài khoản";
            // 
            // tStripMenuItem_ThongTinTK
            // 
            this.tStripMenuItem_ThongTinTK.Name = "tStripMenuItem_ThongTinTK";
            this.tStripMenuItem_ThongTinTK.Size = new System.Drawing.Size(220, 26);
            this.tStripMenuItem_ThongTinTK.Text = "Thông tin tài khoản";
            this.tStripMenuItem_ThongTinTK.Click += new System.EventHandler(this.tStripMenuItem_ThongTinTK_Click);
            // 
            // toolStripMenuItem_DoiMK
            // 
            this.toolStripMenuItem_DoiMK.Name = "toolStripMenuItem_DoiMK";
            this.toolStripMenuItem_DoiMK.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem_DoiMK.Text = "Đổi mật khẩu";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Image = global::DACN.Properties.Resources.icon_logout2;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(115, 536);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(116, 46);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DACN.Properties.Resources.khosat;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 263);
            this.panel3.TabIndex = 3;
            // 
            // FormNhanVienKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 680);
            this.Controls.Add(this.panel2);
            this.Name = "FormNhanVienKho";
            this.Text = "FormNhanVienKho";
            this.panel_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_LapPhieuNH;
        private System.Windows.Forms.Button btn_QLTonKho;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_caidat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mn_tttk;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItem_ThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DoiMK;
        private System.Windows.Forms.Button btn_Logout;
    }
}