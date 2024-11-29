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
    public partial class FormCapNhatKho : Form
    {
        private static string mapn;
        private static string makho;
        public FormCapNhatKho()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            makho = FormNhapHang.makho;
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_CapNhatKho.DataSource = listctpn;
            dvg_CapNhatKho.Columns["MaCTPhieuNH"].HeaderText = "Mã CT phiếu nhập hàng";
            dvg_CapNhatKho.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_CapNhatKho.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_CapNhatKho.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_CapNhatKho.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_CapNhatKho.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_CapNhatKho.Columns["DVT"].HeaderText = "DVT";
            dvg_CapNhatKho.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_CapNhatKho.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_CapNhatKho.Columns["SoLuong"].HeaderText = "Số lượng";
            dvg_CapNhatKho.Columns["DonGia"].HeaderText = "Dơn giá";
            dvg_CapNhatKho.Columns["TongTien"].HeaderText = "Tổng tiền";
            dvg_CapNhatKho.Columns["NgayNhapHang"].HeaderText = "Ngày nhập hàng";
            dvg_CapNhatKho.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }
        private void btn_CapNhatKho_Click(object sender, EventArgs e)
        {
            bool allUpdated = true;
            if (string.IsNullOrEmpty(makho))
            {
                MessageBox.Show("Không xác định được mã kho. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow dgvRow in dvg_CapNhatKho.Rows)
            {
                if (dgvRow.Cells["MaSP"].Value != null)
                {
                    string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                    
                    decimal soLuong = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                    bool tonKhoUpdated = PhieuNhapHangDAO.Instance.CapNhatTonKho(maSP, makho, soLuong);
                    if (!tonKhoUpdated)
                    {
                        allUpdated = false;
                    }
                }
            }

            if (allUpdated)
            {
                TonKhoDAO.Instance.CapNhatTrangThai(mapn);
                LoadCTPN();
                MessageBox.Show("Cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mapn = "";
            makho = "";
        }
    }
}
