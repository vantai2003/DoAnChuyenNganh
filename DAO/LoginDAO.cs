using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "SP_Login @TenDN , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public int getRole(string username, string password)
        {
            string query = "SP_Login @TenDN , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            DataRow role = result.Rows[0];
            return (int)role["QuyenID"];
        }
        //private string conStr = "Data Source=LAPTOP-70K25FBU\\NGUYENVANTAI;Initial Catalog=QL_SatThepXD;User ID=sa;Password = 123;Encrypt=False";
        //public (bool ktlogin, int quyenId) DangNhapandKTQuyen(string username, string password)
        //{
        //    using (SqlConnection con = new SqlConnection(conStr))
        //    {
        //        con.Open();
        //        string query = "SELECT QuyenID FROM NguoiDung Where TenDN = @username AND MatKhau = @password";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@username", username);
        //            cmd.Parameters.AddWithValue("@password", password);
        //            var roleId = cmd.ExecuteScalar();
        //            if(roleId!=null)
        //            {
        //                return (true, Convert.ToInt32(roleId));
        //            }
        //        }
        //    }
        //    return (false, -1);
        //}
    }
}
