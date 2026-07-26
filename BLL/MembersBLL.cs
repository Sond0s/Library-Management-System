using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MembersBLL
    {

        public enum enMode {Add, Update};
        enMode Mode;
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }

        public MembersBLL()
        {
            MemberID = 0;
            Name = "";
            Address = "";
            Phone = "";
            Email = "";
            JoinDate = DateTime.Now;
            Mode = enMode.Add;
        }

        private MembersBLL (int ID , string Name, string Address, DateTime JoinDate, string Phone, string Email)
        {
            this.MemberID = ID; 
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.JoinDate = JoinDate;
            Mode = enMode.Update;
                
        }

        public static MembersBLL Find(int ID)
        {
            string Name = "", Address = "", Phone = "", Email = "";
            DateTime JoinDate  = DateTime.Now;

            if(MembersDAL.FindMemberByID(ID, ref Name , ref Address, ref JoinDate , ref Phone, ref Email))
            {
                return new MembersBLL(ID , Name , Address, JoinDate, Phone, Email);
            }
            else
            {
                return null;
            }
        }

        public static MembersBLL Find(string Name)
        {
            int ID = 0;
            string Address = "", Phone = "", Email = "";
            DateTime JoinDate = DateTime.Now;

            if (MembersDAL.FindMemberByName(ref ID,  Name, ref Address, ref JoinDate, ref Phone, ref Email))
            {
                return new MembersBLL(ID, Name, Address, JoinDate, Phone, Email);
            }
            else
            {
                return null;
            }
        }

        public static DataTable ListAllMembers()
        {
            return MembersDAL.GetAllMembers();
        }

        public static DataTable ListMembersWithName(string Name)
        {
            return MembersDAL.GetMembersWithNames(Name);
        }

        public bool AddNewMember()
        {
            this.MemberID = MembersDAL.AddNewMember(this.Name , this.Address, this.JoinDate , this.Phone , this.Email);
            return (this.MemberID != -1);
        }

        private bool UpdateMember()
        {
            return MembersDAL.UpdateMember(this.MemberID , this.Name , this.Address , this.JoinDate , this.Phone , this.Email);
        }

        public static bool DeleteMember(int ID)
        {
            return MembersDAL.DeleteMember(ID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if(AddNewMember())
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                case enMode.Update:
                    {
                        return UpdateMember();

                    }
            }
            return true;
        }

        public static int CountMembers()
        {
            if(MembersDAL.CountMembers() != -1)
            {
                return MembersDAL.CountMembers();
            }
            else
            {
                return -1;
            }
        }
            

        public static DataTable GetMembersNames()
        {
            return MembersDAL.GetMembersNames();
        }
    }
}
