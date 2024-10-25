using DACN.DTO;
using DACN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public LoaiSanPhamDAO()
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
        public int Insert(LoaiSanPhamDTO obj)
        { 
            string query = "sp_Insert_LoaiSanPham @MaLoai , @TenLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {obj.MaLoai , obj.TenLoai });
            return result;
        }
        public int Update(LoaiSanPhamDTO obj)
        {
            string query = "sp_Update_LoaiSanPham @MaLoai , @TenLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaLoai, obj.TenLoai });
            return result;
        }
        public int Delete(string ID)
        {
            string query = "sp_Delete_LoaiSanPham @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }
    }
}
