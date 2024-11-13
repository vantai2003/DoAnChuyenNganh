using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormQLKhuyenMai : Form
    {
        public static string loaiDK;
        private int flag;
        public FormQLKhuyenMai()
        {
            InitializeComponent();
            LoadListKM();
        }

        private void btn_TaoKM_Click(object sender, EventArgs e)
        {
            string maKM = KhuyenMaiDAO.GenerateMaKM();
            string tenKM = txt_TenKM.Text;
           
            string moTa = txt_MoTa.Text;
            string trangThai = cb_TrangThai.SelectedItem.ToString();
            decimal giaTriKM = decimal.Parse(txt_GiaTriKM.Text);
            DateTime? ngayBD = null;
            DateTime? ngayKT = null;
            decimal? dieuKienTongTien = null;
            string loaiDieuKien = loaiDK;
            if (flag == 2)
            {
                 ngayBD = null;
                 ngayKT = null;
                dieuKienTongTien =decimal.Parse(txt_DieuKienTongTien.Text);
            }
            else if (flag == 3)
            {
                string loaiKH = cb_LoaiKH.SelectedValue.ToString();
                tenKM = loaiKH;
                ngayBD = null;
                ngayKT = null;
                dieuKienTongTien = null;
            }
            else
            {
                ngayBD = dtp_NgayBD.Value;
                ngayKT = dtp_NgayKT.Value;
                dieuKienTongTien = null;
            }
            try
            {
                
                KhuyenMaiDAO.Instance.ThemKM(maKM, tenKM, ngayBD, ngayKT, moTa, trangThai, giaTriKM, loaiDieuKien, dieuKienTongTien);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm thất bại " + ex.Message);
            }
        }

        private void rd_TheoKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = true;
            lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = false;
            flag = 1;
            loaiDK = "Theo khoảng thời gian";
        }

        private void rd_TheoTongTien_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = false;
            txt_TenKM.Enabled = true;
            flag = 2;
            loaiDK = "Theo tổng tiền";
        }
        private void LoadListLoaiKH()
        {
            List<LoaiKhachHangDTO> listLoaiKH = LoaiKhachHangDAO.Instance.GetLoaiKhachHang();
            cb_LoaiKH.DataSource = listLoaiKH;
            cb_LoaiKH.DisplayMember = "TenLoaiKH";
            cb_LoaiKH.ValueMember = "TenLoaiKH";
        }
        private void rd_TheoLoaiKH_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = false;
            lb_tenkm.Enabled = txt_TenKM.Enabled = false;
            lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = true;
            flag = 3;
            loaiDK = "Theo loại khách hàng";
            LoadListLoaiKH();
        }
        private void LoadListKM()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKM();
            dvg_DSKM.DataSource = listKM;

        }
    }
}
