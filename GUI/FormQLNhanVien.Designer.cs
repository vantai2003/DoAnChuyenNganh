namespace DACN.GUI
{
    partial class FormQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            this.btn_reload = new Sunny.UI.UIButton();
            this.btn_Search = new Sunny.UI.UIButton();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.txt_HoTen = new Sunny.UI.UITextBox();
            this.dvg_NhanVien = new Sunny.UI.UIDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_MaNV = new Sunny.UI.UITextBox();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_chucvu = new System.Windows.Forms.Label();
            this.lb_namenv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.pane_body = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dtp_NgayTD = new System.Windows.Forms.DateTimePicker();
            this.txt_ChuVu = new Sunny.UI.UITextBox();
            this.txt_Luong = new Sunny.UI.UITextBox();
            this.txt_Email = new Sunny.UI.UITextBox();
            this.lb_luong = new System.Windows.Forms.Label();
            this.lb_ntd = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_sdt = new Sunny.UI.UITextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.pane_body.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_reload.Location = new System.Drawing.Point(691, 33);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Radius = 25;
            this.btn_reload.Size = new System.Drawing.Size(115, 44);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FillDisableColor = System.Drawing.Color.Cyan;
            this.btn_Search.FillHoverColor = System.Drawing.Color.Fuchsia;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Search.LightColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(337, 28);
            this.btn_Search.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Radius = 15;
            this.btn_Search.RectColor = System.Drawing.Color.Lime;
            this.btn_Search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Search.Size = new System.Drawing.Size(100, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.ButtonRectHoverColor = System.Drawing.Color.Gray;
            this.txt_Search.ButtonStyleInherited = false;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Search.Location = new System.Drawing.Point(57, 28);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Search.ShowText = false;
            this.txt_Search.Size = new System.Drawing.Size(259, 35);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Search.Watermark = "";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_HoTen.Location = new System.Drawing.Point(181, 77);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HoTen.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Padding = new System.Windows.Forms.Padding(5);
            this.txt_HoTen.RectColor = System.Drawing.Color.Red;
            this.txt_HoTen.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.txt_HoTen.ScrollBarStyleInherited = false;
            this.txt_HoTen.ShowText = false;
            this.txt_HoTen.Size = new System.Drawing.Size(185, 29);
            this.txt_HoTen.TabIndex = 9;
            this.txt_HoTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_HoTen.Watermark = "";
            // 
            // dvg_NhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dvg_NhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_NhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_NhanVien.EnableHeadersVisualStyles = false;
            this.dvg_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_NhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dvg_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dvg_NhanVien.Name = "dvg_NhanVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_NhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_NhanVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_NhanVien.RowTemplate.Height = 24;
            this.dvg_NhanVien.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.dvg_NhanVien.ScrollBarRectColor = System.Drawing.Color.Fuchsia;
            this.dvg_NhanVien.ScrollBarStyleInherited = false;
            this.dvg_NhanVien.SelectedIndex = -1;
            this.dvg_NhanVien.Size = new System.Drawing.Size(1187, 298);
            this.dvg_NhanVien.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NhanVien.TabIndex = 0;
            this.dvg_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_NhanVien_CellClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dvg_NhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 298);
            this.panel2.TabIndex = 3;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MaNV.Location = new System.Drawing.Point(181, 19);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaNV.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MaNV.RectColor = System.Drawing.Color.Red;
            this.txt_MaNV.ShowText = false;
            this.txt_MaNV.Size = new System.Drawing.Size(185, 29);
            this.txt_MaNV.TabIndex = 8;
            this.txt_MaNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MaNV.Watermark = "";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BackColor = System.Drawing.Color.Transparent;
            this.lb_sdt.Location = new System.Drawing.Point(21, 197);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(126, 25);
            this.lb_sdt.TabIndex = 3;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.AutoSize = true;
            this.lb_chucvu.BackColor = System.Drawing.Color.Transparent;
            this.lb_chucvu.Location = new System.Drawing.Point(21, 135);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(85, 25);
            this.lb_chucvu.TabIndex = 2;
            this.lb_chucvu.Text = "Chức vụ";
            // 
            // lb_namenv
            // 
            this.lb_namenv.AutoSize = true;
            this.lb_namenv.BackColor = System.Drawing.Color.Transparent;
            this.lb_namenv.Location = new System.Drawing.Point(21, 77);
            this.lb_namenv.Name = "lb_namenv";
            this.lb_namenv.Size = new System.Drawing.Size(137, 25);
            this.lb_namenv.TabIndex = 1;
            this.lb_namenv.Text = "Tên nhân viên";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.BackColor = System.Drawing.Color.Transparent;
            this.lb_manv.Location = new System.Drawing.Point(21, 23);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(130, 25);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // pane_body
            // 
            this.pane_body.Controls.Add(this.panel2);
            this.pane_body.Controls.Add(this.uiPanel2);
            this.pane_body.Controls.Add(this.panel1);
            this.pane_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pane_body.Location = new System.Drawing.Point(0, 0);
            this.pane_body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pane_body.MinimumSize = new System.Drawing.Size(1, 1);
            this.pane_body.Name = "pane_body";
            this.pane_body.Size = new System.Drawing.Size(1187, 711);
            this.pane_body.TabIndex = 2;
            this.pane_body.Text = null;
            this.pane_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.White;
            this.uiPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiPanel2.Controls.Add(this.dtp_NgayTD);
            this.uiPanel2.Controls.Add(this.txt_ChuVu);
            this.uiPanel2.Controls.Add(this.txt_Luong);
            this.uiPanel2.Controls.Add(this.txt_Email);
            this.uiPanel2.Controls.Add(this.lb_luong);
            this.uiPanel2.Controls.Add(this.lb_ntd);
            this.uiPanel2.Controls.Add(this.lb_email);
            this.uiPanel2.Controls.Add(this.txt_sdt);
            this.uiPanel2.Controls.Add(this.btnLuu);
            this.uiPanel2.Controls.Add(this.btnThem);
            this.uiPanel2.Controls.Add(this.btn_Sua);
            this.uiPanel2.Controls.Add(this.btn_Xoa);
            this.uiPanel2.Controls.Add(this.txt_HoTen);
            this.uiPanel2.Controls.Add(this.txt_MaNV);
            this.uiPanel2.Controls.Add(this.lb_sdt);
            this.uiPanel2.Controls.Add(this.lb_chucvu);
            this.uiPanel2.Controls.Add(this.lb_namenv);
            this.uiPanel2.Controls.Add(this.lb_manv);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 398);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1187, 313);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_NgayTD
            // 
            this.dtp_NgayTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_NgayTD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTD.Location = new System.Drawing.Point(583, 76);
            this.dtp_NgayTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayTD.Name = "dtp_NgayTD";
            this.dtp_NgayTD.Size = new System.Drawing.Size(149, 30);
            this.dtp_NgayTD.TabIndex = 60;
            // 
            // txt_ChuVu
            // 
            this.txt_ChuVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChuVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ChuVu.Location = new System.Drawing.Point(181, 141);
            this.txt_ChuVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ChuVu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ChuVu.Name = "txt_ChuVu";
            this.txt_ChuVu.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ChuVu.RectColor = System.Drawing.Color.Red;
            this.txt_ChuVu.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.txt_ChuVu.ScrollBarStyleInherited = false;
            this.txt_ChuVu.ShowText = false;
            this.txt_ChuVu.Size = new System.Drawing.Size(185, 29);
            this.txt_ChuVu.TabIndex = 59;
            this.txt_ChuVu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ChuVu.Watermark = "";
            // 
            // txt_Luong
            // 
            this.txt_Luong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Luong.Location = new System.Drawing.Point(505, 131);
            this.txt_Luong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Luong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Luong.Name = "txt_Luong";
            this.txt_Luong.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Luong.RectColor = System.Drawing.Color.Red;
            this.txt_Luong.ShowText = false;
            this.txt_Luong.Size = new System.Drawing.Size(227, 29);
            this.txt_Luong.TabIndex = 58;
            this.txt_Luong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Luong.Watermark = "";
            // 
            // txt_Email
            // 
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Email.Location = new System.Drawing.Point(505, 23);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Email.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Email.RectColor = System.Drawing.Color.Red;
            this.txt_Email.ShowText = false;
            this.txt_Email.Size = new System.Drawing.Size(227, 29);
            this.txt_Email.TabIndex = 56;
            this.txt_Email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Email.Watermark = "";
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.BackColor = System.Drawing.Color.Transparent;
            this.lb_luong.Location = new System.Drawing.Point(417, 135);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(67, 25);
            this.lb_luong.TabIndex = 55;
            this.lb_luong.Text = "Lương";
            // 
            // lb_ntd
            // 
            this.lb_ntd.AutoSize = true;
            this.lb_ntd.BackColor = System.Drawing.Color.Transparent;
            this.lb_ntd.Location = new System.Drawing.Point(417, 77);
            this.lb_ntd.Name = "lb_ntd";
            this.lb_ntd.Size = new System.Drawing.Size(160, 25);
            this.lb_ntd.TabIndex = 54;
            this.lb_ntd.Text = "Ngày tuyển dụng";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.BackColor = System.Drawing.Color.Transparent;
            this.lb_email.Location = new System.Drawing.Point(417, 23);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(60, 25);
            this.lb_email.TabIndex = 53;
            this.lb_email.Text = "Email";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_sdt.Location = new System.Drawing.Point(181, 197);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sdt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Padding = new System.Windows.Forms.Padding(5);
            this.txt_sdt.RectColor = System.Drawing.Color.Red;
            this.txt_sdt.ShowText = false;
            this.txt_sdt.Size = new System.Drawing.Size(185, 29);
            this.txt_sdt.TabIndex = 52;
            this.txt_sdt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_sdt.Watermark = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.uiGroupBox1);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 100);
            this.panel1.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txt_Search);
            this.uiGroupBox1.Controls.Add(this.btn_Search);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(72, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(494, 78);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "Tìm kiếm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::DACN.Properties.Resources.icons8_save_50__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(873, 217);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 60);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(873, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 56);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(873, 144);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 58);
            this.btn_Sua.TabIndex = 49;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(873, 72);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 61);
            this.btn_Xoa.TabIndex = 48;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 711);
            this.Controls.Add(this.pane_body);
            this.Name = "FormQLNhanVien";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pane_body.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btn_reload;
        private Sunny.UI.UIButton btn_Search;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private Sunny.UI.UITextBox txt_HoTen;
        private Sunny.UI.UIDataGridView dvg_NhanVien;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UITextBox txt_MaNV;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_chucvu;
        private System.Windows.Forms.Label lb_namenv;
        private System.Windows.Forms.Label lb_manv;
        private Sunny.UI.UIPanel pane_body;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_luong;
        private System.Windows.Forms.Label lb_ntd;
        private System.Windows.Forms.Label lb_email;
        private Sunny.UI.UITextBox txt_sdt;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Sunny.UI.UITextBox txt_Luong;
        private Sunny.UI.UITextBox txt_Email;
        private Sunny.UI.UITextBox txt_ChuVu;
        private System.Windows.Forms.DateTimePicker dtp_NgayTD;
        private Sunny.UI.UIGroupBox uiGroupBox1;
    }
}