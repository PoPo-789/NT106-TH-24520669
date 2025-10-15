namespace Lab01
{
    partial class Lab01_Bai08
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
            lb_Food_Input = new Label();
            tb_Food_Input = new TextBox();
            tb_List_Food = new TextBox();
            btn_Add = new Button();
            btn_Find_Food = new Button();
            btn_Clear = new Button();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 46);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // lb_Food_Input
            // 
            lb_Food_Input.AutoSize = true;
            lb_Food_Input.Font = new Font("Segoe UI", 14F);
            lb_Food_Input.Location = new Point(12, 76);
            lb_Food_Input.Name = "lb_Food_Input";
            lb_Food_Input.Size = new Size(161, 32);
            lb_Food_Input.TabIndex = 1;
            lb_Food_Input.Text = "Nhập món ăn";
            // 
            // tb_Food_Input
            // 
            tb_Food_Input.Font = new Font("Segoe UI", 12F);
            tb_Food_Input.Location = new Point(196, 76);
            tb_Food_Input.Name = "tb_Food_Input";
            tb_Food_Input.Size = new Size(304, 34);
            tb_Food_Input.TabIndex = 2;
            tb_Food_Input.TextChanged += textBox1_TextChanged;
            // 
            // tb_List_Food
            // 
            tb_List_Food.Location = new Point(522, 76);
            tb_List_Food.Multiline = true;
            tb_List_Food.Name = "tb_List_Food";
            tb_List_Food.ReadOnly = true;
            tb_List_Food.ScrollBars = ScrollBars.Vertical;
            tb_List_Food.Size = new Size(404, 262);
            tb_List_Food.TabIndex = 2;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 14F);
            btn_Add.Location = new Point(355, 141);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(145, 50);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Find_Food
            // 
            btn_Find_Food.Font = new Font("Segoe UI", 14F);
            btn_Find_Food.Location = new Point(99, 413);
            btn_Find_Food.Name = "btn_Find_Food";
            btn_Find_Food.Size = new Size(145, 50);
            btn_Find_Food.TabIndex = 3;
            btn_Find_Food.Text = "Tìm món";
            btn_Find_Food.UseVisualStyleBackColor = true;
            btn_Find_Food.Click += btn_Find_Food_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI", 14F);
            btn_Clear.Location = new Point(405, 413);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(145, 50);
            btn_Clear.TabIndex = 3;
            btn_Clear.Text = "Xóa";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 14F);
            btn_Close.Location = new Point(737, 413);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(145, 50);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Thoát";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(btn_Close);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Find_Food);
            Controls.Add(btn_Add);
            Controls.Add(tb_List_Food);
            Controls.Add(tb_Food_Input);
            Controls.Add(lb_Food_Input);
            Controls.Add(label1);
            Name = "Lab01_Bai08";
            Text = "Hôm nay ăn gì?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_Food_Input;
        private TextBox tb_Food_Input;
        private TextBox tb_List_Food;
        private Button btn_Add;
        private Button btn_Find_Food;
        private Button btn_Clear;
        private Button btn_Close;
    }
}