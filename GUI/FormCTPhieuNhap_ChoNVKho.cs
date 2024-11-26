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
    public partial class FormCTPhieuNhap_ChoNVKho : Form
    {
        private string mapn;
        public FormCTPhieuNhap_ChoNVKho()
        {
            InitializeComponent();
            mapn = FormNhapHang.mapn;
            LoadCTPN();
        }
        private void LoadCTPN()
        {
            List<CTPhieuNHDTO> listctpn = PhieuNhapHangDAO.Instance.GetCTPhieuNH(mapn);
            dvg_CTPN.DataSource = listctpn;
        }
    }
}
