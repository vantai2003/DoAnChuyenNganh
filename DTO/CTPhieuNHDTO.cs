using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class CTPhieuNHDTO
    {
        public string MaCTPhieuNH {  get; set; }
        public string MaSP {  get; set; }
        public string MaPhieuNH { get; set; }
        public decimal SoLuong {  get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgayNhapHang {  get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
        public CTPhieuNHDTO() { }
    }
}
