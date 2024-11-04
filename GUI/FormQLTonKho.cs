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
    public partial class FormQLTonKho : Form
    {
        public FormQLTonKho()
        {
            InitializeComponent();
            LoadTonKho();
        }
        private void LoadTonKho()
        {
            List<Kho_SanPhamDTO> listkhosp = TonKhoDAO.Instance.GetTonKho();
            dvg_TonKho.DataSource = listkhosp;
        }
    }
}
