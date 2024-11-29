
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
            this.pn0 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btn_QLDonhang = new Sunny.UI.UIButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.pane_left.SuspendLayout();
            this.pn0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(261, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(664, 541);
            this.panel_right.TabIndex = 1;
            this.panel_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_right_Paint);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Controls.Add(this.pane_left);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(925, 541);
            this.panel_body.TabIndex = 1;
            // 
            // pane_left
            // 
            this.pane_left.BackColor = System.Drawing.Color.Teal;
            this.pane_left.Controls.Add(this.pictureBox3);
            this.pane_left.Controls.Add(this.pn0);
            this.pane_left.Controls.Add(this.btn_DangXuat);
            this.pane_left.Controls.Add(this.btn_QLDonhang);
            this.pane_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_left.ForeColor = System.Drawing.Color.Coral;
            this.pane_left.Location = new System.Drawing.Point(0, 0);
            this.pane_left.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pane_left.Name = "pane_left";
            this.pane_left.Size = new System.Drawing.Size(261, 541);
            this.pane_left.TabIndex = 0;
            // 
            // pn0
            // 
            this.pn0.BackColor = System.Drawing.Color.Teal;
            this.pn0.Controls.Add(this.lbUserName);
            this.pn0.Controls.Add(this.pictureBox1);
            this.pn0.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn0.Location = new System.Drawing.Point(0, 0);
            this.pn0.Margin = new System.Windows.Forms.Padding(2);
            this.pn0.Name = "pn0";
            this.pn0.Size = new System.Drawing.Size(261, 161);
            this.pn0.TabIndex = 9;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(25, 122);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(199, 29);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Nhân viên Giao Hàng";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QLDonhang
            // 
            this.btn_QLDonhang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_QLDonhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLDonhang.FillColor = System.Drawing.Color.Teal;
            this.btn_QLDonhang.FillColor2 = System.Drawing.Color.Teal;
            this.btn_QLDonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLDonhang.Location = new System.Drawing.Point(2, 195);
            this.btn_QLDonhang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_QLDonhang.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_QLDonhang.Name = "btn_QLDonhang";
            this.btn_QLDonhang.RectColor = System.Drawing.Color.Teal;
            this.btn_QLDonhang.Size = new System.Drawing.Size(261, 71);
            this.btn_QLDonhang.TabIndex = 4;
            this.btn_QLDonhang.Text = "Quản lý đơn hàng";
            this.btn_QLDonhang.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_QLDonhang.Click += new System.EventHandler(this.btn_QLDonHang_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DACN.Properties.Resources.order1;
            this.pictureBox3.Location = new System.Drawing.Point(11, 216);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DACN.Properties.Resources.delivery_man;
            this.pictureBox1.Location = new System.Drawing.Point(73, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.Image = global::DACN.Properties.Resources.icon_logout1;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(2, 425);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(34, 43);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // FormNhanVienGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 541);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormNhanVienGiaoHang";
            this.Text = "FormNhanVienGiaoHang";
            this.Load += new System.EventHandler(this.FormNhanVienGiaoHang_Load);
            this.panel_body.ResumeLayout(false);
            this.pane_left.ResumeLayout(false);
            this.pn0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel pane_left;
        private System.Windows.Forms.Button btn_DangXuat;
        private Sunny.UI.UIButton btn_QLDonhang;
        private System.Windows.Forms.Panel pn0;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}