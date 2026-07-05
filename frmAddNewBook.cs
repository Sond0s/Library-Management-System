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
    public partial class frmAddNewBook : Form
    {
        public enum enMode { Add, Update };
        enMode Mode;
        //passed parameter value to check whether the book in update or add mode.
        private int _BookID;
        //Book=  1- new book || = 2- Find(BookCopyID)
        BooksBLL Book;

        public frmAddNewBook(int BookID)
        {
            InitializeComponent();
            //I'll use the same form in the 2 Cases : 1- Add 2- Update
            //if BookCopyID = -1 => get the form use in the Add mode.
            //otherwise , the form use will be in Update Mode (Edit).
            _BookID = BookID;
            if (BookID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
            }


        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            LoadData();
            ChangeColors();
        }

        private void ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnSaveBook.FillColor = ThemeColor.btnColor;
            btnCancelBook.FillColor = ThemeColor.btnColor;
        }

        private void LoadCategories()
        {
            dtPublishDate.Value = DateTime.Now;
            DataTable dt = CategoriesBLL.ListAllCategories();

            //loop through each row in the data table and fill the combo box items with the given values.
            foreach (DataRow dr in dt.Rows)
            {
                cbCategory.Items.Add(dr["CategoryName"]);
            }
        }

        private void LoadData()
        {
            //set the default value of the combo box to the first selection.
            LoadCategories();
            llRemoveImg.Visible = pbBookimg.ImageLocation != null;

            //default value of the combo box.
            cbCategory.SelectedIndex = 0;

            if (Mode == enMode.Add)
            {
                //the passed parameter == -1.
                Book = new BooksBLL();
                //move to (Save button) Function after returning.
                return;
            }
            //otherwise , the book in the update mode.
            //FindCategoryByName the book's info through (FindCategoryByName) Function.
            Book = BooksBLL.Find(_BookID);
            if (Book == null)
            {
                MessageBox.Show("Book not found.");
                this.Close();
                return;
            }
            lblAddNewBook.Text = "Update Book";
            lblID.Text = _BookID.ToString();
            tbTitle.Text = Book.Title;
            tbAuthor.Text = Book.Author;
            tbISBN.Text = Book.ISBN;
            tbDetails.Text = Book.Details;
            dtPublishDate.Value = Book.PublishDate;

            if (Book.ImagePath != null)
            {
                pbBookimg.ImageLocation = Book.ImagePath;
            }

            llRemoveImg.Visible = (Book.ImagePath != null);

            cbCategory.SelectedIndex = cbCategory.FindString(CategoriesBLL.FindCategoryByID(Book.CategoryID).CategoryName);



        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            //check required fields before save.
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the highlighted fields before saving.", "Validation Error");
                return;
            }

            int CategoryID = CategoriesBLL.FindCategoryByName(cbCategory.Text).CategoryID;

            Book.Title = tbTitle.Text;
            Book.ISBN = tbISBN.Text;
            Book.PublishDate = dtPublishDate.Value;
            Book.Details = tbDetails.Text;
            Book.CategoryID = CategoryID; //default value till add the combo box exchanging value.
            Book.Author = tbAuthor.Text;
            if (pbBookimg.ImageLocation == null)
            {
                Book.ImagePath = "";
            }
            else
            {
                Book.ImagePath = pbBookimg.ImageLocation;
            }

            //switch between the 2 modes
            if (Mode == enMode.Add)
            {
                if (Book.Save())
                {
                    MessageBox.Show("Book Added Successfully.", "Success" , MessageBoxButtons.OK 
                        , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add new book." , "Failed", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }

            if (Mode == enMode.Update)
            {
                if (Book.Save())
                {
                    MessageBox.Show("Book Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update the book.", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }


        }

        private void llAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdBook.Title = "Browsing";
            ofdBook.InitialDirectory = @"E:\";
            ofdBook.DefaultExt = "jpeg";
            ofdBook.Filter = "Images | *.png; *.jpg; *.jpeg";
            ofdBook.RestoreDirectory = true;

            if (ofdBook.ShowDialog() == DialogResult.OK)
            {
                pbBookimg.ImageLocation = ofdBook.FileName;
            }
            llRemoveImg.Visible = true;
        }

        private void llRemoveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbBookimg.Image = null;
            pbBookimg.ImageLocation = null;
            pbBookimg.Visible = false;
            llRemoveImg.Visible = false;

        }

        //Title - ISBN - Details - Author => Required.
        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddBook);
        }

        private void tbISBN_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddBook);
        }

        private void tbAuthor_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddBook);

        }

        private void tbDetails_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddBook);

        }
    }
}
