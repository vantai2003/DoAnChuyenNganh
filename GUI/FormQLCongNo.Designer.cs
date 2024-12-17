namespace DACN.GUI
{
    partial class FormQLCongNo
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txt_Search = new Sunny.UI.UITextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.dgv_CongNo = new Sunny.UI.UIDataGridView();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiPanel5);
            this.uiPanel1.Controls.Add(this.uiPanel4);
            this.uiPanel1.Controls.Add(this.uiPanel3);
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1041, 527);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(1041, 105);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = "QUẢN LÝ CÔNG NỢ";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btn_Search);
            this.uiGroupBox1.Controls.Add(this.txt_Search);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(64, 30);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(401, 79);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Tìm kiếm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Search.Location = new System.Drawing.Point(90, 37);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Search.ShowText = false;
            this.txt_Search.Size = new System.Drawing.Size(150, 29);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Search.Watermark = "";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(273, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 39);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.uiGroupBox1);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 105);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1041, 154);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 512);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(1041, 15);
            this.uiPanel4.TabIndex = 3;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.dgv_CongNo);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel5.Location = new System.Drawing.Point(0, 259);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Size = new System.Drawing.Size(1041, 253);
            this.uiPanel5.TabIndex = 4;
            this.uiPanel5.Text = "uiPanel5";
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_CongNo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_CongNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_CongNo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_CongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CongNo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CongNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CongNo.EnableHeadersVisualStyles = false;
            this.dgv_CongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_CongNo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_CongNo.Location = new System.Drawing.Point(0, 0);
            this.dgv_CongNo.Name = "dgv_CongNo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CongNo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CongNo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_CongNo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CongNo.RowTemplate.Height = 24;
            this.dgv_CongNo.SelectedIndex = -1;
            this.dgv_CongNo.Size = new System.Drawing.Size(1041, 253);
            this.dgv_CongNo.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_CongNo.TabIndex = 0;
            // 
            // FormQLCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 527);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormQLCongNo";
            this.Text = "FormQLCongNo";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Button btn_Search;
        private Sunny.UI.UITextBox txt_Search;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIDataGridView dgv_CongNo;
    }
}