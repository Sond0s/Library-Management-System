using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BooksBLL
    {
        enum enMode { Add, Update };
        enMode Mode;

        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Details { get; set; }
        public int CategoryID { get; set; }
        public string ImagePath { get; set; }
        public string Author { get; set; }

        //default Constructor
        public BooksBLL()
        {
            BookID = -1;
            ISBN = "";
            Title = "";
            PublishDate = DateTime.Now;
            Details = "";
            CategoryID = 0;
            ImagePath = "";
            Author = "";
            Mode = enMode.Add;
        }

        //parametarized constructor 
        private BooksBLL(int BookID, string ISBN, string Title, DateTime PublishDate, string Details,
            int CategoryID, string ImagePath, string Author)
        {
            this.BookID = BookID;
            this.ISBN = ISBN;
            this.Title = Title;
            this.PublishDate = PublishDate;
            this.Details = Details;
            this.CategoryID = CategoryID;
            this.ImagePath = ImagePath;
            this.Author = Author;
            Mode = enMode.Update;
        }


        public static DataTable GetAllBooks()
        {
            return BooksDAL.ListAllBooks();
        }


        public bool AddNewBook()
        {
            this.BookID = BooksDAL.AddNewBook(this.ISBN, this.Title, this.PublishDate, this.Details, this.CategoryID, this.ImagePath, this.Author);
            //return true in case of the new book id not equal to -1.
            return (this.BookID != -1);
        }

        private bool _UpdateBook()
        {
            return BooksDAL.UpdateBookInfo(this.BookID, this.Title, this.ISBN, this.PublishDate, this.Details, this.CategoryID, this.ImagePath, this.Author);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (AddNewBook())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateBook();
            }
            return true;
        }

        public static BooksBLL Find(int ID)
        {
            string Title = "", ImagePath = "", Author = "", ISBN = "", Details = "";
            int CategoryID = -1;
            DateTime PublishDate = DateTime.Now;

            if (BooksDAL.FindBookByID(ID, ref Title, ref ISBN, ref PublishDate, ref Details, ref CategoryID,
               ref ImagePath, ref Author))
            {

                //return new object full of returned properties (using private parameterised constructor)
                return new BooksBLL(ID, ISBN, Title, PublishDate, Details, CategoryID, ImagePath, Author);
            }
            else
            {
                return null;
            }

        }

        public static BooksBLL Find(string Title)
        {
            int ID = -1, CategoryID = -1;
            DateTime PublishDate = DateTime.Now;
            string ImagePath = "", Author = "", ISBN = "", Details = "";

            if (BooksDAL.FindBookByName(ref ID, Title, ref ISBN, ref PublishDate, ref Details, ref CategoryID
                , ref ImagePath, ref Author))
            {
                return new BooksBLL(ID , ISBN , Title , PublishDate , Details , CategoryID , ImagePath, Author);    
            }
            else
            {
                return null;
            }
        }

        public static DataTable ListBooksByTitle(string Title)
        {
            return BooksDAL.SearchBooksByTitle(Title);
        }

        public static bool DeleteBook(int ID)
        {
            return BooksDAL.DeleteBookByID(ID);
        }

        public static int CountBooks()
        {
            if(BooksDAL.CountBooks() != -1)
            {
                return BooksDAL.CountBooks();
            }
            else

            {
                //no count values.
                return 0;
            }
            
        }

        public static DataTable ListBooksTitles()
        {
            return BooksDAL.GetBooksTitles();
        }

        //public static int GetBookIdByTitle(string Title)
        //{
        //    return BooksDAL.GetBookIdByTitle(Title);
        //}
    }
}
