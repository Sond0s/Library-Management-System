using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookCopiesBLL
    {
        public int BookCopyID { get; set; }
        public int BookID { get; set; }

        bool Status; //(1=> returned, 0 => Borrowed)


        public static int CheckBookCopy(int BookID)
        {
            return BookCopiesDAL.GetAvailableBookCopy(BookID);
        }

        public static bool UpdateStatus (int BookCopyID, bool status)
        {
            return BookCopiesDAL.UpdateAvailability(BookCopyID,status);
        }

        public static int GetBookCopyID(int BorrowID)
        {
            return BookCopiesDAL.GetBookCopyID(BorrowID);
        }

        public static int CountCopies(int BookID)
        {
            return BookCopiesDAL.CountBookCopies(BookID);
        }

    }
}
