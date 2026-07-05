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
    public partial class frmFines : Form
    {
        public frmFines()
        {
            InitializeComponent();
        }

        private void frmFines_Load(object sender, EventArgs e)
        {
            _RefreshFinesList();
            this.BackColor = ThemeColor.BackColor;

        }

        private void _RefreshFinesList()
        {
            DataTable dt = FinesBLL.ListFines();
            if (dt.Rows == null || dt.Rows.Count == 0)
            {
                dgvFines.Visible = false;
                lblFines.Visible = true;
                lblFines.Text = "No Fines have been Issued Yet.";
                return;
            }
            else
            {
                dgvFines.DataSource = dt;
            }
        }

        private void cmdPayFine_Click(object sender, EventArgs e)
        {
            int FineID = (int)dgvFines.CurrentRow.Cells["FineID"].Value;
            decimal Amount = (decimal)dgvFines.CurrentRow.Cells["Amount"].Value;
            string MemberName = (string)dgvFines.CurrentRow.Cells["Name"].Value;
            string Status = (string)dgvFines.CurrentRow.Cells["Status"].Value;


            //if the current member's fine already paid.
            if(Status == "Paid")
            {
                MessageBox.Show("Current Member's Fine history is already paid before.", "Already Paid");
                return;
            }
            
                if(MessageBox.Show($"Member '{MemberName}' will pay fine with total of {Amount}$.", "Pay Fine"
                    , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
                {
                        if (FinesBLL.PayFine(FineID))
                        {
                    MessageBox.Show("Payment Done Successfully.", "Success" , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    _RefreshFinesList();

                        }
                else
                {
                    MessageBox.Show("Failed to pay member's Fine", "Failed", 
                        MessageBoxButtons.OK  , MessageBoxIcon.Error);
                }

                }
        }
    }
}
