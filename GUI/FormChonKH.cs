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
    public partial class FormChonKH : Form
    {
        public FormChonKH()
        {
            InitializeComponent();
            LoadKH();
        }
        public void LoadKH()
        {
            List<KhachHangDTO> listHoaDon = KhachHangDAO.Instance.GetKhachHang();
            dgvKhachHang.DataSource = listHoaDon;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormHoaDon fHD)
            {
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    string makh = txtChonMaKH.Text;
                    fHD.chonMaKh(makh);
                }
            }
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                    txtChonMaKH.Text = row.Cells["MaKH"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    
}
