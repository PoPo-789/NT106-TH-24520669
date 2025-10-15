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
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private static readonly string[] ChuSo =
           { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            // Kiểm tra dữ liệu nhập vào
            if (input == "")
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(input, out long so) || so < 0)
            {
                MessageBox.Show("Chỉ được nhập số nguyên dương (12 chữ số)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (input.Length > 12)
            {
                MessageBox.Show("Số quá lớn (chỉ nhập 12 chữ số)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (input.Length < 12)
            {
                MessageBox.Show("Số quá nhỏ (phải nhập 12 chữ số)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2.Text = DocSoThanhChu(so);
        }

        // Hàm đọc số thành chữ
        private string DocSoThanhChu(long so)
        {
            if (so == 0) return "Không";

            string[] DonViNhom = { "", "nghìn", "triệu", "tỷ" };
            string ketQua = "";
            int i = 0;

            while (so > 0)
            {
                int nhom = (int)(so % 1000);
                if (nhom != 0)
                {
                    string chuNhom = DocBaChuSo(nhom);
                    ketQua = $"{chuNhom} {DonViNhom[i]} {ketQua}";
                }
                so /= 1000;
                i++;
            }

            // Chuẩn hóa lại chuỗi
            ketQua = ketQua.Trim();
            return char.ToUpper(ketQua[0]) + ketQua.Substring(1);
        }

        // Hàm đọc 3 chữ số
        private string DocBaChuSo(int num)
        {
            int tram = num / 100;
            int chuc = (num % 100) / 10;
            int donvi = num % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += ChuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0) kq += " lẻ";
            }

            if (chuc > 1)
            {
                kq += " " + ChuSo[chuc] + " mươi";
                if (donvi == 1) kq += " mốt";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (donvi == 1) kq += " một";
                else if (donvi == 5) kq += " lăm";
                else if (donvi > 0) kq += " " + ChuSo[donvi];
            }
            else if (chuc == 0 && tram == 0)
            {
                if (donvi > 0) kq += ChuSo[donvi];
            }
            else
            {
                if (donvi > 0) kq += " " + ChuSo[donvi];
            }

            return kq.Trim();
        }
    }
}
