using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class Kho_SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenLoaiSP { get; set; }
        public string DVT { get; set; }
        //public string MaKho { get; set; }
        public string TenKho { get; set; }
        public decimal SoLuongTon { get; set; }
        public Kho_SanPhamDTO(DataRow row) {
            this.MaSP = row["MaSP"].ToString();
            this.TenSP = row["TenSP"].ToString();
            this.TenLoaiSP = row["TenLoai"].ToString();
            this.DVT = row["DVT"].ToString();
            this.SoLuongTon = decimal.Parse(row["SoLuongTon"].ToString());
            this.TenKho = row["TenKho"].ToString();
            
        }
        public Kho_SanPhamDTO() { }

    }
}
