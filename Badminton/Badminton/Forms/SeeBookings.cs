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
using System.Reflection;

namespace Badminton.Forms
{
    public partial class SeeBookings : Form
    {
        public SeeBookings()
        {
            List<DateTime> currentWeek = new List<DateTime>();
            currentWeek = Classes.Day.GenerateWeek();
            InitializeComponent();
            lblToday.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(0));
            lblDay2.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(1));
            lblDay3.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(2));
            lblDay4.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(3));
            lblDay5.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(4));
            lblDay6.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(5));
            lblDay7.Text = Classes.Day.GetStrDay(currentWeek.ElementAt(6));
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
                listOfBookings = BookingRepository.ReadBookingRepo7Days();
                listOfBookings = BookingRepository.GenereateSelectionList(choice, listOfBookings);
                

                if (listOfBookings.Count != 0)  //If list contains no items, no idea to run this part of the program.
                {
                    PopulateFlowTagsForTheWeek(listOfBookings);
                }
            }
        }

        private string GenerateFlowTagText(Booking booking)
        {
            string gameType = booking.Court.Type.ToString().Substring(0, 1);
            string courtID = booking.Court.CortNumber.ToString();
            string fromTime = booking.Court.StartTime.ToString("HH");
            string endTime = booking.Court.EndTime.ToString("HH");
            string bookingText = $"{gameType}{courtID} {fromTime}-{endTime}";
            return bookingText;
        }

        private void PopulateFlowTagsForTheWeek(List<Booking> listOfBookings)
        {
            List<txtToFlowSeeBookings> listOfBookingTags = GenerateListOfBookingTags();
            List<DateTime> currentWeek = Classes.Day.GenerateWeek();

            int counter = 0;
            foreach (var weekDay in currentWeek)
            {
                List<Booking> listByWeekday = BookingRepository.FetchCertainBookingsByDay(listOfBookings, weekDay);
                foreach (var booking in listByWeekday)
                {
                    string tagStr = GenerateFlowTagText(booking);
                    listOfBookingTags = PopulateFlowTagsWithNewText(listOfBookingTags, tagStr, counter);
                }
                counter++;
            }
        }
        private List<txtToFlowSeeBookings> PopulateFlowTagsWithNewText(List<txtToFlowSeeBookings> listOfBookingTags, string tagStr, int counter)
        {
            txtToFlowSeeBookings updatedTag = listOfBookingTags.ElementAt(counter);
            listOfBookingTags.RemoveAt(counter);
            updatedTag.ShowBooking = tagStr;
            listOfBookingTags.Insert(counter, updatedTag);
            return listOfBookingTags;
        }

        private List<txtToFlowSeeBookings> GenerateListOfBookingTags()
        {
            List<txtToFlowSeeBookings> listOfBookingTags = new List<txtToFlowSeeBookings> {FlowToday, FlowDay2,
            FlowDay3, FlowDay4, FlowDay5, FlowDay6, FlowDay7};
            return listOfBookingTags;
        }
    }
}
