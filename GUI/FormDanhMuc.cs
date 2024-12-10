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
        private bool IsInsert = false;
        private KhoDTO KhoDTO = new KhoDTO();
        private KhoDAO KhoDAO = new KhoDAO();
        private string makho;
        public FormDanhMuc()
        {
            InitializeComponent();
            LoadNCC();
        }
        private KhachHangDTO khDTO = new KhachHangDTO();
        bool IsUpdate = false;
        private KhachHangDAO khDAO = new KhachHangDAO();
        private NhaCungCapDTO nccDTO = new NhaCungCapDTO();
        private NhaCungCapDAO nccDAO = new NhaCungCapDAO();
        private LoaiKhachHangDAO loaiKhachHangDAO = new LoaiKhachHangDAO();
        private LoaiKhachHangDTO lkhDTO = new LoaiKhachHangDTO();
        public void HienThiKH()
        {
            List<KhachHangDTO>listKH = KhachHangDAO.Instance.GetKhachHang();
            dgv_KH.DataSource = listKH;
            dgv_KH.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgv_KH.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgv_KH.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgv_KH.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgv_KH.Columns["Email"].HeaderText = "Email";
            dgv_KH.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgv_KH.Columns["MaLoaiKH"].Visible = false;
            dgv_KH.Columns["TenLoaiKH"].HeaderText = "Loại khách hàng";
            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            cbbLoaiKH.DataSource = listLoaiKH;
            cbbLoaiKH.DisplayMember = "TenLoaiKH";
            cbbLoaiKH.ValueMember = "MaLoaiKH";
            tsbLuu.Enabled = false;
            xoaTxt();
        }
        static string GenerateNewCodeNCC()
        {
            List<NhaCungCapDTO> listNCC = new List<NhaCungCapDTO>();
            listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
          
            if (listNCC.Count == 0)
            {
                return "NCC001";
            }
            string lastCode = listNCC.Last().MaNCC;
            string prefix = lastCode.Substring(0, 3);
            string numberPart = lastCode.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newCode = $"{prefix}{number:D3}";
            return newCode;
        }
        static string GenerateNewCodeKH()
        {
            List<KhachHangDTO> listKh = new List<KhachHangDTO>();
            listKh = KhachHangDAO.Instance.GetKhachHang();

            if (listKh.Count == 0)
            {
                return "KH001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = listKh.Last().MaKH;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        static string GenerateNewCodeLKH()
        {
            List<LoaiKhachHangDTO> listLKH = new List<LoaiKhachHangDTO>();
            listLKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();

            if (listLKH.Count == 0)
            {
                return "LKH001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = listLKH.Last().MaLoaiKH;

            string prefix = lastCode.Substring(0, 3);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }

        private List<KhachHangDTO> listKH = new List<KhachHangDTO>();
        private bool ktDKKhachHang(string ma, string ten, string sdt, string email)
        {
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            bool isSdtEmpty = string.IsNullOrWhiteSpace(sdt);
            bool isEmailEmpty = string.IsNullOrWhiteSpace(email);
            if (isSdtEmpty && isEmailEmpty)
            {
                MessageBox.Show("Số điện thoại hoặc email phải được cung cấp ít nhất một cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            return true; 
        }
        public void xoaTxt()
        {
            txtMK.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear(); 
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            khDTO.MaKH = KhachHangDAO.GenerateMaKH();
            khDTO.TenKH = txtTenKH.Text;
            khDTO.Email = txtEmail.Text;
            khDTO.Diachi = txtDiaChi.Text;
            khDTO.SoDienThoai = txtSDT.Text;
            khDTO.NgayTao = DateTime.Now;
            khDTO.MaLoaiKH = cbbLoaiKH.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(khDTO.SoDienThoai) && !KiemTraDuLieuDAO.KTSoDienThoai(khDTO.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại bắt đầu với 0 hoặc +84 và có độ dài 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(khDTO.Email) && !KiemTraDuLieuDAO.KiemTraEmail(khDTO.SoDienThoai))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ktDKKhachHang(khDTO.MaKH, khDTO.TenKH, khDTO.SoDienThoai, khDTO.Email))
            {
                if (!string.IsNullOrEmpty(txtSDT.Text) && KhachHangDAO.Instance.KiemTraTrungSDT(txtSDT.Text) == true)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng");
                    return;
                }
                if (!string.IsNullOrEmpty(txtEmail.Text) && KhachHangDAO.Instance.KiemTraTrungEmail(txtEmail.Text) == true)
                {
                    MessageBox.Show("Email đã được sử dụng");
                    return;
                }
                else
                {
                    khDAO.Insert(khDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                    HienThiKH();
                }
            }
            HienThiKH();
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
                    HienThiKH();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            xoaTxt();
            dgv_KH.Refresh();
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            txtMK.Enabled = false;
            IsUpdate = true;
            tsbLuu.Enabled = true;
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            try
            {
                khDTO.MaKH = txtMK.Text;
                khDTO.TenKH = txtTenKH.Text;
                khDTO.Email = txtEmail.Text;
                khDTO.Diachi = txtDiaChi.Text;
                khDTO.SoDienThoai = txtSDT.Text;
                khDTO.NgayTao = DateTime.Now;
                khDTO.MaLoaiKH = cbbLoaiKH.SelectedValue.ToString();
                if (IsUpdate == true & ktDKKhachHang(khDTO.MaKH, khDTO.TenKH, khDTO.SoDienThoai, khDTO.Email))
                {
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
        
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_KH.Rows[e.RowIndex];
                    txtMK.Text = row.Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                    txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    dtpNgayTao.Value = DateTime.Parse(row.Cells["NgayTao"].Value.ToString());
                    string tenLoaiKH = row.Cells["TenLoaiKH"].Value.ToString();
                    foreach (LoaiKhachHangDTO loaiKH in cbbLoaiKH.Items)
                    {
                        if (loaiKH.TenLoaiKH == tenLoaiKH)
                        {
                            cbbLoaiKH.SelectedItem = loaiKH;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private bool ktDKNhaCungCap(string ma, string ten, string sdt, string email)
        {
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Mã Nhà Cung Cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên Nhà Cung Cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool isSdtEmpty = string.IsNullOrWhiteSpace(sdt);
            bool isEmailEmpty = string.IsNullOrWhiteSpace(email);
            if (isSdtEmpty && isEmailEmpty)
            {
                MessageBox.Show("Số điện thoại hoặc email phải được cung cấp ít nhất một cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadNCC()
        {
            listncc = NhaCungCapDAO.Instance.GetNhaCungCap();
            dgv_NCC.DataSource = listncc;
            dgv_NCC.Columns["MaNCC"].HeaderText = "Mã";
            dgv_NCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgv_NCC.Columns["SDT"].HeaderText = "SĐT";
            dgv_NCC.Columns["Email"].HeaderText = "Email";
            dgv_NCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgv_NCC.Columns["ThanhPho"].HeaderText = "Thành phố";
            dgv_NCC.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgv_NCC.Columns["NgayTao"].HeaderText = "Ngày tạo";
            btnLuu.Enabled = false;
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txt_DiaChiNCC.Clear();
            txt_SDTNCC.Clear();
            txt_EmailNCC.Clear();
            txtThanhPho.Clear();
            txt_QuocGia.Clear();
        }
 

        private List<NhaCungCapDTO> listncc = new List<NhaCungCapDTO>();

        public void clearTxt()
        {
            txtMaNCC.Text = txt_SDTNCC.Text = txt_DiaChiNCC.Text = txtThanhPho.Text = txt_QuocGia.Text = txtEmail.Text = txtTenNCC.Text = string.Empty;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            nccDTO.MaNCC = NhaCungCapDAO.GenerateMancc();
            nccDTO.TenNCC = txtTenNCC.Text;
            nccDTO.Email = txt_EmailNCC.Text;
            nccDTO.ThanhPho = txtThanhPho.Text;
            nccDTO.DiaChi = txt_DiaChiNCC.Text;
            nccDTO.QuocGia = txt_QuocGia.Text;
            nccDTO.NgayTao = DateTime.Now;
            nccDTO.SDT = txt_SDTNCC.Text;
            if (!string.IsNullOrEmpty(nccDTO.SDT) && !KiemTraDuLieuDAO.KTSoDienThoai(nccDTO.SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại bắt đầu với 0 hoặc +84 và có độ dài 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(nccDTO.Email) && !KiemTraDuLieuDAO.KiemTraEmail(nccDTO.Email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ktDKNhaCungCap(nccDTO.MaNCC, nccDTO.TenNCC, nccDTO.SDT, nccDTO.Email))
            {
                if(!string.IsNullOrEmpty(txt_SDTNCC.Text) && NhaCungCapDAO.Instance.KiemTraTrungSDT(txt_SDTNCC.Text)== true)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng");
                    return;
                }
                if (!string.IsNullOrEmpty(txt_EmailNCC.Text) && NhaCungCapDAO.Instance.KiemTraTrungEmail(txt_EmailNCC.Text) == true)
                {
                    MessageBox.Show("Email đã được sử dụng");
                    return;
                }
                else
                {
                    nccDAO.Insert(nccDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                    LoadNCC();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         
            txtMaNCC.Enabled = false;
            IsUpdate = true;
            btnLuu.Enabled = true;
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
            try
            {
                nccDTO.MaNCC = txtMaNCC.Text;
                nccDTO.TenNCC = txtTenNCC.Text;
                nccDTO.Email = txt_EmailNCC.Text;
                nccDTO.ThanhPho = txtThanhPho.Text;
                nccDTO.DiaChi = txt_DiaChiNCC.Text;
                nccDTO.QuocGia = txt_QuocGia.Text;
                nccDTO.NgayTao = DateTime.Now;
                nccDTO.SDT = txt_SDTNCC.Text;
                if (IsUpdate == true)
                {
                    nccDAO.Update(nccDTO);
                    MessageBox.Show("Sửa thông tin thành công!");
                }
                LoadNCC();
                clearTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private List<LoaiKhachHangDTO> listLKH = new List<LoaiKhachHangDTO>();
        private void LoadLoaiKhachHang()
        {
            listLKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            dgv_LoaiKhachHang.DataSource = listLKH;
            dgv_LoaiKhachHang.Columns["MaLoaiKH"].HeaderText = "Mã loại khách hàng";
            dgv_LoaiKhachHang.Columns["TenLoaiKH"].HeaderText = "Tên loại khách hàng";
            dgv_LoaiKhachHang.Columns["MucChiTieuToiThieu"].HeaderText = "Mức chi tiêu tối thiểu";
            dgv_LoaiKhachHang.Columns["MucChiTieuToiDa"].HeaderText = "Mức chi tiêu tối đa";
            btn_LuuLoaiKH.Enabled = false;
        }
  
        
        private bool ktDKLoaiKH(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                return false;
            }
            return true;
        }
        private void btn_ThemLoaiKH_Click(object sender, EventArgs e)
        {
            lkhDTO.MaLoaiKH = GenerateNewCodeLKH();
            lkhDTO.TenLoaiKH = txt_TenLoaiKH.Text;
            if(txt_MucChiTieuTD.Text == "" || txt_MucChiTieuToiThieu.Text == "")
            {
                lkhDTO.MucChiTieuToiThieu = null;
                lkhDTO.MucChiTieuToiDa = null;
            }
            else
            {
                lkhDTO.MucChiTieuToiThieu = decimal.Parse(txt_MucChiTieuToiThieu.Text);
                lkhDTO.MucChiTieuToiDa = decimal.Parse(txt_MucChiTieuTD.Text);
            }
            decimal toithieu, toida;
            if (!decimal.TryParse(txt_MucChiTieuToiThieu.Text, out toithieu)|| !decimal.TryParse(txt_MucChiTieuTD.Text, out toida)) 
            {
                MessageBox.Show("Vui lòng nhập vào một số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MucChiTieuToiThieu.Focus();
            }
            else
            {
                if(toithieu < 0)
                {
                    MessageBox.Show("Mức tối thiểu không được âm");
                    txt_MucChiTieuToiThieu.Focus();
                    return;
                }
                if (toida < 0)
                {
                    MessageBox.Show("Mức tối đa không được âm");
                    txt_MucChiTieuTD.Focus();
                    return;
                }
                if (toithieu > toida)
                {
                    MessageBox.Show("Mức tối đa không được nhỏ hơn mức tối thiểu");
                    txt_MucChiTieuTD.Focus();
                    return;
                }
                if (ktDKLoaiKH(lkhDTO.MaLoaiKH, lkhDTO.TenLoaiKH))
                {
                    loaiKhachHangDAO.Insert(lkhDTO.MaLoaiKH, lkhDTO.TenLoaiKH, lkhDTO.MucChiTieuToiThieu, lkhDTO.MucChiTieuToiDa);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else MessageBox.Show("Mã loại khách hàng và tên loại khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadLoaiKhachHang();
            }
        }

        private void btn_SuaLoaiKH_Click(object sender, EventArgs e)
        {
            btn_LuuLoaiKH.Enabled = true;
            txt_MaLoaiKH.Enabled = false;
            IsUpdate = true;
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
            try
            {
           
                lkhDTO.MaLoaiKH = txt_MaLoaiKH.Text;
                lkhDTO.TenLoaiKH = txt_TenLoaiKH.Text;
                if (txt_MucChiTieuTD.Text == "" || txt_MucChiTieuToiThieu.Text == "")
                {
                    lkhDTO.MucChiTieuToiThieu = null;
                    lkhDTO.MucChiTieuToiDa = null;
                }
                else
                {
                    lkhDTO.MucChiTieuToiThieu = decimal.Parse(txt_MucChiTieuToiThieu.Text);
                    lkhDTO.MucChiTieuToiDa = decimal.Parse(txt_MucChiTieuTD.Text);
                }
                if (IsUpdate == true)
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

        private void dgv_LoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgv_LoaiKhachHang.Rows[e.RowIndex];
                txt_MaLoaiKH.Text = Convert.ToString(row.Cells["MaLoaiKH"].Value);
                txt_TenLoaiKH.Text = Convert.ToString(row.Cells["TenLoaiKH"].Value);
                txt_MucChiTieuToiThieu.Text = Convert.ToString(row.Cells["MucChiTieuToiThieu"].Value);
                txt_MucChiTieuTD.Text = Convert.ToString(row.Cells["MucChiTieuToiDa"].Value);
                btn_ThemLoaiKH.Enabled = false;
                btn_XoaLoaiKH.Enabled = btn_SuaLoaiKH.Enabled = true;
                txt_MaLoaiKH.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào dòng");
                txt_MaLoaiKH.Clear();
                txt_TenLoaiKH.Clear();
                txt_MucChiTieuToiThieu.Clear();
                txt_MucChiTieuTD.Clear();
            }
        }
        

        private void tab_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_DanhMuc.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadNCC();
                    break;
                case 1:
                    HienThiKH();
                    break;
                case 2:
                    LoadLoaiKhachHang();
                    break;
                case 3:
                    LoadKho();
                    break;
                default:
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txt_DiaChiNCC.Clear();
            txt_SDTNCC.Clear();
            txt_EmailNCC.Clear();
            txtThanhPho.Clear();
            txt_QuocGia.Clear();
        }

        private void dgv_LoaiKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgv_LoaiKhachHang.Rows[e.RowIndex];
                txt_MaLoaiKH.Text = Convert.ToString(row.Cells["MaLoaiKH"].Value);
                txt_TenLoaiKH.Text = Convert.ToString(row.Cells["TenLoaiKH"].Value);
                txt_MucChiTieuToiThieu.Text = Convert.ToString(row.Cells["MucChiTieuToiThieu"].Value);
                txt_MucChiTieuTD.Text = Convert.ToString(row.Cells["MucChiTieuToiDa"].Value);
                btn_ThemLoaiKH.Enabled = false;
                btn_XoaLoaiKH.Enabled = btn_SuaLoaiKH.Enabled = true;
                txt_MaLoaiKH.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào dòng");
                txt_MaLoaiKH.Clear();
                txt_TenLoaiKH.Clear();
                txt_MucChiTieuToiThieu.Clear();
                txt_MucChiTieuTD.Clear();
            }
        }
        private List<KhoDTO> listkho = new List<KhoDTO>();
        private void TS_ThemKho_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaKho.Text = GenerateNewCode(listkho);
        }
        public void moKhoaDK()
        {
            txtTenKho.Enabled = uiTextBox1.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        static string GenerateNewCode(List<KhoDTO> list)
        {
            if (list.Count == 0)
            {
                return "MK001";
            }
            string lastCode = list.Last().MaKho;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }

        private void ts_SuaKho_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaKho.Enabled = false;
            IsInsert = false;
        }

        private void ts_LuuKho_Click(object sender, EventArgs e)
        {
            KhoDTO.MaKho = txtMaKho.Text;
            KhoDTO.TenKho = txtTenKho.Text;
            KhoDTO.DiaChi = uiTextBox1.Text;
            if(txtTenKho.Text == "" || uiTextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (IsInsert == true)
                    {
                        KhoDAO.Insert(KhoDTO);
                        MessageBox.Show("Thêm thông tin thành công!");
                    }
                    else
                    {
                        KhoDAO.Update(KhoDTO);
                        MessageBox.Show("Sửa thông tin thành công!");

                    }
                    LoadKho();
                    xoaTxt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            
        }
        private void LoadKho()
        {
            try
            {
                listkho = KhoDAO.Instance.GetKho();
                dgvKho.Columns["MaKho"].DataPropertyName = "MaKHO";
                dgvKho.Columns["TENKho"].DataPropertyName = "TenKHo";
                dgvKho.Columns["DiaChi"].DataPropertyName = "DiaCHI";
                dgvKho.DataSource = listkho;
            }
            catch
            {
                MessageBox.Show("Không có kho nào");
            }

        }

        private void ts_LamMoiKho_Click(object sender, EventArgs e)
        {
            uiTextBox1.Clear();
            txtMaKho.Clear();
            txtTenKho.Clear();
            LoadKho();
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                    makho = txtMaKho.Text = row.Cells["MaKho"].Value.ToString();
                    txtTenKho.Text = row.Cells["TenKho"].Value.ToString();
                    uiTextBox1.Text = row.Cells["DiaCHi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void khoaDK()
        {
            txtMaKho.Enabled = txtTenKho.Enabled = uiTextBox1.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }

        private void ts_XoaKho_Click(object sender, EventArgs e)
        {
            try
            {
                KhoDAO.Instance.Delete(makho);
                MessageBox.Show("Xóa thành công");
                LoadKho();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
