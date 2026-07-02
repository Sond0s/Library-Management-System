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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblBooksTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvFines = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblFines = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvFines).BeginInit();
            guna2Panel1.SuspendLayout();
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
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.MediumOrchid;
            dataGridViewCellStyle5.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFines.ColumnHeadersHeight = 30;
            dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvFines.DefaultCellStyle = dataGridViewCellStyle6;
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
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = SystemColors.ButtonFace;
            guna2Panel1.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Panel1.Location = new Point(46, 141);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            // frmFines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 700);
            Controls.Add(guna2Panel1);
            Controls.Add(lblBooksTitle);
            Name = "frmFines";
            Text = "Fines";
            Load += frmFines_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFines).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooksTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFines;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFines;
    }
}