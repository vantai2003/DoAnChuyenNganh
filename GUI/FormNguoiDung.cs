﻿using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            List<NhanVienDTO> listNhanVien = NhanVienDAO.Instance.LoadListNV();
            cb_nhanvien.DataSource = listNhanVien;
            cb_nhanvien.DisplayMember = "MaNV";
            cb_nhanvien.ValueMember = "MaNV";
            List<QuyenDTO> listQuyen = QuyenDAO.Instance.LoadLisQuyen();
            cb_vitrilv.DataSource = listQuyen;
            cb_vitrilv.DisplayMember = "TenQuyen";
            cb_vitrilv.ValueMember = "Id";
            cb_vitrilv.SelectedIndex = 2;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<NguoiDungDTO> listNguoiDung = NguoiDungDAO.Instance.TimKiemNguoiDung(txt_Search.Text);
            dvg_NguoiDung.DataSource = listNguoiDung;
        }

        private void dvg_NguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_NguoiDung.Rows[e.RowIndex];
                txt_username.Text = Convert.ToString(row.Cells["TenDN"].Value);
                txt_pass.Text = Convert.ToString(row.Cells["MatKhau"].Value);
                cb_nhanvien.SelectedValue = Convert.ToString(row.Cells["MaNV"].Value);
                cb_vitrilv.SelectedValue = Convert.ToInt32(row.Cells["QuyenID"].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                txt_username.Clear();
                txt_pass.Clear();
                cb_nhanvien.SelectedIndex = 0;
                cb_vitrilv.SelectedIndex = 2;
            }
        }
        private bool KTTrungTenDN(string tenDN)
        {
            return NguoiDungDAO.Instance.KiemTraTrungTenDN(tenDN);
        }
        public bool IsValidInput(string input)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {

            string tenDN = txt_username.Text;
            string matKhau = NguoiDungDAO.Hash(txt_pass.Text);
            if (tenDN == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!");
            }
            else
            {
                if (IsValidInput(tenDN))
                {
                    if (KTTrungTenDN(tenDN))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                    }
                    else
                    {
                        DateTime ngayTao = DateTime.Now;
                        string MaNV = cb_nhanvien.SelectedValue.ToString();
                        int quyenID = int.Parse(cb_vitrilv.SelectedValue.ToString());

                        NguoiDungDAO.Instance.ThemNguoiDung(tenDN, matKhau, ngayTao, MaNV, quyenID);
                        MessageBox.Show("Thêm người dùng thành công");
                        LoadNguoiDung();
                    }
                    txt_username.Clear();
                    txt_pass.Clear();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không đúng định dạng");
                }
            }
               
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadNguoiDung();
            txt_username.Text = "";
            txt_pass.Text = "";
            cb_nhanvien.SelectedItem = 0;
            cb_vitrilv.SelectedItem = 2;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            string tenDN = "";
            tenDN = txt_username.Text;
            if(tenDN == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa người dùng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    NguoiDungDAO.Instance.XoaNguoiDung(tenDN);
                    MessageBox.Show("Xóa người dùng thành công!");
                    txt_username.Clear();
                    txt_pass.Clear();
                    cb_nhanvien.SelectedIndex = 0;
                    cb_vitrilv.SelectedIndex = 2;
                    LoadNguoiDung();
                }
            }


        }
            

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string tenDN = "";
            tenDN = txt_username.Text;
            if (tenDN == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng để sửa");
            }
            else
            {
                string matKhau = NguoiDungDAO.Hash(txt_pass.Text);
                string maNV = cb_nhanvien.SelectedValue.ToString();
                int quyenId = int.Parse(cb_vitrilv.SelectedValue.ToString());
                NguoiDungDAO.Instance.SuaNguoiDung(tenDN, matKhau, maNV, quyenId);
                txt_username.Clear();
                txt_pass.Clear();
                cb_nhanvien.SelectedIndex = 0;
                cb_vitrilv.SelectedIndex = 2;
                MessageBox.Show("Sửa người dùng thành công");
                LoadNguoiDung() ;
            }
            
        }
    }
}
