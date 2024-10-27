using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DTO;
using DACN.DAO;
using Sunny.UI.Win32;
namespace DACN.GUI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            HienThiKH();
            loadCBBLoaiKH();
        }
        private KhachHangDTO khDTO = new KhachHangDTO();
        bool IsInsert = false;
        private KhachHangDAO khDAO = new KhachHangDAO();
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
        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMK.Text = GenerateNewCode(listKH);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMK.Enabled = false;
            IsInsert = false;
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
    }
}
