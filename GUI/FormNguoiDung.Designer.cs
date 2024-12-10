namespace DACN.GUI
{
    partial class FormNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNguoiDung));
            this.pane_body = new Sunny.UI.UIPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvg_NguoiDung = new Sunny.UI.UIDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.btn_reload = new Sunny.UI.UIButton();
            this.lb_userName = new System.Windows.Forms.Label();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.txt_pass = new Sunny.UI.UITextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.cb_vitrilv = new Sunny.UI.UIComboBox();
            this.lb_vtlv = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.ts_Them = new System.Windows.Forms.ToolStripButton();
            this.ts_Xoa = new System.Windows.Forms.ToolStripButton();
            this.ts_Sua = new System.Windows.Forms.ToolStripButton();
            this.ts_Luu = new System.Windows.Forms.ToolStripButton();
            this.ts_LamMoi = new System.Windows.Forms.ToolStripButton();
            this.pane_body.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane_body
            // 
            this.pane_body.Controls.Add(this.panel2);
            this.pane_body.Controls.Add(this.panel1);
            this.pane_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pane_body.Location = new System.Drawing.Point(0, 0);
            this.pane_body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pane_body.MinimumSize = new System.Drawing.Size(1, 1);
            this.pane_body.Name = "pane_body";
            this.pane_body.Size = new System.Drawing.Size(1039, 736);
            this.pane_body.TabIndex = 1;
            this.pane_body.Text = null;
            this.pane_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dvg_NguoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 400);
            this.panel2.TabIndex = 3;
            // 
            // dvg_NguoiDung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_NguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_NguoiDung.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dvg_NguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_NguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_NguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_NguoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_NguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_NguoiDung.EnableHeadersVisualStyles = false;
            this.dvg_NguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_NguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dvg_NguoiDung.Location = new System.Drawing.Point(0, 0);
            this.dvg_NguoiDung.Name = "dvg_NguoiDung";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_NguoiDung.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_NguoiDung.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_NguoiDung.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_NguoiDung.RowTemplate.Height = 24;
            this.dvg_NguoiDung.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.dvg_NguoiDung.ScrollBarRectColor = System.Drawing.Color.Fuchsia;
            this.dvg_NguoiDung.ScrollBarStyleInherited = false;
            this.dvg_NguoiDung.SelectedIndex = -1;
            this.dvg_NguoiDung.Size = new System.Drawing.Size(1039, 400);
            this.dvg_NguoiDung.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.TabIndex = 0;
            this.dvg_NguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_NguoiDung_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_Tim);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.cb_NhanVien);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.lb_pass);
            this.panel1.Controls.Add(this.cb_vitrilv);
            this.panel1.Controls.Add(this.lb_vtlv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 336);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.ts_Them,
            this.toolStripSeparator2,
            this.ts_Xoa,
            this.toolStripSeparator5,
            this.ts_Sua,
            this.toolStripSeparator1,
            this.ts_Luu,
            this.toolStripSeparator4,
            this.ts_LamMoi});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1039, 58);
            this.toolStrip1.TabIndex = 56;
            this.toolStrip1.Text = "tsNCC";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(271, 64);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(199, 33);
            this.cb_NhanVien.TabIndex = 53;
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_reload.Location = new System.Drawing.Point(1251, 261);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Radius = 25;
            this.btn_reload.Size = new System.Drawing.Size(115, 35);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.BackColor = System.Drawing.Color.Transparent;
            this.lb_userName.Location = new System.Drawing.Point(45, 72);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(145, 25);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "Tên đăng nhập";
            // 
            // txt_Search
            // 
            this.txt_Search.ButtonRectHoverColor = System.Drawing.Color.Gray;
            this.txt_Search.ButtonStyleInherited = false;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Search.Location = new System.Drawing.Point(158, 236);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Search.ShowText = false;
            this.txt_Search.Size = new System.Drawing.Size(298, 35);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Search.Watermark = "";
            // 
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_pass.Location = new System.Drawing.Point(271, 117);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(5);
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.RectColor = System.Drawing.Color.Red;
            this.txt_pass.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.txt_pass.ScrollBarStyleInherited = false;
            this.txt_pass.ShowText = false;
            this.txt_pass.Size = new System.Drawing.Size(199, 29);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_pass.Watermark = "";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_pass.Enabled = false;
            this.lb_pass.Location = new System.Drawing.Point(45, 117);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(93, 25);
            this.lb_pass.TabIndex = 1;
            this.lb_pass.Text = "Mật khẩu";
            // 
            // cb_vitrilv
            // 
            this.cb_vitrilv.DataSource = null;
            this.cb_vitrilv.FillColor = System.Drawing.Color.White;
            this.cb_vitrilv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_vitrilv.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cb_vitrilv.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cb_vitrilv.Location = new System.Drawing.Point(271, 173);
            this.cb_vitrilv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_vitrilv.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_vitrilv.Name = "cb_vitrilv";
            this.cb_vitrilv.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_vitrilv.RectColor = System.Drawing.Color.Red;
            this.cb_vitrilv.Size = new System.Drawing.Size(199, 29);
            this.cb_vitrilv.SymbolSize = 24;
            this.cb_vitrilv.TabIndex = 7;
            this.cb_vitrilv.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_vitrilv.Watermark = "";
            // 
            // lb_vtlv
            // 
            this.lb_vtlv.AutoSize = true;
            this.lb_vtlv.BackColor = System.Drawing.Color.Transparent;
            this.lb_vtlv.Location = new System.Drawing.Point(45, 173);
            this.lb_vtlv.Name = "lb_vtlv";
            this.lb_vtlv.Size = new System.Drawing.Size(126, 25);
            this.lb_vtlv.TabIndex = 3;
            this.lb_vtlv.Text = "Vị trí làm việc";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Tim.Image = global::DACN.Properties.Resources.icons8_search_55;
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(463, 221);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(165, 62);
            this.btn_Tim.TabIndex = 57;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // ts_Them
            // 
            this.ts_Them.BackColor = System.Drawing.Color.PeachPuff;
            this.ts_Them.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Them.ForeColor = System.Drawing.Color.Black;
            this.ts_Them.Image = global::DACN.Properties.Resources.icons8_add_1001;
            this.ts_Them.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Them.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ts_Them.Name = "ts_Them";
            this.ts_Them.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ts_Them.Size = new System.Drawing.Size(135, 54);
            this.ts_Them.Text = "Thêm";
            this.ts_Them.Click += new System.EventHandler(this.ts_Them_Click);
            // 
            // ts_Xoa
            // 
            this.ts_Xoa.BackColor = System.Drawing.Color.PeachPuff;
            this.ts_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("ts_Xoa.Image")));
            this.ts_Xoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Xoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ts_Xoa.Name = "ts_Xoa";
            this.ts_Xoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ts_Xoa.Size = new System.Drawing.Size(116, 54);
            this.ts_Xoa.Text = "Xóa";
            this.ts_Xoa.Click += new System.EventHandler(this.ts_Xoa_Click);
            // 
            // ts_Sua
            // 
            this.ts_Sua.BackColor = System.Drawing.Color.PeachPuff;
            this.ts_Sua.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Sua.Image = ((System.Drawing.Image)(resources.GetObject("ts_Sua.Image")));
            this.ts_Sua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Sua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ts_Sua.Name = "ts_Sua";
            this.ts_Sua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ts_Sua.Size = new System.Drawing.Size(116, 54);
            this.ts_Sua.Text = "Sửa";
            this.ts_Sua.Click += new System.EventHandler(this.ts_Sua_Click);
            // 
            // ts_Luu
            // 
            this.ts_Luu.BackColor = System.Drawing.Color.PeachPuff;
            this.ts_Luu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Luu.Image = global::DACN.Properties.Resources.icons8_save_501;
            this.ts_Luu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Luu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ts_Luu.Name = "ts_Luu";
            this.ts_Luu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ts_Luu.Size = new System.Drawing.Size(116, 54);
            this.ts_Luu.Text = "Lưu";
            this.ts_Luu.Click += new System.EventHandler(this.ts_Luu_Click);
            // 
            // ts_LamMoi
            // 
            this.ts_LamMoi.BackColor = System.Drawing.Color.PeachPuff;
            this.ts_LamMoi.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("ts_LamMoi.Image")));
            this.ts_LamMoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_LamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_LamMoi.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ts_LamMoi.Name = "ts_LamMoi";
            this.ts_LamMoi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ts_LamMoi.Size = new System.Drawing.Size(166, 54);
            this.ts_LamMoi.Text = "Làm mới";
            this.ts_LamMoi.Click += new System.EventHandler(this.ts_LamMoi_Click);
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 736);
            this.Controls.Add(this.pane_body);
            this.Name = "FormNguoiDung";
            this.Text = "FormNguoiDung";
            this.pane_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pane_body;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Label lb_vtlv;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_userName;
        private Sunny.UI.UITextBox txt_pass;
        private Sunny.UI.UIComboBox cb_vitrilv;
        private Sunny.UI.UIButton btn_reload;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIDataGridView dvg_NguoiDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_Them;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ts_Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_LamMoi;
        private System.Windows.Forms.ToolStripButton ts_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btn_Tim;
    }
}