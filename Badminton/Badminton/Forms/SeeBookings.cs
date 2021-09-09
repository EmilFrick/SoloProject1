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
    public partial class SeeBookings : Form
    {
        public SeeBookings()
        {
            InitializeComponent();
        }
        Label choice;
        private void MarkLabel(object sender, EventArgs e)
        {

            Label clickedlabel = sender as Label;
            if (clickedlabel.BackColor == Color.Chocolate)
            {
                return;
            }

            if (choice == null)
            {
                clickedlabel.BackColor = Color.Chocolate; //was Ivory
                clickedlabel.ForeColor = Color.Yellow; //was black
                choice = clickedlabel;
                return;
            }

            GiveSelectionAtributes(clickedlabel);
            RevertAtributes(choice);
            choice = clickedlabel;
        }

        private void GiveSelectionAtributes(Label clickedlabel)
        {
            clickedlabel.BackColor = Color.Chocolate; //was Ivory
            clickedlabel.ForeColor = Color.Yellow; //was black
        }

        private void RevertAtributes(Label choice)
        {
            choice.BackColor = Color.Ivory;
            choice.ForeColor = Color.Black;
        }
        private void SeeSelectionBooking(object sender, EventArgs e)
        {
            if (choice == null)
            {
                //Nothing happens.
            }
            else
            {
                List<Booking> listOfBookings = new List<Booking>();
                listOfBookings = BookingRepository.ReadBookingRepo();
                listOfBookings = BookingRepository.GenereateSelectionList(choice, listOfBookings);
                //populera listan med värden
                // börja med datum
                //sätt props Och fånga värden.
            }


        }
    }
}
