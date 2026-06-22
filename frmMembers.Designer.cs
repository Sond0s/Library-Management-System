namespace LibraryManagmentSystem
{
    partial class frmMembers
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
            label1 = new Label();
            BooksPanel = new Panel();
            dgvListMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            tbSearchMembers = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddMember = new Guna.UI2.WinForms.Guna2TileButton();
            cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            BooksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).BeginInit();
            cmsOptions.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(455, 35);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 1;
            label1.Text = "Library Members";
            // 
            // BooksPanel
            // 
            BooksPanel.BackColor = SystemColors.ButtonFace;
            BooksPanel.Controls.Add(dgvListMembers);
            BooksPanel.Controls.Add(tbSearchMembers);
            BooksPanel.Controls.Add(btnAddMember);
            BooksPanel.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BooksPanel.Location = new Point(12, 109);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(1214, 512);
            BooksPanel.TabIndex = 15;
            // 
            // dgvListMembers
            // 
            dgvListMembers.AllowUserToAddRows = false;
            dgvListMembers.AllowUserToDeleteRows = false;
            dgvListMembers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvListMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListMembers.ColumnHeadersHeight = 30;
            dgvListMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListMembers.ContextMenuStrip = cmsOptions;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListMembers.GridColor = Color.FromArgb(231, 229, 255);
            dgvListMembers.Location = new Point(22, 129);
            dgvListMembers.Name = "dgvListMembers";
            dgvListMembers.ReadOnly = true;
            dgvListMembers.RowHeadersVisible = false;
            dgvListMembers.RowHeadersWidth = 51;
            dgvListMembers.Size = new Size(1159, 378);
            dgvListMembers.TabIndex = 9;
            dgvListMembers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvListMembers.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvListMembers.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvListMembers.ThemeStyle.HeaderStyle.Height = 30;
            dgvListMembers.ThemeStyle.ReadOnly = true;
            dgvListMembers.ThemeStyle.RowsStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvListMembers.ThemeStyle.RowsStyle.Height = 29;
            // 
            // tbSearchMembers
            // 
            tbSearchMembers.CustomizableEdges = customizableEdges1;
            tbSearchMembers.DefaultText = "";
            tbSearchMembers.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchMembers.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchMembers.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchMembers.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchMembers.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchMembers.Font = new Font("Cairo", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchMembers.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchMembers.Location = new Point(22, 52);
            tbSearchMembers.Margin = new Padding(8, 11, 8, 11);
            tbSearchMembers.Name = "tbSearchMembers";
            tbSearchMembers.PlaceholderText = "Search With Name";
            tbSearchMembers.SelectedText = "";
            tbSearchMembers.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbSearchMembers.Size = new Size(542, 46);
            tbSearchMembers.TabIndex = 13;
            tbSearchMembers.TextChanged += tbSearchMembers_TextChanged;
            // 
            // btnAddMember
            // 
            btnAddMember.BorderRadius = 3;
            btnAddMember.CustomizableEdges = customizableEdges3;
            btnAddMember.DisabledState.BorderColor = Color.DarkGray;
            btnAddMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddMember.FillColor = Color.MediumOrchid;
            btnAddMember.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(1013, 52);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddMember.Size = new Size(168, 46);
            btnAddMember.TabIndex = 11;
            btnAddMember.Text = " Add";
            btnAddMember.Click += btnAddMember_Click;
            // 
            // cmsOptions
            // 
            cmsOptions.BackColor = SystemColors.ButtonHighlight;
            cmsOptions.Font = new Font("Cairo Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsOptions.RenderStyle.BorderColor = Color.Gainsboro;
            cmsOptions.RenderStyle.ColorTable = null;
            cmsOptions.RenderStyle.RoundedEdges = true;
            cmsOptions.RenderStyle.SelectionArrowColor = Color.White;
            cmsOptions.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsOptions.RenderStyle.SelectionForeColor = Color.White;
            cmsOptions.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsOptions.Size = new Size(134, 72);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.EditIcon;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(133, 34);
            editToolStripMenuItem.Text = " Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            deleteToolStripMenuItem.Image = Properties.Resources.DeleteIcon;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(133, 34);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 645);
            Controls.Add(BooksPanel);
            Controls.Add(label1);
            Name = "frmMembers";
            Text = "Members";
            Load += frmMembers_Load;
            BooksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).EndInit();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel BooksPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListMembers;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchMembers;
        private Guna.UI2.WinForms.Guna2TileButton btnAddMember;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}