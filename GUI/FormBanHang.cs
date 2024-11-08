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
        List<CTHoaDonDTO> listcthd = CTHoaDonDAO.Instance.GetCTHD();
        List<Kho_SanPhamDTO> listkhsp = TonKhoDAO.Instance.GetTonKho();
        Kho_SanPhamDTO khsp = new Kho_SanPhamDTO();
        HangHoaDAO hangHoaDAO = new HangHoaDAO();
        public FormBanHang()
        {
            InitializeComponent();
            LoadSanPham();
        
        }
        public void LoadSanPham()
        {
            dgv_Hang.DataSource = listkhsp;
            txtMaCTHD.Text = GenerateNewCode(listcthd);
        }
        public void LoadHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();

        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
          dgv_Hang.Refresh();
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
                    khsp.SoLuongTon = decimal.Parse(row.Cells["SoLuongTon"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private bool ktDKBanHang(string mahd, string masp, decimal dongia, string macthd, decimal soluong , decimal soluongkho)
        {
            
            
            if (dongia <= 0)
            {
                MessageBox.Show("Đơn giá không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (soluong >= soluongkho)
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

            if (hangHoaDAO.KiemTraTrungMaSP(masp))
            {
                MessageBox.Show("Mã Sản phẩm không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(macthd))
            {
                MessageBox.Show("Mã Chi tiết HD không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string numberPart = lastCode.Substring(4);

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
            
           
            try
            {
                CTHoaDonDTO.MaHD = txtMaHD.Text;
                CTHoaDonDTO.MaSP = txtHangHoa.Text;
                CTHoaDonDTO.SoLuong = decimal.Parse(txtSoLuong.Text);
                CTHoaDonDTO.DonGia = decimal.Parse(txtDonGia.Text);
                CTHoaDonDTO.MaCTHD = txtMaCTHD.Text;
                CTHoaDonDTO.DVT = txtDVT.Text;
             
                txtThanhTien.Text = tinhThanhTien(CTHoaDonDTO.DonGia, CTHoaDonDTO.SoLuong).ToString();
                CTHoaDonDTO.ThanhTien = decimal.Parse(txtThanhTien.Text);
                if (ktDKBanHang(CTHoaDonDTO.MaHD,CTHoaDonDTO.MaSP, CTHoaDonDTO.DonGia, CTHoaDonDTO.MaCTHD,CTHoaDonDTO.SoLuong, khsp.SoLuongTon))
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
 
            
            if (txt.Text == ".")
            {
                txt.Text = "0.";
                txt.SelectionStart = txt.Text.Length;
                return;
            }
            if (decimal.TryParse(txt.Text, out decimal value))
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
            
            if (txt.Text == ".")
            {
                txt.Text = "0.";
                txt.SelectionStart = txt.Text.Length;
                return;
            }
            if (decimal.TryParse(txt.Text, out decimal value))
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
        public void chonMaHD(string mahd)
        {
            txtMaHD.Text = mahd;
        }
        private void btnChonHD_Click(object sender, EventArgs e)
        {
            FormChonHoaDon formChonHD = new FormChonHoaDon();
            formChonHD.Owner = this;
            formChonHD.ShowDialog();
        }
    }
   
}
