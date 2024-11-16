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
            
            FormPhieuTraHangKH fpthkh = new FormPhieuTraHangKH();
            mahd = FormHoaDon.mahd;
            if(String.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Bạn phải chọn hóa đơn trước khi trả ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            fpthkh.ShowDialog();
        }
    }
}
