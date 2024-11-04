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
    }
}
