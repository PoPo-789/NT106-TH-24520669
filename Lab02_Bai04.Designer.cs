namespace Lab02
{
    partial class Lab02_Bai04
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
            rtb = new RichTextBox();
            btn_Write = new Button();
            btn_Read = new Button();
            btn_Add = new Button();
            btn_Next = new Button();
            btn_Back = new Button();
            tb_Name_Write = new TextBox();
            tb_ID_Write = new TextBox();
            tb_Phone_Write = new TextBox();
            tb_Course1_Write = new TextBox();
            tb_Course2_Write = new TextBox();
            tb_Course3_Write = new TextBox();
            tb_Average_Write = new TextBox();
            tb_Name_Read = new TextBox();
            tb_ID_Read = new TextBox();
            tb_Phone_Read = new TextBox();
            tb_Course1_Read = new TextBox();
            tb_Course2_Read = new TextBox();
            tb_Course3_Read = new TextBox();
            tb_Average_Read = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            btn_Exit = new Button();
            lb_Page = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(863, 62);
            label1.TabIndex = 0;
            label1.Text = " Đọc và Ghi file sử dụng JsonSerializer\r\n";
            // 
            // rtb
            // 
            rtb.Location = new Point(330, 91);
            rtb.Name = "rtb";
            rtb.Size = new Size(310, 460);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // btn_Write
            // 
            btn_Write.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Write.Location = new Point(102, 91);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(120, 51);
            btn_Write.TabIndex = 2;
            btn_Write.Text = "WRITE";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(745, 91);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(120, 51);
            btn_Read.TabIndex = 2;
            btn_Read.Text = "READ";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(12, 499);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(120, 51);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Next
            // 
            btn_Next.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Next.Location = new Point(823, 512);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(94, 32);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "NEXT";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Back.Location = new Point(695, 512);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 32);
            btn_Back.TabIndex = 2;
            btn_Back.Text = "BACK";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_Name_Write
            // 
            tb_Name_Write.Location = new Point(113, 165);
            tb_Name_Write.Name = "tb_Name_Write";
            tb_Name_Write.ReadOnly = true;
            tb_Name_Write.Size = new Size(201, 27);
            tb_Name_Write.TabIndex = 3;
            tb_Name_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_ID_Write
            // 
            tb_ID_Write.Location = new Point(113, 214);
            tb_ID_Write.Name = "tb_ID_Write";
            tb_ID_Write.ReadOnly = true;
            tb_ID_Write.Size = new Size(201, 27);
            tb_ID_Write.TabIndex = 3;
            tb_ID_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Phone_Write
            // 
            tb_Phone_Write.Location = new Point(113, 259);
            tb_Phone_Write.Name = "tb_Phone_Write";
            tb_Phone_Write.ReadOnly = true;
            tb_Phone_Write.Size = new Size(201, 27);
            tb_Phone_Write.TabIndex = 3;
            tb_Phone_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course1_Write
            // 
            tb_Course1_Write.Location = new Point(113, 308);
            tb_Course1_Write.Name = "tb_Course1_Write";
            tb_Course1_Write.ReadOnly = true;
            tb_Course1_Write.Size = new Size(201, 27);
            tb_Course1_Write.TabIndex = 3;
            tb_Course1_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course2_Write
            // 
            tb_Course2_Write.Location = new Point(113, 358);
            tb_Course2_Write.Name = "tb_Course2_Write";
            tb_Course2_Write.ReadOnly = true;
            tb_Course2_Write.Size = new Size(201, 27);
            tb_Course2_Write.TabIndex = 3;
            tb_Course2_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course3_Write
            // 
            tb_Course3_Write.Location = new Point(113, 408);
            tb_Course3_Write.Name = "tb_Course3_Write";
            tb_Course3_Write.ReadOnly = true;
            tb_Course3_Write.Size = new Size(201, 27);
            tb_Course3_Write.TabIndex = 3;
            tb_Course3_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Average_Write
            // 
            tb_Average_Write.Location = new Point(113, 457);
            tb_Average_Write.Name = "tb_Average_Write";
            tb_Average_Write.ReadOnly = true;
            tb_Average_Write.Size = new Size(201, 27);
            tb_Average_Write.TabIndex = 3;
            tb_Average_Write.TextChanged += textBox1_TextChanged;
            // 
            // tb_Name_Read
            // 
            tb_Name_Read.Location = new Point(762, 165);
            tb_Name_Read.Name = "tb_Name_Read";
            tb_Name_Read.ReadOnly = true;
            tb_Name_Read.Size = new Size(201, 27);
            tb_Name_Read.TabIndex = 3;
            tb_Name_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_ID_Read
            // 
            tb_ID_Read.Location = new Point(762, 214);
            tb_ID_Read.Name = "tb_ID_Read";
            tb_ID_Read.ReadOnly = true;
            tb_ID_Read.Size = new Size(201, 27);
            tb_ID_Read.TabIndex = 3;
            tb_ID_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_Phone_Read
            // 
            tb_Phone_Read.Location = new Point(762, 259);
            tb_Phone_Read.Name = "tb_Phone_Read";
            tb_Phone_Read.ReadOnly = true;
            tb_Phone_Read.Size = new Size(201, 27);
            tb_Phone_Read.TabIndex = 3;
            tb_Phone_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course1_Read
            // 
            tb_Course1_Read.Location = new Point(762, 308);
            tb_Course1_Read.Name = "tb_Course1_Read";
            tb_Course1_Read.ReadOnly = true;
            tb_Course1_Read.Size = new Size(201, 27);
            tb_Course1_Read.TabIndex = 3;
            tb_Course1_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course2_Read
            // 
            tb_Course2_Read.Location = new Point(762, 358);
            tb_Course2_Read.Name = "tb_Course2_Read";
            tb_Course2_Read.ReadOnly = true;
            tb_Course2_Read.Size = new Size(201, 27);
            tb_Course2_Read.TabIndex = 3;
            tb_Course2_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_Course3_Read
            // 
            tb_Course3_Read.Location = new Point(762, 408);
            tb_Course3_Read.Name = "tb_Course3_Read";
            tb_Course3_Read.ReadOnly = true;
            tb_Course3_Read.Size = new Size(201, 27);
            tb_Course3_Read.TabIndex = 3;
            tb_Course3_Read.TextChanged += textBox1_TextChanged;
            // 
            // tb_Average_Read
            // 
            tb_Average_Read.Location = new Point(762, 457);
            tb_Average_Read.Name = "tb_Average_Read";
            tb_Average_Read.ReadOnly = true;
            tb_Average_Read.Size = new Size(201, 27);
            tb_Average_Read.TabIndex = 3;
            tb_Average_Read.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(28, 23);
            label3.TabIndex = 5;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleTurquoise;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleTurquoise;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 5;
            label5.Text = "Course 1";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PaleTurquoise;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 359);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Course 2";
            label6.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PaleTurquoise;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 409);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 5;
            label7.Text = "Course 3";
            label7.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 459);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 5;
            label8.Text = "Average";
            label8.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PaleTurquoise;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(672, 166);
            label9.Name = "label9";
            label9.Size = new Size(57, 23);
            label9.TabIndex = 5;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.PaleTurquoise;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(672, 214);
            label10.Name = "label10";
            label10.Size = new Size(28, 23);
            label10.TabIndex = 5;
            label10.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.PaleTurquoise;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(672, 259);
            label11.Name = "label11";
            label11.Size = new Size(59, 23);
            label11.TabIndex = 5;
            label11.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.PaleTurquoise;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(672, 308);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 5;
            label12.Text = "Course 1";
            label12.Click += label5_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.PaleTurquoise;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(672, 358);
            label13.Name = "label13";
            label13.Size = new Size(79, 23);
            label13.TabIndex = 5;
            label13.Text = "Course 2";
            label13.Click += label5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.PaleTurquoise;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(672, 408);
            label14.Name = "label14";
            label14.Size = new Size(79, 23);
            label14.TabIndex = 5;
            label14.Text = "Course 3";
            label14.Click += label5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.PaleTurquoise;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(672, 458);
            label15.Name = "label15";
            label15.Size = new Size(76, 23);
            label15.TabIndex = 5;
            label15.Text = "Average";
            label15.Click += label5_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(194, 500);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(120, 51);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Font = new Font("Segoe UI", 11F);
            lb_Page.Location = new Point(795, 514);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(22, 25);
            lb_Page.TabIndex = 6;
            lb_Page.Text = "1";
            // 
            // Lab02_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(965, 582);
            Controls.Add(lb_Page);
            Controls.Add(label15);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_Average_Read);
            Controls.Add(tb_Average_Write);
            Controls.Add(tb_Course3_Read);
            Controls.Add(tb_Course3_Write);
            Controls.Add(tb_Course2_Read);
            Controls.Add(tb_Course2_Write);
            Controls.Add(tb_Course1_Read);
            Controls.Add(tb_Course1_Write);
            Controls.Add(tb_Phone_Read);
            Controls.Add(tb_Phone_Write);
            Controls.Add(tb_ID_Read);
            Controls.Add(tb_Name_Read);
            Controls.Add(tb_ID_Write);
            Controls.Add(tb_Name_Write);
            Controls.Add(btn_Read);
            Controls.Add(btn_Back);
            Controls.Add(btn_Next);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Add);
            Controls.Add(btn_Write);
            Controls.Add(rtb);
            Controls.Add(label1);
            Name = "Lab02_Bai04";
            Text = "Lab02_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtb;
        private Button btn_Write;
        private Button btn_Read;
        private Button btn_Add;
        private Button btn_Next;
        private Button btn_Back;
        private TextBox tb_Name_Write;
        private TextBox tb_ID_Write;
        private TextBox tb_Phone_Write;
        private TextBox tb_Course1_Write;
        private TextBox tb_Course2_Write;
        private TextBox tb_Course3_Write;
        private TextBox tb_Average_Write;
        private TextBox tb_Name_Read;
        private TextBox tb_ID_Read;
        private TextBox tb_Phone_Read;
        private TextBox tb_Course1_Read;
        private TextBox tb_Course2_Read;
        private TextBox tb_Course3_Read;
        private TextBox tb_Average_Read;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btn_Exit;
        private Label lb_Page;
    }
}