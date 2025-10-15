namespace Lab01
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 lab01_Bai01 = new Lab01_Bai01();
            lab01_Bai01.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 lab01_Bai02 = new Lab01_Bai02();
            lab01_Bai02.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 lab01_Bai03 = new Lab01_Bai03();
            lab01_Bai03.Show();
            this.Hide();
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            Lab01_Bai03_1 lab01_Bai03_1 = new Lab01_Bai03_1();
            lab01_Bai03_1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 lab01_Bai05 = new Lab01_Bai05();
            lab01_Bai05.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 lab01_Bai06 = new Lab01_Bai06();
            lab01_Bai06.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 lab01_Bai07 = new Lab01_Bai07();
            lab01_Bai07.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 lab01_Bai08 = new Lab01_Bai08();
            lab01_Bai08.Show();
            this.Hide();
        }
    }
}
