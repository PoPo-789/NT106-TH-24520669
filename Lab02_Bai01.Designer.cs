namespace Lab02
{
    partial class Lab02_Bai01
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
            btnDocFile = new Button();
            btnGhiFile = new Button();
            btnThoat = new Button();
            rtbOut = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(314, 21);
            label1.Name = "label1";
            label1.Size = new Size(345, 62);
            label1.TabIndex = 0;
            label1.Text = "Ghi và Đọc file";
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDocFile.Location = new Point(78, 162);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(141, 51);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGhiFile.Location = new Point(78, 295);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(141, 51);
            btnGhiFile.TabIndex = 1;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(78, 422);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 51);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtbOut
            // 
            rtbOut.Font = new Font("Segoe UI", 12F);
            rtbOut.Location = new Point(341, 130);
            rtbOut.Name = "rtbOut";
            rtbOut.Size = new Size(594, 425);
            rtbOut.TabIndex = 3;
            rtbOut.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(965, 582);
            Controls.Add(rtbOut);
            Controls.Add(btnThoat);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(label1);
            Name = "Lab02_Bai01";
            Text = "Lab02_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Button btnThoat;
        private RichTextBox rtbOut;
    }
}