namespace Lab02
{
    partial class Lab02_Bai07
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
            tree = new TreeView();
            rtb = new RichTextBox();
            ptb = new PictureBox();
            btn_Browser = new Button();
            btn_Exit = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptb).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(429, 32);
            label1.Name = "label1";
            label1.Size = new Size(531, 93);
            label1.TabIndex = 0;
            label1.Text = "Duyệt thư mục";
            // 
            // tree
            // 
            tree.Location = new Point(25, 155);
            tree.Name = "tree";
            tree.Size = new Size(431, 541);
            tree.TabIndex = 1;
            tree.AfterExpand += treeView_AfterExpand;
            tree.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // rtb
            // 
            rtb.Location = new Point(480, 155);
            rtb.Name = "rtb";
            rtb.Size = new Size(431, 541);
            rtb.TabIndex = 2;
            rtb.Text = "";
            // 
            // ptb
            // 
            ptb.Location = new Point(-1, -1);
            ptb.Name = "ptb";
            ptb.Size = new Size(449, 541);
            ptb.TabIndex = 3;
            ptb.TabStop = false;
            // 
            // btn_Browser
            // 
            btn_Browser.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btn_Browser.Location = new Point(157, 49);
            btn_Browser.Name = "btn_Browser";
            btn_Browser.Size = new Size(169, 67);
            btn_Browser.TabIndex = 4;
            btn_Browser.Text = "BROWSE";
            btn_Browser.UseVisualStyleBackColor = true;
            btn_Browser.Click += btn_Browse_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btn_Exit.Location = new Point(1090, 49);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(169, 67);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ptb);
            panel1.Location = new Point(937, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 541);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1405, 742);
            Controls.Add(panel1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Browser);
            Controls.Add(rtb);
            Controls.Add(tree);
            Controls.Add(label1);
            Name = "Lab02_Bai07";
            Text = "Lab02_Bai07";
            ((System.ComponentModel.ISupportInitialize)ptb).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TreeView tree;
        private RichTextBox rtb;
        private PictureBox ptb;
        private Button btn_Browser;
        private Button btn_Exit;
        private Panel panel1;
    }
}