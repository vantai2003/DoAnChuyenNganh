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
using System.Globalization;

namespace DACN.GUI
{
    public partial class FormThongKeDoanhThu : Form
    {
        private int flag;
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }
        private void btn_ThongKeNgay_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DateTime ngay = dtp_ChonNgay.Value;
                decimal tongThu = CongNoDAO.Instance.TongThuTheoNgay(ngay);
                txt_Thu.Text = tongThu.ToString("N0", new CultureInfo("vi-VN"));
                decimal tongChi = CongNoDAO.Instance.TongChiTheoNgay(ngay);
                txt_ChiTheoNgay.Text = tongChi.ToString("N0", new CultureInfo("vi-VN"));
            }
            else if (flag == 2)
            {
                decimal tongThu = CongNoDAO.Instance.TongThuTheoTuanHienTai();
                txt_Thu.Text = tongThu.ToString("N0", new CultureInfo("vi-VN"));
                decimal tongChi = CongNoDAO.Instance.TongChiTheoTuanHienTai();
                txt_ChiTheoNgay.Text = tongChi.ToString("N0", new CultureInfo("vi-VN"));
            }
            else if(flag == 3)
            {
                decimal tongThu = CongNoDAO.Instance.TongThuTheoKhoangTG(dtTuNgay.Value, dtDenNgay.Value);
                txt_Thu.Text = tongThu.ToString("N0", new CultureInfo("vi-VN"));
                decimal tongChi = CongNoDAO.Instance.TongChiTheoKhoangTG(dtTuNgay.Value, dtDenNgay.Value);
                txt_ChiTheoNgay.Text = tongChi.ToString("N0", new CultureInfo("vi-VN"));
            }
            else if(flag == 4)
            {
                int nam = int.Parse(cb_Nam.SelectedItem.ToString());
                DataTable dt = CongNoDAO.Instance.ThongKeTongThuChiTheoNam(nam);

                if (dt.Rows.Count > 0)
                {
                    txt_Thu.Text = Convert.ToDecimal(dt.Rows[0]["TongThu"]).ToString("N0", new CultureInfo("vi-VN"));
                    txt_ChiTheoNgay.Text = Convert.ToDecimal(dt.Rows[0]["TongChi"]).ToString("N0", new CultureInfo("vi-VN"));
                    txt_TongCong.Text = Convert.ToDecimal(dt.Rows[0]["LoiNhuan"]).ToString("N0", new CultureInfo("vi-VN"));
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho năm này.");
                }
            }
            else if(flag == 5)
            {
                DataTable dt = CongNoDAO.Instance.ThongKeTongThuChiTatCa();
                if (dt.Rows.Count > 0)
                {
                    decimal tongThu = Convert.ToDecimal(dt.Rows[0]["TongThu"]);
                    decimal tongChi = Convert.ToDecimal(dt.Rows[0]["TongChi"]);
                    decimal loiNhuan = Convert.ToDecimal(dt.Rows[0]["LoiNhuan"]);

                    txt_Thu.Text = tongThu.ToString("N0", new CultureInfo("vi-VN"));
                    txt_ChiTheoNgay.Text = tongChi.ToString("N0", new CultureInfo("vi-VN"));
                    txt_TongCong.Text = loiNhuan.ToString("N0", new CultureInfo("vi-VN"));
                }
                else
                {
                    txt_Thu.Text = "0";
                    txt_ChiTheoNgay.Text = "0";
                    txt_TongCong.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hình thống kê");
                return;
            }
            decimal thu = 0;
            decimal chi = 0;
            if (!string.IsNullOrWhiteSpace(txt_Thu.Text) && decimal.TryParse(txt_Thu.Text, NumberStyles.Number, new CultureInfo("vi-VN"), out thu))
            {
                thu = Convert.ToDecimal(txt_Thu.Text, new CultureInfo("vi-VN"));
            }

            if (!string.IsNullOrWhiteSpace(txt_ChiTheoNgay.Text) && decimal.TryParse(txt_ChiTheoNgay.Text, NumberStyles.Number, new CultureInfo("vi-VN"), out chi))
            {
                chi = Convert.ToDecimal(txt_ChiTheoNgay.Text, new CultureInfo("vi-VN"));
            }
            txt_TongCong.Text = (thu - chi).ToString("N0", new CultureInfo("vi-VN"));
        }

        private void rd_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
            label3.Enabled = dtp_ChonNgay.Enabled = true;
            dtTuNgay.Enabled = label6.Enabled = label1.Enabled = label7.Enabled = dtDenNgay.Enabled = dtDenNgay.Enabled = cb_Nam.Enabled = false;
        }

        private void rd_Tuan_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
            dtTuNgay.Enabled = label3.Enabled = dtp_ChonNgay.Enabled = label6.Enabled = label1.Enabled = label7.Enabled = dtDenNgay.Enabled = dtDenNgay.Enabled = cb_Nam.Enabled = false;
        }

        private void rd_KhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = label1.Enabled = dtTuNgay.Enabled = dtDenNgay.Enabled = true;
            flag = 3;
            label3.Enabled = dtp_ChonNgay.Enabled = label7.Enabled = cb_Nam.Enabled = false;
        }

        private void rd_Nam_CheckedChanged(object sender, EventArgs e)
        {
            label7.Enabled = cb_Nam.Enabled = true;
            label6.Enabled = label1.Enabled = dtTuNgay.Enabled = dtDenNgay.Enabled = label3.Enabled = dtp_ChonNgay.Enabled = false;
            flag = 4;
            LoadYearsToComboBox();
        }
        private void LoadYearsToComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 10;   
            cb_Nam.Items.Clear();
            for (int year = currentYear; year > startYear; year--)
            {
                cb_Nam.Items.Add(year);
            }
            if (cb_Nam.Items.Count > 0)
            {
                cb_Nam.SelectedIndex = 0;
            }
        }
        private void rd_TatCa_CheckedChanged(object sender, EventArgs e)
        {
            flag = 5;
            dtTuNgay.Enabled = label3.Enabled = dtp_ChonNgay.Enabled = label6.Enabled = label1.Enabled = label7.Enabled = dtDenNgay.Enabled = dtDenNgay.Enabled = cb_Nam.Enabled = false;
        }
    }
 }

