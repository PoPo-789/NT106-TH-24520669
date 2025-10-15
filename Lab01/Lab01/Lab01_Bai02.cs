using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = double.Parse(textBox1.Text.Trim(), CultureInfo.InvariantCulture);
                double secondNumber = double.Parse(textBox2.Text.Trim(), CultureInfo.InvariantCulture);
                double thirdNumber = double.Parse(textBox3.Text.Trim(), CultureInfo.InvariantCulture);

                double max = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
                double min = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));

                // Hiển thị kết quả: nếu là số nguyên thì không có .0, nếu có thập phân thì giữ nguyên
                textBox4.Text = max % 1 == 0 ? ((int)max).ToString() : max.ToString("0.##", CultureInfo.InvariantCulture);
                textBox5.Text = min % 1 == 0 ? ((int)min).ToString() : min.ToString("0.##", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa trắng các textbox 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Quay về Menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
