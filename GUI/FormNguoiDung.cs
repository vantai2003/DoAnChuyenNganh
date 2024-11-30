using DACN.DAO;
using DACN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN.GUI
{
    public partial class FormNguoiDung : Form
    {
        public FormNguoiDung()
        {
            InitializeComponent();
            LoadNguoiDung();
        }
        private int flag = 0;
        private void LoadNguoiDung()
        {
            List<NguoiDungDTO> listNguoiDung = NguoiDungDAO.Instance.GetNguoiDung();
            dvg_NguoiDung.DataSource = listNguoiDung;
            dvg_NguoiDung.Columns["MaNV"].HeaderText = "Tên đăng nhập";
            dvg_NguoiDung.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dvg_NguoiDung.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dvg_NguoiDung.Columns["QuyenID"].Visible = false;
            dvg_NguoiDung.Columns["TenQuyen"].HeaderText = "Quyền";
            List<QuyenDTO> listQuyen = QuyenDAO.Instance.LoadLisQuyen();
            cb_vitrilv.DataSource = listQuyen;
            cb_vitrilv.DisplayMember = "TenQuyen";
            cb_vitrilv.ValueMember = "Id";
            cb_vitrilv.SelectedIndex = 3;
            List<NhanVienDTO> listNV = NhanVienDAO.Instance.LoadListNV();
            cb_NhanVien.DataSource = listNV;
            cb_NhanVien.DisplayMember = "MaNV";
            cb_NhanVien.ValueMember = "MaNV";
            btnThem.Enabled = true;
            btn_Xoa.Enabled = btn_Sua.Enabled = btnLuu.Enabled = false;
            txt_pass.Clear();
            cb_NhanVien.SelectedIndex = 2;
            cb_vitrilv.Enabled = cb_NhanVien.Enabled =txt_pass.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<NguoiDungDTO> listNguoiDung = NguoiDungDAO.Instance.TimKiemNguoiDung(txt_Search.Text);
            dvg_NguoiDung.DataSource = listNguoiDung;
        }

        private void dvg_NguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dvg_NguoiDung.Rows[e.RowIndex];
                cb_NhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cb_vitrilv.SelectedValue = Convert.ToInt32(row.Cells["QuyenID"].Value);
                string tenQuyen = row.Cells["TenQuyen"].Value.ToString();

                foreach (QuyenDTO quyen in cb_vitrilv.Items)
                {
                    if (quyen.TenQuyen == tenQuyen)
                    {
                        cb_vitrilv.SelectedItem = quyen;
                        break;
                    }
                }
                btn_Xoa.Enabled = true;
                btnThem.Enabled = false;
                btn_Sua.Enabled = true;
                cb_NhanVien.Enabled = txt_pass.Enabled =  cb_vitrilv.Enabled = false;
                flag = 2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào người dùng" + ex.ToString());
                txt_pass.Clear();
                cb_vitrilv.SelectedIndex = 2;
            }
        }
        private bool KTTrungTenDN(string tenDN)
        {
            return NguoiDungDAO.Instance.KiemTraTrungTenDN(tenDN);
        }
        public bool IsValidInput(string input)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenDN = "";
            tenDN = cb_NhanVien.SelectedValue.ToString();
            string matKhau = NguoiDungDAO.Hash(txt_pass.Text);
            if (tenDN == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!");
            }
            else
            {
                if (IsValidInput(tenDN))
                {
                    if (KTTrungTenDN(tenDN))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                    }
                    else
                    {
                        DateTime ngayTao = DateTime.Now;
                        
                        int quyenID = int.Parse(cb_vitrilv.SelectedValue.ToString());

                        NguoiDungDAO.Instance.ThemNguoiDung(tenDN, matKhau, ngayTao, quyenID);
                        MessageBox.Show("Thêm người dùng thành công");
                        LoadNguoiDung();
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không đúng định dạng");
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadNguoiDung();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string tenDN = "";
            tenDN = cb_NhanVien.SelectedValue.ToString();
            if (tenDN == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa người dùng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    NguoiDungDAO.Instance.XoaNguoiDung(tenDN);
                    MessageBox.Show("Xóa người dùng thành công!");
                    LoadNguoiDung();
                }
            }
        }
            

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btn_Xoa.Enabled = false;
            txt_pass.Enabled = cb_vitrilv.Enabled = true;
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if(flag == 2)
            {
                string tenDN = cb_NhanVien.SelectedValue.ToString();
                string matKhau = null;
                if(txt_pass.Text  != "")
                {
                    matKhau = txt_pass.Text;
                }    
                matKhau = NguoiDungDAO.Hash(txt_pass.Text);
                int quyenId = int.Parse(cb_vitrilv.SelectedValue.ToString());
                NguoiDungDAO.Instance.SuaNguoiDung(tenDN, matKhau, quyenId);
                MessageBox.Show("Sửa người dùng thành công");
                LoadNguoiDung();
                
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadNguoiDung() ;
        }
    }
}
