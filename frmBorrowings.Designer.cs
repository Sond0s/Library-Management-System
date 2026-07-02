namespace LibraryManagmentSystem
{
    partial class frmBorrowings
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblBooksTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tbSearchOpt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            cbSearchOpt = new Guna.UI2.WinForms.Guna2ComboBox();
            btnBorrowBook = new Guna.UI2.WinForms.Guna2TileButton();
            dgvBorrowings = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            cmsReturn = new ToolStripMenuItem();
            cmsDelete = new ToolStripMenuItem();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            cmsOptions.SuspendLayout();
            SuspendLayout();
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.BackColor = Color.Transparent;
            lblBooksTitle.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksTitle.ForeColor = SystemColors.ButtonHighlight;
            lblBooksTitle.Location = new Point(574, 43);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(216, 47);
            lblBooksTitle.TabIndex = 11;
            lblBooksTitle.Text = "Borrowings";
            lblBooksTitle.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(tbSearchOpt);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(cbSearchOpt);
            guna2Panel1.Controls.Add(btnBorrowBook);
            guna2Panel1.Controls.Add(dgvBorrowings);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = SystemColors.ButtonFace;
            guna2Panel1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Panel1.Location = new Point(24, 125);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(1378, 593);
            guna2Panel1.TabIndex = 12;
            // 
            // tbSearchOpt
            // 
            tbSearchOpt.BorderRadius = 5;
            tbSearchOpt.CustomizableEdges = customizableEdges1;
            tbSearchOpt.DefaultText = "";
            tbSearchOpt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchOpt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchOpt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchOpt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchOpt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchOpt.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchOpt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchOpt.Location = new Point(161, 58);
            tbSearchOpt.Margin = new Padding(3, 5, 3, 5);
            tbSearchOpt.Name = "tbSearchOpt";
            tbSearchOpt.PlaceholderText = "Enter to search";
            tbSearchOpt.SelectedText = "";
            tbSearchOpt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbSearchOpt.Size = new Size(426, 46);
            tbSearchOpt.TabIndex = 16;
            tbSearchOpt.TextChanged += tbSearchOpt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 11);
            label1.Name = "label1";
            label1.Size = new Size(122, 43);
            label1.TabIndex = 15;
            label1.Text = "Search by:";
            // 
            // cbSearchOpt
            // 
            cbSearchOpt.BackColor = Color.Transparent;
            cbSearchOpt.BorderRadius = 5;
            cbSearchOpt.CustomizableEdges = customizableEdges3;
            cbSearchOpt.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchOpt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchOpt.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchOpt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchOpt.Font = new Font("Cairo", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSearchOpt.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchOpt.ItemHeight = 30;
            cbSearchOpt.Items.AddRange(new object[] { "Title", "Member" });
            cbSearchOpt.Location = new Point(161, 18);
            cbSearchOpt.Name = "cbSearchOpt";
            cbSearchOpt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbSearchOpt.Size = new Size(205, 36);
            cbSearchOpt.TabIndex = 14;
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.BorderRadius = 5;
            btnBorrowBook.CustomizableEdges = customizableEdges5;
            btnBorrowBook.DisabledState.BorderColor = Color.DarkGray;
            btnBorrowBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBorrowBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBorrowBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBorrowBook.FillColor = Color.MediumOrchid;
            btnBorrowBook.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            btnBorrowBook.ForeColor = Color.White;
            btnBorrowBook.Location = new Point(1107, 58);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBorrowBook.Size = new Size(247, 46);
            btnBorrowBook.TabIndex = 12;
            btnBorrowBook.Text = "Borrow Book";
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.AllowUserToAddRows = false;
            dgvBorrowings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBorrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBorrowings.ColumnHeadersHeight = 30;
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBorrowings.ContextMenuStrip = cmsOptions;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBorrowings.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBorrowings.GridColor = Color.FromArgb(231, 229, 255);
            dgvBorrowings.Location = new Point(17, 160);
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.RowHeadersVisible = false;
            dgvBorrowings.RowHeadersWidth = 51;
            dgvBorrowings.Size = new Size(1346, 421);
            dgvBorrowings.TabIndex = 0;
            dgvBorrowings.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBorrowings.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvBorrowings.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvBorrowings.ThemeStyle.HeaderStyle.Height = 30;
            dgvBorrowings.ThemeStyle.ReadOnly = true;
            dgvBorrowings.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBorrowings.ThemeStyle.RowsStyle.Height = 29;
            dgvBorrowings.CellFormatting += dgvBorrowings_CellFormatting;
            // 
            // cmsOptions
            // 
            cmsOptions.BackColor = SystemColors.ButtonHighlight;
            cmsOptions.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { cmsReturn, cmsDelete });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RenderStyle.ArrowColor = Color.MediumOrchid;
            cmsOptions.RenderStyle.BorderColor = Color.Transparent;
            cmsOptions.RenderStyle.ColorTable = null;
            cmsOptions.RenderStyle.RoundedEdges = true;
            cmsOptions.RenderStyle.SelectionArrowColor = Color.White;
            cmsOptions.RenderStyle.SelectionBackColor = Color.DarkMagenta;
            cmsOptions.RenderStyle.SelectionForeColor = Color.White;
            cmsOptions.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsOptions.Size = new Size(215, 100);
            // 
            // cmsReturn
            // 
            cmsReturn.Image = Properties.Resources.icons8_return_24;
            cmsReturn.Name = "cmsReturn";
            cmsReturn.Size = new Size(214, 34);
            cmsReturn.Text = "Return";
            cmsReturn.Click += cmsReturn_Click;
            // 
            // cmsDelete
            // 
            cmsDelete.BackColor = SystemColors.ButtonHighlight;
            cmsDelete.Image = Properties.Resources.DeleteIcon;
            cmsDelete.Name = "cmsDelete";
            cmsDelete.Size = new Size(214, 34);
            cmsDelete.Text = "Delete";
            cmsDelete.Click += cmsDelete_Click;
            // 
            // frmBorrowings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 754);
            Controls.Add(guna2Panel1);
            Controls.Add(lblBooksTitle);
            Name = "frmBorrowings";
            Text = "Borrowings";
            Load += frmBorrowings_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooksTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBorrowings;
        private Guna.UI2.WinForms.Guna2TileButton btnBorrowBook;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchOpt;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchOpt;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private ToolStripMenuItem cmsReturn;
        private ToolStripMenuItem cmsDelete;
    }
}