using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return LoginDAO.instance; }
            private set { instance = value; }
        }
        public LoginDAO()
        {
        }
        public bool Login(string username, string password)
        {
            string query = "SP_Login @MaNV , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public int getRole(string username, string password)
        {
            string query = "SP_Login @MaNV , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            DataRow role = result.Rows[0];
            return (int)role["QuyenID"];
        }
        public int DoiMatKhau(string tendn, string matkhaucu, string matkhaumoi)
        {
            string query = "SP_DoiMatKhau @MaNV , @MatKhauCu , @MatKhauMoi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tendn, matkhaucu, matkhaumoi });
            return result;
        }
        public void LogoutUser(string loginName)
        {
            string query = "KillUserSessions @UserName";
            DataProvider.Instance.ExecuteNonQueryAsAdmin(query, new object[] { loginName });  
        }
        public int StatusDangNhap(string manv)
        {
            string query = "SP_SetStatus @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {manv});
            return result;
        }
        public int StatusDangXua(string manv)
        {
            string query = "SP_SetStatus0 @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv });
            return result;
        }
        public int GetStatus(string username)
        {
            string query = "SP_TrangThai @MaNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }

    }
}
