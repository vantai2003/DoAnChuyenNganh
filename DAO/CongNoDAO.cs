using DACN.DTO;
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

        public DataTable (DateTime tungay, DateTime denngay)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            string query = "sp_SelectAll_HD_ByTime @ngayTu , @ngayDen ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tungay1, denngay1 });
            return data;
        }

    }
}
