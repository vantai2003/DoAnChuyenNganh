using DACN.DAO;
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
    public partial class FormSaoLuuPhucHoi : Form
    {
        public FormSaoLuuPhucHoi()
        {
            InitializeComponent();

        }
        
        private bool backupDatabase(string backupPath)
        {
            return SaoLuuPhucHoiDAO.BackupDatabase(backupPath);
        }
        private bool restoreDatabase(string backupPath)
        {
            return SaoLuuPhucHoiDAO.RestoreDatabase(backupPath);
        }
        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Backup Files|*.bak";
                sfd.Title = "Chọn nơi lưu file sao lưu";
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = sfd.FileName;
                    if(backupDatabase(backupPath) == true)
                    {
                        MessageBox.Show("Sao lưu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sao Lưu thất bại");
                    }

                }
            }
        }

        private void btn_PhucHoi_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Backup Files|*.bak";
                ofd.Title = "Chọn file sao lưu";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = ofd.FileName;
                    if(restoreDatabase(backupPath)== true)
                    {
                        MessageBox.Show("Phục hồi thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Phục hồi thất bại!");
                    }
                }
            }
        }
    }
}
