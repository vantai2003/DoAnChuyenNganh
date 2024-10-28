using DACN.DTO;
using DACN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class LoaiKhachHangDAO
    {
        private static LoaiKhachHangDAO instance;
        public static LoaiKhachHangDAO Instance
        {
            get { if (instance == null) instance = new LoaiKhachHangDAO(); return LoaiKhachHangDAO.instance; }
            private set { LoaiKhachHangDAO.instance = value; }
        }
        public LoaiKhachHangDAO()
        {

        }
        public List<LoaiKhachHangDTO> GetLoaiKhachHang()
        {
            List<LoaiKhachHangDTO> list = new List<LoaiKhachHangDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_LoaiKH");

            foreach (DataRow row in data.Rows)
            {
                LoaiKhachHangDTO loaikh = new LoaiKhachHangDTO(row);
                list.Add(loaikh);
            }

            return list;
        }
        public int Insert(string maloai, string tenloai)
        {
            string query = "sp_Insert_LoaiKhachHang @MaLKH , @TenLKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai, tenloai });
            return result;
        }
        public int Update(LoaiKhachHangDTO obj)
        {
            string query = "sp_Update_LoaiKhachHang @MaLKH , @TenLKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaLoaiKH, obj.TenLoaiKH });
            return result;
        }
        public int Delete(string ID)
        {
            string query = "sp_Delete_LoaiKhachHang @MaLKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }
    }
}
