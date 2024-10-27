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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiSanPham));
            this.pannel_Body = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dvg_LoaiSP = new Sunny.UI.UIDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_TenLoaiSP = new Sunny.UI.UITextBox();
            this.txt_MaLoaiSP = new Sunny.UI.UITextBox();
            this.lb_TenLoai = new System.Windows.Forms.Label();
            this.lbMaLoai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pannel_Body.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannel_Body
            // 
            this.pannel_Body.Controls.Add(this.panel3);
            this.pannel_Body.Controls.Add(this.panel1);
            this.pannel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannel_Body.Location = new System.Drawing.Point(0, 0);
            this.pannel_Body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pannel_Body.Name = "pannel_Body";
            this.pannel_Body.Size = new System.Drawing.Size(1004, 557);
            this.pannel_Body.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 450);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.dvg_LoaiSP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 450);
            this.panel5.TabIndex = 1;
            // 
            // dvg_LoaiSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_LoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_LoaiSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvg_LoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dvg_LoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_LoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_LoaiSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_LoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_LoaiSP.EnableHeadersVisualStyles = false;
            this.dvg_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.GridColor = System.Drawing.Color.DarkGreen;
            this.dvg_LoaiSP.Location = new System.Drawing.Point(0, 0);
            this.dvg_LoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvg_LoaiSP.Name = "dvg_LoaiSP";
            this.dvg_LoaiSP.RectColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_LoaiSP.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_LoaiSP.RowTemplate.Height = 24;
            this.dvg_LoaiSP.SelectedIndex = -1;
            this.dvg_LoaiSP.Size = new System.Drawing.Size(573, 450);
            this.dvg_LoaiSP.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.TabIndex = 0;
            this.dvg_LoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_LoaiSP_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btn_Sua);
            this.panel4.Controls.Add(this.btn_Xoa);
            this.panel4.Controls.Add(this.txt_TenLoaiSP);
            this.panel4.Controls.Add(this.txt_MaLoaiSP);
            this.panel4.Controls.Add(this.lb_TenLoai);
            this.panel4.Controls.Add(this.lbMaLoai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(573, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 450);
            this.panel4.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(18, 174);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 65);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(295, 174);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 65);
            this.btn_Sua.TabIndex = 52;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(160, 174);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 65);
            this.btn_Xoa.TabIndex = 51;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_TenLoaiSP
            // 
            this.txt_TenLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenLoaiSP.Location = new System.Drawing.Point(134, 90);
            this.txt_TenLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenLoaiSP.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_TenLoaiSP.Name = "txt_TenLoaiSP";
            this.txt_TenLoaiSP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenLoaiSP.ShowText = false;
            this.txt_TenLoaiSP.Size = new System.Drawing.Size(259, 23);
            this.txt_TenLoaiSP.TabIndex = 3;
            this.txt_TenLoaiSP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_TenLoaiSP.Watermark = "";
            // 
            // txt_MaLoaiSP
            // 
            this.txt_MaLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MaLoaiSP.Location = new System.Drawing.Point(134, 19);
            this.txt_MaLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaLoaiSP.MinimumSize = new System.Drawing.Size(1, 13);
            this.txt_MaLoaiSP.Name = "txt_MaLoaiSP";
            this.txt_MaLoaiSP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaLoaiSP.ShowText = false;
            this.txt_MaLoaiSP.Size = new System.Drawing.Size(259, 23);
            this.txt_MaLoaiSP.TabIndex = 2;
            this.txt_MaLoaiSP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MaLoaiSP.Watermark = "";
            // 
            // lb_TenLoai
            // 
            this.lb_TenLoai.AutoSize = true;
            this.lb_TenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenLoai.ForeColor = System.Drawing.Color.Yellow;
            this.lb_TenLoai.Location = new System.Drawing.Point(53, 94);
            this.lb_TenLoai.Name = "lb_TenLoai";
            this.lb_TenLoai.Size = new System.Drawing.Size(68, 20);
            this.lb_TenLoai.TabIndex = 1;
            this.lb_TenLoai.Text = "Tên loại";
            // 
            // lbMaLoai
            // 
            this.lbMaLoai.AutoSize = true;
            this.lbMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoai.ForeColor = System.Drawing.Color.Yellow;
            this.lbMaLoai.Location = new System.Drawing.Point(53, 30);
            this.lbMaLoai.Name = "lbMaLoai";
            this.lbMaLoai.Size = new System.Drawing.Size(63, 20);
            this.lbMaLoai.TabIndex = 0;
            this.lbMaLoai.Text = "Mã loại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.uiGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 107);
            this.panel1.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txt_Search);
            this.uiGroupBox1.Controls.Add(this.btn_Search);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(68, 11);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(720, 90);
            this.uiGroupBox1.TabIndex = 15;
            this.uiGroupBox1.Text = "Tìm kiếm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Search.Location = new System.Drawing.Point(77, 37);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Search.ShowText = false;
            this.txt_Search.Size = new System.Drawing.Size(295, 29);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Search.Watermark = "";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(379, 28);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 44);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1004, 557);
            this.Controls.Add(this.pannel_Body);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoaiSanPham";
            this.Text = "Loại Sản Phẩm";
            this.pannel_Body.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pannel_Body;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIDataGridView dvg_LoaiSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITextBox txt_TenLoaiSP;
        private Sunny.UI.UITextBox txt_MaLoaiSP;
        private System.Windows.Forms.Label lb_TenLoai;
        private System.Windows.Forms.Label lbMaLoai;
        private Sunny.UI.UITextBox txt_Search;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Search;
        private Sunny.UI.UIGroupBox uiGroupBox1;
    }
}