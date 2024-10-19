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
    public partial class FormLoaiSanPham : Form
    {
        private LoaiSanPhamDAO loaiSanPhamDAO = new LoaiSanPhamDAO();
        public FormLoaiSanPham()
        {
            InitializeComponent();
            LoadLoaiSanPham();
        }
        private void LoadLoaiSanPham()
        {
            List<LoaiSanPhamDTO> listLoaiSanPham = loaiSanPhamDAO.GetLoaiSanPham();
            dvg_LoaiSP.DataSource = listLoaiSanPham;
            dvg_LoaiSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dvg_LoaiSP.Columns["TenLoai"].HeaderText = "Tên Loại";
        }
    }
}
