namespace Lab02
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btap1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 bai1 = new Lab02_Bai01();
            bai1.Show();
            this.Hide();
        }

        private void btap2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 bai2 = new Lab02_Bai02();
            bai2.Show();
            this.Hide();
        }

        private void btap3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 bai3 = new Lab02_Bai03();
            bai3.Show();
            this.Hide();
        }

        private void btap4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 bai4 = new Lab02_Bai04();
            bai4.Show();
            this.Hide();
        }

        private void btap7_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 bai7 = new Lab02_Bai07();
            bai7.Show();
            this.Hide();
        }

        private void btap5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 bai05 = new Lab02_Bai05();
            bai05.Show();
            this.Hide();
        }

        private void btap6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 bai06 = new Lab02_Bai06();
            bai06.Show();
            this.Hide();
        }
    }
}
