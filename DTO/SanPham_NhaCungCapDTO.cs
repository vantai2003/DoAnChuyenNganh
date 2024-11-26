using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class SanPham_NhaCungCapDTO
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenLoai { get; set; }
        public string DVT { get; set; }
        public decimal? GiaNhap { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public SanPham_NhaCungCapDTO(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.MaSP = row["MaSP"].ToString();
            this.TenSP = row["TenSP"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
            this.DVT = row["DVT"].ToString();
            //this.GiaNhap =Convert.ToDecimal(row["GiaNhap"].ToString());
            //this.NgayCapNhat =Convert.ToDateTime(row["NgayCapNhat"].ToString());
        }
        public SanPham_NhaCungCapDTO() { }
    }
}
