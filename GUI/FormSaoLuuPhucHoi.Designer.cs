﻿namespace DACN.GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btn_PhucHoi = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel2);
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(800, 450);
            this.panel_body.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_PhucHoi);
            this.panel2.Controls.Add(this.btn_SaoLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Location = new System.Drawing.Point(94, 75);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(75, 48);
            this.btn_SaoLuu.TabIndex = 0;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Location = new System.Drawing.Point(404, 75);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(107, 47);
            this.btn_PhucHoi.TabIndex = 1;
            this.btn_PhucHoi.Text = "Phục hồi";
            this.btn_PhucHoi.UseVisualStyleBackColor = true;
            this.btn_PhucHoi.Click += new System.EventHandler(this.btn_PhucHoi_Click);
            // 
            // FormSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Panel panel1;
    }
}