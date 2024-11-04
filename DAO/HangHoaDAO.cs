using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;
        public static HangHoaDAO Instance
        {
            get { if (instance == null) instance = new HangHoaDAO(); return HangHoaDAO.instance; }
            private set { HangHoaDAO.instance = value; }
        }
        public HangHoaDAO() { }
        public List<HangHoaDTO> GetSanPham()
        {
            List<HangHoaDTO> listSP = new List<HangHoaDTO>();

            string query = "SP_GetListSP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                HangHoaDTO SanPham = new HangHoaDTO(row);
                listSP.Add(SanPham);
            }

            return listSP;
        }
        public int ThemSanPham(string masp, string tensp, string dvt, string maloai)
        {
            string query = "SP_ThemSP @MaSP , @TenSP , @DVT , @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, tensp, dvt, maloai });
            return result;
        }
        public static string GenerateMaNV()
        {
            string query = "SP_TaoMaSP";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public bool KiemTraTrungMaSP(string masp)
        {
            string query = "SP_KiemTraMaSP @MaSP";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { masp });
            return result.Rows.Count > 0;
        }
        public int XoaSP(string masp)
        {
            string query = "SP_XoaSP @MaSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp });
            return result;
        }
        public int SuaSP(string masp, string tensp, string dvt, string maloai)
        {
            string query = "SP_SuaSP @MaSP , @TenSP , @DVT , @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, tensp, dvt, maloai });
            return result;
        }
        public List<HangHoaDTO> TimKiemHH(string searchValue)
        {
            List<HangHoaDTO> listHH = new List<HangHoaDTO>();
            string query = "SP_TimKiemSP @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
            foreach (DataRow row in data.Rows)
            {
                HangHoaDTO hanghoa = new HangHoaDTO(row);
                listHH.Add(hanghoa);
            }
            return listHH;
        }
        public DataTable GetSanPhamByNhaCungCap(string mancc)
        {
            string query = "SP_GetSanPhamByIdNCC @MaNCC";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mancc });

        }
    }
}
