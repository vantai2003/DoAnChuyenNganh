using DACN.DAO;
using DACN.DTO;
using Sunny.UI;
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
    public partial class FormQLTonKho : Form
    {
        private int flag;
        public FormQLTonKho()
        {
            InitializeComponent();
            LoadTonKho();
        }
        private void LoadTonKho()
        {
            List<Kho_SanPhamDTO> listkhosp = TonKhoDAO.Instance.GetTonKho();
            dvg_TonKho.DataSource = listkhosp;
            dvg_TonKho.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dvg_TonKho.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dvg_TonKho.Columns["TenLoaiSP"].HeaderText = "Loại sản phẩm";
            dvg_TonKho.Columns["DVT"].HeaderText = "Đơn vị tính";
            dvg_TonKho.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dvg_TonKho.Columns["TenKho"].HeaderText = "Tên kho";
        }

        private void rdb_SanPham_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Enabled = btn_Loc.Enabled = true;
            cb_Kho.Enabled = false;
            cb_Kho.Text = null;
            flag = 0;
        }

        private void rdb_Kho_CheckedChanged(object sender, EventArgs e)
        {
            cb_Kho.Enabled = btn_Loc.Enabled = true;
            txt_search.Enabled = false;
            List<KhoDTO> listKHo = KhoDAO.Instance.GetKho();
            listKHo.Insert(0, new KhoDTO { MaKho = "ALL", TenKho = "Chọn tất cả" });
            cb_Kho.DataSource = listKHo;
            cb_Kho.DisplayMember = "TenKho";
            cb_Kho.ValueMember = "MaKho";
            flag = 1;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string maKho = cb_Kho.SelectedValue.ToString();
                if (maKho == "ALL")
                {
                    List<Kho_SanPhamDTO> listkhosp = TonKhoDAO.Instance.GetTonKho();
                    dvg_TonKho.DataSource = listkhosp;
                }
                else
                {
                    List<Kho_SanPhamDTO> listTonKho = TonKhoDAO.Instance.LocTheoKho(maKho);
                    dvg_TonKho.DataSource = listTonKho;
                }

            }
            else
            {
                string searchValue = txt_search.Text;
                List<Kho_SanPhamDTO> listTonKho = TonKhoDAO.Instance.LocTheoSP(searchValue);
                dvg_TonKho.DataSource = listTonKho;
            }
        }
    }
}
