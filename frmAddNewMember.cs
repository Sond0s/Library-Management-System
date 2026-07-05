using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class frmAddNewMember : Form
    {

        //Mode for check whether the member is new or needs update.
        public enum enMode { Add, Update };
        private enMode Mode;

        //Current Member's ID (if -1 => New, otherwise Update).
        private int _MemberID;

        //current member Object.
        MembersBLL Member;

        //check the ID by the passed parameter to the constructor.
        public frmAddNewMember(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
            if (MemberID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
            }
        }


        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnSaveMember.FillColor = ThemeColor.btnColor;
            btnCancelMember.FillColor = ThemeColor.btnColor;
        }


        private void _Load()
        {
            dtpJoinDate.Value = DateTime.Now;
            //findout whether the member is new or not.
            if (_MemberID == -1)
            {
                Member = new MembersBLL();
                return;
            }
            //otherwise, the member already exists.
            Member = MembersBLL.Find(_MemberID);

            if (Member == null)
            {
                MessageBox.Show("This member is not available in the database.");
                this.Close();
                return;
            }
            lblMemberID.Text = Member.MemberID.ToString();
            tbName.Text = Member.Name;
            tbEmail.Text = Member.Email;
            tbAddress.Text = Member.Address;
            tbPhone.Text = Member.Phone;
            dtpJoinDate.Value = Member.JoinDate;


        }

        private void frmAddNewMember_Load(object sender, EventArgs e)
        {
            _ChangeColors();
            _Load();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            //check required fields before save.
            if (!this.ValidateChildren()) // triggers Validating on all child controls
            {
                MessageBox.Show("Please fix the highlighted fields before saving.", "Validation Error");
                return;
            }

            Member.Name = tbName.Text;
            Member.Email = tbEmail.Text;
            Member.Address = tbAddress.Text;
            Member.Phone = tbPhone.Text;
            Member.JoinDate = dtpJoinDate.Value;


            if (Mode == enMode.Add)
            {
                if (Member.Save())
                {
                    MessageBox.Show("Member Added Successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add new member.", "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }


            if (Mode == enMode.Update)
            {
                if (Member.Save())
                {
                    MessageBox.Show("Member Updated Successfully.", "Success", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update data.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }



        }

        //Name , Address, Email , Phone => Required
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddMember);
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddMember);

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddMember);

        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateFields(sender, e, epAddMember);

        }

        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
