using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton.Forms
{
    public static class HelperMethods
    {
        public static void GoToMethod(Form form)
        {
            Form currentForm = Form.ActiveForm;
            currentForm.Hide();
            form.Closed += (s, args) => currentForm.Close();
            form.Show();
        }
    }
}
