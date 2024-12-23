﻿using DACN.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
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
        
        public List<PhieuNhapHangDTO> TimPhieuNhap(string searchValue)
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_SearchPN @MaPN", new object[] {searchValue});
            foreach (DataRow row in data.Rows)
            {
                PhieuNhapHangDTO phieunhap = new PhieuNhapHangDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
        public List<PhieuNhapHangDTO> LocPhieuNhap(object tenncc, object tenkho)
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LocPN @Kho , @NhaCungCap", new object[] { tenncc ?? DBNull.Value, tenkho ?? DBNull.Value });
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
        public int PheDuyetXoa(string mapn)
        {
            string query = "SP_PheDuyetXoaPN @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn });
            return result;
        }
        public int TuChoiPN(string mapn)
        {
            string query = "SP_TuChoiPN @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn });
            return result;
        }
        public int TuChoiYeuCauXoa(string mapn)
        {
            string query = "SP_TuChoiYeuCauXoa @MaPN";
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
        public bool UpdatePhieuNhap(string mapn, decimal tongtien, string manv)
        {
            string query = "SP_SuaPhieuNhapHang @MaPhieuNH , @TongTien , @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn, tongtien, manv});
            return result > 0;
        }
        public bool UpdateCTPhieuNhap(string mactpn, decimal soluong, decimal dongia)
        {
            string query = "SP_SuaCTPhieuNhapHang @MaCTPhieuNH , @SoLuong , @DonGia";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mactpn, soluong, dongia });
            return result > 0;
        }
        
        public bool XoaCTPN(string mactpn)
        {
            string query = "SP_XoaCTPN @MaCTPhieuNH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mactpn});
            return result > 0;
        }
        public List<PhieuNhapHangDTO> LocTheoNgay(string tungay, string denngay)
        {
            List<PhieuNhapHangDTO> listPN = new List<PhieuNhapHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LocTheoNgay @TuNgay , @DenNgay", new object[] {tungay, denngay});
            foreach (DataRow row in data.Rows)
            {
                PhieuNhapHangDTO phieunhap = new PhieuNhapHangDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
        public bool XoaPN(string mapn)
        {
            string query = "SP_XoaChoDuyetPN @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn});
            return result > 0;
        }
        public decimal GetDonGiaNhap(string masp, string mancc)
        {
            string query = "SP_LayDonGiaNhap @MaSP , @MaNCC";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] {masp, mancc});
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }
        public DataTable GetNhaCungCapInfo(string maPhieuNhap)
        {
            string query = "SP_TTNhaCCDeinPhieuPhap @MaPN";
        
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuNhap });
        }
    }   
}
