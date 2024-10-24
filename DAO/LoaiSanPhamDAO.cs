using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return LoaiSanPhamDAO.instance; }
            private set { LoaiSanPhamDAO.instance = value; }
        }
        private LoaiSanPhamDAO()
        {

        }

        public List<LoaiSanPhamDTO> GetLoaiSanPham()
        {
            List<LoaiSanPhamDTO> list = new List<LoaiSanPhamDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_LoaiSanPham");

            foreach (DataRow row in data.Rows)
            {
                LoaiSanPhamDTO loaiSanPham = new LoaiSanPhamDTO(row);
                list.Add(loaiSanPham);
            }

            return list;
          
        }
    }
}
