using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACN.DTO;
using DACN.DAO;
namespace DACN.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return NhaCungCapDAO.instance; }
            private set { NhaCungCapDAO.instance = value; }
        }
        private NhaCungCapDAO()
        {

        }
        public List<NhaCungCapDTO> GetNhaCungCap()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_NCC");

            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(row);
                list.Add(ncc);
            }

            return list;
        }
    }
}
