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
    public partial class FormBaoCao : Form
    {
       
        public FormBaoCao(DateTime ngayTu, DateTime ngayDen)
        {
            InitializeComponent();
        }
        public void LoadBaoCaoHD()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvBaoCao.DataSource = listHoaDon;
            dgvBaoCao.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dgvBaoCao.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dgvBaoCao.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvBaoCao.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvBaoCao.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            dgvBaoCao.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvBaoCao.Columns["TienCoc"].HeaderText = "Tiền cọc";
            dgvBaoCao.Columns["ThanhToan"].HeaderText = "Số tiền cần toán";
            dgvBaoCao.Columns["SoTienKM"].HeaderText = "Số tiền khuyến mãi";
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItemHD = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItemHD.Click += XemChiTietMenuItemHD_Click;
            contextMenu.Items.Add(xemChiTietMenuItemHD);
            dgvBaoCao.ContextMenuStrip = contextMenu;
           
        }
        private void XemChiTietMenuItemHD_Click(object sender, EventArgs e)
        {
            string mahd;
            int rowIndex = dgvBaoCao.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvBaoCao.Rows[rowIndex];
            mahd = row.Cells["MaHD"].Value.ToString();

            FormCTHoaDon formCTHoaDon = new FormCTHoaDon(mahd);
            formCTHoaDon.Owner = this;
            formCTHoaDon.ShowDialog();
            
        }
        public void LoadBaoCaoPN()
        {
            List<PhieuNhapHangDTO> listphieunhap = PhieuNhapHangDAO.Instance.GetPhieuNhapStatus();
            dgvBaoCao.DataSource = listphieunhap;
            dgvBaoCao.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dgvBaoCao.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dgvBaoCao.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvBaoCao.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvBaoCao.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvBaoCao.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvBaoCao.Columns["TenKho"].HeaderText = "Tên kho";
            //chuột phải thao tác xem  chi tiết
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItemPN = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItemPN.Click += XemChiTietMenuItemPN_Click;
            contextMenu.Items.Add(xemChiTietMenuItemPN);
            dgvBaoCao.ContextMenuStrip = contextMenu;
          
        }
        private void XemChiTietMenuItemPN_Click(object sender, EventArgs e)
        {
            string mapn;
            int rowIndex = dgvBaoCao.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvBaoCao.Rows[rowIndex];
            mapn = row.Cells["MaPN"].Value.ToString();


            FormCTHoaDon formCTHoaDon = new FormCTHoaDon(null);
            formCTHoaDon.Owner = this;
            formCTHoaDon.LoadCTPN(mapn);
            formCTHoaDon.ShowDialog();

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
