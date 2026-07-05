using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            _RefreshBooksList();
            _ChangeColors();
        }

        private void _RefreshBooksList()
        {
            DataTable dt = new DataTable();
            dt = BooksBLL.GetAllBooks();
            dgvBooks.DataSource = dt;

        }

        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnAddBook.FillColor = ThemeColor.btnColor;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // -1 sample parameter.
            Form frm = new frmAddNewBook(-1);
            frm.ShowDialog();
            _RefreshBooksList();
        }

        //as the text being changed in the bar, as the grid view show new data as needed.
        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbSearchBar.Text))
            {
                _RefreshBooksList();
                return;
            }
            //Binding result data set into the data grid view.
            dgvBooks.DataSource = BooksBLL.ListBooksByTitle(tbSearchBar.Text);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookID = (int)dgvBooks.CurrentRow.Cells["BookID"].Value;
            int BookCopies = BookCopiesBLL.CountCopies(BookID);

            //prevent deletion in case of available copies in the system.
            if(BookCopies> 0)
            {
                MessageBox.Show("This book cannot be deleted because copies of it still exist." , "Failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }


            if (MessageBox.Show("Are You Sure you want to delete this Book ?", "Delete",
                MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BooksBLL.DeleteBook(BookID))
                {
                    MessageBox.Show("Book Deleted Successfully.", "Succeded", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    _RefreshBooksList();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Book", "Failed", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //update / edit the current row book info.
            //pass the ID to the add form.
            int BookID = (int)dgvBooks.CurrentRow.Cells["BookID"].Value;

            Form frm = new frmAddNewBook(BookID);
            frm.ShowDialog();
            _RefreshBooksList();
        }
    }
}
