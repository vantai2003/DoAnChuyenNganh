using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class LoaiKhachHangDTO
    {
        public string MaLoaiKH { get; set; }
        public string TenLoaiKH { get; set; }

        public LoaiKhachHangDTO(string maLoai, string tenLoai)
        {
            this.MaLoaiKH = maLoai;
            this.TenLoaiKH = tenLoai;
        }
    }
}
