using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class ValidationHelper
    {
        public static void ValidateFields(Object sender , CancelEventArgs e , ErrorProvider error)
        {
            Control control = (Control)sender;
            if(string.IsNullOrEmpty(control.Text))
            {
                error.SetError(control, "This field is required.");
                //preventing focus out the selected control.
                e.Cancel = true;

            }
            else
            {
                error.SetError(control, "");
            }
        }

    }
}
