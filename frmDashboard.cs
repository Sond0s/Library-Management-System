using BLL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class frmDashboard : Form
    {
        public UsersBLL _CurrentUser;

        public frmDashboard(UsersBLL CurrentUser)
        {
            //there is no need each time to define new UserBLL Object , just one for entire login process.
            InitializeComponent();
            _CurrentUser = CurrentUser;
            lblUsername.Text = $"Welcome! {CurrentUser.Username}";

        }

        private void ChangeMouseEnter(Label label)
        {
            label.Cursor = Cursors.Hand;
            label.ForeColor = Color.Blue;
        }

        private void ChangeMouseLeave(Label label)
        {
            label.Cursor = Cursors.Default;
            label.ForeColor = Color.Black;
        }


        private void lblMembers_Click(object sender, EventArgs e)
        {
            Form frm = new frmMembers();
            frm.ShowDialog();
            this.Hide();

        }

        private void lblBooks_Click(object sender, EventArgs e)
        {
            Form frm = new frmBooks();
            frm.ShowDialog();
            this.Hide();
        }

        private void lblMembers_MouseEnter(object sender, EventArgs e)
        {
            ChangeMouseEnter(lblMembers);
        }

        private void lblMembers_MouseLeave(object sender, EventArgs e)
        {
            ChangeMouseLeave(lblMembers);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BooksBLL.GetAllBooks();
            dgvDashboardBooks.DataSource = dt;
        }

        private void lblBooks_MouseEnter(object sender, EventArgs e)
        {
            ChangeMouseEnter(lblBooks);
        }

        private void lblBooks_MouseLeave(object sender, EventArgs e)
        {
            ChangeMouseLeave(lblBooks);
        }

    

    }
}
