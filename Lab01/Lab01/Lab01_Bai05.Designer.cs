namespace Lab01
{
    partial class Lab01_Bai05
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(296, 22);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 0;
            label1.Text = "Tính toán theo yêu cầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ nhất (A):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(497, 137);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 1;
            label3.Text = "Nhập số thứ hai (B):";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(148, 215);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 1;
            label4.Text = "Lựa chọn:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(280, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 34);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán các giá trị" });
            comboBox1.Location = new Point(280, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 36);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 342);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(938, 203);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(736, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 34);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(118, 279);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 5;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(428, 279);
            button2.Name = "button2";
            button2.Size = new Size(146, 43);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(736, 279);
            button3.Name = "button3";
            button3.Size = new Size(146, 43);
            button3.TabIndex = 5;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai05";
            Text = "Tính toán theo yêu cầu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}