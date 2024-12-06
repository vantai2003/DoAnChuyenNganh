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
    public partial class FormXuaHD : Form
    {
        private string maHD;
        public FormXuaHD()
        {
            InitializeComponent();
            maHD = FormInHoaDon.maHD;
        }

        private void FormXuaHD_Load(object sender, EventArgs e)
        {
            rpV_HD.LocalReport.ReportPath = @"D:\DACN\Project\DACN\Dataset\ReportHoaDon.rdlc";

            string maHoaDon = maHD;

            DataTable dtHD = HoaDonDAO.Instance.GetTTInHoaDon(maHoaDon);
            decimal thanhToan = Convert.ToDecimal(dtHD.Rows[0]["ThanhToan"]);
            string tienChu = ChuyenTienThanhChu.ToWords((long)thanhToan);

            DataTable chiTietHoaDon = CTHoaDonDAO.Instance.GetTTInCTHoaDon(maHD);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSetCTHoaDon", chiTietHoaDon);
            ReportDataSource reportDataSource3 = new ReportDataSource("DataSetHoaDon", dtHD);
            rpV_HD.LocalReport.DataSources.Clear();
            rpV_HD.LocalReport.DataSources.Add(reportDataSource2);
            rpV_HD.LocalReport.DataSources.Add(reportDataSource3);
            //
            // Thiết lập tham số cho mã phiếu nhập
            ReportParameter[] reportParameters = new ReportParameter[2];
            reportParameters[0] = new ReportParameter("MaHoaDon", maHoaDon);
            reportParameters[1] = new ReportParameter("TienBangChu", tienChu);


            try
            {
                rpV_HD.LocalReport.SetParameters(reportParameters);
            }
            catch (Exception ex)
            {
                Console.Write("Lỗi khi thiết lập tham số: " + ex.Message);
                return;
            }

            // Làm mới báo cáo
            
            this.rpV_HD.RefreshReport();
        }
    }
}
