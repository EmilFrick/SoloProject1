using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Badminton.Classes;

namespace Badminton.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            if (Customer.placeholderCustomer!=null)
            {
            Customer.ResetPlaceHolderCustomer();
            }
            
            if (Court.placeholderCourt!=null)
            {
            Court.ResetPlaceholderCourt();
            }
        }

        private void MainMenuGoToCreateBooking(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new Form1());
        }

        private void MainMenuGoToSeeBookings(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SeeBookings());
        }

        private void MainMenuGoToUpdateBooking(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new UpdateBooking());
        }

        private void MainMenuGoToCheckAvailability(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SeeAvailability());
        }
    }
}
