namespace Lab02
{
    partial class Lab02_Bai03
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
            rtbOut = new RichTextBox();
            btnDocFile = new Button();
            btnTinhToan = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(620, 62);
            label1.TabIndex = 0;
            label1.Text = "Đọc và Ghi file và tính toán";
            // 
            // rtbOut
            // 
            rtbOut.Font = new Font("Segoe UI", 12F);
            rtbOut.Location = new Point(341, 130);
            rtbOut.Name = "rtbOut";
            rtbOut.ReadOnly = true;
            rtbOut.Size = new Size(594, 425);
            rtbOut.TabIndex = 1;
            rtbOut.Text = "";
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDocFile.Location = new Point(78, 162);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(141, 51);
            btnDocFile.TabIndex = 2;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnTinhToan
            // 
            btnTinhToan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnTinhToan.Location = new Point(78, 295);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(141, 51);
            btnTinhToan.TabIndex = 2;
            btnTinhToan.Text = "Tính Toán";
            btnTinhToan.UseVisualStyleBackColor = true;
            btnTinhToan.Click += btnTinhToan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(78, 422);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 51);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(965, 582);
            Controls.Add(btnThoat);
            Controls.Add(btnTinhToan);
            Controls.Add(btnDocFile);
            Controls.Add(rtbOut);
            Controls.Add(label1);
            Name = "Lab02_Bai03";
            Text = "Lab02_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbOut;
        private Button btnDocFile;
        private Button btnTinhToan;
        private Button btnThoat;
    }
}