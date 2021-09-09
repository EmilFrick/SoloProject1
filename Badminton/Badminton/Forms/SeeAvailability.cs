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
    public partial class SeeAvailability : Form
    {
        public SeeAvailability()
        {
            InitializeComponent();

        }
        Label choice;

        private void MarkSelection(object sender, EventArgs e)
        {
            Label clickedlabel = sender as Label;
            if (clickedlabel.BackColor == Color.Chocolate)
            {
                return;
            }
            
            if (choice == null)
            {
                clickedlabel.Margin = new Padding(3, 5, 3, 5); //was (3, 10, 3, 10);
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
            clickedlabel.Margin = new Padding(3, 5, 3, 5); //was (3, 10, 3, 10);
            clickedlabel.BackColor = Color.Chocolate; //was Ivory
            clickedlabel.ForeColor = Color.Yellow; //was black
        }

        private void RevertAtributes(Label choice)
        {
            choice.Margin = new Padding(3, 10, 3, 10);
            choice.BackColor = Color.Ivory;
            choice.ForeColor = Color.Black;
        }


        private void SelectCourtGoToCreateBooking(object sender, EventArgs e)
        {
            int collisionsFound = CheckingForCollisions(Court.placeholderCourt);
            bool courtIsAvailable = Court.IsCourtAvailable(Court.placeholderCourt.Type, collisionsFound);

            if (choice == null)
            {
                MessageBox.Show("Något Saknas!");
            }
            if (!courtIsAvailable)
            {
                MessageBox.Show("Tyvärr finns det ingen bana tillgänglig för den här tiden");
            }
            else
            {
                //Fixa en ny property med en CourtNumber
                //Spara en placeholder court med ett värde som är collisionsFound +1
                HelperMethods.GoToMethod(new Form1());
            }
        }

        private int CheckingForCollisions(Court checkCourt)
        {
            List<Booking> listWithBookings = new List<Booking>();
            listWithBookings = BookingRepository.ReadBookingRepo();
            listWithBookings = BookingRepository.GetBookingsForSpecificDayAndActivity(listWithBookings,
                                    checkCourt.BookingDate,checkCourt.Type);
            int howManyCollisions = BookingRepository.IsItVacant(listWithBookings,
                                    checkCourt.StartTime, checkCourt.EndTime);
            return howManyCollisions;
        }

        private void CheckAvailabilityGoToMainMenu(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new MainMenu());
        }
    }
}
