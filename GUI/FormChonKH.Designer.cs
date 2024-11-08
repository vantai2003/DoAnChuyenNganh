namespace DACN.GUI
{
    partial class FormChonKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonKH));
            this.pndata = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lammoiHang = new System.Windows.Forms.Button();
            this.tbTimKiemHang = new System.Windows.Forms.TextBox();
            this.btnChon = new Sunny.UI.UIButton();
            this.dgvKhachHang = new Sunny.UI.UIDataGridView();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.txtChonMaKH = new System.Windows.Forms.TextBox();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pndata
            // 
            this.pndata.BackColor = System.Drawing.Color.White;
            this.pndata.Controls.Add(this.pcSearch);
            this.pndata.Controls.Add(this.label3);
            this.pndata.Controls.Add(this.btn_lammoiHang);
            this.pndata.Controls.Add(this.tbTimKiemHang);
            this.pndata.Location = new System.Drawing.Point(13, 29);
            this.pndata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(546, 89);
            this.pndata.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tìm kiếm";
            // 
            // btn_lammoiHang
            // 
            this.btn_lammoiHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_lammoiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoiHang.ForeColor = System.Drawing.Color.White;
            this.btn_lammoiHang.Location = new System.Drawing.Point(392, 18);
            this.btn_lammoiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lammoiHang.Name = "btn_lammoiHang";
            this.btn_lammoiHang.Size = new System.Drawing.Size(135, 53);
            this.btn_lammoiHang.TabIndex = 12;
            this.btn_lammoiHang.Text = "Làm Mới";
            this.btn_lammoiHang.UseVisualStyleBackColor = false;
            // 
            // tbTimKiemHang
            // 
            this.tbTimKiemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemHang.Location = new System.Drawing.Point(26, 36);
            this.tbTimKiemHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimKiemHang.Name = "tbTimKiemHang";
            this.tbTimKiemHang.Size = new System.Drawing.Size(302, 35);
            this.tbTimKiemHang.TabIndex = 11;
            // 
            // btnChon
            // 
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.Location = new System.Drawing.Point(628, 32);
            this.btnChon.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(205, 73);
            this.btnChon.TabIndex = 54;
            this.btnChon.Text = "Chọn";
            this.btnChon.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dgvKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 202);
            this.dgvKhachHang.Name = "dgvKhachHang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKhachHang.RowTemplate.Height = 28;
            this.dgvKhachHang.SelectedIndex = -1;
            this.dgvKhachHang.Size = new System.Drawing.Size(971, 265);
            this.dgvKhachHang.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.TabIndex = 53;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // pcSearch
            // 
            this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
            this.pcSearch.Location = new System.Drawing.Point(324, 28);
            this.pcSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(41, 39);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            // 
            // txtChonMaKH
            // 
            this.txtChonMaKH.Location = new System.Drawing.Point(13, 156);
            this.txtChonMaKH.Name = "txtChonMaKH";
            this.txtChonMaKH.Size = new System.Drawing.Size(138, 26);
            this.txtChonMaKH.TabIndex = 57;
            // 
            // FormChonKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 479);
            this.Controls.Add(this.txtChonMaKH);
            this.Controls.Add(this.pndata);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "FormChonKH";
            this.Text = "FormChonKH";
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pndata;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lammoiHang;
        private System.Windows.Forms.TextBox tbTimKiemHang;
        private Sunny.UI.UIButton btnChon;
        private Sunny.UI.UIDataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtChonMaKH;
    }
}