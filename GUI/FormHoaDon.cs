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
        public static string mahd;
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
            DataGridViewCheckBoxColumn chkColumn = dgvHoaDon.Columns["Chon"] as DataGridViewCheckBoxColumn;
            if (chkColumn == null)
            {
                chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Chọn";
                chkColumn.Name = "Chon";
                dgvHoaDon.Columns.Add(chkColumn);
            }
            dgvHoaDon.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvHoaDon.Rows)
                    {
                        row.Cells["Chon"].Value = false;
                    }

                    if (e.ColumnIndex == dgvHoaDon.Columns["Chon"].Index)
                    {
                        bool currentValue = (bool)(dgvHoaDon.Rows[e.RowIndex].Cells["Chon"].Value ?? false);
                        dgvHoaDon.Rows[e.RowIndex].Cells["Chon"].Value = !currentValue; 
                    }
                    else
                    {
                        dgvHoaDon.Rows[e.RowIndex].Cells["Chon"].Value = true; 
                    }
                }
            };

            dgvHoaDon.DataSource = listHoaDon;
            dgvHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dgvHoaDon.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvHoaDon.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns["TienCoc"].HeaderText = "Tiền cọc";
            dgvHoaDon.Columns["ThanhToan"].HeaderText = "Số tiền cần toán";
            dgvHoaDon.Columns["SoTienKM"].HeaderText = "Số tiền khuyến mãi";
            if (!dgvHoaDon.Columns.Contains("SoTienDaThanhToan"))
            {
                dgvHoaDon.Columns.Add("SoTienDaThanhToan", "Số tiền đã thanh toán");
            }
            else
            {
                dgvHoaDon.Columns["SoTienDaThanhToan"].HeaderText = "Số tiền đã thanh toán";
            }
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                row.Cells["SoTienDaThanhToan"].Value = ((HoaDonDTO)row.DataBoundItem).SoTienDaThanhToan;
            }
            dgvHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvHoaDon.Columns["TenNV"].HeaderText = "Tên nhân viên tạo phiếu";
            dgvHoaDon.Columns["MaNV"].Visible = false;
            loadCbbTrangThai();
            tsbSua.Enabled = false;
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItem = new ToolStripMenuItem("Xem chi tiết hóa đơn");
            xemChiTietMenuItem.Click += XemChiTietMenuItem_Click;
            contextMenu.Items.Add(xemChiTietMenuItem);
            dgvHoaDon.ContextMenuStrip = contextMenu;
            ToolStripMenuItem xemChiTietPTMenuItem = new ToolStripMenuItem("Xem chi tiết phiếu trả");
            xemChiTietPTMenuItem.Click += xemChiTietPTMenuItem_Click;
            contextMenu.Items.Add(xemChiTietPTMenuItem);
            dgvHoaDon.ContextMenuStrip = contextMenu;
        }

        public void SetGiaoHangMode()
        {
            tsbThem.Visible = tsbXoa.Visible = tsbSua.Visible = tsbLuu.Visible =false;
            txtMaNV.Enabled = txtTienCoc.Enabled = txtDiaChi.Enabled = dtpNgayTao.Enabled = txtMaHD.Enabled = false;
        }
        public void SetBanHangMode()
        {
            tsbThem.Visible = tsbXoa.Visible = tsbSua.Visible = tsbLuu.Visible = false;
            txtMaNV.Enabled = txtTienCoc.Enabled = txtDiaChi.Enabled = dtpNgayTao.Enabled = txtMaHD.Enabled = false;
            btnThanhToan.Visible = btn_pth.Visible = false;
        }
        public void LoadHoaDonGiaoHang()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvHoaDon.DataSource = listHoaDon;
        }
        private void XemChiTietMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvHoaDon.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvHoaDon.Rows[rowIndex];
            mahd = row.Cells["MaHD"].Value.ToString();
            FormCTHoaDon formCTHoaDon = new FormCTHoaDon(txtMaHD.Text);
            formCTHoaDon.Owner = this;
            formCTHoaDon.ShowDialog();
        }
        private void xemChiTietPTMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvHoaDon.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvHoaDon.Rows[rowIndex];
            mahd = row.Cells["MaHD"].Value.ToString();
            FormCTPhieuTraHangKH cTPhieuTraHangKH = new FormCTPhieuTraHangKH();
            cTPhieuTraHangKH.ShowDialog();
        }
        public void loadCbbTrangThai()
        {
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Chưa giao hàng");
            cbbTrangThai.Items.Add("Đã giao");
            cbbTrangThai.SelectedIndex = 0;
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

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            txtMaKH.Clear();
            txtMaHD.Clear();
            txtMaNV.Clear();
            txtDiaChi.Clear();
            txtTienCoc.Clear();
            txtThanhToan.Clear();
            dtpNgayTao.Value = DateTime.Now;
            txtTongTien.Clear();
            txt_TienKM.Clear();
            mahd = txtMaHD.Text;
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
                    txtMaNV.Text = row.Cells["TenNV"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChiGiaoHang"].Value.ToString();
                    txtTienCoc.Text = row.Cells["TienCoc"].Value.ToString();
                    txtThanhToan.Text = row.Cells["ThanhToan"].Value.ToString();
                    dtpNgayTao.Value = DateTime.Parse(row.Cells["NgayDatHang"].Value.ToString());
                    txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                    txt_TienKM.Text = row.Cells["SoTienKM"].Value.ToString();
                    mahd = txtMaHD.Text;
                    tsbSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public bool dkHoaDon(string makh, string Diachi, string manv)
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
                hoaDonDTO.TrangThai = "Chưa giao hàng";
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
                    txtMaHD.Text = txtMaHD.Text;
                    hoaDonDTO.MaHD = txtMaHD.Text;
                    hoaDonDTO.MaNV = txtMaNV.Text;
                    hoaDonDTO.MaKH = txtMaKH.Text;
                    hoaDonDTO.DiaChiGiaoHang = txtDiaChi.Text;
                    hoaDonDTO.ThanhToan = decimal.Parse(txtThanhToan.Text);
                    hoaDonDTO.TienCoc = decimal.Parse(txtTienCoc.Text);
                    hoaDonDTO.TongTien = decimal.Parse(txtTongTien.Text);
                    hoaDonDTO.TrangThai = cbbTrangThai.SelectedItem.ToString();
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
        private decimal TinhTongThanhTien()
        {
            decimal sotiendatra = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
               
                if (row.Cells["ThanhTien"].Value != null && row.Cells["ThanhTien"].Value != DBNull.Value)
                {
                    decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    decimal tongtien = Convert.ToDecimal(row.Cells["tongtien"].Value);
                    sotiendatra = tongtien - thanhTien;
                }
            }

            return sotiendatra;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan frmThanhtoan = new FormThanhToan(txtTongTien.Text,txtTienCoc.Text,txt_TienKM.Text, txtThanhToan.Text);
            frmThanhtoan.FormClosed += (s, args) => LoadHoaDon();
            frmThanhtoan.ShowDialog();
        }

        private void btn_pth_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = FormHoaDon.mahd;
                if (string.IsNullOrEmpty(mahd))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn trước khi tạo phiếu trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormPhieuTraHangKH fpthkh = new FormPhieuTraHangKH();
                fpthkh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbTimKiem.Text;
            List<HoaDonDTO> listHD =  hoaDonDAO.TimHD(searchValue);
            dgvHoaDon.DataSource = listHD;
        }
    }
}
