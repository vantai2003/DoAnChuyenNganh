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
    public partial class FormQLBanHang : Form
    {
        public FormQLBanHang()
        {
            InitializeComponent();
            load();
        }
        private void AddFormToTabPage(Form frm, TabPage tp)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tp.Controls.Add(frm);
            frm.Show();
        }
        public void load()
        {
            FormBanHang frm1 = new FormBanHang();
            AddFormToTabPage(frm1, uiTabControl1.SelectedTab);
            uiTabControl1.Size = this.ClientSize;
            uiTabControl1.Location = new Point(0, 0);
            uiTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uiTabControl1.SelectedIndex)
            {
                case 0:
                    FormBanHang frm1 = new FormBanHang();
                    AddFormToTabPage(frm1, uiTabControl1.SelectedTab);
                    break;
                case 1:
                    FormHoaDon frm2 = new FormHoaDon();
                    AddFormToTabPage(frm2, uiTabControl1.SelectedTab);
                    break;
            }
        }
    }
}
