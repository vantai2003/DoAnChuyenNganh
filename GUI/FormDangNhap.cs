using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormDangNhap : Form
    {

        public FormDangNhap()
        {
            InitializeComponent();
        }
        public static string nhanvien;
        private bool Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }
        private int getRole(string username, string password)
        {
            return LoginDAO.Instance.getRole(username, password);
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string pass = NguoiDungDAO.Hash(txt_PassWord.Text);

            if (Login(userName, pass))
            {
                nhanvien = txt_UserName.Text.Trim();
                DataProvider.Instance.ChangeConnectionString(userName.Trim(), pass.Trim());

                this.Hide();
                switch (getRole(userName, pass))
                {
                    case 0:
                        FormTrangChuAdmin fTrangchuAdmin = new FormTrangChuAdmin();
                        fTrangchuAdmin.Show();
                        break;
                    case 1:
                        FormGiamDoc fGiamDoc = new FormGiamDoc();
                        fGiamDoc.Show();
                        break;
                    case 2:
                        FormThongKeDoanhThu fThongKe = new FormThongKeDoanhThu();
                        fThongKe.Show();
                        break;
                    case 3:
                        FormNhanVienBanHang fnvbh = new FormNhanVienBanHang();
                        fnvbh.Show();
                        break;
                    case 4:
                        MessageBox.Show("Đăng nhập thành công với quyền giao hàng");
                        FormNhanVienGiaoHang fnvgh = new FormNhanVienGiaoHang();
                        fnvgh.Show();
                        break;
                    case 5:
                        FormNhanVienKho fnvkho = new FormNhanVienKho();
                        fnvkho.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
