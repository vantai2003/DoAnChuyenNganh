using DACN.DTO;
using System;   
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }
        public KhachHangDAO()
        {

        }
        public List<KhachHangDTO> GetKhachHang()
        {
            List<KhachHangDTO> listNguoiDung = new List<KhachHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_KhachHang");
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(row);
                listNguoiDung.Add(khachhang);
            }
            return listNguoiDung;
        }
        public int Insert(KhachHangDTO obj)
        {
            string query = "sp_Insert_KhachHang @MaKH , @TenKH , @SoDienThoai , @Email , @DiaChi , @NgayTao , @MaLoaiKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaKH, obj.TenKH,obj.SoDienThoai,obj.Email,obj.Diachi,obj.NgayTao,obj.MaLoaiKH });
            return result;
        }
        public int Update(KhachHangDTO obj)
        {
            string query = "sp_Update_KhachHang @MaKH , @TenKH , @SoDienThoai , @Email , @DiaChi , @NgayTao , @MaLoaiKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaKH, obj.TenKH, obj.SoDienThoai, obj.Email, obj.Diachi, obj.NgayTao, obj.MaLoaiKH });
            return result;
        }
        public int Delete(string ID)
        {
            string query = "sp_Delete_KhachHang @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }
        public bool KiemTraTrungSDT(string sdt)
        {
            string query = "SP_KiemTraTrungSDTKH @SDT";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { sdt });
            return result.Rows.Count > 0;
        }

        public bool KiemTraTrungEmail(string email)
        {
            string query = "SP_KiemTraTrungEmailKH @Email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            return result.Rows.Count > 0;
        }
        public static string GenerateMaKH()
        {
            string query = "SP_TaoMaKH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
    }
}
