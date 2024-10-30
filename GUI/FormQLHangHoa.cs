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
        private int selectedRowIndex = -1;
        private int flag;
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
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
            btnThem.Enabled = true;
            txt_MaLoaiSP.Clear();
            txt_TenLoaiSP.Clear();
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

           List<LoaiSanPhamDTO> listloaisp = LoaiSanPhamDAO.Instance.TimKiemLHH(txt_Search.Text);
            dvg_LoaiSP.DataSource=listloaisp;

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
                btnThem.Enabled = false;
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
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
            try
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
            catch 
            {
                MessageBox.Show("Không xóa được loại sản phẩm này !");
                
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
            btn_ThemHH.Enabled = true;
            btn_XoaHH.Enabled = btn_SuaHH.Enabled = btn_LuuHH.Enabled =false;
            txt_MaHH.Clear();
            txt_TenHH.Clear();
            cb_DVT.SelectedIndex = 0;
            cb_Kho.SelectedIndex = 0;
            cb_LoaiHH.SelectedIndex = 0;
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

        private void dvg_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = new DataGridViewRow();
                row = dvg_HangHoa.Rows[e.RowIndex];
                txt_MaHH.Text = Convert.ToString(row.Cells["MaSP"].Value);
                txt_TenHH.Text = Convert.ToString(row.Cells["TenSP"].Value);
                cb_DVT.SelectedItem = row.Cells["DVT"].Value.ToString();
                cb_Kho.SelectedValue = Convert.ToString(row.Cells["MaKho"].Value);
                cb_LoaiHH.SelectedValue = Convert.ToString(row.Cells["MaLoaiSP"].Value);
                btn_XoaHH.Enabled = true;
                btn_ThemHH.Enabled = false;
                btn_SuaHH.Enabled = true;
            }
            
        }

        private void btn_XoaHH_Click(object sender, EventArgs e)
        {
            string masp = "";
            masp = txt_MaHH.Text;
            if (masp == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    HangHoaDAO.Instance.XoaSP(masp);
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    txt_MaHH.Clear();
                    txt_TenHH.Clear();
                    cb_DVT.SelectedIndex = 0;
                    cb_Kho.SelectedIndex = 0;
                    cb_LoaiHH.SelectedIndex = 0;
                    LoadSanPham();
                }
            }          
        }

        private void btn_SuaHH_Click(object sender, EventArgs e)
        {
            btn_LuuHH.Enabled = true;
            flag = 1;
                
        }

        private void btn_ReloadHH_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btn_LuuHH_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string mahh = txt_MaHH.Text;
                string tenSP = txt_TenHH.Text;
                string dvt = cb_DVT.SelectedItem.ToString();
                string maKho = cb_Kho.SelectedValue.ToString();
                string loaiSP = cb_LoaiHH.SelectedValue.ToString();
                if (tenSP == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống");
                }
                else
                {
                    HangHoaDAO.Instance.SuaSP(mahh, tenSP, dvt, maKho, loaiSP);
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    LoadSanPham();
                    txt_MaHH.Clear();
                    txt_TenHH.Clear();
                    cb_DVT.SelectedIndex = 0;
                    cb_Kho.SelectedIndex = 0;
                    cb_LoaiHH.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_SearchHH_Click(object sender, EventArgs e)
        {
            List<HangHoaDTO> listHH = HangHoaDAO.Instance.TimKiemHH(txt_SearchHH.Text);
            dvg_HangHoa.DataSource = listHH;
        }

        private void rd_kho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
