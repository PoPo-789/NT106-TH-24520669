namespace BTTH1

{
    partial class Bai4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHoTen = new Label();
            TB_HT = new TextBox();
            lblPhim = new Label();
            CB_Phim = new ComboBox();
            btnThanhToan = new Button();
            colorDialog1 = new ColorDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            progressBar1 = new ProgressBar();
            chkC5 = new CheckBox();
            chkC4 = new CheckBox();
            chkC3 = new CheckBox();
            chkC2 = new CheckBox();
            chkC1 = new CheckBox();
            chkB5 = new CheckBox();
            chkA1 = new CheckBox();
            chkB4 = new CheckBox();
            chkB3 = new CheckBox();
            chkB2 = new CheckBox();
            chkB1 = new CheckBox();
            chkA5 = new CheckBox();
            chkA4 = new CheckBox();
            chkA3 = new CheckBox();
            chkA2 = new CheckBox();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox29 = new CheckBox();
            checkBox30 = new CheckBox();
            label2 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F);
            lblHoTen.Location = new Point(133, 65);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(150, 28);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Tên khách hàng:";
            // 
            // TB_HT
            // 
            TB_HT.Location = new Point(327, 65);
            TB_HT.Name = "TB_HT";
            TB_HT.Size = new Size(333, 27);
            TB_HT.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 12F);
            lblPhim.Location = new Point(133, 111);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(112, 28);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Chọn phim:";
            // 
            // CB_Phim
            // 
            CB_Phim.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Phim.FormattingEnabled = true;
            CB_Phim.Location = new Point(327, 111);
            CB_Phim.Name = "CB_Phim";
            CB_Phim.Size = new Size(333, 28);
            CB_Phim.TabIndex = 3;
            CB_Phim.SelectedIndexChanged += CB_Phim_SelectedIndexChanged;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(327, 570);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(188, 55);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(133, 190);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598, 365);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(chkC5);
            tabPage1.Controls.Add(chkC4);
            tabPage1.Controls.Add(chkC3);
            tabPage1.Controls.Add(chkC2);
            tabPage1.Controls.Add(chkC1);
            tabPage1.Controls.Add(chkB5);
            tabPage1.Controls.Add(chkA1);
            tabPage1.Controls.Add(chkB4);
            tabPage1.Controls.Add(chkB3);
            tabPage1.Controls.Add(chkB2);
            tabPage1.Controls.Add(chkB1);
            tabPage1.Controls.Add(chkA5);
            tabPage1.Controls.Add(chkA4);
            tabPage1.Controls.Add(chkA3);
            tabPage1.Controls.Add(chkA2);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(590, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phòng 1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(122, 282);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(324, 29);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 9;
            // 
            // chkC5
            // 
            chkC5.AutoSize = true;
            chkC5.Font = new Font("Segoe UI", 12F);
            chkC5.Location = new Point(434, 201);
            chkC5.Name = "chkC5";
            chkC5.Size = new Size(57, 32);
            chkC5.TabIndex = 30;
            chkC5.Text = "C5";
            chkC5.UseVisualStyleBackColor = true;
            // 
            // chkC4
            // 
            chkC4.AutoSize = true;
            chkC4.Font = new Font("Segoe UI", 12F);
            chkC4.Location = new Point(354, 201);
            chkC4.Name = "chkC4";
            chkC4.Size = new Size(57, 32);
            chkC4.TabIndex = 29;
            chkC4.Text = "C4";
            chkC4.UseVisualStyleBackColor = true;
            // 
            // chkC3
            // 
            chkC3.AutoSize = true;
            chkC3.Font = new Font("Segoe UI", 12F);
            chkC3.Location = new Point(271, 201);
            chkC3.Name = "chkC3";
            chkC3.Size = new Size(57, 32);
            chkC3.TabIndex = 28;
            chkC3.Text = "C3";
            chkC3.UseVisualStyleBackColor = true;
            // 
            // chkC2
            // 
            chkC2.AutoSize = true;
            chkC2.Font = new Font("Segoe UI", 12F);
            chkC2.Location = new Point(190, 201);
            chkC2.Name = "chkC2";
            chkC2.Size = new Size(57, 32);
            chkC2.TabIndex = 27;
            chkC2.Text = "C2";
            chkC2.UseVisualStyleBackColor = true;
            // 
            // chkC1
            // 
            chkC1.AutoSize = true;
            chkC1.Font = new Font("Segoe UI", 12F);
            chkC1.Location = new Point(110, 201);
            chkC1.Name = "chkC1";
            chkC1.Size = new Size(57, 32);
            chkC1.TabIndex = 26;
            chkC1.Text = "C1";
            chkC1.UseVisualStyleBackColor = true;
            // 
            // chkB5
            // 
            chkB5.AutoSize = true;
            chkB5.Font = new Font("Segoe UI", 12F);
            chkB5.Location = new Point(434, 149);
            chkB5.Name = "chkB5";
            chkB5.Size = new Size(56, 32);
            chkB5.TabIndex = 25;
            chkB5.Text = "B5";
            chkB5.UseVisualStyleBackColor = true;
            // 
            // chkA1
            // 
            chkA1.AutoSize = true;
            chkA1.Font = new Font("Segoe UI", 12F);
            chkA1.Location = new Point(108, 97);
            chkA1.Name = "chkA1";
            chkA1.Size = new Size(58, 32);
            chkA1.TabIndex = 16;
            chkA1.Text = "A1";
            chkA1.UseVisualStyleBackColor = true;
            // 
            // chkB4
            // 
            chkB4.AutoSize = true;
            chkB4.Font = new Font("Segoe UI", 12F);
            chkB4.Location = new Point(354, 149);
            chkB4.Name = "chkB4";
            chkB4.Size = new Size(56, 32);
            chkB4.TabIndex = 24;
            chkB4.Text = "B4";
            chkB4.UseVisualStyleBackColor = true;
            // 
            // chkB3
            // 
            chkB3.AutoSize = true;
            chkB3.Font = new Font("Segoe UI", 12F);
            chkB3.Location = new Point(271, 149);
            chkB3.Name = "chkB3";
            chkB3.Size = new Size(56, 32);
            chkB3.TabIndex = 23;
            chkB3.Text = "B3";
            chkB3.UseVisualStyleBackColor = true;
            // 
            // chkB2
            // 
            chkB2.AutoSize = true;
            chkB2.Font = new Font("Segoe UI", 12F);
            chkB2.Location = new Point(190, 149);
            chkB2.Name = "chkB2";
            chkB2.Size = new Size(56, 32);
            chkB2.TabIndex = 22;
            chkB2.Text = "B2";
            chkB2.UseVisualStyleBackColor = true;
            // 
            // chkB1
            // 
            chkB1.AutoSize = true;
            chkB1.Font = new Font("Segoe UI", 12F);
            chkB1.Location = new Point(110, 149);
            chkB1.Name = "chkB1";
            chkB1.Size = new Size(56, 32);
            chkB1.TabIndex = 21;
            chkB1.Text = "B1";
            chkB1.UseVisualStyleBackColor = true;
            // 
            // chkA5
            // 
            chkA5.AutoSize = true;
            chkA5.Font = new Font("Segoe UI", 12F);
            chkA5.Location = new Point(434, 97);
            chkA5.Name = "chkA5";
            chkA5.Size = new Size(58, 32);
            chkA5.TabIndex = 20;
            chkA5.Text = "A5";
            chkA5.UseVisualStyleBackColor = true;
            // 
            // chkA4
            // 
            chkA4.AutoSize = true;
            chkA4.Font = new Font("Segoe UI", 12F);
            chkA4.Location = new Point(354, 97);
            chkA4.Name = "chkA4";
            chkA4.Size = new Size(58, 32);
            chkA4.TabIndex = 19;
            chkA4.Text = "A4";
            chkA4.UseVisualStyleBackColor = true;
            // 
            // chkA3
            // 
            chkA3.AutoSize = true;
            chkA3.Font = new Font("Segoe UI", 12F);
            chkA3.Location = new Point(271, 97);
            chkA3.Name = "chkA3";
            chkA3.Size = new Size(58, 32);
            chkA3.TabIndex = 18;
            chkA3.Text = "A3";
            chkA3.UseVisualStyleBackColor = true;
            // 
            // chkA2
            // 
            chkA2.AutoSize = true;
            chkA2.Font = new Font("Segoe UI", 12F);
            chkA2.Location = new Point(190, 97);
            chkA2.Name = "chkA2";
            chkA2.Size = new Size(58, 32);
            chkA2.TabIndex = 17;
            chkA2.Text = "A2";
            chkA2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(checkBox3);
            tabPage2.Controls.Add(checkBox4);
            tabPage2.Controls.Add(checkBox5);
            tabPage2.Controls.Add(checkBox6);
            tabPage2.Controls.Add(checkBox7);
            tabPage2.Controls.Add(checkBox8);
            tabPage2.Controls.Add(checkBox9);
            tabPage2.Controls.Add(checkBox10);
            tabPage2.Controls.Add(checkBox11);
            tabPage2.Controls.Add(checkBox12);
            tabPage2.Controls.Add(checkBox13);
            tabPage2.Controls.Add(checkBox14);
            tabPage2.Controls.Add(checkBox15);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Phòng 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(428, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 32);
            checkBox1.TabIndex = 45;
            checkBox1.Text = "C5";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F);
            checkBox2.Location = new Point(348, 202);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(57, 32);
            checkBox2.TabIndex = 44;
            checkBox2.Text = "C4";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F);
            checkBox3.Location = new Point(265, 202);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 32);
            checkBox3.TabIndex = 43;
            checkBox3.Text = "C3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F);
            checkBox4.Location = new Point(184, 202);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(57, 32);
            checkBox4.TabIndex = 42;
            checkBox4.Text = "C2";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 12F);
            checkBox5.Location = new Point(104, 202);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(57, 32);
            checkBox5.TabIndex = 41;
            checkBox5.Text = "C1";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 12F);
            checkBox6.Location = new Point(428, 150);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(56, 32);
            checkBox6.TabIndex = 40;
            checkBox6.Text = "B5";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 12F);
            checkBox7.Location = new Point(348, 150);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(56, 32);
            checkBox7.TabIndex = 39;
            checkBox7.Text = "B4";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 12F);
            checkBox8.Location = new Point(265, 150);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(56, 32);
            checkBox8.TabIndex = 38;
            checkBox8.Text = "B3";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Segoe UI", 12F);
            checkBox9.Location = new Point(184, 150);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(56, 32);
            checkBox9.TabIndex = 37;
            checkBox9.Text = "B2";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("Segoe UI", 12F);
            checkBox10.Location = new Point(104, 150);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(56, 32);
            checkBox10.TabIndex = 36;
            checkBox10.Text = "B1";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Font = new Font("Segoe UI", 12F);
            checkBox11.Location = new Point(428, 98);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(58, 32);
            checkBox11.TabIndex = 35;
            checkBox11.Text = "A5";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Font = new Font("Segoe UI", 12F);
            checkBox12.Location = new Point(348, 98);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(58, 32);
            checkBox12.TabIndex = 34;
            checkBox12.Text = "A4";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Font = new Font("Segoe UI", 12F);
            checkBox13.Location = new Point(265, 98);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(58, 32);
            checkBox13.TabIndex = 33;
            checkBox13.Text = "A3";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Font = new Font("Segoe UI", 12F);
            checkBox14.Location = new Point(184, 98);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(58, 32);
            checkBox14.TabIndex = 32;
            checkBox14.Text = "A2";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Font = new Font("Segoe UI", 12F);
            checkBox15.Location = new Point(104, 98);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(58, 32);
            checkBox15.TabIndex = 31;
            checkBox15.Text = "A1";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 16);
            label1.Name = "label1";
            label1.Size = new Size(434, 34);
            label1.TabIndex = 9;
            label1.Text = "SCREEN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBox16);
            tabPage3.Controls.Add(checkBox17);
            tabPage3.Controls.Add(checkBox18);
            tabPage3.Controls.Add(checkBox19);
            tabPage3.Controls.Add(checkBox20);
            tabPage3.Controls.Add(checkBox21);
            tabPage3.Controls.Add(checkBox22);
            tabPage3.Controls.Add(checkBox23);
            tabPage3.Controls.Add(checkBox24);
            tabPage3.Controls.Add(checkBox25);
            tabPage3.Controls.Add(checkBox26);
            tabPage3.Controls.Add(checkBox27);
            tabPage3.Controls.Add(checkBox28);
            tabPage3.Controls.Add(checkBox29);
            tabPage3.Controls.Add(checkBox30);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(590, 332);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Phòng 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Font = new Font("Segoe UI", 12F);
            checkBox16.Location = new Point(428, 202);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(57, 32);
            checkBox16.TabIndex = 45;
            checkBox16.Text = "C5";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Font = new Font("Segoe UI", 12F);
            checkBox17.Location = new Point(348, 202);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(57, 32);
            checkBox17.TabIndex = 44;
            checkBox17.Text = "C4";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Font = new Font("Segoe UI", 12F);
            checkBox18.Location = new Point(265, 202);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(57, 32);
            checkBox18.TabIndex = 43;
            checkBox18.Text = "C3";
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Font = new Font("Segoe UI", 12F);
            checkBox19.Location = new Point(184, 202);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(57, 32);
            checkBox19.TabIndex = 42;
            checkBox19.Text = "C2";
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Font = new Font("Segoe UI", 12F);
            checkBox20.Location = new Point(104, 202);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(57, 32);
            checkBox20.TabIndex = 41;
            checkBox20.Text = "C1";
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Font = new Font("Segoe UI", 12F);
            checkBox21.Location = new Point(428, 150);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(56, 32);
            checkBox21.TabIndex = 40;
            checkBox21.Text = "B5";
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Font = new Font("Segoe UI", 12F);
            checkBox22.Location = new Point(348, 150);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(56, 32);
            checkBox22.TabIndex = 39;
            checkBox22.Text = "B4";
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Font = new Font("Segoe UI", 12F);
            checkBox23.Location = new Point(265, 150);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(56, 32);
            checkBox23.TabIndex = 38;
            checkBox23.Text = "B3";
            checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Font = new Font("Segoe UI", 12F);
            checkBox24.Location = new Point(184, 150);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(56, 32);
            checkBox24.TabIndex = 37;
            checkBox24.Text = "B2";
            checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            checkBox25.AutoSize = true;
            checkBox25.Font = new Font("Segoe UI", 12F);
            checkBox25.Location = new Point(104, 150);
            checkBox25.Name = "checkBox25";
            checkBox25.Size = new Size(56, 32);
            checkBox25.TabIndex = 36;
            checkBox25.Text = "B1";
            checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            checkBox26.AutoSize = true;
            checkBox26.Font = new Font("Segoe UI", 12F);
            checkBox26.Location = new Point(428, 98);
            checkBox26.Name = "checkBox26";
            checkBox26.Size = new Size(58, 32);
            checkBox26.TabIndex = 35;
            checkBox26.Text = "A5";
            checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            checkBox27.AutoSize = true;
            checkBox27.Font = new Font("Segoe UI", 12F);
            checkBox27.Location = new Point(348, 98);
            checkBox27.Name = "checkBox27";
            checkBox27.Size = new Size(58, 32);
            checkBox27.TabIndex = 34;
            checkBox27.Text = "A4";
            checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            checkBox28.AutoSize = true;
            checkBox28.Font = new Font("Segoe UI", 12F);
            checkBox28.Location = new Point(265, 98);
            checkBox28.Name = "checkBox28";
            checkBox28.Size = new Size(58, 32);
            checkBox28.TabIndex = 33;
            checkBox28.Text = "A3";
            checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            checkBox29.AutoSize = true;
            checkBox29.Font = new Font("Segoe UI", 12F);
            checkBox29.Location = new Point(184, 98);
            checkBox29.Name = "checkBox29";
            checkBox29.Size = new Size(58, 32);
            checkBox29.TabIndex = 32;
            checkBox29.Text = "A2";
            checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            checkBox30.AutoSize = true;
            checkBox30.Font = new Font("Segoe UI", 12F);
            checkBox30.Location = new Point(104, 98);
            checkBox30.Name = "checkBox30";
            checkBox30.Size = new Size(58, 32);
            checkBox30.TabIndex = 31;
            checkBox30.Text = "A1";
            checkBox30.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 17);
            label2.Name = "label2";
            label2.Size = new Size(434, 34);
            label2.TabIndex = 10;
            label2.Text = "SCREEN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 19);
            label4.Name = "label4";
            label4.Size = new Size(434, 34);
            label4.TabIndex = 0;
            label4.Text = "SCREEN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 639);
            Controls.Add(tabControl1);
            Controls.Add(btnThanhToan);
            Controls.Add(CB_Phim);
            Controls.Add(lblPhim);
            Controls.Add(TB_HT);
            Controls.Add(lblHoTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Bán Vé Xem Phim";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox TB_HT;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox CB_Phim;
        private System.Windows.Forms.Button btnThanhToan;
        private ColorDialog colorDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TabPage tabPage3;
        private Label label2;
        private CheckBox chkC5;
        private CheckBox chkC4;
        private CheckBox chkC3;
        private CheckBox chkC2;
        private CheckBox chkC1;
        private CheckBox chkB5;
        private CheckBox chkB4;
        private CheckBox chkB3;
        private CheckBox chkB2;
        private CheckBox chkB1;
        private CheckBox chkA5;
        private CheckBox chkA4;
        private CheckBox chkA3;
        private CheckBox chkA2;
        private CheckBox chkA1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private CheckBox checkBox30;
        private ProgressBar progressBar1;
        private Label label4;
    }
}