using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class KhoDTO
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string DiaChi { get; set; }
        public KhoDTO(DataRow row)
        {
            this.MaKho = row["MaKho"].ToString();
            this.TenKho = row["TenKho"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }

        public KhoDTO()
        {

        }
    }
}