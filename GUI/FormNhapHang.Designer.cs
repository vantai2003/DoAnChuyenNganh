﻿namespace DACN.GUI
{
    partial class FormNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_body = new Sunny.UI.UITabControl();
            this.tab_DanhSach = new System.Windows.Forms.TabPage();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.dvg_DSPhieuNhap = new Sunny.UI.UIDataGridView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panelTopButtom = new System.Windows.Forms.Panel();
            this.btn_TimPN = new System.Windows.Forms.Button();
            this.txt_SearchPN = new Sunny.UI.UITextBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_ChiTiet = new System.Windows.Forms.TabPage();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTien = new Sunny.UI.UITextBox();
            this.dvg_TaoPN = new System.Windows.Forms.DataGridView();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.btn_ChonSP = new System.Windows.Forms.Button();
            this.cb_TaoPNKho = new System.Windows.Forms.ComboBox();
            this.lb_ncc = new System.Windows.Forms.Label();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.lb_kho = new System.Windows.Forms.Label();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.btn_ToaPN = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tab_body.SuspendLayout();
            this.tab_DanhSach.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPhieuNhap)).BeginInit();
            this.panelTopButtom.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.tab_ChiTiet.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TaoPN)).BeginInit();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.inToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thêmToolStripMenuItem.Image = global::DACN.Properties.Resources.Add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xóaToolStripMenuItem.Image = global::DACN.Properties.Resources.Delete;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sửaToolStripMenuItem.Image = global::DACN.Properties.Resources.Edit;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inToolStripMenuItem.Image = global::DACN.Properties.Resources.Print;
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.inToolStripMenuItem.Text = "In";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thoátToolStripMenuItem.Image = global::DACN.Properties.Resources.Close1;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // tab_body
            // 
            this.tab_body.Controls.Add(this.tab_DanhSach);
            this.tab_body.Controls.Add(this.tab_ChiTiet);
            this.tab_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_body.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_body.ItemSize = new System.Drawing.Size(150, 40);
            this.tab_body.Location = new System.Drawing.Point(0, 36);
            this.tab_body.MainPage = "";
            this.tab_body.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tab_body.Name = "tab_body";
            this.tab_body.SelectedIndex = 0;
            this.tab_body.Size = new System.Drawing.Size(1213, 663);
            this.tab_body.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_body.TabBackColor = System.Drawing.Color.DarkViolet;
            this.tab_body.TabIndex = 1;
            this.tab_body.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tab_DanhSach
            // 
            this.tab_DanhSach.Controls.Add(this.panel_Body);
            this.tab_DanhSach.Controls.Add(this.panel_header);
            this.tab_DanhSach.Controls.Add(this.panelTopButtom);
            this.tab_DanhSach.Controls.Add(this.panel_Top);
            this.tab_DanhSach.Location = new System.Drawing.Point(0, 40);
            this.tab_DanhSach.Name = "tab_DanhSach";
            this.tab_DanhSach.Size = new System.Drawing.Size(1213, 623);
            this.tab_DanhSach.TabIndex = 0;
            this.tab_DanhSach.Text = "Danh sách";
            this.tab_DanhSach.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.uiPanel1);
            this.panel_Body.Controls.Add(this.dvg_DSPhieuNhap);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 293);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1213, 230);
            this.panel_Body.TabIndex = 3;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(1137, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(76, 230);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_DSPhieuNhap
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dvg_DSPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dvg_DSPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dvg_DSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_DSPhieuNhap.DefaultCellStyle = dataGridViewCellStyle13;
            this.dvg_DSPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_DSPhieuNhap.EnableHeadersVisualStyles = false;
            this.dvg_DSPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_DSPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dvg_DSPhieuNhap.Name = "dvg_DSPhieuNhap";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_DSPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dvg_DSPhieuNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_DSPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dvg_DSPhieuNhap.RowTemplate.Height = 24;
            this.dvg_DSPhieuNhap.SelectedIndex = -1;
            this.dvg_DSPhieuNhap.Size = new System.Drawing.Size(1213, 230);
            this.dvg_DSPhieuNhap.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_DSPhieuNhap.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_header.Location = new System.Drawing.Point(0, 523);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1213, 100);
            this.panel_header.TabIndex = 2;
            // 
            // panelTopButtom
            // 
            this.panelTopButtom.Controls.Add(this.btn_TimPN);
            this.panelTopButtom.Controls.Add(this.txt_SearchPN);
            this.panelTopButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButtom.Location = new System.Drawing.Point(0, 209);
            this.panelTopButtom.Name = "panelTopButtom";
            this.panelTopButtom.Size = new System.Drawing.Size(1213, 84);
            this.panelTopButtom.TabIndex = 1;
            // 
            // btn_TimPN
            // 
            this.btn_TimPN.Location = new System.Drawing.Point(609, 29);
            this.btn_TimPN.Name = "btn_TimPN";
            this.btn_TimPN.Size = new System.Drawing.Size(130, 44);
            this.btn_TimPN.TabIndex = 1;
            this.btn_TimPN.Text = "Tìm";
            this.btn_TimPN.UseVisualStyleBackColor = true;
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
            this.txt_SearchPN.Size = new System.Drawing.Size(150, 29);
            this.txt_SearchPN.TabIndex = 0;
            this.txt_SearchPN.Text = "uiTextBox1";
            this.txt_SearchPN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_SearchPN.Watermark = "";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.LightGray;
            this.panel_Top.Controls.Add(this.uiComboBox2);
            this.panel_Top.Controls.Add(this.uiComboBox1);
            this.panel_Top.Controls.Add(this.uiDatePicker2);
            this.panel_Top.Controls.Add(this.uiDatePicker1);
            this.panel_Top.Controls.Add(this.label4);
            this.panel_Top.Controls.Add(this.label3);
            this.panel_Top.Controls.Add(this.label2);
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1213, 209);
            this.panel_Top.TabIndex = 0;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox2.Location = new System.Drawing.Point(262, 122);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(656, 29);
            this.uiComboBox2.SymbolSize = 24;
            this.uiComboBox2.TabIndex = 7;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(262, 86);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(656, 29);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 6;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiDatePicker2
            // 
            this.uiDatePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatePicker2.Location = new System.Drawing.Point(754, 37);
            this.uiDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker2.MaxLength = 10;
            this.uiDatePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker2.Name = "uiDatePicker2";
            this.uiDatePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker2.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker2.SymbolDropDown = 61555;
            this.uiDatePicker2.SymbolNormal = 61555;
            this.uiDatePicker2.SymbolSize = 24;
            this.uiDatePicker2.TabIndex = 5;
            this.uiDatePicker2.Text = "2024-10-31";
            this.uiDatePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker2.Value = new System.DateTime(2024, 10, 31, 0, 22, 10, 311);
            this.uiDatePicker2.Watermark = "";
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(262, 29);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 24;
            this.uiDatePicker1.TabIndex = 4;
            this.uiDatePicker1.Text = "2024-10-31";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2024, 10, 31, 0, 22, 2, 537);
            this.uiDatePicker1.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // tab_ChiTiet
            // 
            this.tab_ChiTiet.Controls.Add(this.uiPanel2);
            this.tab_ChiTiet.Location = new System.Drawing.Point(0, 40);
            this.tab_ChiTiet.Name = "tab_ChiTiet";
            this.tab_ChiTiet.Size = new System.Drawing.Size(1213, 623);
            this.tab_ChiTiet.TabIndex = 1;
            this.tab_ChiTiet.Text = "Chi tiết";
            this.tab_ChiTiet.UseVisualStyleBackColor = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.btn_Xoa);
            this.uiPanel2.Controls.Add(this.btn_ToaPN);
            this.uiPanel2.Controls.Add(this.label10);
            this.uiPanel2.Controls.Add(this.txtTongTien);
            this.uiPanel2.Controls.Add(this.dvg_TaoPN);
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1213, 623);
            this.uiPanel2.TabIndex = 16;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(584, 520);
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
            this.txtTongTien.Location = new System.Drawing.Point(756, 520);
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
            // dvg_TaoPN
            // 
            this.dvg_TaoPN.AllowUserToAddRows = false;
            this.dvg_TaoPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_TaoPN.Location = new System.Drawing.Point(3, 285);
            this.dvg_TaoPN.Name = "dvg_TaoPN";
            this.dvg_TaoPN.RowHeadersWidth = 51;
            this.dvg_TaoPN.RowTemplate.Height = 24;
            this.dvg_TaoPN.Size = new System.Drawing.Size(1207, 197);
            this.dvg_TaoPN.TabIndex = 2;
            this.dvg_TaoPN.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_TaoPN_CellEndEdit);
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.lb_trangthai);
            this.uiPanel4.Controls.Add(this.cb_TrangThai);
            this.uiPanel4.Controls.Add(this.btn_ChonSP);
            this.uiPanel4.Controls.Add(this.cb_TaoPNKho);
            this.uiPanel4.Controls.Add(this.lb_ncc);
            this.uiPanel4.Controls.Add(this.cb_NCC);
            this.uiPanel4.Controls.Add(this.lb_kho);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 97);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(1213, 180);
            this.uiPanel4.TabIndex = 1;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ChonSP
            // 
            this.btn_ChonSP.Location = new System.Drawing.Point(237, 119);
            this.btn_ChonSP.Name = "btn_ChonSP";
            this.btn_ChonSP.Size = new System.Drawing.Size(215, 45);
            this.btn_ChonSP.TabIndex = 27;
            this.btn_ChonSP.Text = "Chọn sản phẩm";
            this.btn_ChonSP.UseVisualStyleBackColor = true;
            this.btn_ChonSP.Click += new System.EventHandler(this.btn_ChonSP_Click);
            // 
            // cb_TaoPNKho
            // 
            this.cb_TaoPNKho.FormattingEnabled = true;
            this.cb_TaoPNKho.Location = new System.Drawing.Point(331, 58);
            this.cb_TaoPNKho.Name = "cb_TaoPNKho";
            this.cb_TaoPNKho.Size = new System.Drawing.Size(255, 33);
            this.cb_TaoPNKho.TabIndex = 26;
            // 
            // lb_ncc
            // 
            this.lb_ncc.AutoSize = true;
            this.lb_ncc.Location = new System.Drawing.Point(703, 58);
            this.lb_ncc.Name = "lb_ncc";
            this.lb_ncc.Size = new System.Drawing.Size(133, 25);
            this.lb_ncc.TabIndex = 25;
            this.lb_ncc.Text = "Nhà cung cấp";
            // 
            // cb_NCC
            // 
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(861, 55);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(121, 33);
            this.cb_NCC.TabIndex = 24;
            // 
            // lb_kho
            // 
            this.lb_kho.AutoSize = true;
            this.lb_kho.Location = new System.Drawing.Point(232, 58);
            this.lb_kho.Name = "lb_kho";
            this.lb_kho.Size = new System.Drawing.Size(48, 25);
            this.lb_kho.TabIndex = 19;
            this.lb_kho.Text = "Kho";
            // 
            // uiPanel3
            // 
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1213, 97);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = "TẠO PHIẾU NHẬP HÀNG";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.Enabled = false;
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Đang xử lý"});
            this.cb_TrangThai.Location = new System.Drawing.Point(861, 119);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(121, 33);
            this.cb_TrangThai.TabIndex = 28;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Location = new System.Drawing.Point(703, 119);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(100, 25);
            this.lb_trangthai.TabIndex = 29;
            this.lb_trangthai.Text = "Trạng thái";
            // 
            // btn_ToaPN
            // 
            this.btn_ToaPN.Location = new System.Drawing.Point(250, 521);
            this.btn_ToaPN.Name = "btn_ToaPN";
            this.btn_ToaPN.Size = new System.Drawing.Size(176, 52);
            this.btn_ToaPN.TabIndex = 7;
            this.btn_ToaPN.Text = "Tạo phiếu nhập";
            this.btn_ToaPN.UseVisualStyleBackColor = true;
            this.btn_ToaPN.Click += new System.EventHandler(this.btn_ToaPN_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1015, 525);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(158, 48);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa sản phẩm";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 699);
            this.Controls.Add(this.tab_body);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_body.ResumeLayout(false);
            this.tab_DanhSach.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DSPhieuNhap)).EndInit();
            this.panelTopButtom.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.tab_ChiTiet.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TaoPN)).EndInit();
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private Sunny.UI.UITabControl tab_body;
        private System.Windows.Forms.TabPage tab_DanhSach;
        private System.Windows.Forms.TabPage tab_ChiTiet;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panelTopButtom;
        private System.Windows.Forms.Panel panel_Top;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dvg_DSPhieuNhap;
        private System.Windows.Forms.Button btn_TimPN;
        private Sunny.UI.UITextBox txt_SearchPN;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.DataGridView dvg_TaoPN;
        private Sunny.UI.UIPanel uiPanel4;
        private System.Windows.Forms.Label lb_kho;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox txtTongTien;
        private System.Windows.Forms.Label lb_ncc;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.ComboBox cb_TaoPNKho;
        private System.Windows.Forms.Button btn_ChonSP;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.Button btn_ToaPN;
        private System.Windows.Forms.Button btn_Xoa;
    }
}