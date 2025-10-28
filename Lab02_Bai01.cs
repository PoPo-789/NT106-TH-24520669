using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Quay về menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

            private void btnDocFile_Click(object sender, EventArgs e)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                if (Path.GetExtension(ofd.FileName).ToLower() != ".txt")
                {
                    MessageBox.Show("Chỉ được chọn file .txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();

                if (string.IsNullOrWhiteSpace(s))
                {
                    MessageBox.Show("File rỗng, không có dữ liệu để đọc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fs.Close();
                    return;
                }

                rtbOut.Text = s;
                fs.Close();
            }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (Path.GetExtension(ofd.FileName).ToLower() != ".txt")
            {
                MessageBox.Show("Chỉ ghi vào file .txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileStream fs = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(rtbOut.Text.ToUpper());
            sw.Flush();
            fs.Close();
        }
    }
}
