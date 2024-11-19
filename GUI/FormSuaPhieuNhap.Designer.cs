namespace DACN.GUI
{
    partial class FormSuaPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvg_SuaPN = new Sunny.UI.UIDataGridView();
            this.cbkho = new System.Windows.Forms.ComboBox();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.txttongtien = new Sunny.UI.UITextBox();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.lbtt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new Sunny.UI.UITextBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.txt_DonGia = new Sunny.UI.UITextBox();
            this.txt_ThanhTien = new Sunny.UI.UITextBox();
            this.txt_MaCTPN = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_SuaPN)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uiPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 715);
            this.panel1.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1155, 71);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "SỬA PHIẾU NHẬP";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbtt);
            this.panel2.Controls.Add(this.cbtrangthai);
            this.panel2.Controls.Add(this.txttongtien);
            this.panel2.Controls.Add(this.cbncc);
            this.panel2.Controls.Add(this.cbkho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 194);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uiPanel2);
            this.panel3.Controls.Add(this.dvg_SuaPN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 450);
            this.panel3.TabIndex = 2;
            // 
            // dvg_SuaPN
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_SuaPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvg_SuaPN.BackgroundColor = System.Drawing.Color.White;
            this.dvg_SuaPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_SuaPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvg_SuaPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_SuaPN.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvg_SuaPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvg_SuaPN.EnableHeadersVisualStyles = false;
            this.dvg_SuaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_SuaPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_SuaPN.Location = new System.Drawing.Point(0, 0);
            this.dvg_SuaPN.Name = "dvg_SuaPN";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_SuaPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvg_SuaPN.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_SuaPN.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvg_SuaPN.RowTemplate.Height = 24;
            this.dvg_SuaPN.SelectedIndex = -1;
            this.dvg_SuaPN.Size = new System.Drawing.Size(1155, 168);
            this.dvg_SuaPN.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_SuaPN.TabIndex = 0;
            this.dvg_SuaPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_SuaPN_CellClick);
            // 
            // cbkho
            // 
            this.cbkho.FormattingEnabled = true;
            this.cbkho.Location = new System.Drawing.Point(732, 43);
            this.cbkho.Name = "cbkho";
            this.cbkho.Size = new System.Drawing.Size(293, 24);
            this.cbkho.TabIndex = 0;
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(732, 111);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(293, 24);
            this.cbncc.TabIndex = 1;
            // 
            // txttongtien
            // 
            this.txttongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttongtien.Enabled = false;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttongtien.Location = new System.Drawing.Point(283, 38);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttongtien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Padding = new System.Windows.Forms.Padding(5);
            this.txttongtien.ShowText = false;
            this.txttongtien.Size = new System.Drawing.Size(218, 29);
            this.txttongtien.TabIndex = 2;
            this.txttongtien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttongtien.Watermark = "";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.Enabled = false;
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Đã chỉnh sửa"});
            this.cbtrangthai.Location = new System.Drawing.Point(283, 111);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(218, 24);
            this.cbtrangthai.TabIndex = 3;
            // 
            // lbtt
            // 
            this.lbtt.AutoSize = true;
            this.lbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtt.Location = new System.Drawing.Point(124, 38);
            this.lbtt.Name = "lbtt";
            this.lbtt.Size = new System.Drawing.Size(78, 20);
            this.lbtt.TabIndex = 4;
            this.lbtt.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trang thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhà cung cấp";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SoLuong.Location = new System.Drawing.Point(197, 110);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SoLuong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Padding = new System.Windows.Forms.Padding(5);
            this.txt_SoLuong.ShowText = false;
            this.txt_SoLuong.Size = new System.Drawing.Size(150, 29);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_SoLuong.Watermark = "";
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 168);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1155, 282);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.btn_Sua);
            this.uiPanel3.Controls.Add(this.btn_Xoa);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(934, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(221, 282);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.btn_capNhat);
            this.uiPanel4.Controls.Add(this.label7);
            this.uiPanel4.Controls.Add(this.label6);
            this.uiPanel4.Controls.Add(this.label5);
            this.uiPanel4.Controls.Add(this.label1);
            this.uiPanel4.Controls.Add(this.txt_MaCTPN);
            this.uiPanel4.Controls.Add(this.txt_ThanhTien);
            this.uiPanel4.Controls.Add(this.txt_DonGia);
            this.uiPanel4.Controls.Add(this.txt_SoLuong);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 0);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(934, 282);
            this.uiPanel4.TabIndex = 1;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_DonGia.Location = new System.Drawing.Point(197, 174);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DonGia.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Padding = new System.Windows.Forms.Padding(5);
            this.txt_DonGia.ShowText = false;
            this.txt_DonGia.Size = new System.Drawing.Size(150, 29);
            this.txt_DonGia.TabIndex = 2;
            this.txt_DonGia.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_DonGia.Watermark = "";
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ThanhTien.Location = new System.Drawing.Point(595, 40);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThanhTien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ThanhTien.ShowText = false;
            this.txt_ThanhTien.Size = new System.Drawing.Size(150, 29);
            this.txt_ThanhTien.TabIndex = 3;
            this.txt_ThanhTien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ThanhTien.Watermark = "";
            // 
            // txt_MaCTPN
            // 
            this.txt_MaCTPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaCTPN.Enabled = false;
            this.txt_MaCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MaCTPN.Location = new System.Drawing.Point(197, 44);
            this.txt_MaCTPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaCTPN.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MaCTPN.Name = "txt_MaCTPN";
            this.txt_MaCTPN.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MaCTPN.ShowText = false;
            this.txt_MaCTPN.Size = new System.Drawing.Size(150, 29);
            this.txt_MaCTPN.TabIndex = 4;
            this.txt_MaCTPN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MaCTPN.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã CTPN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thành tiền";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(83, 44);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 40);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(83, 130);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(106, 39);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Location = new System.Drawing.Point(654, 145);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(129, 54);
            this.btn_capNhat.TabIndex = 9;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // FormSuaPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 715);
            this.Controls.Add(this.panel1);
            this.Name = "FormSuaPhieuNhap";
            this.Text = "FormSuaPhieuNhap";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_SuaPN)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIDataGridView dvg_SuaPN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private Sunny.UI.UITextBox txttongtien;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.ComboBox cbkho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtt;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UITextBox txt_ThanhTien;
        private Sunny.UI.UITextBox txt_DonGia;
        private Sunny.UI.UITextBox txt_SoLuong;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txt_MaCTPN;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_capNhat;
    }
}