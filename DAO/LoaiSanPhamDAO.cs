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
        private DataProvider dataProvider = new DataProvider();

        public List<LoaiSanPhamDTO> GetLoaiSanPham()
        {
            List<LoaiSanPhamDTO> list = new List<LoaiSanPhamDTO>();

            string query = "SELECT * FROM LoaiSanPham";

            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string maLoai = row["MaLoai"].ToString();
                string tenLoai = row["TenLoai"].ToString();

                LoaiSanPhamDTO loaiSanPham = new LoaiSanPhamDTO(maLoai, tenLoai);
                list.Add(loaiSanPham);
            }

            return list;
        }
    }
}
