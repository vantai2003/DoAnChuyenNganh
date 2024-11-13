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
    public partial class FormQLNhanVien : Form
    {
        private int flag;
        private string phone;
        private string emails;
        public FormQLNhanVien()
        {
            InitializeComponent();
            LoadListNhanVien();
            
        }
        private void LoadListNhanVien()
        {
            List<NhanVienDTO> listNhanVien = NhanVienDAO.Instance.LoadListNV();
            dvg_NhanVien.DataSource = listNhanVien;
            dvg_NhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvg_NhanVien.Columns["TenNV"].HeaderText = "Họ tên";
            dvg_NhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dvg_NhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dvg_NhanVien.Columns["Email"].HeaderText = "Email";
            dvg_NhanVien.Columns["NgayTuyenDung"].HeaderText = "Ngày tuyển dụng";
            dvg_NhanVien.Columns["Luong"].HeaderText = "Lương";
            btnThem.Enabled = true;
            btn_Xoa.Enabled = btn_Sua.Enabled = btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string tenNV = txt_HoTen.Text;
            string chucVu = txt_ChuVu.Text;
            string sdt = txt_sdt.Text;
            string email = txt_Email.Text;
            DateTime ngayTD = dtp_NgayTD.Value;
            decimal luong = 0;
            if (txt_Luong.Text != "")
            {
                luong = decimal.Parse(txt_Luong.Text);
                
            }
            if (tenNV == "")
            {
                MessageBox.Show("Vui lòng không để trống họ tên");
            }
            else if(sdt == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!");
            }
            
            else
            {
                bool ktSDT = NhanVienDAO.Instance.KiemTraTrungSDT(sdt);
                if(ktSDT == true)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!");
                    return;
                }
                
                bool dinhDangSDT = KiemTraDuLieuDAO.KTSoDienThoai(sdt);
                if(dinhDangSDT == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
                bool dinhDangEmail = KiemTraDuLieuDAO.KiemTraEmail(email);
                if(dinhDangEmail == false)
                {
                    MessageBox.Show("Emaill không hợp lệ");
                    return;
                }
                bool ktEmail = NhanVienDAO.Instance.KiemTraTrungEmail(email);
                if (ktEmail == true)
                {
                    MessageBox.Show("Email đã được sử dụng!");
                    return;
                }
                else
                {
                    string maNV = NhanVienDAO.GenerateMaNV();
                    NhanVienDAO.Instance.ThemNhanVien(maNV, tenNV, chucVu, sdt, email, ngayTD, luong);
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadListNhanVien();
                }
                
            }
            
        }

        private void dvg_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_NhanVien.Rows[e.RowIndex];
                txt_MaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
                txt_HoTen.Text = Convert.ToString(row.Cells["TenNV"].Value);
                txt_ChuVu.Text = Convert.ToString(row.Cells["ChucVu"].Value);
                txt_sdt.Text = Convert.ToString(row.Cells["SDT"].Value);
                txt_Email.Text = Convert.ToString(row.Cells["Email"].Value);
                dtp_NgayTD.Value = Convert.ToDateTime(row.Cells["NgayTuyenDung"].Value);
                txt_Luong.Text = Convert.ToString(row.Cells["Luong"].Value);
                phone = txt_sdt.Text;
                emails = txt_Email.Text;
                btn_Xoa.Enabled = true;
                btnThem.Enabled = false;
                btn_Sua.Enabled = true;
                txt_HoTen.Enabled = txt_ChuVu.Enabled = txt_sdt.Enabled = txt_Email.Enabled = txt_Luong.Enabled = dtp_NgayTD.Enabled=false;
                flag = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào người dùng");
                txt_HoTen.Clear();
                txt_ChuVu.Clear();
                txt_sdt.Clear();
                txt_Email.Clear();
                txt_Luong.Clear();
                dtp_NgayTD.Value = DateTime.Now;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txt_MaNV.Text;
                NhanVienDAO.Instance.XoaNV(maNV);
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListNhanVien();
            }catch
            {
                MessageBox.Show("Không thể xóa nhân viên này");
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = false;
            btnLuu.Enabled = true;
            btn_Sua.Enabled=false;
            txt_HoTen.Enabled = txt_ChuVu.Enabled = txt_sdt.Enabled = txt_Email.Enabled = txt_Luong.Enabled = dtp_NgayTD.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenNV = txt_HoTen.Text;
            string chucVu = txt_ChuVu.Text;
            string sdt = txt_sdt.Text;
            string email = txt_Email.Text;
            DateTime ngayTD = dtp_NgayTD.Value;
            decimal luong = 0;
            if (txt_Luong.Text != "")
            {
                luong = decimal.Parse(txt_Luong.Text);

            }
            if (tenNV == "")
            {
                MessageBox.Show("Vui lòng không để trống họ tên");
            }
            if (sdt == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!");
            }
            if (sdt != phone)
            {
                bool ktSDT = NhanVienDAO.Instance.KiemTraTrungSDT(sdt);
                if (ktSDT)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!");
                    return;
                }

                bool dinhDangSDT = KiemTraDuLieuDAO.KTSoDienThoai(sdt);
                if (!dinhDangSDT)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
            }
            if (email != emails)
            {
                bool dinhDangEmail = KiemTraDuLieuDAO.KiemTraEmail(email);
                if (!dinhDangEmail)
                {
                    MessageBox.Show("Email không hợp lệ");
                    return;
                }

                bool ktEmail = NhanVienDAO.Instance.KiemTraTrungEmail(email);
                if (ktEmail)
                {
                    MessageBox.Show("Email đã được sử dụng!");
                    return;
                }
            }

            string maNV = txt_MaNV.Text;
            NhanVienDAO.Instance.SuaNV(maNV, tenNV, chucVu, sdt, email, ngayTD, luong);
            MessageBox.Show("Sửa nhân viên thành công!");
            LoadListNhanVien();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadListNhanVien();
            txt_MaNV.Clear();
            txt_HoTen.Clear();
            txt_ChuVu.Clear();
            txt_sdt.Clear();
            txt_Email.Clear();
            txt_Luong.Clear();
            dtp_NgayTD.Value = DateTime.Now;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text;
            List<NhanVienDTO> listNhanVien = NhanVienDAO.Instance.TimKiemNhanVien(searchValue);
            dvg_NhanVien.DataSource = listNhanVien;
            if(dvg_NhanVien.RowCount == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
        }
    }
}
