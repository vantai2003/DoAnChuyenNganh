
namespace DACN.GUI
{
    partial class FormThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTienmat = new System.Windows.Forms.RadioButton();
            this.rdbThe = new System.Windows.Forms.RadioButton();
            this.txt_tongtienhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.txt_tienkm = new System.Windows.Forms.TextBox();
            this.txt_tienthanhtoan = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.txt_tiencantra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txt_soTien = new System.Windows.Forms.TextBox();
            this.cb_template = new System.Windows.Forms.ComboBox();
            this.cb_nganhang = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXacNhanQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương Thức Thanh Toán";
            // 
            // rdbTienmat
            // 
            this.rdbTienmat.AutoSize = true;
            this.rdbTienmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTienmat.Location = new System.Drawing.Point(78, 99);
            this.rdbTienmat.Name = "rdbTienmat";
            this.rdbTienmat.Size = new System.Drawing.Size(287, 36);
            this.rdbTienmat.TabIndex = 1;
            this.rdbTienmat.TabStop = true;
            this.rdbTienmat.Text = "Thanh toán tiền mặt";
            this.rdbTienmat.UseVisualStyleBackColor = true;
            this.rdbTienmat.CheckedChanged += new System.EventHandler(this.rdbTienmat_CheckedChanged);
            // 
            // rdbThe
            // 
            this.rdbThe.AutoSize = true;
            this.rdbThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbThe.Location = new System.Drawing.Point(645, 99);
            this.rdbThe.Name = "rdbThe";
            this.rdbThe.Size = new System.Drawing.Size(363, 36);
            this.rdbThe.TabIndex = 2;
            this.rdbThe.TabStop = true;
            this.rdbThe.Text = "Thanh toán chuyển khoản";
            this.rdbThe.UseVisualStyleBackColor = true;
            this.rdbThe.CheckedChanged += new System.EventHandler(this.rdbThe_CheckedChanged);
            // 
            // txt_tongtienhang
            // 
            this.txt_tongtienhang.Enabled = false;
            this.txt_tongtienhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tongtienhang.Location = new System.Drawing.Point(248, 207);
            this.txt_tongtienhang.Name = "txt_tongtienhang";
            this.txt_tongtienhang.Size = new System.Drawing.Size(631, 27);
            this.txt_tongtienhang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(73, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(73, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiền đặt cọc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(73, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền khuyến mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(73, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiền thanh toán";
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.Enabled = false;
            this.txt_tiencoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tiencoc.Location = new System.Drawing.Point(248, 258);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Size = new System.Drawing.Size(631, 27);
            this.txt_tiencoc.TabIndex = 10;
            // 
            // txt_tienkm
            // 
            this.txt_tienkm.Enabled = false;
            this.txt_tienkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tienkm.Location = new System.Drawing.Point(248, 313);
            this.txt_tienkm.Name = "txt_tienkm";
            this.txt_tienkm.Size = new System.Drawing.Size(631, 27);
            this.txt_tienkm.TabIndex = 11;
            // 
            // txt_tienthanhtoan
            // 
            this.txt_tienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tienthanhtoan.Location = new System.Drawing.Point(248, 416);
            this.txt_tienthanhtoan.Name = "txt_tienthanhtoan";
            this.txt_tienthanhtoan.Size = new System.Drawing.Size(631, 27);
            this.txt_tienthanhtoan.TabIndex = 12;
            this.txt_tienthanhtoan.TextChanged += new System.EventHandler(this.txt_tienthanhtoan_TextChanged);
            this.txt_tienthanhtoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tienthanhtoan_KeyPress);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacnhan.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnXacnhan.Location = new System.Drawing.Point(458, 488);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(146, 45);
            this.btnXacnhan.TabIndex = 13;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txt_tiencantra
            // 
            this.txt_tiencantra.Enabled = false;
            this.txt_tiencantra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tiencantra.Location = new System.Drawing.Point(248, 363);
            this.txt_tiencantra.Name = "txt_tiencantra";
            this.txt_tiencantra.Size = new System.Drawing.Size(631, 27);
            this.txt_tiencantra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(73, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số tiền cần trả";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(625, 347);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCreate.Location = new System.Drawing.Point(248, 468);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(236, 53);
            this.btnCreate.TabIndex = 28;
            this.btnCreate.Text = "Tạo QR thanh toán";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txt_soTien
            // 
            this.txt_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_soTien.Location = new System.Drawing.Point(640, 187);
            this.txt_soTien.Name = "txt_soTien";
            this.txt_soTien.Size = new System.Drawing.Size(237, 27);
            this.txt_soTien.TabIndex = 27;
            this.txt_soTien.TextChanged += new System.EventHandler(this.txt_soTien_TextChanged);
            this.txt_soTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soTien_KeyPress);
            // 
            // cb_template
            // 
            this.cb_template.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_template.FormattingEnabled = true;
            this.cb_template.Items.AddRange(new object[] {
            "compact",
            "compact2",
            "qr_only",
            "print"});
            this.cb_template.Location = new System.Drawing.Point(82, 289);
            this.cb_template.Name = "cb_template";
            this.cb_template.Size = new System.Drawing.Size(230, 28);
            this.cb_template.TabIndex = 26;
            // 
            // cb_nganhang
            // 
            this.cb_nganhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_nganhang.FormattingEnabled = true;
            this.cb_nganhang.Location = new System.Drawing.Point(82, 186);
            this.cb_nganhang.Name = "cb_nganhang";
            this.cb_nganhang.Size = new System.Drawing.Size(230, 28);
            this.cb_nganhang.TabIndex = 25;
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInfo.Location = new System.Drawing.Point(640, 295);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(237, 22);
            this.txtInfo.TabIndex = 24;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(336, 290);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(268, 27);
            this.txtTenTaiKhoan.TabIndex = 23;
            this.txtTenTaiKhoan.Text = "NGUYEN PHAN HOANG";
            // 
            // txtSTK
            // 
            this.txtSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTK.Location = new System.Drawing.Point(336, 186);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(268, 27);
            this.txtSTK.TabIndex = 22;
            this.txtSTK.Text = "0587744230";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(636, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(332, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên chủ tài khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(78, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Template";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(636, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Số tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(332, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số tài khoản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(78, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngân hàng";
            // 
            // btnXacNhanQR
            // 
            this.btnXacNhanQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnXacNhanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanQR.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnXacNhanQR.Location = new System.Drawing.Point(714, 662);
            this.btnXacNhanQR.Name = "btnXacNhanQR";
            this.btnXacNhanQR.Size = new System.Drawing.Size(146, 45);
            this.btnXacNhanQR.TabIndex = 30;
            this.btnXacNhanQR.Text = "Xác nhận";
            this.btnXacNhanQR.UseVisualStyleBackColor = false;
            this.btnXacNhanQR.Click += new System.EventHandler(this.btnXacNhanQR_Click);
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 705);
            this.Controls.Add(this.btnXacNhanQR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txt_soTien);
            this.Controls.Add(this.cb_template);
            this.Controls.Add(this.cb_nganhang);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tiencantra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txt_tienthanhtoan);
            this.Controls.Add(this.txt_tienkm);
            this.Controls.Add(this.txt_tiencoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tongtienhang);
            this.Controls.Add(this.rdbThe);
            this.Controls.Add(this.rdbTienmat);
            this.Controls.Add(this.label1);
            this.Name = "FormThanhToan";
            this.Text = "Phương thức thanh toán";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThanhToan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTienmat;
        private System.Windows.Forms.RadioButton rdbThe;
        private System.Windows.Forms.TextBox txt_tongtienhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.TextBox txt_tienkm;
        private System.Windows.Forms.TextBox txt_tienthanhtoan;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.TextBox txt_tiencantra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txt_soTien;
        private System.Windows.Forms.ComboBox cb_template;
        private System.Windows.Forms.ComboBox cb_nganhang;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXacNhanQR;
    }
}