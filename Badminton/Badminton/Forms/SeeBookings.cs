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
            ClearContainer();
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
                ClearContainer();
                listOfBookings = BookingRepository.ReadBookingRepo7Days();
                listOfBookings = BookingRepository.GenereateSelectionList(choice, listOfBookings);
                List<txtToFlowSeeBookings> listOfBookingTags = new List<txtToFlowSeeBookings>();

                if (listOfBookings.Count != 0)  //If list contains no items, no idea to run this part of the program.
                {
                    List<txtToFlowSeeBookings> listOfFlowTags = PopulateFlowTagsForTheWeek(listOfBookings, listOfBookingTags);
                    PopulateFlowLayOutPanelsWithTags(listOfFlowTags);
                }
            }
        }

        private void ClearContainer()
        {
            flwDay0.Controls.Clear();
            flwDay1.Controls.Clear();
            flwDay2.Controls.Clear();
            flwDay3.Controls.Clear();
            flwDay4.Controls.Clear();
            flwDay5.Controls.Clear();
            flwDay6.Controls.Clear();
        }

        private void PopulateFlowLayOutPanelsWithTags(List<txtToFlowSeeBookings> listOfFlowTags)
        {
            List<FlowLayoutPanel> flowPanel = new List<FlowLayoutPanel> {flwDay0, flwDay1, flwDay2,
            flwDay3, flwDay4, flwDay5, flwDay6};

            int counter = 0;
            foreach (var myPanel in flowPanel)
            {
                foreach (var myTag in listOfFlowTags)
                {
                    if (myTag.AttachedBooking!=null)
                    {

                        TimeSpan tagSpan = GetConditionalTimeSpan(myTag, counter);
                        if (tagSpan == TimeSpan.Zero)
                        {
                            AssignLabelsToPanels(myTag, myPanel);
                        }
                    }
                }
                counter++;
            }
        }

        private TimeSpan GetConditionalTimeSpan(txtToFlowSeeBookings myTag, int counter)
        {
            DateTime tagDate = myTag.AttachedBooking.Court.BookingDate.Date;
            DateTime comparativeDate = DateTime.Today.Date.AddDays(counter);
            TimeSpan tagSpan = tagDate - comparativeDate;
            return tagSpan;

        }

        private void AssignLabelsToPanels(txtToFlowSeeBookings myTag, FlowLayoutPanel myPanel)
        {
            myPanel.Controls.Add(myTag);
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

        private List<txtToFlowSeeBookings> PopulateFlowTagsForTheWeek(List<Booking> listOfBookings, List<txtToFlowSeeBookings> listOfBookingTags)
        {
            List<DateTime> currentWeek = Classes.Day.GenerateWeek();

            int counter = 0;
            foreach (var weekDay in currentWeek)
            {
                List<Booking> listByWeekday = BookingRepository.FetchCertainBookingsByDay(listOfBookings, weekDay);
                foreach (var booking in listByWeekday)
                {
                    string tagStr = GenerateFlowTagText(booking);
                    txtToFlowSeeBookings myBookingTag = new txtToFlowSeeBookings();
                    myBookingTag = PopulateFlowTagsWithNewText(booking, tagStr, counter);
                    listOfBookingTags.Add(myBookingTag);
                }
                counter++;
            }
            return listOfBookingTags;
        }
        private txtToFlowSeeBookings PopulateFlowTagsWithNewText(Booking booking, string tagStr, int counter)
        {
            txtToFlowSeeBookings myBookingTag = new txtToFlowSeeBookings();
            myBookingTag.ShowBooking = tagStr;
            myBookingTag.AttachedBooking = booking;
            return myBookingTag;
        }


    }
}
