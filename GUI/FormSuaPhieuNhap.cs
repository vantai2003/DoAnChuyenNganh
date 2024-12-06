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
    public partial class FormSuaPhieuNhap : Form
    {
        private string mapn;
        private decimal tongtien;
        private string makho;
        private string mancc;
        private string manv;
        private List<string> deletedRows = new List<string>();
        //sử dụng BindinSource để cập nhật lại dvg khi xóa 1 dòng
        private BindingSource bindingSource = new BindingSource();
        public FormSuaPhieuNhap()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            tongtien = FormNhapHang.tongtien;
            makho = FormNhapHang.makho;
            mancc = FormNhapHang.mancc;
            Load();
            manv = FormDangNhap.nhanvien;
            this.Width = 1200;
            this.Height = 900;
        }
        private void Load()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            bindingSource.DataSource = listctpn; 
            dvg_SuaPN.DataSource = bindingSource;
            dvg_SuaPN.Columns["MaCTPhieuNH"].HeaderText = "Mã chi tiết phiếu nhập";
            dvg_SuaPN.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_SuaPN.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_SuaPN.Columns["TenLoai"].HeaderText = "Tên loại";
            dvg_SuaPN.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvg_SuaPN.Columns["MaPhieuNH"].HeaderText = "Mã phiếu nhập";
            dvg_SuaPN.Columns["DVT"].HeaderText = "DVT";
            dvg_SuaPN.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_SuaPN.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_SuaPN.Columns["SoLuong"].HeaderText = "Số lượng";
            dvg_SuaPN.Columns["DonGia"].HeaderText = "Đơn giá";
            dvg_SuaPN.Columns["DonGia"].ReadOnly = true;
            dvg_SuaPN.Columns["NgayNhapHang"].HeaderText = "Ngày nhập hàng";
            dvg_SuaPN.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dvg_SuaPN.Columns["TongTien"].Visible = false;
            txttongtien.Text = tongtien.ToString();
            List<KhoDTO> listKho = KhoDAO.Instance.GetKho();
            cbkho.DataSource = listKho;
            cbkho.DisplayMember = "TenKho";
            cbkho.ValueMember = "MaKho";
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetNhaCungCap();
            cbncc.DataSource = listNCC;
            cbncc.DisplayMember = "TenNCC";
            cbncc.ValueMember = "MaNCC";
            foreach (KhoDTO kho in cbkho.Items)
            {
                if (kho.TenKho == makho)
                {
                    cbkho.SelectedItem = kho;
                    break;
                }
            }
            foreach (NhaCungCapDTO ncc in cbncc.Items)
            {
                if (ncc.TenNCC == mancc)
                {
                    cbncc.SelectedItem = ncc;
                    break;
                }
            }
            //gắn cờ
            if (!dvg_SuaPN.Columns.Contains("IsModified"))
            {
                DataGridViewTextBoxColumn isModifiedColumn = new DataGridViewTextBoxColumn
                {
                    Name = "IsModified",
                    Visible = false //ẩn
                };
                dvg_SuaPN.Columns.Add(isModifiedColumn);
            }

            dvg_SuaPN.Columns["TongTien"].Visible = false;
            txttongtien.Text = tongtien.ToString();
        }

        private void dvg_SuaPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_SuaPN.Rows[e.RowIndex];
                string maCTPN = Convert.ToString(row.Cells["MaCTPhieuNH"].Value);
                decimal soLuong= Convert.ToDecimal(row.Cells["SoLuong"].Value);
                decimal donGia= Convert.ToDecimal(row.Cells["DonGia"].Value);
                txt_MaCTPN.Text = maCTPN;
                txt_SoLuong.Text = soLuong.ToString();
                txt_DonGia.Text = donGia.ToString();
                decimal thanhTien = soLuong * donGia;
                txt_ThanhTien.Text = thanhTien.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        private void TinhThanhTien()
        {
            decimal dongia = 0, soluong = 0;
            if (decimal.TryParse(txt_DonGia.Text, out dongia))
            {
                if (decimal.TryParse(txt_SoLuong.Text, out soluong))
                {
                    txt_ThanhTien.Text = (dongia * soluong).ToString();
                }
                else
                {
                    txt_ThanhTien.Text = "0";
                }
            }
            else
            {
                txt_ThanhTien.Text = "0";
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (dvg_SuaPN.SelectedCells.Count > 0) 
            {
                if(KiemTraDuLieuDAO.KiemTraDuLieuSo(txt_DonGia.Text) !=true || KiemTraDuLieuDAO.KiemTraDuLieuSo(txt_SoLuong.Text)!=true) 
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!");
                }
                else
                {
                    int rowIndex = dvg_SuaPN.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dvg_SuaPN.Rows[rowIndex];
                    row.Cells["Dongia"].Value = txt_DonGia.Text;
                    row.Cells["Soluong"].Value = txt_SoLuong.Text;
                    row.Cells["Thanhtien"].Value = txt_ThanhTien.Text;
                    //đặt cờ bằng true
                    row.Cells["IsModified"].Value = true;
                    TinhTongThanhTien();
                    MessageBox.Show("Cập nhật thành công!");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để cập nhật!");
            }
        }
        private void TinhTongThanhTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dvg_SuaPN.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    decimal thanhtien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    tongTien += thanhtien;
                }
            }
            txttongtien.Text = tongTien.ToString(); 
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dvg_SuaPN.SelectedCells.Count > 0)
            {
                int rowIndex = dvg_SuaPN.SelectedCells[0].RowIndex;
                DataGridViewRow row = dvg_SuaPN.Rows[rowIndex];
                string maCTPN = row.Cells["MaCTPhieuNH"].Value.ToString();
                //add vào list
                deletedRows.Add(maCTPN);
                //xóa khỏi dvg
                bindingSource.RemoveAt(rowIndex);
                TinhTongThanhTien();
                MessageBox.Show("Đã xóa dòng!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dvg_SuaPN.Rows)
                {
                    if (row.Cells["IsModified"].Value != null && (bool)row.Cells["IsModified"].Value == true)
                    {
                        string maCTPN = row.Cells["MaCTPhieuNH"].Value.ToString();
                        decimal soLuong = Convert.ToDecimal(row.Cells["Soluong"].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells["Dongia"].Value);
                        
                        bool success = PhieuNhapHangDAO.Instance.UpdateCTPhieuNhap(maCTPN, soLuong, donGia);
                        
                        // Optional: Reset the IsModified flag if the update was successful
                        if (success)
                        {
                            row.Cells["IsModified"].Value = false;
                        }

                    }
                }
                foreach (string maCTPN in deletedRows)
                {
                    PhieuNhapHangDAO.Instance.XoaCTPN(maCTPN);
                }
                deletedRows.Clear();
                decimal tongTien = Convert.ToDecimal(txttongtien.Text);
                
                bool capNhatPN = PhieuNhapHangDAO.Instance.UpdatePhieuNhap(mapn, tongTien, manv);
                if (capNhatPN)
                {
                    MessageBox.Show("sửa phiếu nhập thành công");
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
                throw;
            }
        }
    }
}
