
namespace DACN.GUI
{
    partial class FormThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTienmat = new System.Windows.Forms.RadioButton();
            this.rdbThe = new System.Windows.Forms.RadioButton();
            this.txt_sothe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongtienhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.txt_tienkm = new System.Windows.Forms.TextBox();
            this.txt_tienthanhtoan = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.txt_tiencantra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương Thức Thanh Toán";
            // 
            // rdbTienmat
            // 
            this.rdbTienmat.AutoSize = true;
            this.rdbTienmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTienmat.Location = new System.Drawing.Point(78, 99);
            this.rdbTienmat.Name = "rdbTienmat";
            this.rdbTienmat.Size = new System.Drawing.Size(288, 36);
            this.rdbTienmat.TabIndex = 1;
            this.rdbTienmat.TabStop = true;
            this.rdbTienmat.Text = "Thanh toán tiền mặt";
            this.rdbTienmat.UseVisualStyleBackColor = true;
            // 
            // rdbThe
            // 
            this.rdbThe.AutoSize = true;
            this.rdbThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbThe.Location = new System.Drawing.Point(606, 99);
            this.rdbThe.Name = "rdbThe";
            this.rdbThe.Size = new System.Drawing.Size(234, 36);
            this.rdbThe.TabIndex = 2;
            this.rdbThe.TabStop = true;
            this.rdbThe.Text = "Thanh toán thẻ ";
            this.rdbThe.UseVisualStyleBackColor = true;
            this.rdbThe.CheckedChanged += new System.EventHandler(this.rdbThe_CheckedChanged);
            // 
            // txt_sothe
            // 
            this.txt_sothe.Location = new System.Drawing.Point(274, 209);
            this.txt_sothe.Name = "txt_sothe";
            this.txt_sothe.Size = new System.Drawing.Size(434, 22);
            this.txt_sothe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(91, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số thẻ";
            // 
            // txt_tongtienhang
            // 
            this.txt_tongtienhang.Enabled = false;
            this.txt_tongtienhang.Location = new System.Drawing.Point(274, 260);
            this.txt_tongtienhang.Name = "txt_tongtienhang";
            this.txt_tongtienhang.Size = new System.Drawing.Size(434, 22);
            this.txt_tongtienhang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(91, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(91, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiền đặt cọc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(91, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền khuyến mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(91, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiền thanh toán";
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.Enabled = false;
            this.txt_tiencoc.Location = new System.Drawing.Point(274, 314);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Size = new System.Drawing.Size(434, 22);
            this.txt_tiencoc.TabIndex = 10;
            // 
            // txt_tienkm
            // 
            this.txt_tienkm.Enabled = false;
            this.txt_tienkm.Location = new System.Drawing.Point(274, 356);
            this.txt_tienkm.Name = "txt_tienkm";
            this.txt_tienkm.Size = new System.Drawing.Size(434, 22);
            this.txt_tienkm.TabIndex = 11;
            // 
            // txt_tienthanhtoan
            // 
            this.txt_tienthanhtoan.Location = new System.Drawing.Point(274, 447);
            this.txt_tienthanhtoan.Name = "txt_tienthanhtoan";
            this.txt_tienthanhtoan.Size = new System.Drawing.Size(434, 22);
            this.txt_tienthanhtoan.TabIndex = 12;
            this.txt_tienthanhtoan.TextChanged += new System.EventHandler(this.txt_tienthanhtoan_TextChanged);
            this.txt_tienthanhtoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tienthanhtoan_KeyPress);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.Red;
            this.btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacnhan.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnXacnhan.Location = new System.Drawing.Point(487, 500);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(146, 45);
            this.btnXacnhan.TabIndex = 13;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txt_tiencantra
            // 
            this.txt_tiencantra.Enabled = false;
            this.txt_tiencantra.Location = new System.Drawing.Point(274, 409);
            this.txt_tiencantra.Name = "txt_tiencantra";
            this.txt_tiencantra.Size = new System.Drawing.Size(434, 22);
            this.txt_tiencantra.TabIndex = 15;
            this.txt_tiencantra.TextChanged += new System.EventHandler(this.txt_tiencantra_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(91, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số tiền cần trả";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 557);
            this.Controls.Add(this.txt_tiencantra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txt_tienthanhtoan);
            this.Controls.Add(this.txt_tienkm);
            this.Controls.Add(this.txt_tiencoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tongtienhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sothe);
            this.Controls.Add(this.rdbThe);
            this.Controls.Add(this.rdbTienmat);
            this.Controls.Add(this.label1);
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThanhToan_FormClosed);
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTienmat;
        private System.Windows.Forms.RadioButton rdbThe;
        private System.Windows.Forms.TextBox txt_sothe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongtienhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.TextBox txt_tienkm;
        private System.Windows.Forms.TextBox txt_tienthanhtoan;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.TextBox txt_tiencantra;
        private System.Windows.Forms.Label label7;
    }
}