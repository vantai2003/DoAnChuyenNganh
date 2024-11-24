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
    public partial class FormDuyetPhieuNhap : Form
    {
        public FormDuyetPhieuNhap()
        {
            InitializeComponent();

            LoadDSPD();
        }
        public static string maPN = "";
        private string trangThai = "";
        private void LoadDSPD()
        {
            List<PhieuNhapHangDTO> listphieunhap = PhieuNhapHangDAO.Instance.GetPhieuNhapStatus();
            dvg_DSDPN.DataSource = listphieunhap;
            dvg_DSDPN.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            dvg_DSDPN.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
            dvg_DSDPN.Columns["TongTien"].HeaderText = "Tổng tiền";
            dvg_DSDPN.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSDPN.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_DSDPN.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_DSDPN.Columns["TenKho"].HeaderText = "Tên kho";
            //chuột phải thao tác xem  chi tiết
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItem = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItem.Click += XemChiTietMenuItem_Click;
            contextMenu.Items.Add(xemChiTietMenuItem);
            dvg_DSDPN.ContextMenuStrip = contextMenu;
            maPN = "";
        }
        private void XemChiTietMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dvg_DSDPN.SelectedCells[0].RowIndex;
            DataGridViewRow row = dvg_DSDPN.Rows[rowIndex];
            maPN = row.Cells["MaPhieuNH"].Value.ToString();
            FormChiTietPhieuNhap fctpn = new FormChiTietPhieuNhap();
            fctpn.ShowDialog();
        }
        private void btn_PheDuyet_Click(object sender, EventArgs e)
        {
            if(maPN == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn phê duyệt");
            }
            else
            {
                if (trangThai == "Chờ phê duyệt nhập")
                {
                    PhieuNhapHangDAO.Instance.PheDuyetPN(maPN);
                    MessageBox.Show("Đã phê duyệt!");
                    LoadDSPD();
                }
                else
                {
                    PhieuNhapHangDAO.Instance.PheDuyetXoa(maPN);
                    MessageBox.Show("Đã phê duyệt xóa");
                    LoadDSPD();
                }
                
            }

        }

        private void dvg_DSDPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSDPN.Rows[e.RowIndex];
                maPN = Convert.ToString(row.Cells["MaPhieuNH"].Value);
                trangThai = Convert.ToString(row.Cells["TrangThai"].Value);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn vào người dùng");
            }
        }

        private void btn_TuChoi_Click(object sender, EventArgs e)
        {
            if (maPN == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn từ chối");
            }
            else
            {
                if (trangThai == "Chờ phê duyệt nhập")
                {
                    PhieuNhapHangDAO.Instance.TuChoiPN(maPN);
                    MessageBox.Show("Đã từ chối!");
                }
                else
                {
                    PhieuNhapHangDAO.Instance.TuChoiYeuCauXoa(maPN);
                    MessageBox.Show("Đã từ chối yêu cầu xóa");
                }
                LoadDSPD();
            }
        }
        private void LoadDSPN()
        {
            List<PhieuNhapHangDTO> listphieunhap = PhieuNhapHangDAO.Instance.GetPhieuNhap();
            dvg_DSPN.DataSource = listphieunhap;
        }

        private void tab_DuyetPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_DuyetPN.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadDSPD();
                    break;
                case 1:

                    LoadDSPN();
                    break;
                default:
                    break;
            }
        }

        private void dvg_DSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSPN.Rows[e.RowIndex];
                maPN = Convert.ToString(row.Cells["MaPhieuNH"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void btn_CTPN_Click(object sender, EventArgs e)
        {
            FormChiTietPhieuNhap fctpn = new FormChiTietPhieuNhap();
            fctpn.ShowDialog();
        }
    }
}
