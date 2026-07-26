
using Microsoft.Data.SqlClient;


namespace DAL

{
    public class UsersDAL
    {
        public static bool Login(string username , string password , ref int UserID, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select UserID , Permissions
                            from Users where Username = @username AND Password =@password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    Permissions = (int)reader["Permissions"];
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

            return isFound;
        }


        //public static bool IsUserExists(string username, string password)
        //{
        //    bool isFound = false;
        //    SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        //    string query = @"Select *
        //                    from Users where Username = @username AND Password =@password";

        //    SqlCommand cmd = new SqlCommand(query, conn);

        //    cmd.Parameters.AddWithValue("@Username", username);
        //    cmd.Parameters.AddWithValue("@Password", password);

        //    try
        //    {
        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            isFound = true;
        //        }
        //        reader.Close();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return isFound;
        //}


        //check permissions DAL function here: 
        //public static int GetPermissions(int UserID)
        //{
        //    int Permissions = 0;
        //    SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        //    string query = @"Select Permissions from Users Where UserID = @UserID";

        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@UserID", UserID);

        //    try
        //    {
        //        conn.Open();
        //        var result = cmd.ExecuteScalar();
        //        if(result != null && int.TryParse(result.ToString(), out int P))
        //        {
        //            Permissions = P;
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return Permissions;


        //}


    }
}
