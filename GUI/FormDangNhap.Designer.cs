namespace DACN.GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.llb_QuenMK = new Sunny.UI.UILinkLabel();
            this.btn_Login = new Sunny.UI.UIButton();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.txt_PassWord = new Sunny.UI.UITextBox();
            this.txt_UserName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiPanel1.BackgroundImage")));
            this.uiPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(13, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(371, 484);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel2.AutoSize = true;
            this.uiPanel2.Controls.Add(this.llb_QuenMK);
            this.uiPanel2.Controls.Add(this.btn_Login);
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Controls.Add(this.txt_PassWord);
            this.uiPanel2.Controls.Add(this.txt_UserName);
            this.uiPanel2.Controls.Add(this.uiLabel1);
            this.uiPanel2.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(392, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.White;
            this.uiPanel2.Size = new System.Drawing.Size(410, 488);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llb_QuenMK
            // 
            this.llb_QuenMK.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.llb_QuenMK.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.llb_QuenMK.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.llb_QuenMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.llb_QuenMK.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.llb_QuenMK.LinkColor = System.Drawing.Color.Blue;
            this.llb_QuenMK.Location = new System.Drawing.Point(181, 274);
            this.llb_QuenMK.Name = "llb_QuenMK";
            this.llb_QuenMK.Size = new System.Drawing.Size(165, 23);
            this.llb_QuenMK.TabIndex = 6;
            this.llb_QuenMK.TabStop = true;
            this.llb_QuenMK.Text = "Quên mật khẩu?";
            this.llb_QuenMK.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FillColor = System.Drawing.Color.Green;
            this.btn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Login.Location = new System.Drawing.Point(127, 315);
            this.btn_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Radius = 20;
            this.btn_Login.RectColor = System.Drawing.Color.Cyan;
            this.btn_Login.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.RectPressColor = System.Drawing.Color.Green;
            this.btn_Login.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.Size = new System.Drawing.Size(126, 38);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiPanel4.BackgroundImage")));
            this.uiPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(56, 227);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectColor = System.Drawing.Color.White;
            this.uiPanel4.Size = new System.Drawing.Size(34, 29);
            this.uiPanel4.TabIndex = 4;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiPanel3.BackgroundImage")));
            this.uiPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(56, 139);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.White;
            this.uiPanel3.Size = new System.Drawing.Size(34, 35);
            this.uiPanel3.TabIndex = 3;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_PassWord.Location = new System.Drawing.Point(107, 227);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PassWord.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.ShowText = false;
            this.txt_PassWord.Size = new System.Drawing.Size(188, 29);
            this.txt_PassWord.TabIndex = 2;
            this.txt_PassWord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_PassWord.Watermark = "";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UserName.Location = new System.Drawing.Point(107, 145);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_UserName.ShowText = false;
            this.txt_UserName.Size = new System.Drawing.Size(188, 29);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_UserName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.uiLabel1.Location = new System.Drawing.Point(102, 71);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(151, 36);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Đăng Nhập";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 488);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox txt_UserName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIButton btn_Login;
        private Sunny.UI.UILinkLabel llb_QuenMK;
        private Sunny.UI.UITextBox txt_PassWord;
    }
}