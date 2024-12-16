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
        public static string password;
        public static string instance;
        public FormDangNhap()
        {
            InitializeComponent();
            this.Width = 1050;
            this.Height = 600;
            Load();
        }
        private void Load()
        {
            var loginInfo =LoginDAO.LoadFromRegistry();
            if (loginInfo.rememberMe)
            {
                txt_instance.Text = loginInfo.instance;
                txt_UserName.Text = loginInfo.username;
                txt_PassWord.Text = loginInfo.password;
                cb_Luutt.Checked = true;
            }
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
            if(txt_instance.Text=="" || txt_PassWord.Text == "" || txt_UserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                nhanvien = txt_UserName.Text.Trim();
                password = txt_PassWord.Text;
                instance = txt_instance.Text;
                if (DataProvider.Instance.SetConnectionString(instance, nhanvien, password) == false)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }
                string userName = txt_UserName.Text;
                string pass = NguoiDungDAO.Hash(txt_PassWord.Text);
                if (Login(userName, pass))
                {
                    LoginDAO.Instance.StatusDangNhap(userName);
                    LoginDAO.SaveToRegistry(instance, nhanvien, password, cb_Luutt.Checked);
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
                            FormKeToan fKeToan = new FormKeToan();
                            fKeToan.Show();
                            break;
                        case 3:
                            FormNhanVienBanHang fnvbh = new FormNhanVienBanHang();
                            fnvbh.Show();
                            break;
                        case 4:

                            FormNhanVienGiaoHang fnvgh = new FormNhanVienGiaoHang();
                            fnvgh.Show();
                            break;
                        case 5:
                            FormNhanVienKho fnvkho = new FormNhanVienKho();
                            fnvkho.Show();
                            break;
                    }
                }
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
