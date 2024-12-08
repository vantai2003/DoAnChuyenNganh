using DACN.GUI;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.DAO
{
    public class DataProvider
    {
        private string user;
        private string password;
        private string conStr;
        public static string thongBao = null;
        private string conStrAdmin = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QL_SatThepXD;User ID=userkill;Password=123;Encrypt=False";

        //private string conStrAdmin = "Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=QL_SatThepXD;User ID=userkill;Password=123;Encrypt=False";
        private SqlConnection connection;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private static DataProvider instance;

        // private string conStr = "Data Source=localhost;Initial Catalog=QL_SatThepXD;User ID=sa;Password = 123;Encrypt=False";
        //private string conStr = "Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=QL_SatThepXD;Integrated Security=True;Encrypt=False";
       // private string conStr = "Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=QL_SatThepXD;User ID=admin;Password = 123;Encrypt=False";

        //private string conStr = $"Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=QL_SatThepXD;User ID={User};Password = {};Encrypt=False";


        //private string conStr = "Data Source=localhost;Initial Catalog=QL_SatThepXD;User ID=nv001;Password = 123;Encrypt=False";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        public DataProvider()
        {
            user = FormDangNhap.nhanvien;
            password = FormDangNhap.password;
            SetConnectionString(user, password);
        }
        public void SetConnectionString(string user, string password)
        {
            user = user.ToLower();
            password = password.ToLower();
            //conStr = $"Data Source=LAPTOP-70K25FBU\\MSSQLSERVER01;Initial Catalog=QL_SatThepXD;User ID={user};Password={password};Encrypt=False";
            conStr = $"Data Source=MSI\\SQLEXPRESS;Initial Catalog=QL_SatThepXD;User ID={user};Password={password};Encrypt=False"; 
            
        }


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public void ExecuteNonQueryAsAdmin(string query, object[] parameter = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conStrAdmin))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        AddParametersToCommand(cmd, query, parameter);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL (Admin): {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void AddParametersToCommand(SqlCommand cmd, string query, object[] parameters)
        {
            if (parameters != null)
            {
                string[] listPara = query.Split(' ').Where(p => p.Contains('@')).ToArray();
                for (int i = 0; i < listPara.Length; i++)
                {
                    cmd.Parameters.AddWithValue(listPara[i], parameters[i]);
                }
            }
        }
    }
}
