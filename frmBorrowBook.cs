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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagmentSystem
{
    public partial class frmBorrowBook : Form
    {
        public BorrowingsBLL Borrowing;

        public frmBorrowBook()
        {
            InitializeComponent();
            //initialize new object
            Borrowing = new BorrowingsBLL();
        }

        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            _ChangeColors();
            _LoadBooksTitles();
            _LoadMembersNames();
            //Default values
            dtpCurrentDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;

        }

        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnSave.FillColor = ThemeColor.btnColor;
            btnCancel.FillColor = ThemeColor.btnColor;

        }

        private void _LoadBooksTitles()
        {

            DataTable dtBooks = BooksBLL.ListBooksTitles();

            foreach (DataRow dr in dtBooks.Rows)
            {
                cbChooseBook.Items.Add(dr["Title"]);
            }

        }

        private void _LoadMembersNames()
        {
            DataTable dtMembers = MembersBLL.GetMembersNames(); ;

            foreach (DataRow dr in dtMembers.Rows)
            {
                cbChooseMember.Items.Add(dr["Name"]);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //first check whether the user didnt select any option.
            if (cbChooseBook.SelectedIndex == -1 ||
                cbChooseMember.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book and a member.");
                return;
            }

            int MemberID = MembersBLL.Find(cbChooseMember.Text).MemberID;
            int BookID = BooksBLL.Find(cbChooseBook.Text).BookID;   

            int CopyID = BookCopiesBLL.CheckBookCopy(BookID);
       
            if(FinesBLL.IsMemberGotFines(MemberID))
            {
                MessageBox.Show("This member has unpaid fines and cannot borrow new books until all fines are settled.");
                return;
            }


            //check availability of selected copy.
            if (CopyID == -1)
            {
                MessageBox.Show("No Available copy of the chosen book.");
                return;
            }

            Borrowing.MemberID = MemberID;

            Borrowing.BookCopyID = CopyID;

            Borrowing.BorrowDate = dtpCurrentDate.Value;
            
            Borrowing.DueDate = dtpDueDate.Value;
            
      

                if (Borrowing.AddNewBorrow())
            {
                MessageBox.Show("Borrow Added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add new Borrow.");
            }

            //change availability status to Borrowed (0) 
            BookCopiesBLL.UpdateStatus(CopyID, false);

        }
    }
}
