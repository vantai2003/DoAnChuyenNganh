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
            decimal giaTriKM = txt_GiaTriKM.Value;
            DateTime? ngayBD = null;
            DateTime? ngayKT = null;
            if (flag == 2)
            {
                 ngayBD = null;
                 ngayKT = null;
            }
            else
            {
                ngayBD = dtp_NgayBD.Value;
                ngayKT = dtp_NgayKT.Value;
            }
            try
            {
                
                KhuyenMaiDAO.Instance.ThemKM(maKM, tenKM, ngayBD, ngayKT, moTa, trangThai, giaTriKM);
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
            flag = 1;
        }

        private void rd_TheoTongTien_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = false;
            flag = 2;
        }

        private void rd_TheoLoaiKH_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = false;
            flag = 2;
        }
        private void LoadListKM()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKM();
            dvg_DSKM.DataSource = listKM;

        }
    }
}
