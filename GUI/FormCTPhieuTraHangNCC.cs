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
    public partial class FormCTPhieuTraHangNCC : Form
    {
        private string mapnh;
        public FormCTPhieuTraHangNCC()
        {
            InitializeComponent();
            mapnh = FormQLTraHangNCC.maPhieuTH;
            Load();
        }
        private void Load()
        {
            DataTable dt = PhieuTraHangNCCDAO.Instance.GetCTPhieuNH(mapnh);
            dgv_CTPhieuTH.DataSource = dt;
            dgv_CTPhieuTH.Columns["IDCTPhieuTHNCC"].HeaderText = "Mã CT phiếu trả";
            dgv_CTPhieuTH.Columns["MaPhieuTraHang"].HeaderText = "Mã phiếu trả";
            dgv_CTPhieuTH.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgv_CTPhieuTH.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgv_CTPhieuTH.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv_CTPhieuTH.Columns["DonGiaTra"].HeaderText = "Đơn giá trả";
            dgv_CTPhieuTH.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }
    }
}
