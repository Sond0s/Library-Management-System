using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MembersDAL
    {

        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

            string query = @"Select * from Members";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
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


        public static DataTable GetMembersWithNames(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select * from Members Where Name Like '%' + @Name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", Name);

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
  
    
        //add new member to database 
        public static int AddNewMember(string Name , string Address , DateTime JoinDate, string Phone , string Email)
        {
            int NewMember = -1;

            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"INSERT INTO [Members]
                           ([Name]
                           ,[Address]
                           ,[JoinDate]
                           ,[Phone]
                           ,[Email])
                     VALUES
                           (@Name
                           ,@Address
                           ,@JoinDate
                           ,@Phone
                           ,@Email);
                        Select Scope_Identity();";
        
             SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@JoinDate", JoinDate);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);


            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int member))
                {
                    NewMember = member;
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
            return NewMember;

        }


        //update member 
        public static bool UpdateMember(int ID , string Name, string Address, DateTime JoinDate, string Phone, string Email)
        {
            bool Updated = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @" UPDATE [dbo].[Members]
                           SET [Name] =@Name
                              ,[Address] = @Address
                              ,[JoinDate] = @JoinDate
                              ,[Phone] = @Phone
                              ,[Email] = @Email
                         WHERE MemberID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.Parameters.AddWithValue("@Name", Name);

            cmd.Parameters.AddWithValue("@Address", Address);

            cmd.Parameters.AddWithValue("@JoinDate", JoinDate);

            cmd.Parameters.AddWithValue("@Phone", Phone);
            
            cmd.Parameters.AddWithValue("@Email", Email);

            try
            {
                conn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    Updated = true;
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

            return Updated;
        }


        //find member 
        public static bool FindMemberByID(int ID, ref string Name , ref string  Address , ref DateTime JoinDate, ref string Phone , ref string Email)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select * from Members Where MemberID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.Read())
                {
                    isFound = true;
                    Name = (string)rd["Name"];
                    Address = (string)rd["Address"];
                    JoinDate = (DateTime)rd["JoinDate"];
                    Phone = (string)rd["Phone"];
                    Email = (string)rd["Email"];
                }
                rd.Close();
            }
            catch
            {
                throw;
            }
            finally { conn.Close(); }

            return isFound;
        }

        public static bool FindMemberByName(ref int ID, string Name, ref string Address, ref DateTime JoinDate, ref string Phone, ref string Email)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select * from Members Where Name = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    isFound = true;
                    ID = (int)rd["MemberID"];
                    Address = (string)rd["Address"];
                    JoinDate = (DateTime)rd["JoinDate"];
                    Phone = (string)rd["Phone"];
                    Email = (string)rd["Email"];
                }
                rd.Close();
            }
            catch
            {
                throw;
            }
            finally { conn.Close(); }

            return isFound;
        }


        //delete member 
        public static bool DeleteMember(int ID)
        {
            bool Deleted = false;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Delete From Members where MemberID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    Deleted = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            { conn.Close(); }
            return Deleted;


        }


        //Count Members.
        public static int CountMembers()
        {
            int count = -1;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string query = @"Select Count(*) from Members";
            SqlCommand cmd = new SqlCommand(@query, conn);  

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString() , out int Count))
                {
                    count = Count;
                }
            }
            catch
            {
                throw; ;
            }
            finally { conn.Close(); }



            return count;
        }
        


        //Members combo box options for borrowing process.
        public static DataTable GetMembersNames()
        {
            
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

                string query = @"Select Name from Members";
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