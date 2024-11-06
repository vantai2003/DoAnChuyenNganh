﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }

        public DateTime NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public decimal TienCoc { get; set; }
        public decimal ThanhToan { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public HoaDonDTO(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaNV = row["MANV"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.NgayDatHang = DateTime.Parse(row["NgayDatHang"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
            this.DiaChiGiaoHang = row["DiaChiGiaoHang"].ToString();
            this.TienCoc = decimal.Parse(row["TienCoc"].ToString());
            this.TongTien = decimal.Parse(row["TongTien"].ToString());
        }
        public HoaDonDTO() { }
    }
}