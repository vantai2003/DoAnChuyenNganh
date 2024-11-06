using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class CTPhieuNHDTO
    {
        public string MaCTPhieuNH {  get; set; }
        public string MaSP {  get; set; }
        public string TenSP {  get; set; }
        public string TenLoai {  get; set; }
        public string TenNCC {  get; set; }
        public string MaPhieuNH { get; set; }
        public string DVT { get; set; }
        public string TrangThai { get; set; }
        public string MaNV { get; set; }
        public decimal SoLuong {  get; set; }
        public decimal DonGia { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayNhapHang {  get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
        public CTPhieuNHDTO(DataRow row)
        {
            this.MaCTPhieuNH = row["MaCTPhieuNH"].ToString();
            this.MaPhieuNH = row["MaPhieuNH"].ToString();
            this.NgayNhapHang =DateTime.Parse(row["NgayNhapHang"].ToString());
            this.MaSP = row["MaSP"].ToString();
            this.TenSP = row["TenSP"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.SoLuong = decimal.Parse(row["SoLuong"].ToString());
            this.DonGia = decimal.Parse(row["DonGia"].ToString());
            this.DVT = row["DVT"].ToString();
            this.TongTien = decimal.Parse(row["TongTien"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
            this.MaNV = row["MaNV"].ToString();
        }
        public CTPhieuNHDTO() { }
    }
}
