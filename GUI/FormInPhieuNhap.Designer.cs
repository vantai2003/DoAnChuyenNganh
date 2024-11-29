namespace DACN.GUI
{
    partial class FormInPhieuNhap
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
            this.rp_PhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_PhieuNhap
            // 
            this.rp_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_PhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.rp_PhieuNhap.Name = "rp_PhieuNhap";
            this.rp_PhieuNhap.ServerReport.BearerToken = null;
            this.rp_PhieuNhap.Size = new System.Drawing.Size(800, 450);
            this.rp_PhieuNhap.TabIndex = 0;
            // 
            // FormInPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rp_PhieuNhap);
            this.Name = "FormInPhieuNhap";
            this.Text = "FormInPhieuNhap";
            this.Load += new System.EventHandler(this.FormInPhieuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_PhieuNhap;
    }
}