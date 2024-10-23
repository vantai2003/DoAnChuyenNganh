using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormNguoiDung : Form
    {
        public FormNguoiDung()
        {
            InitializeComponent();
            LoadNguoiDung();
        }
        private void LoadNguoiDung()
        {
            List<NguoiDungDTO> listNguoiDung = NguoiDungDAO.Instance.GetNguoiDung();
            dvg_NguoiDung.DataSource = listNguoiDung;
            dvg_NguoiDung.Columns["TenDN"].HeaderText = "Tên đăng nhập";
            dvg_NguoiDung.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dvg_NguoiDung.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dvg_NguoiDung.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_NguoiDung.Columns["QuyenID"].HeaderText = "QuyenID";
            List<NhanVienDTO> listNhanVien = NhanVienDAO.Instance.LoadListNV();
            cb_nhanvien.DataSource = listNhanVien;
            cb_nhanvien.DisplayMember = "MaNV";
            cb_nhanvien.ValueMember = "MaNV";
            List<QuyenDTO> listQuyen = QuyenDAO.Instance.LoadLisQuyen();
            cb_vitrilv.DataSource = listQuyen;
            cb_vitrilv.DisplayMember = "TenQuyen";
            cb_vitrilv.ValueMember = "Id";

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<NguoiDungDTO> listNguoiDung = NguoiDungDAO.Instance.TimKiemNguoiDung(txt_Search.Text);
            dvg_NguoiDung.DataSource = listNguoiDung;
            //dvg_NguoiDung.Columns["TenDN"].HeaderText = "Tên đăng nhập";
            //dvg_NguoiDung.Columns["MatKhau"].HeaderText = "Mật khẩu";
            //dvg_NguoiDung.Columns["NgayTao"].HeaderText = "Ngày tạo";
            //dvg_NguoiDung.Columns["MaNV"].HeaderText = "Mã nhân viên";
            //dvg_NguoiDung.Columns["QuyenID"].HeaderText = "QuyenID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             string tenDN = txt_username.Text;
             string matKhau = NguoiDungDAO.Hash(txt_pass.Text);
             DateTime ngayTao = DateTime.Now;
             string MaNV = cb_nhanvien.SelectedValue.ToString();
             int quyenID = int.Parse(cb_vitrilv.SelectedValue.ToString());

             NguoiDungDAO.Instance.ThemNguoiDung(tenDN, matKhau, ngayTao, MaNV, quyenID);
             LoadNguoiDung();
            
        }
    }
}
