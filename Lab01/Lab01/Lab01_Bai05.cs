using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Lab01_Bai05_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; // Mặc định chọn dòng đầu tiên
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(textBox1.Text.Trim());
                int B = int.Parse(textBox3.Text.Trim());
                string result = "";

                if (comboBox1.SelectedIndex == 0)
                {
                    // ======= LỰA CHỌN 1: BẢNG CỬU CHƯƠNG CỦA SỐ (B - A) =======
                    int so = Math.Abs(B - A);
                    result += $"=== BẢNG CỬU CHƯƠNG CỦA SỐ {so} ===\r\n\r\n";

                    for (int i = 1; i <= 10; i++)
                    {
                        result += $"{so} x {i,2} = {so * i}\r\n";
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    // ======= Lựa chọn 2: TÍNH (A - B)! và TỔNG S =======
                    int hieu = Math.Abs(A - B);
                    long giaiThua = 1;
                    for (int i = 1; i <= hieu; i++)
                        giaiThua *= i;

                    double tong = 0;
                    for (int i = 1; i <= B; i++)
                        tong += Math.Pow(A, i);

                    result += $"(A - B)! = {hieu}! = {giaiThua}\r\n";
                    result += $"Tổng S = A¹ + A² + ... + Aᴮ = {tong}\r\n";
                }

                textBox2.Text = result;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa trắng các textbox 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Quay về Menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
