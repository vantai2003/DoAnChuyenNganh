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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
            LoadThongKe();
        }
        
        public void LoadThongKe()
        {
            dtTuNgay.Value = new DateTime(2024, 1, 1);
            dtDenNgay.Value = DateTime.Now;
            decimal tiennhap = CongNoDAO.Instance.GetTienNhapHang(dtTuNgay.Value, dtDenNgay.Value);
            decimal tienban = CongNoDAO.Instance.GetTienBanHang(dtTuNgay.Value, dtDenNgay.Value);
            decimal tienloi = tienban - tiennhap;
            txtTienNhapHang.Text = CongNoDAO.Instance.GetTienNhapHang(dtTuNgay.Value,dtDenNgay.Value).ToString(); 
            txtTienBanHang.Text = CongNoDAO.Instance.GetTienBanHang(dtTuNgay.Value, dtDenNgay.Value).ToString();
            txtTienLoi.Text =  tienloi.ToString();
        }
        public void ReLoadThongKe()
        {
            dtDenNgay.Value = DateTime.Now;
            decimal tiennhap = CongNoDAO.Instance.GetTienNhapHang(dtTuNgay.Value, dtDenNgay.Value);
            decimal tienban = CongNoDAO.Instance.GetTienBanHang(dtTuNgay.Value, dtDenNgay.Value);
            decimal tienloi = tienban - tiennhap;
            txtTienNhapHang.Text = CongNoDAO.Instance.GetTienNhapHang(dtTuNgay.Value, dtDenNgay.Value).ToString();
            txtTienBanHang.Text = CongNoDAO.Instance.GetTienBanHang(dtTuNgay.Value, dtDenNgay.Value).ToString();
            txtTienLoi.Text = tienloi.ToString();
        }

        private void xemThongKe_Click(object sender, EventArgs e)
        {
  
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        { 

        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            ReLoadThongKe();
        }
    }
 }

