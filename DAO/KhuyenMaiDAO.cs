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
        public DataTable ApDungKhuyenMaiChung(string maHD)
        {
            try
            {
                string query = "SP_ApDungKhuyenMaiChung @MaHD";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maHD });

                if (result.Rows.Count > 0)
                {
                    // Hiển thị thông báo về khuyến mãi được áp dụng
                    Console.WriteLine("Khuyến mãi đã được áp dụng thành công.");
                    foreach (DataRow row in result.Rows)
                    {
                        Console.WriteLine($"Mã HD: {row["MaHD"]}, Tổng Tiền: {row["TongTien"]}, Thanh Toán: {row["ThanhToan"]}, Tiền KM: {row["TienKM"]}");
                    }
                }
                else
                {
                    Console.WriteLine("Không có khuyến mãi nào được áp dụng.");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return null;
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
        public int BatKM(string makm)
        {
            string query = "SP_BatKhuyenMai @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm });
            return result;
        }
        public int TuChoiKM(string makm)
        {
            string query = "SP_TuChoiKhuyenMai @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm });
            return result;
        }
        public int SuaKMThoiGian(string makm, string tenkm, DateTime ngaybd, DateTime ngaykt, decimal giatrikm, string mota)
        {
            string query = "SP_SuaKM @MaKM , @TenKM , @NgayDB , @NgayKT , @GiaTriKM , @MoTa";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm, tenkm, ngaybd , ngaykt, giatrikm, mota });
            return result;
        }
        public int SuaKMTongTien(string makm, string tenkm, decimal giatrikm, string mota, decimal dieukientt)
        {
            string query = "SP_SuaKMLoaiTongTien @MaKM , @TenKM , @GiaTriKM , @MoTa , @DieuKienTongTien";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm, tenkm, giatrikm, mota,dieukientt });
            return result;
        }
        public int SuaKMLoaiKH(string makm, decimal giatrikm, string mota)
        {
            string query = "SP_SuaKMLoaiKhachHang @MaKM , @GiaTriKM , @MoTa";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { makm, giatrikm, mota});
            return result;
        }
        public List<KhuyenMaiDTO> TimKiemKM(string searchValue)
        {
            List<KhuyenMaiDTO> listKhuyenMai = new List<KhuyenMaiDTO>();
            string query = "SP_TimKiemKhuyenMai @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { searchValue });
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
        public List<KhuyenMaiDTO> LocKMTrangThai(string searchValue)
        {
            List<KhuyenMaiDTO> listKhuyenMai = new List<KhuyenMaiDTO>();
            string query = "SP_TimKiemKhuyenMaiTheoTrangThai @SearchValue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
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
    }
}
