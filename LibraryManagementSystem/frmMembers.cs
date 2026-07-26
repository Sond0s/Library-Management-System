using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            _RefreshMembersList();
            _ChangeColors();

        }

        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.BackColor;
            btnAddMember.FillColor = ThemeColor.btnColor;
        }

        private void _RefreshMembersList()
        {
            DataTable dt = MembersBLL.ListAllMembers();
            dgvListMembers.DataSource = dt;
        }

        private void tbSearchMembers_TextChanged(object sender, EventArgs e)
        {
            dgvListMembers.DataSource = MembersBLL.ListMembersWithName(tbSearchMembers.Text);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //Default value => Add new Member.
            Form frm = new frmAddNewMember(-1);
            frm.ShowDialog();
            _RefreshMembersList();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)dgvListMembers.CurrentRow.Cells["MemberID"].Value;

            Form frm = new frmAddNewMember(MemberID);
            frm.ShowDialog();
            _RefreshMembersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)dgvListMembers.CurrentRow.Cells["MemberID"].Value;

            //check if the member has borrowings history
            if(BorrowingsBLL.HasBorrowings(MemberID))
            {
                MessageBox.Show("Can't Delete this member because of old borrowings history saved."
                    , "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (MessageBox.Show("Are You Sure you want to delete this Member ?", "Delete",
             MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MembersBLL.DeleteMember(MemberID))
                {
                    MessageBox.Show("Member Deleted Successfully.", "Succeded" , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    _RefreshMembersList();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Member", "Failed", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }
    }
}
