using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class HangHoaDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public string MaKho { get; set; }
        public string MaLoaiSP { get; set; }
        public string TenLoai { get; set; }

        public HangHoaDTO(DataRow row)
        {
            this.MaSP = row["MaSP"].ToString();
            this.TenSP = row["TenSP"].ToString();
            this.DVT =row["DVT"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
        }
        public HangHoaDTO() { }
    }
}
