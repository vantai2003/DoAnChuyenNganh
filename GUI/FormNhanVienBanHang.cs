using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormNhanVienBanHang : Form
    {
        public FormNhanVienBanHang()
        {
            InitializeComponent();
            this.Width = 1450;
            this.Height = 800;

            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //if (currentFormChild != null)
            //{
            //    currentFormChild.Close();
            //}

            //currentFormChild = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;

            //childForm.AutoSize = true;
            //childForm.AutoScaleMode = AutoScaleMode.None;


            //childForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //childForm.Dock = DockStyle.Fill;

            //childForm.Size = panel_body.ClientSize;


            //panel_body.Resize += (s, e) =>
            //{
            //    childForm.Size = panel_body.ClientSize;
            //};

            //panel_body.Controls.Add(childForm);
            //panel_body.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
        }
        
        private void btn_CapNhatDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhMuc());
            
        }

        private void btn_QLHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLHangHoa());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap.nhanvien = string.Empty;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.Show();
            }
        }

        private void btn_LapPhieuBanHang_Click(object sender, EventArgs e)
        {
            FormQLBanHang formQLBanHang = new FormQLBanHang() {};
            OpenChildForm(formQLBanHang);
        }

        private void btn_QLKhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhuyenMai());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiMatKhau());
        }

        private void pn0_Paint(object sender, PaintEventArgs e)
        {
            //using (Pen pen = new Pen(Color.White, 5)) 
            //{
            //    e.Graphics.DrawRectangle(pen, 0, 0, this.pn0.ClientRectangle.Width - 1, this.pn0.ClientRectangle.Height - 1);
            //}
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTTNguoiDung());
        }
    }
}
