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
        private DataProvider dataProvider = new DataProvider();
        public List<LoaiKhachHangDTO> GetLoaiKhachHang()
        {
            List<LoaiKhachHangDTO> list = new List<LoaiKhachHangDTO>();

            string query = "SELECT * FROM LoaiKH";

            DataTable data = dataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                string maLoai = row["MaLoaiKH"].ToString();
                string tenLoai = row["TenLoaiKH"].ToString();

                LoaiKhachHangDTO loaiKH = new LoaiKhachHangDTO(maLoai, tenLoai);
                list.Add(loaiKH);
            }

            return list;
        }
    }
}
