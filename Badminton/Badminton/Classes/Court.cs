using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Badminton.Classes
{
    public class Court
    {
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; }
        public int CortNumber { get; set; }

        public static Court placeholderCourt;

        public static int TennisCourt = 2;
        public static int SquashCourt = 2;
        public static int BadmintonCourt = 3;

        public Court(DateTime bookingDate, DateTime startTime, DateTime endTime, string getType, int courtNumber)
        {
            BookingDate = bookingDate;
            StartTime = startTime;
            EndTime = endTime;
            Type = GetCourtType(getType);
            CortNumber = courtNumber;
        }

        private string GetCourtType(string getType)
        {
            if (getType == "Tennis" || getType == "Squash" || getType == "Badminton")
            {
                return getType;
            }
            else
            {
                return "uppgifter saknas";
            }
        }

        public static bool IsCourtAvailable(string courtType, int collisionsFound)
        {
            if (courtType == "Tennis" && TennisCourt > collisionsFound)
            {
                return true;
            }
            else if (courtType == "Squash" && SquashCourt > collisionsFound)
            {
                return true;
            }
            else if (courtType == "Badminton" && BadmintonCourt > collisionsFound)
            {
                return true;
            }
            return false;
        }


        #region Placeholder Methods
        public static void SetPlaceholderCourt(Court court)
        {
            placeholderCourt = court;
        }

        public static Court SetPlaceholderCourtWithCourtNumber(int courtID)
        {
            placeholderCourt.CortNumber = ++courtID;
            return placeholderCourt;
        }

        public static Court GetPlaceholderCourt()
        {
            return placeholderCourt;
        }

        
        
        public static void ResetPlaceholderCourt()
        {
            Court court = new Court(DateTime.Now, DateTime.Now, DateTime.Now, null, 0);
            placeholderCourt = court;
        }
        #endregion



    }
}
