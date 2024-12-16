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
            this.label1 = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.rd_Nam = new Sunny.UI.UIRadioButton();
            this.rd_KhoangTG = new Sunny.UI.UIRadioButton();
            this.rd_Tuan = new Sunny.UI.UIRadioButton();
            this.rd_Ngay = new Sunny.UI.UIRadioButton();
            this.txt_ChiTheoNgay = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Thu = new Sunny.UI.UITextBox();
            this.btn_ThongKeNgay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.txt_TongCong = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_TatCa = new Sunny.UI.UIRadioButton();
            this.uiPanel5.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 308);
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
            this.dtTuNgay.Location = new System.Drawing.Point(138, 303);
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(171, 30);
            this.dtTuNgay.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 303);
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
            this.dtDenNgay.Location = new System.Drawing.Point(438, 308);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(169, 30);
            this.dtDenNgay.TabIndex = 37;
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.uiGroupBox1);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel5.Location = new System.Drawing.Point(0, 90);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel5.Size = new System.Drawing.Size(1198, 110);
            this.uiPanel5.TabIndex = 50;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.label7);
            this.uiPanel2.Controls.Add(this.cb_Nam);
            this.uiPanel2.Controls.Add(this.label2);
            this.uiPanel2.Controls.Add(this.dtDenNgay);
            this.uiPanel2.Controls.Add(this.label1);
            this.uiPanel2.Controls.Add(this.dtTuNgay);
            this.uiPanel2.Controls.Add(this.txt_TongCong);
            this.uiPanel2.Controls.Add(this.label6);
            this.uiPanel2.Controls.Add(this.txt_ChiTheoNgay);
            this.uiPanel2.Controls.Add(this.label5);
            this.uiPanel2.Controls.Add(this.label4);
            this.uiPanel2.Controls.Add(this.txt_Thu);
            this.uiPanel2.Controls.Add(this.btn_ThongKeNgay);
            this.uiPanel2.Controls.Add(this.label3);
            this.uiPanel2.Controls.Add(this.dtp_ChonNgay);
            this.uiPanel2.Controls.Add(this.uiPanel5);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1198, 550);
            this.uiPanel2.TabIndex = 51;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.rd_TatCa);
            this.uiGroupBox1.Controls.Add(this.rd_Nam);
            this.uiGroupBox1.Controls.Add(this.rd_KhoangTG);
            this.uiGroupBox1.Controls.Add(this.rd_Tuan);
            this.uiGroupBox1.Controls.Add(this.rd_Ngay);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1198, 110);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Thống kê theo";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rd_Nam
            // 
            this.rd_Nam.BackColor = System.Drawing.Color.Transparent;
            this.rd_Nam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rd_Nam.Location = new System.Drawing.Point(681, 36);
            this.rd_Nam.MinimumSize = new System.Drawing.Size(1, 1);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(150, 29);
            this.rd_Nam.TabIndex = 3;
            this.rd_Nam.Text = "Năm";
            this.rd_Nam.CheckedChanged += new System.EventHandler(this.rd_Nam_CheckedChanged);
            // 
            // rd_KhoangTG
            // 
            this.rd_KhoangTG.BackColor = System.Drawing.Color.Transparent;
            this.rd_KhoangTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_KhoangTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rd_KhoangTG.Location = new System.Drawing.Point(401, 36);
            this.rd_KhoangTG.MinimumSize = new System.Drawing.Size(1, 1);
            this.rd_KhoangTG.Name = "rd_KhoangTG";
            this.rd_KhoangTG.Size = new System.Drawing.Size(181, 29);
            this.rd_KhoangTG.TabIndex = 2;
            this.rd_KhoangTG.Text = "Khoảng thời gian";
            this.rd_KhoangTG.CheckedChanged += new System.EventHandler(this.rd_KhoangTG_CheckedChanged);
            // 
            // rd_Tuan
            // 
            this.rd_Tuan.BackColor = System.Drawing.Color.Transparent;
            this.rd_Tuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rd_Tuan.Location = new System.Drawing.Point(200, 36);
            this.rd_Tuan.MinimumSize = new System.Drawing.Size(1, 1);
            this.rd_Tuan.Name = "rd_Tuan";
            this.rd_Tuan.Size = new System.Drawing.Size(150, 29);
            this.rd_Tuan.TabIndex = 1;
            this.rd_Tuan.Text = "Tuần hiện tại";
            this.rd_Tuan.CheckedChanged += new System.EventHandler(this.rd_Tuan_CheckedChanged);
            // 
            // rd_Ngay
            // 
            this.rd_Ngay.BackColor = System.Drawing.Color.Transparent;
            this.rd_Ngay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rd_Ngay.Location = new System.Drawing.Point(44, 36);
            this.rd_Ngay.MinimumSize = new System.Drawing.Size(1, 1);
            this.rd_Ngay.Name = "rd_Ngay";
            this.rd_Ngay.Size = new System.Drawing.Size(150, 29);
            this.rd_Ngay.TabIndex = 0;
            this.rd_Ngay.Text = "Ngày";
            this.rd_Ngay.CheckedChanged += new System.EventHandler(this.rd_Ngay_CheckedChanged);
            // 
            // txt_ChiTheoNgay
            // 
            this.txt_ChiTheoNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChiTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ChiTheoNgay.Location = new System.Drawing.Point(166, 428);
            this.txt_ChiTheoNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ChiTheoNgay.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ChiTheoNgay.Name = "txt_ChiTheoNgay";
            this.txt_ChiTheoNgay.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ChiTheoNgay.ShowText = false;
            this.txt_ChiTheoNgay.Size = new System.Drawing.Size(236, 32);
            this.txt_ChiTheoNgay.TabIndex = 57;
            this.txt_ChiTheoNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ChiTheoNgay.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(41, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tổng chi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tổng thu";
            // 
            // txt_Thu
            // 
            this.txt_Thu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Thu.Location = new System.Drawing.Point(166, 363);
            this.txt_Thu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Thu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Thu.Name = "txt_Thu";
            this.txt_Thu.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Thu.ShowText = false;
            this.txt_Thu.Size = new System.Drawing.Size(236, 32);
            this.txt_Thu.TabIndex = 54;
            this.txt_Thu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Thu.Watermark = "";
            // 
            // btn_ThongKeNgay
            // 
            this.btn_ThongKeNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_ThongKeNgay.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKeNgay.Location = new System.Drawing.Point(612, 428);
            this.btn_ThongKeNgay.Name = "btn_ThongKeNgay";
            this.btn_ThongKeNgay.Size = new System.Drawing.Size(147, 55);
            this.btn_ThongKeNgay.TabIndex = 53;
            this.btn_ThongKeNgay.Text = "Thống kê";
            this.btn_ThongKeNgay.UseVisualStyleBackColor = false;
            this.btn_ThongKeNgay.Click += new System.EventHandler(this.btn_ThongKeNgay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày";
            // 
            // dtp_ChonNgay
            // 
            this.dtp_ChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ChonNgay.Location = new System.Drawing.Point(104, 237);
            this.dtp_ChonNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ChonNgay.Name = "dtp_ChonNgay";
            this.dtp_ChonNgay.Size = new System.Drawing.Size(171, 30);
            this.dtp_ChonNgay.TabIndex = 51;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Size = new System.Drawing.Size(1198, 90);
            this.uiPanel3.TabIndex = 50;
            this.uiPanel3.Text = "BÁO CÁO THỐNG KÊ";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TongCong.ForeColor = System.Drawing.Color.Red;
            this.txt_TongCong.Location = new System.Drawing.Point(166, 492);
            this.txt_TongCong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongCong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TongCong.ShowText = false;
            this.txt_TongCong.Size = new System.Drawing.Size(236, 32);
            this.txt_TongCong.TabIndex = 58;
            this.txt_TongCong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TongCong.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tổng cộng";
            // 
            // cb_Nam
            // 
            this.cb_Nam.FormattingEnabled = true;
            this.cb_Nam.Location = new System.Drawing.Point(810, 237);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(121, 33);
            this.cb_Nam.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(734, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Năm";
            // 
            // rd_TatCa
            // 
            this.rd_TatCa.BackColor = System.Drawing.Color.Transparent;
            this.rd_TatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_TatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rd_TatCa.Location = new System.Drawing.Point(894, 36);
            this.rd_TatCa.MinimumSize = new System.Drawing.Size(1, 1);
            this.rd_TatCa.Name = "rd_TatCa";
            this.rd_TatCa.Size = new System.Drawing.Size(150, 29);
            this.rd_TatCa.TabIndex = 4;
            this.rd_TatCa.Text = "Tất cả";
            this.rd_TatCa.CheckedChanged += new System.EventHandler(this.rd_TatCa_CheckedChanged);
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1198, 550);
            this.Controls.Add(this.uiPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.Button btn_ThongKeNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ChonNgay;
        private Sunny.UI.UITextBox txt_Thu;
        private Sunny.UI.UITextBox txt_ChiTheoNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton rd_Nam;
        private Sunny.UI.UIRadioButton rd_KhoangTG;
        private Sunny.UI.UIRadioButton rd_Tuan;
        private Sunny.UI.UIRadioButton rd_Ngay;
        private Sunny.UI.UITextBox txt_TongCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Nam;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIRadioButton rd_TatCa;
    }
}