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
    public partial class FormQLGiaNhapTuNCC : Form
    {
        private string masp;
        private string mancc;
        public FormQLGiaNhapTuNCC()
        {
            InitializeComponent();
            LoadBaoGia();
        }
        private void LoadBaoGia()
        {
            List<SanPham_NhaCungCapDTO> listSPNCC = SanPham_NhaCCDAO.Instance.ListBangGia();
            dvg_BangGia.DataSource = listSPNCC;
            dvg_BangGia.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            dvg_BangGia.Columns["TenNCC"].HeaderText = "Nhà cung cấp";
            dvg_BangGia.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_BangGia.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_BangGia.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_BangGia.Columns["DVT"].HeaderText = "DVT";
            dvg_BangGia.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dvg_BangGia.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
            List<HangHoaDTO> listHH = HangHoaDAO.Instance.GetSanPham();
            cb_SanPham.DataSource = listHH;
            cb_SanPham.DisplayMember = "TenSP";
            cb_SanPham.ValueMember = "TenSP";

            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
            cb_NCC.DataSource = listNCC;
            cb_NCC.DisplayMember = "TenNCC";
            cb_NCC.ValueMember = "TenNCC";

            cb_SanPham.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_SanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cb_NCC.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_NCC.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_GiaNhap.Clear();
            dp_NgayCapNhat.Value = DateTime.Now; 
        }

        private void dvg_BangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_BangGia.Rows[e.RowIndex];
                masp = Convert.ToString(row.Cells["MaSP"].Value);
                mancc = Convert.ToString(row.Cells["MaNCC"].Value);
                txt_GiaNhap.Text = Convert.ToString(row.Cells["GiaNhap"].Value);
                dp_NgayCapNhat.Text = Convert.ToString(row.Cells["NgayCapNhat"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào bảng");
                txt_GiaNhap.Clear();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            bool ktDuLieu = KiemTraDuLieuDAO.KiemTraDuLieuSo(txt_GiaNhap.Text);
            if (ktDuLieu == true)
            {
                decimal giaNhap = Convert.ToDecimal(txt_GiaNhap.Text);
                DateTime ngayCapNhat = dp_NgayCapNhat.Value;
                bool kq = BangBaoGiaTuNCCDAO.Instance.CapNhatGia(masp, mancc, giaNhap, ngayCapNhat);
                MessageBox.Show("Cập nhật giá thành công");
                LoadBaoGia();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            string tenSP = string.IsNullOrEmpty(cb_SanPham.SelectedValue?.ToString()) ? null : cb_SanPham.SelectedValue.ToString();
            string tenNCC = string.IsNullOrEmpty(cb_NCC.SelectedValue?.ToString()) ? null : cb_NCC.SelectedValue.ToString();
            List<SanPham_NhaCungCapDTO> listBG = BangBaoGiaTuNCCDAO.Instance.LocBangBaoGia(tenSP, tenNCC);
            dvg_BangGia.DataSource = listBG;
        }
    }
}
