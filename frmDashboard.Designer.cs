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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsername = new Label();
            label3 = new Label();
            lblBooks = new Label();
            lblMembers = new Label();
            lblBorrowings = new Label();
            lblFines = new Label();
            MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            panel2 = new Panel();
            label2 = new Label();
            dgvDashboardMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            dgvDashboardBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTodayTime = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            panel3 = new Panel();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardMembers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(3, 4);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(155, 56);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Freestyle Script", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(252, 59);
            label3.TabIndex = 1;
            label3.Text = "The Book Shelf";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Cursor = Cursors.Hand;
            lblBooks.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooks.Location = new Point(63, 62);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(114, 39);
            lblBooks.TabIndex = 3;
            lblBooks.Text = "Books";
            lblBooks.Click += lblBooks_Click;
            lblBooks.MouseEnter += lblBooks_MouseEnter;
            lblBooks.MouseLeave += lblBooks_MouseLeave;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembers.Location = new Point(63, 162);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(165, 39);
            lblMembers.TabIndex = 4;
            lblMembers.Text = "Members";
            lblMembers.Click += lblMembers_Click;
            lblMembers.MouseEnter += lblMembers_MouseEnter;
            lblMembers.MouseLeave += lblMembers_MouseLeave;
            // 
            // lblBorrowings
            // 
            lblBorrowings.AutoSize = true;
            lblBorrowings.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowings.Location = new Point(62, 271);
            lblBorrowings.Name = "lblBorrowings";
            lblBorrowings.Size = new Size(201, 39);
            lblBorrowings.TabIndex = 5;
            lblBorrowings.Text = "Borrowings";
            lblBorrowings.MouseEnter += lblBorrowings_MouseEnter;
            lblBorrowings.MouseLeave += lblBorrowings_MouseLeave;
            // 
            // lblFines
            // 
            lblFines.AutoSize = true;
            lblFines.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFines.Location = new Point(65, 382);
            lblFines.Name = "lblFines";
            lblFines.Size = new Size(101, 39);
            lblFines.TabIndex = 6;
            lblFines.Text = "Fines";
            lblFines.MouseEnter += lblFines_MouseEnter;
            lblFines.MouseLeave += lblFines_MouseLeave;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(lblTodayTime);
            MainPanel.Controls.Add(lblUsername);
            MainPanel.CustomizableEdges = customizableEdges1;
            MainPanel.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainPanel.Location = new Point(323, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MainPanel.Size = new Size(1198, 714);
            MainPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvDashboardMembers);
            panel2.Location = new Point(602, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 471);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 20);
            label2.Name = "label2";
            label2.Size = new Size(200, 56);
            label2.TabIndex = 6;
            label2.Text = "Members List";
            // 
            // dgvDashboardMembers
            // 
            dgvDashboardMembers.AllowUserToAddRows = false;
            dgvDashboardMembers.AllowUserToDeleteRows = false;
            dgvDashboardMembers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDashboardMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDashboardMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDashboardMembers.ColumnHeadersHeight = 30;
            dgvDashboardMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cairo", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDashboardMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDashboardMembers.GridColor = Color.FromArgb(231, 229, 255);
            dgvDashboardMembers.Location = new Point(26, 96);
            dgvDashboardMembers.Name = "dgvDashboardMembers";
            dgvDashboardMembers.ReadOnly = true;
            dgvDashboardMembers.RowHeadersVisible = false;
            dgvDashboardMembers.RowHeadersWidth = 51;
            dgvDashboardMembers.Size = new Size(537, 361);
            dgvDashboardMembers.TabIndex = 4;
            dgvDashboardMembers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDashboardMembers.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvDashboardMembers.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.5F);
            dgvDashboardMembers.ThemeStyle.HeaderStyle.Height = 30;
            dgvDashboardMembers.ThemeStyle.ReadOnly = true;
            dgvDashboardMembers.ThemeStyle.RowsStyle.Font = new Font("Cairo", 10.5F);
            dgvDashboardMembers.ThemeStyle.RowsStyle.Height = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvDashboardBooks);
            panel1.Location = new Point(10, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 471);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 56);
            label1.TabIndex = 6;
            label1.Text = "Books List";
            // 
            // dgvDashboardBooks
            // 
            dgvDashboardBooks.AllowUserToAddRows = false;
            dgvDashboardBooks.AllowUserToDeleteRows = false;
            dgvDashboardBooks.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvDashboardBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle5.Font = new Font("Cairo", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDashboardBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDashboardBooks.ColumnHeadersHeight = 30;
            dgvDashboardBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Cairo", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDashboardBooks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDashboardBooks.GridColor = Color.FromArgb(231, 229, 255);
            dgvDashboardBooks.Location = new Point(25, 96);
            dgvDashboardBooks.Name = "dgvDashboardBooks";
            dgvDashboardBooks.ReadOnly = true;
            dgvDashboardBooks.RowHeadersVisible = false;
            dgvDashboardBooks.RowHeadersWidth = 51;
            dgvDashboardBooks.Size = new Size(537, 361);
            dgvDashboardBooks.TabIndex = 4;
            dgvDashboardBooks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDashboardBooks.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvDashboardBooks.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 9F);
            dgvDashboardBooks.ThemeStyle.HeaderStyle.Height = 30;
            dgvDashboardBooks.ThemeStyle.ReadOnly = true;
            dgvDashboardBooks.ThemeStyle.RowsStyle.Font = new Font("Cairo", 9F);
            dgvDashboardBooks.ThemeStyle.RowsStyle.Height = 29;
            // 
            // lblTodayTime
            // 
            lblTodayTime.AutoSize = true;
            lblTodayTime.Font = new Font("Cairo SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTime.Location = new Point(10, 56);
            lblTodayTime.Name = "lblTodayTime";
            lblTodayTime.Size = new Size(129, 43);
            lblTodayTime.TabIndex = 3;
            lblTodayTime.Text = "Today Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ColoredBooks;
            pictureBox1.Location = new Point(10, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 59);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ColoredPeople;
            pictureBox2.Location = new Point(4, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 59);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_borrow_book_50;
            pictureBox3.Location = new Point(3, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 59);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_debt_64;
            pictureBox4.Location = new Point(0, 372);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 59);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BorderRadius = 3;
            btnLogout.CustomizableEdges = customizableEdges3;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Purple;
            btnLogout.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(40, 523);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogout.Size = new Size(202, 56);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblFines);
            panel3.Controls.Add(lblBorrowings);
            panel3.Controls.Add(lblMembers);
            panel3.Controls.Add(lblBooks);
            panel3.Location = new Point(12, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 595);
            panel3.TabIndex = 11;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1551, 762);
            Controls.Add(panel3);
            Controls.Add(MainPanel);
            Controls.Add(label3);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardMembers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Label label3;
        private Label lblBooks;
        private Label lblMembers;
        private Label lblBorrowings;
        private Label lblFines;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Label lblTodayTime;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDashboardBooks;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDashboardMembers;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Panel panel3;
    }
}