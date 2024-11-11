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
        public FormGiamDoc()
        {
            InitializeComponent();
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
            OpenChildForm(new FormTTNguoiDung());
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

        private void btn_DuyetPNH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDuyetPhieuNhap());
        }

        private void btn_QuanLyNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLNhanVien());
        }
    }
}
