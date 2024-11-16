using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DTO;
using DACN.DAO;

namespace DACN.GUI
{
    public partial class FormPhieuTraHangKH : Form
    {

        private static string makho;
        private static string mahd;
        public FormPhieuTraHangKH()
        {
            InitializeComponent();
            mahd = FormHoaDon.mahd;
            LoadCTHD();


        }

        private void LoadCTHD()
        {
            List<CTHoaDonDTO> listHoaDon = CTHoaDonDAO.Instance.GetCTHDTheoMHD(mahd);
            if (!dvg_TaoPTH.Columns.Contains("SoLuongTra"))
            {
                DataGridViewTextBoxColumn colSoLuongTra = new DataGridViewTextBoxColumn();
                colSoLuongTra.Name = "SoLuongTra";
                colSoLuongTra.HeaderText = "Số lượng trả";
                colSoLuongTra.DataPropertyName = "SoLuongTra"; // Liên kết với thuộc tính trong DTO
                List<KhoDTO> listkho = KhoDAO.Instance.GetKho();
                cbbKho.DataSource = listkho;
                cbbKho.DisplayMember = "TenKho";
                cbbKho.ValueMember = "MaKho";
                cbbKho.SelectedIndex = 0;
                // Thêm cột vào DataGridView
                dvg_TaoPTH.Columns.Add(colSoLuongTra);

            }

            dvg_TaoPTH.DataSource = listHoaDon;
            RearrangeColumns();


        }
        private void RearrangeColumns()
        {
            // Tạo một danh sách mới cho các cột theo thứ tự mong muốn
            var newOrder = new List<string>();

            // Thêm các cột theo thứ tự bạn mong muốn
            newOrder.Add("MaCTHD");
            newOrder.Add("SoLuong");
            newOrder.Add("SoLuongTra");
            newOrder.Add("DVT");
            newOrder.Add("DonGia");
            newOrder.Add("MaSP");
            newOrder.Add("MaHD");
            newOrder.Add("ThanhTien");


            // Thiết lập lại thứ tự cột trong DataGridView
            foreach (var columnName in newOrder)
            {
                if (dvg_TaoPTH.Columns.Contains(columnName))
                {
                    dvg_TaoPTH.Columns[columnName].DisplayIndex = newOrder.IndexOf(columnName);
                }
            }
        }

        private void uiPanel4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvg_TaoPTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_taophieuKH_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên
            try
            {
                DataTable dt = NhanVienDAO.Instance.GetThongTinDN(FormDangNhap.nhanvien);
                string manv = string.Empty;
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    manv = row["MaNV"].ToString();
                }

                // Tạo mã phiếu trả
                string maPT = PhieuTraHangKHDAO.GenerateMaPT(); // Phương thức tạo mã phiếu trả cho KH
                DateTime ngayTao = DateTime.Now;
                string lyDo = rtb_lydo.Text;
                decimal tongTien = 0;

                // Tính tổng tiền từ DataGridView
                foreach (DataGridViewRow dvgRow in dvg_TaoPTH.Rows)
                {
                    if (dvgRow.Cells["MaSP"].Value != null)
                    {
                        decimal soLuongTra = Convert.ToDecimal(dvgRow.Cells["SoLuongTra"].Value);
                        decimal donGia = Convert.ToDecimal(dvgRow.Cells["DonGia"].Value);
                        decimal thanhTien = soLuongTra * donGia;
                        tongTien += thanhTien;
                    }
                }

                // Kiểm tra mã phiếu trả
                if (!string.IsNullOrEmpty(maPT))
                {
                    makho = cbbKho.SelectedValue.ToString();
                    // Thêm phiếu trả hàng cho KH
                    bool phieuTraAdded = PhieuTraHangKHDAO.Instance.ThemPhieuTraHang(maPT, tongTien, lyDo, ngayTao, manv, mahd, makho);

                    if (phieuTraAdded)
                    {
                        bool allDetailsAdded = true;
                        foreach (DataGridViewRow dgvRow in dvg_TaoPTH.Rows)
                        {
                            if (dgvRow.Cells["MaSP"].Value != null)
                            {
                                string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                                decimal soLuongTra = Convert.ToDecimal(dgvRow.Cells["SoLuongTra"].Value);
                                decimal donGia = Convert.ToDecimal(dgvRow.Cells["DonGia"].Value);
                                string C = PhieuTraHangKHDAO.GenerateMaCTPT();
                                CTPhieuTraHangKHDTO ctPhieuTraKH = new CTPhieuTraHangKHDTO
                                {
                                    MaCTPhieuTraHang = C,
                                    MaPhieuTraHang = maPT,
                                    MaSP = maSP,
                                    SoLuong = soLuongTra,
                                    DonGia = donGia,
                                };
                                
                                // Thêm chi tiết phiếu trả
                                bool detailAdded = PhieuTraHangKHDAO.Instance.ThemCTPhieuTraHang(ctPhieuTraKH);
                                if (!detailAdded)
                                {
                                    allDetailsAdded = false;
                                }
                                if (soLuongTra > 0)
                                {
                                    string makho = cbbKho.SelectedValue.ToString();   
                                    bool updated = PhieuTraHangKHDAO.Instance.CapNhatTonKho(maSP, makho, soLuongTra);
                                    if (!updated)
                                    {
                                        MessageBox.Show("Có lỗi khi cập nhật tồn kho cho sản phẩm " + maSP, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                            }
                        }

                        if (allDetailsAdded)
                        {
                           
                            MessageBox.Show("Tạo phiếu trả hàng cho khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm phiếu trả hàng cho khách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo mã phiếu trả hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.ToString());
            }
        }
            
 
        
        
    }
}
