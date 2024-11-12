using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class CTHoaDonDTO
    {
        public string MaCTHD { get; set; }
        public decimal SoLuong { get; set; }
        public string DVT { get; set; }
        public decimal DonGia { get; set; }
        public string MaSP { get; set; }
        public string MaHD { get; set; }
        public decimal ThanhTien { get; set; } 
        public CTHoaDonDTO(DataRow row)
        {
            this.MaCTHD = row["MaCTHD"].ToString();
            this.SoLuong = decimal.Parse(row["SoLuong"].ToString());
            this.DonGia = decimal.Parse(row["DonGia"].ToString());
            this.DVT = row["DVT"].ToString();
            this.ThanhTien = decimal.Parse(row["ThanhTien"].ToString());
            this.MaSP = row["MaSP"].ToString();
            this.MaHD = row["MaHD"].ToString();
            
        }
        public CTHoaDonDTO() { }
    }
}
