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
                    CTHoaDonDTO.DVT = row.Cells["DVT"].Value.ToString();
                    CTHoaDonDTO.MaSP = row.Cells["MaSP"].Value.ToString();
                    

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

        private void btnThemVao_Click(object sender, EventArgs e)
        {

        }
    }
   
}
