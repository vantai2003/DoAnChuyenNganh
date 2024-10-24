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
            this.lb_LoaiSP = new System.Windows.Forms.Label();
            this.dvg_LoaiSP = new Sunny.UI.UIDataGridView();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LoaiSP
            // 
            this.lb_LoaiSP.AutoSize = true;
            this.lb_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_LoaiSP.Location = new System.Drawing.Point(369, 61);
            this.lb_LoaiSP.Name = "lb_LoaiSP";
            this.lb_LoaiSP.Size = new System.Drawing.Size(237, 37);
            this.lb_LoaiSP.TabIndex = 1;
            this.lb_LoaiSP.Text = "Loại Sản Phẩm";
            // 
            // dvg_LoaiSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_LoaiSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dvg_LoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_LoaiSP.ColumnHeadersHeight = 32;
            this.dvg_LoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiSP,
            this.TenLoaiSP});
            this.dvg_LoaiSP.EnableHeadersVisualStyles = false;
            this.dvg_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dvg_LoaiSP.Location = new System.Drawing.Point(14, 156);
            this.dvg_LoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvg_LoaiSP.Name = "dvg_LoaiSP";
            this.dvg_LoaiSP.RectColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_LoaiSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_LoaiSP.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_LoaiSP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_LoaiSP.RowTemplate.Height = 24;
            this.dvg_LoaiSP.ScrollBarColor = System.Drawing.Color.Green;
            this.dvg_LoaiSP.ScrollBarRectColor = System.Drawing.Color.Green;
            this.dvg_LoaiSP.ScrollBarStyleInherited = false;
            this.dvg_LoaiSP.SelectedIndex = -1;
            this.dvg_LoaiSP.Size = new System.Drawing.Size(873, 234);
            this.dvg_LoaiSP.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_LoaiSP.TabIndex = 2;
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
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dvg_LoaiSP);
            this.Controls.Add(this.lb_LoaiSP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLoaiSanPham";
            this.Text = "FormLoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_LoaiSP;
        private Sunny.UI.UIDataGridView dvg_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
    }
}