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
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_pass = new Sunny.UI.UITextBox();
            this.txt_username = new Sunny.UI.UITextBox();
            this.cb_vitrilv = new Sunny.UI.UIComboBox();
            this.cb_nhanvien = new Sunny.UI.UIComboBox();
            this.lb_vtlv = new System.Windows.Forms.Label();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reload = new Sunny.UI.UIButton();
            this.btn_Search = new Sunny.UI.UIButton();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.pane_body.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NguoiDung)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pane_body.Size = new System.Drawing.Size(1207, 736);
            this.pane_body.TabIndex = 1;
            this.pane_body.Text = null;
            this.pane_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dvg_NguoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 342);
            this.panel2.TabIndex = 3;
            // 
            // dvg_NguoiDung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_NguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.dvg_NguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
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
            this.dvg_NguoiDung.Size = new System.Drawing.Size(1207, 342);
            this.dvg_NguoiDung.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.TabIndex = 0;
            this.dvg_NguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_NguoiDung_CellClick);
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.White;
            this.uiPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiPanel2.Controls.Add(this.btnLuu);
            this.uiPanel2.Controls.Add(this.btnThem);
            this.uiPanel2.Controls.Add(this.btn_Sua);
            this.uiPanel2.Controls.Add(this.btn_Xoa);
            this.uiPanel2.Controls.Add(this.txt_pass);
            this.uiPanel2.Controls.Add(this.txt_username);
            this.uiPanel2.Controls.Add(this.cb_vitrilv);
            this.uiPanel2.Controls.Add(this.cb_nhanvien);
            this.uiPanel2.Controls.Add(this.lb_vtlv);
            this.uiPanel2.Controls.Add(this.lb_nhanvien);
            this.uiPanel2.Controls.Add(this.lb_pass);
            this.uiPanel2.Controls.Add(this.lb_userName);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.FillColor = System.Drawing.Color.PaleGreen;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 442);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1207, 294);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(662, 68);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 60);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(458, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 56);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(458, 208);
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
            this.btn_Xoa.Location = new System.Drawing.Point(458, 129);
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
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_pass.Location = new System.Drawing.Point(213, 89);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(5);
            this.txt_pass.RectColor = System.Drawing.Color.Red;
            this.txt_pass.ScrollBarColor = System.Drawing.Color.Fuchsia;
            this.txt_pass.ScrollBarStyleInherited = false;
            this.txt_pass.ShowText = false;
            this.txt_pass.Size = new System.Drawing.Size(185, 29);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_pass.Watermark = "";
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_username.Location = new System.Drawing.Point(213, 36);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(5);
            this.txt_username.RectColor = System.Drawing.Color.Red;
            this.txt_username.ShowText = false;
            this.txt_username.Size = new System.Drawing.Size(185, 29);
            this.txt_username.TabIndex = 8;
            this.txt_username.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_username.Watermark = "";
            // 
            // cb_vitrilv
            // 
            this.cb_vitrilv.DataSource = null;
            this.cb_vitrilv.FillColor = System.Drawing.Color.White;
            this.cb_vitrilv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_vitrilv.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cb_vitrilv.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cb_vitrilv.Location = new System.Drawing.Point(213, 208);
            this.cb_vitrilv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_vitrilv.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_vitrilv.Name = "cb_vitrilv";
            this.cb_vitrilv.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_vitrilv.RectColor = System.Drawing.Color.Red;
            this.cb_vitrilv.Size = new System.Drawing.Size(185, 29);
            this.cb_vitrilv.SymbolSize = 24;
            this.cb_vitrilv.TabIndex = 7;
            this.cb_vitrilv.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_vitrilv.Watermark = "";
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.DataSource = null;
            this.cb_nhanvien.FillColor = System.Drawing.Color.White;
            this.cb_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_nhanvien.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cb_nhanvien.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cb_nhanvien.Location = new System.Drawing.Point(213, 149);
            this.cb_nhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_nhanvien.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_nhanvien.RectColor = System.Drawing.Color.Red;
            this.cb_nhanvien.Size = new System.Drawing.Size(185, 29);
            this.cb_nhanvien.SymbolSize = 24;
            this.cb_nhanvien.TabIndex = 6;
            this.cb_nhanvien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_nhanvien.Watermark = "";
            // 
            // lb_vtlv
            // 
            this.lb_vtlv.AutoSize = true;
            this.lb_vtlv.BackColor = System.Drawing.Color.PaleGreen;
            this.lb_vtlv.Location = new System.Drawing.Point(53, 212);
            this.lb_vtlv.Name = "lb_vtlv";
            this.lb_vtlv.Size = new System.Drawing.Size(126, 25);
            this.lb_vtlv.TabIndex = 3;
            this.lb_vtlv.Text = "Vị trí làm việc";
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.BackColor = System.Drawing.Color.PaleGreen;
            this.lb_nhanvien.Location = new System.Drawing.Point(53, 149);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(100, 25);
            this.lb_nhanvien.TabIndex = 2;
            this.lb_nhanvien.Text = "Nhân viên";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BackColor = System.Drawing.Color.PaleGreen;
            this.lb_pass.Location = new System.Drawing.Point(53, 89);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(93, 25);
            this.lb_pass.TabIndex = 1;
            this.lb_pass.Text = "Mật khẩu";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.BackColor = System.Drawing.Color.PaleGreen;
            this.lb_userName.Location = new System.Drawing.Point(48, 36);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(145, 25);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_reload.Location = new System.Drawing.Point(673, 36);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Radius = 25;
            this.btn_reload.Size = new System.Drawing.Size(115, 35);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FillColor = System.Drawing.Color.Lime;
            this.btn_Search.FillDisableColor = System.Drawing.Color.Cyan;
            this.btn_Search.FillHoverColor = System.Drawing.Color.Fuchsia;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Search.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Search.LightColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(405, 36);
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
            this.txt_Search.Location = new System.Drawing.Point(139, 36);
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
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 736);
            this.Controls.Add(this.pane_body);
            this.Name = "FormNguoiDung";
            this.Text = "FormNguoiDung";
            this.pane_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NguoiDung)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pane_body;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btn_Search;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Label lb_vtlv;
        private System.Windows.Forms.Label lb_nhanvien;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_userName;
        private Sunny.UI.UITextBox txt_pass;
        private Sunny.UI.UITextBox txt_username;
        private Sunny.UI.UIComboBox cb_vitrilv;
        private Sunny.UI.UIComboBox cb_nhanvien;
        private Sunny.UI.UIButton btn_reload;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIDataGridView dvg_NguoiDung;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnLuu;
    }
}