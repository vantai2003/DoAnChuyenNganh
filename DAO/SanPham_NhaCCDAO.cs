using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class SanPham_NhaCCDAO
    {
        private static SanPham_NhaCCDAO instance;
        public static SanPham_NhaCCDAO Instance
        {
            get { if (instance == null) instance = new SanPham_NhaCCDAO(); return SanPham_NhaCCDAO.instance; }
            private set { SanPham_NhaCCDAO.instance = value; }
        }
        public SanPham_NhaCCDAO() { }
        public List<SanPham_NhaCungCapDTO> GetDSSanPhamNCC()
        {
            List<SanPham_NhaCungCapDTO> listSpKho = new List<SanPham_NhaCungCapDTO>();

            string query = "SP_GetListSanPhamNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                SanPham_NhaCungCapDTO SanphamKho = new SanPham_NhaCungCapDTO(row);
                listSpKho.Add(SanphamKho);
            }

            return listSpKho;
        }
        public int ThemSanPhamNCC(string mancc, string masp)
        {
            string query = "SP_ThemSanPhamNNCC @MaNCC , @MaSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mancc, masp });
            return result;
        }
        public List<HangHoaDTO> LocSPNhaCCDaCungCap(string mancc)
        {
            List<HangHoaDTO> listSP = new List<HangHoaDTO>();

            string query = "GetSanPhamChuaCungCap @MaNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {mancc});

            foreach (DataRow row in data.Rows)
            {
                HangHoaDTO SanPham = new HangHoaDTO(row);
                listSP.Add(SanPham);
            }

            return listSP;
        }
        public List<SanPham_NhaCungCapDTO> LocTheoNCC(string mancc)
        {
            List<SanPham_NhaCungCapDTO> listSPNCC = new List<SanPham_NhaCungCapDTO>();

            string query = "SP_GetListSanPhamNCCByIdNCC @MaNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mancc });

            foreach (DataRow row in data.Rows)
            {
                SanPham_NhaCungCapDTO SanPhamNCC = new SanPham_NhaCungCapDTO(row);
                listSPNCC.Add(SanPhamNCC);
            }

            return listSPNCC;
        }
        public List<SanPham_NhaCungCapDTO> LocTheoSP(string mancc)
        {
            List<SanPham_NhaCungCapDTO> listSPNCC = new List<SanPham_NhaCungCapDTO>();

            string query = "SP_GetListSanPhamNCCBySP @SearchValues";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mancc });

            foreach (DataRow row in data.Rows)
            {
                SanPham_NhaCungCapDTO SanPhamNCC = new SanPham_NhaCungCapDTO(row);
                listSPNCC.Add(SanPhamNCC);
            }

            return listSPNCC;
        }
        public bool XoaNhaCungUng(string mancc,string masp)
        {
            string query = "SP_XoaCungUng @MaNCC , @MaSP";
            int resule = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mancc, masp });
            return resule > 0;
        }
        public List<SanPham_NhaCungCapDTO> ListBangGia()
        {
            List<SanPham_NhaCungCapDTO> listBangGia = new List<SanPham_NhaCungCapDTO>();

            string query = "SP_ListBangGia";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                SanPham_NhaCungCapDTO spNCC = new SanPham_NhaCungCapDTO
                {
                    MaNCC = row["MaNCC"].ToString(),
                    TenNCC = row["TenNCC"].ToString(),
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    TenLoai = row["TenLoai"].ToString(),
                    DVT = row["DVT"].ToString()
                };
                if (row["GiaNhap"] != DBNull.Value && row["NgayCapNhat"] != DBNull.Value)
                {
                    spNCC.GiaNhap = Convert.ToDecimal(row["GiaNhap"]);
                    spNCC.NgayCapNhat = Convert.ToDateTime(row["NgayCapNhat"]);
                }
                else
                {
                    spNCC.GiaNhap = null;
                    spNCC.NgayCapNhat = null;
                }

                listBangGia.Add(spNCC);
            }

            return listBangGia;
        }
    }
}
