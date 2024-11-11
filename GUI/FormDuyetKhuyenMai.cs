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
            LoadDSKhuyenMai();
        }
        private void LoadListDSKMCanPheDuyet()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKMCanPheDuyet();
            dvg_DSKM.DataSource = listKM;
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
        }
    }
}
