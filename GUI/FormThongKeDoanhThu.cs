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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent(); 
            gvdata.DataSource = HoaDonDAO.Instance.GetHoaDon();
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            gvdata.DataSource = listHoaDon;
            gvdata.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            gvdata.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            gvdata.Columns["TongTien"].HeaderText = "Tổng tiền";
            gvdata.Columns["TrangThai"].HeaderText = "Trạng thái";
            gvdata.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            gvdata.Columns["TienCoc"].HeaderText = "Tiền cọc";
            gvdata.Columns["ThanhToan"].HeaderText = "Thanh toán";
            gvdata.Columns["MaKH"].HeaderText = "Mã khách hàng";
            gvdata.Columns["TenKH"].HeaderText = "Tên khách hàng";
            gvdata.Columns["TenNV"].HeaderText = "Tên nhân viên tạo phiếu";
            gvdata.Columns["MaNV"].Visible = false;
            gvdata.Columns["SoTienKM"].HeaderText = "Số tiền khuyến mãi";

        }
        
        

        private void xemThongKe_Click(object sender, EventArgs e)
        {
            gvdata.DataSource = HoaDonDAO.Instance.GetHoaDonByTime(dtTuNgay.Value, dtDenNgay.Value);
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            gvdata.DataSource = HoaDonDAO.Instance.GetHoaDon();
        }
    }
}
