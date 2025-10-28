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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Quay về menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int charCount = 0;
            int wordCount = 0;
            int lineCount = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (Path.GetExtension(ofd.FileName).ToLower() != ".txt")
            {
                MessageBox.Show("Chỉ được chọn file .txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fi = new FileInfo(ofd.FileName);
            if (fi.Length == 0)
            {
                MessageBox.Show("File rỗng không có dữ liệu để đọc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = ofd.SafeFileName.ToString();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            string filePath = fs.Name.ToString();
            StreamReader sr = new StreamReader(fs);
            string s = File.ReadAllText(ofd.FileName, Encoding.UTF8);
            sr.Close();
            fs.Close();

            if (s.Length > 0 && s[0] == '\uFEFF')
                s = s.Substring(1);

            s = s.Replace("\r\n", "\n");

            //Đếm số ký tự, số từ, số dòng
            charCount = s.Length;
            wordCount = s.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            lineCount = s.Split(new char[] { '\n' }).Length;

            //Hiển thị kết quả lên RichTextBox
            rtbOut.Text = s;
            tbName.Text = name;
            tbSize.Text = new FileInfo(ofd.FileName).Length.ToString() + " bytes";
            tbURL.Text = filePath;
            tbCharCnt.Text = charCount.ToString();
            tbWordCnt.Text = wordCount.ToString();
            tbLineCnt.Text = lineCount.ToString();
        }
    }
}
