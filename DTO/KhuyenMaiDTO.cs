using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class KhuyenMaiDTO
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc {  get; set; }
        public string MoTa {  get; set; }
        public string TrangThai {  get; set; }
        public decimal GiaTriKM {  get; set; }

        public KhuyenMaiDTO(DataRow row)
        {
            this.MaKM = row["MaKM"].ToString();
            this.TenKM = row["TenKM"].ToString();
            this.NgayBatDau =Convert.ToDateTime(row["NgayBatDau"].ToString());
            this.NgayKetThuc = DateTime.Parse(row["NgayKetThuc"].ToString());
            this.MoTa = row["MoTa"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.GiaTriKM =Decimal.Parse(row["GiaTriKM"].ToString());
        }
        public KhuyenMaiDTO() { }
    }
}
