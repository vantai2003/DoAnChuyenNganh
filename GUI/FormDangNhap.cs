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
        LoginDAO lgdao = new LoginDAO();
        LoginDTO lgDTO = new LoginDTO();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void ktlogin()
        {
            var (isLogin, roleId) = lgdao.DangNhapandKTQuyen(txt_UserName.Text, txt_PassWord.Text);
            if (isLogin)
            {
                MessageBox.Show("Đăng nhập thành công!");
                switch (roleId)
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
                        FormLoaiSanPham floaiSp = new FormLoaiSanPham();
                        floaiSp.Show();
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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            ktlogin();
        }
    }
}
