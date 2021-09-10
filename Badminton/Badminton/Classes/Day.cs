using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton.Classes
{
    public static class Day
    {

        public static DateTime GetDateTimeDayFromNow(int days)
        {
            DateTime myDay = DateTime.Now.AddDays(days);
            return myDay;
        }
       
        public static string GetStrDay(DateTime getWeekday)
        {
            string myWeekday = getWeekday.ToString("dddd");
            return myWeekday;
        }

        public static List<DateTime> GenerateWeek()
        {
            List<DateTime> myWeek = new List<DateTime>();
            myWeek.Add(DateTime.Now);
            for (int i = 1; i < 7; i++)
            {
            myWeek.Add(GetDateTimeDayFromNow(i));
            }

            return myWeek;
        }
    }
}
