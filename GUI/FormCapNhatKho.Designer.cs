namespace DACN.GUI
{
    partial class FormCapNhatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatKho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_TaoPhieuTH = new System.Windows.Forms.Button();
            this.btn_CapNhatKho = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvg_CapNhatKho = new Sunny.UI.UIDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_CapNhatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 677);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_TaoPhieuTH);
            this.panel4.Controls.Add(this.btn_CapNhatKho);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1449, 201);
            this.panel4.TabIndex = 2;
            // 
            // btn_TaoPhieuTH
            // 
            this.btn_TaoPhieuTH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_TaoPhieuTH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TaoPhieuTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuTH.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPhieuTH.Location = new System.Drawing.Point(700, 56);
            this.btn_TaoPhieuTH.Name = "btn_TaoPhieuTH";
            this.btn_TaoPhieuTH.Size = new System.Drawing.Size(202, 53);
            this.btn_TaoPhieuTH.TabIndex = 1;
            this.btn_TaoPhieuTH.Text = "Tạo phiếu trả hàng";
            this.btn_TaoPhieuTH.UseVisualStyleBackColor = false;
            this.btn_TaoPhieuTH.Click += new System.EventHandler(this.btn_TaoPhieuTH_Click);
            // 
            // btn_CapNhatKho
            // 
            this.btn_CapNhatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CapNhatKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatKho.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CapNhatKho.Location = new System.Drawing.Point(177, 57);
            this.btn_CapNhatKho.Name = "btn_CapNhatKho";
            this.btn_CapNhatKho.Size = new System.Drawing.Size(179, 52);
            this.btn_CapNhatKho.TabIndex = 0;
            this.btn_CapNhatKho.Text = "Cập nhật vào kho";
            this.btn_CapNhatKho.UseVisualStyleBackColor = false;
            this.btn_CapNhatKho.Click += new System.EventHandler(this.btn_CapNhatKho_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvg_CapNhatKho);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1449, 426);
            this.panel3.TabIndex = 1;
            // 
            // dvg_CapNhatKho
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_CapNhatKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_CapNhatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_CapNhatKho.BackgroundColor = System.Drawing.Color.White;
            this.dvg_CapNhatKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_CapNhatKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_CapNhatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_CapNhatKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_CapNhatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_CapNhatKho.EnableHeadersVisualStyles = false;
            this.dvg_CapNhatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_CapNhatKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvg_CapNhatKho.Location = new System.Drawing.Point(0, 0);
            this.dvg_CapNhatKho.Name = "dvg_CapNhatKho";
            this.dvg_CapNhatKho.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_CapNhatKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_CapNhatKho.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_CapNhatKho.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_CapNhatKho.RowTemplate.Height = 24;
            this.dvg_CapNhatKho.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvg_CapNhatKho.ScrollBarStyleInherited = false;
            this.dvg_CapNhatKho.SelectedIndex = -1;
            this.dvg_CapNhatKho.Size = new System.Drawing.Size(1449, 426);
            this.dvg_CapNhatKho.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_CapNhatKho.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1449, 50);
            this.panel2.TabIndex = 0;
            // 
            // FormCapNhatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 677);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhatKho";
            this.Text = "CẬP NHẬT VÀO KHO";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_CapNhatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIDataGridView dvg_CapNhatKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaoPhieuTH;
        private System.Windows.Forms.Button btn_CapNhatKho;
    }
}