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
            private set {LoaiSanPhamDAO.instance = value; }
        }
        public LoaiSanPhamDAO() { }
        public List<LoaiSanPhamDTO> GetLoaiSanPham()
        {
            List<LoaiSanPhamDTO> listLoaiSP = new List<LoaiSanPhamDTO>();

            string query = "SP_GetListNLoaiSP";


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                LoaiSanPhamDTO loaiSanPham = new LoaiSanPhamDTO(row);
                listLoaiSP.Add(loaiSanPham);
            }

            return listLoaiSP;
        }
        public int ThemLoaiSanPham(string maLoai, string tenLoai)
        {
            string query = "SP_ThemLoaiSP @MaLoai , @TenLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai, tenLoai });
            return result;
        }
        public bool KiemTraTrungMaLoai(string maLoai)
        {
            string query = "SP_KiemTraMaLoai @MaLoai";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maLoai });
            return result.Rows.Count > 0;
        }
        public int XoaLoaiSP(string maLoai)
        {
            string query = "SP_XoaLoaiSP @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai });
            return result;
        }
        public int SuaLoaiSP(string maLoai, string tenLoai)
        {
            string query = "SP_SuaLoaiSP @MaLoai , @TenLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai, tenLoai });
            return result;
        }
    }
}
