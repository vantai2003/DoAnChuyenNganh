using DACN.DAO;
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
    public partial class FormQLTraHangNCC : Form
    {
        public static string maPhieuTH;
        public FormQLTraHangNCC()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            DataTable dtPTH = PhieuTraHangNCCDAO.Instance.GetPhieuTraHang();
            dvg_PhieuTH.DataSource = dtPTH;
            dvg_PhieuTH.Columns["MaPhieuTraHang"].HeaderText = "Mã phiếu trả hàng";
            dvg_PhieuTH.Columns["TongTienNhan"].HeaderText = "Tổng tiền nhận";
            dvg_PhieuTH.Columns["LyDo"].HeaderText = "Lý do";
            dvg_PhieuTH.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_PhieuTH.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dvg_PhieuTH.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dvg_PhieuTH.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập hàng";
            //add xem chi tiết
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xemChiTietMenuItem = new ToolStripMenuItem("Xem chi tiết");
            xemChiTietMenuItem.Click += XemChiTietMenuItem_Click;
            contextMenu.Items.Add(xemChiTietMenuItem);
            dvg_PhieuTH.ContextMenuStrip = contextMenu;
            this.Width = 1150;
            this.Height = 800;
        }
        private void XemChiTietMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dvg_PhieuTH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dvg_PhieuTH.Rows[rowIndex];
            maPhieuTH = row.Cells["MaPhieuTraHang"].Value.ToString();
            FormCTPhieuTraHangNCC fCTPTraHang = new FormCTPhieuTraHangNCC();
            fCTPTraHang.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text;
            DataTable dtPTH = PhieuTraHangNCCDAO.Instance.TimPhieuTHNCC(searchValue);
            dvg_PhieuTH.DataSource = dtPTH;
        }

        private void dvg_PhieuTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_PhieuTH.Rows[e.RowIndex];
                maPhieuTH = Convert.ToString(row.Cells["MaPhieuTraHang"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(maPhieuTH == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu trả hàng");
                return;
            }
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn xóa phiếu trả hàng này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                bool kq = PhieuTraHangNCCDAO.Instance.XoaPhieuTHNCC(maPhieuTH);
                if (kq) {
                    MessageBox.Show("Xóa thành công");
                    Load();
                    maPhieuTH = null;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            
        }
    }
}
