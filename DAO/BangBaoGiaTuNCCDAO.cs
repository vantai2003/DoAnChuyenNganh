using DACN.DTO;
using DACN.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class BangBaoGiaTuNCCDAO
    {
        private static BangBaoGiaTuNCCDAO instance;
        public static BangBaoGiaTuNCCDAO Instance
        {
            get { if (instance == null) instance = new BangBaoGiaTuNCCDAO(); return BangBaoGiaTuNCCDAO.instance; }
            private set { BangBaoGiaTuNCCDAO.instance = value; }
        }
        public BangBaoGiaTuNCCDAO() { }
        
        public bool CapNhatGia(string masp, string mancc, decimal gianhap, DateTime ngaycapnhat)
        {
            string query = "SP_CapNhatGia @MaSP , @MaNCC , @GiaNhap , @NgayCapNhat";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, mancc, gianhap, ngaycapnhat });
            return result > 0;
        }
        public List<SanPham_NhaCungCapDTO> LocBangBaoGia(object tensanpham, object tenncc)
        {
            List<SanPham_NhaCungCapDTO> listPN = new List<SanPham_NhaCungCapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LocBangGia @SanPham , @NhaCungCap", new object[] { tensanpham ?? DBNull.Value, tenncc ?? DBNull.Value });
            foreach (DataRow row in data.Rows)
            {
                SanPham_NhaCungCapDTO phieunhap = new SanPham_NhaCungCapDTO(row);
                listPN.Add(phieunhap);
            }
            return listPN;
        }
    }
}
