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
            dgvListMembers = new DataGridView();
            label1 = new Label();
            btnAddMember = new Button();
            btnUpdateMember = new Button();
            btnDeleteMember = new Button();
            btnFindMember = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).BeginInit();
            SuspendLayout();
            // 
            // dgvListMembers
            // 
            dgvListMembers.AllowUserToAddRows = false;
            dgvListMembers.AllowUserToDeleteRows = false;
            dgvListMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListMembers.Location = new Point(-4, 82);
            dgvListMembers.Name = "dgvListMembers";
            dgvListMembers.RowHeadersWidth = 51;
            dgvListMembers.Size = new Size(1069, 310);
            dgvListMembers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 23);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 1;
            label1.Text = "Library Members";
            // 
            // btnAddMember
            // 
            btnAddMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMember.Location = new Point(60, 486);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(162, 40);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Add Member";
            btnAddMember.TextAlign = ContentAlignment.TopCenter;
            btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMember
            // 
            btnUpdateMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateMember.Location = new Point(291, 486);
            btnUpdateMember.Name = "btnUpdateMember";
            btnUpdateMember.Size = new Size(188, 40);
            btnUpdateMember.TabIndex = 3;
            btnUpdateMember.Text = "Update Member";
            btnUpdateMember.TextAlign = ContentAlignment.TopCenter;
            btnUpdateMember.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteMember.Location = new Point(561, 486);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(177, 40);
            btnDeleteMember.TabIndex = 4;
            btnDeleteMember.Text = "Delete Member";
            btnDeleteMember.TextAlign = ContentAlignment.TopCenter;
            btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // btnFindMember
            // 
            btnFindMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindMember.Location = new Point(814, 486);
            btnFindMember.Name = "btnFindMember";
            btnFindMember.Size = new Size(177, 40);
            btnFindMember.TabIndex = 5;
            btnFindMember.Text = "Find Member";
            btnFindMember.TextAlign = ContentAlignment.TopCenter;
            btnFindMember.UseVisualStyleBackColor = true;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 616);
            Controls.Add(btnFindMember);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnUpdateMember);
            Controls.Add(btnAddMember);
            Controls.Add(label1);
            Controls.Add(dgvListMembers);
            Name = "frmMembers";
            Text = "Form1";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListMembers;
        private Label label1;
        private Button btnAddMember;
        private Button btnUpdateMember;
        private Button btnDeleteMember;
        private Button btnFindMember;
    }
}