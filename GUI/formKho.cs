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
    public partial class formKho : Form
    {
        private bool IsInsert = false;
        private KhoDTO KhoDTO = new KhoDTO();
        private KhoDAO KhoDAO = new KhoDAO();
        public formKho()
        {
            InitializeComponent();
            LoadKho();
            khoaDK();
        }
        private void LoadKho()
        {
            List<KhoDTO> list= KhoDAO.Instance.GetKho();
            dgvKho.Columns["MaKho"].DataPropertyName = "MaKHO";
            dgvKho.Columns["TENKho"].DataPropertyName = "TenKHo";
            dgvKho.Columns["DiaChi"].DataPropertyName = "DiaCHI";
            dgvKho.DataSource = list;
        }
        public void khoaDK()
        {
            txtMaKho.Enabled = txtTenKho.Enabled = txtDiaChi.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtMaKho.Enabled = txtTenKho.Enabled = txtDiaChi.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        private List<KhoDTO> listkho= new List<KhoDTO>();
        public void xoaTxt()
        {
            txtMaKho.Text = txtTenKho.Text = txtDiaChi.Text = string.Empty;
        }
        static string GenerateNewCode(List<KhoDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "MK001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaKho;

            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaKho.Text = GenerateNewCode(listkho);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaKho.Enabled = false;
            IsInsert = false;

        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {

        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            KhoDTO.MaKho = txtMaKho.Text;
            KhoDTO.TenKho = txtTenKho.Text;
            KhoDTO.DiaChi = txtDiaChi.Text;
            try
            {

                if (IsInsert == true)
                {
                    //Insert
                    KhoDAO.Insert(KhoDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    //Update
                    KhoDAO.Update(KhoDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                LoadKho();
                xoaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                    txtMaKho.Text = row.Cells["MaKho"].Value.ToString();
                    txtTenKho.Text = row.Cells["TenKho"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaCHi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
