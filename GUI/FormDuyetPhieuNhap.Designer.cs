namespace DACN.GUI
{
    partial class FormDuyetPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_DuyetPN = new System.Windows.Forms.TabControl();
            this.tab_PheDuyet = new System.Windows.Forms.TabPage();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btn_TuChoi = new System.Windows.Forms.Button();
            this.btn_PheDuyet = new System.Windows.Forms.Button();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.dvg_DSDPN = new Sunny.UI.UIDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.tab_Dspn = new System.Windows.Forms.TabPage();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.dvg_DSPN = new Sunny.UI.UIDataGridView();
            this.pane_top = new Sunny.UI.UIPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_LocNgay = new System.Windows.Forms.Button();
            this.lb_DenNgay = new System.Windows.Forms.Label();
            this.lb_TuNgay = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.cb_Kho = new Sunny.UI.UIComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.panelTop = new Sunny.UI.UIPanel();
            this.btn_In = new System.Windows.Forms.Button();
            this.tab_DuyetPN.SuspendLayout();
            this.tab_PheDuyet.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSDPN)).BeginInit();
            this.tab_Dspn.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPN)).BeginInit();
            this.pane_top.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_DuyetPN
            // 
            this.tab_DuyetPN.Controls.Add(this.tab_PheDuyet);
            this.tab_DuyetPN.Controls.Add(this.tab_Dspn);
            this.tab_DuyetPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_DuyetPN.Location = new System.Drawing.Point(0, 0);
            this.tab_DuyetPN.Name = "tab_DuyetPN";
            this.tab_DuyetPN.SelectedIndex = 0;
            this.tab_DuyetPN.Size = new System.Drawing.Size(1332, 698);
            this.tab_DuyetPN.TabIndex = 0;
            this.tab_DuyetPN.SelectedIndexChanged += new System.EventHandler(this.tab_DuyetPN_SelectedIndexChanged);
            // 
            // tab_PheDuyet
            // 
            this.tab_PheDuyet.Controls.Add(this.uiPanel2);
            this.tab_PheDuyet.Controls.Add(this.uiPanel1);
            this.tab_PheDuyet.Location = new System.Drawing.Point(4, 25);
            this.tab_PheDuyet.Name = "tab_PheDuyet";
            this.tab_PheDuyet.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PheDuyet.Size = new System.Drawing.Size(1324, 669);
            this.tab_PheDuyet.TabIndex = 0;
            this.tab_PheDuyet.Text = "Phiếu duyệt cần xử lý";
            this.tab_PheDuyet.UseVisualStyleBackColor = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.btn_In);
            this.uiPanel2.Controls.Add(this.btn_TuChoi);
            this.uiPanel2.Controls.Add(this.btn_PheDuyet);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(3, 89);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1318, 577);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TuChoi
            // 
            this.btn_TuChoi.Location = new System.Drawing.Point(734, 381);
            this.btn_TuChoi.Name = "btn_TuChoi";
            this.btn_TuChoi.Size = new System.Drawing.Size(148, 85);
            this.btn_TuChoi.TabIndex = 3;
            this.btn_TuChoi.Text = "Từ chối";
            this.btn_TuChoi.UseVisualStyleBackColor = true;
            this.btn_TuChoi.Click += new System.EventHandler(this.btn_TuChoi_Click);
            // 
            // btn_PheDuyet
            // 
            this.btn_PheDuyet.Location = new System.Drawing.Point(464, 377);
            this.btn_PheDuyet.Name = "btn_PheDuyet";
            this.btn_PheDuyet.Size = new System.Drawing.Size(165, 92);
            this.btn_PheDuyet.TabIndex = 2;
            this.btn_PheDuyet.Text = "Phê duyệt";
            this.btn_PheDuyet.UseVisualStyleBackColor = true;
            this.btn_PheDuyet.Click += new System.EventHandler(this.btn_PheDuyet_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.dvg_DSDPN);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1318, 180);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = "uiPanel3";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_DSDPN
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSDPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_DSDPN.BackgroundColor = System.Drawing.Color.White;
            this.dvg_DSDPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSDPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_DSDPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_DSDPN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_DSDPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_DSDPN.EnableHeadersVisualStyles = false;
            this.dvg_DSDPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSDPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_DSDPN.Location = new System.Drawing.Point(0, 0);
            this.dvg_DSDPN.Name = "dvg_DSDPN";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSDPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_DSDPN.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSDPN.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_DSDPN.RowTemplate.Height = 24;
            this.dvg_DSDPN.SelectedIndex = -1;
            this.dvg_DSDPN.Size = new System.Drawing.Size(1318, 180);
            this.dvg_DSDPN.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSDPN.TabIndex = 0;
            this.dvg_DSDPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_DSDPN_CellClick);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.uiPanel1.Location = new System.Drawing.Point(3, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1318, 86);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = "DANH SÁCH PHIẾU NHẬP CẦN XỬ LÝ";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Dspn
            // 
            this.tab_Dspn.Controls.Add(this.uiPanel4);
            this.tab_Dspn.Location = new System.Drawing.Point(4, 25);
            this.tab_Dspn.Name = "tab_Dspn";
            this.tab_Dspn.Size = new System.Drawing.Size(1324, 669);
            this.tab_Dspn.TabIndex = 2;
            this.tab_Dspn.Text = "Danh sách phiếu nhập";
            this.tab_Dspn.UseVisualStyleBackColor = true;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.btn_XemCT);
            this.uiPanel4.Controls.Add(this.uiPanel5);
            this.uiPanel4.Controls.Add(this.panelTop);
            this.uiPanel4.FillColor = System.Drawing.Color.Silver;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 0);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(1324, 776);
            this.uiPanel4.TabIndex = 0;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Location = new System.Drawing.Point(61, 610);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(273, 73);
            this.btn_XemCT.TabIndex = 2;
            this.btn_XemCT.Text = "Xem chi tiết phiếu nhập";
            this.btn_XemCT.UseVisualStyleBackColor = true;
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.uiPanel7);
            this.uiPanel5.Controls.Add(this.pane_top);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel5.Location = new System.Drawing.Point(0, 59);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Size = new System.Drawing.Size(1324, 467);
            this.uiPanel5.TabIndex = 1;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            this.uiPanel7.Controls.Add(this.dvg_DSPN);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel7.Location = new System.Drawing.Point(0, 200);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Size = new System.Drawing.Size(1324, 267);
            this.uiPanel7.TabIndex = 2;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_DSPN
            // 
            this.dvg_DSPN.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvg_DSPN.BackgroundColor = System.Drawing.Color.White;
            this.dvg_DSPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvg_DSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_DSPN.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvg_DSPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_DSPN.EnableHeadersVisualStyles = false;
            this.dvg_DSPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_DSPN.Location = new System.Drawing.Point(0, 0);
            this.dvg_DSPN.Name = "dvg_DSPN";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvg_DSPN.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPN.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvg_DSPN.RowTemplate.Height = 24;
            this.dvg_DSPN.SelectedIndex = -1;
            this.dvg_DSPN.Size = new System.Drawing.Size(1324, 267);
            this.dvg_DSPN.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSPN.TabIndex = 0;
            this.dvg_DSPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_DSPN_CellClick);
            // 
            // pane_top
            // 
            this.pane_top.Controls.Add(this.textBox1);
            this.pane_top.Controls.Add(this.btn_LocNgay);
            this.pane_top.Controls.Add(this.lb_DenNgay);
            this.pane_top.Controls.Add(this.lb_TuNgay);
            this.pane_top.Controls.Add(this.dtp_DenNgay);
            this.pane_top.Controls.Add(this.dtp_TuNgay);
            this.pane_top.Controls.Add(this.txt_Search);
            this.pane_top.Controls.Add(this.groupBox1);
            this.pane_top.Controls.Add(this.btn_Tim);
            this.pane_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pane_top.Location = new System.Drawing.Point(0, 0);
            this.pane_top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pane_top.MinimumSize = new System.Drawing.Size(1, 1);
            this.pane_top.Name = "pane_top";
            this.pane_top.Size = new System.Drawing.Size(1324, 200);
            this.pane_top.TabIndex = 1;
            this.pane_top.Text = null;
            this.pane_top.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 9;
            // 
            // btn_LocNgay
            // 
            this.btn_LocNgay.Location = new System.Drawing.Point(1014, 23);
            this.btn_LocNgay.Name = "btn_LocNgay";
            this.btn_LocNgay.Size = new System.Drawing.Size(114, 49);
            this.btn_LocNgay.TabIndex = 8;
            this.btn_LocNgay.Text = "Lọc";
            this.btn_LocNgay.UseVisualStyleBackColor = true;
            // 
            // lb_DenNgay
            // 
            this.lb_DenNgay.AutoSize = true;
            this.lb_DenNgay.Location = new System.Drawing.Point(527, 35);
            this.lb_DenNgay.Name = "lb_DenNgay";
            this.lb_DenNgay.Size = new System.Drawing.Size(96, 25);
            this.lb_DenNgay.TabIndex = 7;
            this.lb_DenNgay.Text = "Đến ngày";
            // 
            // lb_TuNgay
            // 
            this.lb_TuNgay.AutoSize = true;
            this.lb_TuNgay.Location = new System.Drawing.Point(40, 30);
            this.lb_TuNgay.Name = "lb_TuNgay";
            this.lb_TuNgay.Size = new System.Drawing.Size(84, 25);
            this.lb_TuNgay.TabIndex = 6;
            this.lb_TuNgay.Text = "Từ ngày";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Location = new System.Drawing.Point(629, 30);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(349, 30);
            this.dtp_DenNgay.TabIndex = 5;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Location = new System.Drawing.Point(130, 30);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(349, 30);
            this.dtp_TuNgay.TabIndex = 4;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Search.Location = new System.Drawing.Point(61, 116);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Search.ShowText = false;
            this.txt_Search.Size = new System.Drawing.Size(195, 29);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Search.Watermark = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Loc);
            this.groupBox1.Controls.Add(this.cb_Kho);
            this.groupBox1.Location = new System.Drawing.Point(602, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc theo kho";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(383, 20);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(93, 34);
            this.btn_Loc.TabIndex = 1;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            // 
            // cb_Kho
            // 
            this.cb_Kho.DataSource = null;
            this.cb_Kho.FillColor = System.Drawing.Color.White;
            this.cb_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Kho.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cb_Kho.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cb_Kho.Location = new System.Drawing.Point(58, 31);
            this.cb_Kho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Kho.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Kho.Name = "cb_Kho";
            this.cb_Kho.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Kho.Size = new System.Drawing.Size(255, 29);
            this.cb_Kho.SymbolSize = 24;
            this.cb_Kho.TabIndex = 0;
            this.cb_Kho.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Kho.Watermark = "";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tim.Image = global::DACN.Properties.Resources.Search1;
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(292, 105);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(143, 54);
            this.btn_Tim.TabIndex = 1;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.Gray;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1324, 59);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = "DANH SÁCH PHIẾU NHẬP";
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(98, 315);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(212, 115);
            this.btn_In.TabIndex = 4;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // FormDuyetPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 698);
            this.Controls.Add(this.tab_DuyetPN);
            this.Name = "FormDuyetPhieuNhap";
            this.Text = "FormDuyetPhieuNhap";
            this.tab_DuyetPN.ResumeLayout(false);
            this.tab_PheDuyet.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSDPN)).EndInit();
            this.tab_Dspn.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPN)).EndInit();
            this.pane_top.ResumeLayout(false);
            this.pane_top.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_DuyetPN;
        private System.Windows.Forms.TabPage tab_PheDuyet;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Button btn_TuChoi;
        private System.Windows.Forms.Button btn_PheDuyet;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIDataGridView dvg_DSDPN;
        private System.Windows.Forms.TabPage tab_Dspn;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIDataGridView dvg_DSPN;
        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UIPanel pane_top;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Loc;
        private Sunny.UI.UIComboBox cb_Kho;
        private System.Windows.Forms.Button btn_Tim;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Label lb_DenNgay;
        private System.Windows.Forms.Label lb_TuNgay;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Button btn_LocNgay;
        private System.Windows.Forms.Button btn_XemCT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_In;
    }
}