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
        public FormLoaiSanPham()
        {
            InitializeComponent();
            LoadLoaiSanPham();
        }
        private void LoadLoaiSanPham()
        {
            List<LoaiSanPhamDTO> listLSP = LoaiSanPhamDAO.Instance.GetLoaiSanPham();
            dvg_LoaiSP.Columns["MALOAISP"].DataPropertyName = "MaLoai";
            dvg_LoaiSP.Columns["TENLOAISP"].DataPropertyName = "TenLoai";
            dvg_LoaiSP.DataSource = listLSP;
        }

        private void dvg_LoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
