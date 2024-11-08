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
    public partial class FormTaoPhieuTraHangNCC : Form
    {

        private static string mapn;
        private static string manv;
        private static string makho;
        public FormTaoPhieuTraHangNCC()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_TaoPTH.DataSource = listctpn;
            makho = FormNhapHang.makho;
        }

        private void btn_TaoPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = NhanVienDAO.Instance.GetThongTinDN(FormDangNhap.nhanvien);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                manv = row["MaNV"].ToString();
            }
            string maPT = PhieuTraHangNCCDAO.GenerateMaPT();
            DateTime ngayTao = DateTime.Now;
            textBox1.Text = mapn;
            string lyDo = rtb_LyDo.Text;
            decimal tongTien = 0;
            foreach(DataGridViewRow dvgRow in dvg_TaoPTH.Rows)
            {
                if (dvgRow.Cells["MaSP"].Value != null)
                {
                    decimal soLuong = Convert.ToDecimal(dvgRow.Cells["SoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(dvgRow.Cells["DonGia"].Value);
                    decimal thanhTien = soLuong * donGia;
                    tongTien += thanhTien;
                }
            }

            if (!string.IsNullOrEmpty(maPT))
            {
                bool phieuNhapAdded = PhieuTraHangNCCDAO.Instance.ThemPhieuTraHang(maPT, tongTien, lyDo, ngayTao, manv, mapn);

                if (phieuNhapAdded)
                {
                    bool allDetailsAdded = true;
                    foreach (DataGridViewRow dgvRow in dvg_TaoPTH.Rows)
                    {
                        if (dgvRow.Cells["MaSP"].Value != null)
                        {
                            string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                            decimal soLuongTra = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                            decimal donGia = Convert.ToDecimal(dgvRow.Cells["DonGia"].Value);
                            CTPhieuTraHangNCCDTO ctPhieuTraNCC = new CTPhieuTraHangNCCDTO
                            {
                                MaCTPhieuTraHang = PhieuTraHangNCCDAO.GenerateMaCTPN(),
                                MaPhieuTraHang = maPT,
                                MaSP = maSP,
                                SoLuong = soLuongTra,
                                DonGia = donGia,
                            };
                            bool detailAdded = PhieuTraHangNCCDAO.Instance.ThemCTPhieuTraHang(ctPhieuTraNCC);
                            if (!detailAdded)
                            {
                                allDetailsAdded = false;
                            }
                            decimal soLuongNhapGoc = TonKhoDAO.Instance.CapNhatTonKho(maSP, mapn);
                            decimal soLuongConLai = soLuongNhapGoc - soLuongTra;
                            if(soLuongConLai > 0)
                            {
                                bool updated = PhieuNhapHangDAO.Instance.CapNhatTonKho(maSP, makho, soLuongConLai);
                                if (!updated)
                                {
                                    MessageBox.Show("Có lỗi khi cập nhật tồn kho cho sản phẩm " + maSP, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }

                    if (allDetailsAdded)
                    {
                        PhieuNhapHangDAO.Instance.CapNhatTrangThaiTraHang(mapn);
                        MessageBox.Show("Tạo phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo mã phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
