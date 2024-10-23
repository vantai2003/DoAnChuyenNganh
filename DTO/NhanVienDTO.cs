using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public DateTime NgayTuyenDung { get; set; }
        public decimal Luong {  get; set; }

        public NhanVienDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
            this.NgayTuyenDung = DateTime.Parse(row["NgayTuyenDung"].ToString());
            this.Luong = decimal.Parse(row["Luong"].ToString());
        }
        public NhanVienDTO() { }
    }
}
