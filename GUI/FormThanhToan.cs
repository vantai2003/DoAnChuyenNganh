using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACN.DAO;
namespace DACN.GUI
{
    public partial class FormThanhToan : Form
    {
        public string tongtienhang ;
        public string tiencoc ;
        public string tienkm ;
        public string soTienCanTra;
        public FormThanhToan(string tth, string tc, string tkm, string  stct)
        {
            InitializeComponent();
            tongtienhang = tth;
            tiencoc = tc;
            tienkm = tkm;
            soTienCanTra = stct;
            loadTT();
        }
        private void loadTT()
        {
            txt_tiencoc.Text = tiencoc;
            txt_tienkm.Text = tienkm;
            txt_tongtienhang.Text = tongtienhang;
            txt_tiencantra.Text = soTienCanTra;
        }
        private void rdbThe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_tienthanhtoan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthanhtoan.Text))
            {
                txt_tienthanhtoan.Text = "0";
            }
            if (decimal.TryParse(txt_tiencantra.Text, out decimal  tiencantra) && decimal.TryParse(txt_tienthanhtoan.Text, out decimal tienthanhtoan) && tienthanhtoan>tiencantra)
            {
                MessageBox.Show("Nhập số tiền thanh toán không hợp lệ!!!");
                txt_tienthanhtoan.Text = "0";
            }

        }

        private void txt_tienthanhtoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')
            {
                if (txt_tienthanhtoan.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
                if (txt_tienthanhtoan.Text.Length == 0)

                {
                    e.Handled = true;
                    return;
                }
            }
        }
        
        private void FormThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void txt_tiencantra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tiencantra = decimal.TryParse(txt_tiencantra.Text, out decimal stct) ? stct :0;
                decimal tienthanhtoan = decimal.TryParse(txt_tienthanhtoan.Text, out decimal temp) ? temp : 0;
                decimal tientra = tiencantra - tienthanhtoan;
                string mahd = FormHoaDon.mahd;
                HoaDonDAO.Instance.ThanhToan(mahd, tientra);
                MessageBox.Show("Thanh toán thành công!");
                this.Close();
        
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public void FormThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormClosed -= FormThanhToan_FormClosed;
        }
    }
}
