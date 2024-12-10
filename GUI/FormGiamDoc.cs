using DACN.DAO;
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
    public partial class FormGiamDoc : Form
    {
        private string user;
        public FormGiamDoc()
        {
            InitializeComponent();
            OpenChildForm(new FormDuyetPhieuNhap());
            this.Width = 1400;
            this.Height = 820;
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
        private void tStripMenuItem_ThongTinTK_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormTTNguoiDung());
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
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

        private void btn_DuyetPNH_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormDuyetPhieuNhap());
            }
        }

        private void btn_QuanLyNV_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormQLNhanVien());
            }
        }

        private void btn_ĐuyetM_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                OpenChildForm(new FormDuyetKhuyenMai());
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
    }
}
