using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class PhieuNhapHangDTO
    {
        public string MaPhieuNH { get; set; }
        public DateTime NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        //public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        //public string MaKho { get; set; }
        public string TenKho { get; set; }
        public PhieuNhapHangDTO(DataRow row)
        {
            this.MaPhieuNH = row["MaPhieuNH"].ToString();
            this.NgayDatHang = DateTime.Parse(row["NgayDatHang"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.TenKho = row["TenKho"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.TongTien = decimal.Parse(row["TongTien"].ToString());
        }
        public PhieuNhapHangDTO() { }
    }
}
