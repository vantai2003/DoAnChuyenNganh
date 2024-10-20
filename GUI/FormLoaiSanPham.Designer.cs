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
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
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
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(107, 378);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 24;
            this.uiDatePicker1.TabIndex = 2;
            this.uiDatePicker1.Text = "uiDatePicker1";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2024, 10, 20, 16, 5, 54, 184);
            this.uiDatePicker1.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(432, 65);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "uiSymbolButton1";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // FormLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiDatePicker1);
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
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}