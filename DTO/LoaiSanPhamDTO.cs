using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiSanPhamDTO(string maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }
    }
}
