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
                this.Hide();
                switch (getRole(userName, pass))
                {
                    case 0:
                        FormTrangChuAdmin fTrangchuAdmin = new FormTrangChuAdmin();
                        fTrangchuAdmin.Show();
                        break;
                    case 1:
                        MessageBox.Show("Đang dăng nhập với quyền giám đốc");
                        break;
                    case 2:
                        MessageBox.Show("Đăng nhập thành công với quyền kế toán");
                        break;
                    case 3:
                        FormNhanVienBanHang fnvbh = new FormNhanVienBanHang();
                        fnvbh.Show();
                        break;
                    case 4:
                        MessageBox.Show("Đăng nhập thành công với quyền giao hàng");
                        break;
                    case 5:
                        MessageBox.Show("Đăng nhập thành công với quyền kho");
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
