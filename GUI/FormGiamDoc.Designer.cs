﻿namespace DACN.GUI
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_LapPhieuNH = new System.Windows.Forms.Button();
            this.btn_DuyetPNH = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_caidat
            // 
            this.mn_caidat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mn_caidat.Name = "mn_caidat";
            this.mn_caidat.Size = new System.Drawing.Size(70, 24);
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
            this.mn_tttk.Size = new System.Drawing.Size(202, 24);
            this.mn_tttk.Text = "Quản lý thông tin tài khoản";
            // 
            // tStripMenuItem_ThongTinTK
            // 
            this.tStripMenuItem_ThongTinTK.Name = "tStripMenuItem_ThongTinTK";
            this.tStripMenuItem_ThongTinTK.Size = new System.Drawing.Size(224, 26);
            this.tStripMenuItem_ThongTinTK.Text = "Thông tin tài khoản";
            this.tStripMenuItem_ThongTinTK.Click += new System.EventHandler(this.tStripMenuItem_ThongTinTK_Click);
            // 
            // toolStripMenuItem_DoiMK
            // 
            this.toolStripMenuItem_DoiMK.Name = "toolStripMenuItem_DoiMK";
            this.toolStripMenuItem_DoiMK.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem_DoiMK.Text = "Đổi mật khẩu";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Controls.Add(this.panel_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 28);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1182, 608);
            this.panel_body.TabIndex = 3;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel_left.Controls.Add(this.btn_DangXuat);
            this.panel_left.Controls.Add(this.button3);
            this.panel_left.Controls.Add(this.btn_LapPhieuNH);
            this.panel_left.Controls.Add(this.btn_DuyetPNH);
            this.panel_left.Controls.Add(this.panel2);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(369, 608);
            this.panel_left.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(369, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 608);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DACN.Properties.Resources.khosat1;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 276);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-9, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(389, 59);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_LapPhieuNH
            // 
            this.btn_LapPhieuNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LapPhieuNH.Location = new System.Drawing.Point(-9, 351);
            this.btn_LapPhieuNH.Name = "btn_LapPhieuNH";
            this.btn_LapPhieuNH.Size = new System.Drawing.Size(389, 56);
            this.btn_LapPhieuNH.TabIndex = 4;
            this.btn_LapPhieuNH.Text = "Lập phiếu nhập hàng";
            this.btn_LapPhieuNH.UseVisualStyleBackColor = true;
            // 
            // btn_DuyetPNH
            // 
            this.btn_DuyetPNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DuyetPNH.Location = new System.Drawing.Point(-9, 295);
            this.btn_DuyetPNH.Name = "btn_DuyetPNH";
            this.btn_DuyetPNH.Size = new System.Drawing.Size(389, 59);
            this.btn_DuyetPNH.TabIndex = 3;
            this.btn_DuyetPNH.Text = "Duyệt phiếu nhập hàng";
            this.btn_DuyetPNH.UseVisualStyleBackColor = true;
            this.btn_DuyetPNH.Click += new System.EventHandler(this.btn_DuyetPNH_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(90, 480);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(142, 52);
            this.btn_DangXuat.TabIndex = 6;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // FormGiamDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 636);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormGiamDoc";
            this.Text = "FormGiamDoc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_LapPhieuNH;
        private System.Windows.Forms.Button btn_DuyetPNH;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}