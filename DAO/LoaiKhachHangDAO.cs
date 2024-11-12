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
                LoaiKhachHangDTO lkh = new LoaiKhachHangDTO()
                {
                    MaLoaiKH = row["MaLoaiKH"].ToString(),
                    TenLoaiKH = row["TenLoaiKH"].ToString(),
                };
                if (row["MucChiTieuToiThieu"] != DBNull.Value && row["MucChiTieuToiDa"] != DBNull.Value)
                {
                    lkh.MucChiTieuToiThieu = Convert.ToDecimal(row["MucChiTieuToiThieu"]);
                    lkh.MucChiTieuToiDa = Convert.ToDecimal(row["MucChiTieuToiDa"]);
                }
                else
                {
                    lkh.MucChiTieuToiThieu = null;
                    lkh.MucChiTieuToiDa = null;
                }

                list.Add(lkh);
            }

            return list;
        }
        public static string GetLoaiKHById(string tenloai)
        {
            string query = "SP_GetTenLoaiKHById @TenLoaiKH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tenloai});

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public int Insert(string maloai, string tenloai, object mucchitieutt, object mucchitieutd)
        {
            string query = "sp_Insert_LoaiKhachHang @MaLKH , @TenLKH , @MucChiTieuToiThieu , @MucChiTieuToiDa";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai, tenloai, mucchitieutt ?? DBNull.Value, mucchitieutd ?? DBNull.Value });
            return result;
        }
        public int Update(LoaiKhachHangDTO obj)
        {
            string query = "sp_Update_LoaiKhachHang @MaLKH , @TenLKH , @MucChiTieuToiThieu , @MucChiTieuToiDa";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaLoaiKH, obj.TenLoaiKH, obj.MucChiTieuToiThieu, obj.MucChiTieuToiDa });
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
