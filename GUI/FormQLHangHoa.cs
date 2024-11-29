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
            LoadSanPham();
        }
        private void LoadLoaiSanPham()
        {
            List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            dvg_LoaiSP.DataSource = listLoaiSanPham;
            dvg_LoaiSP.Columns["MaLoai"].HeaderText = "Mã loại";
            dvg_LoaiSP.Columns["TenLoai"].HeaderText = "Tên loại";
            btn_Xoa.Enabled = btn_Sua.Enabled = btn_Luu.Enabled = false;
            btnThem.Enabled = true;
            txt_MaLoaiSP.Clear();
            txt_TenLoaiSP.Clear();
        }
        private bool ktTrungMa(string maloai)
        {
            return LoaiSanPhamDAO.Instance.KiemTraTrungMaLoai(maloai);
        }
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
        static string GenerateNewCodeLHH()
        {
            List<LoaiSanPhamDTO> listLSP = new List<LoaiSanPhamDTO>();
            listLSP = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            if (listLSP.Count == 0)
            {
                return "LSP001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = listLSP.Last().MaLoai;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLoai = GenerateNewCodeLHH();
            string tenLoai = txt_TenLoaiSP.Text;
            if ( tenLoai == "")
            {
                MessageBox.Show("Tên loại không được để trống");
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
                txt_MaLoaiSP.Enabled = false;
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
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
        }

        private void LoadSanPham()
        {
            List<HangHoaDTO> listSanPham = HangHoaDAO.Instance.GetSanPham();
            dvg_HangHoa.DataSource = listSanPham;
            dvg_HangHoa.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_HangHoa.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_HangHoa.Columns["DVT"].HeaderText = "ĐVT";
            dvg_HangHoa.Columns["TenLoai"].HeaderText = "Tên Loại";
            dvg_HangHoa.Columns["MaKho"].Visible = false;
            dvg_HangHoa.Columns["MaLoaiSP"].Visible = false;
            List<KhoDTO> listKho = KhoDAO.Instance.GetKho();
            List<LoaiSanPhamDTO> listLoaiSP = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            cb_LoaiHH.DataSource = listLoaiSP;
            cb_LoaiHH.DisplayMember = "TenLoai";
            cb_LoaiHH.ValueMember = "MaLoai";
            btn_ThemHH.Enabled = true;
            btn_XoaHH.Enabled = btn_SuaHH.Enabled = btn_LuuHH.Enabled = cb_LoaiSP.Enabled =false;
            cb_LoaiSP.SelectedItem = null;
            txt_MaHH.Clear();
            txt_TenHH.Clear();
            cb_DVT.SelectedIndex = 0;
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
            string loaiSP = cb_LoaiHH.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(maSP))
            {


                if (tenSP == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống");
                }
                else
                {
                    HangHoaDAO.Instance.ThemSanPham(maSP, tenSP, dvt, loaiSP);
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
                //cb_LoaiHH.SelectedValue = Convert.ToString(row.Cells["TenLoai"].Value);
                string tenLoai = row.Cells["TenLoai"].Value.ToString();

                foreach (LoaiSanPhamDTO loaiSP in cb_LoaiHH.Items)
                {
                    if (loaiSP.TenLoai == tenLoai)
                    {
                        cb_LoaiHH.SelectedItem = loaiSP;
                        break;
                    }
                }
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
                string loaiSP = cb_LoaiHH.SelectedValue.ToString();
                if (tenSP == "")
                {
                    MessageBox.Show("Tên sản phẩm không được để trống");
                }
                else
                {
                    HangHoaDAO.Instance.SuaSP(mahh, tenSP, dvt, loaiSP);
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    LoadSanPham();
                    txt_MaHH.Clear();
                    txt_TenHH.Clear();
                    cb_DVT.SelectedIndex = 0;
                    cb_LoaiHH.SelectedIndex = 0;
                    flag = 0;
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


        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
            txt_MaLoaiSP.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
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

        private void rd_LoaiHH_CheckedChanged(object sender, EventArgs e)
        {
            cb_LoaiSP.Enabled = true;
            List<LoaiSanPhamDTO> listLoaiSP = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            cb_LoaiSP.DataSource = listLoaiSP;
            cb_LoaiSP.DisplayMember = "TenLoai";
            cb_LoaiSP.ValueMember = "TenLoai";
        }

        private void btn_LocHH_Click(object sender, EventArgs e)
        {
            string value = cb_LoaiSP.SelectedValue.ToString();
            List<HangHoaDTO> listHH = HangHoaDAO.Instance.LocTheoTenLoaiSP(value);
            dvg_HangHoa.DataSource = listHH;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_body.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadLoaiSanPham();
                    break;
                case 1:

                    LoadLoaiSanPham();
                    break;
                case 2:

                    LoadTonKho();
                    break;
                default:
                    break;
            }
        }
        private void LoadTonKho()
        {
            List<Kho_SanPhamDTO> listkhosp = TonKhoDAO.Instance.GetTonKho();
            dvg_TonKho.DataSource = listkhosp;
            dvg_TonKho.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_TonKho.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_TonKho.Columns["TenLoaiSP"].HeaderText = "Loại sản phẩm";
            dvg_TonKho.Columns["DVT"].HeaderText = "Đơn vị tính";
            dvg_TonKho.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dvg_TonKho.Columns["TenKho"].HeaderText = "Tên kho";
        }

        private void rdb_Kho_CheckedChanged(object sender, EventArgs e)
        {
            cb_Kho.Enabled = btn_Loc.Enabled = true;
            txt_SearchKho.Enabled = false;
            List<KhoDTO> listKHo = KhoDAO.Instance.GetKho();
            cb_Kho.DataSource = listKHo;
            cb_Kho.DisplayMember = "TenKho";
            cb_Kho.ValueMember = "MaKho";
            flag = 1;
        }

        private void rdb_SanPham_CheckedChanged(object sender, EventArgs e)
        {
            txt_SearchKho.Enabled = btn_Loc.Enabled = true;
            cb_Kho.Enabled = false;
            cb_Kho.Text = null;
            flag = 0;
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string maKho = cb_Kho.SelectedValue.ToString();
                List<Kho_SanPhamDTO> listTonKho = TonKhoDAO.Instance.LocTheoKho(maKho);
                dvg_TonKho.DataSource = listTonKho;
            }
            else
            {
                string searchValue = txt_SearchKho.Text;
                List<Kho_SanPhamDTO> listTonKho = TonKhoDAO.Instance.LocTheoSP(searchValue);
                dvg_TonKho.DataSource = listTonKho;
            }
        }
    }
}
