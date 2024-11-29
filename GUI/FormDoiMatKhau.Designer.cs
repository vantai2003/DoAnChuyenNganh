namespace DACN.GUI
{
    partial class FormDoiMatKhau
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
            this.panel_body = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_MkMoi = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btn_DoiMK = new Sunny.UI.UIButton();
            this.txt_MatKhauCu = new Sunny.UI.UITextBox();
            this.txt_TenDN = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.panel_body.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.uiPanel2);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_body.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(976, 641);
            this.panel_body.TabIndex = 0;
            this.panel_body.Text = null;
            this.panel_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.Controls.Add(this.txt_MkMoi);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Controls.Add(this.uiLabel1);
            this.uiPanel2.Controls.Add(this.btn_DoiMK);
            this.uiPanel2.Controls.Add(this.txt_MatKhauCu);
            this.uiPanel2.Controls.Add(this.txt_TenDN);
            this.uiPanel2.Controls.Add(this.uiPanel1);
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(214, 28);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(423, 471);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(61, 286);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(162, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "Mật khẩu mới";
            // 
            // txt_MkMoi
            // 
            this.txt_MkMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MkMoi.Location = new System.Drawing.Point(61, 328);
            this.txt_MkMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MkMoi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MkMoi.Name = "txt_MkMoi";
            this.txt_MkMoi.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MkMoi.PasswordChar = '*';
            this.txt_MkMoi.ShowText = false;
            this.txt_MkMoi.Size = new System.Drawing.Size(324, 29);
            this.txt_MkMoi.TabIndex = 6;
            this.txt_MkMoi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MkMoi.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(61, 185);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "Mật khẩu cũ";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(56, 81);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(232, 36);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "Tên đăng nhập";
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DoiMK.FillColor = System.Drawing.Color.Green;
            this.btn_DoiMK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DoiMK.ForeHoverColor = System.Drawing.Color.Black;
            this.btn_DoiMK.Location = new System.Drawing.Point(135, 422);
            this.btn_DoiMK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(140, 35);
            this.btn_DoiMK.TabIndex = 3;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MatKhauCu.Location = new System.Drawing.Point(61, 227);
            this.txt_MatKhauCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MatKhauCu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MatKhauCu.PasswordChar = '*';
            this.txt_MatKhauCu.ShowText = false;
            this.txt_MatKhauCu.Size = new System.Drawing.Size(324, 29);
            this.txt_MatKhauCu.TabIndex = 2;
            this.txt_MatKhauCu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MatKhauCu.Watermark = "";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenDN.Location = new System.Drawing.Point(61, 122);
            this.txt_TenDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenDN.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TenDN.ShowText = false;
            this.txt_TenDN.Size = new System.Drawing.Size(324, 29);
            this.txt_TenDN.TabIndex = 1;
            this.txt_TenDN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TenDN.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(423, 58);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "Đổi mật khẩu";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 641);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.panel_body.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panel_body;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox txt_MatKhauCu;
        private Sunny.UI.UITextBox txt_TenDN;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_DoiMK;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_MkMoi;
    }
}