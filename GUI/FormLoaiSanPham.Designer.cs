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
            this.dvg_LoaiSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_LoaiSP
            // 
            this.dvg_LoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_LoaiSP.Location = new System.Drawing.Point(26, 126);
            this.dvg_LoaiSP.Name = "dvg_LoaiSP";
            this.dvg_LoaiSP.RowHeadersWidth = 51;
            this.dvg_LoaiSP.RowTemplate.Height = 24;
            this.dvg_LoaiSP.Size = new System.Drawing.Size(724, 232);
            this.dvg_LoaiSP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_LoaiSP);
            this.Name = "FormLoaiSanPham";
            this.Text = "FormLoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_LoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_LoaiSP;
        private System.Windows.Forms.Label label1;
    }
}