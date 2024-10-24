using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DTO;
using DACN.DAO;
using Sunny.UI.Win32;
namespace DACN.GUI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            HienThiKH();
        }

      
        public void HienThiKH()
        {
            List<KhachHangDTO> listKH = KhachHangDAO.Instance.GetKhachHang();
            dgv_KH.Columns["MAKH"].DataPropertyName = "MAKH";
            dgv_KH.Columns["TENKH"].DataPropertyName = "TENKH";
            dgv_KH.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_KH.Columns["SDT"].DataPropertyName = "SoDienThoai";
            dgv_KH.Columns["EMAIL"].DataPropertyName = "EMAIL";
            dgv_KH.Columns["NgayTao"].DataPropertyName = "NGAYTAO";
            dgv_KH.Columns["MaLoaiKH"].DataPropertyName = "MaLoaiKH";
            dgv_KH.DataSource = listKH;
        }
       
    }
}
