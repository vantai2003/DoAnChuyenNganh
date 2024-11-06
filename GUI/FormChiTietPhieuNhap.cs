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
    public partial class FormChiTietPhieuNhap : Form
    {
        private string mapn;
        public FormChiTietPhieuNhap()
        {
            InitializeComponent();
            mapn = FormDuyetPhieuNhap.maPN;
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn); 
            dvg_CTPN.DataSource = listctpn;
        }

        private void btn_PheDuyet_Click(object sender, EventArgs e)
        {
             PhieuNhapHangDAO.Instance.PheDuyetPN(mapn);
             MessageBox.Show("Đã phê duyệt!");
             this.Close();
        }

        private void btn_TuChoi_Click(object sender, EventArgs e)
        {
            PhieuNhapHangDAO.Instance.TuChoiPN(mapn);
            MessageBox.Show("Đã từ chối!");
            this.Close();
        }
    }
}
