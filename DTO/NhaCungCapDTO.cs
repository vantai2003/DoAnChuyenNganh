using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACN.DTO
{
    public class NhaCungCapDTO
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public DateTime NgayTao { get; set; }
        public NhaCungCapDTO(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["EMAIL"].ToString();
            this.ThanhPho = row["ThanhPho"].ToString();
            this.QuocGia = row["QuocGia"].ToString();
            this.NgayTao = DateTime.Parse(row["NgayTao"].ToString());
        }

        public NhaCungCapDTO()
        {
        }
    }
}
