namespace Lab01
{
    partial class Lab01_Bai07
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
            nhap = new TextBox();
            tbm = new TextBox();
            max = new TextBox();
            min = new TextBox();
            xeploai = new TextBox();
            dau = new TextBox();
            rot = new TextBox();
            diem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            hoten = new TextBox();
            label5 = new Label();
            ui = new Label();
            label100 = new Label();
            ưq = new Label();
            rưq = new Label();
            yu = new Label();
            tinh = new Button();
            xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(341, 25);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 0;
            label1.Text = "Mảng tổng hợp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(121, 109);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên SV + Điểm: ";
            label2.Click += label2_Click;
            // 
            // nhap
            // 
            nhap.Font = new Font("Segoe UI", 12F);
            nhap.Location = new Point(313, 107);
            nhap.Name = "nhap";
            nhap.Size = new Size(352, 34);
            nhap.TabIndex = 2;
            // 
            // tbm
            // 
            tbm.Font = new Font("Segoe UI", 12F);
            tbm.Location = new Point(662, 240);
            tbm.Name = "tbm";
            tbm.ReadOnly = true;
            tbm.Size = new Size(243, 34);
            tbm.TabIndex = 2;
            // 
            // max
            // 
            max.Font = new Font("Segoe UI", 12F);
            max.Location = new Point(205, 328);
            max.Name = "max";
            max.ReadOnly = true;
            max.Size = new Size(243, 34);
            max.TabIndex = 2;
            // 
            // min
            // 
            min.Font = new Font("Segoe UI", 12F);
            min.Location = new Point(662, 329);
            min.Name = "min";
            min.ReadOnly = true;
            min.Size = new Size(243, 34);
            min.TabIndex = 2;
            // 
            // xeploai
            // 
            xeploai.Font = new Font("Segoe UI", 12F);
            xeploai.Location = new Point(402, 492);
            xeploai.Name = "xeploai";
            xeploai.ReadOnly = true;
            xeploai.Size = new Size(243, 34);
            xeploai.TabIndex = 2;
            // 
            // dau
            // 
            dau.Font = new Font("Segoe UI", 12F);
            dau.Location = new Point(205, 429);
            dau.Name = "dau";
            dau.ReadOnly = true;
            dau.Size = new Size(243, 34);
            dau.TabIndex = 2;
            // 
            // rot
            // 
            rot.Font = new Font("Segoe UI", 12F);
            rot.Location = new Point(662, 429);
            rot.Name = "rot";
            rot.ReadOnly = true;
            rot.Size = new Size(243, 34);
            rot.TabIndex = 2;
            rot.TextChanged += textBox8_TextChanged;
            // 
            // diem
            // 
            diem.Font = new Font("Segoe UI", 12F);
            diem.Location = new Point(205, 240);
            diem.Name = "diem";
            diem.ReadOnly = true;
            diem.Size = new Size(312, 34);
            diem.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(89, 174);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 3;
            label3.Text = "Họ và tên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(89, 330);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 3;
            label4.Text = "Cao nhất";
            label4.Click += label3_Click;
            // 
            // hoten
            // 
            hoten.Font = new Font("Segoe UI", 12F);
            hoten.Location = new Point(205, 174);
            hoten.Name = "hoten";
            hoten.ReadOnly = true;
            hoten.Size = new Size(243, 34);
            hoten.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(89, 242);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 3;
            label5.Text = "Điểm";
            label5.Click += label3_Click;
            // 
            // ui
            // 
            ui.AutoSize = true;
            ui.Font = new Font("Segoe UI", 14F);
            ui.Location = new Point(523, 330);
            ui.Name = "ui";
            ui.Size = new Size(122, 32);
            ui.TabIndex = 3;
            ui.Text = "Thấp nhất";
            ui.Click += label3_Click;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI", 14F);
            label100.Location = new Point(523, 240);
            label100.Name = "label100";
            label100.Size = new Size(63, 32);
            label100.TabIndex = 3;
            label100.Text = "TBM";
            label100.Click += label3_Click;
            // 
            // ưq
            // 
            ưq.AutoSize = true;
            ưq.Font = new Font("Segoe UI", 14F);
            ưq.Location = new Point(89, 429);
            ưq.Name = "ưq";
            ưq.Size = new Size(57, 32);
            ưq.TabIndex = 3;
            ưq.Text = "Đậu";
            ưq.Click += label3_Click;
            // 
            // rưq
            // 
            rưq.AutoSize = true;
            rưq.Font = new Font("Segoe UI", 14F);
            rưq.Location = new Point(523, 431);
            rưq.Name = "rưq";
            rưq.Size = new Size(50, 32);
            rưq.TabIndex = 3;
            rưq.Text = "Rớt";
            rưq.Click += label3_Click;
            // 
            // yu
            // 
            yu.AutoSize = true;
            yu.Font = new Font("Segoe UI", 14F);
            yu.Location = new Point(271, 493);
            yu.Name = "yu";
            yu.Size = new Size(100, 32);
            yu.TabIndex = 3;
            yu.Text = "Xếp loại";
            yu.Click += label3_Click;
            // 
            // tinh
            // 
            tinh.Font = new Font("Segoe UI", 14F);
            tinh.Location = new Point(617, 169);
            tinh.Name = "tinh";
            tinh.Size = new Size(111, 41);
            tinh.TabIndex = 4;
            tinh.Text = "Tính";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // xoa
            // 
            xoa.Font = new Font("Segoe UI", 14F);
            xoa.Location = new Point(794, 170);
            xoa.Name = "xoa";
            xoa.Size = new Size(111, 41);
            xoa.TabIndex = 4;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 14F);
            thoat.Location = new Point(752, 480);
            thoat.Name = "thoat";
            thoat.Size = new Size(119, 49);
            thoat.TabIndex = 4;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tinh);
            Controls.Add(label5);
            Controls.Add(yu);
            Controls.Add(rưq);
            Controls.Add(ưq);
            Controls.Add(label100);
            Controls.Add(ui);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rot);
            Controls.Add(dau);
            Controls.Add(xeploai);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(hoten);
            Controls.Add(tbm);
            Controls.Add(diem);
            Controls.Add(nhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai07";
            Text = "Họ và tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nhap;
        private TextBox tbm;
        private TextBox max;
        private TextBox min;
        private TextBox xeploai;
        private TextBox dau;
        private TextBox rot;
        private TextBox diem;
        private Label label3;
        private Label label4;
        private TextBox hoten;
        private Label label5;
        private Label ui;
        private Label label100;
        private Label ưq;
        private Label rưq;
        private Label yu;
        private Button tinh;
        private Button xoa;
        private Button thoat;
    }
}