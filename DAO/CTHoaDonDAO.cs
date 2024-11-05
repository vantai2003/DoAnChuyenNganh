using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class CTHoaDonDAO
    {
        private static CTHoaDonDAO instance;
        public static CTHoaDonDAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonDAO(); return CTHoaDonDAO.instance; }
            private set { CTHoaDonDAO.instance = value; }
        }
        public CTHoaDonDAO() { }
        public List<CTHoaDonDTO> GetCTHD()
        {
            List<CTHoaDonDTO> listSP = new List<CTHoaDonDTO>();

            string query = "SP_GetListSP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                CTHoaDonDTO SanPham = new CTHoaDonDTO(row);
                listSP.Add(SanPham);
            }

            return listSP;
        }

    }
}
