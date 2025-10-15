namespace Lab01
{
    partial class Lab01_Bai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(441, 46);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất và bé nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(25, 171);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(345, 171);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 1;
            label3.Text = "Số thứ hai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(647, 171);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 1;
            label4.Text = "Số thứ ba";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(138, 442);
            label5.Name = "label5";
            label5.Size = new Size(137, 32);
            label5.TabIndex = 1;
            label5.Text = "Số lớn nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(531, 442);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 1;
            label6.Text = "Số nhỏ nhất";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(170, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(474, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 34);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(770, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(293, 442);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(151, 34);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(704, 442);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(151, 34);
            textBox5.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(181, 307);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 3;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(417, 307);
            button2.Name = "button2";
            button2.Size = new Size(136, 52);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(647, 307);
            button4.Name = "button4";
            button4.Size = new Size(136, 52);
            button4.TabIndex = 3;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "Lab01_Bai02";
            Text = "Số lớn nhất, nhỏ nhất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}