using Badminton.Classes;
using Badminton.Repository;
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
    public partial class SelectCourt : Form
    {
        public SelectCourt()
        {
            InitializeComponent();

        }
        Label choice;

        #region LabelStuff

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

        #endregion


        private void SelectCourtGoToCreateBooking(object sender, EventArgs e)
        {
            if (choice != null)
            {
                Court setPlaceholderCourt = new Court(dtpBookingDate.Value, dtpBookingTimeFrom.Value,
                    dtpBookingTimeTo.Value, choice.Text, 0);

                Court.SetPlaceholderCourt(setPlaceholderCourt);

                int collisionsFound = CheckingForCollisions(Court.placeholderCourt);
                bool courtIsAvailable = Court.IsCourtAvailable(Court.placeholderCourt.Type, collisionsFound);

                if (!courtIsAvailable)
                {
                    MessageBox.Show("Tyvärr finns det ingen bana tillgänglig för den här tiden");
                }
                else
                {
                    Court.placeholderCourt = Court.SetPlaceholderCourtWithCourtNumber(collisionsFound);
                    HelperMethods.GoToMethod(new Form1());
                }
            }
            else
            {
                MessageBox.Show("Något Saknas!");
            }
        }


        private int CheckingForCollisions(Court checkCourt)
        {
            List<Booking> listWithBookings = new List<Booking>();
            listWithBookings = BookingRepository.ReadBookingRepo();
            listWithBookings = BookingRepository.GetBookingsForSpecificDayAndActivity(listWithBookings,
                                    checkCourt.BookingDate, checkCourt.Type);
            int howManyCollisions = BookingRepository.IsItVacant(listWithBookings,
                                    checkCourt.StartTime, checkCourt.EndTime);
            return howManyCollisions;
        }

    }
}
