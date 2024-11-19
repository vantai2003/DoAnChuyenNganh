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
        public FormSuaPhieuNhap()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            tongtien = FormNhapHang.tongtien;
            makho = FormNhapHang.makho;
            mancc = FormNhapHang.mancc;
            Load();
        }
        private void Load()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_SuaPN.DataSource = listctpn;
            dvg_SuaPN.Columns["TongTien"].Visible = false;
            txttongtien.Text = tongtien.ToString();
            cbtrangthai.SelectedIndex = 0;
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
                int rowIndex = dvg_SuaPN.SelectedCells[0].RowIndex; 
                DataGridViewRow row = dvg_SuaPN.Rows[rowIndex];
                row.Cells["Dongia"].Value = txt_DonGia.Text;
                row.Cells["Soluong"].Value = txt_SoLuong.Text;
                row.Cells["Thanhtien"].Value = txt_ThanhTien.Text;
                TinhTongThanhTien();
                MessageBox.Show("Cập nhật thành công!");
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
                if (row.Cells["Thanhtien"].Value != null)
                {
                    decimal thanhtien = Convert.ToDecimal(row.Cells["Thanhtien"].Value);
                    tongTien += thanhtien;
                }
            }
            txttongtien.Text = tongTien.ToString(); 
        }
    }
}
