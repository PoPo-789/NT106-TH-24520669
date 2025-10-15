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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa trắng các textbox 
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Quay về Menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            string kq = "";

            //Kiểm tra dữ liệu nhâp vào
            if (input == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Xử lý chuỗi từ số sang chữ
            switch (input)
            {
                case "0":
                    kq = "Không";
                    break;
                case "1":
                    kq = "Một";
                    break;
                case "2":
                    kq = "Hai";
                    break;
                case "3":
                    kq = "Ba";
                    break;
                case "4":
                    kq = "Bốn";
                    break;
                case "5":
                    kq = "Năm";
                    break;
                case "6":
                    kq = "Sáu";
                    break;
                case "7":
                    kq = "Bảy";
                    break;
                case "8":
                    kq = "Tám";
                    break;
                case "9":
                    kq = "Chín";
                    break;
                default:
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            textBox2.Text = kq;
        }
    }
}
