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
            tp.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = tp.Width;
            frm.Height = tp.Height;
            frm.Dock = DockStyle.Fill;
            tp.Controls.Add(frm);
            frm.Show();
        }
        public void load()
        {
            FormBanHang frmBanHang = new FormBanHang();
            AddFormToTabPage(frmBanHang, uiTabControl1.TabPages[0]);
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var control in uiTabControl1.SelectedTab.Controls.OfType<Form>())
            {
                control.Close();
            }
            switch (uiTabControl1.SelectedIndex)
            {
                case 0:
                    FormBanHang frm1 = new FormBanHang();
                    AddFormToTabPage(frm1, uiTabControl1.SelectedTab);
                    break;
                case 1:
                    FormHoaDon formHoaDon = new FormHoaDon();
                    formHoaDon.SetBanHangMode();
                    AddFormToTabPage(formHoaDon, uiTabControl1.SelectedTab);
                    break;
            }
        }
    }
}
