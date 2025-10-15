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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        List<string> foods = new List<string>() { };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            UpdateFoodListDisplay();
        }

        // Nút "Thêm"
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string newFood = tb_Food_Input.Text.Trim();

            if (string.IsNullOrEmpty(newFood))
            {
                MessageBox.Show("Vui lòng nhập món ăn!");
                return;
            }

            // Kiểm tra trùng món
            if (foods.Contains(newFood, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Món này đã có trong danh sách!");
                return;
            }

            foods.Add(newFood);
            UpdateFoodListDisplay();
            tb_Food_Input.Clear();
        }

        // Cập nhật danh sách hiển thị
        private void UpdateFoodListDisplay()
        {
            tb_List_Food.Clear();
            foreach (string food in foods)
            {
                tb_List_Food.AppendText(food + Environment.NewLine);
            }
        }

        // Nút "Tìm món ăn" (chọn ngẫu nhiên)
        private void btn_Find_Food_Click(object sender, EventArgs e)
        {
            if (foods.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!");
                return;
            }

            Random rand = new Random();
            int index = rand.Next(foods.Count);
            string todayFood = foods[index];

            MessageBox.Show($"Hôm nay bạn nên ăn: {todayFood}", "Kết quả");
        }

        // Nút "Xóa"
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Food_Input.Clear();
            tb_List_Food.Clear();
            foods.Clear();
        }

        // Nút "Thoát"
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
