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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BooksBLL.GetAllBooks();
            dgvBooks.DataSource = dt;
        }

        private void frmBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            
        }
    }
}
