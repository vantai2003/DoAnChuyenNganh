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
            
            FormThanhToan formThanhToan = new FormThanhToan();
            formThanhToan.Show();
            this.Close();
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
                    CTHoaDonDTO.DVT = row.Cells["DVT"].Value.ToString();
                    
                    txtHangHoa.Text = row.Cells["MaSP"].Value.ToString();

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
        private bool ktDKBanHang(string mahd, string masp, float dongia)
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

            if (dongia <= 0)
            {
                MessageBox.Show("Đơn giá không được bé hơn không !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //kiêm tra xem số lượng thêm vào gio hàng có lớn hơn số lượng hàng hóa đang có ko
            return true;

        }
      private void btnThemVao_Click(object sender, EventArgs e)
        {
            CTHoaDonDTO.MaHD = txtMaHD.Text;
            CTHoaDonDTO.MaSP = txtHangHoa.Text;
            CTHoaDonDTO.DonGia = float.Parse(txtDonGia.Text);
        

            try
            {
                if (ktDKBanHang(CTHoaDonDTO.MaHD,CTHoaDonDTO.MaSP, CTHoaDonDTO.DonGia))
                {
                    MessageBox.Show("Thêm hàng thành công");
                    LoadSanPham();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("thêm hàng thất bại");
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
    }
   
}
