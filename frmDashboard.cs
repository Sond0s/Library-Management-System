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
            lblUsername.Text = $"Hello, {CurrentUser.Username}";

        }

        private void ChangeMouseEnter(Label label)
        {
            label.Cursor = Cursors.Hand;
            label.ForeColor = ThemeColor.BackColor;
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

        }

        private void lblBooks_Click(object sender, EventArgs e)
        {
            Form frm = new frmBooks();
            frm.ShowDialog();
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
            //Load all the data of the views.
            LoadDataGridLists();

            //ColorTranslator.FromHtml("#A536D1")
            this.BackColor = ThemeColor.BackColor;
            btnLogout.FillColor = ThemeColor.btnColor;
            //Get today's date.
            string Date = DateTime.Now.ToString();
            lblTodayTime.Text = Date;
        }

        private void LoadDataGridLists()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = BooksBLL.GetAllBooks();
            dt2 = MembersBLL.ListAllMembers();
            dgvDashboardBooks.DataSource = dt1;
            dgvDashboardMembers.DataSource = dt2;
        }

        private void lblBooks_MouseEnter(object sender, EventArgs e)
        {
            ChangeMouseEnter(lblBooks);
        }

        private void lblBooks_MouseLeave(object sender, EventArgs e)
        {
            ChangeMouseLeave(lblBooks);
        }

        private void lblBorrowings_MouseEnter(object sender, EventArgs e)
        {
            ChangeMouseEnter(lblBorrowings);
        }

        private void lblBorrowings_MouseLeave(object sender, EventArgs e)
        {
            ChangeMouseLeave(lblBorrowings);
        }

        private void lblFines_MouseEnter(object sender, EventArgs e)
        {
            ChangeMouseEnter(lblFines);
        }

        private void lblFines_MouseLeave(object sender, EventArgs e)
        {
            ChangeMouseLeave(lblFines);
        }
    }
}
