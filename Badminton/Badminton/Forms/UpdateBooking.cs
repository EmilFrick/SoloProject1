using Badminton.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Badminton.Repository;

namespace Badminton.Forms
{
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
        {
            InitializeComponent();
            List<Booking> allBookings = BookingRepository.ReadBookingRepo();
            foreach (var b in allBookings)
            {
                lstbListingBookings.Items.Add(b);
            }

        }
    }
}
