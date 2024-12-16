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
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.dvg_TonKho = new Sunny.UI.UIDataGridView();
            this.panel_Top = new Sunny.UI.UIPanel();
            this.btn_Loc = new Sunny.UI.UIButton();
            this.cb_Kho = new System.Windows.Forms.ComboBox();
            this.txt_search = new Sunny.UI.UITextBox();
            this.rgb_Loc = new Sunny.UI.UIRadioButtonGroup();
            this.rdb_Kho = new Sunny.UI.UIRadioButton();
            this.rdb_SanPham = new Sunny.UI.UIRadioButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pannel_body.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TonKho)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.rgb_Loc.SuspendLayout();
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
            this.pannel_body.Text = null;
            this.pannel_body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Controls.Add(this.panel_Top);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 98);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1214, 577);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.dvg_TonKho);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 108);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1214, 469);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = "uiPanel3";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvg_TonKho
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_TonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_TonKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dvg_TonKho.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.dvg_TonKho.Size = new System.Drawing.Size(1214, 469);
            this.dvg_TonKho.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_TonKho.TabIndex = 0;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.btn_Loc);
            this.panel_Top.Controls.Add(this.cb_Kho);
            this.panel_Top.Controls.Add(this.txt_search);
            this.panel_Top.Controls.Add(this.rgb_Loc);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Top.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1214, 108);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.Text = null;
            this.panel_Top.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Loc.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Loc.Location = new System.Drawing.Point(930, 33);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Loc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(127, 45);
            this.btn_Loc.TabIndex = 5;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Loc.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cb_Kho
            // 
            this.cb_Kho.Enabled = false;
            this.cb_Kho.FormattingEnabled = true;
            this.cb_Kho.Location = new System.Drawing.Point(627, 38);
            this.cb_Kho.Name = "cb_Kho";
            this.cb_Kho.Size = new System.Drawing.Size(297, 33);
            this.cb_Kho.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Enabled = false;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_search.Location = new System.Drawing.Point(423, 35);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_search.ShowText = false;
            this.txt_search.Size = new System.Drawing.Size(197, 40);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_search.Watermark = "";
            // 
            // rgb_Loc
            // 
            this.rgb_Loc.Controls.Add(this.rdb_Kho);
            this.rgb_Loc.Controls.Add(this.rdb_SanPham);
            this.rgb_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rgb_Loc.Location = new System.Drawing.Point(29, 5);
            this.rgb_Loc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgb_Loc.MinimumSize = new System.Drawing.Size(1, 1);
            this.rgb_Loc.Name = "rgb_Loc";
            this.rgb_Loc.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.rgb_Loc.Size = new System.Drawing.Size(358, 79);
            this.rgb_Loc.TabIndex = 1;
            this.rgb_Loc.Text = "Lọc theo";
            this.rgb_Loc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdb_Kho
            // 
            this.rdb_Kho.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb_Kho.Location = new System.Drawing.Point(240, 35);
            this.rdb_Kho.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_Kho.Name = "rdb_Kho";
            this.rdb_Kho.Size = new System.Drawing.Size(100, 29);
            this.rdb_Kho.TabIndex = 1;
            this.rdb_Kho.Text = "Kho";
            this.rdb_Kho.CheckedChanged += new System.EventHandler(this.rdb_Kho_CheckedChanged);
            // 
            // rdb_SanPham
            // 
            this.rdb_SanPham.BackColor = System.Drawing.Color.Transparent;
            this.rdb_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb_SanPham.Location = new System.Drawing.Point(19, 35);
            this.rdb_SanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdb_SanPham.Name = "rdb_SanPham";
            this.rdb_SanPham.Size = new System.Drawing.Size(150, 29);
            this.rdb_SanPham.TabIndex = 0;
            this.rdb_SanPham.Text = "Sản phẩm";
            this.rdb_SanPham.CheckedChanged += new System.EventHandler(this.rdb_SanPham_CheckedChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(1214, 98);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "QUẢN LÝ TỒN KHO";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TonKho)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.rgb_Loc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pannel_body;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dvg_TonKho;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel panel_Top;
        private Sunny.UI.UIRadioButtonGroup rgb_Loc;
        private System.Windows.Forms.ComboBox cb_Kho;
        private Sunny.UI.UITextBox txt_search;
        private Sunny.UI.UIRadioButton rdb_Kho;
        private Sunny.UI.UIRadioButton rdb_SanPham;
        private Sunny.UI.UIButton btn_Loc;
    }
}