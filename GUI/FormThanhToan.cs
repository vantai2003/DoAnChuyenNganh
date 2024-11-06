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
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            FormCTHoaDon formCTHoaDon = new FormCTHoaDon();
            formCTHoaDon.ShowDialog();
        }
        public void LoadHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvHoaDon.DataSource = listHoaDon;
        }

      private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void pcSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                    txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtTienCoc.Text = row.Cells["TienCoc"].Value.ToString();
                    txtThanhToan.Text = row.Cells["ThanhToan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {

        }

        private void tsbSua_Click(object sender, EventArgs e)
        {

        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {

        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
