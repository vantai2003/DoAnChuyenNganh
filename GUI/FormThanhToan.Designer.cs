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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.tsCTPN = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvHoaDon = new Sunny.UI.UIDataGridView();
            this.txtMaHD = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.btn_lammoiHang = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.cbbMaKH = new Sunny.UI.UIComboBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.tsCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(166, 670);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(219, 69);
            this.btnThanhToan.TabIndex = 50;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // tsCTPN
            // 
            this.tsCTPN.BackColor = System.Drawing.Color.White;
            this.tsCTPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCTPN.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.toolStripSeparator4,
            this.tsbSua,
            this.toolStripSeparator6,
            this.tsbXoa,
            this.toolStripSeparator1,
            this.tsbLuu,
            this.toolStripSeparator8});
            this.tsCTPN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsCTPN.Location = new System.Drawing.Point(0, 0);
            this.tsCTPN.Name = "tsCTPN";
            this.tsCTPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCTPN.Size = new System.Drawing.Size(1029, 40);
            this.tsCTPN.TabIndex = 51;
            this.tsCTPN.Text = "tsNCC";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::DACN.Properties.Resources.Add;
            this.tsbThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbThem.Size = new System.Drawing.Size(119, 36);
            this.tsbThem.Text = "Thêm";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::DACN.Properties.Resources.Edit;
            this.tsbSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSua.Size = new System.Drawing.Size(97, 36);
            this.tsbSua.Text = "Sửa";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::DACN.Properties.Resources.Delete;
            this.tsbXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoa.Size = new System.Drawing.Size(98, 36);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::DACN.Properties.Resources.Save;
            this.tsbLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuu.Size = new System.Drawing.Size(97, 36);
            this.tsbLuu.Text = "Lưu";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 40);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(602, 670);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(219, 69);
            this.btnThemSP.TabIndex = 52;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 280);
            this.dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDon.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.SelectedIndex = -1;
            this.dgvHoaDon.Size = new System.Drawing.Size(1012, 382);
            this.dgvHoaDon.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.TabIndex = 53;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(287, 107);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaHD.ShowText = false;
            this.txtMaHD.Size = new System.Drawing.Size(150, 29);
            this.txtMaHD.TabIndex = 54;
            this.txtMaHD.Text = "MaHD";
            this.txtMaHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaHD.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Hóa đơn đang chọn:";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton1.Location = new System.Drawing.Point(453, 98);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(192, 38);
            this.uiButton1.TabIndex = 59;
            this.uiButton1.Text = "Xem chi tiết";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // pcSearch
            // 
            this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
            this.pcSearch.Location = new System.Drawing.Point(763, 1);
            this.pcSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(35, 37);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // btn_lammoiHang
            // 
            this.btn_lammoiHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_lammoiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoiHang.ForeColor = System.Drawing.Color.White;
            this.btn_lammoiHang.Location = new System.Drawing.Point(806, 3);
            this.btn_lammoiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lammoiHang.Name = "btn_lammoiHang";
            this.btn_lammoiHang.Size = new System.Drawing.Size(144, 37);
            this.btn_lammoiHang.TabIndex = 12;
            this.btn_lammoiHang.Text = "Làm Mới";
            this.btn_lammoiHang.UseVisualStyleBackColor = false;
            this.btn_lammoiHang.Click += new System.EventHandler(this.btn_lammoiHang_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(453, 3);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(302, 35);
            this.tbTimKiem.TabIndex = 11;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DataSource = null;
            this.cbbMaKH.FillColor = System.Drawing.Color.White;
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaKH.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbMaKH.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbMaKH.Location = new System.Drawing.Point(287, 59);
            this.cbbMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaKH.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbMaKH.Size = new System.Drawing.Size(150, 29);
            this.cbbMaKH.SymbolSize = 24;
            this.cbbMaKH.TabIndex = 61;
            this.cbbMaKH.Text = "MaKH";
            this.cbbMaKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbMaKH.Watermark = "";
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.OrangeRed;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton2.Location = new System.Drawing.Point(453, 49);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(192, 43);
            this.uiButton2.TabIndex = 62;
            this.uiButton2.Text = "Xem khách hàng";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox1.Location = new System.Drawing.Point(287, 146);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 63;
            this.uiTextBox1.Text = "MaNV";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(676, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "Ngày Đặt";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(806, 56);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(138, 26);
            this.dtpNgayTao.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Khách hàng đang chọn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "Thanh Toán:";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox2.Location = new System.Drawing.Point(287, 226);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox2.TabIndex = 70;
            this.uiTextBox2.Text = "TienTT";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tiền cọc:";
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox3.Location = new System.Drawing.Point(287, 187);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox3.TabIndex = 68;
            this.uiTextBox3.Text = "TienCoc";
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(463, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 73;
            this.label7.Text = "Địa chỉ giao:";
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox4.Location = new System.Drawing.Point(615, 146);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox4.ShowText = false;
            this.uiTextBox4.Size = new System.Drawing.Size(362, 29);
            this.uiTextBox4.TabIndex = 72;
            this.uiTextBox4.Text = "DiaChi";
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox4.Watermark = "";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uiTextBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiTextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.pcSearch);
            this.Controls.Add(this.btn_lammoiHang);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.tsCTPN);
            this.Controls.Add(this.btnThanhToan);
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.tsCTPN.ResumeLayout(false);
            this.tsCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ToolStrip tsCTPN;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Button btnThemSP;
        private Sunny.UI.UIDataGridView dgvHoaDon;
        private Sunny.UI.UITextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.Button btn_lammoiHang;
        private System.Windows.Forms.TextBox tbTimKiem;
        private Sunny.UI.UIComboBox cbbMaKH;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox uiTextBox2;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UITextBox uiTextBox3;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox uiTextBox4;
    }
}