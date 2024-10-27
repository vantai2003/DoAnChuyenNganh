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
using DACN.DAO;
using DACN.DTO;
namespace DACN.GUI
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
            LoadNCC();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadNCC()
        {
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();

            dgv_NCC.Columns["MaNCC"].DataPropertyName = "MaNCC";
            dgv_NCC.Columns["TenNCC"].DataPropertyName = "TenNCC";
            dgv_NCC.Columns["SDT"].DataPropertyName = "SDT";
            dgv_NCC.Columns["QuocGia"].DataPropertyName = "QuocGia";
            dgv_NCC.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgv_NCC.Columns["ThanhPho"].DataPropertyName = "ThanhPho";
            dgv_NCC.Columns["NgayTao"].DataPropertyName = "NgayTao";
            dgv_NCC.DataSource = listNCC;
        }
    }
}
