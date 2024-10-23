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
        public string TenDN {  get; set; }
        public string MatKhau { get; set; }
        public DateTime NgayTao { get; set; }
        public string MaNV { get; set; }
        public int QuyenID {  get; set; }
        
        public NguoiDungDTO(DataRow row)
        {
            this.TenDN = row["TenDN"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.NgayTao = DateTime.Parse(row["NgayTao"].ToString());
            this.MaNV = row["MaNV"].ToString();
            this.QuyenID = int.Parse(row["QuyenID"].ToString());
        }
        public NguoiDungDTO() { }
    }
}
