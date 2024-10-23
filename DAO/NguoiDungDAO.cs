using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class NguoiDungDAO
    {
        private static NguoiDungDAO instance;
        public static NguoiDungDAO Instance
        {
            get { if (instance == null) instance = new NguoiDungDAO(); return NguoiDungDAO.instance; }
            private set { NguoiDungDAO.instance = value; }
        }
        private NguoiDungDAO()
        {

        }
        public List<NguoiDungDTO> TimKiemNguoiDung(string searchValue)
        {
            List<NguoiDungDTO> listNguoiDung = new List<NguoiDungDTO>();
            string query = "SP_TimKiemNguoiDung @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
            foreach(DataRow row in data.Rows)
            {
                NguoiDungDTO nguoidung = new NguoiDungDTO(row);
                listNguoiDung.Add(nguoidung);
            }
            return listNguoiDung;
        }
        public List<NguoiDungDTO> GetNguoiDung()
        {
            List<NguoiDungDTO> listNguoiDung = new List<NguoiDungDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListNguoiDung");
            foreach (DataRow row in data.Rows)
            {
                NguoiDungDTO nguoidung = new NguoiDungDTO(row);
                listNguoiDung.Add(nguoidung);
            }
            return listNguoiDung;
        }
        public int ThemNguoiDung(string tenDN, string matKhau, DateTime ngayTao, string maNV, int quyenId)
        {
            string query = "SP_ThemNguoiDung @TenDN , @MatKhau , @NgayTao , @MaNV , @QuyenID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDN, matKhau, ngayTao, maNV, quyenId });
            return result;
        }
        public static string Hash(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
    }
}
