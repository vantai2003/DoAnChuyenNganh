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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            txt_TenDN.Text = FormDangNhap.nhanvien;
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if(txt_TenDN.Text == "" || txt_MatKhauCu.Text == "" || txt_MkMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            }
            else
            {
                string tenDN = txt_TenDN.Text;
                string matKhauCu =  NguoiDungDAO.Hash(txt_MatKhauCu.Text);
                string matKhauMoi =  NguoiDungDAO.Hash(txt_MkMoi.Text);
                int kq = LoginDAO.Instance.DoiMatKhau(tenDN, matKhauCu, matKhauMoi);
                if (kq > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txt_TenDN.Clear();
                    txt_MatKhauCu.Clear();
                    txt_MkMoi.Clear();
                }
                else
                {
                    MessageBox.Show("Sai Tên đăng nhập hoặc mật khẩu");
                    txt_MatKhauCu.Focus();
                } 
                    
                
            }
        }
    }
}
