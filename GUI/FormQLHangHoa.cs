using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormQLHangHoa : Form
    {
        public FormQLHangHoa()
        {
            InitializeComponent();
            LoadLoaiSanPham();
            LoadSanPham();
        }
        private void LoadLoaiSanPham()
        {
            List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            dvg_LoaiSP.DataSource = listLoaiSanPham;
        }
        private bool ktTrungMa(string maloai)
        {
            return LoaiSanPhamDAO.Instance.KiemTraTrungMaLoai(maloai);
        }
        // Kiểm tra chuỗi không chứa khoảng trắng và không có chữ có dấu dùng Regex
        public bool IsValidInput(string input)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLoai = txt_MaLoaiSP.Text;
            string tenLoai = txt_TenLoaiSP.Text;
            if (maLoai == "" || tenLoai == "")
            {
                MessageBox.Show("Mã loại hoặc tên loại không được để trống");
            }
            else
            {
                if (IsValidInput(maLoai))
                {
                    if (ktTrungMa(maLoai))
                    {
                        MessageBox.Show("Mã loại đã tồn tại!");
                    }
                    else
                    {
                        LoaiSanPhamDAO.Instance.ThemLoaiSanPham(maLoai, tenLoai);
                        MessageBox.Show("Thêm loại sản phẩm thành công!");
                        LoadLoaiSanPham();
                        txt_MaLoaiSP.Clear();
                        txt_TenLoaiSP.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Mã Loại không đúng định dạng");
                }
            }
        }
        private void dvg_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_LoaiSP.Rows[e.RowIndex];
                txt_MaLoaiSP.Text = Convert.ToString(row.Cells["MaLoai"].Value);
                txt_TenLoaiSP.Text = Convert.ToString(row.Cells["TenLoai"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                txt_MaLoaiSP.Clear();
                txt_TenLoaiSP.Clear();
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maLoai = "";
            maLoai = txt_MaLoaiSP.Text;
            if (maLoai == "")
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm muốn xóa");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    LoaiSanPhamDAO.Instance.XoaLoaiSP(maLoai);
                    MessageBox.Show("Xóa loại sản phẩm thành công!");
                    txt_MaLoaiSP.Clear();
                    txt_TenLoaiSP.Clear();
                    LoadLoaiSanPham();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maLoai = "";
            maLoai = txt_MaLoaiSP.Text;

            if (maLoai == "")
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm muốn sửa");
            }
            else
            {
                string tenLoai = txt_TenLoaiSP.Text;
                LoaiSanPhamDAO.Instance.SuaLoaiSP(maLoai, tenLoai);
                txt_MaLoaiSP.Clear();
                txt_TenLoaiSP.Clear();
                MessageBox.Show("Sửa loai sản phẩm thành công");
                LoadLoaiSanPham();
            }
        }

        private void LoadSanPham()
        {
            List<HangHoaDTO> listSanPham = HangHoaDAO.Instance.GetSanPham();
            dvg_HangHoa.DataSource = listSanPham;
            List<KhoDTO> listKho = KhoDAO.Instance.GetKho();
            cb_Kho.DataSource = listKho;
            cb_Kho.DisplayMember = "TenKho";
            cb_Kho.ValueMember = "MaKho";
            List<LoaiSanPhamDTO> listLoaiSP = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            cb_LoaiHH.DataSource = listLoaiSP;
            cb_LoaiHH.DisplayMember = "TenLoai";
            cb_LoaiHH.ValueMember = "MaLoai";
        }
        private bool ktTrungMaSP(string masp)
        {
            return HangHoaDAO.Instance.KiemTraTrungMaSP(masp);
        }

        private void btn_ThemHH_Click(object sender, EventArgs e)
        {
            string maSP = HangHoaDAO.GenerateMaNV();
            string tenSP = txt_TenHH.Text;
            string dvt = cb_DVT.SelectedItem.ToString();
            string maKho = cb_Kho.SelectedValue.ToString();
            string loaiSP = cb_LoaiHH.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(maSP))
            {


                if (tenSP == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống");
                }
                else
                {
                    HangHoaDAO.Instance.ThemSanPham(maSP, tenSP, dvt, maKho, loaiSP);
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadSanPham();
                    txt_MaHH.Clear();
                    txt_TenHH.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo mã sản phẩm");
            }
        }
        // Kiểm tra chuỗi không chứa khoảng trắng và không có chữ có dấu dùng Regex

    }
}
