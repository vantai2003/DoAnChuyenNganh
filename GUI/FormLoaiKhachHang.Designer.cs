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
            this.label1 = new System.Windows.Forms.Label();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiKhachHang
            // 
            this.dgv_LoaiKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiKH,
            this.TenLoaiKH});
            this.dgv_LoaiKhachHang.Location = new System.Drawing.Point(59, 96);
            this.dgv_LoaiKhachHang.Name = "dgv_LoaiKhachHang";
            this.dgv_LoaiKhachHang.RowHeadersWidth = 62;
            this.dgv_LoaiKhachHang.RowTemplate.Height = 28;
            this.dgv_LoaiKhachHang.Size = new System.Drawing.Size(682, 311);
            this.dgv_LoaiKhachHang.TabIndex = 0;
            this.dgv_LoaiKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiKhachHang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Khách Hàng";
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
            // FormLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LoaiKhachHang);
            this.Name = "FormLoaiKhachHang";
            this.Text = "LoaiKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
    }
}