namespace LibraryManagmentSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label4 = new Label();
            tbUsername = new TextBox();
            mtbPassword = new TextBox();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 13.1999989F, FontStyle.Bold);
            label3.Location = new Point(127, 111);
            label3.Name = "label3";
            label3.Size = new Size(117, 42);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 13.1999989F, FontStyle.Bold);
            label4.Location = new Point(127, 181);
            label4.Name = "label4";
            label4.Size = new Size(112, 42);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Cairo", 9F);
            tbUsername.Location = new Point(263, 113);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(267, 36);
            tbUsername.TabIndex = 0;
            // 
            // mtbPassword
            // 
            mtbPassword.Font = new Font("Cairo", 9F);
            mtbPassword.Location = new Point(263, 185);
            mtbPassword.Name = "mtbPassword";
            mtbPassword.Size = new Size(267, 36);
            mtbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(394, 40);
            label1.Name = "label1";
            label1.Size = new Size(252, 59);
            label1.TabIndex = 5;
            label1.Text = "The Book Shelf";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.ButtonHighlight;
            guna2Panel1.Controls.Add(btnLogin);
            guna2Panel1.Controls.Add(mtbPassword);
            guna2Panel1.Controls.Add(tbUsername);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(147, 121);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(757, 404);
            guna2Panel1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 3;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.DarkMagenta;
            btnLogin.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(301, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(170, 57);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 570);
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox tbUsername;
        private TextBox mtbPassword;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}
