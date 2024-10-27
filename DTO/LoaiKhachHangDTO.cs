using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class LoaiKhachHangDTO
    {
        public string MaLoaiKH { get; set; }
        public string TenLoaiKH { get; set; }
        public LoaiKhachHangDTO(DataRow row)
        {
            this.MaLoaiKH = row["MaLoaiKH"].ToString();
            this.TenLoaiKH = row["TenLoaiKH"].ToString();
        }
        public LoaiKhachHangDTO()
        {
           
        }
    }
}
