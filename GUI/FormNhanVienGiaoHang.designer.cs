
namespace DACN.GUI
{
    partial class FormNhanVienGiaoHang
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
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pane_left = new System.Windows.Forms.Panel();
            this.btn_lappth = new Sunny.UI.UIButton();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_QLDonhang = new Sunny.UI.UIButton();
            this.panel_body.SuspendLayout();
            this.pane_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(348, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(630, 576);
            this.panel_right.TabIndex = 1;
            this.panel_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_right_Paint);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Controls.Add(this.pane_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(978, 576);
            this.panel_body.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.Silver;
            this.pane_left.Controls.Add(this.btn_lappth);
            this.pane_left.Controls.Add(this.btn_DangXuat);
            this.pane_left.Controls.Add(this.btn_QLDonhang);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(348, 576);
            this.pane_left.TabIndex = 0;
            // 
            // btn_lappth
            // 
            this.btn_lappth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_lappth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lappth.FillColor = System.Drawing.Color.Snow;
            this.btn_lappth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_lappth.ForeColor = System.Drawing.Color.Black;
            this.btn_lappth.Location = new System.Drawing.Point(0, 57);
            this.btn_lappth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_lappth.Name = "btn_lappth";
            this.btn_lappth.Size = new System.Drawing.Size(348, 50);
            this.btn_lappth.TabIndex = 6;
            this.btn_lappth.Text = "Lập phiếu trả hàng ";
            this.btn_lappth.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_lappth.Click += new System.EventHandler(this.btn_lappth_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout1;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(119, 520);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(164, 53);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QLDonhang
            // 
            this.btn_QLDonhang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_QLDonhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLDonhang.FillColor = System.Drawing.Color.Snow;
            this.btn_QLDonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLDonhang.ForeColor = System.Drawing.Color.Black;
            this.btn_QLDonhang.Location = new System.Drawing.Point(0, 1);
            this.btn_QLDonhang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QLDonhang.Name = "btn_QLDonhang";
            this.btn_QLDonhang.Size = new System.Drawing.Size(348, 50);
            this.btn_QLDonhang.TabIndex = 4;
            this.btn_QLDonhang.Text = "Quản lý đơn hàng";
            this.btn_QLDonhang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLDonhang.Click += new System.EventHandler(this.btn_QLDonHang_Click);
            // 
            // FormNhanVienGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 576);
            this.Controls.Add(this.panel_body);
            this.Name = "FormNhanVienGiaoHang";
            this.Text = "FormNhanVienGiaoHang";
            this.Load += new System.EventHandler(this.FormNhanVienGiaoHang_Load);
            this.panel_body.ResumeLayout(false);
            this.pane_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel pane_left;
        private System.Windows.Forms.Button btn_DangXuat;
        private Sunny.UI.UIButton btn_QLDonhang;
        private Sunny.UI.UIButton btn_lappth;
    }
}