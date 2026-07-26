using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookCopiesDAL
    {

        public static int GetAvailableBookCopy(int BookID)
        {
            int CopyID = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            //get only one result set if the book already exists.
            string query = @"Select top 1 BookCopyID from BookCopies Where IsAvailable = 1 AND BookID = @BookID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    CopyID = ID;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return CopyID;
        }


        //change availability of books after borrowing - returning.
        public static bool UpdateAvailability(int BookCopyID , bool status)
        {
            bool updated = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Update BookCopies
                             Set IsAvailable = @status
                              Where BookCopyID = @BookCopyID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@BookCopyID", BookCopyID);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                updated = (rowsAffected > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return updated;
        }


        public static int GetBookCopyID(int BorrowID)
        {
            int ID = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select BookCopyID from Borrowings where BorrowID = @BorrowID";
            SqlCommand cmd= new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BorrowID", BorrowID);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString() , out int Id) )
                {
                    ID = Id;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ID;


        }

        public static int CountBookCopies(int BookID)
        {
            int Count = 0;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select Count(*)
                                from BookCopies 
                                Where BookID = @BookID ";

            SqlCommand cmd = new SqlCommand (query, conn);
            cmd.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString() , out int r))
                {
                    Count = r;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return Count;
        }
    }
}
