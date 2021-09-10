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
    public partial class txtToFlowSeeBookings : UserControl
    {
        public txtToFlowSeeBookings()
        {
            InitializeComponent();
        }

        private string _showBooking;



        [Category("Custom Props")]
        public string ShowBooking
        {
            get { return _showBooking; }
            set { _showBooking = value; lblBookingText.Text = value; }
        }

    }
}
