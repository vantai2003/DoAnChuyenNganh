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
            this.btn_LamMoi = new Sunny.UI.UIButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_reload = new Sunny.UI.UIButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Search = new Sunny.UI.UIButton();
            this.lb_userName = new System.Windows.Forms.Label();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_pass = new Sunny.UI.UITextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.cb_vitrilv = new Sunny.UI.UIComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lb_vtlv = new System.Windows.Forms.Label();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.pane_body.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_NguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 367);
            this.panel2.TabIndex = 3;
            // 
            // dvg_NguoiDung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_NguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dvg_NguoiDung.Size = new System.Drawing.Size(1207, 367);
            this.dvg_NguoiDung.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_NguoiDung.TabIndex = 0;
            this.dvg_NguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_NguoiDung_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.cb_NhanVien);
            this.panel1.Controls.Add(this.btn_LamMoi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.lb_pass);
            this.panel1.Controls.Add(this.cb_vitrilv);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.lb_vtlv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 369);
            this.panel1.TabIndex = 0;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LamMoi.Location = new System.Drawing.Point(716, 196);
            this.btn_LamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(117, 60);
            this.btn_LamMoi.TabIndex = 52;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(536, 196);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 60);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(50, 195);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 59);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_Search.FillDisableColor = System.Drawing.Color.Cyan;
            this.btn_Search.FillHoverColor = System.Drawing.Color.Fuchsia;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Search.ForeDisableColor = System.Drawing.Color.White;
            this.btn_Search.LightColor = System.Drawing.Color.Brown;
            this.btn_Search.Location = new System.Drawing.Point(409, 314);
            this.btn_Search.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Radius = 15;
            this.btn_Search.RectColor = System.Drawing.Color.Blue;
            this.btn_Search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Search.Size = new System.Drawing.Size(120, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.BackColor = System.Drawing.Color.White;
            this.lb_userName.Location = new System.Drawing.Point(45, 42);
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
            this.txt_Search.Location = new System.Drawing.Point(104, 314);
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
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(363, 196);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 58);
            this.btn_Sua.TabIndex = 49;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.txt_pass.Size = new System.Drawing.Size(185, 29);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_pass.Watermark = "";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BackColor = System.Drawing.Color.White;
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
            this.cb_vitrilv.Location = new System.Drawing.Point(730, 117);
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
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(202, 195);
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
            // lb_vtlv
            // 
            this.lb_vtlv.AutoSize = true;
            this.lb_vtlv.BackColor = System.Drawing.Color.White;
            this.lb_vtlv.Location = new System.Drawing.Point(542, 117);
            this.lb_vtlv.Name = "lb_vtlv";
            this.lb_vtlv.Size = new System.Drawing.Size(126, 25);
            this.lb_vtlv.TabIndex = 3;
            this.lb_vtlv.Text = "Vị trí làm việc";
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(271, 42);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(199, 33);
            this.cb_NhanVien.TabIndex = 53;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pane_body;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btn_Search;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Label lb_vtlv;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_userName;
        private Sunny.UI.UITextBox txt_pass;
        private Sunny.UI.UIComboBox cb_vitrilv;
        private Sunny.UI.UIButton btn_reload;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIDataGridView dvg_NguoiDung;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnLuu;
        private Sunny.UI.UIButton btn_LamMoi;
        private System.Windows.Forms.ComboBox cb_NhanVien;
    }
}