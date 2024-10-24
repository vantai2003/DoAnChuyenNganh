namespace DACN.GUI
{
    partial class FormLoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_LoaiSP = new System.Windows.Forms.Label();
            this.dvg_LoaiSP = new Sunny.UI.UIDataGridView();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsbSearchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).BeginInit();
            this.tsCTPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_LoaiSP
            // 
            this.lb_LoaiSP.AutoSize = true;
            this.lb_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_LoaiSP.Location = new System.Drawing.Point(350, 62);
            this.lb_LoaiSP.Name = "lb_LoaiSP";
            this.lb_LoaiSP.Size = new System.Drawing.Size(237, 37);
            this.lb_LoaiSP.TabIndex = 1;
            this.lb_LoaiSP.Text = "Loại Sản Phẩm";
            // 
            // dvg_LoaiSP
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvg_LoaiSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dvg_LoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvg_LoaiSP.ColumnHeadersHeight = 32;
            this.dvg_LoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiSP,
            this.TenLoaiSP});
            this.dvg_LoaiSP.EnableHeadersVisualStyles = false;
            this.dvg_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dvg_LoaiSP.Location = new System.Drawing.Point(12, 291);
            this.dvg_LoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvg_LoaiSP.Name = "dvg_LoaiSP";
            this.dvg_LoaiSP.RectColor = System.Drawing.Color.Green;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dvg_LoaiSP.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvg_LoaiSP.RowTemplate.Height = 24;
            this.dvg_LoaiSP.ScrollBarColor = System.Drawing.Color.Green;
            this.dvg_LoaiSP.ScrollBarRectColor = System.Drawing.Color.Green;
            this.dvg_LoaiSP.ScrollBarStyleInherited = false;
            this.dvg_LoaiSP.SelectedIndex = -1;
            this.dvg_LoaiSP.Size = new System.Drawing.Size(873, 234);
            this.dvg_LoaiSP.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.TabIndex = 2;
            this.dvg_LoaiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_LoaiSP_CellContentClick);
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.HeaderText = "Mã Loại SP";
            this.MaLoaiSP.MinimumWidth = 8;
            this.MaLoaiSP.Name = "MaLoaiSP";
            this.MaLoaiSP.Width = 150;
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.HeaderText = "Tên Lọai SP";
            this.TenLoaiSP.MinimumWidth = 8;
            this.TenLoaiSP.Name = "TenLoaiSP";
            this.TenLoaiSP.Width = 150;
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
            this.toolStripSeparator8,
            this.tsbSearchtxt,
            this.tsbSearch});
            this.tsCTPN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsCTPN.Location = new System.Drawing.Point(0, 0);
            this.tsCTPN.Name = "tsCTPN";
            this.tsCTPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCTPN.Size = new System.Drawing.Size(900, 43);
            this.tsCTPN.TabIndex = 11;
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
            this.tsbThem.Size = new System.Drawing.Size(119, 39);
            this.tsbThem.Text = "Thêm";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::DACN.Properties.Resources.Edit;
            this.tsbSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSua.Size = new System.Drawing.Size(97, 39);
            this.tsbSua.Text = "Sửa";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::DACN.Properties.Resources.Delete;
            this.tsbXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoa.Size = new System.Drawing.Size(98, 39);
            this.tsbXoa.Text = "Xóa";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbXoaAll
            // 
            this.tsbXoaAll.Image = global::DACN.Properties.Resources.Delete;
            this.tsbXoaAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoaAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaAll.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoaAll.Name = "tsbXoaAll";
            this.tsbXoaAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoaAll.Size = new System.Drawing.Size(136, 39);
            this.tsbXoaAll.Text = " Xóa all";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::DACN.Properties.Resources.Save;
            this.tsbLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuu.Size = new System.Drawing.Size(97, 39);
            this.tsbLuu.Text = "Lưu";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbSearchtxt
            // 
            this.tsbSearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchtxt.Margin = new System.Windows.Forms.Padding(5, 2, 1, 2);
            this.tsbSearchtxt.Name = "tsbSearchtxt";
            this.tsbSearchtxt.Size = new System.Drawing.Size(199, 39);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::DACN.Properties.Resources.Search;
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(34, 38);
            this.tsbSearch.Text = "toolStripButton1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(54, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Loại ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Loại ";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox2.Location = new System.Drawing.Point(215, 180);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(162, 46);
            this.uiTextBox2.TabIndex = 16;
            this.uiTextBox2.Text = "uiTextBox2";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox1.Location = new System.Drawing.Point(215, 119);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 39);
            this.uiTextBox1.TabIndex = 15;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.tsCTPN);
            this.Controls.Add(this.dvg_LoaiSP);
            this.Controls.Add(this.lb_LoaiSP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLoaiSanPham";
            this.Text = "FormLoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).EndInit();
            this.tsCTPN.ResumeLayout(false);
            this.tsCTPN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_LoaiSP;
        private Sunny.UI.UIDataGridView dvg_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
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
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxt;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}