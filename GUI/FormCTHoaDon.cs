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
    public partial class FormCTHoaDon : Form
    {
        public FormCTHoaDon()
        {
            InitializeComponent();
            LoadCTHD();
        }
        public void LoadCTHD()
        {
            List<CTHoaDonDTO> listHoaDon = CTHoaDonDAO.Instance.GetCTHD();
            dgvCTHD.DataSource = listHoaDon;
        }
    }
}
