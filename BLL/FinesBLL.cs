using DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FinesBLL
    {
        public int FineID { get; set; }
        public decimal Amount { get; set; }
        public int DelayedDays  { get; set; }
        public int BorrowID { get; set; }
        public DateTime DateIssued { get; set; }
        public bool IsPaid { get; set; }


        public FinesBLL ()
        {
            FineID = -1;
            Amount = 0;
            DelayedDays = 0;
            BorrowID = -1;
            DateIssued = DateTime.Now;
            IsPaid = false;
        }

        private FinesBLL (int fineID, decimal amount, int delayedDays, int borrowID, DateTime datePaid, bool isPaid )
        {
            FineID = fineID;
            Amount = amount;
            DelayedDays = delayedDays;
            BorrowID = borrowID;
            DateIssued = datePaid;
            IsPaid = isPaid;
        }
    
        
        public bool AddNewFine()
        {
            this.FineID = FinesDAL.AddNewFine(this.Amount , this.DelayedDays ,this.BorrowID, this.DateIssued , this.IsPaid);
            return (this.FineID != -1);
        }
    

        public static DataTable ListFines()
        {
            return FinesDAL.ListAllFines();
        }

    
        /*
         * Check Difference between dates: due date - return date
         * if the delayed days > 0 => add new fines 
         * based on each delayed costs 10$ => multipy each delayed day with this amount.
         * 
         */

        public static FinesBLL CreateFineIfLate(int BorrowID,  DateTime DueDate)
        {
            
            int DelayedDays = (DateTime.Now.Date -DueDate.Date).Days;
            const decimal FinePerDay = 10m;
            if (DelayedDays <= 0)
            {
                return null; // no fines for this member.
            }
            else
            {
                return new FinesBLL
                {
                    BorrowID = BorrowID,
                    Amount = DelayedDays *FinePerDay,
                    DelayedDays = DelayedDays,
                    DateIssued = DateTime.Now,
                    IsPaid = false
                };
            }
            
        }

        /*
         * Check if the current member have unpaid fines before.
         * prevent this member from make borrowings until paying late fines.
         * 
         */
    
        public static bool IsMemberGotFines(int MemberID)
        {
            return FinesDAL.IsMemberGotFines(MemberID);
        }


        public static bool PayFine(int FineID)
        {
            return FinesDAL.PayFine(FineID);
        }
    
    }
}
