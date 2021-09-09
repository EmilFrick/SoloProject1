using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton.Forms
{
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void CreateNewCustomerClick(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SelectCustomerNew());
        }

        private void btnExisting_Click(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SelectCustomerExist());
        }
    }
}
