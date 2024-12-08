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
    public partial class FormKeToan : Form
    {
        public FormKeToan()
        {
            InitializeComponent();
            OpenChildForm(new FormInHoaDon());
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

        private void btn_InPhieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInHoaDon());
        }

        private void btnSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeDoanhThu());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTTNguoiDung());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiMatKhau());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginDAO.Instance.LogoutUser(FormDangNhap.nhanvien);
                LoginDAO.Instance.StatusDangXua(FormDangNhap.nhanvien);
                this.Close();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.Show();
                FormDangNhap.nhanvien = string.Empty;
            }
        }
    }
}
