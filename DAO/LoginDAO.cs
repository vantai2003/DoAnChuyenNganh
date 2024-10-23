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
        private string conStr = "Data Source=LAPTOP-70K25FBU\\NGUYENVANTAI;Initial Catalog=QL_SatThepXD;User ID=sa;Password = 123;Encrypt=False";
        public (bool ktlogin, int quyenId) DangNhapandKTQuyen(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT QuyenID FROM NguoiDung Where TenDN = @username AND MatKhau = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    var roleId = cmd.ExecuteScalar();
                    if(roleId!=null)
                    {
                        return (true, Convert.ToInt32(roleId));
                    }
                }
            }
            return (false, -1);
        }
    }
}
