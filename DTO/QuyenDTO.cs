using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class QuyenDTO
    {
        public int Id {  get; set; }
        public string TenQuyen {  get; set; }

        public QuyenDTO(DataRow row) {
            this.Id = int.Parse(row["Id"].ToString());
            this.TenQuyen = row["TenQuyen"].ToString();
        }
        public QuyenDTO() { }
    }
}
