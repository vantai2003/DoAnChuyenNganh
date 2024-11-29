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
    public partial class FormCTPhieuNhap_ChoNVKho : Form
    {
        private string mapn;
        public FormCTPhieuNhap_ChoNVKho()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            LoadCTPN();
            this.Width = 1200;
            this.Height = 600;
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_CTPN.DataSource = listctpn;
            dvg_CTPN.Columns["MaCTPhieuNH"].HeaderText = "Mã chi tiết phiếu nhập";
            dvg_CTPN.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_CTPN.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_CTPN.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_CTPN.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_CTPN.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập";
            dvg_CTPN.Columns["DVT"].HeaderText = "DVT";
            dvg_CTPN.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_CTPN.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_CTPN.Columns["SoLuong"].HeaderText = "Số lượng";
            dvg_CTPN.Columns["DonGia"].HeaderText = "Đơn giá";
            dvg_CTPN.Columns["NgayNhapHang"].HeaderText = "Ngày nhập hàng";
            dvg_CTPN.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dvg_CTPN.Columns["TongTien"].Visible = false;
        }
    }
}
