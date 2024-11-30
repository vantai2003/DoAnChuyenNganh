using DACN.DTO;
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
    public partial class FormTrangChuAdmin : Form
    {
        public FormTrangChuAdmin()
        {
            InitializeComponent();
            OpenChildForm(new FormNguoiDung());
            this.Width = 1250;
            this.Height = 700;
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
        }
        

        private void btn_QuanLyTaiKhoam_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormNguoiDung());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap.nhanvien = string.Empty;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSaoLuuPhucHoi());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTTNguoiDung());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiMatKhau());
        }
    }
}
