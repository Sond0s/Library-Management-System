using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FinesDAL
    {


        public static int AddNewFine( decimal Amount , int DelayedDays, int BorrowID , DateTime DateIssued, bool IsPaid )
        {
            //no need to add MemberID as a parameter 
            //although its in Borrowings Table
            // => no need to do Denormalization.
            int newID = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                string query = @" INSERT INTO [dbo].[Fines]
                                 VALUES
                                       (@Amount
                                       ,@DelayedDays
                                       ,@BorrowID
                                       ,@DateIssued
                                       ,@IsPaid);
                                select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@DelayedDays", DelayedDays);
            cmd.Parameters.AddWithValue("@BorrowID", BorrowID);
            cmd.Parameters.AddWithValue("@DateIssued" ,DateIssued);
            cmd.Parameters.AddWithValue("@IsPaid", IsPaid);


            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString() ,out int ID))
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
   
    
        public static DataTable ListAllFines()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"select Fines.FineID , Fines.Amount , Fines.DelayedDays, Members.Name , Fines.DateIssued,
                                CASE 
                                WHEN 
                                Fines.IsPaid = 0 THEN 'Pending'
                                ELSE
                                'Paid'
                                END AS Status
                                from Fines 
                                 JOIN 
                                 Borrowings 
                                 On Fines.BorrowID = Borrowings.BorrowID
                                 JOIN 
                                 Members 
                                 ON Borrowings.MemberID = Members.MemberID";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader =  cmd.ExecuteReader();
                if(reader.HasRows)
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


        public static bool IsMemberGotFines(int MemberID)
        {
            bool GotFines = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"select LateFines = 1
                            from Borrowings
                            JOIN 
                            Fines 
                            ON Fines.BorrowID = Borrowings.BorrowID
                            where Fines.IsPaid = 0 AND Borrowings.MemberID = @MemberID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString() , out int R))
                {
                    GotFines = true;
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





            return GotFines;
        }

        //Update fine Payment to Paid.
        public static bool PayFine(int FineID)
        {
            bool Paid = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Update Fines 
                             Set IsPaid = 1 
                             Where FineID = @FineID;";

            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@FineID", FineID);
            try
            {
                conn.Open();
                int rowAffected = cmd.ExecuteNonQuery();

                Paid = (rowAffected > 0);
            
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return Paid;
        }

    }
}
