using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class ChuyenTienThanhChu
    {
        private static readonly string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        private static readonly string[] tens = { "", "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
        private static readonly string[] powers = { "", "Ngàn", "Triệu", "Tỷ" };

        public static string ToWords(long number)
        {
            if (number == 0)
                return "Không đồng";

            string result = "";
            int powerIndex = 0;

            while (number > 0)
            {
                int chunk = (int)(number % 1000);
                if (chunk > 0)
                {
                    string chunkStr = ConvertChunk(chunk);
                    if (powerIndex > 0)
                    {
                        chunkStr += " " + powers[powerIndex];
                    }
                    result = chunkStr + " " + result;
                }
                number /= 1000;
                powerIndex++;
            }

            result = result.Trim();
            result = result.Replace("Mười không", "Mười");

            return result + " đồng";
        }

        private static string ConvertChunk(int chunk)
        {
            string chunkStr = "";

            int hundreds = chunk / 100;
            chunk %= 100;

            if (hundreds > 0)
            {
                chunkStr += ones[hundreds] + " trăm ";
            }

            int ten = chunk / 10;
            int one = chunk % 10;

            if (ten > 1)
            {
                chunkStr += tens[ten];
                if (one > 0)
                {
                    chunkStr += " " + ones[one];
                }
            }
            else if (ten == 1)
            {
                chunkStr += "Mười";
                if (one > 0)
                {
                    chunkStr += " " + ones[one];
                }
            }
            else
            {
                if (one > 0)
                {
                    chunkStr += ones[one];
                }
            }

            return chunkStr.Trim();
        }
    }
}
