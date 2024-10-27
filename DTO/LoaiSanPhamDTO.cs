using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiSanPhamDTO(DataRow row)
        {
            this.MaLoai = row["MaLoai"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
        }
        public LoaiSanPhamDTO() { }
    }
}
