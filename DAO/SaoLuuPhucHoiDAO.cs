using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.DAO
{
    public class SaoLuuPhucHoiDAO
    {
        public static bool BackupDatabase(string backupPath)
        {
            string query = "SP_BackupDatabase @BackupPath";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { backupPath });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool RestoreDatabase(string backupPath)
        {
            //kết nối đến master để sao lưu, nếu không chuyển sẽ không phục hồi được vì vì không thể restore khi đang được sử dụng
            string masterConnectionString = "Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=master;User ID=admin;Password=123;Encrypt=False";
            try
            {
                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    string query = "SP_RestoreDatabase @BackupPath";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BackupPath", backupPath);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
