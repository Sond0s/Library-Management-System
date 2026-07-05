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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label3 = new Label();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pbShowPass = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            mtbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            epLogin = new ErrorProvider(components);
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epLogin).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 64);
            label3.Location = new Point(396, 65);
            label3.Name = "label3";
            label3.Size = new Size(127, 75);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(538, 41);
            label1.Name = "label1";
            label1.Size = new Size(280, 71);
            label1.TabIndex = 5;
            label1.Text = "The BookShelf";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(pbShowPass);
            guna2Panel1.Controls.Add(btnLogin);
            guna2Panel1.Controls.Add(tbUsername);
            guna2Panel1.Controls.Add(mtbPassword);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.FillColor = SystemColors.ButtonHighlight;
            guna2Panel1.Location = new Point(227, 152);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Padding = new Padding(10);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(909, 498);
            guna2Panel1.TabIndex = 6;
            // 
            // pbShowPass
            // 
            pbShowPass.BackColor = Color.GhostWhite;
            pbShowPass.FillColor = Color.GhostWhite;
            pbShowPass.Image = Properties.Resources.icons8_closed_eye_30;
            pbShowPass.ImageRotate = 0F;
            pbShowPass.Location = new Point(587, 263);
            pbShowPass.Name = "pbShowPass";
            pbShowPass.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbShowPass.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbShowPass.Size = new Size(49, 27);
            pbShowPass.TabIndex = 3;
            pbShowPass.TabStop = false;
            pbShowPass.Click += pbShowPass_Click;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 15;
            btnLogin.CustomizableEdges = customizableEdges2;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.DarkMagenta;
            btnLogin.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(295, 371);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogin.Size = new Size(296, 66);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // tbUsername
            // 
            tbUsername.BorderColor = SystemColors.ControlLight;
            tbUsername.BorderRadius = 15;
            tbUsername.CustomizableEdges = customizableEdges4;
            tbUsername.DefaultText = "";
            tbUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbUsername.FillColor = Color.GhostWhite;
            tbUsername.FocusedState.BorderColor = Color.FromArgb(64, 0, 64);
            tbUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.Black;
            tbUsername.HoverState.BorderColor = Color.Purple;
            tbUsername.IconLeft = Properties.Resources.icons8_user_50;
            tbUsername.Location = new Point(238, 159);
            tbUsername.Margin = new Padding(7, 25, 7, 25);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderForeColor = Color.DarkGray;
            tbUsername.PlaceholderText = "Username";
            tbUsername.SelectedText = "";
            tbUsername.ShadowDecoration.CustomizableEdges = customizableEdges5;
            tbUsername.Size = new Size(407, 60);
            tbUsername.TabIndex = 0;
            tbUsername.Validating += tbUsername_Validating;
            // 
            // mtbPassword
            // 
            mtbPassword.BorderColor = SystemColors.ControlLight;
            mtbPassword.BorderRadius = 15;
            mtbPassword.CustomizableEdges = customizableEdges6;
            mtbPassword.DefaultText = "";
            mtbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            mtbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            mtbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            mtbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            mtbPassword.FillColor = Color.GhostWhite;
            mtbPassword.FocusedState.BorderColor = Color.FromArgb(64, 0, 64);
            mtbPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbPassword.ForeColor = Color.Black;
            mtbPassword.HoverState.BorderColor = Color.Purple;
            mtbPassword.IconLeft = Properties.Resources.icons8_lock_50;
            mtbPassword.Location = new Point(238, 247);
            mtbPassword.Margin = new Padding(11, 50, 11, 50);
            mtbPassword.Name = "mtbPassword";
            mtbPassword.PlaceholderForeColor = Color.DarkGray;
            mtbPassword.PlaceholderText = "Password";
            mtbPassword.SelectedText = "";
            mtbPassword.ShadowDecoration.CustomizableEdges = customizableEdges7;
            mtbPassword.Size = new Size(407, 60);
            mtbPassword.TabIndex = 1;
            mtbPassword.UseSystemPasswordChar = true;
            // 
            // epLogin
            // 
            epLogin.ContainerControl = this;
            epLogin.Icon = (Icon)resources.GetObject("epLogin.Icon");
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.blurred;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 712);
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Login";
            FormClosing += frmLogin_FormClosing;
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)epLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2TextBox mtbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbShowPass;
        private ErrorProvider epLogin;
    }
}
