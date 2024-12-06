namespace DACN.GUI
{
    partial class FormThongKeDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienNhapHang = new System.Windows.Forms.TextBox();
            this.txtTienBanHang = new System.Windows.Forms.TextBox();
            this.txtTienLoi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtTuNgay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtDenNgay);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 142);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Đến ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(225, 70);
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(301, 30);
            this.dtTuNgay.TabIndex = 36;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Từ ngày";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(838, 70);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(294, 30);
            this.dtDenNgay.TabIndex = 37;
            this.dtDenNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(302, 194);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(209, 30);
            this.uiLabel2.TabIndex = 44;
            this.uiLabel2.Text = "Tiền Nhập Hàng";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(302, 248);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(209, 30);
            this.uiLabel3.TabIndex = 45;
            this.uiLabel3.Text = "Tiền Bán Hàng";
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(302, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tiền Lời";
            // 
            // txtTienNhapHang
            // 
            this.txtTienNhapHang.Location = new System.Drawing.Point(607, 198);
            this.txtTienNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienNhapHang.Name = "txtTienNhapHang";
            this.txtTienNhapHang.Size = new System.Drawing.Size(205, 22);
            this.txtTienNhapHang.TabIndex = 47;
            // 
            // txtTienBanHang
            // 
            this.txtTienBanHang.Location = new System.Drawing.Point(607, 251);
            this.txtTienBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienBanHang.Name = "txtTienBanHang";
            this.txtTienBanHang.Size = new System.Drawing.Size(205, 22);
            this.txtTienBanHang.TabIndex = 48;
            // 
            // txtTienLoi
            // 
            this.txtTienLoi.Location = new System.Drawing.Point(607, 315);
            this.txtTienLoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienLoi.Name = "txtTienLoi";
            this.txtTienLoi.Size = new System.Drawing.Size(205, 22);
            this.txtTienLoi.TabIndex = 49;
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 550);
            this.Controls.Add(this.txtTienLoi);
            this.Controls.Add(this.txtTienBanHang);
            this.Controls.Add(this.txtTienNhapHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienNhapHang;
        private System.Windows.Forms.TextBox txtTienBanHang;
        private System.Windows.Forms.TextBox txtTienLoi;
    }
}