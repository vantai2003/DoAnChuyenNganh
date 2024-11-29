using DACN.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class CTHoaDonDAO
    {
        private static CTHoaDonDAO instance;
        public static CTHoaDonDAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonDAO(); return CTHoaDonDAO.instance; }
            private set { CTHoaDonDAO.instance = value; }
        }
        public CTHoaDonDAO() { }
        public List<CTHoaDonDTO> GetCTHD()
        {
            List<CTHoaDonDTO> list = new List<CTHoaDonDTO>();

            string query = "sp_SelectAll_CTHD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                CTHoaDonDTO CTHD = new CTHoaDonDTO(row);
                list.Add(CTHD);
            }

            return list;

        }
        public int Insert(CTHoaDonDTO obj)
        {
            string query = "sp_Insert_CTHD @MaCTHD , @SoLuong , @DonGia , @DVT , @ThanhTien , @MaSP , @MaHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {obj.MaCTHD, obj.SoLuong, obj.DonGia, obj.DVT, obj.ThanhTien, obj.MaSP, obj.MaHD });
            return result;
        }
        public int Update(CTHoaDonDTO obj)
        {
            string query = "sp_Update_CTHD @MaCTHD , @SoLuong , @DonGia , @DVT , @ThanhTien , @MaSP , @MaHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { obj.MaCTHD, obj.SoLuong, obj.DonGia, obj.DVT, obj.ThanhTien, obj.MaSP, obj.MaHD });
            return result;
        }
        public List<CTHoaDonDTO> GetCTHDTheoMHD(string ID)
        {
            List<CTHoaDonDTO> list = new List<CTHoaDonDTO>();
            string query = "sp_SelectOne_CTHD @MaHD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            foreach (DataRow row in data.Rows)
            {
                CTHoaDonDTO CTHD = new CTHoaDonDTO(row);
                list.Add(CTHD);
            }

            return list;
        }

        public DataTable SearchSP(string searchquery)
        {
            List<CTHoaDonDTO> list = new List<CTHoaDonDTO>();
            string query = "SP_TimKiemSPKho @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchquery });

            return data;
        }
        public int CapNhatTrangThai(string masp,string makho,decimal soluong)
        {
            string query = "SP_CapNhatTonKho @MaSP , @MaKho , @SoLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, makho, soluong });
            return result;
        }
        public DataTable GetSanPhamBan()
        {
            string query = "SP_GetProductsInStock";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public int updateSL(string masp, string makho, decimal soluong)
        {
            string query = "SP_CapNhatSoLuongSP @MaSP , @MaKho , @SoLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, makho, soluong });
            return result;

        }
        public int Delete(string ID)
        {
            string query = "SP_Delete_CTHD @MaCTHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result;
        }
    }
}
