using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class TonKhoDAO
    {
        private static TonKhoDAO instance;
        public static TonKhoDAO Instance
        {
            get { if (instance == null) instance = new TonKhoDAO(); return TonKhoDAO.instance; }
            private set { TonKhoDAO.instance = value; }
        }
        public TonKhoDAO() { }
        public List<Kho_SanPhamDTO> GetTonKho()
        {
            List<Kho_SanPhamDTO> listSpKho = new List<Kho_SanPhamDTO>();

            string query = "SP_GetProductsInStock";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Kho_SanPhamDTO SanphamKho = new Kho_SanPhamDTO(row);
                listSpKho.Add(SanphamKho);
            }

            return listSpKho;
        }
    }
}
