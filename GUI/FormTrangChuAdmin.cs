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
    public partial class FormTrangChuAdmin : Form
    {
        public FormTrangChuAdmin()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_QuanLyTaiKhoam_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormNguoiDung());
        }

        private void btn_QuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLHangHoa());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {

        }
    }
}
