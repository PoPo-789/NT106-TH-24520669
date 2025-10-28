namespace Lab02
{
    partial class Lab02_Bai06
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
            listViewDish = new ListView();
            listViewUser = new ListView();
            btnExit = new Button();
            btnRand = new Button();
            btnUpLoad = new Button();
            btnAddUser = new Button();
            btnAddDish = new Button();
            btnAddPicDish = new Button();
            btnConnect = new Button();
            tbIDDish = new TextBox();
            label5 = new Label();
            label2 = new Label();
            tbNameDish = new TextBox();
            label3 = new Label();
            tbPicDish = new TextBox();
            label4 = new Label();
            tbIDUser = new TextBox();
            label6 = new Label();
            tbNameUser = new TextBox();
            label7 = new Label();
            tbAthorUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(462, 9);
            label1.Name = "label1";
            label1.Size = new Size(550, 93);
            label1.TabIndex = 1;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // listViewDish
            // 
            listViewDish.Location = new Point(452, 169);
            listViewDish.Name = "listViewDish";
            listViewDish.Size = new Size(465, 377);
            listViewDish.TabIndex = 2;
            listViewDish.UseCompatibleStateImageBehavior = false;
            // 
            // listViewUser
            // 
            listViewUser.Location = new Point(938, 169);
            listViewUser.Name = "listViewUser";
            listViewUser.Size = new Size(465, 377);
            listViewUser.TabIndex = 2;
            listViewUser.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1188, 655);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRand
            // 
            btnRand.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRand.Location = new Point(852, 563);
            btnRand.Name = "btnRand";
            btnRand.Size = new Size(151, 57);
            btnRand.TabIndex = 3;
            btnRand.Text = "Random 🎲";
            btnRand.UseVisualStyleBackColor = true;
            btnRand.Click += btnRand_Click;
            // 
            // btnUpLoad
            // 
            btnUpLoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpLoad.Location = new Point(962, 655);
            btnUpLoad.Name = "btnUpLoad";
            btnUpLoad.Size = new Size(194, 50);
            btnUpLoad.TabIndex = 3;
            btnUpLoad.Text = "Đưa dữ liệu lên";
            btnUpLoad.UseVisualStyleBackColor = true;
            btnUpLoad.Click += btnUpLoad_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(734, 655);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(194, 50);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Thêm người dùng";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnAddDish
            // 
            btnAddDish.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDish.Location = new Point(506, 655);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(194, 50);
            btnAddDish.TabIndex = 3;
            btnAddDish.Text = "Thêm món ăn";
            btnAddDish.UseVisualStyleBackColor = true;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // btnAddPicDish
            // 
            btnAddPicDish.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPicDish.Location = new Point(276, 655);
            btnAddPicDish.Name = "btnAddPicDish";
            btnAddPicDish.Size = new Size(194, 50);
            btnAddPicDish.TabIndex = 3;
            btnAddPicDish.Text = "Thêm ảnh món";
            btnAddPicDish.UseVisualStyleBackColor = true;
            btnAddPicDish.Click += btnAddPicDish_Click;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(41, 655);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 50);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Kết nối CSDL";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbIDDish
            // 
            tbIDDish.Font = new Font("Segoe UI", 11F);
            tbIDDish.Location = new Point(172, 179);
            tbIDDish.Name = "tbIDDish";
            tbIDDish.Size = new Size(263, 32);
            tbIDDish.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleTurquoise;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(-1, 179);
            label5.Name = "label5";
            label5.Size = new Size(131, 30);
            label5.TabIndex = 8;
            label5.Text = "ID món ăn: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(-1, 237);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 8;
            label2.Text = "Tên món ăn: ";
            // 
            // tbNameDish
            // 
            tbNameDish.Font = new Font("Segoe UI", 11F);
            tbNameDish.Location = new Point(172, 237);
            tbNameDish.Name = "tbNameDish";
            tbNameDish.Size = new Size(263, 32);
            tbNameDish.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(-1, 287);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 8;
            label3.Text = "Ảnh món ăn: ";
            // 
            // tbPicDish
            // 
            tbPicDish.Font = new Font("Segoe UI", 11F);
            tbPicDish.Location = new Point(172, 287);
            tbPicDish.Name = "tbPicDish";
            tbPicDish.ReadOnly = true;
            tbPicDish.Size = new Size(263, 32);
            tbPicDish.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleTurquoise;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(-1, 382);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 8;
            label4.Text = "ID người dùng:";
            // 
            // tbIDUser
            // 
            tbIDUser.Font = new Font("Segoe UI", 11F);
            tbIDUser.Location = new Point(172, 382);
            tbIDUser.Name = "tbIDUser";
            tbIDUser.Size = new Size(263, 32);
            tbIDUser.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PaleTurquoise;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(-1, 439);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 8;
            label6.Text = "Họ và tên:";
            // 
            // tbNameUser
            // 
            tbNameUser.Font = new Font("Segoe UI", 11F);
            tbNameUser.Location = new Point(172, 439);
            tbNameUser.Name = "tbNameUser";
            tbNameUser.Size = new Size(263, 32);
            tbNameUser.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PaleTurquoise;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.Location = new Point(-1, 499);
            label7.Name = "label7";
            label7.Size = new Size(130, 30);
            label7.TabIndex = 8;
            label7.Text = "Quyền hạn:";
            // 
            // tbAthorUser
            // 
            tbAthorUser.Font = new Font("Segoe UI", 11F);
            tbAthorUser.Location = new Point(172, 499);
            tbAthorUser.Name = "tbAthorUser";
            tbAthorUser.Size = new Size(263, 32);
            tbAthorUser.TabIndex = 9;
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1415, 742);
            Controls.Add(tbAthorUser);
            Controls.Add(tbNameUser);
            Controls.Add(tbIDUser);
            Controls.Add(tbPicDish);
            Controls.Add(tbNameDish);
            Controls.Add(tbIDDish);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btnRand);
            Controls.Add(btnConnect);
            Controls.Add(btnAddPicDish);
            Controls.Add(btnAddDish);
            Controls.Add(btnAddUser);
            Controls.Add(btnUpLoad);
            Controls.Add(btnExit);
            Controls.Add(listViewUser);
            Controls.Add(listViewDish);
            Controls.Add(label1);
            Name = "Lab02_Bai06";
            Text = "Lab02_Bai06";
            Load += Lab02_Bai06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewDish;
        private ListView listViewUser;
        private Button btnExit;
        private Button btnRand;
        private Button btnUpLoad;
        private Button btnAddUser;
        private Button btnAddDish;
        private Button btnAddPicDish;
        private Button btnConnect;
        private TextBox tbIDDish;
        private Label label5;
        private Label label2;
        private TextBox tbNameDish;
        private Label label3;
        private TextBox tbPicDish;
        private Label label4;
        private TextBox tbIDUser;
        private Label label6;
        private TextBox tbNameUser;
        private Label label7;
        private TextBox tbAthorUser;
    }
}