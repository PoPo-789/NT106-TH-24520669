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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long firstNum, secondNum;

            //Kiểm tra dữ liệu nhập vào có hợp lệ không
            if (!long.TryParse(textBox1.Text, out firstNum))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (!long.TryParse(textBox2.Text, out secondNum))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            //Thực hiện phép tính
            long result = firstNum + secondNum;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Quay về Menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
