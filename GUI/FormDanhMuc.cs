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
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
            HienThiKH();
            LoadLoaiKhachHang();
            LoadNCC();
            
        }
        private KhachHangDTO khDTO = new KhachHangDTO();
        bool IsInsert = false;
        private KhachHangDAO khDAO = new KhachHangDAO();
        private NhaCungCapDTO nccDTO = new NhaCungCapDTO();
        private NhaCungCapDAO nccDAO = new NhaCungCapDAO();
        private LoaiKhachHangDAO loaiKhachHangDAO = new LoaiKhachHangDAO();
        private LoaiKhachHangDTO lkhDTO = new LoaiKhachHangDTO();
        public void HienThiKH()
        {
            List<KhachHangDTO> listKH = KhachHangDAO.Instance.GetKhachHang();
            dgv_KH.Columns["MAKH"].DataPropertyName = "MAKH";
            dgv_KH.Columns["TENKH"].DataPropertyName = "TENKH";
            dgv_KH.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_KH.Columns["SDT"].DataPropertyName = "SoDienThoai";
            dgv_KH.Columns["EMAIL"].DataPropertyName = "EMAIL";
            dgv_KH.Columns["NgayTao"].DataPropertyName = "NGAYTAO";
            dgv_KH.DataSource = listKH;
            loadCBBLoaiKH();
            khoaDK();
        }
        public void loadCBBLoaiKH()
        {
            cbbLoaiKH.Items.Clear();
            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            var bindingList = new BindingList<LoaiKhachHangDTO>(listLoaiKH);
            cbbLoaiKH.DataSource = new BindingSource(bindingList, null);
            cbbLoaiKH.DisplayMember = "TenLoaiKH";
            cbbLoaiKH.ValueMember = "MaLoaiKH";
            if (cbbLoaiKH.Items.Count > 0)
            {
                cbbLoaiKH.SelectedIndex = 0;
            }
        }
        public void khoaDK()
        {
            txtMK.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtTenKH.Enabled = cbbLoaiKH.Enabled = dtpNgayTao.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtMK.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtTenKH.Enabled = cbbLoaiKH.Enabled = dtpNgayTao.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        private List<KhachHangDTO> listKH = new List<KhachHangDTO>();
        public void xoaTxt()
        {
            txtMK.Text = txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = string.Empty;
        }

        static string GenerateNewCode(List<KhachHangDTO> list)
        {

            if (list.Count == 0)
            {
                return "KH001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaKH;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }

        private void panel_top_Resize(object sender, EventArgs e)
        {
            label_qlhh.Location = new Point(
            (panel_top.Width - label_qlhh.Width) / 2,  
            (panel_top.Height - label_qlhh.Height) / 2  
            );
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMK.Text = GenerateNewCode(listKH);
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    khDAO.Delete(txtMK.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            HienThiKH();
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMK.Enabled = false;
            IsInsert = false;
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            khDTO.MaKH = txtMK.Text;
            khDTO.TenKH = txtTenKH.Text;
            khDTO.Email = txtEmail.Text;
            khDTO.Diachi = txtDiaChi.Text;
            khDTO.SoDienThoai = txtSDT.Text;
            khDTO.NgayTao = DateTime.Now;
            khDTO.MaLoaiKH = cbbLoaiKH.SelectedValue.ToString();
            try
            {

                if (IsInsert == true)
                {
                    //Insert
                    khDAO.Insert(khDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    //Update
                    khDAO.Update(khDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                HienThiKH();
                xoaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_KH.Rows[e.RowIndex];
                    txtMK.Text = row.Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    dtpNgayTao.Value = DateTime.Parse(row.Cells["NgayTao"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void LoadNCC()
        {
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
            dgv_NCC.DataSource = listNCC;
            khoaThem();
        }
        public void khoaThem()
        {
            txtMaNCC.Enabled = txt_SDTNCC.Enabled = txt_DiaChiNCC.Enabled = txtTenNCC.Enabled = txtThanhPho.Enabled = txt_QuocGia.Enabled = dateTimePicker_NCC.Enabled = txt_EmailNCC.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void moKhoaThem()
        {
            txtMaNCC.Enabled = txt_SDTNCC.Enabled = txt_DiaChiNCC.Enabled = txtTenNCC.Enabled = txtThanhPho.Enabled = txt_QuocGia.Enabled = dateTimePicker_NCC.Enabled = txt_EmailNCC.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private List<NhaCungCapDTO> listncc = new List<NhaCungCapDTO>();
        static string GenerateNewCode(List<NhaCungCapDTO> list)
        {

            if (list.Count == 0)
            {
                return "NCC001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaNCC;

            string prefix = lastCode.Substring(0, 3);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        public void clearTxt()
        {
            txtMaNCC.Text = txt_SDTNCC.Text = txt_DiaChiNCC.Text = txtThanhPho.Text = txt_QuocGia.Text = txtEmail.Text = string.Empty;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            moKhoaThem();
            IsInsert = true;
            clearTxt();
            txtMaNCC.Text = GenerateNewCode(listncc);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            moKhoaThem();
            txtMaNCC.Enabled = false;
            IsInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nccDAO.Delete(txtMaNCC.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    clearTxt();
                    khoaThem();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            LoadNCC();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nccDTO.MaNCC = txtMaNCC.Text;
            nccDTO.TenNCC = txtTenNCC.Text;
            nccDTO.Email = txt_EmailNCC.Text;
            nccDTO.ThanhPho = txtThanhPho.Text;
            nccDTO.DiaChi = txt_DiaChiNCC.Text;
            nccDTO.QuocGia = txt_QuocGia.Text;
            nccDTO.NgayTao = DateTime.Now;
            nccDTO.SDT = txt_SDTNCC.Text;
            try
            {

                if (IsInsert == true)
                {
                    //Insert
                    nccDAO.Insert(nccDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    //Update
                    nccDAO.Update(nccDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                LoadNCC();
                clearTxt();
                khoaThem();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaThem();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_NCC.Rows[e.RowIndex];
                    txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                    txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                    txt_SDTNCC.Text = row.Cells["SDT"].Value.ToString();
                    txt_EmailNCC.Text = row.Cells["Email"].Value.ToString();
                    txt_DiaChiNCC.Text = row.Cells["DiaChi"].Value.ToString();
                    txtThanhPho.Text = row.Cells["ThanhPho"].Value.ToString();
                    txt_QuocGia.Text = row.Cells["QuocGia"].Value.ToString();
                    dateTimePicker_NCC.Value = DateTime.Parse(row.Cells["NgayTao"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        //Loại khách hàng
        private void LoadLoaiKhachHang()
        {
            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            dgv_LoaiKhachHang.Columns["LoaiKH"].DataPropertyName = "MaLoaiKH";
            dgv_LoaiKhachHang.Columns["TenLoaiKH"].DataPropertyName = "TenLoaiKH";
            dgv_LoaiKhachHang.DataSource = listLoaiKH;
        }
        static string GenerateNewCode(List<LoaiKhachHangDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "LK001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaLoaiKH;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        private List<LoaiKhachHangDTO> listLKH = new List<LoaiKhachHangDTO>();
        private void btn_ThemLoaiKH_Click(object sender, EventArgs e)
        {
            txt_MaLoaiKH.Enabled = txt_TenLoaiKH.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
            IsInsert = true;
            txt_TenLoaiKH.Clear();
            txt_MaLoaiKH.Text = GenerateNewCode(listLKH);
        }

        private void btn_SuaLoaiKH_Click(object sender, EventArgs e)
        {
            txt_TenLoaiKH.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
            txt_MaLoaiKH.Enabled = false;
            IsInsert = false;
        }

        private void btn_XoaLoaiKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    loaiKhachHangDAO.Delete(txt_MaLoaiKH.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            LoadLoaiKhachHang();
        }

        private void btn_LuuLoaiKH_Click(object sender, EventArgs e)
        {
            string maLoaiKH = txt_MaLoaiKH.Text;
            string tenLoaiKH = txt_TenLoaiKH.Text;

            try
            {

                if (IsInsert == true)
                {
                    //Insert
                    loaiKhachHangDAO.Insert(maLoaiKH, tenLoaiKH);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    
                    loaiKhachHangDAO.Update(lkhDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                LoadLoaiKhachHang();
                xoaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trùng tên loại khách hàng");
            }
        }
    }
}
