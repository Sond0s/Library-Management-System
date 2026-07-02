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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dgvListMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tbSearchMembers = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddMember = new Guna.UI2.WinForms.Guna2TileButton();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).BeginInit();
            cmsOptions.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(490, 35);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 1;
            label1.Text = "Library Members";
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
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
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListMembers.GridColor = Color.FromArgb(231, 229, 255);
            dgvListMembers.Location = new Point(31, 152);
            dgvListMembers.Name = "dgvListMembers";
            dgvListMembers.ReadOnly = true;
            dgvListMembers.RowHeadersVisible = false;
            dgvListMembers.RowHeadersWidth = 51;
            dgvListMembers.Size = new Size(1172, 404);
            dgvListMembers.TabIndex = 9;
            dgvListMembers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvListMembers.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvListMembers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListMembers.ThemeStyle.HeaderStyle.Height = 30;
            dgvListMembers.ThemeStyle.ReadOnly = true;
            dgvListMembers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListMembers.ThemeStyle.RowsStyle.Height = 29;
            // 
            // cmsOptions
            // 
            cmsOptions.BackColor = SystemColors.ButtonHighlight;
            cmsOptions.Font = new Font("Cairo Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RenderStyle.ArrowColor = Color.MediumOrchid;
            cmsOptions.RenderStyle.BorderColor = Color.Gainsboro;
            cmsOptions.RenderStyle.ColorTable = null;
            cmsOptions.RenderStyle.RoundedEdges = true;
            cmsOptions.RenderStyle.SelectionArrowColor = Color.White;
            cmsOptions.RenderStyle.SelectionBackColor = Color.DarkMagenta;
            cmsOptions.RenderStyle.SelectionForeColor = Color.White;
            cmsOptions.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsOptions.Size = new Size(215, 100);
            // 
            // editToolStripMenuItem
            // 
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
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tbSearchMembers
            // 
            tbSearchMembers.BorderRadius = 5;
            tbSearchMembers.CustomizableEdges = customizableEdges1;
            tbSearchMembers.DefaultText = "";
            tbSearchMembers.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchMembers.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchMembers.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchMembers.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchMembers.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchMembers.Font = new Font("Cairo", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchMembers.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchMembers.Location = new Point(31, 54);
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
            btnAddMember.BorderRadius = 5;
            btnAddMember.CustomizableEdges = customizableEdges3;
            btnAddMember.DisabledState.BorderColor = Color.DarkGray;
            btnAddMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddMember.FillColor = Color.MediumOrchid;
            btnAddMember.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(1035, 54);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddMember.Size = new Size(168, 46);
            btnAddMember.TabIndex = 11;
            btnAddMember.Text = " Add";
            btnAddMember.Click += btnAddMember_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(dgvListMembers);
            guna2Panel1.Controls.Add(tbSearchMembers);
            guna2Panel1.Controls.Add(btnAddMember);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = SystemColors.ButtonFace;
            guna2Panel1.Location = new Point(27, 121);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1227, 565);
            guna2Panel1.TabIndex = 14;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 718);
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            Name = "frmMembers";
            Text = "Members";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).EndInit();
            cmsOptions.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListMembers;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchMembers;
        private Guna.UI2.WinForms.Guna2TileButton btnAddMember;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}