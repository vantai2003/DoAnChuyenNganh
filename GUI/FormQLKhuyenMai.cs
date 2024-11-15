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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DACN.GUI
{
    public partial class FormQLKhuyenMai : Form
    {
        public static string loaiDK;
        private int flag;
        private string maKM =null;
        private int temp;
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
            if (!rd_TheoKhoangTG.Checked && !rd_TheoTongTien.Checked && !rd_TheoLoaiKH.Checked)
            {
                MessageBox.Show("Vui lòng chọn một loại khuyến mãi!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_GiaTriKM.Text))
            {
                MessageBox.Show("Giá trị khuyến mãi không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaTriKM.Focus();
            }
            else if (!decimal.TryParse(txt_GiaTriKM.Text, out _))
            {
                MessageBox.Show("Giá trị khuyến mãi phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaTriKM.Focus();
            }
            else
            {
                decimal giaTriKM = decimal.Parse(txt_GiaTriKM.Text);
                DateTime? ngayBD = null;
                DateTime? ngayKT = null;
                decimal? dieuKienTongTien = null;
                string loaiDieuKien = loaiDK;
                if (flag == 2)
                {
                    ngayBD = null;
                    ngayKT = null;
                    
                    if (string.IsNullOrWhiteSpace(txt_DieuKienTongTien.Text))
                    {
                        MessageBox.Show("Giá trị điều kiện tổng tiền không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_DieuKienTongTien.Focus();
                        return;
                    }
                    else if (!decimal.TryParse(txt_GiaTriKM.Text, out _))
                    {
                        MessageBox.Show("Giá trị điều kiện tổng tiền phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_DieuKienTongTien.Focus();
                        return;
                    }
                    else
                    {
                        dieuKienTongTien = decimal.Parse(txt_DieuKienTongTien.Text);
                    }
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
                    txt_TenKM.Clear();
                    txt_MoTa.Clear();
                    txt_GiaTriKM.Clear();
                    txt_DieuKienTongTien.Clear();
                    flag = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Thêm thất bại " + ex.Message);
                }
            }
        }

        private void rd_TheoKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = true;
            lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = lb_gtdktt.Enabled = txt_DieuKienTongTien.Enabled = false;
            flag = 1;
            loaiDK = "Theo khoảng thời gian";
        }

        private void rd_TheoTongTien_CheckedChanged(object sender, EventArgs e)
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = false;
            txt_TenKM.Enabled = lb_gtdktt.Enabled = txt_DieuKienTongTien.Enabled = true;
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
            lb_tenkm.Enabled = txt_TenKM.Enabled = lb_gtdktt.Enabled = txt_DieuKienTongTien.Enabled = false;
            lb_LoaiKH.Enabled = cb_LoaiKH.Enabled = true;
            flag = 3;
            loaiDK = "Theo loại khách hàng";
            LoadListLoaiKH();
        }
        private void LoadListKM()
        {
            List<KhuyenMaiDTO> listKM = KhuyenMaiDAO.Instance.LoadListKM();
            dvg_DSKM.DataSource = listKM;
            cb_TrangThai.SelectedIndex = 0;
        }

        private void tab_Body_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tab_Body.SelectedIndex;

            switch (index)
            {
                case 0:
                    LoadListKM();
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }

        private void btn_TatKM_Click(object sender, EventArgs e)
        {
            if (maKM == null)
            {
                MessageBox.Show("Vui lòng chọn Khuyến mãi muốn tắt");
            }
            else
            {
                try
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn có chắc muốn tắt khuyến mãi?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        KhuyenMaiDAO.Instance.TatKhuyenMai(maKM);
                        MessageBox.Show("Đã tắt khuyến mãi");
                        maKM = null;
                        LoadListKM();
                    }
                }
                catch
                {
                    MessageBox.Show("Tắt khuyến mãi thất bại");
                }

            } 
        }

        private void dvg_DSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_DSKM.Rows[e.RowIndex];
                maKM = Convert.ToString(row.Cells["MaKM"].Value);
                txttenkm.Text =Convert.ToString(row.Cells["TenKM"].Value);
                dpNgayBD.Text =Convert.ToString(row.Cells["NgayBatDau"].Value);
                dpNgayKT.Text =Convert.ToString(row.Cells["NgayKetThuc"].Value);
                txtgtkm.Text =Convert.ToString(row.Cells["GiaTriKM"].Value);
                txtdktt.Text = Convert.ToString(row.Cells["DieuKienTongTien"].Value);
                string loaiDK = Convert.ToString(row.Cells["LoaiDK"].Value);
                if(loaiDK == "Theo khoảng thời gian")
                {
                    dpNgayBD.Enabled = dpNgayKT.Enabled = true;
                    temp = 1;
                }
    
                else
                {
                    dpNgayBD.Enabled = dpNgayKT.Enabled = false;
                }
                if(loaiDK == "Theo tổng tiền")
                {
                    txtdktt.Enabled = true;
                    temp = 2;
                }
                else
                {
                    txtdktt.Enabled = false;
                }
                if(loaiDK == "Theo loại khách hàng")
                {
                    txttenkm.Enabled = false;
                    temp = 3;
                }
                else
                {
                    txttenkm.Enabled = true;
                }
                uiTextBox1.Text = loaiDK;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi");
            }
        }
    }
}
