using DACN.DAO;
using DACN.DTO;
using Sunny.UI;
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
            DataGridViewCheckBoxColumn chkColumn = uiDataGridView1.Columns["Chon"] as DataGridViewCheckBoxColumn;
            if (chkColumn == null)
            {
                chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Chọn";
                chkColumn.Name = "Chon";
                uiDataGridView1.Columns.Add(chkColumn);
            }

            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.DataSource = dtsanpham;
            uiDataGridView1.AutoSize = true;

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
                uiDataGridView1.Columns["Chon"].ReadOnly = false;
            }

        }
        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormBanHang formBanHang)
            {
                foreach (var product in selectedProducts)
                {
                    formBanHang.AddProductToReceipt(product.MaSP, product.TenSP, product.DVT, product.TenLoaiSP, product.SoLuongTon, product.TenKho);
                }
                this.Close();
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == uiDataGridView1.Columns["Chon"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                bool isChecked = row.Cells["Chon"].Selected; 

                if (isChecked)
                {
                    try
                    { 
                        if (row.Cells["MaSP"].Value == null || row.Cells["TenSP"].Value == null || row.Cells["DVT"].Value == null || row.Cells["TenKho"].Value == null || row.Cells["SoLuongTon"].Value == null)
                        {
                            MessageBox.Show("Missing data in row!");
                            return;
                        }

                        string maSP = row.Cells["MaSP"].Value.ToString();
                        string tenSP = row.Cells["TenSP"].Value.ToString();
                        string dvt = row.Cells["DVT"].Value.ToString();
                        string tenKho = row.Cells["TenKho"].Value.ToString();
                        decimal soLuongTon = decimal.Parse(row.Cells["SoLuongTon"].Value.ToString());
                        string tenloaisp = row.Cells["TenLoai"].Value.ToString();
                        selectedProducts.Add(new Kho_SanPhamDTO
                        {
                            MaSP = maSP,
                            TenSP = tenSP,
                            DVT = dvt,
                            TenKho = tenKho,
                            SoLuongTon = soLuongTon,
                            TenLoaiSP = tenloaisp

                        });
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    selectedProducts.RemoveAll(p => p.MaSP == row.Cells["MaSP"].Value.ToString());
                }
            }
        }

        private void btn_lammoiHang_Click(object sender, EventArgs e)
        {
            LoadSanPhamBan();
        }

        private void tbTimKiemHang_TextChanged(object sender, EventArgs e)
        {
            DataTable dtsanpham = CTHoaDonDAO.Instance.SearchSP(tbTimKiemHang.Text);
            DataGridViewCheckBoxColumn chkColumn = uiDataGridView1.Columns["Chon"] as DataGridViewCheckBoxColumn;
            if (chkColumn == null)
            {
                chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Chọn";
                chkColumn.Name = "Chon";
                uiDataGridView1.Columns.Add(chkColumn);
            }

            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.DataSource = dtsanpham;
            uiDataGridView1.AutoSize = true;

            SetupDataGridView();

        }
    }
    }
