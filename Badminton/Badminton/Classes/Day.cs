using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badminton.Classes
{
    class Day
    {
        private DateTime Today { get; set; }

        public Day(DateTime today)
        {
            Today = DateTime.Now;
        }

        public DateTime GetDateTimeDayFromNow(int days)
        {
            DateTime myDay = Today.AddDays(days);
            return myDay;
        }
       
        public string GetStrDay(DateTime getWeekday)
        {
            string myWeekday = getWeekday.ToString("dddd");
            return myWeekday;
        }
    }
}
