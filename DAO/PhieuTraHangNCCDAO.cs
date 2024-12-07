using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class PhieuTraHangNCCDAO
    {
        private static PhieuTraHangNCCDAO instance;
        public static PhieuTraHangNCCDAO Instance
        {
            get { if (instance == null) instance = new PhieuTraHangNCCDAO(); return PhieuTraHangNCCDAO.instance; }
            private set { PhieuTraHangNCCDAO.instance = value; }
        }
        public PhieuTraHangNCCDAO()
        {

        }
        public static string GenerateMaPT()
        {
            string query = "SP_TaoMaCTPTra";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public static string GenerateMaCTPN()
        {
            string query = "SP_TaoMaCTPTraHang";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public bool ThemPhieuTraHang(string mapt, decimal tongtien, string lydo, DateTime ngaytao, string manv, string maphieunhap)
        {
            string query = "SP_ThemPhieuTraHang @MaPhieuTH , @TongTienNhan , @LyDo , @NgayTao , @MaNV , @MaPhieuNH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapt, tongtien, lydo, ngaytao, manv, maphieunhap });
            return result > 0;
        }
        public bool ThemCTPhieuTraHang(CTPhieuTraHangNCCDTO ctpth)
        {
            string query = "SP_ThemCTPhieuTraHang @MaCTPT , @MaPhieuTH , @MaSP , @SoLuong , @DonGiaTra";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ctpth.MaCTPhieuTraHang, ctpth.MaPhieuTraHang, ctpth.MaSP, ctpth.SoLuong, ctpth.DonGia });
            return result > 0;
        }
        public DataTable GetPhieuTraHang()
        {
            string query = "SP_ListPhieuTraHangNCC";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public DataTable TimPhieuTHNCC(string searchvalue)
        {
            string query = "SP_TraHangNCC @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new[] {searchvalue});
        }
        public DataTable GetCTPhieuNH(string mapth)
        {
            string query = "SP_ListCTPhieuTH_NCC @MaPNH";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {mapth});
        }
        public bool XoaPhieuTHNCC(string mapth)
        {
            string query = "SP_DeletePhieuTH_NCC @MaPhieuTH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapth});
            return result > 0;
        }
    }
}
