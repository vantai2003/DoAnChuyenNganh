namespace DACN.GUI
{
    partial class FormQLTonKho
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
            this.pannel_body = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dvg_TonKho = new Sunny.UI.UIDataGridView();
            this.pannel_body.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // pannel_body
            // 
            this.pannel_body.Controls.Add(this.uiPanel2);
            this.pannel_body.Controls.Add(this.uiPanel1);
            this.pannel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannel_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pannel_body.Location = new System.Drawing.Point(0, 0);
            this.pannel_body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pannel_body.MinimumSize = new System.Drawing.Size(1, 1);
            this.pannel_body.Name = "pannel_body";
            this.pannel_body.Size = new System.Drawing.Size(1214, 675);
            this.pannel_body.TabIndex = 0;
            this.pannel_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Lime;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.uiPanel1.ForeColor = System.Drawing.Color.Lime;
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1214, 98);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "QUẢN LÝ TỒN KHO";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.dvg_TonKho);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 98);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1214, 577);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_TonKho
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_TonKho.BackgroundColor = System.Drawing.Color.White;
            this.dvg_TonKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_TonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_TonKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_TonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvg_TonKho.EnableHeadersVisualStyles = false;
            this.dvg_TonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_TonKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.Location = new System.Drawing.Point(0, 0);
            this.dvg_TonKho.Name = "dvg_TonKho";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_TonKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_TonKho.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_TonKho.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_TonKho.RowTemplate.Height = 24;
            this.dvg_TonKho.SelectedIndex = -1;
            this.dvg_TonKho.Size = new System.Drawing.Size(1214, 483);
            this.dvg_TonKho.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.TabIndex = 0;
            // 
            // FormQLTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 675);
            this.Controls.Add(this.pannel_body);
            this.Name = "FormQLTonKho";
            this.Text = "FormQLTonKho";
            this.pannel_body.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pannel_body;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dvg_TonKho;
    }
}