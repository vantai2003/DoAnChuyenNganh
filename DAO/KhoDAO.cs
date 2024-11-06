using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;
        public static KhoDAO Instance
        {
            get { if (instance == null) instance = new KhoDAO(); return KhoDAO.instance; }
            private set { KhoDAO.instance = value; }
        }
        public KhoDAO()
        {

        }

        public List<KhoDTO> GetKho()
        {
            List<KhoDTO> list = new List<KhoDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_Kho");

            foreach (DataRow row in data.Rows)
            {
                KhoDTO kho = new KhoDTO(row);
                list.Add(kho);
            }

            return list;

        }
        public int Insert(KhoDTO obj)
        {
            string query = "sp_Insert_Kho @MaKho , @TenKho , @DiaChi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaKho, obj.TenKho, obj.DiaChi });
            return result;
        }
        public int Update(KhoDTO obj)
        {
            string query = "sp_Update_Kho  @MaKho , @TenKho , @DiaChi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaKho, obj.TenKho, obj.DiaChi });
            return result;
        }
        public int Delete(string ID)
        {
            string query = "sp_Delete_Kho  @MaKho";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }
        public string GetMaKhoByTenKho(string tenKho)
        {
            string query = "EXEC SP_GetMaKhoByTenKho @TenKho";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKho });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["MaKho"].ToString();
            }
            return null;
        }
    }
}
