namespace DACN.GUI
{
    partial class FormQLKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Body = new Sunny.UI.UITabControl();
            this.tab_DS = new System.Windows.Forms.TabPage();
            this.tab_TaoKM = new System.Windows.Forms.TabPage();
            this.btn_TaoKM = new Sunny.UI.UIButton();
            this.lb_mota = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_TheoLoaiKH = new System.Windows.Forms.RadioButton();
            this.rd_TheoKhoangTG = new System.Windows.Forms.RadioButton();
            this.rd_TheoTongTien = new System.Windows.Forms.RadioButton();
            this.dtp_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_GiaTriKM = new System.Windows.Forms.NumericUpDown();
            this.txt_TenKM = new Sunny.UI.UITextBox();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.lb_gtkm = new System.Windows.Forms.Label();
            this.txt_MoTa = new Sunny.UI.UIRichTextBox();
            this.lb_ngaykt = new System.Windows.Forms.Label();
            this.lb_ngaybd = new System.Windows.Forms.Label();
            this.lb_tenkm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.dvg_DSKM = new Sunny.UI.UIDataGridView();
            this.tab_Body.SuspendLayout();
            this.tab_DS.SuspendLayout();
            this.tab_TaoKM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTriKM)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSKM)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Body
            // 
            this.tab_Body.Controls.Add(this.tab_DS);
            this.tab_Body.Controls.Add(this.tab_TaoKM);
            this.tab_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Body.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_Body.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tab_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_Body.ItemSize = new System.Drawing.Size(260, 40);
            this.tab_Body.Location = new System.Drawing.Point(0, 0);
            this.tab_Body.MainPage = "";
            this.tab_Body.Name = "tab_Body";
            this.tab_Body.SelectedIndex = 0;
            this.tab_Body.Size = new System.Drawing.Size(1248, 707);
            this.tab_Body.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Body.Style = Sunny.UI.UIStyle.Custom;
            this.tab_Body.TabIndex = 0;
            this.tab_Body.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tab_Body.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tab_Body.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tab_DS
            // 
            this.tab_DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tab_DS.Controls.Add(this.panel1);
            this.tab_DS.Location = new System.Drawing.Point(0, 40);
            this.tab_DS.Name = "tab_DS";
            this.tab_DS.Size = new System.Drawing.Size(1248, 667);
            this.tab_DS.TabIndex = 0;
            this.tab_DS.Text = "Danh sách khuyến mãi";
            // 
            // tab_TaoKM
            // 
            this.tab_TaoKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tab_TaoKM.Controls.Add(this.btn_TaoKM);
            this.tab_TaoKM.Controls.Add(this.lb_mota);
            this.tab_TaoKM.Controls.Add(this.groupBox1);
            this.tab_TaoKM.Controls.Add(this.dtp_NgayKT);
            this.tab_TaoKM.Controls.Add(this.dtp_NgayBD);
            this.tab_TaoKM.Controls.Add(this.cb_TrangThai);
            this.tab_TaoKM.Controls.Add(this.txt_GiaTriKM);
            this.tab_TaoKM.Controls.Add(this.txt_TenKM);
            this.tab_TaoKM.Controls.Add(this.lb_trangthai);
            this.tab_TaoKM.Controls.Add(this.lb_gtkm);
            this.tab_TaoKM.Controls.Add(this.txt_MoTa);
            this.tab_TaoKM.Controls.Add(this.lb_ngaykt);
            this.tab_TaoKM.Controls.Add(this.lb_ngaybd);
            this.tab_TaoKM.Controls.Add(this.lb_tenkm);
            this.tab_TaoKM.Location = new System.Drawing.Point(0, 40);
            this.tab_TaoKM.Name = "tab_TaoKM";
            this.tab_TaoKM.Size = new System.Drawing.Size(1248, 667);
            this.tab_TaoKM.TabIndex = 1;
            this.tab_TaoKM.Text = "Tạo khuyến mãi";
            // 
            // btn_TaoKM
            // 
            this.btn_TaoKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TaoKM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_TaoKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_TaoKM.ForeHoverColor = System.Drawing.Color.Black;
            this.btn_TaoKM.Location = new System.Drawing.Point(735, 494);
            this.btn_TaoKM.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_TaoKM.Name = "btn_TaoKM";
            this.btn_TaoKM.Radius = 20;
            this.btn_TaoKM.Size = new System.Drawing.Size(221, 55);
            this.btn_TaoKM.TabIndex = 17;
            this.btn_TaoKM.Text = "Tạo khuyến mãi";
            this.btn_TaoKM.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_TaoKM.Click += new System.EventHandler(this.btn_TaoKM_Click);
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Location = new System.Drawing.Point(79, 249);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(61, 25);
            this.lb_mota.TabIndex = 16;
            this.lb_mota.Text = "Mô tả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_TheoLoaiKH);
            this.groupBox1.Controls.Add(this.rd_TheoKhoangTG);
            this.groupBox1.Controls.Add(this.rd_TheoTongTien);
            this.groupBox1.Location = new System.Drawing.Point(98, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại khuyến mãi";
            // 
            // rd_TheoLoaiKH
            // 
            this.rd_TheoLoaiKH.AutoSize = true;
            this.rd_TheoLoaiKH.Location = new System.Drawing.Point(528, 42);
            this.rd_TheoLoaiKH.Name = "rd_TheoLoaiKH";
            this.rd_TheoLoaiKH.Size = new System.Drawing.Size(177, 29);
            this.rd_TheoLoaiKH.TabIndex = 15;
            this.rd_TheoLoaiKH.TabStop = true;
            this.rd_TheoLoaiKH.Text = "Loại khách hàng";
            this.rd_TheoLoaiKH.UseVisualStyleBackColor = true;
            this.rd_TheoLoaiKH.CheckedChanged += new System.EventHandler(this.rd_TheoLoaiKH_CheckedChanged);
            // 
            // rd_TheoKhoangTG
            // 
            this.rd_TheoKhoangTG.AutoSize = true;
            this.rd_TheoKhoangTG.Location = new System.Drawing.Point(52, 42);
            this.rd_TheoKhoangTG.Name = "rd_TheoKhoangTG";
            this.rd_TheoKhoangTG.Size = new System.Drawing.Size(180, 29);
            this.rd_TheoKhoangTG.TabIndex = 13;
            this.rd_TheoKhoangTG.TabStop = true;
            this.rd_TheoKhoangTG.Text = "Khoảng thời gian";
            this.rd_TheoKhoangTG.UseVisualStyleBackColor = true;
            this.rd_TheoKhoangTG.CheckedChanged += new System.EventHandler(this.rd_TheoKhoangTG_CheckedChanged);
            // 
            // rd_TheoTongTien
            // 
            this.rd_TheoTongTien.AutoSize = true;
            this.rd_TheoTongTien.Location = new System.Drawing.Point(262, 42);
            this.rd_TheoTongTien.Name = "rd_TheoTongTien";
            this.rd_TheoTongTien.Size = new System.Drawing.Size(229, 29);
            this.rd_TheoTongTien.TabIndex = 14;
            this.rd_TheoTongTien.TabStop = true;
            this.rd_TheoTongTien.Text = "Tổng tiền trên hóa đơn";
            this.rd_TheoTongTien.UseVisualStyleBackColor = true;
            this.rd_TheoTongTien.CheckedChanged += new System.EventHandler(this.rd_TheoTongTien_CheckedChanged);
            // 
            // dtp_NgayKT
            // 
            this.dtp_NgayKT.Location = new System.Drawing.Point(757, 197);
            this.dtp_NgayKT.Name = "dtp_NgayKT";
            this.dtp_NgayKT.Size = new System.Drawing.Size(350, 30);
            this.dtp_NgayKT.TabIndex = 11;
            // 
            // dtp_NgayBD
            // 
            this.dtp_NgayBD.Location = new System.Drawing.Point(233, 192);
            this.dtp_NgayBD.Name = "dtp_NgayBD";
            this.dtp_NgayBD.Size = new System.Drawing.Size(345, 30);
            this.dtp_NgayBD.TabIndex = 10;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Chờ phê duyệt"});
            this.cb_TrangThai.Location = new System.Drawing.Point(259, 443);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(155, 33);
            this.cb_TrangThai.TabIndex = 9;
            // 
            // txt_GiaTriKM
            // 
            this.txt_GiaTriKM.Location = new System.Drawing.Point(323, 505);
            this.txt_GiaTriKM.Name = "txt_GiaTriKM";
            this.txt_GiaTriKM.Size = new System.Drawing.Size(154, 30);
            this.txt_GiaTriKM.TabIndex = 8;
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenKM.Location = new System.Drawing.Point(270, 141);
            this.txt_TenKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenKM.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TenKM.ShowText = false;
            this.txt_TenKM.Size = new System.Drawing.Size(330, 29);
            this.txt_TenKM.TabIndex = 7;
            this.txt_TenKM.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TenKM.Watermark = "";
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Location = new System.Drawing.Point(98, 443);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(100, 25);
            this.lb_trangthai.TabIndex = 6;
            this.lb_trangthai.Text = "Trạng thái";
            // 
            // lb_gtkm
            // 
            this.lb_gtkm.AutoSize = true;
            this.lb_gtkm.Location = new System.Drawing.Point(103, 503);
            this.lb_gtkm.Name = "lb_gtkm";
            this.lb_gtkm.Size = new System.Drawing.Size(167, 25);
            this.lb_gtkm.TabIndex = 5;
            this.lb_gtkm.Text = "Giá trị khuyến mãi";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.FillColor = System.Drawing.Color.White;
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MoTa.Location = new System.Drawing.Point(98, 294);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MoTa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Padding = new System.Windows.Forms.Padding(2);
            this.txt_MoTa.ShowText = false;
            this.txt_MoTa.Size = new System.Drawing.Size(632, 101);
            this.txt_MoTa.TabIndex = 3;
            this.txt_MoTa.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ngaykt
            // 
            this.lb_ngaykt.AutoSize = true;
            this.lb_ngaykt.Location = new System.Drawing.Point(609, 197);
            this.lb_ngaykt.Name = "lb_ngaykt";
            this.lb_ngaykt.Size = new System.Drawing.Size(131, 25);
            this.lb_ngaykt.TabIndex = 2;
            this.lb_ngaykt.Text = "Ngày kết thúc";
            // 
            // lb_ngaybd
            // 
            this.lb_ngaybd.AutoSize = true;
            this.lb_ngaybd.Location = new System.Drawing.Point(74, 192);
            this.lb_ngaybd.Name = "lb_ngaybd";
            this.lb_ngaybd.Size = new System.Drawing.Size(128, 25);
            this.lb_ngaybd.TabIndex = 1;
            this.lb_ngaybd.Text = "Ngày bắt đầu";
            // 
            // lb_tenkm
            // 
            this.lb_tenkm.AutoSize = true;
            this.lb_tenkm.Location = new System.Drawing.Point(74, 141);
            this.lb_tenkm.Name = "lb_tenkm";
            this.lb_tenkm.Size = new System.Drawing.Size(152, 25);
            this.lb_tenkm.TabIndex = 0;
            this.lb_tenkm.Text = "Tên khuyến mãi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 667);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvg_DSKM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 272);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1248, 295);
            this.panel4.TabIndex = 2;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1248, 100);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "DANH SÁCH KHUYẾN MÃI";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_DSKM
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSKM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_DSKM.BackgroundColor = System.Drawing.Color.White;
            this.dvg_DSKM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_DSKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_DSKM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_DSKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_DSKM.EnableHeadersVisualStyles = false;
            this.dvg_DSKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSKM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_DSKM.Location = new System.Drawing.Point(0, 0);
            this.dvg_DSKM.Name = "dvg_DSKM";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSKM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_DSKM.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSKM.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_DSKM.RowTemplate.Height = 24;
            this.dvg_DSKM.SelectedIndex = -1;
            this.dvg_DSKM.Size = new System.Drawing.Size(1248, 272);
            this.dvg_DSKM.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSKM.TabIndex = 0;
            // 
            // FormQLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 707);
            this.Controls.Add(this.tab_Body);
            this.Name = "FormQLKhuyenMai";
            this.Text = "Quản lý khuyến mãi";
            this.tab_Body.ResumeLayout(false);
            this.tab_DS.ResumeLayout(false);
            this.tab_TaoKM.ResumeLayout(false);
            this.tab_TaoKM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTriKM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl tab_Body;
        private System.Windows.Forms.TabPage tab_DS;
        private System.Windows.Forms.TabPage tab_TaoKM;
        private Sunny.UI.UIRichTextBox txt_MoTa;
        private System.Windows.Forms.Label lb_ngaykt;
        private System.Windows.Forms.Label lb_ngaybd;
        private System.Windows.Forms.Label lb_tenkm;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Label lb_gtkm;
        private System.Windows.Forms.DateTimePicker dtp_NgayBD;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.NumericUpDown txt_GiaTriKM;
        private Sunny.UI.UITextBox txt_TenKM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_TheoKhoangTG;
        private System.Windows.Forms.RadioButton rd_TheoTongTien;
        private System.Windows.Forms.DateTimePicker dtp_NgayKT;
        private System.Windows.Forms.RadioButton rd_TheoLoaiKH;
        private Sunny.UI.UIButton btn_TaoKM;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dvg_DSKM;
    }
}