using System;

namespace DACN.GUI
{
    partial class FormDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_DanhMuc = new System.Windows.Forms.TabControl();
            this.tab_HangHoa = new System.Windows.Forms.TabPage();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_qlhh = new System.Windows.Forms.Label();
            this.tab_KhuyenMai = new System.Windows.Forms.TabPage();
            this.tab_NhaCC = new System.Windows.Forms.TabPage();
            this.txt_EmailNCC = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThanhPho = new Sunny.UI.UITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DiaChiNCC = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_QuocGia = new Sunny.UI.UITextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SDTNCC = new Sunny.UI.UITextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNCC = new Sunny.UI.UITextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker_NCC = new System.Windows.Forms.DateTimePicker();
            this.txtMaNCC = new Sunny.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_NCC = new Sunny.UI.UIDataGridView();
            this.tab_KhachHang = new System.Windows.Forms.TabPage();
            this.cbbLoaiKH = new Sunny.UI.UIComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.tsCTPN = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_LoaiKH = new System.Windows.Forms.TabPage();
            this.lb_TenLoai = new System.Windows.Forms.Label();
            this.txt_MaLoaiKH = new Sunny.UI.UITextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_LuuLoaiKH = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_XoaLoaiKH = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SuaLoaiKH = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ThemLoaiKH = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_MaLoai = new System.Windows.Forms.Label();
            this.dgv_LoaiKhachHang = new System.Windows.Forms.DataGridView();
            this.txt_TenLoaiKH = new Sunny.UI.UITextBox();
            this.tab_DanhMuc.SuspendLayout();
            this.tab_HangHoa.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.tab_NhaCC.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.tab_KhachHang.SuspendLayout();
            this.tsCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.tab_LoaiKH.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_DanhMuc
            // 
            this.tab_DanhMuc.Controls.Add(this.tab_HangHoa);
            this.tab_DanhMuc.Controls.Add(this.tab_KhuyenMai);
            this.tab_DanhMuc.Controls.Add(this.tab_NhaCC);
            this.tab_DanhMuc.Controls.Add(this.tab_KhachHang);
            this.tab_DanhMuc.Controls.Add(this.tab_LoaiKH);
            this.tab_DanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_DanhMuc.Location = new System.Drawing.Point(0, 0);
            this.tab_DanhMuc.Name = "tab_DanhMuc";
            this.tab_DanhMuc.SelectedIndex = 0;
            this.tab_DanhMuc.Size = new System.Drawing.Size(1107, 548);
            this.tab_DanhMuc.TabIndex = 1;
            // 
            // tab_HangHoa
            // 
            this.tab_HangHoa.Controls.Add(this.panel_top);
            this.tab_HangHoa.Location = new System.Drawing.Point(4, 25);
            this.tab_HangHoa.Name = "tab_HangHoa";
            this.tab_HangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_HangHoa.Size = new System.Drawing.Size(1099, 519);
            this.tab_HangHoa.TabIndex = 0;
            this.tab_HangHoa.Text = "Hàng Hóa";
            this.tab_HangHoa.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_top.Controls.Add(this.label_qlhh);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_top.Size = new System.Drawing.Size(1093, 64);
            this.panel_top.TabIndex = 0;
            this.panel_top.Resize += new System.EventHandler(this.panel_top_Resize);
            // 
            // label_qlhh
            // 
            this.label_qlhh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_qlhh.AutoSize = true;
            this.label_qlhh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qlhh.ForeColor = System.Drawing.Color.White;
            this.label_qlhh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_qlhh.Location = new System.Drawing.Point(466, 23);
            this.label_qlhh.Name = "label_qlhh";
            this.label_qlhh.Size = new System.Drawing.Size(203, 22);
            this.label_qlhh.TabIndex = 0;
            this.label_qlhh.Text = "QUẢN LÝ HÀNG HÓA";
            this.label_qlhh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_KhuyenMai
            // 
            this.tab_KhuyenMai.Location = new System.Drawing.Point(4, 25);
            this.tab_KhuyenMai.Name = "tab_KhuyenMai";
            this.tab_KhuyenMai.Padding = new System.Windows.Forms.Padding(3);
            this.tab_KhuyenMai.Size = new System.Drawing.Size(1099, 519);
            this.tab_KhuyenMai.TabIndex = 1;
            this.tab_KhuyenMai.Text = "Khuyến Mãi";
            this.tab_KhuyenMai.UseVisualStyleBackColor = true;
            // 
            // tab_NhaCC
            // 
            this.tab_NhaCC.Controls.Add(this.txt_EmailNCC);
            this.tab_NhaCC.Controls.Add(this.label8);
            this.tab_NhaCC.Controls.Add(this.txtThanhPho);
            this.tab_NhaCC.Controls.Add(this.label9);
            this.tab_NhaCC.Controls.Add(this.txt_DiaChiNCC);
            this.tab_NhaCC.Controls.Add(this.label10);
            this.tab_NhaCC.Controls.Add(this.txt_QuocGia);
            this.tab_NhaCC.Controls.Add(this.label11);
            this.tab_NhaCC.Controls.Add(this.txt_SDTNCC);
            this.tab_NhaCC.Controls.Add(this.label12);
            this.tab_NhaCC.Controls.Add(this.txtTenNCC);
            this.tab_NhaCC.Controls.Add(this.label13);
            this.tab_NhaCC.Controls.Add(this.dateTimePicker_NCC);
            this.tab_NhaCC.Controls.Add(this.txtMaNCC);
            this.tab_NhaCC.Controls.Add(this.label14);
            this.tab_NhaCC.Controls.Add(this.toolStrip1);
            this.tab_NhaCC.Controls.Add(this.dgv_NCC);
            this.tab_NhaCC.Location = new System.Drawing.Point(4, 25);
            this.tab_NhaCC.Name = "tab_NhaCC";
            this.tab_NhaCC.Size = new System.Drawing.Size(1099, 519);
            this.tab_NhaCC.TabIndex = 2;
            this.tab_NhaCC.Text = "Nhà Cung Cấp";
            this.tab_NhaCC.UseVisualStyleBackColor = true;
            // 
            // txt_EmailNCC
            // 
            this.txt_EmailNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmailNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_EmailNCC.Location = new System.Drawing.Point(116, 235);
            this.txt_EmailNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmailNCC.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_EmailNCC.Name = "txt_EmailNCC";
            this.txt_EmailNCC.Padding = new System.Windows.Forms.Padding(4);
            this.txt_EmailNCC.ShowText = false;
            this.txt_EmailNCC.Size = new System.Drawing.Size(133, 23);
            this.txt_EmailNCC.TabIndex = 50;
            this.txt_EmailNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_EmailNCC.Watermark = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Email";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhPho.Location = new System.Drawing.Point(681, 187);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPho.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Padding = new System.Windows.Forms.Padding(4);
            this.txtThanhPho.ShowText = false;
            this.txtThanhPho.Size = new System.Drawing.Size(133, 23);
            this.txtThanhPho.TabIndex = 48;
            this.txtThanhPho.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThanhPho.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Thành Phố";
            // 
            // txt_DiaChiNCC
            // 
            this.txt_DiaChiNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChiNCC.Location = new System.Drawing.Point(670, 119);
            this.txt_DiaChiNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChiNCC.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_DiaChiNCC.Name = "txt_DiaChiNCC";
            this.txt_DiaChiNCC.Padding = new System.Windows.Forms.Padding(4);
            this.txt_DiaChiNCC.ShowText = false;
            this.txt_DiaChiNCC.Size = new System.Drawing.Size(133, 23);
            this.txt_DiaChiNCC.TabIndex = 41;
            this.txt_DiaChiNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_DiaChiNCC.Watermark = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(598, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Địa chỉ";
            // 
            // txt_QuocGia
            // 
            this.txt_QuocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_QuocGia.Location = new System.Drawing.Point(393, 180);
            this.txt_QuocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuocGia.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_QuocGia.Name = "txt_QuocGia";
            this.txt_QuocGia.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QuocGia.ShowText = false;
            this.txt_QuocGia.Size = new System.Drawing.Size(133, 23);
            this.txt_QuocGia.TabIndex = 46;
            this.txt_QuocGia.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_QuocGia.Watermark = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Quốc Gia";
            // 
            // txt_SDTNCC
            // 
            this.txt_SDTNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDTNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SDTNCC.Location = new System.Drawing.Point(393, 119);
            this.txt_SDTNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDTNCC.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_SDTNCC.Name = "txt_SDTNCC";
            this.txt_SDTNCC.Padding = new System.Windows.Forms.Padding(4);
            this.txt_SDTNCC.ShowText = false;
            this.txt_SDTNCC.Size = new System.Drawing.Size(133, 23);
            this.txt_SDTNCC.TabIndex = 40;
            this.txt_SDTNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_SDTNCC.Watermark = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "SDT";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(145, 180);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Padding = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.ShowText = false;
            this.txtTenNCC.Size = new System.Drawing.Size(133, 23);
            this.txtTenNCC.TabIndex = 44;
            this.txtTenNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenNCC.Watermark = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Tên Nhà Cung Cấp";
            // 
            // dateTimePicker_NCC
            // 
            this.dateTimePicker_NCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_NCC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NCC.Location = new System.Drawing.Point(871, 119);
            this.dateTimePicker_NCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_NCC.Name = "dateTimePicker_NCC";
            this.dateTimePicker_NCC.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker_NCC.TabIndex = 42;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNCC.Location = new System.Drawing.Point(116, 119);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Padding = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.ShowText = false;
            this.txtMaNCC.Size = new System.Drawing.Size(133, 23);
            this.txtMaNCC.TabIndex = 37;
            this.txtMaNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaNCC.Watermark = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Mã Nhà CC";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator3,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator5,
            this.btnLuu,
            this.toolStripSeparator1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1099, 38);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "tsNCC";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::DACN.Properties.Resources.Add;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(104, 34);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::DACN.Properties.Resources.Edit;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(89, 34);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::DACN.Properties.Resources.Delete;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXoa.Size = new System.Drawing.Size(90, 34);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::DACN.Properties.Resources.Save;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLuu.Size = new System.Drawing.Size(88, 34);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // dgv_NCC
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_NCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_NCC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_NCC.ColumnHeadersHeight = 32;
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_NCC.EnableHeadersVisualStyles = false;
            this.dgv_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_NCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_NCC.Location = new System.Drawing.Point(0, 268);
            this.dgv_NCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NCC.Name = "dgv_NCC";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_NCC.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_NCC.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_NCC.RowTemplate.Height = 28;
            this.dgv_NCC.SelectedIndex = -1;
            this.dgv_NCC.Size = new System.Drawing.Size(994, 178);
            this.dgv_NCC.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_NCC.TabIndex = 34;
            this.dgv_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_CellClick);
            // 
            // tab_KhachHang
            // 
            this.tab_KhachHang.Controls.Add(this.cbbLoaiKH);
            this.tab_KhachHang.Controls.Add(this.label7);
            this.tab_KhachHang.Controls.Add(this.label6);
            this.tab_KhachHang.Controls.Add(this.label5);
            this.tab_KhachHang.Controls.Add(this.label4);
            this.tab_KhachHang.Controls.Add(this.label3);
            this.tab_KhachHang.Controls.Add(this.label2);
            this.tab_KhachHang.Controls.Add(this.label1);
            this.tab_KhachHang.Controls.Add(this.txtSDT);
            this.tab_KhachHang.Controls.Add(this.txtDiaChi);
            this.tab_KhachHang.Controls.Add(this.txtEmail);
            this.tab_KhachHang.Controls.Add(this.txtTenKH);
            this.tab_KhachHang.Controls.Add(this.txtMK);
            this.tab_KhachHang.Controls.Add(this.tsCTPN);
            this.tab_KhachHang.Controls.Add(this.dtpNgayTao);
            this.tab_KhachHang.Controls.Add(this.dgv_KH);
            this.tab_KhachHang.Location = new System.Drawing.Point(4, 25);
            this.tab_KhachHang.Name = "tab_KhachHang";
            this.tab_KhachHang.Size = new System.Drawing.Size(1099, 519);
            this.tab_KhachHang.TabIndex = 3;
            this.tab_KhachHang.Text = "KhachHang";
            this.tab_KhachHang.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiKH
            // 
            this.cbbLoaiKH.DataSource = null;
            this.cbbLoaiKH.FillColor = System.Drawing.Color.White;
            this.cbbLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLoaiKH.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbLoaiKH.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbLoaiKH.Location = new System.Drawing.Point(847, 170);
            this.cbbLoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiKH.MinimumSize = new System.Drawing.Size(56, 0);
            this.cbbLoaiKH.Name = "cbbLoaiKH";
            this.cbbLoaiKH.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbLoaiKH.Size = new System.Drawing.Size(219, 23);
            this.cbbLoaiKH.SymbolSize = 24;
            this.cbbLoaiKH.TabIndex = 41;
            this.cbbLoaiKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbLoaiKH.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Loại Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(865, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ngày Tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Khách ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(417, 113);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 22);
            this.txtSDT.TabIndex = 32;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(417, 177);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(194, 22);
            this.txtDiaChi.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(642, 113);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 22);
            this.txtEmail.TabIndex = 30;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(153, 177);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(169, 22);
            this.txtTenKH.TabIndex = 29;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(123, 113);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(169, 22);
            this.txtMK.TabIndex = 28;
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
            this.toolStripSeparator7,
            this.tsbLuu,
            this.toolStripSeparator8});
            this.tsCTPN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsCTPN.Location = new System.Drawing.Point(0, 0);
            this.tsCTPN.Name = "tsCTPN";
            this.tsCTPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCTPN.Size = new System.Drawing.Size(1099, 38);
            this.tsCTPN.TabIndex = 27;
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
            this.tsbThem.Size = new System.Drawing.Size(104, 34);
            this.tsbThem.Text = "Thêm";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::DACN.Properties.Resources.Edit;
            this.tsbSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSua.Size = new System.Drawing.Size(89, 34);
            this.tsbSua.Text = "Sửa";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::DACN.Properties.Resources.Delete;
            this.tsbXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoa.Size = new System.Drawing.Size(90, 34);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::DACN.Properties.Resources.Save;
            this.tsbLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuu.Size = new System.Drawing.Size(88, 34);
            this.tsbLuu.Text = "Lưu";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(933, 114);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(123, 22);
            this.dtpNgayTao.TabIndex = 40;
            // 
            // dgv_KH
            // 
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.NgayTao});
            this.dgv_KH.Location = new System.Drawing.Point(8, 224);
            this.dgv_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.RowHeadersWidth = 62;
            this.dgv_KH.RowTemplate.Height = 28;
            this.dgv_KH.Size = new System.Drawing.Size(1094, 247);
            this.dgv_KH.TabIndex = 26;
            this.dgv_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KH_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.MinimumWidth = 8;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 150;
            // 
            // TENKH
            // 
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.MinimumWidth = 8;
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 150;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // NgayTao
            // 
            this.NgayTao.HeaderText = "Ngày Tạo";
            this.NgayTao.MinimumWidth = 8;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.Width = 150;
            // 
            // tab_LoaiKH
            // 
            this.tab_LoaiKH.Controls.Add(this.txt_TenLoaiKH);
            this.tab_LoaiKH.Controls.Add(this.lb_TenLoai);
            this.tab_LoaiKH.Controls.Add(this.txt_MaLoaiKH);
            this.tab_LoaiKH.Controls.Add(this.toolStrip2);
            this.tab_LoaiKH.Controls.Add(this.lb_MaLoai);
            this.tab_LoaiKH.Controls.Add(this.dgv_LoaiKhachHang);
            this.tab_LoaiKH.Location = new System.Drawing.Point(4, 25);
            this.tab_LoaiKH.Name = "tab_LoaiKH";
            this.tab_LoaiKH.Size = new System.Drawing.Size(1099, 519);
            this.tab_LoaiKH.TabIndex = 4;
            this.tab_LoaiKH.Text = "Loại khách hàng";
            this.tab_LoaiKH.UseVisualStyleBackColor = true;
            // 
            // lb_TenLoai
            // 
            this.lb_TenLoai.AutoSize = true;
            this.lb_TenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_TenLoai.Location = new System.Drawing.Point(332, 163);
            this.lb_TenLoai.Name = "lb_TenLoai";
            this.lb_TenLoai.Size = new System.Drawing.Size(94, 25);
            this.lb_TenLoai.TabIndex = 20;
            this.lb_TenLoai.Text = "Tên Loại ";
            // 
            // txt_MaLoaiKH
            // 
            this.txt_MaLoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaLoaiKH.Location = new System.Drawing.Point(154, 160);
            this.txt_MaLoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiKH.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_MaLoaiKH.Name = "txt_MaLoaiKH";
            this.txt_MaLoaiKH.Padding = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiKH.ShowText = false;
            this.txt_MaLoaiKH.Size = new System.Drawing.Size(133, 31);
            this.txt_MaLoaiKH.TabIndex = 17;
            this.txt_MaLoaiKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MaLoaiKH.Watermark = "";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_LuuLoaiKH
            // 
            this.btn_LuuLoaiKH.Image = global::DACN.Properties.Resources.Save;
            this.btn_LuuLoaiKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_LuuLoaiKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LuuLoaiKH.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_LuuLoaiKH.Name = "btn_LuuLoaiKH";
            this.btn_LuuLoaiKH.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_LuuLoaiKH.Size = new System.Drawing.Size(88, 34);
            this.btn_LuuLoaiKH.Text = "Lưu";
            this.btn_LuuLoaiKH.Click += new System.EventHandler(this.btn_LuuLoaiKH_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_XoaLoaiKH
            // 
            this.btn_XoaLoaiKH.Image = global::DACN.Properties.Resources.Delete;
            this.btn_XoaLoaiKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_XoaLoaiKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaLoaiKH.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_XoaLoaiKH.Name = "btn_XoaLoaiKH";
            this.btn_XoaLoaiKH.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_XoaLoaiKH.Size = new System.Drawing.Size(90, 34);
            this.btn_XoaLoaiKH.Text = "Xóa";
            this.btn_XoaLoaiKH.Click += new System.EventHandler(this.btn_XoaLoaiKH_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_SuaLoaiKH
            // 
            this.btn_SuaLoaiKH.Image = global::DACN.Properties.Resources.Edit;
            this.btn_SuaLoaiKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_SuaLoaiKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaLoaiKH.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_SuaLoaiKH.Name = "btn_SuaLoaiKH";
            this.btn_SuaLoaiKH.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_SuaLoaiKH.Size = new System.Drawing.Size(89, 34);
            this.btn_SuaLoaiKH.Text = "Sửa";
            this.btn_SuaLoaiKH.Click += new System.EventHandler(this.btn_SuaLoaiKH_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_ThemLoaiKH
            // 
            this.btn_ThemLoaiKH.Image = global::DACN.Properties.Resources.Add;
            this.btn_ThemLoaiKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ThemLoaiKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemLoaiKH.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btn_ThemLoaiKH.Name = "btn_ThemLoaiKH";
            this.btn_ThemLoaiKH.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_ThemLoaiKH.Size = new System.Drawing.Size(104, 34);
            this.btn_ThemLoaiKH.Text = "Thêm";
            this.btn_ThemLoaiKH.Click += new System.EventHandler(this.btn_ThemLoaiKH_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemLoaiKH,
            this.toolStripSeparator13,
            this.btn_SuaLoaiKH,
            this.toolStripSeparator12,
            this.btn_XoaLoaiKH,
            this.toolStripSeparator11,
            this.btn_LuuLoaiKH,
            this.toolStripSeparator9});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1099, 38);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "tsNCC";
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.HeaderText = "Tên Loại Khách Hàng";
            this.TenLoaiKH.MinimumWidth = 8;
            this.TenLoaiKH.Name = "TenLoaiKH";
            this.TenLoaiKH.Width = 150;
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Mã Loại KH";
            this.LoaiKH.MinimumWidth = 8;
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.Width = 150;
            // 
            // lb_MaLoai
            // 
            this.lb_MaLoai.AutoSize = true;
            this.lb_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_MaLoai.Location = new System.Drawing.Point(55, 163);
            this.lb_MaLoai.Name = "lb_MaLoai";
            this.lb_MaLoai.Size = new System.Drawing.Size(87, 25);
            this.lb_MaLoai.TabIndex = 19;
            this.lb_MaLoai.Text = "Mã Loại ";
            // 
            // dgv_LoaiKhachHang
            // 
            this.dgv_LoaiKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiKH,
            this.TenLoaiKH});
            this.dgv_LoaiKhachHang.Location = new System.Drawing.Point(11, 231);
            this.dgv_LoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiKhachHang.Name = "dgv_LoaiKhachHang";
            this.dgv_LoaiKhachHang.RowHeadersWidth = 62;
            this.dgv_LoaiKhachHang.RowTemplate.Height = 28;
            this.dgv_LoaiKhachHang.Size = new System.Drawing.Size(765, 203);
            this.dgv_LoaiKhachHang.TabIndex = 15;
            // 
            // txt_TenLoaiKH
            // 
            this.txt_TenLoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenLoaiKH.Location = new System.Drawing.Point(468, 163);
            this.txt_TenLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenLoaiKH.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_TenLoaiKH.Name = "txt_TenLoaiKH";
            this.txt_TenLoaiKH.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TenLoaiKH.ShowText = false;
            this.txt_TenLoaiKH.Size = new System.Drawing.Size(150, 29);
            this.txt_TenLoaiKH.TabIndex = 21;
            this.txt_TenLoaiKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TenLoaiKH.Watermark = "";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 548);
            this.Controls.Add(this.tab_DanhMuc);
            this.Name = "FormDanhMuc";
            this.Text = "FormDanhMuc";
            this.tab_DanhMuc.ResumeLayout(false);
            this.tab_HangHoa.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.tab_NhaCC.ResumeLayout(false);
            this.tab_NhaCC.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.tab_KhachHang.ResumeLayout(false);
            this.tab_KhachHang.PerformLayout();
            this.tsCTPN.ResumeLayout(false);
            this.tsCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.tab_LoaiKH.ResumeLayout(false);
            this.tab_LoaiKH.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_DanhMuc;
        private System.Windows.Forms.TabPage tab_HangHoa;
        private System.Windows.Forms.TabPage tab_KhuyenMai;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_qlhh;
        private System.Windows.Forms.TabPage tab_NhaCC;
        private System.Windows.Forms.TabPage tab_KhachHang;
        private Sunny.UI.UIComboBox cbbLoaiKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.ToolStrip tsCTPN;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.DataGridView dgv_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox txtThanhPho;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UITextBox txt_DiaChiNCC;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox txt_QuocGia;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UITextBox txt_SDTNCC;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox txtTenNCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NCC;
        private Sunny.UI.UITextBox txtMaNCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Sunny.UI.UIDataGridView dgv_NCC;
        private Sunny.UI.UITextBox txt_EmailNCC;
        private System.Windows.Forms.TabPage tab_LoaiKH;
        private Sunny.UI.UITextBox txt_TenLoaiKH;
        private System.Windows.Forms.Label lb_TenLoai;
        private Sunny.UI.UITextBox txt_MaLoaiKH;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_ThemLoaiKH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btn_SuaLoaiKH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btn_XoaLoaiKH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btn_LuuLoaiKH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label lb_MaLoai;
        private System.Windows.Forms.DataGridView dgv_LoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
    }
}