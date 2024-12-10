using DACN.DAO;
using Sunny.UI.Win32;
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
    public partial class FormNhanVienKho : Form
    {
        private string user;
        public FormNhanVienKho()
        {
            InitializeComponent();
            this.Width = 1350;
            this.Height = 800;
            this.StartPosition = FormStartPosition.CenterScreen;
            OpenChildForm(new FormQLTonKho());
            user = FormDangNhap.nhanvien;
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
        private void btn_LapPhieuNH_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormNhapHang());
            }
        }

        private void tStripMenuItem_ThongTinTK_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormTTNguoiDung());
            }
            
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginDAO.Instance.StatusDangXua(user);
                this.Close();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.Show();
                LoginDAO.Instance.LogoutUser(user);
                user = null;
            }
        }

        private void btn_QLGiaNhap_Click_1(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormQLGiaNhapTuNCC());
            }
        }
        private void btn_QLTraHang_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormQLTraHangNCC());
            }
        }

        private void toolStripMenuItem_DoiMK_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormDoiMatKhau());
            }
        }
        private bool CheckLoginStatus(string username)
        {
            int status = LoginDAO.Instance.GetStatus(username);

            if (status == 0)
            {
                MessageBox.Show("Tài khoản đã bị đăng xuất ở thiết bị khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormDangNhap loginForm = new FormDangNhap();
                this.Close();
                loginForm.Show();
                LoginDAO.Instance.LogoutUser(user);
                return false;
            }
            return true;
        }

        private void btn_QLCungUng_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormCT_SanPham_NCC());
            }
        }

        private void btn_QLTonKho_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormQLTonKho());
            }
        }
    }
}
