using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DAO;
using DACN.DTO;

namespace DACN.GUI
{
    public partial class FormCTPhieuTraHangKH : Form
    {
        string mahd;
        public FormCTPhieuTraHangKH()
        {
            InitializeComponent();
            LoadCTPT();
        }
        public void LoadCTPT()
        {
            mahd = FormHoaDon.mahd;
            List<CTPhieuTraHangKHDTO> listHoaDon = PhieuTraHangKHDAO.Instance.GetCTPThieuTra_KH(mahd);
            dgvCTHD.DataSource = listHoaDon;
            
        }

    }
}
