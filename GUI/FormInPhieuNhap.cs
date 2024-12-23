﻿using DACN.DAO;
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
            mapn = FormInHoaDon.maPN;
        }

        private void FormInPhieuNhap_Load(object sender, EventArgs e)
        {
            rp_PhieuNhap.LocalReport.ReportPath = @"D:\DACN\Project\DACN\Dataset\ReportPhieuNhap.rdlc";

            string maPhieuNhap = mapn;

            DataTable dtNCC = PhieuNhapHangDAO.Instance.GetNhaCungCapInfo(maPhieuNhap);
            decimal tongTien = Convert.ToDecimal(dtNCC.Rows[0]["TongTien"]);
            string tienChu = ChuyenTienThanhChu.ToWords((long)tongTien);
            //LẤY DỮ LEIEU JTUWF pn
            List<CTPhieuNHDTO> chiTietPhieuNhap = PhieuNhapHangDAO.Instance.GetCTPhieuNH(maPhieuNhap);
            DataTable dtChiTiet = ConvertToDataTable(chiTietPhieuNhap);
            // Thiết lập nguồn dữ liệu cho báo cáo
            ReportDataSource reportDataSource = new ReportDataSource("DataSetPhieuNhap", dtChiTiet);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSetCTPhieuNhap", dtChiTiet);
            ReportDataSource reportDataSource3 = new ReportDataSource("DataSetNhaCungCap", dtNCC);
            rp_PhieuNhap.LocalReport.DataSources.Clear();
            rp_PhieuNhap.LocalReport.DataSources.Add(reportDataSource);
            rp_PhieuNhap.LocalReport.DataSources.Add(reportDataSource2);
            rp_PhieuNhap.LocalReport.DataSources.Add(reportDataSource3);
            //
            // Thiết lập tham số cho mã phiếu nhập
            ReportParameter[] reportParameters = new ReportParameter[2];
            reportParameters[0] = new ReportParameter("MaPhieuNH", maPhieuNhap);
            reportParameters[1] = new ReportParameter("TienBangChu", tienChu);
            try
            {
                rp_PhieuNhap.LocalReport.SetParameters(reportParameters);
            }
            catch (Exception ex)
            {
                Console.Write("Lỗi khi thiết lập tham số: " + ex.Message);
                return;
            }
            // Làm mới báo cáo
            this.rp_PhieuNhap.RefreshReport();
        }
        private DataTable ConvertPhieuNhap(List<PhieuNhapHangDTO> listPN)
        {
            DataTable dtPN = new DataTable();
            dtPN.Columns.Add("MaPhieuNH");
            dtPN.Columns.Add("NgayDatHang");
            foreach(var item in listPN)
            {
                dtPN.Rows.Add(item.MaPhieuNH, item.NgayDatHang);
            }
            return dtPN;
        }
        private DataTable ConvertToDataTable(List<CTPhieuNHDTO> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenSP");
            dt.Columns.Add("DVT");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            // Thêm các dòng dữ liệu vào DataTable
            foreach (var item in list)
            {
                dt.Rows.Add(item.TenSP, item.DVT, item.SoLuong, item.DonGia);
            }
            return dt;
        }
    }
}
