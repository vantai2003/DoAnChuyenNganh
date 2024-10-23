using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class LoginDTO
    {
        public string TenDN { get; set; }
        public string PassWord { get; set; }
        public DateTime NgayTao { get; set; }
        public int IdRole { get; set; }
        public string NhanVienId {  get; set; }
    }
}
