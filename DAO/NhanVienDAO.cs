using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO()
        {

        }
        public List<NhanVienDTO> LoadListNV()
        {
            List<NhanVienDTO> listNhanVien = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListNhanVien");
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO nhanvien = new NhanVienDTO(row);
                listNhanVien.Add(nhanvien);
            }
            return listNhanVien;
        }
        public DataTable GetThongTinDN(string tendn)
        {
            string query = "SP_GetThongTinNguoiDung @TenDN";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tendn });

        }
        public int ThemNhanVien(string manv, string tennv, string chucvu, string sdt, string email, DateTime ngaytuyendung, decimal luong)
        {
            string query = "SP_ThemNhanVien @MaNV , @TenNV , @ChucVu , @SDT , @Email , @NgayTuyenDung , @Luong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, chucvu, sdt, email, ngaytuyendung, luong });
            return result;
        }
        public int XoaNV(string manv)
        {
            string query = "SP_XoaNhanVien @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv });
            return result;
        }
        public int SuaNV(string manv, string tennv, string chucvu, string sdt, string email, DateTime ngaytuyendung, decimal luong)
        {
            string query = "SP_NhanVien @MaNV , @TenNV , @ChucVu , @SDT , @Email , @NgayTuyenDung , @Luong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, chucvu, sdt, email, ngaytuyendung, luong });
            return result;
        }
        public static string GenerateMaNV()
        {
            string query = "SP_TaoMaNV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public bool KiemTraTrungSDT(string sdt)
        {
            string query = "SP_KiemTraTrungSDT @SDT";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { sdt });
            return result.Rows.Count > 0;
        }
        public bool KiemTraTrungEmail(string email)
        {
            string query = "SP_KiemTraTrungEmail @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            return result.Rows.Count > 0;
        }
        public List<NhanVienDTO> TimKiemNhanVien(string searchValue)
        {
            List<NhanVienDTO> listNhanVien = new List<NhanVienDTO>();
            string query = "SP_TimKiemNhanVien @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO nguoidung = new NhanVienDTO(row);
                listNhanVien.Add(nguoidung);
            }
            return listNhanVien;
        }
    }
}
