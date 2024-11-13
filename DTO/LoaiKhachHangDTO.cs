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
        public decimal? MucChiTieuToiThieu { get; set; }
        public decimal? MucChiTieuToiDa {  get; set; }
        public LoaiKhachHangDTO(DataRow row)
        {
            this.MaLoaiKH = row["MaLoaiKH"].ToString();
            this.TenLoaiKH = row["TenLoaiKH"].ToString();
            this.MucChiTieuToiThieu =decimal.Parse(row["MucChiTieuToiThieu"].ToString());
            this.MucChiTieuToiDa =decimal.Parse(row["MucChiTieuToiDa"].ToString());
        }
        public LoaiKhachHangDTO()
        {
           
        }
    }
}
