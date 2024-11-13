using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACN.DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string TenKH {  get; set; }
        public string SoDienThoai {  get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }

        public DateTime NgayTao { get; set; }
        public string MaLoaiKH { get; set; }
        public string TenLoaiKH { get; set; }
        public KhachHangDTO(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.Diachi = row["DiaChi"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.Email = row["Email"].ToString();
            this.NgayTao = DateTime.Parse(row["NgayTao"].ToString());
            this.TenLoaiKH = row["TenLoaiKH"].ToString();
           // this.MaLoaiKH = row["MaLoaiKH"].ToString();
            
        }
        public KhachHangDTO (){ }
    }
}
