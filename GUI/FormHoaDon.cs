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
    public partial class FormHoaDon : Form
    {
        List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        HoaDonDTO hoaDonDTO = new HoaDonDTO();
        
        bool sua = false;
        public FormHoaDon()
        {
            
            InitializeComponent();
            LoadHoaDon();
            tsbLuu.Enabled = false;
            this.AutoScroll = true;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            FormCTHoaDon formCTHoaDon = new FormCTHoaDon(txtMaHD.Text);
            formCTHoaDon.Owner = this;
            formCTHoaDon.ShowDialog();
        }
        public void LoadHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvHoaDon.DataSource = listHoaDon;
            dgvHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvHoaDon.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            dgvHoaDon.Columns["TienCoc"].HeaderText = "Tiền cọc";
            dgvHoaDon.Columns["ThanhToan"].HeaderText = "Thanh toán";
            dgvHoaDon.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvHoaDon.Columns["TenNV"].HeaderText = "Tên nhân viên tạo phiếu";
            dgvHoaDon.Columns["MaNV"].Visible = false;
            dgvHoaDon.Columns["SoTienKM"].HeaderText = "Số tiền khuyến mãi";
        }
        public void loadCbbTrangThai()
        {
         
        }
        static string GenerateNewCode(List<HoaDonDTO> list)
        {
            if (list.Count == 0)
            {
                return "HD001";
            }

            string lastCode = list.Last().MaHD;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        public void chonTongTien(string tongtien)
        {
            txtTongTien.Text = tongtien;
        }
        public void chonMaKh(string makh)
        {
            txtMaKH.Text = makh;
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            FormChonKH formChonkh = new FormChonKH();
            formChonkh.Owner = this;
            formChonkh.ShowDialog();
        }

        private void pcSearch_Click(object sender, EventArgs e)
        {
            
        }
    
        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                    txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                    txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChiGiaoHang"].Value.ToString();
                    txtTienCoc.Text = row.Cells["TienCoc"].Value.ToString();
                    txtThanhToan.Text = row.Cells["ThanhToan"].Value.ToString();
                    dtpNgayTao.Value = DateTime.Parse(row.Cells["NgayDatHang"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
      
        public bool dkHoaDon(string makh,string Diachi,string manv)
        { 
            if (string.IsNullOrWhiteSpace(makh))
            {
                MessageBox.Show(" khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(manv))
            {
                MessageBox.Show(" Nhân Viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Diachi))
            {
                MessageBox.Show("Địa chỉ giao không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void tsbThem_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaHD.Text = GenerateNewCode(listHoaDon);
                hoaDonDTO.MaHD = txtMaHD.Text;
                hoaDonDTO.MaNV = txtMaNV.Text;
                hoaDonDTO.MaKH = txtMaKH.Text;
                hoaDonDTO.DiaChiGiaoHang = txtDiaChi.Text;
                hoaDonDTO.ThanhToan = 0;
                hoaDonDTO.TienCoc = 0;
                hoaDonDTO.TongTien = 0;
                hoaDonDTO.TrangThai ="Chưa giao";
                hoaDonDTO.NgayDatHang = DateTime.Now;
                if (dkHoaDon(hoaDonDTO.MaKH, hoaDonDTO.DiaChiGiaoHang, hoaDonDTO.MaNV))
                {
                    hoaDonDAO.Insert(hoaDonDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
               
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            sua = true;
            tsbLuu.Enabled = true;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    hoaDonDAO.Delete(txtMaHD.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (sua == true)
            {
                try
                {
                    txtMaHD.Text = GenerateNewCode(listHoaDon);
                    hoaDonDTO.MaHD = txtMaHD.Text;
                    hoaDonDTO.MaNV = txtMaNV.Text;
                    hoaDonDTO.MaKH = txtMaKH.Text;
                    hoaDonDTO.DiaChiGiaoHang = txtDiaChi.Text;
                    hoaDonDTO.ThanhToan = decimal.Parse(txtThanhToan.Text);
                    hoaDonDTO.TienCoc = decimal.Parse(txtTienCoc.Text);
                    hoaDonDTO.TongTien = decimal.Parse(txtTongTien.Text);
                    hoaDonDTO.TrangThai = cbbThanhToan.SelectedItem.ToString();
                    hoaDonDTO.NgayDatHang = DateTime.Parse(dtpNgayTao.Value.ToString()); 
                    hoaDonDAO.Update(hoaDonDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
