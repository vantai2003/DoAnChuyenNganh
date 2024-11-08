namespace DACN.GUI
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.btnThemVao = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Hang = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHangHoa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnChonHD = new System.Windows.Forms.Button();
            this.tbTimKiemHang = new System.Windows.Forms.TextBox();
            this.btn_lammoiHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pndata = new System.Windows.Forms.Panel();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang)).BeginInit();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemVao
            // 
            this.btnThemVao.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThemVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVao.ForeColor = System.Drawing.Color.White;
            this.btnThemVao.Location = new System.Drawing.Point(601, 42);
            this.btnThemVao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(219, 69);
            this.btnThemVao.TabIndex = 47;
            this.btnThemVao.Text = "Thêm Vào ";
            this.btnThemVao.UseVisualStyleBackColor = false;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.Color.OrangeRed;
            this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamMoi.ForeColor = System.Drawing.Color.White;
            this.btLamMoi.Location = new System.Drawing.Point(-329, 194);
            this.btLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(156, 74);
            this.btLamMoi.TabIndex = 46;
            this.btLamMoi.Text = "Làm Mới";
            this.btLamMoi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(448, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Số Lượng";
            // 
            // dgv_Hang
            // 
            this.dgv_Hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hang.Location = new System.Drawing.Point(22, 336);
            this.dgv_Hang.Name = "dgv_Hang";
            this.dgv_Hang.RowHeadersWidth = 62;
            this.dgv_Hang.RowTemplate.Height = 28;
            this.dgv_Hang.Size = new System.Drawing.Size(1228, 702);
            this.dgv_Hang.TabIndex = 53;
            this.dgv_Hang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hang_CellClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(262, 249);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(139, 26);
            this.txtMaHD.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(17, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Hóa đơn đang chọn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 29);
            this.label6.TabIndex = 59;
            this.label6.Text = "Sản phẩm đang chọn";
            // 
            // txtHangHoa
            // 
            this.txtHangHoa.Enabled = false;
            this.txtHangHoa.Location = new System.Drawing.Point(262, 304);
            this.txtHangHoa.Name = "txtHangHoa";
            this.txtHangHoa.Size = new System.Drawing.Size(139, 26);
            this.txtHangHoa.TabIndex = 58;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(578, 300);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(139, 26);
            this.txtDonGia.TabIndex = 60;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(458, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 61;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(784, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 63;
            this.label8.Text = "Mã CTHD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(914, 245);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(139, 26);
            this.txtMaCTHD.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(266, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 29);
            this.label9.TabIndex = 65;
            this.label9.Text = "Thành tiền";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(415, 181);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(139, 26);
            this.txtThanhTien.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(814, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 29);
            this.label10.TabIndex = 67;
            this.label10.Text = "DVT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDVT
            // 
            this.txtDVT.Enabled = false;
            this.txtDVT.Location = new System.Drawing.Point(914, 293);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(139, 26);
            this.txtDVT.TabIndex = 66;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(570, 245);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(139, 26);
            this.txtSoLuong.TabIndex = 68;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // btnChonHD
            // 
            this.btnChonHD.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChonHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHD.ForeColor = System.Drawing.Color.White;
            this.btnChonHD.Location = new System.Drawing.Point(17, 157);
            this.btnChonHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(208, 70);
            this.btnChonHD.TabIndex = 69;
            this.btnChonHD.Text = "Chọn Hóa Đơn";
            this.btnChonHD.UseVisualStyleBackColor = false;
            this.btnChonHD.Click += new System.EventHandler(this.btnChonHD_Click);
            // 
            // tbTimKiemHang
            // 
            this.tbTimKiemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemHang.Location = new System.Drawing.Point(14, 32);
            this.tbTimKiemHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimKiemHang.Name = "tbTimKiemHang";
            this.tbTimKiemHang.Size = new System.Drawing.Size(302, 35);
            this.tbTimKiemHang.TabIndex = 11;
            this.tbTimKiemHang.TextChanged += new System.EventHandler(this.tbTimKiemHang_TextChanged);
            // 
            // btn_lammoiHang
            // 
            this.btn_lammoiHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_lammoiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoiHang.ForeColor = System.Drawing.Color.White;
            this.btn_lammoiHang.Location = new System.Drawing.Point(392, 18);
            this.btn_lammoiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lammoiHang.Name = "btn_lammoiHang";
            this.btn_lammoiHang.Size = new System.Drawing.Size(135, 53);
            this.btn_lammoiHang.TabIndex = 12;
            this.btn_lammoiHang.Text = "Làm Mới";
            this.btn_lammoiHang.UseVisualStyleBackColor = false;
            this.btn_lammoiHang.Click += new System.EventHandler(this.btn_lammoiHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tìm kiếm";
            // 
            // pndata
            // 
            this.pndata.BackColor = System.Drawing.Color.White;
            this.pndata.Controls.Add(this.pcSearch);
            this.pndata.Controls.Add(this.label3);
            this.pndata.Controls.Add(this.btn_lammoiHang);
            this.pndata.Controls.Add(this.tbTimKiemHang);
            this.pndata.Location = new System.Drawing.Point(8, 32);
            this.pndata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(546, 89);
            this.pndata.TabIndex = 51;
            // 
            // pcSearch
            // 
            this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
            this.pcSearch.Location = new System.Drawing.Point(324, 28);
            this.pcSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(41, 39);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 1050);
            this.Controls.Add(this.btnChonHD);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaCTHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHangHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dgv_Hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pndata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemVao);
            this.Controls.Add(this.btLamMoi);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang)).EndInit();
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Hang;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHangHoa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnChonHD;
        private System.Windows.Forms.TextBox tbTimKiemHang;
        private System.Windows.Forms.Button btn_lammoiHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.Panel pndata;
    }
}