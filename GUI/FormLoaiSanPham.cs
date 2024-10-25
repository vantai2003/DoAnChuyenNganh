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
using System.Xml.Linq;

namespace DACN.GUI
{
    public partial class FormLoaiSanPham : Form
    {
        private bool IsInsert = false;
        private LoaiSanPhamDTO lspDTO = new LoaiSanPhamDTO();
        private LoaiSanPhamDAO lspDAO = new LoaiSanPhamDAO();
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
        public void khoaDK()
        {
            txt_MaLoai.Enabled = txt_TenLoai.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txt_MaLoai.Enabled = txt_TenLoai.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled  = false;
            tsbLuu.Enabled = true;
        }
        private List<LoaiSanPhamDTO> listLSP = new List<LoaiSanPhamDTO>();
        public void xoaTxt()
        {
            txt_MaLoai.Text = txt_MaLoai.Text = string.Empty;
        }

        static string GenerateNewCode(List<LoaiSanPhamDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "ML001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaLoai;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        private void dvg_LoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txt_MaLoai.Text = GenerateNewCode(listLSP);
        }
        private void tsbLuu_Click(object sender, EventArgs e)
        {

           
            lspDTO.MaLoai = txt_MaLoai.Text;
            lspDTO.TenLoai = txt_TenLoai.Text;

            try
            {
          
            if (IsInsert == true)
            {
                //Insert
                lspDAO.Insert(lspDTO);
                MessageBox.Show("Thêm thông tin thành công!");
            }
            else
            {
                //Update
                lspDAO.Update(lspDTO);
                MessageBox.Show("Sửa thông tin thành công!");
            
            }
            LoadLoaiSanPham();
            xoaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txt_MaLoai.Enabled = false;
            IsInsert = false;
            
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    lspDAO.Delete(txt_MaLoai.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            LoadLoaiSanPham();
        }

        private void dvg_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dvg_LoaiSP.Rows[e.RowIndex];
                    txt_MaLoai.Text = row.Cells["MALOAISP"].Value.ToString();
                    txt_TenLoai.Text = row.Cells["TENLOAISP"].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
