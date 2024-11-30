using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class NguoiDungDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenQuyen {  get; set; }
        public int QuyenID {  get; set; }
        
        
        public NguoiDungDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.NgayTao = DateTime.Parse(row["NgayTao"].ToString());
            this.TenQuyen = row["TenQuyen"].ToString();
            //this.QuyenID = Convert.ToInt32(row["QuyenID"].ToString());
        }
        public NguoiDungDTO() { }
    }
}
