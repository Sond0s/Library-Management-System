using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {

        public static bool FindCategoryByID(int ID, ref string CategoryName)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select * from Categories
                                Where CategoryID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID" , ID);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CategoryName = (string)reader["CategoryName"];
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
            return IsFound;
        }

        public static bool FindCategoryByName(ref int ID , string CategoryName)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select * from Categories
                                Where CategoryName = @CategoryName";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CategoryName" , CategoryName);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["CategoryID"];
                    IsFound = true;
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
            return IsFound;
        }


        public static DataTable ListAllCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select CategoryName from Categories";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    dt.Load(sqlDataReader);
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

    }
}
