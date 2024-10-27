namespace DACN.GUI
{
    partial class FormLoaiKhachHang
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
            this.dgv_LoaiKhachHang = new System.Windows.Forms.DataGridView();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCTPN = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoaAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_MaLoaiKH = new Sunny.UI.UITextBox();
            this.txt_TenLoaiKH = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).BeginInit();
            this.tsCTPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LoaiKhachHang
            // 
            this.dgv_LoaiKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiKH,
            this.TenLoaiKH});
            this.dgv_LoaiKhachHang.Location = new System.Drawing.Point(12, 184);
            this.dgv_LoaiKhachHang.Name = "dgv_LoaiKhachHang";
            this.dgv_LoaiKhachHang.RowHeadersWidth = 62;
            this.dgv_LoaiKhachHang.RowTemplate.Height = 28;
            this.dgv_LoaiKhachHang.Size = new System.Drawing.Size(861, 254);
            this.dgv_LoaiKhachHang.TabIndex = 0;
            this.dgv_LoaiKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiKhachHang_CellClick);
            this.dgv_LoaiKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiKhachHang_CellContentClick);
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Mã Loại KH";
            this.LoaiKH.MinimumWidth = 8;
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.Width = 150;
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.HeaderText = "Tên Loại Khách Hàng";
            this.TenLoaiKH.MinimumWidth = 8;
            this.TenLoaiKH.Name = "TenLoaiKH";
            this.TenLoaiKH.Width = 150;
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
            this.tsbXoaAll,
            this.toolStripSeparator1,
            this.tsbLuu,
            this.toolStripSeparator8});
            this.tsCTPN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsCTPN.Location = new System.Drawing.Point(0, 0);
            this.tsCTPN.Name = "tsCTPN";
            this.tsCTPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCTPN.Size = new System.Drawing.Size(896, 40);
            this.tsCTPN.TabIndex = 10;
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbXoaAll
            // 
            this.tsbXoaAll.Image = global::DACN.Properties.Resources.Delete;
            this.tsbXoaAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoaAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaAll.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoaAll.Name = "tsbXoaAll";
            this.tsbXoaAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoaAll.Size = new System.Drawing.Size(136, 36);
            this.tsbXoaAll.Text = " Xóa all";
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
            // txt_MaLoaiKH
            // 
            this.txt_MaLoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaLoaiKH.Location = new System.Drawing.Point(173, 95);
            this.txt_MaLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaLoaiKH.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MaLoaiKH.Name = "txt_MaLoaiKH";
            this.txt_MaLoaiKH.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MaLoaiKH.ShowText = false;
            this.txt_MaLoaiKH.Size = new System.Drawing.Size(150, 39);
            this.txt_MaLoaiKH.TabIndex = 11;
            this.txt_MaLoaiKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MaLoaiKH.Watermark = "";
            // 
            // txt_TenLoaiKH
            // 
            this.txt_TenLoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenLoaiKH.Location = new System.Drawing.Point(523, 95);
            this.txt_TenLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenLoaiKH.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_TenLoaiKH.Name = "txt_TenLoaiKH";
            this.txt_TenLoaiKH.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TenLoaiKH.ShowText = false;
            this.txt_TenLoaiKH.Size = new System.Drawing.Size(150, 29);
            this.txt_TenLoaiKH.TabIndex = 12;
            this.txt_TenLoaiKH.Text = "uiTextBox2";
            this.txt_TenLoaiKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TenLoaiKH.Watermark = "";
            this.txt_TenLoaiKH.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Loại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(374, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Loại ";
            // 
            // FormLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenLoaiKH);
            this.Controls.Add(this.txt_MaLoaiKH);
            this.Controls.Add(this.tsCTPN);
            this.Controls.Add(this.dgv_LoaiKhachHang);
            this.Name = "FormLoaiKhachHang";
            this.Text = "LoaiKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).EndInit();
            this.tsCTPN.ResumeLayout(false);
            this.tsCTPN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
        private System.Windows.Forms.ToolStrip tsCTPN;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbXoaAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private Sunny.UI.UITextBox txt_MaLoaiKH;
        private Sunny.UI.UITextBox txt_TenLoaiKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}