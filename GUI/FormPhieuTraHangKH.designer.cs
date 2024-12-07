
namespace DACN.GUI
{
    partial class FormPhieuTraHangKH
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
            this.dvg_TaoPTH = new Sunny.UI.UIDataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_TaoPhieu = new System.Windows.Forms.Button();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.cbbKho = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_lydo = new Sunny.UI.UIRichTextBox();
            this.btn_taophieuKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TaoPTH)).BeginInit();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg_TaoPTH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TaoPTH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_TaoPTH.BackgroundColor = System.Drawing.Color.White;
            this.dvg_TaoPTH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_TaoPTH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_TaoPTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_TaoPTH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_TaoPTH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_TaoPTH.EnableHeadersVisualStyles = false;
            this.dvg_TaoPTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_TaoPTH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dvg_TaoPTH.Location = new System.Drawing.Point(0, 98);
            this.dvg_TaoPTH.Name = "dvg_TaoPTH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_TaoPTH.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_TaoPTH.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dvg_TaoPTH.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_TaoPTH.RowTemplate.Height = 24;
            this.dvg_TaoPTH.SelectedIndex = -1;
            this.dvg_TaoPTH.Size = new System.Drawing.Size(1179, 495);
            this.dvg_TaoPTH.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TaoPTH.TabIndex = 4;
            this.dvg_TaoPTH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_TaoPTH_CellContentClick);
            this.dvg_TaoPTH.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_TaoPTH_CellEndEdit);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 472);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // btn_TaoPhieu
            // 
            this.btn_TaoPhieu.Location = new System.Drawing.Point(642, 492);
            this.btn_TaoPhieu.Name = "btn_TaoPhieu";
            this.btn_TaoPhieu.Size = new System.Drawing.Size(214, 50);
            this.btn_TaoPhieu.TabIndex = 5;
            this.btn_TaoPhieu.Text = "Tạo phiếu";
            this.btn_TaoPhieu.UseVisualStyleBackColor = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1179, 98);
            this.uiPanel2.TabIndex = 6;
            this.uiPanel2.Text = "TẠO PHIẾU TRẢ HÀNG ";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.cbbKho);
            this.uiPanel4.Controls.Add(this.label1);
            this.uiPanel4.Controls.Add(this.rtb_lydo);
            this.uiPanel4.Controls.Add(this.btn_taophieuKH);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 376);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(1179, 217);
            this.uiPanel4.TabIndex = 9;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel4.Click += new System.EventHandler(this.uiPanel4_Click);
            // 
            // cbbKho
            // 
            this.cbbKho.DataSource = null;
            this.cbbKho.FillColor = System.Drawing.Color.White;
            this.cbbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKho.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbKho.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbKho.Location = new System.Drawing.Point(577, 89);
            this.cbbKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbKho.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbKho.Name = "cbbKho";
            this.cbbKho.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbKho.Size = new System.Drawing.Size(150, 29);
            this.cbbKho.SymbolSize = 24;
            this.cbbKho.TabIndex = 3;
            this.cbbKho.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbKho.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lý do";
            // 
            // rtb_lydo
            // 
            this.rtb_lydo.FillColor = System.Drawing.Color.White;
            this.rtb_lydo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_lydo.Location = new System.Drawing.Point(179, 42);
            this.rtb_lydo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_lydo.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtb_lydo.Name = "rtb_lydo";
            this.rtb_lydo.Padding = new System.Windows.Forms.Padding(2);
            this.rtb_lydo.ShowText = false;
            this.rtb_lydo.Size = new System.Drawing.Size(354, 106);
            this.rtb_lydo.TabIndex = 1;
            this.rtb_lydo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_taophieuKH
            // 
            this.btn_taophieuKH.Location = new System.Drawing.Point(763, 79);
            this.btn_taophieuKH.Name = "btn_taophieuKH";
            this.btn_taophieuKH.Size = new System.Drawing.Size(214, 50);
            this.btn_taophieuKH.TabIndex = 0;
            this.btn_taophieuKH.Text = "Tạo phiếu";
            this.btn_taophieuKH.UseVisualStyleBackColor = true;
            this.btn_taophieuKH.Click += new System.EventHandler(this.btn_taophieuKH_Click);
            // 
            // FormPhieuTraHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 593);
            this.Controls.Add(this.uiPanel4);
            this.Controls.Add(this.dvg_TaoPTH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TaoPhieu);
            this.Controls.Add(this.uiPanel2);
            this.Name = "FormPhieuTraHangKH";
            this.Text = "TẠO PHIẾU TRẢ HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TaoPTH)).EndInit();
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIDataGridView dvg_TaoPTH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_TaoPhieu;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel4;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIRichTextBox rtb_lydo;
        private System.Windows.Forms.Button btn_taophieuKH;
        private Sunny.UI.UIComboBox cbbKho;
    }
}