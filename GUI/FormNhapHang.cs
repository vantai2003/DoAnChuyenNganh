using DACN.DAO;
using DACN.DTO;
using Sunny.UI;
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
    public partial class FormNhapHang : Form
    {
        public static string mancc;
        public static string manv;
        public static string mapn;
        public static string makho;
        public static decimal tongtien;
        public FormNhapHang()
        {
            InitializeComponent();
            LoadDSPN();
        }
        private void LoadPhieuNhap()
        {
            List<KhoDTO> listkho = KhoDAO.Instance.GetKho();
            cb_TaoPNKho.DataSource = listkho;
            cb_TaoPNKho.DisplayMember = "TenKho";
            cb_TaoPNKho.ValueMember = "MaKho";
            List<NhaCungCapDTO> listncc = NhaCungCapDAO.Instance.GetNhaCungCap();
            cb_NCC.DataSource = listncc;
            cb_NCC.DisplayMember = "TenNCC";
            cb_NCC.ValueMember = "MaNCC";
            cb_TrangThai.SelectedIndex = 0;
            InitializeDataGridView();
        }

        private void btn_ChonSP_Click(object sender, EventArgs e)
        {
            mancc = cb_NCC.SelectedValue.ToString();
            FormChonSanPham formChonSP = new FormChonSanPham();
            formChonSP.Owner = this;
            formChonSP.ShowDialog();
        }
        public void AddProductToReceipt(string maSP, string tenSP,string dvt, string tenloaisp,decimal soLuong, decimal donGia)
        {
            decimal thanhTien = soLuong * donGia;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dvg_TaoPN);

            row.Cells[0].Value = maSP;   
            row.Cells[1].Value = tenSP;    
            row.Cells[2].Value = dvt; 
            row.Cells[3].Value = tenloaisp; 
            row.Cells[4].Value = soLuong;  
            row.Cells[5].Value = donGia;    
            row.Cells[6].Value = thanhTien; 

            dvg_TaoPN.Rows.Add(row);

            decimal tongTien = TinhTongThanhTien();
            txtTongTien.Text = tongTien.ToString("N2");
        }
        private void InitializeDataGridView()
        {
            if (dvg_TaoPN.Columns.Count == 0)
            {
                dvg_TaoPN.Columns.Add("MaSP", "Mã Sản Phẩm");
                dvg_TaoPN.Columns.Add("TenSP", "Tên Sản Phẩm");
                dvg_TaoPN.Columns.Add("DVT", "Đơn Vị Tính");
                dvg_TaoPN.Columns.Add("TenLoai", "Tên Loại");
                dvg_TaoPN.Columns.Add("SoLuong", "Số Lượng");
                dvg_TaoPN.Columns.Add("DonGia", "Đơn Giá");
                dvg_TaoPN.Columns.Add("ThanhTien", "Thành Tiền");
            }
        }
        private decimal TinhTongThanhTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dvg_TaoPN.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null && row.Cells["ThanhTien"].Value != DBNull.Value)
                {
                    decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    tongTien += thanhTien;
                }
            }

            return tongTien;
        }

        private void btn_ToaPN_Click(object sender, EventArgs e)
        {
            if (dvg_TaoPN.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm trước khi tạo phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataTable dt = NhanVienDAO.Instance.GetThongTinDN(FormDangNhap.nhanvien);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                manv = row["MaNV"].ToString();
            }
            string maPN = PhieuNhapHangDAO.GenerateMaPN();
            DateTime ngayDat = DateTime.Now;
            decimal tongTien = decimal.Parse(txtTongTien.Text);
            string trangThai = cb_TrangThai.SelectedItem.ToString();
            string maNCC = mancc;
            makho = cb_TaoPNKho.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(maPN))
            {
                bool phieuNhapAdded = PhieuNhapHangDAO.Instance.ThemPhieuNhapHang(maPN, ngayDat, tongTien, trangThai, manv, maNCC, makho);

                if (phieuNhapAdded)
                {
                    bool allDetailsAdded = true;
                    foreach (DataGridViewRow dgvRow in dvg_TaoPN.Rows)
                    {
                        if (dgvRow.Cells["MaSP"].Value != null)
                        {
                            string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                            decimal soLuong = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                            decimal donGia = Convert.ToDecimal(dgvRow.Cells["DonGia"].Value);
                            DateTime ngayNhapHang = DateTime.Now;
                            CTPhieuNHDTO ctPhieuNhap = new CTPhieuNHDTO
                            {
                                MaCTPhieuNH = PhieuNhapHangDAO.GenerateMaCTPN(),
                                MaPhieuNH = maPN,
                                MaSP = maSP,
                                SoLuong = soLuong,
                                DonGia = donGia,
                                NgayNhapHang = ngayNhapHang
                            };
                            bool detailAdded = PhieuNhapHangDAO.Instance.ThemCTPhieuNhapHang(ctPhieuNhap);
                            if (!detailAdded)
                            {
                                allDetailsAdded = false;                           
                            }
                        }
                    }

                    if (allDetailsAdded)
                    {
                        MessageBox.Show("Thêm phiếu nhập và chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvg_TaoPN.Rows.Clear();
                        txtTongTien.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo mã phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dvg_TaoPN.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dvg_TaoPN.SelectedRows)
                {
                    dvg_TaoPN.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dvg_TaoPN.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            txtTongTien.Text = tongTien.ToString("N2");
        }

        private void dvg_TaoPN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_TaoPN.Columns["SoLuong"].Index || e.ColumnIndex == dvg_TaoPN.Columns["DonGia"].Index)
            {
                DataGridViewRow row = dvg_TaoPN.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["SoLuong"].Value?.ToString(), out decimal soLuong) &&
                    decimal.TryParse(row.Cells["DonGia"].Value?.ToString(), out decimal donGia))
                {
                    if (soLuong < 0 || donGia < 0)
                    {
                        MessageBox.Show("Số lượng và đơn giá không được phép âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (soLuong < 0) row.Cells["SoLuong"].Value = 0;
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
        private void LoadDSPN()
        {
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.GetPhieuNhap();
            dvg_DSPhieuNhap.DataSource = listPN;
            dvg_DSPhieuNhap.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_DSPhieuNhap.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dvg_DSPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
            dvg_DSPhieuNhap.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSPhieuNhap.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_DSPhieuNhap.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_DSPhieuNhap.Columns["TenKho"].HeaderText = "Tên kho";
            List<KhoDTO> listkho = KhoDAO.Instance.GetKho();
            cbkho.DataSource = listkho;
            cbkho.DisplayMember = "TenKho";
            cbkho.ValueMember = "TenKho";
            List<NhaCungCapDTO> listncc = NhaCungCapDAO.Instance.GetNhaCungCap();
            cbncc.DataSource = listncc;
            cbncc.DisplayMember = "TenNCC";
            cbncc.ValueMember = "TenNCC";

        }
        private void LoadDSPNDaPheDuyet()
        {
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.DSPhieuNhapDaPD();
            dvg_DSPNDPD.DataSource = listPN;
        }
        private void tab_body_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_body.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadDSPN();
                    break;
                case 1:

                    LoadPhieuNhap();
                    break;
                case 2:
                    LoadPNDangPD();
                    
                    break;
                case 3:
                    LoadDSPNDaPheDuyet();
                    break;
                default:
                    break;
            }
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            FormCapNhatKho fcnk = new FormCapNhatKho();
            fcnk.ShowDialog();
        }

        private void dvg_DSPNDPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSPNDPD.Rows[e.RowIndex];
                mapn = Convert.ToString(row.Cells["MaPhieuNH"].Value);
                string tenKho = row.Cells["TenKho"].Value.ToString();
                makho = KhoDAO.Instance.GetMaKhoByTenKho(tenKho);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void btn_TaoPTH_Click(object sender, EventArgs e)
        {
            FormTaoPhieuTraHangNCC ftpth = new FormTaoPhieuTraHangNCC();
            ftpth.ShowDialog();
        }

        private void btn_TimPN_Click(object sender, EventArgs e)
        {
            string searchValue = txt_SearchPN.Text;
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.TimPhieuNhap(searchValue);
            dvg_DSPhieuNhap.DataSource= listPN;

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị từ combobox Kho, nếu trống thì truyền null
            string tenNCC = string.IsNullOrEmpty(cbncc.SelectedValue?.ToString()) ? null : cbncc.SelectedValue.ToString();
            string tenKho = string.IsNullOrEmpty(cbkho.SelectedValue?.ToString()) ? null : cbkho.SelectedValue.ToString();
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.LocPhieuNhap(tenKho, tenNCC);
            dvg_DSPhieuNhap.DataSource = listPN;
        }
        private void LoadPNDangPD()
        {
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.GetPhieuNhapStatus();
            dvg_PhieuNhapCoTheSua.DataSource = listPN;
        }

        private void dvg_PhieuNhapCoTheSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_PhieuNhapCoTheSua.Rows[e.RowIndex];
                string maPN = Convert.ToString(row.Cells["MaPhieuNH"].Value);
                decimal tongTien= Convert.ToDecimal(row.Cells["TongTien"].Value);
                mancc = Convert.ToString(row.Cells["TenNCC"].Value);
                makho = Convert.ToString(row.Cells["TenKho"].Value);
                mapn = maPN;
                tongtien = Convert.ToDecimal(row.Cells["TongTien"].Value);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void btn_SuaPN_Click(object sender, EventArgs e)
        {
            FormSuaPhieuNhap fSuaPN = new FormSuaPhieuNhap();
            fSuaPN.ShowDialog();
        }
    }
}
