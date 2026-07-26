namespace LibraryManagmentSystem
{
    partial class frmFines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFines));
            lblBooksTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvFines = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblFines = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            cmdPayFine = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvFines).BeginInit();
            guna2Panel1.SuspendLayout();
            cmsOptions.SuspendLayout();
            SuspendLayout();
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.BackColor = Color.Transparent;
            lblBooksTitle.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooksTitle.ForeColor = SystemColors.ButtonHighlight;
            lblBooksTitle.Location = new Point(565, 53);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(101, 47);
            lblBooksTitle.TabIndex = 11;
            lblBooksTitle.Text = "Fines";
            lblBooksTitle.TextAlignment = ContentAlignment.TopCenter;
            // 
            // dgvFines
            // 
            dgvFines.AllowUserToAddRows = false;
            dgvFines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFines.ColumnHeadersHeight = 30;
            dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvFines.ContextMenuStrip = cmsOptions;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFines.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFines.GridColor = Color.FromArgb(231, 229, 255);
            dgvFines.Location = new Point(51, 78);
            dgvFines.Name = "dgvFines";
            dgvFines.ReadOnly = true;
            dgvFines.RowHeadersVisible = false;
            dgvFines.RowHeadersWidth = 51;
            dgvFines.Size = new Size(1050, 437);
            dgvFines.TabIndex = 12;
            dgvFines.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFines.ThemeStyle.HeaderStyle.BackColor = Color.MediumOrchid;
            dgvFines.ThemeStyle.HeaderStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvFines.ThemeStyle.HeaderStyle.Height = 30;
            dgvFines.ThemeStyle.ReadOnly = true;
            dgvFines.ThemeStyle.RowsStyle.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvFines.ThemeStyle.RowsStyle.Height = 29;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(lblFines);
            guna2Panel1.Controls.Add(dgvFines);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = SystemColors.ButtonFace;
            guna2Panel1.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Panel1.Location = new Point(46, 141);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1149, 547);
            guna2Panel1.TabIndex = 13;
            // 
            // lblFines
            // 
            lblFines.BackColor = Color.Transparent;
            lblFines.Font = new Font("Cairo", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFines.Location = new Point(375, 248);
            lblFines.Name = "lblFines";
            lblFines.Size = new Size(16, 64);
            lblFines.TabIndex = 13;
            lblFines.Text = "-";
            lblFines.Visible = false;
            // 
            // cmsOptions
            // 
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { cmdPayFine });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RenderStyle.ArrowColor = Color.DarkMagenta;
            cmsOptions.RenderStyle.BorderColor = Color.Gainsboro;
            cmsOptions.RenderStyle.ColorTable = null;
            cmsOptions.RenderStyle.RoundedEdges = true;
            cmsOptions.RenderStyle.SelectionArrowColor = Color.White;
            cmsOptions.RenderStyle.SelectionBackColor = Color.MediumOrchid;
            cmsOptions.RenderStyle.SelectionForeColor = Color.White;
            cmsOptions.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsOptions.Size = new Size(215, 66);
            // 
            // cmdPayFine
            // 
            cmdPayFine.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdPayFine.Image = Properties.Resources.icons8_pay_50;
            cmdPayFine.Name = "cmdPayFine";
            cmdPayFine.Size = new Size(214, 34);
            cmdPayFine.Text = "Pay Fine";
            cmdPayFine.Click += cmdPayFine_Click;
            // 
            // frmFines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 700);
            Controls.Add(guna2Panel1);
            Controls.Add(lblBooksTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFines";
            Text = "Fines";
            Load += frmFines_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFines).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooksTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFines;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFines;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private ToolStripMenuItem cmdPayFine;
    }
}