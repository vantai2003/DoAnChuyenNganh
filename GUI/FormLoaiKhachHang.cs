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
        private bool IsInsert = false;
        private LoaiKhachHangDAO loaiKhachHangDAO = new LoaiKhachHangDAO();
        private LoaiKhachHangDTO lkhDTO = new LoaiKhachHangDTO();
        public FormLoaiKhachHang()
        {
            InitializeComponent();
            LoadLoaiKhachHang();
            khoaDK();
        }
        private void LoadLoaiKhachHang()
        {
            listLKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            dgv_LoaiKhachHang.Columns["LoaiKH"].DataPropertyName = "MaLoaiKH";
            dgv_LoaiKhachHang.Columns["TenLoaiKH"].DataPropertyName = "TenLoaiKH";
            dgv_LoaiKhachHang.DataSource = listLKH;
        }
        public void khoaDK()
        {
            txt_MaLoaiKH.Enabled = txt_TenLoaiKH.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txt_MaLoaiKH.Enabled = txt_TenLoaiKH.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        
        public void xoaTxt()
        {
            txt_MaLoaiKH.Text = txt_TenLoaiKH.Text = string.Empty;
        }
        static string GenerateNewCode(List<LoaiKhachHangDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "LK001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaLoaiKH;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D3}";

            return newCode;
        }
        private void dgv_LoaiKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private List<LoaiKhachHangDTO> listLKH = new List<LoaiKhachHangDTO>();
        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txt_MaLoaiKH.Text = GenerateNewCode(listLKH);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txt_MaLoaiKH.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    loaiKhachHangDAO.Delete(txt_MaLoaiKH.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            LoadLoaiKhachHang();
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            

            try
            {
            
                if (txt_MaLoaiKH.Text == null || txt_TenLoaiKH.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                lkhDTO.MaLoaiKH = txt_MaLoaiKH.Text;
                lkhDTO.TenLoaiKH = txt_TenLoaiKH.Text;
                if (IsInsert == true)
                {
                    //Insert
                    loaiKhachHangDAO.Insert(lkhDTO.MaLoaiKH,lkhDTO.TenLoaiKH);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    //Update
                    loaiKhachHangDAO.Update(lkhDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                LoadLoaiKhachHang();
                xoaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trùng tên loại khách hàng!");
            }
        }

        private void dgv_LoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_LoaiKhachHang.Rows[e.RowIndex];
                    txt_MaLoaiKH.Text = row.Cells["LoaiKH"].Value.ToString();
                    txt_TenLoaiKH.Text = row.Cells["TENLOAIKH"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
