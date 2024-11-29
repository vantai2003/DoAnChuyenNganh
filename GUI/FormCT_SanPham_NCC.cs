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
    public partial class FormCT_SanPham_NCC : Form
    {
        public static string mancc;
        public static string masp;
        private int flag;
        public FormCT_SanPham_NCC()
        {
            InitializeComponent();
            LoadDS();
        }
        private void LoadDS()
        {
            List<SanPham_NhaCungCapDTO> listSPNCC = SanPham_NhaCCDAO.Instance.GetDSSanPhamNCC();
            dvg_SanPhamNCC.DataSource = listSPNCC;
            dvg_SanPhamNCC.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            dvg_SanPhamNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_SanPhamNCC.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_SanPhamNCC.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_SanPhamNCC.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_SanPhamNCC.Columns["DVT"].HeaderText = "DVT";
            dvg_SanPhamNCC.Columns["GiaNhap"].Visible = false;
            dvg_SanPhamNCC.Columns["NgayCapNhat"].Visible = false;
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
            cb_NhaCC.DataSource = listNCC;
            cb_NhaCC.DisplayMember = "TenNCC";
            cb_NhaCC.ValueMember = "MaNCC";
            //InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            if (dvg_SanPham.Columns.Count == 0)
            {
                dvg_SanPham.Columns.Add("MaSP", "Mã Sản Phẩm");
                dvg_SanPham.Columns.Add("TenSP", "Tên Sản Phẩm");
                dvg_SanPham.Columns.Add("DVT", "Đơn Vị Tính");
                dvg_SanPham.Columns.Add("TenLoai", "Tên Loại");
            }
        }
        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uiTabControl1.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadDS();
                    break;
                case 1:
                    InitializeDataGridView();
                    break;
                default:
                    break;
            }
        }

        private void btn_ChonSP_Click(object sender, EventArgs e)
        {
            mancc = cb_NhaCC.SelectedValue.ToString();
            FormChonSP_NCC fChonHH = new FormChonSP_NCC();
            fChonHH.Owner = this;
            fChonHH.ShowDialog();
        }

        private void btn_TaoNCC_Click(object sender, EventArgs e)
        {
            FormDanhMuc formDanhMuc = new FormDanhMuc();
            formDanhMuc.ShowDialog();
        }
        public bool AddProductToReceipt(string maSP, string tenSP, string dvt, string tenloaisp)
        {
            foreach (DataGridViewRow existingRow in dvg_SanPham.Rows)
            {
                if (existingRow.Cells[0].Value?.ToString() == maSP)
                {
                    return false;
                }
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dvg_SanPham);
            row.Cells[0].Value = maSP;
            row.Cells[1].Value = tenSP;
            row.Cells[2].Value = dvt;
            row.Cells[3].Value = tenloaisp;
            dvg_SanPham.Rows.Add(row);
            return true;
        }


        private void rdb_SanPham_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Enabled = btn_Loc.Enabled = true;
            cb_NCC.Enabled = false;
            cb_NCC.Text = null;
            flag = 0;
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                
                string maNCC = cb_NCC.SelectedValue.ToString();
                if(maNCC == "ALL")
                {
                    List<SanPham_NhaCungCapDTO> listSPNCC = SanPham_NhaCCDAO.Instance.GetDSSanPhamNCC();
                    dvg_SanPhamNCC.DataSource = listSPNCC;
                }
                else
                {
                    List<SanPham_NhaCungCapDTO> listSPNCC = SanPham_NhaCCDAO.Instance.LocTheoNCC(maNCC);
                    dvg_SanPhamNCC.DataSource = listSPNCC;
                }
                
            }
            else
            {
                string searchValue = txt_search.Text;
                List<SanPham_NhaCungCapDTO> listSPNCC = SanPham_NhaCCDAO.Instance.LocTheoSP(searchValue);
                dvg_SanPhamNCC.DataSource = listSPNCC;
            }
        }

        private void rdb_NCC_CheckedChanged(object sender, EventArgs e)
        {
            cb_NCC.Enabled = btn_Loc.Enabled = true;
            txt_search.Enabled = false;
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
            listNCC.Insert(0, new NhaCungCapDTO { MaNCC = "ALL", TenNCC = "Chọn tất cả" });
            cb_NCC.DataSource = listNCC;
            cb_NCC.DisplayMember = "TenNCC";
            cb_NCC.ValueMember = "MaNCC";
            flag = 1;
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            if (dvg_SanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm trước khi tạo phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maNCC = cb_NhaCC.SelectedValue.ToString();
                foreach (DataGridViewRow dgvRow in dvg_SanPham.Rows)
                {
                    if (dgvRow.Cells["MaSP"].Value != null)
                    {
                        string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                        int detailAdded = SanPham_NhaCCDAO.Instance.ThemSanPhamNCC(maNCC, maSP);
                    }
                }
                MessageBox.Show("Thêm thành công");
            }
            dvg_SanPham.Rows.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvg_SanPham.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = dvg_SanPham.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            DataGridViewRow row = dvg_SanPham.SelectedRows[i];
                            dvg_SanPham.Rows.Remove(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { MessageBox.Show("Xóa thành công"); }
            
        }

        private void dvg_SanPhamNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_SanPhamNCC.Rows[e.RowIndex];
                masp = Convert.ToString(row.Cells["MaSP"].Value);
                mancc = Convert.ToString(row.Cells["MaNCC"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void btn_XoaHH_Click(object sender, EventArgs e)
        {
            if(masp != null)
            {
                bool kq = SanPham_NhaCCDAO.Instance.XoaNhaCungUng(mancc, masp);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công");
                    mancc = null;
                    masp = null;
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
            }
        }
    }
}
