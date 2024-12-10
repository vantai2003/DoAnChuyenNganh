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
    public partial class FormInHoaDon : Form
    {
        public static string maPN;
        public static string maHD;
        public FormInHoaDon()
        {
            InitializeComponent();
            LoadDSPhieuNhap();
        }
        private void Load()
        {
            List<HoaDonDTO> listHD = HoaDonDAO.Instance.GetHoaDon();
            dgv_DSPhieuXuat.DataSource = listHD;
            dgv_DSPhieuXuat.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dgv_DSPhieuXuat.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dgv_DSPhieuXuat.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgv_DSPhieuXuat.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgv_DSPhieuXuat.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            dgv_DSPhieuXuat.Columns["TienCoc"].HeaderText = "Tiền cọc";
            dgv_DSPhieuXuat.Columns["ThanhToan"].HeaderText = "Thanh toán";
            dgv_DSPhieuXuat.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgv_DSPhieuXuat.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgv_DSPhieuXuat.Columns["MaNV"].Visible = false;
            dgv_DSPhieuXuat.Columns["TenNV"].HeaderText = "nhân viên lập phiếu";
            dgv_DSPhieuXuat.Columns["SoTienKM"].HeaderText = "Tiền khuyến mãi";
            dgv_DSPhieuXuat.Columns["SoTienDaThanhToan"].HeaderText = "Tiền đã thanh toán";
            //chuột phải thao tác xem  chi tiết
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItem = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItem.Click += XemChiTietMenuItem_Click1;
            contextMenu.Items.Add(xemChiTietMenuItem);
            dgv_DSPhieuXuat.ContextMenuStrip = contextMenu;

            dgv_DSPhieuXuat.AlternatingRowsDefaultCellStyle = null;
            dgv_DSPhieuXuat.DefaultCellStyle.BackColor = Color.Beige;
            dgv_DSPhieuXuat.DefaultCellStyle.ForeColor = Color.Black;
            // Dòng tiêu đề
            dgv_DSPhieuXuat.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgv_DSPhieuXuat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_DSPhieuXuat.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Các ô dữ liệu
            dgv_DSPhieuXuat.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dgv_DSPhieuXuat.DefaultCellStyle.SelectionForeColor = Color.White;

            // Border và đường viền
            dgv_DSPhieuXuat.BorderStyle = BorderStyle.Fixed3D;
            dgv_DSPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv_DSPhieuXuat.GridColor = Color.LightGray;

            // Vô hiệu hóa hiệu ứng mặc định tiêu đề
            dgv_DSPhieuXuat.EnableHeadersVisualStyles = false;
        }
        private void XemChiTietMenuItem_Click1(object sender, EventArgs e)
        {
            int rowIndex = dgv_DSPhieuXuat.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv_DSPhieuXuat.Rows[rowIndex];
            maHD = row.Cells["MaHD"].Value.ToString();
            FormCTHoaDon formCTHoaDon = new FormCTHoaDon(maHD);
            formCTHoaDon.Owner = this;
            formCTHoaDon.ShowDialog();
        }
        private void XemChiTietMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dvg_DSPhieuNhap.SelectedCells[0].RowIndex;
            DataGridViewRow row = dvg_DSPhieuNhap.Rows[rowIndex];
            maPN = row.Cells["MaPhieuNH"].Value.ToString();
            FormCTPhieuNhap_ChoNVKho formChiTiet = new FormCTPhieuNhap_ChoNVKho();
            formChiTiet.Show();
        }
        private void LoadDSPhieuNhap()
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

            dvg_DSPhieuNhap.AlternatingRowsDefaultCellStyle = null;
            dvg_DSPhieuNhap.DefaultCellStyle.BackColor = Color.Beige;
            dvg_DSPhieuNhap.DefaultCellStyle.ForeColor = Color.Black;
            // Dòng tiêu đề
            dvg_DSPhieuNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dvg_DSPhieuNhap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvg_DSPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Các ô dữ liệu
            dvg_DSPhieuNhap.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dvg_DSPhieuNhap.DefaultCellStyle.SelectionForeColor = Color.White;

            // Border và đường viền
            dvg_DSPhieuNhap.BorderStyle = BorderStyle.Fixed3D;
            dvg_DSPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvg_DSPhieuNhap.GridColor = Color.LightGray;

            // Vô hiệu hóa hiệu ứng mặc định tiêu đề
            dvg_DSPhieuNhap.EnableHeadersVisualStyles = false;

        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            FormXuaHD formXuatHD = new FormXuaHD();
            formXuatHD.ShowDialog();
        }

        private void dgv_DSPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgv_DSPhieuXuat.Rows[e.RowIndex];
                maHD = Convert.ToString(row.Cells["MaHD"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void btn_LocTheoNgay_Click(object sender, EventArgs e)
        {
            string tuNgay = Convert.ToString(dp_TuNgay.Value);
            string denNgay = Convert.ToString(dp_DenNgay.Value);
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.LocTheoNgay(tuNgay, denNgay);
            dvg_DSPhieuNhap.DataSource = listPN;
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị từ combobox Kho, nếu trống thì truyền null
            string tenNCC = string.IsNullOrEmpty(cbncc.SelectedValue?.ToString()) ? null : cbncc.SelectedValue.ToString();
            string tenKho = string.IsNullOrEmpty(cbkho.SelectedValue?.ToString()) ? null : cbkho.SelectedValue.ToString();
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.LocPhieuNhap(tenKho, tenNCC);
            dvg_DSPhieuNhap.DataSource = listPN;
        }

        private void btn_TimPN_Click(object sender, EventArgs e)
        {
            string searchValue = txt_SearchPN.Text;
            List<PhieuNhapHangDTO> listPN = PhieuNhapHangDAO.Instance.TimPhieuNhap(searchValue);
            dvg_DSPhieuNhap.DataSource = listPN;
        }

        private void tab_body_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_body.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadDSPhieuNhap();
                    break;
                case 1:

                    Load();
                    break;
                default:
                    break;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (maPN != null)
                {
                    FormInPhieuNhap formInPhieuNhap = new FormInPhieuNhap();
                    formInPhieuNhap.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu nhập muốn xuất");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xuất phiếu nhập, vui lòng thủ lại sau");
            }
        }

        private void dvg_DSPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSPhieuNhap.Rows[e.RowIndex];
                maPN = Convert.ToString(row.Cells["MaPhieuNH"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }
    }
}
