namespace DACN.GUI
{
    partial class FormChiTietPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mn_CTPN = new System.Windows.Forms.MenuStrip();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.dvg_CTPN = new Sunny.UI.UIDataGridView();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btn_PheDuyet = new System.Windows.Forms.Button();
            this.btn_TuChoi = new System.Windows.Forms.Button();
            this.mn_CTPN.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_CTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // mn_CTPN
            // 
            this.mn_CTPN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mn_CTPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mn_CTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mn_CTPN.Location = new System.Drawing.Point(0, 0);
            this.mn_CTPN.Name = "mn_CTPN";
            this.mn_CTPN.Size = new System.Drawing.Size(1141, 36);
            this.mn_CTPN.TabIndex = 0;
            this.mn_CTPN.Text = "menuStrip1";
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Image = global::DACN.Properties.Resources.Print1;
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.inToolStripMenuItem.Text = "In";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::DACN.Properties.Resources.Close2;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiPanel3);
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 36);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1141, 630);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.btn_TuChoi);
            this.uiPanel3.Controls.Add(this.btn_PheDuyet);
            this.uiPanel3.Controls.Add(this.dvg_CTPN);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 76);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1141, 554);
            this.uiPanel3.TabIndex = 1;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_CTPN
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_CTPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dvg_CTPN.BackgroundColor = System.Drawing.Color.White;
            this.dvg_CTPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_CTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dvg_CTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_CTPN.DefaultCellStyle = dataGridViewCellStyle23;
            this.dvg_CTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvg_CTPN.EnableHeadersVisualStyles = false;
            this.dvg_CTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_CTPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_CTPN.Location = new System.Drawing.Point(0, 0);
            this.dvg_CTPN.Name = "dvg_CTPN";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_CTPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dvg_CTPN.RowHeadersWidth = 51;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_CTPN.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dvg_CTPN.RowTemplate.Height = 24;
            this.dvg_CTPN.SelectedIndex = -1;
            this.dvg_CTPN.Size = new System.Drawing.Size(1141, 319);
            this.dvg_CTPN.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_CTPN.TabIndex = 0;
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1141, 76);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = "CHI TIẾT PHIẾU NHẬP HÀNG";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PheDuyet
            // 
            this.btn_PheDuyet.Location = new System.Drawing.Point(249, 381);
            this.btn_PheDuyet.Name = "btn_PheDuyet";
            this.btn_PheDuyet.Size = new System.Drawing.Size(116, 46);
            this.btn_PheDuyet.TabIndex = 3;
            this.btn_PheDuyet.Text = "Phê duyệt";
            this.btn_PheDuyet.UseVisualStyleBackColor = true;
            this.btn_PheDuyet.Click += new System.EventHandler(this.btn_PheDuyet_Click);
            // 
            // btn_TuChoi
            // 
            this.btn_TuChoi.Location = new System.Drawing.Point(600, 381);
            this.btn_TuChoi.Name = "btn_TuChoi";
            this.btn_TuChoi.Size = new System.Drawing.Size(113, 47);
            this.btn_TuChoi.TabIndex = 4;
            this.btn_TuChoi.Text = "Từ chối";
            this.btn_TuChoi.UseVisualStyleBackColor = true;
            this.btn_TuChoi.Click += new System.EventHandler(this.btn_TuChoi_Click);
            // 
            // FormChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 666);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.mn_CTPN);
            this.MainMenuStrip = this.mn_CTPN;
            this.Name = "FormChiTietPhieuNhap";
            this.Text = "FormChiTietPhieuNhap";
            this.mn_CTPN.ResumeLayout(false);
            this.mn_CTPN.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_CTPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn_CTPN;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDataGridView dvg_CTPN;
        private System.Windows.Forms.Button btn_PheDuyet;
        private System.Windows.Forms.Button btn_TuChoi;
    }
}