﻿using DACN.DAO;
using DACN.DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormBanHang : Form
    {
        CTHoaDonDTO CTHoaDonDTO = new CTHoaDonDTO();
        private string mahd;
        List<HoaDonDTO> listHoaDon = new List<HoaDonDTO>();
     
        public static string manv;
        public FormBanHang()
        {
            InitializeComponent();
            this.AutoScroll = true;
            InitializeDataGridView();
            LoadcbbTrangThai();
        }
        public void LoadcbbTrangThai()
        {
            cb_TrangThai.Items.Clear();

            cb_TrangThai.Items.Add("chưa giao hàng"); 
            cb_TrangThai.Items.Add("đã giao hàng ");  

            cb_TrangThai.SelectedIndex = 0;
        }
        private void SetupDataGridView()
        {
            // Đặt các cột khác thành ReadOnly
            foreach (DataGridViewColumn column in dgv_BanHang.Columns)
            {
                if (column.Name != "DonGia" && column.Name != "SoLuong")
                {
                    column.ReadOnly = true;
                }
                column.ReadOnly = false;

            }
        }
    public void chonMaKh(string ma)
        {
            txtMaKH.Text = ma;
        }
        public void chonMahd(string ma)
        {
           
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
        }

     

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

 
        static string GenerateNewCodeHD()
        {
            List<HoaDonDTO> listHoaDon = new List<HoaDonDTO>();
            listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            // Nếu danh sách rỗng, trả về mã mặc định
            if (listHoaDon.Count == 0)
            {
                return "HD001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = listHoaDon.Last().MaHD;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        static string GenerateNewCode()
        {
            List<CTHoaDonDTO> listCTHoaDon = new List<CTHoaDonDTO>();
            listCTHoaDon = CTHoaDonDAO.Instance.GetCTHD();
            // Nếu danh sách rỗng, trả về mã mặc định
            if (listCTHoaDon.Count == 0)
            {
                return "CTHD001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = listCTHoaDon.Last().MaCTHD;

            string prefix = lastCode.Substring(0, 4);
            string numberPart = lastCode.Substring(4);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        private decimal TinhTongThanhTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgv_BanHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null && row.Cells["ThanhTien"].Value != DBNull.Value)
                {
                    decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    tongTien += thanhTien;
                }
            }

            return tongTien;
        }
        private void InitializeDataGridView()
        {
            if (dgv_BanHang.Columns.Count == 0)
            {
                dgv_BanHang.Columns.Add("MaSP", "Mã Sản Phẩm");
                dgv_BanHang.Columns.Add("TenSP", "Tên Sản Phẩm");
                dgv_BanHang.Columns.Add("DVT", "Đơn Vị Tính");
                dgv_BanHang.Columns.Add("TenLoai", "Tên Loại");
                dgv_BanHang.Columns.Add("SoLuongTon", "Số Lượng tồn");
                dgv_BanHang.Columns.Add("SoLuong", "Số Lượng");
                dgv_BanHang.Columns.Add("DonGia", "Đơn Giá");
                dgv_BanHang.Columns.Add("ThanhTien", "Thành Tiền");
            }
            SetupDataGridView();
            UpdateTongTien();
        }
        private void UpdateTongTien()
        {
            decimal tongTien = 0;
            decimal tienCoc =0 ;

            decimal.TryParse(txtTienCoc.Text, out tienCoc);
            foreach (DataGridViewRow row in dgv_BanHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            txtTongTien.Text = tongTien.ToString("N2");
            decimal thanhtoan = tongTien - tienCoc;
            txtThanhToan.Text = thanhtoan.ToString("N2");
        }
        public void AddProductToReceipt(string maSP, string tenSP, string dvt, string tenloaisp, decimal soLuong, decimal donGia,decimal soLuongTon)
        {
            decimal thanhTien = soLuong * donGia;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_BanHang);

            row.Cells[0].Value = maSP;
            row.Cells[1].Value = dvt;
            row.Cells[2].Value = tenSP;
            row.Cells[3].Value = tenloaisp;
            row.Cells[4].Value = soLuongTon;
            row.Cells[5].Value = soLuong;
            row.Cells[6].Value = donGia;
            row.Cells[7].Value = thanhTien;

            dgv_BanHang.Rows.Add(row);

            decimal tongTien = TinhTongThanhTien();
            txtTongTien.Text = tongTien.ToString("N2");
        }
        private void btnThemVao_Click(object sender, EventArgs e)
        {

            
                if (dgv_BanHang.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn Khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                DataTable dt = NhanVienDAO.Instance.GetThongTinDN(FormDangNhap.nhanvien);
                string manv = string.Empty;
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    manv = row["MaNV"].ToString();
                }
               
                    string MaHD = GenerateNewCodeHD();
                    mahd = MaHD;
                
                 string MaNV = manv;
            //string MaKH = txtMaKH.Text;
                string MaKH = FormChonKH.makh;
                 DateTime NgayDatHang = DateTime.Now;
                 string TrangThai = cb_TrangThai.Text;
                 string DiaChiGiaoHang = txtDiaChi.Text;
                 decimal TienCoc = Convert.ToDecimal(txtTienCoc.Text);
                 decimal TongTien = Convert.ToDecimal(txtTongTien.Text);
                 decimal ThanhToan = Convert.ToDecimal(txtThanhToan.Text);

                if (!string.IsNullOrEmpty(mahd))
                {
                    HoaDonDTO hd = new HoaDonDTO() { 
                        MaHD =mahd,
                        MaNV =MaNV,
                        MaKH =MaKH,
                        NgayDatHang=NgayDatHang,
                        TrangThai=TrangThai,
                        DiaChiGiaoHang=DiaChiGiaoHang,
                        TienCoc=TienCoc,
                        TongTien=TongTien,
                        ThanhToan=ThanhToan,
                    };
                    int HoaDonAdded = HoaDonDAO.Instance.Insert(hd);
                    int kmtg = KhuyenMaiDAO.Instance.KhuyenMaiTheoThoiGian(MaHD);
                MessageBox.Show("Biến km theo thời gian có giá trị " + kmtg.ToString());
                    KhuyenMaiDAO.Instance.KhuyenMaiTheoTongTien(MaHD);
                    if (HoaDonAdded != 0)
                    {
                        bool allDetailsAdded = true;
                        foreach (DataGridViewRow dgvRow in dgv_BanHang.Rows)
                        {
                            if (dgvRow.Cells["MaSP"].Value != null)
                            {
                                string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                                decimal soLuong = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                                decimal donGia = Convert.ToDecimal(dgvRow.Cells["DonGia"].Value);
                                string DVT = dgvRow.Cells["DVT"].Value.ToString();
                                decimal thanhTien = Convert.ToDecimal(dgvRow.Cells["ThanhTien"].Value);
                             
                                CTHoaDonDTO ctHoaDon = new CTHoaDonDTO
                                {
                                    MaCTHD = GenerateNewCode(),
                                    SoLuong = soLuong,
                                    DonGia = donGia,
                                    ThanhTien = thanhTien,
                                    MaSP = maSP,
                                    MaHD = hd.MaHD,
                                    DVT = DVT,
                                    
                                };
                                int detailAdded = CTHoaDonDAO.Instance.Insert(ctHoaDon);
                                if (detailAdded <=0)
                                {
                                    allDetailsAdded = false;
                                }
                            }
                        }
                        if (allDetailsAdded)
                        {
                            MessageBox.Show("Thêm phiếu nhập và chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_BanHang.Rows.Clear();
                            txtTongTien.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm một số chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm Hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void pcSearch_Click(object sender, EventArgs e)
        {

        }
  
        
     
        private void btnChonHD_Click(object sender, EventArgs e)
        {
            FormChonHoaDon fChonHD = new FormChonHoaDon();
            fChonHD.Owner = this;
            fChonHD.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSanPhamBan formChonSPB = new FormSanPhamBan();
            formChonSPB.Owner = this;
            formChonSPB.ShowDialog();

        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            FormChonKH formChonKH = new FormChonKH();
            formChonKH.Owner = this;
            formChonKH.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_BanHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_BanHang.Columns["SoLuong"].Index || e.ColumnIndex == dgv_BanHang.Columns["DonGia"].Index)
            {
                DataGridViewRow row = dgv_BanHang.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["SoLuong"].Value?.ToString(), out decimal soLuong) &&
                    decimal.TryParse(row.Cells["DonGia"].Value?.ToString(), out decimal donGia) &&
                    decimal.TryParse(row.Cells["SoLuongTon"].Value?.ToString(), out decimal soLuongTon))
                {
                    if (soLuong < 0 || donGia < 0)
                    {
                        MessageBox.Show("Số lượng và đơn giá không được phép âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (soLuong < 0) row.Cells["SoLuong"].Value = 0;
                        if (donGia < 0) row.Cells["DonGia"].Value = 0;
                    }
                    else if (soLuong > soLuongTon)
                    {
                         MessageBox.Show("Số lượng không được lớn hơn số lượng tồn kho ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         row.Cells["SoLuong"].Value = 0;
                         if (donGia < 0) row.Cells["DonGia"].Value = 0;
                    }
                        else
                    {
                        decimal thanhTien = soLuong * donGia;
                        row.Cells["ThanhTien"].Value = thanhTien;
                        UpdateTongTien();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho Số Lượng và Đơn Giá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["ThanhTien"].Value = 0;
                }
            }
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')
            {
                if (txtTienCoc.Text.Contains("."))
                {
                    e.Handled = true;
                    return;                }
                if (txtTienCoc.Text.Length == 0)

                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            
            UpdateTongTien() ;
        }
    }
   
}
