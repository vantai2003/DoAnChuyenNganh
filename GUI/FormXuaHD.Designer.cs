namespace DACN.GUI
{
    partial class FormXuaHD
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
            this.rpV_HD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpV_HD
            // 
            this.rpV_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpV_HD.Location = new System.Drawing.Point(0, 0);
            this.rpV_HD.Name = "rpV_HD";
            this.rpV_HD.ServerReport.BearerToken = null;
            this.rpV_HD.Size = new System.Drawing.Size(800, 450);
            this.rpV_HD.TabIndex = 0;
            // 
            // FormXuaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpV_HD);
            this.Name = "FormXuaHD";
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FormXuaHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpV_HD;
    }
}