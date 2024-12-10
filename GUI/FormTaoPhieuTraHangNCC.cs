using DACN.DAO;
using DACN.DTO;
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
    public partial class FormTaoPhieuTraHangNCC : Form
    {
        private static string mapn;
        private static string manv;
        private static string makho;
        private decimal Tag = 0;
        private decimal flag = 0;
        private List<CTPhieuTraHangNCCDTO> selectedProducts = new List<CTPhieuTraHangNCCDTO>();
        private FormNhapHang fnhaphang = new FormNhapHang();
        public FormTaoPhieuTraHangNCC()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            DataGridViewCheckBoxColumn chkColumn = dvg_TaoPTH.Columns["Chon"] as DataGridViewCheckBoxColumn;
            if (chkColumn == null)
            {
                chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Chọn";
                chkColumn.Name = "Chon";
                dvg_TaoPTH.Columns.Add(chkColumn);
                CheckBox chkSelectAll = new CheckBox();
                chkSelectAll.Text = "";
                chkSelectAll.Size = new Size(15, 15);
                chkSelectAll.Location = new Point(10, 10);
                chkSelectAll.CheckedChanged += new EventHandler(chkSelectAll_CheckedChanged);

                // Thêm checkbox vào header của DataGridView
                Rectangle rect = dvg_TaoPTH.GetCellDisplayRectangle(0, -1, true); // Lấy vị trí của header
                chkSelectAll.Location = new Point(rect.Location.X + 15, rect.Location.Y + 5); // Điều chỉnh vị trí
                dvg_TaoPTH.Controls.Add(chkSelectAll);
            }
            dvg_TaoPTH.AllowUserToAddRows = false;
            dvg_TaoPTH.AutoSize = true;
            dvg_TaoPTH.DataSource = listctpn;
            dvg_TaoPTH.Columns["MaCTPhieuNH"].HeaderText = "Mã CT phiếu nhập hàng";
            dvg_TaoPTH.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_TaoPTH.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_TaoPTH.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_TaoPTH.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_TaoPTH.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_TaoPTH.Columns["DVT"].HeaderText = "DVT";
            dvg_TaoPTH.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_TaoPTH.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_TaoPTH.Columns["SoLuong"].HeaderText = "Số lượng";
            dvg_TaoPTH.Columns["DonGia"].HeaderText = "Đơn giá";
            dvg_TaoPTH.Columns["TongTien"].HeaderText = "Tổng tiền";
            dvg_TaoPTH.Columns["NgayNhapHang"].HeaderText = "Ngày nhập hàng";
            dvg_TaoPTH.Columns["ThanhTien"].HeaderText = "Thành tiền";
            makho = FormNhapHang.makho;
        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool checkStatus = ((CheckBox)sender).Checked;

            foreach (DataGridViewRow row in dvg_TaoPTH.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["Chon"];
                chkCell.Value = checkStatus; // Set giá trị
            }
        }

        private void btn_TaoPhieu_Click(object sender, EventArgs e)
        {
            
            DataTable dt = NhanVienDAO.Instance.GetThongTinDN(FormDangNhap.nhanvien);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                manv = row["MaNV"].ToString();
            }
            string maPT = PhieuTraHangNCCDAO.GenerateMaPT();
            DateTime ngayTao = DateTime.Now;
            string lyDo = rtb_LyDo.Text;
            decimal tongTien = 0;
            foreach (DataGridViewRow dvgRow in dvg_TaoPTH.Rows)
            {
                if (Convert.ToBoolean(dvgRow.Cells["Chon"].Value) == true) // Kiểm tra nếu dòng được check
                {
                    if (dvgRow.Cells["MaSP"].Value != null)
                    {
                        decimal soLuong = Convert.ToDecimal(dvgRow.Cells["SoLuong"].Value);
                        decimal donGia = Convert.ToDecimal(dvgRow.Cells["DonGia"].Value);
                        decimal thanhTien = soLuong * donGia;
                        tongTien += thanhTien;
                    }
                }
            }
            if (!string.IsNullOrEmpty(maPT))
            {
                bool phieuNhapAdded = PhieuTraHangNCCDAO.Instance.ThemPhieuTraHang(maPT, tongTien, lyDo, ngayTao, manv, mapn);

                if (phieuNhapAdded)
                {
                    bool allDetailsAdded = true;
                    foreach (DataGridViewRow dgvRow in dvg_TaoPTH.Rows)
                    {
                        if (Convert.ToBoolean(dgvRow.Cells["Chon"].Value) == true)
                        {
                            if (dgvRow.Cells["MaSP"].Value != null)
                            {
                                string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                                decimal soLuongTra = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                                decimal donGia = Convert.ToDecimal(dgvRow.Cells["DonGia"].Value);
                                CTPhieuTraHangNCCDTO ctPhieuTraNCC = new CTPhieuTraHangNCCDTO
                                {
                                    MaCTPhieuTraHang = PhieuTraHangNCCDAO.GenerateMaCTPN(),
                                    MaPhieuTraHang = maPT,
                                    MaSP = maSP,
                                    SoLuong = soLuongTra,
                                    DonGia = donGia,
                                };
                                bool detailAdded = PhieuTraHangNCCDAO.Instance.ThemCTPhieuTraHang(ctPhieuTraNCC);
                                if (!detailAdded)
                                {
                                    allDetailsAdded = false;
                                }
                                decimal soLuongNhapGoc = TonKhoDAO.Instance.CapNhatTonKho(maSP, mapn);
                                decimal soLuongConLai = soLuongNhapGoc - soLuongTra;
                                if (soLuongConLai > 0)
                                {
                                    bool updated = PhieuNhapHangDAO.Instance.CapNhatTonKho(maSP, makho, soLuongConLai);
                                    if (!updated)
                                    {
                                        MessageBox.Show("Có lỗi khi cập nhật tồn kho cho sản phẩm " + maSP, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        else
                        {
                              string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                              decimal soLuong = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                              bool tonKhoUpdated = PhieuNhapHangDAO.Instance.CapNhatTonKho(maSP, makho, soLuong);
                        }
                    }
                    if (allDetailsAdded)
                    {
                        PhieuNhapHangDAO.Instance.CapNhatTrangThaiTraHang(mapn);
                        MessageBox.Show("Tạo phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        fnhaphang.LoadDSPNDaPheDuyet();
                        
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm phiếu trả hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo mã phiếu trả hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dvg_TaoPTH.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Chon"].Value) == true)
                {
                    if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            }
            txt_TongTien.Text = tongTien.ToString("N2");
        }

        private void dvg_TaoPTH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_TaoPTH.Rows[e.RowIndex];
                Tag = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                flag = Convert.ToDecimal(row.Cells["DonGia"].Value);
            }
            catch
            {

            }
        }

        private void dvg_TaoPTH_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_TaoPTH.Columns["SoLuong"].Index)
            {
                DataGridViewRow row = dvg_TaoPTH.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["SoLuong"].Value?.ToString(), out decimal soLuong))
                {
                    if (soLuong < 1)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 1.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["SoLuong"].Value = Tag;
                    }
                    else if (soLuong > Tag)
                    {
                        MessageBox.Show("Số lượng trả phải nhỏ hơn số lượng nhập");
                        row.Cells["SoLuong"].Value = Tag;
                    }
                    else
                    {
                        decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                        decimal thanhTien = soLuong * donGia;
                        row.Cells["ThanhTien"].Value = thanhTien;
                        UpdateTongTien();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["SoLuong"].Value = 0;
                }
            }
            else if (e.ColumnIndex == dvg_TaoPTH.Columns["DonGia"].Index)
            {
                MessageBox.Show("Không thể sửa giá trị Đơn Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row = dvg_TaoPTH.Rows[e.RowIndex];
                row.Cells["DonGia"].Value = flag;//reset lại giá tị từ Tag
            }
        }

        private void dvg_TaoPTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_TaoPTH.Columns["Chon"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_TaoPTH.Rows[e.RowIndex];
                bool isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (isChecked)
                {
                    try
                    {
                        string maSP = row.Cells["MaSP"].Value.ToString();
                        decimal SoLuong =Convert.ToDecimal(row.Cells["SoLuong"].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString());
                        selectedProducts.Add(new CTPhieuTraHangNCCDTO
                        {
                            MaSP = maSP,
                            SoLuong = SoLuong,
                            DonGia = donGia
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    
                }
            }
        }
    }
}
