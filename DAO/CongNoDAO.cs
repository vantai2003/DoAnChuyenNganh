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
    }
}
