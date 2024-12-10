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
using System.Web.UI.Design;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DACN.GUI
{
    public partial class FormNhapHang : Form
    {
        public static string mancc;
        public static string manv;
        public static string mapn;
        public static string makho;
        public static decimal tongtien;
        private decimal Tag = 0;
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
            foreach (DataGridViewColumn column in dvg_TaoPN.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dvg_TaoPN.EnableHeadersVisualStyles = false;
            dvg_TaoPN.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  
            dvg_TaoPN.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); 
            dvg_TaoPN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvg_TaoPN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dvg_TaoPN.DefaultCellStyle.Font = new Font("Arial", 12); 
            dvg_TaoPN.RowTemplate.Height = 40;
            dvg_TaoPN.DefaultCellStyle.Padding = new Padding(5);
        }

        private void btn_ChonSP_Click(object sender, EventArgs e)
        {
            mancc = cb_NCC.SelectedValue.ToString();
            FormChonSanPham formChonSP = new FormChonSanPham();
            formChonSP.Owner = this;
            formChonSP.ShowDialog();
        }
        public void AddProductToReceipt(string maSP, string tenSP,string dvt, string tenloaisp)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dvg_TaoPN);
            row.Cells[0].Value = maSP;   
            row.Cells[1].Value = tenSP;    
            row.Cells[2].Value = dvt; 
            row.Cells[3].Value = tenloaisp; 
            dvg_TaoPN.Rows.Add(row);
            decimal tongTien = TinhTongThanhTien();
            txtTongTien.Text = tongTien.ToString("N2");
            AddDonGia();
        }
        private void AddDonGia()
        {
            decimal donGiaNhap = 0;
            foreach (DataGridViewRow row in dvg_TaoPN.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    string maNCC = cb_NCC.SelectedValue.ToString();
                    donGiaNhap = PhieuNhapHangDAO.Instance.GetDonGiaNhap(maSP, maNCC);
                    row.Cells["DonGia"].Value = donGiaNhap;
                    decimal soLuong = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                    row.Cells["ThanhTien"].Value = soLuong * donGiaNhap;
                }
            }
            if (donGiaNhap == 0)
            {
                MessageBox.Show("Vui lòng thêm giá nhập");
                return;
            }
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
        public void AnCombobox()
        {
            cb_NCC.Enabled = false;
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
            else
            {
                foreach (DataGridViewRow row in dvg_TaoPN.Rows)
                {
                    if (Convert.ToDecimal(row.Cells["SoLuong"].Value) == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0");
                        return;
                    }
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

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dvg_TaoPN.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    for (int i = dvg_TaoPN.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = dvg_TaoPN.SelectedRows[i];
                        dvg_TaoPN.Rows.Remove(row);
                        if (dvg_TaoPN.SelectedRows.Count == 0)
                        {
                            cb_NCC.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Kiểm tra nếu cột đang sửa là Số Lượng (Không cho phép sửa Đơn Giá)
            if (e.ColumnIndex == dvg_TaoPN.Columns["SoLuong"].Index)
            {
                DataGridViewRow row = dvg_TaoPN.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["SoLuong"].Value?.ToString(), out decimal soLuong))
                {
                    if (soLuong < 1)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 1.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["SoLuong"].Value = 0;
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
            else if (e.ColumnIndex == dvg_TaoPN.Columns["DonGia"].Index)
            {
                MessageBox.Show("Không thể sửa giá trị Đơn Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row = dvg_TaoPN.Rows[e.RowIndex];
                row.Cells["DonGia"].Value = Tag;//reset lại giá tị từ Tag
            }
        }
        private void LoadDSPN()
        {
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.GetPhieuNhap();
            dvg_DSPhieuNhap.DataSource = listPN;
            dvg_DSPhieuNhap.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_DSPhieuNhap.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dvg_DSPhieuNhap.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSPhieuNhap.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_DSPhieuNhap.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dvg_DSPhieuNhap.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_DSPhieuNhap.Columns["TenKho"].HeaderText = "Tên kho";
            dvg_DSPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
            List<KhoDTO> listkho = KhoDAO.Instance.GetKho();
            cbkho.DataSource = listkho;
            cbkho.DisplayMember = "TenKho";
            cbkho.ValueMember = "TenKho";
            List<NhaCungCapDTO> listncc = NhaCungCapDAO.Instance.GetNhaCungCap();
            cbncc.DataSource = listncc;
            cbncc.DisplayMember = "TenNCC";
            cbncc.ValueMember = "TenNCC";
            cb_CongTy.SelectedIndex = 0;
            //chuột phải thao tác xem  chi tiết
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItem = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItem.Click += XemChiTietMenuItem_Click;
            contextMenu.Items.Add(xemChiTietMenuItem);
            dvg_DSPhieuNhap.ContextMenuStrip = contextMenu;
            //add nút xóa
            if (!dvg_DSPhieuNhap.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    HeaderText = "Hành động",
                    Name = "btnDelete",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    FlatStyle = FlatStyle.Flat
                };
                btnDelete.DefaultCellStyle.BackColor = Color.DarkBlue;
                btnDelete.DefaultCellStyle.ForeColor = Color.DeepPink;
                btnDelete.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dvg_DSPhieuNhap.Columns.Add(btnDelete);
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Name = "btnEdit",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    FlatStyle = FlatStyle.Flat
                };
                btnEdit.DefaultCellStyle.BackColor = Color.White;
                btnEdit.DefaultCellStyle.ForeColor = Color.DarkViolet;
                btnEdit.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dvg_DSPhieuNhap.Columns.Add(btnEdit);
            }
        }
        private void XemChiTietMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dvg_DSPhieuNhap.SelectedCells[0].RowIndex;
            DataGridViewRow row = dvg_DSPhieuNhap.Rows[rowIndex];
            mapn = row.Cells["MaPhieuNH"].Value.ToString();
            FormCTPhieuNhap_ChoNVKho formChiTiet = new FormCTPhieuNhap_ChoNVKho();
            formChiTiet.Show();
        }
        public void LoadDSPNDaPheDuyet()
        {
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.DSPhieuNhapDaPD();
            dvg_DSPNDPD.DataSource = listPN;
            dvg_DSPNDPD.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_DSPNDPD.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dvg_DSPNDPD.Columns["TongTien"].HeaderText = "Tổng tiền";
            dvg_DSPNDPD.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSPNDPD.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_DSPNDPD.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dvg_DSPNDPD.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_DSPNDPD.Columns["TenKho"].HeaderText = "Tên kho";
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
                    LoadDSPNDaPheDuyet();
                    break;
                default:
                    break;
            }
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if(mapn == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhâp");
            }
            else
            {
                FormCapNhatKho fcnk = new FormCapNhatKho();
                fcnk.ShowDialog();
            }
            
        }

        private void btn_TaoPTH_Click(object sender, EventArgs e)
        {
            if (mapn == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhâp");
            }
            else
            {
                FormTaoPhieuTraHangNCC ftpth = new FormTaoPhieuTraHangNCC();
                ftpth.ShowDialog();
            }
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

        private void btn_SuaPN_Click(object sender, EventArgs e)
        {
            FormSuaPhieuNhap fSuaPN = new FormSuaPhieuNhap();
            fSuaPN.ShowDialog();
        }

        private void btn_LocTheoNgay_Click(object sender, EventArgs e)
        {
            string tuNgay = Convert.ToString(dp_TuNgay.Value);
            string denNgay =Convert.ToString(dp_DenNgay.Value);
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.LocTheoNgay(tuNgay, denNgay);
            dvg_DSPhieuNhap.DataSource = listPN;
        }

        private void dvg_DSPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dvg_DSPhieuNhap.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string id = dvg_DSPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNH"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = PhieuNhapHangDAO.Instance.XoaPN(id);
                    if (success)
                    {
                        MessageBox.Show("Hãy chờ phê duyệt.");
                    }
                    else
                    {
                        MessageBox.Show("Gửi yêu cầu xóa không thành công.");
                    }
                }
            }
            if(e.ColumnIndex == dvg_DSPhieuNhap.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                mapn = dvg_DSPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNH"].Value.ToString();
                tongtien = decimal.Parse(dvg_DSPhieuNhap.Rows[e.RowIndex].Cells["TongTien"].Value.ToString());
                string trangThai = dvg_DSPhieuNhap.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                if(trangThai == "Chờ phê duyệt nhập")
                {
                    FormSuaPhieuNhap fSuaPN = new FormSuaPhieuNhap();
                    fSuaPN.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không thể sửa phiếu nhập!");
                }
            }
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

        private void dvg_TaoPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_TaoPN.Rows[e.RowIndex];
                Tag = Convert.ToDecimal(row.Cells["DonGia"].Value);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }
    }
}
