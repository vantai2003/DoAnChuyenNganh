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
                lbMaNV.Text = row["MaNV"].ToString();
                lbTenNV.Text = row["TenNV"].ToString();
                lbEmail.Text = row["Email"].ToString();
                lbSDT.Text = row["SDT"].ToString();
                lbChucVu.Text = row["ChucVu"].ToString();
                lbNgayVaoLam.Text =row["NgayTuyenDung"].ToString();
                
            }
        }
    }
}
