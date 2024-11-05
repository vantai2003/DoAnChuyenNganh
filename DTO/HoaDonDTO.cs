using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }

        public DateTime NgayDatHang { get; set; }
        public float TongTien { get; set; }
        public string TrangThai { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public float TienCoc { get; set; }
        public float ThanhToan { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public HoaDonDTO(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaNV = row["MANV"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.NgayDatHang = DateTime.Parse(row["NgayDatHang"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
            this.DiaChiGiaoHang = row["DiaChiGiaoHang"].ToString();
            this.TienCoc = float.Parse(row["TienCoc"].ToString());
            this.ThanhToan = float.Parse(row["ThanhToan"].ToString());
            this.TongTien = float.Parse(row["TongTien"].ToString());
        }
        public HoaDonDTO() { }
    }
}
