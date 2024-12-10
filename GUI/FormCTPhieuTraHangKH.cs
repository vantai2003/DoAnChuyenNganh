using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DAO;
using DACN.DTO;

namespace DACN.GUI
{
    public partial class FormCTPhieuTraHangKH : Form
    {
        string mahd;
        public FormCTPhieuTraHangKH()
        {
            InitializeComponent();
            LoadCTPT();
        }

        public void LoadCTPT()
        {
            mahd = FormHoaDon.mahd;
            List<CTPhieuTraHangKHDTO> listHoaDon = PhieuTraHangKHDAO.Instance.GetCTPThieuTra_KH(mahd);
            dgvCTHD.DataSource = listHoaDon;
            dgvCTHD.Columns["MaCTPhieuTraHang"].HeaderText = "Mã Phiếu Trả Hàng";
            dgvCTHD.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgvCTHD.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgvCTHD.Columns["SoLuong"].HeaderText = "Số Lượng Trả";
            dgvCTHD.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvCTHD.Columns["TongTienNhan"].HeaderText = "Tổng Tiền Nhận";
            dgvCTHD.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvCTHD.Columns["LyDo"].HeaderText = "Lý Do";
            dgvCTHD.Columns["MaPhieuTraHang"].Visible = false;
        }
    }
}
