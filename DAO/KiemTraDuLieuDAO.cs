using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class KiemTraDuLieuDAO
    {
        public static bool KTSoDienThoai(string phoneNumber)
        {
            string pattern = @"^(0|\+84)(3|5|7|8|9)\d{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool KiemTraEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
