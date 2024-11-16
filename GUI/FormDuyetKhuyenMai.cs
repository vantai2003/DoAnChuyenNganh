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
    public partial class FormDuyetKhuyenMai : Form
    {
        public string makm;
        public FormDuyetKhuyenMai()
        {
            InitializeComponent();
            LoadListDSKMCanPheDuyet();
            
        }
        private void LoadListDSKMCanPheDuyet()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKMCanPheDuyet();
            dvg_DSKM.DataSource = listKM;
            dvg_DSKM.Columns["MaKM"].HeaderText = "Mã khuyến mãi";
            dvg_DSKM.Columns["TenKM"].HeaderText = "Tên khuyến mãi";
            dvg_DSKM.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dvg_DSKM.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            dvg_DSKM.Columns["MoTa"].HeaderText = "Mô tả";
            dvg_DSKM.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSKM.Columns["GiaTriKM"].HeaderText = "Giá trị khuyến mãi";
            dvg_DSKM.Columns["LoaiDK"].HeaderText = "Loại điều kiện";
            dvg_DSKM.Columns["DieuKienTongTien"].HeaderText = "Điều kiện của tổng tiền";

        }

        private void dvg_DSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSKM.Rows[e.RowIndex];
                makm = Convert.ToString(row.Cells["MaKM"].Value);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi");
            }
        }

        private void btn_PheDuyet_Click(object sender, EventArgs e)
        {
            if (makm != null)
            {
                KhuyenMaiDAO.Instance.PheDuyetKM(makm);
                MessageBox.Show("Đã phê duyệt");
                LoadListDSKMCanPheDuyet();
                makm = null;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn duyệt");
            }
        }

        private void btn_TuChoi_Click(object sender, EventArgs e)
        {
            if(makm != null)
            {
                KhuyenMaiDAO.Instance.TuChoiKM(makm);
                MessageBox.Show("Đã từ chối");
                LoadListDSKMCanPheDuyet();
                makm = null;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn từ chối");
            }
        }
        private void LoadDSKhuyenMai()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKM();
            dvg_DSKhuyenMai.DataSource = listKM;
            dvg_DSKhuyenMai.Columns["MaKM"].HeaderText = "Mã khuyến mãi";
            dvg_DSKhuyenMai.Columns["TenKM"].HeaderText = "Tên khuyến mãi";
            dvg_DSKhuyenMai.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dvg_DSKhuyenMai.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            dvg_DSKhuyenMai.Columns["MoTa"].HeaderText = "Mô tả";
            dvg_DSKhuyenMai.Columns["TrangThai"].HeaderText = "Trạng thái";
            dvg_DSKhuyenMai.Columns["GiaTriKM"].HeaderText = "Giá trị khuyến mãi";
            dvg_DSKhuyenMai.Columns["LoaiDK"].HeaderText = "Loại điều kiện";
            dvg_DSKhuyenMai.Columns["DieuKienTongTien"].HeaderText = "Điều kiện của tổng tiền";
        }

        private void tab_DuyetKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_DuyetKM.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadListDSKMCanPheDuyet();
                    break;
                case 1:

                    LoadDSKhuyenMai(); 
                    break;
                default:
                    break;
            }
        }
    }
}
