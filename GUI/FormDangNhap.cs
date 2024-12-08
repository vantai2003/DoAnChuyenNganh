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
        //private string error = DataProvider.thongBao;
        public FormDangNhap()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 500;
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
            nhanvien = txt_UserName.Text.Trim();
            password = txt_PassWord.Text;
            DataProvider.Instance.SetConnectionString(nhanvien, password);
            Console.WriteLine("NhanVien" + nhanvien + "pass: " + password);
            string userName = txt_UserName.Text;
            string pass = NguoiDungDAO.Hash(txt_PassWord.Text);
            if (Login(userName, pass))
            {
                LoginDAO.Instance.StatusDangNhap(userName);
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
