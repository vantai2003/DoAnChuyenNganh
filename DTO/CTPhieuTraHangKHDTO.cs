using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace DACN.DTO
{
    class CTPhieuTraHangKHDTO
    {
        public string MaCTPhieuTraHang { get; set; }
        public string MaPhieuTraHang { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; } 
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal TongTienNhan { get; set; } 
        public string LyDo { get; set; }



        public CTPhieuTraHangKHDTO(DataRow row)
        {
            MaCTPhieuTraHang = row["IDCTPhieuTH"].ToString();
            NgayTao = Convert.ToDateTime(row["NgayTao"]);
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            SoLuong = Convert.ToDecimal(row["SoLuongTra"]);
            DonGia = Convert.ToDecimal(row["DonGiaTra"]);
            TongTienNhan = Convert.ToDecimal(row["TongTienNhan"]);
            LyDo = row["LyDo"].ToString();
        }
        public CTPhieuTraHangKHDTO() { }
    }
}
