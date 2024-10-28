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
    public partial class FormNhanVienBanHang : Form
    {
        public FormNhanVienBanHang()
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

        private void btn_CapNhatDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhMuc());
        }

        private void btn_QLHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLHangHoa());
        }
    }
}
