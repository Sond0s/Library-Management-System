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
            if(dt.Rows == null || dt.Rows.Count ==0)
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
    
    }
}
