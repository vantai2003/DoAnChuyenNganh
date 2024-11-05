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
        public int SoLuong { get; set; }
        public string DVT { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string MaSP { get; set; }
        public string MaHD { get; set; }  

        public CTHoaDonDTO(DataRow row)
        {
            this.MaCTHD = row["MaSP"].ToString();
            this.SoLuong = int.Parse(row["SoLuong"].ToString());
            this.DonGia = float.Parse(row["TenSP"].ToString());
            this.DVT = row["DVT"].ToString();
            this.MaSP = row["MaSP"].ToString();
            this.MaHD = row["MaHD"].ToString();
            
        }
        public CTHoaDonDTO() { }
    }
}
