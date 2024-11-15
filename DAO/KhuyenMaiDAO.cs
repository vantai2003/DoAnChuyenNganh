using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;
        public static KhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new KhuyenMaiDAO(); return KhuyenMaiDAO.instance; }
            private set { KhuyenMaiDAO.instance = value; }
        }
        private KhuyenMaiDAO()
        {

        }
        public int ThemKM(string makm, string tenkm, object ngaybd, object ngaykt, string mota, string trangthai, decimal giatridk, string loaidk, object dieukientongtien)
        {
            string query = "SP_ThemKM @MaKM , @TenKM , @NgayBatDau , @NgayKetThuc , @MoTa , @TrangThai , @GiaTriKM , @LoaiDK , @DieuKienTongTien";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm, tenkm, ngaybd ?? DBNull.Value, ngaykt ?? DBNull.Value, mota, trangthai, giatridk, loaidk,dieukientongtien ?? DBNull.Value });
            return result;
        }
        public int KhuyenMaiTheoThoiGian(string mahd)
        {
            string query = "SP_KM_TheoThoiGian @MaHD";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            if (result != null && int.TryParse(result.ToString(), out int parsedResult))
            {
                return parsedResult;
            }
            else
            {
                return 0;
            }
        }
        public int KhuyenMaiTheoTongTien(string mahd)
        {
            string query = "SP_KM_TheoTongTien @MaHD";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            if (result != null && int.TryParse(result.ToString(), out int parsedResult))
            {
                return parsedResult;
            }
            else
            {
                return 0;
            }
        }
        public int KhuyenMaiTheoLoaiKH(string mahd)
        {
            string query = "Sp_ApDungKhuyenMai @MaHD";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            if (result != null && int.TryParse(result.ToString(), out int parsedResult))
            {
                return parsedResult;
            }
            else
            {
                return 0;
            }
        }
        public static string GenerateMaKM()
        {
            string query = "SP_TaoMaKM";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return null;
        }
        public List<KhuyenMaiDTO> LoadListKM()
        {
            List<KhuyenMaiDTO> listKhuyenMai = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_ListKM");
            foreach (DataRow row in data.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO
                {
                    MaKM = row["MaKM"].ToString(),
                    TenKM = row["TenKM"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    GiaTriKM = Convert.ToDecimal(row["GiaTriKM"]),
                    LoaiDK = row["LoaiDieuKien"].ToString()
                };
                if (row["NgayBatDau"] != DBNull.Value && row["NgayKetThuc"] != DBNull.Value)
                {
                    km.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
                    km.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
                }
                else
                {
                    km.NgayBatDau = null;
                    km.NgayKetThuc = null;
                }
                if (row["DieuKienTongTien"] != DBNull.Value)
                {
                    km.DieuKienTongTien = Convert.ToDecimal(row["DieuKienTongTien"]);
                }
                else
                {
                    km.DieuKienTongTien= null;
                }

                listKhuyenMai.Add(km);
            }
            return listKhuyenMai;
        }
        public List<KhuyenMaiDTO> LoadListKMCanPheDuyet()
        {
            List<KhuyenMaiDTO> listKhuyenMai = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_ListKMCanPheDuyet");
            foreach (DataRow row in data.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO
                {
                    MaKM = row["MaKM"].ToString(),
                    TenKM = row["TenKM"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    GiaTriKM = Convert.ToDecimal(row["GiaTriKM"]),
                    LoaiDK = row["LoaiDieuKien"].ToString()
                };
                if (row["NgayBatDau"] != DBNull.Value && row["NgayKetThuc"] != DBNull.Value)
                {
                    km.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
                    km.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
                }
                else
                {
                    km.NgayBatDau = null;
                    km.NgayKetThuc = null;
                }
                if (row["DieuKienTongTien"] != DBNull.Value)
                {
                    km.DieuKienTongTien = Convert.ToDecimal(row["DieuKienTongTien"]);
                }
                else
                {
                    km.DieuKienTongTien = null;
                }

                listKhuyenMai.Add(km);
            }
            return listKhuyenMai;
        }
        public int PheDuyetKM(string makm)
        {
            string query = "SP_DuyetKhuyenMai @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm });
            return result;
        }
        public int TatKhuyenMai(string makm)
        {
            string query = "SP_NgungKhuyenMai @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm });
            return result;
        }
        public int TuChoiKM(string makm)
        {
            string query = "SP_TuChoiKhuyenMai @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm });
            return result;
        }
    }
}
