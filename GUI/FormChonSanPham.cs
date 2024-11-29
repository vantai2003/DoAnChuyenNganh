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
            DataGridViewCheckBoxColumn chkColumn = dvg_ChonSP.Columns["Chon"] as DataGridViewCheckBoxColumn;
            
            
            if (chkColumn == null)
            {
                chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Chọn";
                chkColumn.Name = "Chon";
                dvg_ChonSP.Columns.Add(chkColumn);
                CheckBox chkSelectAll = new CheckBox();
                chkSelectAll.Text = "";
                chkSelectAll.Size = new Size(15, 15);
                chkSelectAll.Location = new Point(10, 10);
                chkSelectAll.CheckedChanged += new EventHandler(chkSelectAll_CheckedChanged);

                // Thêm checkbox vào header của DataGridView
                Rectangle rect = dvg_ChonSP.GetCellDisplayRectangle(0, -1, true); // Lấy vị trí của header
                chkSelectAll.Location = new Point(rect.Location.X + 15, rect.Location.Y + 5); // Điều chỉnh vị trí
                dvg_ChonSP.Controls.Add(chkSelectAll);

            }
            dvg_ChonSP.AllowUserToAddRows = false;
            dvg_ChonSP.AutoSize = true;
            dvg_ChonSP.DataSource = dtSanPham;
            dvg_ChonSP.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_ChonSP.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_ChonSP.Columns["DVT"].HeaderText = "Đơn vị tính";
            dvg_ChonSP.Columns["TenLoai"].HeaderText = "Loại";

            dvg_ChonSP.EndEdit(); // tránh focus dòng đầu tiên
            foreach (DataGridViewColumn column in dvg_ChonSP.Columns)
            {
                column.ReadOnly = true;
                dvg_ChonSP.Columns["Chon"].ReadOnly = false;
            }


        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool checkStatus = ((CheckBox)sender).Checked;

            foreach (DataGridViewRow row in dvg_ChonSP.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["Chon"];
                chkCell.Value = checkStatus; // Set giá trị
            }
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormNhapHang fNhapHang)
            {
                foreach (DataGridViewRow row in dvg_ChonSP.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Chon"].Value))
                    {
                        try
                        {
                            string maSP = row.Cells["MaSP"].Value.ToString();
                            string tenSP = row.Cells["TenSP"].Value.ToString();
                            string dvt = row.Cells["DVT"].Value.ToString();
                            string tenloaisp = row.Cells["TenLoai"].Value.ToString();
                            fNhapHang.AddProductToReceipt(maSP, tenSP, dvt, tenloaisp);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi không thể thêm sản phẩm: ");
                        }
                    }
                }
                this.Close();
                fNhapHang.AnCombobox();
            }
        }

       

        private void dvg_ChonSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_ChonSP.Columns["Chon"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_ChonSP.Rows[e.RowIndex];
                bool isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (isChecked)
                {
                    try
                    {
                        string maSP = row.Cells["MaSP"].Value.ToString();
                        string tenSP = row.Cells["TenSP"].Value.ToString();
                        string dvt = row.Cells["DVT"].Value.ToString();
                        string tenloaisp = row.Cells["TenLoai"].Value.ToString();
                        selectedProducts.Add(new HangHoaDTO
                        {
                            MaSP = maSP,
                            TenSP = tenSP,
                            DVT = dvt,
                            TenLoai = tenloaisp
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    HangHoaDTO productToRemove = selectedProducts.FirstOrDefault(p => p.MaSP == maSP);
                    if (productToRemove != null)
                    {
                        selectedProducts.Remove(productToRemove);
                    }
                }
            }
        }
    }
}
