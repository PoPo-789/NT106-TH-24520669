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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Set về giá trị ngày giờ hiện tại
            dateTimePicker1.Value = DateTime.Now;
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
            DateTime ngaySinh = dateTimePicker1.Value;
            int day = ngaySinh.Day;
            int month = ngaySinh.Month;
            string cung = "";

            // ✅ Xác định cung hoàng đạo theo ngày & tháng
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                cung = "Bạch Dương ♈ (Aries)";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                cung = "Kim Ngưu ♉ (Taurus)";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                cung = "Song Tử ♊ (Gemini)";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                cung = "Cự Giải ♋ (Cancer)";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                cung = "Sư Tử ♌ (Leo)";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                cung = "Xử Nữ ♍ (Virgo)";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
                cung = "Thiên Bình ♎ (Libra)";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 21))
                cung = "Bọ Cạp ♏ (Scorpio)";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                cung = "Nhân Mã ♐ (Sagittarius)";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                cung = "Ma Kết ♑ (Capricorn)";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                cung = "Bảo Bình ♒ (Aquarius)";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                cung = "Song Ngư ♓ (Pisces)";
            else
                cung = "Không xác định được cung hoàng đạo 😅";

            // 🪄 Hiển thị kết quả
            MessageBox.Show(
               $"Ngày sinh: {ngaySinh:dd/MM/yyyy}\n" +
               $"Cung hoàng đạo của bạn là:\n👉 {cung}",
               "Kết quả xác định cung hoàng đạo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }
    }
}
