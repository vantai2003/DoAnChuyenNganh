using DACN.DAO;
using DACN.DTO;
using Sunny.UI;
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
    public partial class FormBanHang : Form
    {
        CTHoaDonDTO CTHoaDonDTO = new CTHoaDonDTO();
        
        public FormBanHang()
        {
            InitializeComponent();
            LoadSanPham();
            LoadHoaDon();
        
        }
        public void LoadSanPham()
        {
            List<HangHoaDTO> listSanPham = HangHoaDAO.Instance.GetSanPham();
            dgv_Hang.DataSource = listSanPham;
        }
        public void LoadHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvHD.DataSource = listHoaDon;

        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {

            LoadHoaDon();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_Hang.Rows[e.RowIndex];
                    txtHangHoa.Text = row.Cells["MaSP"].Value.ToString();
                    txtDVT.Text = row.Cells["DVT"].Value.ToString();
                    txtMaCTHD.Text = GenerateNewCode(CTHoaDonDAO.Instance.GetCTHD());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHD.Rows[e.RowIndex];
                    txtMaHD.Text = row.Cells["MaHD"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private bool ktDKBanHang(string mahd, string masp, decimal dongia, string macthd, decimal soluong)
        {
            if (string.IsNullOrWhiteSpace(mahd))
            {
                MessageBox.Show("Mã Hóa đơn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(masp))
            {
                MessageBox.Show("Mã Sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(macthd))
            {
                MessageBox.Show("Mã Chi tiết HD không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dongia <=0)
            {
                MessageBox.Show("Đơn giá không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //kiêm tra xem số lượng thêm vào gio hàng có lớn hơn số lượng hàng hóa đang có ko
            return true;

        }
        static string GenerateNewCode(List<CTHoaDonDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "CTHD001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaCTHD;

            string prefix = lastCode.Substring(0, 4);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        public decimal tinhThanhTien(decimal a, decimal b)
        {
            return a * b;
        }
        private void btnThemVao_Click(object sender, EventArgs e)
        {
            
            CTHoaDonDTO.MaHD = txtMaHD.Text;
            CTHoaDonDTO.MaSP = txtHangHoa.Text;
            CTHoaDonDTO.SoLuong = decimal.Parse(txtSoLuong.ToString());
            CTHoaDonDTO.DonGia = decimal.Parse(txtDonGia.Text);
            CTHoaDonDTO.MaCTHD = txtMaCTHD.Text;
            CTHoaDonDTO.DVT = txtDVT.Text;
            txtThanhTien.Text = tinhThanhTien(CTHoaDonDTO.DonGia,CTHoaDonDTO.SoLuong).ToString();
            CTHoaDonDTO.ThanhTien = decimal.Parse(txtThanhTien.Text);
            try
            {         
                if (ktDKBanHang(CTHoaDonDTO.MaHD,CTHoaDonDTO.MaSP, CTHoaDonDTO.DonGia, CTHoaDonDTO.MaCTHD,CTHoaDonDTO.SoLuong))
                {
                    CTHoaDonDAO.Instance.Insert(CTHoaDonDTO);
                    MessageBox.Show("Thêm hàng thành công");
                    LoadSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void nbsoluong_ValueChanged(object sender, EventArgs e)
        {
   
           
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Focus();
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Giá trị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = "0";
             
                return;
            }

            if (txt.Text == ".")
            {
                txt.Text = "0.";
                txt.SelectionStart = txt.Text.Length;
                return;
            }
            if (double.TryParse(txt.Text, out double value))
            {
                if (value < 0)
                {
                    txt.Text = "0";
                }
            }
            else
            {
                txt.Text = "0";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Focus();
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Giá trị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = "0";

                return;
            }

            if (txt.Text == ".")
            {
                txt.Text = "0.";
                txt.SelectionStart = txt.Text.Length;
                return;
            }
            if (double.TryParse(txt.Text, out double value))
            {
                if (value < 0)
                {
                    txt.Text = "0";
                }
            }
            else
            {
                txt.Text = "0";
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void pcSearch_Click(object sender, EventArgs e)
        {
        }

        private void tbTimKiemHang_TextChanged(object sender, EventArgs e)
        {
            List<HangHoaDTO> listHH = HangHoaDAO.Instance.TimKiemHH(tbTimKiemHang.Text);
            dgv_Hang.DataSource = listHH;
        }
    }
   
}
