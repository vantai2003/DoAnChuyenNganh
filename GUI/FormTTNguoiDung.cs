using DACN.DAO;
using DACN.DTO;
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
    public partial class FormTTNguoiDung : Form
    {
        public FormTTNguoiDung()
        {
            InitializeComponent();
            LoadTT(FormDangNhap.nhanvien);
        }
        private void LoadTT(string tenDN)
        {
            DataTable dt = NhanVienDAO.Instance.GetThongTinDN(tenDN);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_MaNV.Text = row["MaNV"].ToString();
                txt_TenNV.Text = row["TenNV"].ToString();
                txt_Email.Text = row["Email"].ToString();
                txt_SDT.Text = row["SDT"].ToString();
                txt_ChucVu.Text = row["ChucVu"].ToString();
                txt_NgayVaoLam.Text =row["NgayTuyenDung"].ToString();
            }
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text;
            string tennv = txt_TenNV.Text;
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;
            bool kq = NguoiDungDAO.Instance.SuaTTNguoiDung(manv, tennv, sdt, email);
            if (kq) {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
        }
    }
}
