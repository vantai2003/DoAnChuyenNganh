using DACN.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class CongNoDAO
    {
        private static CongNoDAO instance;
        public static CongNoDAO Instance
        {
            get { if (instance == null) instance = new CongNoDAO(); return CongNoDAO.instance; }
            private set { CongNoDAO.instance = value; }
        }
        public CongNoDAO() { }

     
        public decimal GetTienNhapHang(DateTime tungay, DateTime denngay)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = denngay.ToString("yyyy-MM-dd");
            decimal tongtien = 0;
            string Query = "SP_GetTienNhapHang @NgayTu , @NgayDen"; 
            DataTable data = DataProvider.Instance.ExecuteQuery(Query, new object[] { tungay,denngay });

            if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
            {
                tongtien = Convert.ToDecimal(data.Rows[0][0]);
            }

            return tongtien;
        }
        public decimal GetTienBanHang(DateTime tungay, DateTime denngay)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = denngay.ToString("yyyy-MM-dd");
            decimal tongtien = 0;
            decimal thanhtoan =0;
            string Query = "SP_GetTienBanHang @NgayTu , @NgayDen";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query, new object[] { tungay, denngay });
            if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
            {
                tongtien = Convert.ToDecimal(data.Rows[0][0]);
            
            }
            if (data.Rows[0][1] != DBNull.Value)
            {
                thanhtoan = Convert.ToDecimal(data.Rows[0][1]);
            }
            return tongtien - thanhtoan;
        }
        public decimal TongThuTheoNgay(DateTime ngay)
        {
            string query = "sp_ReportRevenueByDay @ReportDate";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ngay });
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public decimal TongChiTheoNgay(DateTime ngay)
        {
            string query = "SP_ThongKeChi @ReportDate";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ngay });
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public decimal TongThuTheoTuanHienTai()
        {
            string query = "SP_ReportRevenueByCurrentWeek";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] {});
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public decimal TongChiTheoTuanHienTai()
        {
            string query = "SP_ThongKeChiTheoTuan";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { });
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public decimal TongThuTheoKhoangTG(DateTime ngaybd, DateTime ngaykt)
        {
            string query = "SP_ThongKeDoanhThuTheoKhoangThoiGian @StartDate , @EndDate";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ngaybd, ngaykt});
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public decimal TongChiTheoKhoangTG(DateTime ngaybd, DateTime ngaykt)
        {
            string query = "Sp_ThongKeChiTheoKhoangThoiGIan @StartDate , @EndDate";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ngaybd, ngaykt });
            if (result == DBNull.Value || result == null)
            {
                return 0;
            }
            return Convert.ToDecimal(result);
        }
        public DataTable ThongKeTongThuChiTheoNam(int nam)
        {
            string query = "sp_ThongKeTongThuChiTheoNam @Nam";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nam });
        }
        public DataTable ThongKeTongThuChiTatCa()
        {
            string query = "sp_ThongKeTongThuChiTatCa";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemCongNoKH(string makh)
        {
            string query = "SP_QLCongNo @MaKH";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {makh});
        }
        public DataTable HienThiCongNO()
        {
            string query = "SP_SelectCongNo";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
