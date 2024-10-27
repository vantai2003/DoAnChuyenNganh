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
            khoaDK();
            LoadNCC();
        }
        bool IsInsert = false;
        private NhaCungCapDTO nccDTO = new NhaCungCapDTO();
        private NhaCungCapDAO nccDAO = new NhaCungCapDAO();
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadNCC()
        {
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();

            dgv_NCC.Columns["MaNCC"].DataPropertyName = "MaNCC";
            dgv_NCC.Columns["TenNCC"].DataPropertyName = "TenNCC";
            dgv_NCC.Columns["SDT"].DataPropertyName = "SDT";
            dgv_NCC.Columns["Email"].DataPropertyName = "Email";
            dgv_NCC.Columns["QuocGia"].DataPropertyName = "QuocGia";
            dgv_NCC.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgv_NCC.Columns["ThanhPho"].DataPropertyName = "ThanhPho";
            dgv_NCC.Columns["NgayTao"].DataPropertyName = "NgayTao";
            dgv_NCC.DataSource = listNCC;
        }
        public void khoaDK()
        {
            txtMaNCC.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtTenNCC.Enabled = txtThanhPho.Enabled = txt_QuocGia.Enabled = dtpNgayTao.Enabled = txtEmail.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtMaNCC.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtTenNCC.Enabled = txtThanhPho.Enabled = txt_QuocGia.Enabled = dtpNgayTao.Enabled = txtEmail.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        private List<NhaCungCapDTO> listncc = new List<NhaCungCapDTO>();
        static string GenerateNewCode(List<NhaCungCapDTO> list)
        {

            if (list.Count == 0)
            {
                return "NCC001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MaNCC;

            string prefix = lastCode.Substring(0, 3);
            string numberPart = lastCode.Substring(3);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        public void xoaTxt()
        {
            txtMaNCC.Text = txtSDT.Text = txtDiaChi.Text = txtThanhPho.Text = txt_QuocGia.Text = txtEmail.Text  = string.Empty;
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaNCC.Text = GenerateNewCode(listncc);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaNCC.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nccDAO.Delete(txtMaNCC.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            LoadNCC();
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            nccDTO.MaNCC = txtMaNCC.Text;
            nccDTO.TenNCC = txtTenNCC.Text;
            nccDTO.Email = txtEmail.Text;
            nccDTO.ThanhPho = txtThanhPho.Text;
            nccDTO.DiaChi = txtDiaChi.Text;
            nccDTO.QuocGia = txtSDT.Text;
            nccDTO.NgayTao = DateTime.Now;
            nccDTO.SDT = txtSDT.Text;
            try
            {

                if (IsInsert == true)
                {
                    //Insert
                    nccDAO.Insert(nccDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    //Update
                    nccDAO.Update(nccDTO);
                    MessageBox.Show("Sửa thông tin thành công!");

                }
                LoadNCC();
                xoaTxt();
                khoaDK();            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_NCC.Rows[e.RowIndex];
                    txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                    txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtThanhPho.Text = row.Cells["ThanhPho"].Value.ToString();
                    txt_QuocGia.Text = row.Cells["QuocGia"].Value.ToString();
                    dtpNgayTao.Value = DateTime.Parse(row.Cells["NgayTao"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
