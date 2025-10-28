namespace Lab02
{
    partial class Lab02_Bai02
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
            btnRead = new Button();
            lbName = new Label();
            lbSize = new Label();
            lbURL = new Label();
            lbLineCnt = new Label();
            lbWordCnt = new Label();
            lbCharCnt = new Label();
            btnExit = new Button();
            tbName = new TextBox();
            tbSize = new TextBox();
            tbURL = new TextBox();
            tbLineCnt = new TextBox();
            tbWordCnt = new TextBox();
            tbCharCnt = new TextBox();
            rtbOut = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(516, 62);
            label1.TabIndex = 0;
            label1.Text = "Đọc thông tin một file";
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(25, 123);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(384, 32);
            btnRead.TabIndex = 1;
            btnRead.Text = " Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(25, 194);
            lbName.Name = "lbName";
            lbName.Size = new Size(84, 23);
            lbName.TabIndex = 2;
            lbName.Text = "File name";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSize.Location = new Point(25, 244);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(40, 23);
            lbSize.TabIndex = 2;
            lbSize.Text = "Size";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbURL.Location = new Point(25, 295);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(41, 23);
            lbURL.TabIndex = 2;
            lbURL.Text = "URL";
            // 
            // lbLineCnt
            // 
            lbLineCnt.AutoSize = true;
            lbLineCnt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLineCnt.Location = new Point(25, 339);
            lbLineCnt.Name = "lbLineCnt";
            lbLineCnt.Size = new Size(90, 23);
            lbLineCnt.TabIndex = 2;
            lbLineCnt.Text = "Line count";
            // 
            // lbWordCnt
            // 
            lbWordCnt.AutoSize = true;
            lbWordCnt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWordCnt.Location = new Point(25, 391);
            lbWordCnt.Name = "lbWordCnt";
            lbWordCnt.Size = new Size(108, 23);
            lbWordCnt.TabIndex = 2;
            lbWordCnt.Text = "Words count";
            // 
            // lbCharCnt
            // 
            lbCharCnt.AutoSize = true;
            lbCharCnt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCharCnt.Location = new Point(25, 446);
            lbCharCnt.Name = "lbCharCnt";
            lbCharCnt.Size = new Size(133, 23);
            lbCharCnt.TabIndex = 2;
            lbCharCnt.Text = "Character count";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SpringGreen;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(27, 504);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(382, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(169, 193);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(240, 27);
            tbName.TabIndex = 4;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(169, 243);
            tbSize.Name = "tbSize";
            tbSize.ReadOnly = true;
            tbSize.Size = new Size(240, 27);
            tbSize.TabIndex = 4;
            // 
            // tbURL
            // 
            tbURL.Location = new Point(169, 294);
            tbURL.Name = "tbURL";
            tbURL.ReadOnly = true;
            tbURL.Size = new Size(240, 27);
            tbURL.TabIndex = 4;
            // 
            // tbLineCnt
            // 
            tbLineCnt.Location = new Point(169, 338);
            tbLineCnt.Name = "tbLineCnt";
            tbLineCnt.ReadOnly = true;
            tbLineCnt.Size = new Size(240, 27);
            tbLineCnt.TabIndex = 4;
            // 
            // tbWordCnt
            // 
            tbWordCnt.Location = new Point(169, 390);
            tbWordCnt.Name = "tbWordCnt";
            tbWordCnt.ReadOnly = true;
            tbWordCnt.Size = new Size(240, 27);
            tbWordCnt.TabIndex = 4;
            // 
            // tbCharCnt
            // 
            tbCharCnt.Location = new Point(169, 446);
            tbCharCnt.Name = "tbCharCnt";
            tbCharCnt.ReadOnly = true;
            tbCharCnt.Size = new Size(240, 27);
            tbCharCnt.TabIndex = 4;
            // 
            // rtbOut
            // 
            rtbOut.BackColor = Color.LightCyan;
            rtbOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbOut.Location = new Point(434, 123);
            rtbOut.Name = "rtbOut";
            rtbOut.Size = new Size(506, 429);
            rtbOut.TabIndex = 5;
            rtbOut.Text = "";
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(965, 582);
            Controls.Add(rtbOut);
            Controls.Add(tbCharCnt);
            Controls.Add(tbWordCnt);
            Controls.Add(tbLineCnt);
            Controls.Add(tbURL);
            Controls.Add(tbSize);
            Controls.Add(tbName);
            Controls.Add(btnExit);
            Controls.Add(lbCharCnt);
            Controls.Add(lbWordCnt);
            Controls.Add(lbLineCnt);
            Controls.Add(lbURL);
            Controls.Add(lbSize);
            Controls.Add(lbName);
            Controls.Add(btnRead);
            Controls.Add(label1);
            Name = "Lab02_Bai02";
            Text = "Lab02_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRead;
        private Label lbName;
        private Label lbSize;
        private Label lbURL;
        private Label lbLineCnt;
        private Label lbWordCnt;
        private Label lbCharCnt;
        private Button btnExit;
        private TextBox tbName;
        private TextBox tbSize;
        private TextBox tbURL;
        private TextBox tbLineCnt;
        private TextBox tbWordCnt;
        private TextBox tbCharCnt;
        private RichTextBox rtbOut;
    }
}