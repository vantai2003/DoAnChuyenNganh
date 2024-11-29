using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACN.DTO;

namespace DACN.DAO
{
    class PhieuTraHangKHDAO
    {


        private static PhieuTraHangKHDAO instance;
        public static PhieuTraHangKHDAO Instance
        {
            get { if (instance == null) instance = new PhieuTraHangKHDAO(); return PhieuTraHangKHDAO.instance; }
            private set { PhieuTraHangKHDAO.instance = value; }
        }
        public PhieuTraHangKHDAO()
        {

        }
  
        public static string GenerateMaPT()
        {
            string query = "SP_TaoMaPTra_KH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public static string GenerateMaCTPT()
        {
            string query = "SP_TaoMaCTPTra_KH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }

        public bool ThemPhieuTraHang(string mapt, decimal tongtien, string lydo, DateTime ngaytao, string manv, string mahoadon, string makho)
        {
            string query = "SP_ThemPhieuTraHang_KH @MaPhieuTH , @TongTienNhan , @LyDo , @NgayTao , @MaNV , @MaHD , @MaKho";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapt, tongtien, lydo, ngaytao, manv, mahoadon, makho});
            return result > 0;
        }
        public bool ThemCTPhieuTraHang(CTPhieuTraHangKHDTO ctpth)
        {
            string query = "SP_ThemCTPhieuTraHang_KH @MaCTPT , @MaPhieuTH , @MaSP , @SoLuongTra , @DonGiaTra";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ctpth.MaCTPhieuTraHang, ctpth.MaPhieuTraHang, ctpth.MaSP, ctpth.SoLuong, ctpth.DonGia });
            return result > 0;
        }
        public bool CapNhatTonKho(string masp, string makho, decimal soluongton)
        {
            string query = "SP_CapNhatKho_KHTraHang @MaSP , @MaKho , @SoLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, makho, soluongton });
            return result > 0;
        }
        public int CapNhatTrangThaiTraHang_KH(string mahoadon)
        {
            string query = "SP_CapNhatXuLyHang_KH @MaHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahoadon });
            return result;
        }
        public List<CTPhieuTraHangKHDTO> GetCTPThieuTra_KH(string ID)
        {
            List<CTPhieuTraHangKHDTO> list = new List<CTPhieuTraHangKHDTO>();
            string query = "sp_ChiTietPhieuTraHangKH @MaHD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            foreach (DataRow row in data.Rows)
            {
                CTPhieuTraHangKHDTO CTPT = new CTPhieuTraHangKHDTO(row);
                list.Add(CTPT);
            }

            return list;
        }
    }
}
