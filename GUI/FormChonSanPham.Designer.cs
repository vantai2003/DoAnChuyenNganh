namespace DACN.GUI
{
    partial class FormChonSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvg_ChonSP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ChonSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_Import);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 698);
            this.panel1.TabIndex = 0;
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Location = new System.Drawing.Point(157, 511);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(149, 65);
            this.btn_Import.TabIndex = 1;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 389);
            this.panel3.TabIndex = 1;
            // 
            // dvg_ChonSP
            // 
            this.dvg_ChonSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_ChonSP.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_ChonSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_ChonSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_ChonSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_ChonSP.EnableHeadersVisualStyles = false;
            this.dvg_ChonSP.Location = new System.Drawing.Point(0, 0);
            this.dvg_ChonSP.Name = "dvg_ChonSP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_ChonSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_ChonSP.RowHeadersWidth = 51;
            this.dvg_ChonSP.RowTemplate.Height = 24;
            this.dvg_ChonSP.Size = new System.Drawing.Size(908, 322);
            this.dvg_ChonSP.TabIndex = 0;
            this.dvg_ChonSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_ChonSP_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 100);
            this.panel2.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1230, 100);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "CHỌN SẢN PHẨM NHẬP HÀNG";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1230, 67);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 322);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1059, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 322);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dvg_ChonSP);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(151, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(908, 322);
            this.panel7.TabIndex = 4;
            // 
            // FormChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 698);
            this.Controls.Add(this.panel1);
            this.Name = "FormChonSanPham";
            this.Text = "CHỌN SẢN PHẨM NHẬP  HÀNG";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ChonSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvg_ChonSP;
        private System.Windows.Forms.Button btn_Import;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}