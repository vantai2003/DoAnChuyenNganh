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
    public partial class FormChonHoaDon : Form
    {

        public FormChonHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();

        }
        public void LoadHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonDAO.Instance.GetHoaDon();
            dgvHoaDon.DataSource = listHoaDon;
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    txtChonHD.Text = row.Cells["MaHD"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormBanHang fbanhang)
            {
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    string mahd = txtChonHD.Text;
                    fbanhang.chonMaHD(mahd);
                }
            }
            this.Close();
        }
    }
}
