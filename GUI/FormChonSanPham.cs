using DACN.DAO;
using DACN.DTO;
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

namespace DACN.GUI
{
    public partial class FormChonSanPham : Form
    {
        public List<CTPhieuNHDTO> ChiTietSanPhamDaChon { get; private set; }
        private List<HangHoaDTO> selectedProducts = new List<HangHoaDTO>();
        private string mancc; 
        public FormChonSanPham()
        {
            InitializeComponent();
            mancc = FormNhapHang.mancc;
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            DataTable dtSanPham = HangHoaDAO.Instance.GetSanPhamByNhaCungCap(mancc);
            dtSanPham.Columns.Add("SoLuong", typeof(decimal)); 
            dtSanPham.Columns.Add("DonGia", typeof(decimal));
            //dtSanPham.Columns.Add("ThanhTien", typeof(decimal));
            dvg_ChonSP.DataSource = dtSanPham;
            textBox1.Text = mancc;
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            //if (dvg_ChonSP.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để nhập.");
            //    return; // Không có hàng nào được chọn
            //}

            if (this.Owner is FormNhapHang fNhapHang)
            {
                foreach (DataGridViewRow row in dvg_ChonSP.Rows)
                {
                    if (row.Cells["SoLuong"].Value != null && row.Cells["DonGia"].Value != null)
                    {
                        decimal soLuong, donGia;

                        // Kiểm tra tính hợp lệ của SoLuong và DonGia
                        if (decimal.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong) &&
                            decimal.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia) &&
                            soLuong > 0)
                        {
                            // Lấy thông tin sản phẩm
                            string maSP = row.Cells["MaSP"].Value.ToString();
                            string tenSP = row.Cells["TenSP"].Value.ToString();
                            string dvt = row.Cells["DVT"].Value.ToString();
                            string tenLoai = row.Cells["TenLoai"].Value.ToString();
                            // Gọi phương thức trong FormNhapHang để thêm sản phẩm vào phiếu nhập
                            fNhapHang.AddProductToReceipt(maSP, dvt, tenSP, tenLoai ,soLuong, donGia);
                        }
                    }
                }
                this.Close(); // Đóng FormChonSanPham sau khi thêm sản phẩm
            }
            else
            {
                MessageBox.Show("Không thể truy cập đến FormNhapHang.");
            }
        
        }

        private void dvg_ChonSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvg_ChonSP.Rows[e.RowIndex];
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string tenSP = selectedRow.Cells["TenSP"].Value.ToString();
                string dvt = selectedRow.Cells["DVT"].Value.ToString();

                // Kiểm tra nếu số lượng và đơn giá có sẵn
                if (selectedRow.Cells["SoLuong"].Value != null)
                {
                    selectedRow.Cells["SoLuong"].Value = 1;
                }
                if (selectedRow.Cells["DonGia"].Value != null)
                {
                    selectedRow.Cells["DonGia"].Value = 0;
                }
                selectedProducts.Add(new HangHoaDTO
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DVT = dvt,
                });
            }
        }
    }
}
