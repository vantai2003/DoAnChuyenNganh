﻿using DACN.DAO;
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
    public partial class FormChonKH : Form
    {
        private KhachHangDTO khDTO = new KhachHangDTO();
        private KhachHangDAO khDAO = new KhachHangDAO();
        public static string makh;
        public FormChonKH()
        {
            InitializeComponent();
            LoadKH();
            this.Width = 1150;
            this.Height = 700;
        }
        public void LoadKH()
        {
            List<KhachHangDTO> listkh = KhachHangDAO.Instance.GetKhachHang();

            dgvKhachHang.DataSource = listkh;
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgvKhachHang.Columns["TenLoaiKH"].HeaderText = "Loại khách hàng";
            dgvKhachHang.DataSource = listkh; 
            dgvKhachHang.Columns["MaLoaiKH"].Visible = false;

            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            var bindingList = new BindingList<LoaiKhachHangDTO>(listLoaiKH);
            cbbLoaiKH.DataSource = new BindingSource(bindingList, null);
            
            cbbLoaiKH.DisplayMember = "TenLoaiKH";
            cbbLoaiKH.ValueMember = "MaLoaiKH";
            if (cbbLoaiKH.Items.Count > 0)
            {
                cbbLoaiKH.SelectedIndex = 0;
            }
        }
        static string GenerateNewCodeKH()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            list = KhachHangDAO.Instance.GetKhachHang();
            if (list.Count == 0)
            {
                return "KH001";
            }
            string lastCode = list.Last().MaKH;
            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newCode = $"{prefix}{number:D3}";
            return newCode;
        }
        public void xoaTxt()
        {
            txtMK.Text = txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = string.Empty;
        }
        private bool ktDKKhachHang(string ma, string ten, string sdt, string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ma))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                bool isSdtEmpty = string.IsNullOrWhiteSpace(sdt);
                bool isEmailEmpty = string.IsNullOrWhiteSpace(email);
                if (isSdtEmpty && isEmailEmpty)
                {
                    MessageBox.Show("Số điện thoại hoặc email phải được cung cấp ít nhất một cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch { MessageBox.Show("Thêm khách hàng không thành công"); return false; }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormBanHang fBH)
            {
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    string makh = txtMK.Text;
                    fBH.chonMaKh(makh);
                }
            }
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                    makh = txtMK.Text = row.Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                    txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    string tenLoaiKH = row.Cells["TenLoaiKH"].Value.ToString();

                    foreach (LoaiKhachHangDTO loaiKH in cbbLoaiKH.Items)
                    {
                        if (loaiKH.TenLoaiKH == tenLoaiKH)
                        {
                            cbbLoaiKH.SelectedItem = loaiKH;
                            break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            try
            {
                txtMK.Text = GenerateNewCodeKH();
                khDTO.MaKH = txtMK.Text;
                khDTO.TenKH = txtTenKH.Text;
                khDTO.Email = txtEmail.Text;
                khDTO.Diachi = txtDiaChi.Text;
                khDTO.SoDienThoai = txtSDT.Text;
                khDTO.NgayTao = DateTime.Now;
                khDTO.MaLoaiKH = cbbLoaiKH.SelectedValue.ToString();
                if (ktDKKhachHang(khDTO.MaKH, khDTO.TenKH, khDTO.SoDienThoai, khDTO.Email))
                {
                    khDAO.Insert(khDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                LoadKH();
            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại" + ex.ToString()); }
        }
    }
    
}
