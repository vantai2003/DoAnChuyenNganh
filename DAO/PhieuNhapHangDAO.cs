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
    public class PhieuNhapHangDAO
    {
        private static PhieuNhapHangDAO instance;
        public static PhieuNhapHangDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapHangDAO(); return PhieuNhapHangDAO.instance; }
            private set { PhieuNhapHangDAO.instance = value; }
        }
        public PhieuNhapHangDAO()
        {

        }
        public bool ThemPhieuNhapHang(string mapn, DateTime ngaydat, decimal tongtien, string trangthai, string manv, string mancc, string makho)
        {
            string query = "SP_ThemPhieuNhapHang @MaPhieuNH , @NgayDatHang , @TongTien , @TrangThai , @MaNV , @MaNCC , @MaKho";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { mapn, ngaydat, tongtien, trangthai, manv, mancc, makho });
            return result > 0;
        }
        public bool ThemCTPhieuNhapHang(CTPhieuNHDTO ctPhieuNhap)
        {
            string query = "EXEC SP_ThemCTPhieuNhapHang @MaCTPhieuNH , @MaPhieuNH , @MaSP , @SoLuong , @DonGia , @NgayNhapHang";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ctPhieuNhap.MaCTPhieuNH, ctPhieuNhap.MaPhieuNH, ctPhieuNhap.MaSP, ctPhieuNhap.SoLuong, ctPhieuNhap.DonGia, ctPhieuNhap.NgayNhapHang });
            return result > 0;
        }
        public static string GenerateMaPN()
        {
            string query = "SP_TaoMaPN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public static string GenerateMaCTPN()
        {
            string query = "SP_TaoMaCTPN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public bool CapNhatTonKho(string masp, string makho, decimal soluongton)
        {
            string query = "SP_CapNhatTonKho @MaSP , @MaKho , @SoLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, makho, soluongton });
            return result > 0;
        }
        public List<PhieuNhapHangDTO> GetPhieuNhap()
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListPN");
            foreach (DataRow row in data.Rows)
            {
                PhieuNhapHangDTO phieunhap = new PhieuNhapHangDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
        public List<PhieuNhapHangDTO> GetPhieuNhapStatus()
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListPNStatus");
            foreach (DataRow row in data.Rows)
            {
                PhieuNhapHangDTO phieunhap = new PhieuNhapHangDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
        public int PheDuyetPN(string mapn)
        {
            string query = "SP_PheDuyetPN @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn});
            return result;
        }
        public int TuChoiPN(string mapn)
        {
            string query = "SP_TuChoiPN @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn });
            return result;
        }
        public int CapNhatTrangThaiTraHang(string mapn)
        {
            string query = "SP_CapNhatXuLyHang @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn });
            return result;
        }

        public List<CTPhieuNHDTO> GetCTPhieuNH(string mapn)
        {
            List<CTPhieuNHDTO> listCTPN = new List<CTPhieuNHDTO>();
            string query = "SP_GetListCTPN @MaPhieuNH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {mapn});
            foreach (DataRow row in data.Rows)
            {
                CTPhieuNHDTO phieunhap = new CTPhieuNHDTO(row);
                listCTPN.Add(phieunhap);
            }
            return listCTPN;
        }
        public List<PhieuNhapHangDTO> DSPhieuNhapDaPD()
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_ListPNDaDuyet");
            foreach (DataRow row in data.Rows)
            {
                PhieuNhapHangDTO phieunhap = new PhieuNhapHangDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
    }   
}
