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
    public partial class FormChonSP_NCC : Form
    {
        private List<HangHoaDTO> selectedProducts = new List<HangHoaDTO>();
        private string mancc;
        public FormChonSP_NCC()
        {
            InitializeComponent();
            mancc = FormCT_SanPham_NCC.mancc;
            LoadSP();
            
        }
        private void LoadSP()
        {
            List<HangHoaDTO> listHH = SanPham_NhaCCDAO.Instance.LocSPNhaCCDaCungCap(mancc);
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
                Rectangle rect = dvg_ChonSP.GetCellDisplayRectangle(0, -1, true); 
                chkSelectAll.Location = new Point(rect.Location.X + 15, rect.Location.Y + 5); 
                dvg_ChonSP.Controls.Add(chkSelectAll);

            }
            dvg_ChonSP.AllowUserToAddRows = false;
            dvg_ChonSP.AutoSize = true;
            dvg_ChonSP.DataSource = listHH;
            dvg_ChonSP.Columns["MaKho"].Visible = false;
            dvg_ChonSP.Columns["MaLoaiSP"].Visible = false;
            dvg_ChonSP.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_ChonSP.Columns["TenSP"].HeaderText = "Tên Sản phẩm";
            dvg_ChonSP.Columns["DVT"].HeaderText = "Đơn vị tính";
            dvg_ChonSP.Columns["TenLoai"].HeaderText = "Tên loại";

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

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (this.Owner is FormCT_SanPham_NCC fSanPhamNCC)
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
                            fSanPhamNCC.AddProductToReceipt(maSP, tenSP, dvt, tenloaisp);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi không thể thêm sản phẩm: ");
                        }
                    }
                }
                this.Close();
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
                    catch
                    {
                        MessageBox.Show("Lỗi khi chọn sản phẩm");
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

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            FormQLHangHoa fQLHH = new FormQLHangHoa();
            fQLHH.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_SearchHH.Text;
            List<HangHoaDTO> listHH = HangHoaDAO.Instance.TimKiemHH(searchValue);
            dvg_ChonSP.DataSource = listHH;
        }
    }
}
