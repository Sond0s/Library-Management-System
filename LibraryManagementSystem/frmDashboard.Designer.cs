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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            lblUsername = new Label();
            label3 = new Label();
            lblBooks = new Label();
            lblMembers = new Label();
            lblBorrowings = new Label();
            lblFines = new Label();
            MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblMembersCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblBooksCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox5 = new PictureBox();
            label4 = new Label();
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
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox7 = new PictureBox();
            lblLogout = new Label();
            MainPanel.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardMembers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            label3.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(280, 71);
            label3.TabIndex = 1;
            label3.Text = "The BookShelf";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Cursor = Cursors.Hand;
            lblBooks.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooks.Location = new Point(85, 78);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(114, 39);
            lblBooks.TabIndex = 0;
            lblBooks.Text = "Books";
            lblBooks.Click += lblBooks_Click;
            lblBooks.MouseEnter += lblBooks_MouseEnter;
            lblBooks.MouseLeave += lblBooks_MouseLeave;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembers.Location = new Point(85, 177);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(165, 39);
            lblMembers.TabIndex = 1;
            lblMembers.Text = "Members";
            lblMembers.Click += lblMembers_Click;
            lblMembers.MouseEnter += lblMembers_MouseEnter;
            lblMembers.MouseLeave += lblMembers_MouseLeave;
            // 
            // lblBorrowings
            // 
            lblBorrowings.AutoSize = true;
            lblBorrowings.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowings.Location = new Point(79, 284);
            lblBorrowings.Name = "lblBorrowings";
            lblBorrowings.Size = new Size(201, 39);
            lblBorrowings.TabIndex = 2;
            lblBorrowings.Text = "Borrowings";
            lblBorrowings.Click += lblBorrowings_Click;
            lblBorrowings.MouseEnter += lblBorrowings_MouseEnter;
            lblBorrowings.MouseLeave += lblBorrowings_MouseLeave;
            // 
            // lblFines
            // 
            lblFines.AutoSize = true;
            lblFines.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFines.Location = new Point(87, 387);
            lblFines.Name = "lblFines";
            lblFines.Size = new Size(101, 39);
            lblFines.TabIndex = 3;
            lblFines.Text = "Fines";
            lblFines.Click += lblFines_Click;
            lblFines.MouseEnter += lblFines_MouseEnter;
            lblFines.MouseLeave += lblFines_MouseLeave;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.BorderRadius = 15;
            MainPanel.Controls.Add(guna2Panel2);
            MainPanel.Controls.Add(guna2Panel1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(lblTodayTime);
            MainPanel.Controls.Add(lblUsername);
            MainPanel.CustomizableEdges = customizableEdges5;
            MainPanel.FillColor = SystemColors.ButtonFace;
            MainPanel.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainPanel.Location = new Point(323, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            MainPanel.Size = new Size(1198, 725);
            MainPanel.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            guna2Panel2.AutoRoundedCorners = true;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderRadius = 45;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(lblMembersCount);
            guna2Panel2.Controls.Add(pictureBox6);
            guna2Panel2.Controls.Add(label5);
            guna2Panel2.CustomBorderColor = Color.Transparent;
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.FillColor = SystemColors.ButtonHighlight;
            guna2Panel2.Location = new Point(628, 128);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(247, 93);
            guna2Panel2.TabIndex = 11;
            // 
            // lblMembersCount
            // 
            lblMembersCount.BackColor = Color.Transparent;
            lblMembersCount.Font = new Font("Cairo ExtraBold", 16.2F, FontStyle.Bold);
            lblMembersCount.Location = new Point(86, 3);
            lblMembersCount.Name = "lblMembersCount";
            lblMembersCount.Size = new Size(14, 52);
            lblMembersCount.TabIndex = 10;
            lblMembersCount.Text = "-";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_people;
            pictureBox6.Location = new Point(172, 26);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 49);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 12F, FontStyle.Bold);
            label5.Location = new Point(22, 49);
            label5.Name = "label5";
            label5.Size = new Size(145, 37);
            label5.TabIndex = 8;
            label5.Text = "Total Members";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 45;
            guna2Panel1.Controls.Add(lblBooksCount);
            guna2Panel1.Controls.Add(pictureBox5);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = SystemColors.ButtonHighlight;
            guna2Panel1.Location = new Point(35, 128);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(250, 96);
            guna2Panel1.TabIndex = 10;
            // 
            // lblBooksCount
            // 
            lblBooksCount.BackColor = Color.Transparent;
            lblBooksCount.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksCount.Location = new Point(69, 13);
            lblBooksCount.Name = "lblBooksCount";
            lblBooksCount.Size = new Size(12, 45);
            lblBooksCount.TabIndex = 9;
            lblBooksCount.Text = "-";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_book2;
            pictureBox5.Location = new Point(164, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(149, 119);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 12F, FontStyle.Bold);
            label4.Location = new Point(21, 49);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 7;
            label4.Text = "Total Books";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvDashboardMembers);
            panel2.Location = new Point(602, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 484);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 37);
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
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDashboardMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDashboardMembers.ColumnHeadersHeight = 30;
            dgvDashboardMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDashboardMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDashboardMembers.GridColor = Color.FromArgb(231, 229, 255);
            dgvDashboardMembers.Location = new Point(3, 96);
            dgvDashboardMembers.Name = "dgvDashboardMembers";
            dgvDashboardMembers.ReadOnly = true;
            dgvDashboardMembers.RowHeadersVisible = false;
            dgvDashboardMembers.RowHeadersWidth = 51;
            dgvDashboardMembers.Size = new Size(576, 385);
            dgvDashboardMembers.TabIndex = 4;
            dgvDashboardMembers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDashboardMembers.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvDashboardMembers.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvDashboardMembers.ThemeStyle.HeaderStyle.Height = 30;
            dgvDashboardMembers.ThemeStyle.ReadOnly = true;
            dgvDashboardMembers.ThemeStyle.RowsStyle.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvDashboardMembers.ThemeStyle.RowsStyle.Height = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvDashboardBooks);
            panel1.Location = new Point(10, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 481);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
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
            dataGridViewCellStyle5.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dgvDashboardBooks.Location = new Point(3, 96);
            dgvDashboardBooks.Name = "dgvDashboardBooks";
            dgvDashboardBooks.ReadOnly = true;
            dgvDashboardBooks.RowHeadersVisible = false;
            dgvDashboardBooks.RowHeadersWidth = 51;
            dgvDashboardBooks.Size = new Size(576, 385);
            dgvDashboardBooks.TabIndex = 4;
            dgvDashboardBooks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDashboardBooks.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvDashboardBooks.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            pictureBox1.Location = new Point(22, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 59);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ColoredPeople;
            pictureBox2.Location = new Point(19, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 59);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_borrow_book_50;
            pictureBox3.Location = new Point(22, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 59);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_debt_64;
            pictureBox4.Location = new Point(22, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 59);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.Transparent;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.Controls.Add(pictureBox7);
            guna2Panel3.Controls.Add(lblLogout);
            guna2Panel3.Controls.Add(lblBooks);
            guna2Panel3.Controls.Add(pictureBox1);
            guna2Panel3.Controls.Add(pictureBox4);
            guna2Panel3.Controls.Add(lblFines);
            guna2Panel3.Controls.Add(pictureBox2);
            guna2Panel3.Controls.Add(pictureBox3);
            guna2Panel3.Controls.Add(lblBorrowings);
            guna2Panel3.Controls.Add(lblMembers);
            guna2Panel3.CustomizableEdges = customizableEdges7;
            guna2Panel3.FillColor = SystemColors.ButtonFace;
            guna2Panel3.Location = new Point(18, 135);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel3.Size = new Size(286, 602);
            guna2Panel3.TabIndex = 9;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_logout_64;
            pictureBox7.Location = new Point(22, 472);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 59);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Tahoma", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(85, 483);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(128, 39);
            lblLogout.TabIndex = 4;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
            lblLogout.MouseEnter += lblLogout_MouseEnter;
            lblLogout.MouseLeave += lblLogout_MouseLeave;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1551, 762);
            Controls.Add(guna2Panel3);
            Controls.Add(MainPanel);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooksCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMembersCount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private PictureBox pictureBox7;
        private Label lblLogout;
    }
}