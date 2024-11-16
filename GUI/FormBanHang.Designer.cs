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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.tbTimKiemHang = new System.Windows.Forms.TextBox();
            this.btn_lammoiHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pndata = new System.Windows.Forms.Panel();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Sunny.UI.UITextBox();
            this.btnChonKH = new System.Windows.Forms.Button();
            this.txtMaKH = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienCoc = new Sunny.UI.UITextBox();
            this.dgv_BanHang = new Sunny.UI.UIDataGridView();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.Color.OrangeRed;
            this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamMoi.ForeColor = System.Drawing.Color.White;
            this.btLamMoi.Location = new System.Drawing.Point(-328, 194);
            this.btLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(156, 74);
            this.btLamMoi.TabIndex = 46;
            this.btLamMoi.Text = "Làm Mới";
            this.btLamMoi.UseVisualStyleBackColor = false;
            // 
            // tbTimKiemHang
            // 
            this.tbTimKiemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemHang.Location = new System.Drawing.Point(14, 32);
            this.tbTimKiemHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimKiemHang.Name = "tbTimKiemHang";
            this.tbTimKiemHang.Size = new System.Drawing.Size(302, 35);
            this.tbTimKiemHang.TabIndex = 11;
            // 
            // btn_lammoiHang
            // 
            this.btn_lammoiHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_lammoiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoiHang.ForeColor = System.Drawing.Color.White;
            this.btn_lammoiHang.Location = new System.Drawing.Point(392, 18);
            this.btn_lammoiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lammoiHang.Name = "btn_lammoiHang";
            this.btn_lammoiHang.Size = new System.Drawing.Size(135, 52);
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
            this.pndata.Location = new System.Drawing.Point(8, 265);
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
            this.pcSearch.Size = new System.Drawing.Size(40, 38);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // btnChonSP
            // 
            this.btnChonSP.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSP.ForeColor = System.Drawing.Color.White;
            this.btnChonSP.Location = new System.Drawing.Point(598, 275);
            this.btnChonSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(219, 69);
            this.btnChonSP.TabIndex = 70;
            this.btnChonSP.Text = "Chọn Sản Phẩm";
            this.btnChonSP.UseVisualStyleBackColor = false;
            this.btnChonSP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Trạng Thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.Enabled = false;
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Chờ phê duyệt",
            "Đã phê duyệt",
            "Từ chối"});
            this.cb_TrangThai.Location = new System.Drawing.Point(190, 103);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(294, 28);
            this.cb_TrangThai.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 78;
            this.label1.Text = "Tiền Cọc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(26, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "Địa chỉ giao:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(190, 202);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDiaChi.MinimumSize = new System.Drawing.Size(2, 15);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.ShowText = false;
            this.txtDiaChi.Size = new System.Drawing.Size(490, 29);
            this.txtDiaChi.TabIndex = 77;
            this.txtDiaChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiaChi.Watermark = "";
            // 
            // btnChonKH
            // 
            this.btnChonKH.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChonKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonKH.ForeColor = System.Drawing.Color.White;
            this.btnChonKH.Location = new System.Drawing.Point(507, 5);
            this.btnChonKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonKH.Name = "btnChonKH";
            this.btnChonKH.Size = new System.Drawing.Size(237, 69);
            this.btnChonKH.TabIndex = 80;
            this.btnChonKH.Text = "Chọn Khách Hàng";
            this.btnChonKH.UseVisualStyleBackColor = false;
            this.btnChonKH.Click += new System.EventHandler(this.btnChonKH_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(308, 25);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMaKH.MinimumSize = new System.Drawing.Size(2, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.ShowText = false;
            this.txtMaKH.Size = new System.Drawing.Size(147, 29);
            this.txtMaKH.TabIndex = 82;
            this.txtMaKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaKH.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(26, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 29);
            this.label5.TabIndex = 81;
            this.label5.Text = "Khách hàng đang chọn:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienCoc.Location = new System.Drawing.Point(190, 157);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTienCoc.MinimumSize = new System.Drawing.Size(2, 15);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTienCoc.ShowText = false;
            this.txtTienCoc.Size = new System.Drawing.Size(207, 29);
            this.txtTienCoc.TabIndex = 83;
            this.txtTienCoc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTienCoc.Watermark = "";
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCoc_KeyPress);
            // 
            // dgv_BanHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_BanHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_BanHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BanHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BanHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BanHang.EnableHeadersVisualStyles = false;
            this.dgv_BanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_BanHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_BanHang.Location = new System.Drawing.Point(8, 376);
            this.dgv_BanHang.Name = "dgv_BanHang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BanHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BanHang.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_BanHang.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_BanHang.RowTemplate.Height = 28;
            this.dgv_BanHang.SelectedIndex = -1;
            this.dgv_BanHang.Size = new System.Drawing.Size(1318, 336);
            this.dgv_BanHang.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_BanHang.TabIndex = 72;
            this.dgv_BanHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BanHang_CellEndEdit);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Enabled = false;
            this.txtThanhToan.Location = new System.Drawing.Point(425, 765);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(139, 26);
            this.txtThanhToan.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(249, 765);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 65;
            this.label9.Text = "Thanh Toán";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(616, 765);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tổng tiền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(751, 765);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(139, 26);
            this.txtTongTien.TabIndex = 73;
            // 
            // btnThemVao
            // 
            this.btnThemVao.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThemVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVao.ForeColor = System.Drawing.Color.White;
            this.btnThemVao.Location = new System.Drawing.Point(8, 745);
            this.btnThemVao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(219, 69);
            this.btnThemVao.TabIndex = 47;
            this.btnThemVao.Text = "Tạo Hóa Đơn";
            this.btnThemVao.UseVisualStyleBackColor = false;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(8, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 86;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(855, 275);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(219, 69);
            this.btnXoaSP.TabIndex = 87;
            this.btnXoaSP.Text = "Xóa Sản Phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 841);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.dgv_BanHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnThemVao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChonKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnChonSP);
            this.Controls.Add(this.pndata);
            this.Controls.Add(this.btLamMoi);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.TextBox tbTimKiemHang;
        private System.Windows.Forms.Button btn_lammoiHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.Panel pndata;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChonKH;
        private Sunny.UI.UITextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtTienCoc;
        private Sunny.UI.UIDataGridView dgv_BanHang;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaSP;
    }
}