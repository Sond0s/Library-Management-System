using BLL;
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
    public partial class frmBorrowings : Form
    {
        public frmBorrowings()
        {
            InitializeComponent();
        }

        private void _RefreshBorrowingsList()
        {
            DataTable dt = BorrowingsBLL.ListBorrowings();
            dgvBorrowings.DataSource = dt;
        }

        private void frmBorrowings_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingsList();
            _ChangeColors();
            cbSearchOpt.SelectedIndex = 0;
        }

        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnBorrowBook.FillColor = ThemeColor.btnColor;
        }

        private void tbSearchOpt_TextChanged(object sender, EventArgs e)
        {
            //incase of no input in the bar.
            //refresh data.
            if (string.IsNullOrWhiteSpace(tbSearchOpt.Text))
            {
                _RefreshBorrowingsList();
                return;
            }

            // 2 cases of Combo box selections: 
            // 1- Search borrowings by Book's Title.
            // 2- Search Borrowings by Member's Name.
            switch (cbSearchOpt.SelectedIndex)
            {

                case 0:
                    DataTable dtTitle = BorrowingsBLL.SearchBorrowWithTitle(tbSearchOpt.Text);
                    dgvBorrowings.DataSource = dtTitle;
                    break;

                case 1:
                    DataTable dtMembers = BorrowingsBLL.SearchBorrowWithName(tbSearchOpt.Text);
                    dgvBorrowings.DataSource = dtMembers;
                    break;

            }



        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrowBook();
            frm.ShowDialog();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            int BorrowID = (int)dgvBorrowings.CurrentRow.Cells["BorrowID"].Value;

            if (MessageBox.Show("Are you sure you want to delete this borrowing history?", "Delete History", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BorrowingsBLL.DeleteBorrow(BorrowID))
                {
                    MessageBox.Show("History Deleted Successfully.", "Success", MessageBoxButtons.OK);
                    _RefreshBorrowingsList();
                }
                else
                {
                    MessageBox.Show("Deletion Canceled.", "Failed", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void cmsReturn_Click(object sender, EventArgs e)
        {
            string currentMember = (string)dgvBorrowings.CurrentRow.Cells["Name"].Value;
            string currentBook = (string)dgvBorrowings.CurrentRow.Cells["Title"].Value;
            int BorrowID = (int)dgvBorrowings.CurrentRow.Cells["BorrowID"].Value;

            //Dates of the current row 
            DateTime DueDate = (DateTime)dgvBorrowings.CurrentRow.Cells["DueDate"].Value;


            int BookCopyID = BookCopiesBLL.GetBookCopyID(BorrowID);
            if (MessageBox.Show($"Member \'{currentMember}\' will return \'{currentBook}\'.", "Return" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FinesBLL fine = FinesBLL.CreateFineIfLate(BorrowID, DueDate);
                //Check if the member has fine.   
                if (fine != null)
                {
                    //add new fine if delayed days are checked.
                    fine.AddNewFine();
                    MessageBox.Show($"Member \'{currentMember}\' have delayed return with {fine.Amount} $ should be paid..", "Payment");
                }

                //then update the borrowing return status.
                BookCopiesBLL.UpdateStatus(BookCopyID, true);
                BorrowingsBLL.UpdateReturnDate(BorrowID, DateTime.Now);
                _RefreshBorrowingsList();

            }
        }

        private void dgvBorrowings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBorrowings.Columns[e.ColumnIndex].Name == "ReturnDate")
            {
                if (e.Value == DBNull.Value || e.Value == null)
                {
                    e.Value = "Not Returned Yet";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
