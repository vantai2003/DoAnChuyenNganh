using DACN.DAO;
using DACN.DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class FormInPhieuNhap : Form
    {
        private string mapn;
        public FormInPhieuNhap()
        {
            InitializeComponent();
            mapn = FormDuyetPhieuNhap.maPN;
        }

        private void FormInPhieuNhap_Load(object sender, EventArgs e)
        {
            string maPhieuNhap = mapn;

            
            List<CTPhieuNHDTO> chiTietPhieuNhap = PhieuNhapHangDAO.Instance.GetCTPhieuNH(maPhieuNhap);
            DataTable dtChiTiet = ConvertToDataTable(chiTietPhieuNhap);
            //DataTable dtPhieuNhap = Conver

            // Thiết lập nguồn dữ liệu cho báo cáo
            ReportDataSource reportDataSource = new ReportDataSource("DataSetPhieuNhap", dtChiTiet);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSetCTPhieuNhap", dtChiTiet);
            rp_PhieuNhap.LocalReport.DataSources.Clear();
            rp_PhieuNhap.LocalReport.DataSources.Add(reportDataSource);
            rp_PhieuNhap.LocalReport.DataSources.Add(reportDataSource2);

            // Thiết lập tham số cho mã phiếu nhập
            ReportParameter[] reportParameters = new ReportParameter[1];
            reportParameters[0] = new ReportParameter("MaPhieuNH", maPhieuNhap);

            try
            {
                rp_PhieuNhap.LocalReport.SetParameters(reportParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thiết lập tham số: " + ex.Message);
                return;
            }

            // Đặt đường dẫn tới file báo cáo .rdlc
            rp_PhieuNhap.LocalReport.ReportPath = @"D:\DACN\Project\DACN\Dataset\ReportPhieuNhap.rdlc";

            // Hiển thị mã phiếu nhập trên một TextBox (nếu cần)
            //this.txtMaPhieuNhap.Text = maPhieuNhap;

            // Làm mới báo cáo
            this.rp_PhieuNhap.RefreshReport();

        }
        //private DataTable ConvertPhieuNhap(List<PhieuNhapHangDTO> listPN)
        //{
        //    DataTable dtPN = new DataTable();
        //    dtPN.Columns.Add("MaPhieuNH");
        //}
        private DataTable ConvertToDataTable(List<CTPhieuNHDTO> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenSP");
            dt.Columns.Add("DVT");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            //dt.Columns.Add("ThanhTien");
            

            // Thêm các dòng dữ liệu vào DataTable
            foreach (var item in list)
            {
                dt.Rows.Add(item.TenSP, item.DVT, item.SoLuong, item.DonGia);
            }

            return dt;
        }
    }
}
