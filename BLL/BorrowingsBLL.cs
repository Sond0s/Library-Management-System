using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BorrowingsBLL
    {
        //properties 
        public int BorrowID { get; set; }
        public DateTime BorrowDate {  get; set; }
        public DateTime DueDate{ get; set; }
        public DateTime ReturnDate { get; set; }
        
        public int MemberID { get; set; }

        public int BookCopyID { get; set; }

        //enum of status deleted
        //the status of the borrowing will be decided by the return date property.


        public BorrowingsBLL()
        {
            this.BorrowID = -1;
            this.BorrowDate = DateTime.Now;
            this.DueDate = DateTime.Now;
            this.ReturnDate = DateTime.Now;
            this.MemberID = -1;
            this.BookCopyID = -1;
            //default value of any book is available (already returned)
        }
        private BorrowingsBLL(int BorrowID , DateTime BorrowDate ,  DateTime ReturnDate , int MemberID, int BookID)
        {
            this.BorrowID = BorrowID;
            this.DueDate = ReturnDate;
            this.BorrowDate = BorrowDate;
            this.MemberID = MemberID;
            this.BookCopyID = BookID;
        }


        public static DataTable ListBorrowings()
        {
            return BorrowingsDAL.ListAllBorrowings();
        }

        public static DataTable SearchBorrowWithTitle(string title)
        {
            DataTable dt = BorrowingsDAL.ListTitlesFilter(title);
            return dt;
        }

        public static DataTable SearchBorrowWithName(string MemberName)
        {
            DataTable dt = BorrowingsDAL.ListMembersFilter(MemberName);
            return dt;
        }


        public bool AddNewBorrow()
        {

            this.BorrowID = BorrowingsDAL.AddNewBorrow(this.BorrowDate , this.DueDate ,  this.MemberID , this.BookCopyID);
            return (this.BorrowID != -1);
        }

        public static bool DeleteBorrow(int BorrowID)
        {
            return BorrowingsDAL.DeleteBorrowHistory(BorrowID);
        }

        public static bool UpdateReturnDate(int BorrowID ,  DateTime ReturnDate)
        {
            return BorrowingsDAL.UpdateReturnDate(BorrowID , ReturnDate);
        }

        public static bool HasBorrowings(int MemberID)
        {
            return BorrowingsDAL.HasBorrowings(MemberID);
        }

    }
}
