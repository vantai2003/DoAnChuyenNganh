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
        public FormNhanVienGiaoHang()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 900;
        }


        private void btn_LapPhieuBanHang_Click(object sender, EventArgs e)
        {

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
            
            FormHoaDon fHD = new FormHoaDon();
            OpenChildForm(fHD);
            fHD.SetGiaoHangMode();
            
        }

        private void btn_HuyDonHang_Click(object sender, EventArgs e)
        {

        }

        private void panel_right_Paint(object sender, PaintEventArgs e)
        {

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

        private void FormNhanVienGiaoHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_pth_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_lappth_Click(object sender, EventArgs e)
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
}
