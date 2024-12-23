﻿using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class TonKhoDAO
    {
        private static TonKhoDAO instance;
        public static TonKhoDAO Instance
        {
            get { if (instance == null) instance = new TonKhoDAO(); return TonKhoDAO.instance; }
            private set { TonKhoDAO.instance = value; }
        }
        public TonKhoDAO() { }
        public List<Kho_SanPhamDTO> GetTonKho()
        {
            List<Kho_SanPhamDTO> listSpKho = new List<Kho_SanPhamDTO>();

            string query = "SP_GetProductsInStock";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Kho_SanPhamDTO SanphamKho = new Kho_SanPhamDTO(row);
                listSpKho.Add(SanphamKho);
            }

            return listSpKho;
        }
        public int CapNhatTrangThai(string mapn)
        {
            string query = "SP_CapNhatTonKo @MaPN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn });
            return result;
        }

        public decimal CapNhatTonKho(string masp, string mapn)
        {
            string query = "SP_GetSoLuongNhapGoc @MaSP , @MaPN";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { masp, mapn });
            return result != null ? Convert.ToDecimal(result) : 0;
        }
        public List<Kho_SanPhamDTO> LocTheoKho(string makho)
        {
            List<Kho_SanPhamDTO> listSpKho = new List<Kho_SanPhamDTO>();

            string query = "SP_LocTonKhoTheoKho @MaKho";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {makho});

            foreach (DataRow row in data.Rows)
            {
                Kho_SanPhamDTO SanphamKho = new Kho_SanPhamDTO(row);
                listSpKho.Add(SanphamKho);
            }

            return listSpKho;
        }
        public List<Kho_SanPhamDTO> LocTheoSP(string searchvalue)
        {
            List<Kho_SanPhamDTO> listSpKho = new List<Kho_SanPhamDTO>();

            string query = "SP_LocTonKhoTheoSanPham @ReSearch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchvalue });

            foreach (DataRow row in data.Rows)
            {
                Kho_SanPhamDTO SanphamKho = new Kho_SanPhamDTO(row);
                listSpKho.Add(SanphamKho);
            }

            return listSpKho;
        }
    }
}
