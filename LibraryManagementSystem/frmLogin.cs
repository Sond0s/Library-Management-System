

using BLL;
using LibraryManagmentSystem.Properties;
using System.Xml.Serialization;

namespace LibraryManagmentSystem
{
    public partial class frmLogin : Form
    {
        public UsersBLL _CurrentUser;
        private bool _ShowPassword = false;

        public frmLogin()
        {
            _CurrentUser = new UsersBLL();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ThemeColor.BackColor;
            btnLogin.FillColor = ThemeColor.btnColor;
        }


        private void LoginUser()
        {

            if (string.IsNullOrWhiteSpace(mtbPassword.Text) ||
                 string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("One/both of the fields is empty.");
                return;
            }

            //Create new user Obj 
            _CurrentUser.Username = tbUsername.Text;
            _CurrentUser.Password = mtbPassword.Text;

            if (_CurrentUser.Login())
            {
                MessageBox.Show("Login Successfully.", "Succedded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = new frmDashboard(_CurrentUser);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            _ShowPassword = !_ShowPassword;

            if (_ShowPassword)
            {
                mtbPassword.UseSystemPasswordChar = false;
                pbShowPass.Image = Resources.icons8_eye_30;
            }
            else
            {
                mtbPassword.UseSystemPasswordChar = true;
                pbShowPass.Image = Resources.icons8_closed_eye_30;
            }
        }

        private void tbUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epLogin);
        }

        //close the form on clicking cancel - canceling the control of the error provider 
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
