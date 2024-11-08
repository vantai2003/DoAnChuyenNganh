using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class HoaDonDAO
    {

        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }
        public HoaDonDAO() { }
        public List<HoaDonDTO> GetHoaDon()
        {
            List<HoaDonDTO> list= new List<HoaDonDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_SelectAll_HD");
            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hd = new HoaDonDTO(row);
                list.Add(hd);
            }
            return list;
        }
        public int Insert(HoaDonDTO obj)
        {
            string query = "sp_Insert_HD @MaHD , @NgayDatHang , @TongTien , @TrangThai , @DiaChiGiaoHang , @TienCoc , @ThanhToan , @MaKH , @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {obj.MaHD, obj.NgayDatHang, obj.TongTien, obj.TrangThai, obj.DiaChiGiaoHang, obj.TienCoc, obj.ThanhToan, obj.MaKH, obj.MaNV });
            return result;
        }
        public int Update(HoaDonDTO obj)
        {
            string query = "sp_Update_HD @MaHD , @NgayDatHang , @TongTien , @TrangThai , @DiaChiGiaoHang , @TienCoc , @ThanhToan , @MaKH , @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {obj.MaHD, obj.NgayDatHang, obj.TongTien, obj.TrangThai, obj.DiaChiGiaoHang, obj.TienCoc, obj.ThanhToan, obj.MaKH, obj.MaNV });
            return result;
        }
        public int Delete(string ID)
        {
            string query = "sp_Delete_HD @MaHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }

    }
}
