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
        bool IsUpdate = false;
        private KhachHangDAO khDAO = new KhachHangDAO();
        private NhaCungCapDTO nccDTO = new NhaCungCapDTO();
        private NhaCungCapDAO nccDAO = new NhaCungCapDAO();
        private LoaiKhachHangDAO loaiKhachHangDAO = new LoaiKhachHangDAO();
        private LoaiKhachHangDTO lkhDTO = new LoaiKhachHangDTO();
        public void HienThiKH()
        {
            listKH = KhachHangDAO.Instance.GetKhachHang();
            dgv_KH.Columns["MAKH"].DataPropertyName = "MAKH";
            dgv_KH.Columns["TENKH"].DataPropertyName = "TENKH";
            dgv_KH.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_KH.Columns["SDT"].DataPropertyName = "SoDienThoai";
            dgv_KH.Columns["EMAIL"].DataPropertyName = "EMAIL";
            dgv_KH.Columns["NgayTao"].DataPropertyName = "NGAYTAO";
            dgv_KH.DataSource = listKH;
            tsbLuu.Enabled = false;
            loadCBBLoaiKH();
           
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
            txtMK.Text = txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = string.Empty;
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
            
            khDTO.MaKH = txtMK.Text;
            khDTO.TenKH = txtTenKH.Text;
            khDTO.Email = txtEmail.Text;
            khDTO.Diachi = txtDiaChi.Text;
            khDTO.SoDienThoai = txtSDT.Text;
            khDTO.NgayTao = DateTime.Now;
            khDTO.MaLoaiKH = cbbLoaiKH.SelectedValue.ToString();
            if(ktDKKhachHang(khDTO.MaKH, khDTO.TenKH, khDTO.SoDienThoai, khDTO.Email))
            {
                khDAO.Insert(khDTO);
                MessageBox.Show("Thêm thông tin thành công!");

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
                    cbbLoaiKH.Text = row.Cells["MaLoaiKH"].Value.ToString();
                    
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
            btnLuu.Enabled = false;
        }
 

        private List<NhaCungCapDTO> listncc = new List<NhaCungCapDTO>();

        public void clearTxt()
        {
            txtMaNCC.Text = txt_SDTNCC.Text = txt_DiaChiNCC.Text = txtThanhPho.Text = txt_QuocGia.Text = txtEmail.Text = txtTenNCC.Text = string.Empty;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            nccDTO.MaNCC = txtMaNCC.Text;
            nccDTO.TenNCC = txtTenNCC.Text;
            nccDTO.Email = txt_EmailNCC.Text;
            nccDTO.ThanhPho = txtThanhPho.Text;
            nccDTO.DiaChi = txt_DiaChiNCC.Text;
            nccDTO.QuocGia = txt_QuocGia.Text;
            nccDTO.NgayTao = DateTime.Now;
            nccDTO.SDT = txt_SDTNCC.Text;
            if (ktDKNhaCungCap(nccDTO.MaNCC, nccDTO.TenNCC, nccDTO.SDT, nccDTO.Email))
            {
                //Insert
                nccDAO.Insert(nccDTO);
                MessageBox.Show("Thêm thông tin thành công!");
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
               
                    //Update
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
            listLKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            dgv_LoaiKhachHang.Columns["LoaiKH"].DataPropertyName = "MaLoaiKH";
            dgv_LoaiKhachHang.Columns["TenLoaiKH"].DataPropertyName = "TenLoaiKH";
            dgv_LoaiKhachHang.DataSource = listLKH;
            btn_LuuLoaiKH.Enabled = false;
        }
  
        private List<LoaiKhachHangDTO> listLKH = new List<LoaiKhachHangDTO>();
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
            lkhDTO.MaLoaiKH = txt_MaLoaiKH.Text;
            lkhDTO.TenLoaiKH = txt_TenLoaiKH.Text;
            if (ktDKLoaiKH(lkhDTO.MaLoaiKH, lkhDTO.TenLoaiKH))
            {
                loaiKhachHangDAO.Insert(lkhDTO.MaLoaiKH, lkhDTO.TenLoaiKH);
                MessageBox.Show("Thêm thông tin thành công!");
            }
            else MessageBox.Show("Mã loại khách hàng và tên loại khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadLoaiKhachHang();

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
           
                string maLoaiKH = txt_MaLoaiKH.Text;
                string tenLoaiKH = txt_TenLoaiKH.Text;

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
    }
}
