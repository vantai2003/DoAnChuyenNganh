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
    public partial class FormLoaiKhachHang : Form
    {
        private LoaiKhachHangDAO loaiKhachHangDAO = new LoaiKhachHangDAO();
        public FormLoaiKhachHang()
        {
            InitializeComponent();
            LoadLoaiKhachHang();
        }
        private void LoadLoaiKhachHang()
        {
            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();

            dgv_LoaiKhachHang.Columns["LoaiKH"].DataPropertyName = "MaLoaiKH";
            dgv_LoaiKhachHang.Columns["TenLoaiKH"].DataPropertyName = "TenLoaiKH";
            dgv_LoaiKhachHang.DataSource = listLoaiKH;
        }

        private void dgv_LoaiKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
