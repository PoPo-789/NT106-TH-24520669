namespace Lab02
{
    partial class FrmShowDish
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
            lblMonAn = new Label();
            lblNguoi = new Label();
            picMonAn = new PictureBox();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            // 
            // lblMonAn
            // 
            lblMonAn.AutoSize = true;
            lblMonAn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonAn.Location = new Point(12, 9);
            lblMonAn.Name = "lblMonAn";
            lblMonAn.Size = new Size(0, 28);
            lblMonAn.TabIndex = 0;
            // 
            // lblNguoi
            // 
            lblNguoi.AutoSize = true;
            lblNguoi.Font = new Font("Segoe UI", 10F);
            lblNguoi.Location = new Point(12, 42);
            lblNguoi.Name = "lblNguoi";
            lblNguoi.Size = new Size(0, 23);
            lblNguoi.TabIndex = 1;
            // 
            // picMonAn
            // 
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(28, 75);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(300, 200);
            picMonAn.TabIndex = 2;
            picMonAn.TabStop = false;
            picMonAn.Click += picMonAn_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(137, 290);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 38);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.Click += btnDong_Click;
            // 
            // FrmShowDish
            // 
            ClientSize = new Size(355, 340);
            Controls.Add(lblMonAn);
            Controls.Add(lblNguoi);
            Controls.Add(picMonAn);
            Controls.Add(btnDong);
            Name = "FrmShowDish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Món ăn hôm nay";
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMonAn;
        private Label lblNguoi;
        private PictureBox picMonAn;
        private Button btnDong;
    }
}