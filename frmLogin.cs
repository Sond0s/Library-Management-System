

using BLL;

namespace LibraryManagmentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void LoginUser()
        {

            if (string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(mtbPassword.Text))
            {
                MessageBox.Show("One of the fields is empty.");
                return;
            }

            //Create new user Obj 
            UsersBLL CurrentUser = new UsersBLL(tbUsername.Text , mtbPassword.Text);

            if(CurrentUser.Login())
            {
                MessageBox.Show("Login Successfully.");
                Form frm = new frmDashboard(CurrentUser);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
    }
}
