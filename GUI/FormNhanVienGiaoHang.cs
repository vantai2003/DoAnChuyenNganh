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
    public partial class FormNhanVienGiaoHang : Form
    {
        string mahd;
        private string user;
        public FormNhanVienGiaoHang()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 900;
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

        private void btn_QLDonHang_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                FormHoaDon fHD = new FormHoaDon();
                OpenChildForm(fHD);
                fHD.SetGiaoHangMode();
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

        private void btn_lappth_Click(object sender, EventArgs e)
        {
            if (CheckLoginStatus(user))
            {
                try
                {
                    mahd = FormHoaDon.mahd;
                    if (string.IsNullOrEmpty(mahd))
                    {
                        MessageBox.Show("Vui lòng chọn hóa đơn trước khi tạo phiếu trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FormCTPhieuTraHangKH fpthkh = new FormCTPhieuTraHangKH();
                    fpthkh.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
