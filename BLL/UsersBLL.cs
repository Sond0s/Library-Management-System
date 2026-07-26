using DAL;

namespace BLL
{
    public class UsersBLL
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Add permissions enum
        //[Flags]
        //here:
        public enum enPermissions
        {enNoAccess= 0, enAll = -1 , enBooks = 1 , enMembers = 2 , enBorrowings = 4 , enFines = 8};

        public enPermissions Permissions { get; set; }

        public UsersBLL()
        {
            UserID = -1;
            Username = "";
            Password = "";
            Permissions = 0;
        }

        public UsersBLL(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Login()
        {
            int userID = -1;
            int Permissions = 0;

           bool Found = UsersDAL.Login(this.Username, this.Password,ref userID, ref Permissions);
            if(Found)
            {
                this.UserID = userID;
                this.Permissions = (enPermissions)Permissions;
            }
            return Found;
        }


        //public bool IsUserExists()
        //{
        //    return UsersDAL.IsUserExists(this.Username, this.Password);
        //}
        public bool HasPermission (enPermissions permissions)
        {
            return ((Permissions & permissions) == permissions);
        }

    }
}
