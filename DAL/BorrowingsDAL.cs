using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowingsDAL
    {

        public static DataTable ListAllBorrowings()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"SELECT Borrowings.BorrowID, Books.Title,  Borrowings.BorrowDate, Borrowings.DueDate, Members.Name, Borrowings.ReturnDate,
                    CASE
                        WHEN Borrowings.ReturnDate IS NULL
                        THEN 'Borrowed'
                        ELSE 'Returned'
                    END AS Status

                            from Borrowings
                            JOIN 
                            Members
                            ON Borrowings.MemberID = Members.MemberID
                            JOIN 
                            BookCopies
                            ON 
                            Borrowings.BookCopyID = BookCopies.BookCopyID
                            JOIN 
                            Books
                            ON 
                            BookCopies.BookID = Books.BookID;
                         
";

            SqlCommand cmd = new SqlCommand(query, conn);   

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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

            return dt;
        }

        public static DataTable ListTitlesFilter(string Title)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"SELECT Books.Title, Borrowings.BorrowID, Borrowings.BorrowDate, Borrowings.DueDate, Members.Name, Borrowings.ReturnDate,
                                CASE
                                WHEN Borrowings.ReturnDate IS NULL
                                THEN 'Borrowed'
                                ELSE 'Returned'
                            END AS Status
                            from Borrowings
                            JOIN 
                            Members
                            ON Borrowings.MemberID = Members.MemberID
                            JOIN 
                            BookCopies
                            ON 
                            Borrowings.BookCopyID = BookCopies.BookCopyID
                            JOIN 
                            Books
                            ON 
                            BookCopies.BookID = Books.BookID
                                 Where Books.Title like  @Title + '%' ";

            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@Title", Title);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;

        }

        public static DataTable ListMembersFilter(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"SELECT Books.Title, Borrowings.BorrowID, Borrowings.BorrowDate, Borrowings.DueDate, Members.Name, Borrowings.ReturnDate,
                                 CASE
                        WHEN Borrowings.ReturnDate IS NULL
                        THEN 'Borrowed'
                        ELSE 'Returned'
                    END AS Status
                            from Borrowings
                            JOIN 
                            Members
                            ON Borrowings.MemberID = Members.MemberID
                            JOIN 
                            BookCopies
                            ON 
                            Borrowings.BookCopyID = BookCopies.BookCopyID
                            JOIN 
                            Books
                            ON 
                            BookCopies.BookID = Books.BookID
                            Where Members.Name like  @Name + '%' ";

            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;

        }

        public static int AddNewBorrow(DateTime BorrowDate , DateTime DueDate,  int MemberID, int BookCopyID)
        {
            int newID = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"INSERT INTO Borrowings
                            (
                                BorrowDate,
                                DueDate,
                                BookCopyID,
                                MemberID
                            )
                           VALUES (@BorrowDate ,@DueDate ,@BookCopyID,@MemberID);
                            Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BorrowDate", BorrowDate);
            cmd.Parameters.AddWithValue("@DueDate", DueDate);
            cmd.Parameters.AddWithValue("@BookCopyID", BookCopyID);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);


            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString() , out int ID))
                {
                    newID = ID;
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
            return newID;

        }


        //Change the availabilty status of Copies if the history deleted.
        public static bool DeleteBorrowHistory(int BorrowHistoryID )
        {
            bool Deleted = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string Query = @"Delete from Borrowings
                             Where BorrowID = @BorrowHistoryID;";
            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("@BorrowHistoryID", BorrowHistoryID);


            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Deleted = true;
                }
            }
            catch
            {
                throw;
            }
            finally { conn.Close(); }
            return Deleted;
        }
       
        public static bool UpdateReturnDate(int BorrowID , DateTime ReturnDate)
        {
            bool Updated = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Update Borrowings 
                              Set ReturnDate = @ReturnDate
                              Where BorrowID = @BorrowID";

            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("BorrowID", BorrowID);
            cmd.Parameters.AddWithValue("ReturnDate", ReturnDate);

            try
            {
                conn.Open(); 
                int rowsAffected = cmd.ExecuteNonQuery();
                Updated = (rowsAffected > 0);
            }
            catch
            {
                throw;
            }
            finally { conn.Close(); }



            return Updated;
        }


        //check the member whether he/she has borrowings before deletion process.
        public static bool HasBorrowings(int MemberID)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            bool Borrows = false;

            string query = @"Select top 1 BorrowID from Borrowings Where MemberID = @MemberID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int count = Convert.ToInt32(result);
                    Borrows = count > 0;
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

            return Borrows;
        }

 

    }
}
