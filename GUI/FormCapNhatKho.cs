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
    public partial class FormCapNhatKho : Form
    {
        private static string mapn;
        private static string makho;
        public FormCapNhatKho()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            makho = FormNhapHang.makho;
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_CapNhatKho.DataSource = listctpn;
        }
        private void btn_CapNhatKho_Click(object sender, EventArgs e)
        {
            bool allUpdated = true;
            if (string.IsNullOrEmpty(makho))
            {
                MessageBox.Show("Không xác định được mã kho. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow dgvRow in dvg_CapNhatKho.Rows)
            {
                if (dgvRow.Cells["MaSP"].Value != null)
                {
                    string maSP = dgvRow.Cells["MaSP"].Value.ToString();
                    
                    decimal soLuong = Convert.ToDecimal(dgvRow.Cells["SoLuong"].Value);
                    bool tonKhoUpdated = PhieuNhapHangDAO.Instance.CapNhatTonKho(maSP, makho, soLuong);
                    if (!tonKhoUpdated)
                    {
                        allUpdated = false;
                    }
                }
            }

            if (allUpdated)
            {
                TonKhoDAO.Instance.CapNhatTrangThai(mapn);
                LoadCTPN();
                MessageBox.Show("Cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mapn = "";
            makho = "";
        }
    }
}
