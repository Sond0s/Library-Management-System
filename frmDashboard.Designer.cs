namespace LibraryManagmentSystem
{
    partial class frmDashboard
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
            panel1 = new Panel();
            dgvDashboardBooks = new DataGridView();
            lblUsername = new Label();
            label3 = new Label();
            lblBooks = new Label();
            lblMembers = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 31);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDashboardBooks);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(185, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 512);
            panel1.TabIndex = 1;
            // 
            // dgvDashboardBooks
            // 
            dgvDashboardBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboardBooks.Location = new Point(36, 58);
            dgvDashboardBooks.Name = "dgvDashboardBooks";
            dgvDashboardBooks.RowHeadersWidth = 51;
            dgvDashboardBooks.Size = new Size(875, 435);
            dgvDashboardBooks.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(19, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 1;
            label3.Text = "User Panel";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Cursor = Cursors.Hand;
            lblBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooks.Location = new Point(12, 161);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(80, 31);
            lblBooks.TabIndex = 3;
            lblBooks.Text = "Books";
            lblBooks.Click += lblBooks_Click;
            lblBooks.MouseEnter += lblBooks_MouseEnter;
            lblBooks.MouseLeave += lblBooks_MouseLeave;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembers.Location = new Point(12, 224);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(114, 31);
            lblMembers.TabIndex = 4;
            lblMembers.Text = "Members";
            lblMembers.Click += lblMembers_Click;
            lblMembers.MouseEnter += lblMembers_MouseEnter;
            lblMembers.MouseLeave += lblMembers_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 289);
            label6.Name = "label6";
            label6.Size = new Size(138, 31);
            label6.TabIndex = 5;
            label6.Text = "Borrowings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 358);
            label7.Name = "label7";
            label7.Size = new Size(69, 31);
            label7.TabIndex = 6;
            label7.Text = "Fines";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 440);
            button1.Name = "button1";
            button1.Size = new Size(94, 48);
            button1.TabIndex = 7;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 563);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblMembers);
            Controls.Add(lblBooks);
            Controls.Add(label3);
            Controls.Add(lblUsername);
            Controls.Add(panel1);
            Name = "frmDashboard";
            Text = "Form1";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblUsername;
        private Label label3;
        private Label lblBooks;
        private Label lblMembers;
        private Label label6;
        private Label label7;
        private Button button1;
        private DataGridView dgvDashboardBooks;
    }
}