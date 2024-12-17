using DACN.DAO;
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
    public partial class FormQLCongNo : Form
    {
        public FormQLCongNo()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            DataTable dt = CongNoDAO.Instance.HienThiCongNO();
            dgv_CongNo.DataSource = dt;
            dgv_CongNo.Columns["MaKH"].HeaderText = "Mã khách hàng";        
            dgv_CongNo.Columns["TenKH"].HeaderText = "Tên khách hàng";        
            dgv_CongNo.Columns["CongNo"].HeaderText = "Nợ";        
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text;
            DataTable dt = CongNoDAO.Instance.TimKiemCongNoKH(searchValue);
            dgv_CongNo.DataSource = dt;
        }
    }
}
