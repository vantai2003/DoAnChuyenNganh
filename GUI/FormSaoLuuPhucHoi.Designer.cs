namespace DACN.GUI
{
    partial class FormSaoLuuPhucHoi
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_PhucHoi = new System.Windows.Forms.Button();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel2);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(948, 512);
            this.panel_body.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uiPanel1);
            this.panel2.Controls.Add(this.btn_PhucHoi);
            this.panel2.Controls.Add(this.btn_SaoLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 512);
            this.panel2.TabIndex = 1;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(948, 146);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "SAO LƯU VÀ PHỤC HỒI";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.BackColor = System.Drawing.Color.White;
            this.btn_PhucHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhucHoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhucHoi.ForeColor = System.Drawing.Color.Black;
            this.btn_PhucHoi.Image = global::DACN.Properties.Resources.icons8_restore_65;
            this.btn_PhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhucHoi.Location = new System.Drawing.Point(659, 312);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(190, 92);
            this.btn_PhucHoi.TabIndex = 1;
            this.btn_PhucHoi.Text = "Phục hồi";
            this.btn_PhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PhucHoi.UseVisualStyleBackColor = false;
            this.btn_PhucHoi.Click += new System.EventHandler(this.btn_PhucHoi_Click);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.BackColor = System.Drawing.Color.White;
            this.btn_SaoLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaoLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaoLuu.ForeColor = System.Drawing.Color.Black;
            this.btn_SaoLuu.Image = global::DACN.Properties.Resources.icons8_cloud_backup_restore_65;
            this.btn_SaoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaoLuu.Location = new System.Drawing.Point(106, 312);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(185, 92);
            this.btn_SaoLuu.TabIndex = 0;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaoLuu.UseVisualStyleBackColor = false;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // FormSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 512);
            this.Controls.Add(this.panel_body);
            this.Name = "FormSaoLuuPhucHoi";
            this.Text = "FormSaoLuuPhucHoi";
            this.panel_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PhucHoi;
        private System.Windows.Forms.Button btn_SaoLuu;
        private Sunny.UI.UIPanel uiPanel1;
    }
}