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
    public partial class FormSanPhamBan : Form
    {
        private List<Kho_SanPhamDTO> selectedProducts = new List<Kho_SanPhamDTO>();
        public FormSanPhamBan()
        {
            InitializeComponent();
            LoadSanPhamBan();
        }
        private void LoadSanPhamBan()
        {
            
            DataTable dtsanpham = CTHoaDonDAO.Instance.GetSanPhamBan();
            dtsanpham.Columns.Add("SoLuong", typeof(decimal));
            dtsanpham.Columns.Add("DonGia", typeof(decimal));
            uiDataGridView1.DataSource = dtsanpham;
            SetupDataGridView();

        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
     
        }
        private void SetupDataGridView()
        {
            // Đặt các cột khác thành ReadOnly
            foreach (DataGridViewColumn column in uiDataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
        }
        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.Rows[e.RowIndex];
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string tenSP = selectedRow.Cells["TenSP"].Value.ToString();
                string dvt = selectedRow.Cells["DVT"].Value.ToString();
                string tenKho = selectedRow.Cells["TenKho"].Value.ToString();
                //decimal soLuongTon = decimal.Parse(selectedRow.Cells["soLuongTon"].Value.ToString());
                if (selectedRow.Cells["SoLuong"].Value != null)
                {
                    selectedRow.Cells["SoLuong"].Value = 1;
                }
                if (selectedRow.Cells["DonGia"].Value != null)
                {
                    selectedRow.Cells["DonGia"].Value = 0;
                }

                decimal soluong = int.Parse(selectedRow.Cells["SoLuong"].Value.ToString());
              
                    selectedProducts.Add(new Kho_SanPhamDTO
                    {
                        MaSP = maSP,
                        TenSP = tenSP,
                        DVT = dvt,
                        TenKho = tenKho,
                    });
                uiDataGridView1.Refresh();
                
            }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormBanHang formBanHang)
            {
                foreach (DataGridViewRow row in uiDataGridView1.Rows)
                {
                    if (row.Cells["SoLuong"].Value != null && row.Cells["DonGia"].Value != null)
                    {
                        decimal soLuong, donGia =0;
                        decimal soLuongTon = decimal.Parse(row.Cells["SoLuongTon"].Value.ToString());
                        if (decimal.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong) &&
                            decimal.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia) &&
                            soLuong > 0)
                        if (soLuong > soLuongTon)
                            {
                                MessageBox.Show($"Số lượng nhập không được vượt quá số lượng tồn ({soLuongTon})!",
                                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue; 
                            }

                        {
                            string maSP = row.Cells["MaSP"].Value.ToString();
                            string tenSP = row.Cells["TenSP"].Value.ToString();
                            string dvt = row.Cells["DVT"].Value.ToString();
                            string tenLoai = row.Cells["TenLoai"].Value.ToString();
                            string tenkho = row.Cells["TenKho"].Value.ToString();
                            formBanHang.AddProductToReceipt(maSP, dvt, tenSP, tenLoai, soLuong, donGia, soLuongTon);
                        }
                    }
                    
                }

                this.Close();
            }
        }
    }
}
