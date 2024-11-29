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
using System.Web;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormCTHoaDon : Form
    {
        private FormHoaDon _formHoaDon;
        public FormCTHoaDon(string mahd)
        {
            InitializeComponent();
            LoadCTHDTheoMHD(mahd);

        }
        public string GetTongTien()
        {
            return txtTongTien.Text;
        }
        private void UpdateTongTien(DataGridView dgv)
        {
                decimal tongTien = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            txtTongTien.Text = tongTien.ToString("N2");

        }
      
        public void LoadCTHDTheoMHD(string mahd)
        {
            List<CTHoaDonDTO> listHoaDon = CTHoaDonDAO.Instance.GetCTHDTheoMHD(mahd);
            dgvCTHD.DataSource = listHoaDon;
            UpdateTongTien(dgvCTHD);
        }
        public void LoadCTPN(string mapn)
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dgvCTHD.DataSource = listctpn;
        }
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormHoaDon fhd)
            {
                foreach (DataGridViewRow row in dgvCTHD.Rows)
                {
                    string tongtien = txtTongTien.Text;
                    fhd.chonTongTien(tongtien);
                }
            }
            this.Close();
        }
    }
}
