namespace DACN.GUI
{
    partial class FormInHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_body = new Sunny.UI.UITabControl();
            this.tab_InPhieuNhap = new System.Windows.Forms.TabPage();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.dvg_DSPhieuNhap = new Sunny.UI.UIDataGridView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panelTopButtom = new System.Windows.Forms.Panel();
            this.btn_TimPN = new System.Windows.Forms.Button();
            this.txt_SearchPN = new Sunny.UI.UITextBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mn_CTPN = new System.Windows.Forms.MenuStrip();
            this.dp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_LocTheoNgay = new System.Windows.Forms.Button();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.cbkho = new System.Windows.Forms.ComboBox();
            this.cb_CongTy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbncc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.btnIn = new System.Windows.Forms.Button();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_InHD = new System.Windows.Forms.TabPage();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.dgv_DSPhieuXuat = new System.Windows.Forms.DataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ToaPN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTien = new Sunny.UI.UITextBox();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.btn_In = new System.Windows.Forms.Button();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.tab_body.SuspendLayout();
            this.tab_InPhieuNhap.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPhieuNhap)).BeginInit();
            this.panelTopButtom.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.tab_InHD.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhieuXuat)).BeginInit();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_body
            // 
            this.tab_body.Controls.Add(this.tab_InPhieuNhap);
            this.tab_body.Controls.Add(this.tab_InHD);
            this.tab_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_body.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_body.ItemSize = new System.Drawing.Size(150, 40);
            this.tab_body.Location = new System.Drawing.Point(0, 0);
            this.tab_body.MainPage = "";
            this.tab_body.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tab_body.Name = "tab_body";
            this.tab_body.SelectedIndex = 0;
            this.tab_body.Size = new System.Drawing.Size(1160, 659);
            this.tab_body.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_body.TabBackColor = System.Drawing.Color.Linen;
            this.tab_body.TabIndex = 2;
            this.tab_body.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab_body.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tab_body.TabUnSelectedForeColor = System.Drawing.Color.Black;
            this.tab_body.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tab_body.SelectedIndexChanged += new System.EventHandler(this.tab_body_SelectedIndexChanged);
            // 
            // tab_InPhieuNhap
            // 
            this.tab_InPhieuNhap.Controls.Add(this.panel_Body);
            this.tab_InPhieuNhap.Controls.Add(this.panel_header);
            this.tab_InPhieuNhap.Controls.Add(this.panelTopButtom);
            this.tab_InPhieuNhap.Controls.Add(this.panel_Top);
            this.tab_InPhieuNhap.Location = new System.Drawing.Point(0, 40);
            this.tab_InPhieuNhap.Name = "tab_InPhieuNhap";
            this.tab_InPhieuNhap.Size = new System.Drawing.Size(1160, 619);
            this.tab_InPhieuNhap.TabIndex = 0;
            this.tab_InPhieuNhap.Text = "In phiếu nhập";
            this.tab_InPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.dvg_DSPhieuNhap);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 293);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1160, 297);
            this.panel_Body.TabIndex = 3;
            // 
            // dvg_DSPhieuNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dvg_DSPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_DSPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dvg_DSPhieuNhap.BackgroundColor = System.Drawing.Color.DimGray;
            this.dvg_DSPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_DSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_DSPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_DSPhieuNhap.EnableHeadersVisualStyles = false;
            this.dvg_DSPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_DSPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dvg_DSPhieuNhap.Name = "dvg_DSPhieuNhap";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_DSPhieuNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_DSPhieuNhap.RowTemplate.Height = 24;
            this.dvg_DSPhieuNhap.ScrollBarBackColor = System.Drawing.Color.BurlyWood;
            this.dvg_DSPhieuNhap.ScrollBarStyleInherited = false;
            this.dvg_DSPhieuNhap.SelectedIndex = -1;
            this.dvg_DSPhieuNhap.Size = new System.Drawing.Size(1160, 297);
            this.dvg_DSPhieuNhap.StripeOddColor = System.Drawing.Color.White;
            this.dvg_DSPhieuNhap.TabIndex = 0;
            this.dvg_DSPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_DSPhieuNhap_CellClick);
            // 
            // panel_header
            // 
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_header.Location = new System.Drawing.Point(0, 590);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1160, 29);
            this.panel_header.TabIndex = 2;
            // 
            // panelTopButtom
            // 
            this.panelTopButtom.Controls.Add(this.btn_TimPN);
            this.panelTopButtom.Controls.Add(this.txt_SearchPN);
            this.panelTopButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButtom.Location = new System.Drawing.Point(0, 209);
            this.panelTopButtom.Name = "panelTopButtom";
            this.panelTopButtom.Size = new System.Drawing.Size(1160, 84);
            this.panelTopButtom.TabIndex = 1;
            // 
            // btn_TimPN
            // 
            this.btn_TimPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_TimPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_TimPN.ForeColor = System.Drawing.Color.White;
            this.btn_TimPN.Image = global::DACN.Properties.Resources.Search1;
            this.btn_TimPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimPN.Location = new System.Drawing.Point(533, 20);
            this.btn_TimPN.Name = "btn_TimPN";
            this.btn_TimPN.Size = new System.Drawing.Size(115, 49);
            this.btn_TimPN.TabIndex = 1;
            this.btn_TimPN.Text = "Tìm";
            this.btn_TimPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimPN.UseVisualStyleBackColor = false;
            this.btn_TimPN.Click += new System.EventHandler(this.btn_TimPN_Click);
            // 
            // txt_SearchPN
            // 
            this.txt_SearchPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SearchPN.Location = new System.Drawing.Point(262, 29);
            this.txt_SearchPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SearchPN.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_SearchPN.Name = "txt_SearchPN";
            this.txt_SearchPN.Padding = new System.Windows.Forms.Padding(5);
            this.txt_SearchPN.ShowText = false;
            this.txt_SearchPN.Size = new System.Drawing.Size(237, 29);
            this.txt_SearchPN.TabIndex = 0;
            this.txt_SearchPN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_SearchPN.Watermark = "";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.LightGray;
            this.panel_Top.Controls.Add(this.panel4);
            this.panel_Top.Controls.Add(this.panel3);
            this.panel_Top.Controls.Add(this.panel2);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1160, 209);
            this.panel_Top.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.mn_CTPN);
            this.panel4.Controls.Add(this.dp_DenNgay);
            this.panel4.Controls.Add(this.dp_TuNgay);
            this.panel4.Controls.Add(this.btn_LocTheoNgay);
            this.panel4.Controls.Add(this.cbncc);
            this.panel4.Controls.Add(this.cbkho);
            this.panel4.Controls.Add(this.cb_CongTy);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_Loc);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbncc);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(101, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 209);
            this.panel4.TabIndex = 11;
            // 
            // mn_CTPN
            // 
            this.mn_CTPN.BackColor = System.Drawing.Color.Transparent;
            this.mn_CTPN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mn_CTPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mn_CTPN.Location = new System.Drawing.Point(0, 0);
            this.mn_CTPN.Name = "mn_CTPN";
            this.mn_CTPN.Size = new System.Drawing.Size(983, 24);
            this.mn_CTPN.TabIndex = 45;
            this.mn_CTPN.Text = "menuStrip1";
            // 
            // dp_DenNgay
            // 
            this.dp_DenNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_DenNgay.Location = new System.Drawing.Point(585, 71);
            this.dp_DenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_DenNgay.Name = "dp_DenNgay";
            this.dp_DenNgay.Size = new System.Drawing.Size(123, 30);
            this.dp_DenNgay.TabIndex = 44;
            // 
            // dp_TuNgay
            // 
            this.dp_TuNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_TuNgay.Location = new System.Drawing.Point(221, 63);
            this.dp_TuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_TuNgay.Name = "dp_TuNgay";
            this.dp_TuNgay.Size = new System.Drawing.Size(123, 30);
            this.dp_TuNgay.TabIndex = 43;
            // 
            // btn_LocTheoNgay
            // 
            this.btn_LocTheoNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_LocTheoNgay.ForeColor = System.Drawing.Color.White;
            this.btn_LocTheoNgay.Location = new System.Drawing.Point(737, 56);
            this.btn_LocTheoNgay.Name = "btn_LocTheoNgay";
            this.btn_LocTheoNgay.Size = new System.Drawing.Size(174, 48);
            this.btn_LocTheoNgay.TabIndex = 14;
            this.btn_LocTheoNgay.Text = "Lọc theo ngày";
            this.btn_LocTheoNgay.UseVisualStyleBackColor = false;
            this.btn_LocTheoNgay.Click += new System.EventHandler(this.btn_LocTheoNgay_Click);
            // 
            // cbncc
            // 
            this.cbncc.BackColor = System.Drawing.Color.LightGray;
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(221, 151);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(487, 33);
            this.cbncc.TabIndex = 13;
            // 
            // cbkho
            // 
            this.cbkho.BackColor = System.Drawing.Color.LightGray;
            this.cbkho.FormattingEnabled = true;
            this.cbkho.Location = new System.Drawing.Point(221, 112);
            this.cbkho.Name = "cbkho";
            this.cbkho.Size = new System.Drawing.Size(487, 33);
            this.cbkho.TabIndex = 12;
            // 
            // cb_CongTy
            // 
            this.cb_CongTy.Enabled = false;
            this.cb_CongTy.FormattingEnabled = true;
            this.cb_CongTy.Items.AddRange(new object[] {
            "Công ty TNHH Minh Hiếu"});
            this.cb_CongTy.Location = new System.Drawing.Point(221, 25);
            this.cb_CongTy.Name = "cb_CongTy";
            this.cb_CongTy.Size = new System.Drawing.Size(487, 33);
            this.cb_CongTy.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Công ty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_Loc.ForeColor = System.Drawing.Color.White;
            this.btn_Loc.Location = new System.Drawing.Point(737, 114);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(85, 65);
            this.btn_Loc.TabIndex = 8;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kho";
            // 
            // lbncc
            // 
            this.lbncc.AutoSize = true;
            this.lbncc.ForeColor = System.Drawing.Color.Black;
            this.lbncc.Location = new System.Drawing.Point(44, 154);
            this.lbncc.Name = "lbncc";
            this.lbncc.Size = new System.Drawing.Size(133, 25);
            this.lbncc.TabIndex = 2;
            this.lbncc.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(438, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.uiPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 209);
            this.panel3.TabIndex = 10;
            // 
            // uiPanel6
            // 
            this.uiPanel6.Controls.Add(this.btnIn);
            this.uiPanel6.Controls.Add(this.uiPanel7);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel6.Location = new System.Drawing.Point(0, 0);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Size = new System.Drawing.Size(101, 58);
            this.uiPanel6.TabIndex = 0;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = global::DACN.Properties.Resources.Print3;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(14, 0);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(87, 58);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // uiPanel7
            // 
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel7.Location = new System.Drawing.Point(0, 0);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Size = new System.Drawing.Size(14, 58);
            this.uiPanel7.TabIndex = 0;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1084, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 209);
            this.panel2.TabIndex = 9;
            // 
            // tab_InHD
            // 
            this.tab_InHD.Controls.Add(this.uiPanel2);
            this.tab_InHD.Location = new System.Drawing.Point(0, 40);
            this.tab_InHD.Name = "tab_InHD";
            this.tab_InHD.Size = new System.Drawing.Size(1160, 619);
            this.tab_InHD.TabIndex = 1;
            this.tab_InHD.Text = "In hóa đơn";
            this.tab_InHD.UseVisualStyleBackColor = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.panel7);
            this.uiPanel2.Controls.Add(this.btn_Xoa);
            this.uiPanel2.Controls.Add(this.btn_ToaPN);
            this.uiPanel2.Controls.Add(this.label10);
            this.uiPanel2.Controls.Add(this.txtTongTien);
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1160, 619);
            this.uiPanel2.TabIndex = 16;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.uiPanel5);
            this.panel7.Controls.Add(this.uiPanel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 185);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1160, 434);
            this.panel7.TabIndex = 9;
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.dgv_DSPhieuXuat);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel5.Location = new System.Drawing.Point(0, 0);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Size = new System.Drawing.Size(1160, 400);
            this.uiPanel5.TabIndex = 1;
            this.uiPanel5.Text = "uiPanel5";
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_DSPhieuXuat
            // 
            this.dgv_DSPhieuXuat.AllowUserToAddRows = false;
            this.dgv_DSPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_DSPhieuXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DSPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.dgv_DSPhieuXuat.Name = "dgv_DSPhieuXuat";
            this.dgv_DSPhieuXuat.ReadOnly = true;
            this.dgv_DSPhieuXuat.RowHeadersWidth = 51;
            this.dgv_DSPhieuXuat.RowTemplate.Height = 24;
            this.dgv_DSPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSPhieuXuat.Size = new System.Drawing.Size(1160, 400);
            this.dgv_DSPhieuXuat.TabIndex = 2;
            this.dgv_DSPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPhieuXuat_CellClick);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 400);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1160, 34);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Teal;
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Location = new System.Drawing.Point(869, 513);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(158, 48);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa sản phẩm";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_ToaPN
            // 
            this.btn_ToaPN.BackColor = System.Drawing.Color.Teal;
            this.btn_ToaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ToaPN.Location = new System.Drawing.Point(95, 520);
            this.btn_ToaPN.Name = "btn_ToaPN";
            this.btn_ToaPN.Size = new System.Drawing.Size(176, 52);
            this.btn_ToaPN.TabIndex = 7;
            this.btn_ToaPN.Text = "Tạo phiếu nhập";
            this.btn_ToaPN.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongTien.Location = new System.Drawing.Point(629, 525);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(5);
            this.txtTongTien.ShowText = false;
            this.txtTongTien.Size = new System.Drawing.Size(150, 29);
            this.txtTongTien.TabIndex = 4;
            this.txtTongTien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTongTien.Watermark = "";
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.btn_In);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 105);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(1160, 80);
            this.uiPanel4.TabIndex = 1;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_In.ForeColor = System.Drawing.Color.White;
            this.btn_In.Location = new System.Drawing.Point(70, 8);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(182, 65);
            this.btn_In.TabIndex = 27;
            this.btn_In.Text = "Xuất hóa đơn";
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Size = new System.Drawing.Size(1160, 105);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = "XUẤT HÓA ĐƠN";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 659);
            this.Controls.Add(this.tab_body);
            this.Name = "FormInHoaDon";
            this.Text = "FormInHoaDon";
            this.tab_body.ResumeLayout(false);
            this.tab_InPhieuNhap.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPhieuNhap)).EndInit();
            this.panelTopButtom.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.tab_InHD.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhieuXuat)).EndInit();
            this.uiPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl tab_body;
        private System.Windows.Forms.TabPage tab_InPhieuNhap;
        private System.Windows.Forms.Panel panel_Body;
        private Sunny.UI.UIDataGridView dvg_DSPhieuNhap;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panelTopButtom;
        private System.Windows.Forms.Button btn_TimPN;
        private Sunny.UI.UITextBox txt_SearchPN;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dp_DenNgay;
        private System.Windows.Forms.DateTimePicker dp_TuNgay;
        private System.Windows.Forms.Button btn_LocTheoNgay;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.ComboBox cbkho;
        private System.Windows.Forms.ComboBox cb_CongTy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbncc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tab_InHD;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgv_DSPhieuXuat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ToaPN;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox txtTongTien;
        private Sunny.UI.UIPanel uiPanel4;
        private System.Windows.Forms.Button btn_In;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.MenuStrip mn_CTPN;
        private Sunny.UI.UIPanel uiPanel7;
    }
}