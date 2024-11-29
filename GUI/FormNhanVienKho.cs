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
        public FormNhanVienKho()
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
        private void btn_LapPhieuNH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
        }

        private void tStripMenuItem_ThongTinTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTTNguoiDung());
        }

        private void btn_QLTonKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLTonKho());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
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

        private void btn_QLGiaNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCT_SanPham_NCC());
        }

        private void btn_QLGiaNhap_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLGiaNhapTuNCC());
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
