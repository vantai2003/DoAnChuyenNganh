using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class CTPhieuTraHangNCCDTO
    {
        public string MaCTPhieuTraHang { get; set; }
        public string MaPhieuTraHang { get; set; }
        public string MaSP { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
       // public decimal ThanhTien => SoLuong * DonGia;
        //public CTPhieuTraHangNCCDTO(DataRow row)
        //{
        //    this.MaCTPhieuNH = row["MaCTPhieuNH"].ToString();
        //    this.MaPhieuNH = row["MaPhieuNH"].ToString();
        //    this.NgayNhapHang = DateTime.Parse(row["NgayNhapHang"].ToString());
        //    this.MaSP = row["MaSP"].ToString();
        //    this.TenSP = row["TenSP"].ToString();
        //    this.TenLoai = row["TenLoai"].ToString();
        //    this.TenNCC = row["TenNCC"].ToString();
        //    this.SoLuong = decimal.Parse(row["SoLuong"].ToString());
        //    this.DonGia = decimal.Parse(row["DonGia"].ToString());
        //    this.DVT = row["DVT"].ToString();
        //    this.TongTien = decimal.Parse(row["TongTien"].ToString());
        //    this.TrangThai = row["TrangThai"].ToString();
        //    this.MaNV = row["MaNV"].ToString();
        //}
        //public CTPhieuTraHangNCCDTO() { }
    }
}
