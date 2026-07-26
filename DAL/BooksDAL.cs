using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BooksDAL
    {

        public static DataTable ListAllBooks()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"select BookID, Title, Author, ISBN , PublishDate 
                            from Books ";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
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


        public static int AddNewBook(string ISBN, string Title, DateTime PublishDate,
            string Details, int CategoryID, string ImagePath, string Author)
        {
            int NewBookID = -1;

            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"INSERT INTO Books
                            ([ISBN],[Title],[PublishDate],[Details],[CategoryID],[ImagePath],[Author])
                             VALUES (@ISBN, @Title, @PublishDate, @Details, @CategoryID, @ImagePath , @Author); 
                             Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@PublishDate", PublishDate);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@Author", Author);

            if (ImagePath == "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            }

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    NewBookID = ID;
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
            return NewBookID;
        }


        public static bool FindBookByID(int ID, ref string Title, ref string ISBN, ref DateTime PublishDate,
            ref string Details, ref int CategoryID, ref string ImagePath, ref string Author)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select * from Books where BookID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Title = (string)reader["Title"];
                    ISBN = (string)reader["ISBN"];
                    PublishDate = (DateTime)reader["PublishDate"];
                    Details = (string)reader["Details"];
                    CategoryID = (int)reader["CategoryID"];
                    Author = (string)reader["Author"];

                    //handling (NULL) value of image path.
                    ImagePath = reader["ImagePath"] == DBNull.Value ? "NULL" : (string)reader["ImagePath"];
                }

            }
            catch 
            {
                isFound = false;
                throw;
            }

            finally
            {
                conn.Close();
            }
            return isFound;
        }


        public static bool UpdateBookInfo(int ID,  string Title, string ISBN,  DateTime PublishDate,
             string Details,  int CategoryID, string ImagePath,  string Author)
        {
            bool isUpdated = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"UPDATE Books
                                   SET Title = @Title
                                  ,ISBN = @ISBN
                                  ,PublishDate = @PublishDate
                                  ,Details = @Details
                                  ,CategoryID = @CategoryID
                                  ,ImagePath = @ImagePath
                                  ,Author = @Author
                                    WHERE BookID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@PublishDate", PublishDate);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@Author", Author);
            if (ImagePath == "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            try
            {
                conn.Open();
                int RowsAffected = cmd.ExecuteNonQuery();

                isUpdated = (RowsAffected > 0);

            }
            catch 
            {
                throw;

            }
            finally
            {
                conn.Close();
            }
            return isUpdated;
        }
    
    
        public static bool FindBookByName(ref int ID ,string Title, ref string ISBN, ref DateTime PublishDate,
            ref string Details, ref int CategoryID, ref string ImagePath, ref string Author)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select * from Books where Title = @Title";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", Title);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["BookID"];
                    ISBN = (string)reader["ISBN"];
                    PublishDate = (DateTime)reader["PublishDate"];
                    Details = (string)reader["Details"];
                    CategoryID = (int)reader["CategoryID"];
                    Author = (string)reader["Author"];

                    //handling (NULL) value of image path.
                    ImagePath = reader["ImagePath"] == DBNull.Value ? "NULL" : (string)reader["ImagePath"];
                }

            }
            catch 
            {
                isFound = false;
                throw;
            }

            finally
            {
                conn.Close();
            }
            return isFound;
        }
    
        //bind all data of search result in the data grid view.
        public static DataTable SearchBooksByTitle(string Title)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select BookID, Title, Author, ISBN , PublishDate 
                            from Books WHERE Title LIKE '%' + @Title + '%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", Title);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                
                reader.Close();

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


        public static bool DeleteBookByID(int ID)
        {
            int rowAffected = 0;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Delete from Books Where BookID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                 rowAffected= cmd.ExecuteNonQuery();
            }
            catch 
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return (rowAffected > 0);

        }

        //dashboard Count section
        public static int CountBooks()
        {
            int count = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select Count(*) from Books";

            SqlCommand cmd = new SqlCommand(query, conn);


            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    count = Count;
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


            //if the count result is not equal to -1 => then there is result value from the count query.
            return count;
        }


        public static DataTable GetBooksTitles()
        {

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select Title From Books";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
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


    }
}