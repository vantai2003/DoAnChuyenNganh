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
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btn_Login = new Sunny.UI.UIButton();
            this.txt_PassWord = new Sunny.UI.UITextBox();
            this.txt_UserName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_instance = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Luutt = new Sunny.UI.UICheckBox();
            this.uiPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel2
            // 
            this.uiPanel2.AutoSize = true;
            this.uiPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiPanel2.Controls.Add(this.cb_Luutt);
            this.uiPanel2.Controls.Add(this.label1);
            this.uiPanel2.Controls.Add(this.txt_instance);
            this.uiPanel2.Controls.Add(this.label3);
            this.uiPanel2.Controls.Add(this.label2);
            this.uiPanel2.Controls.Add(this.btn_Login);
            this.uiPanel2.Controls.Add(this.txt_PassWord);
            this.uiPanel2.Controls.Add(this.txt_UserName);
            this.uiPanel2.Controls.Add(this.uiLabel1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel2.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(675, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(438, 543);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FillColor = System.Drawing.Color.Green;
            this.btn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Login.Location = new System.Drawing.Point(143, 462);
            this.btn_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Radius = 20;
            this.btn_Login.RectColor = System.Drawing.Color.Cyan;
            this.btn_Login.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.RectPressColor = System.Drawing.Color.Green;
            this.btn_Login.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.Size = new System.Drawing.Size(161, 41);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_PassWord.Location = new System.Drawing.Point(71, 345);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PassWord.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.ShowText = false;
            this.txt_PassWord.Size = new System.Drawing.Size(318, 38);
            this.txt_PassWord.TabIndex = 2;
            this.txt_PassWord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_PassWord.Watermark = "";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UserName.Location = new System.Drawing.Point(71, 252);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_UserName.ShowText = false;
            this.txt_UserName.Size = new System.Drawing.Size(318, 38);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_UserName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.DeepPink;
            this.uiLabel1.Location = new System.Drawing.Point(120, 42);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(315, 36);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 543);
            this.panel1.TabIndex = 2;
            // 
            // txt_instance
            // 
            this.txt_instance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_instance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_instance.Location = new System.Drawing.Point(72, 155);
            this.txt_instance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_instance.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_instance.Name = "txt_instance";
            this.txt_instance.Padding = new System.Windows.Forms.Padding(5);
            this.txt_instance.ShowText = false;
            this.txt_instance.Size = new System.Drawing.Size(318, 38);
            this.txt_instance.TabIndex = 8;
            this.txt_instance.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_instance.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiPanel1.BackgroundImage = global::DACN.Properties.Resources.iStock_1368100643_scaled;
            this.uiPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(675, 543);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = global::DACN.Properties.Resources.icons8_server_50;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(72, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Image = global::DACN.Properties.Resources.icons8_password_50;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(71, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = global::DACN.Properties.Resources.icons8_user_50;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(72, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Luutt
            // 
            this.cb_Luutt.BackColor = System.Drawing.Color.Transparent;
            this.cb_Luutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Luutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Luutt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_Luutt.Location = new System.Drawing.Point(248, 405);
            this.cb_Luutt.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Luutt.Name = "cb_Luutt";
            this.cb_Luutt.Size = new System.Drawing.Size(150, 29);
            this.cb_Luutt.TabIndex = 10;
            this.cb_Luutt.Text = "Lưu thông tin";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.uiPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox txt_UserName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_Login;
        private Sunny.UI.UITextBox txt_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txt_instance;
        private Sunny.UI.UICheckBox cb_Luutt;
    }
}