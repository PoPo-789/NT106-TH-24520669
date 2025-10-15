namespace Lab01
{
    partial class MENU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button3_1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            label1 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Font = new Font("Segoe UI", 16F);
            bt1.Location = new Point(140, 127);
            bt1.Name = "bt1";
            bt1.Size = new Size(139, 55);
            bt1.TabIndex = 0;
            bt1.Text = "Bài tập 1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(140, 264);
            button2.Name = "button2";
            button2.Size = new Size(139, 55);
            button2.TabIndex = 0;
            button2.Text = "Bài tập 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(140, 394);
            button3.Name = "button3";
            button3.Size = new Size(139, 55);
            button3.TabIndex = 1;
            button3.Text = "Bài tập 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button3_1
            // 
            button3_1.Font = new Font("Segoe UI", 16F);
            button3_1.Location = new Point(408, 127);
            button3_1.Name = "button3_1";
            button3_1.Size = new Size(161, 55);
            button3_1.TabIndex = 2;
            button3_1.Text = "Bài tập 3.1";
            button3_1.UseVisualStyleBackColor = true;
            button3_1.Click += button3_1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F);
            button5.Location = new Point(408, 394);
            button5.Name = "button5";
            button5.Size = new Size(139, 55);
            button5.TabIndex = 3;
            button5.Text = "Bài tập 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(717, 127);
            button6.Name = "button6";
            button6.Size = new Size(139, 55);
            button6.TabIndex = 4;
            button6.Text = "Bài tập 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(717, 264);
            button1.Name = "button1";
            button1.Size = new Size(139, 55);
            button1.TabIndex = 5;
            button1.Text = "Bài tập 7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(905, 81);
            label1.TabIndex = 6;
            label1.Text = "LAB_01_NT106 - LÊ QUANG HUY";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16F);
            button8.Location = new Point(717, 394);
            button8.Name = "button8";
            button8.Size = new Size(139, 55);
            button8.TabIndex = 5;
            button8.Text = "Bài tập 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3_1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bt1);
            Name = "MENU";
            Text = "MENU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1;
        private Button button2;
        private Button button3;
        private Button button3_1;
        private Button button5;
        private Button button6;
        private Button button1;
        private Label label1;
        private Button button8;
    }
}
