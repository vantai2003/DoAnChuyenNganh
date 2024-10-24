using DACN.DTO;
using System;   
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }
        private KhachHangDAO()
        {

        }
        public List<KhachHangDTO> GetKhachHang()
        {
            List<KhachHangDTO> listNguoiDung = new List<KhachHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_KhachHang");
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(row);
                listNguoiDung.Add(khachhang);
            }
            return listNguoiDung;
        }
    }
}
