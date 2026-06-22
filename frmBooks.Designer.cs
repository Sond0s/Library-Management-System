namespace LibraryManagmentSystem
{
    partial class frmBooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsProperties = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblBooksTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAddBook = new Guna.UI2.WinForms.Guna2TileButton();
            tbSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            BooksPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            cmsProperties.SuspendLayout();
            BooksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.ColumnHeadersHeight = 30;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBooks.ContextMenuStrip = cmsProperties;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.GridColor = Color.FromArgb(231, 229, 255);
            dgvBooks.Location = new Point(22, 129);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(1159, 378);
            dgvBooks.TabIndex = 9;
            dgvBooks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBooks.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvBooks.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvBooks.ThemeStyle.HeaderStyle.Height = 30;
            dgvBooks.ThemeStyle.ReadOnly = true;
            dgvBooks.ThemeStyle.RowsStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvBooks.ThemeStyle.RowsStyle.Height = 29;
            // 
            // cmsProperties
            // 
            cmsProperties.Font = new Font("Cairo Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsProperties.ImageScalingSize = new Size(20, 20);
            cmsProperties.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsProperties.Name = "cmsProperties";
            cmsProperties.RenderStyle.ArrowColor = Color.MediumOrchid;
            cmsProperties.RenderStyle.BorderColor = Color.Gainsboro;
            cmsProperties.RenderStyle.ColorTable = null;
            cmsProperties.RenderStyle.RoundedEdges = true;
            cmsProperties.RenderStyle.SelectionArrowColor = Color.White;
            cmsProperties.RenderStyle.SelectionBackColor = Color.DarkMagenta;
            cmsProperties.RenderStyle.SelectionForeColor = Color.White;
            cmsProperties.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsProperties.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsProperties.Size = new Size(215, 100);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            editToolStripMenuItem.Image = Properties.Resources.EditIcon;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(214, 34);
            editToolStripMenuItem.Text = " Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            deleteToolStripMenuItem.Image = Properties.Resources.DeleteIcon;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(214, 34);
            deleteToolStripMenuItem.Text = " Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.BackColor = Color.Transparent;
            lblBooksTitle.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksTitle.ForeColor = SystemColors.ButtonHighlight;
            lblBooksTitle.Location = new Point(504, 44);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(256, 47);
            lblBooksTitle.TabIndex = 10;
            lblBooksTitle.Text = " Library Books";
            lblBooksTitle.TextAlignment = ContentAlignment.TopCenter;
            // 
            // btnAddBook
            // 
            btnAddBook.BorderRadius = 3;
            btnAddBook.CustomizableEdges = customizableEdges1;
            btnAddBook.DisabledState.BorderColor = Color.DarkGray;
            btnAddBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBook.FillColor = Color.MediumOrchid;
            btnAddBook.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(1013, 52);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddBook.Size = new Size(168, 46);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = " Add";
            btnAddBook.Click += btnAddBook_Click;
            // 
            // tbSearchBar
            // 
            tbSearchBar.CustomizableEdges = customizableEdges3;
            tbSearchBar.DefaultText = "";
            tbSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchBar.Font = new Font("Cairo", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchBar.Location = new Point(22, 52);
            tbSearchBar.Margin = new Padding(8, 11, 8, 11);
            tbSearchBar.Name = "tbSearchBar";
            tbSearchBar.PlaceholderText = "Search With Title";
            tbSearchBar.SelectedText = "";
            tbSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbSearchBar.Size = new Size(542, 46);
            tbSearchBar.TabIndex = 13;
            tbSearchBar.TextChanged += tbSearchBar_TextChanged;
            // 
            // BooksPanel
            // 
            BooksPanel.BackColor = SystemColors.ButtonFace;
            BooksPanel.Controls.Add(dgvBooks);
            BooksPanel.Controls.Add(tbSearchBar);
            BooksPanel.Controls.Add(btnAddBook);
            BooksPanel.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BooksPanel.Location = new Point(30, 147);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(1214, 512);
            BooksPanel.TabIndex = 14;
            // 
            // frmBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1256, 684);
            Controls.Add(BooksPanel);
            Controls.Add(lblBooksTitle);
            Name = "frmBooks";
            Text = "Books";
            Load += frmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            cmsProperties.ResumeLayout(false);
            BooksPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvBooks;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooksTitle;
        private Guna.UI2.WinForms.Guna2TileButton btnAddBook;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchBar;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsProperties;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel BooksPanel;
    }
}