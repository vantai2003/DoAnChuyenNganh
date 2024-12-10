using System;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DACN.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
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
            CenterToScreen();
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
            txtInfo.Visible = txtSTK.Visible = txtTenTaiKhoan.Visible = txt_soTien.Visible = cb_nganhang.Visible = cb_template.Visible = btnCreate.Visible = pictureBox1.Visible = true;
            label10.Visible = label11.Visible = label2.Visible = label8.Visible = label9.Visible = label12.Visible = true;
            txt_tiencantra.Visible = txt_tienkm.Visible = txt_tongtienhang.Visible = txt_tiencoc.Visible  = txt_tienthanhtoan.Visible = btnXacnhan.Visible= false;
            label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = false;
            ThanhToanQR_Load();
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
   
        private void ThanhToanQR_Load()
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<ThanhToanQRDTO>(bankRawJson);
                cb_nganhang.DataSource = listBankData.data;   // list banks
                cb_nganhang.DisplayMember = "custom_name";
                cb_nganhang.ValueMember = "bin";
                cb_nganhang.SelectedValue = listBankData.data.FirstOrDefault().bin;
                cb_template.SelectedIndex = 0;
            }
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var apiRequest = new ApiRequestDTO();
            apiRequest.acqId = Convert.ToInt32(cb_nganhang.SelectedValue.ToString());
            apiRequest.accountNo = txtSTK.Text.TrimStart().PadLeft(txtSTK.Text.Length, '0'); // Ví dụ với độ dài 13 ký tự
            apiRequest.accountName = txtTenTaiKhoan.Text;
            apiRequest.amount = Convert.ToInt32(txt_soTien.Text);
            apiRequest.format = "text";
            apiRequest.template = cb_template.Text;
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);
            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);
            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox1.Image = image;
            btnXacNhanQR.Visible = true;
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void rdbTienmat_CheckedChanged(object sender, EventArgs e)
        {
            txt_tiencantra.Visible = txt_tienkm.Visible = txt_tongtienhang.Visible = txt_tiencoc.Visible = txt_tienthanhtoan.Visible= btnXacnhan.Visible = true;
            label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = true;
            txtInfo.Visible = txtSTK.Visible = txtTenTaiKhoan.Visible = txt_soTien.Visible = cb_nganhang.Visible = cb_template.Visible = btnCreate.Visible = pictureBox1.Visible = false;
            label10.Visible = label11.Visible = label2.Visible = label8.Visible = label9.Visible = label12.Visible = false;
            btnXacNhanQR.Visible = false;
        }


        private void btnXacNhanQR_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tiencantra = decimal.TryParse(txt_tiencantra.Text, out decimal stct) ? stct : 0;
                decimal tientra = decimal.TryParse(txt_soTien.Text, out decimal temp) ? temp : 0;

                //string mahd = "HD001";
                string mahd = FormHoaDon.mahd;
                HoaDonDAO.Instance.ThanhToan(mahd, tiencantra - tientra);
                MessageBox.Show("Thanh toán thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void txt_soTien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthanhtoan.Text))
            {
                txt_tienthanhtoan.Text = "0";
            }
            if (decimal.TryParse(txt_tiencantra.Text, out decimal tiencantra) && decimal.TryParse(txt_soTien.Text, out decimal tienthanhtoan) && tienthanhtoan > tiencantra)
            {
                MessageBox.Show("Nhập số tiền thanh toán không hợp lệ!!!");
                txt_soTien.Text = "0";
            }
        }

        private void txt_soTien_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
