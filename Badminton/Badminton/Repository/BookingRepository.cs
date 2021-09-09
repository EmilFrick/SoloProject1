using Badminton.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Badminton.Repository
{
    class BookingRepository
    {

        public static void AddBookingToRepo(Customer customer, Court court)
        {
            Booking addBookingToRepo = new Booking(customer,court);
            string repoPath = Directory.GetCurrentDirectory();
            string jString = JsonConvert.SerializeObject(addBookingToRepo);
            File.AppendAllText($@"{repoPath}\BookingsRepo.json", jString + "\n");   //Kan man tabort kladd? :)
        }

        static public List<Booking> ReadBookingRepo()
        {

            string currentPath = Directory.GetCurrentDirectory();
            StreamReader sr = new StreamReader($@"{currentPath}\BookingsRepo.json");
            string jsonString = "";
            List<Booking> jsonBookingList = new List<Booking>();

            using (sr)
            {
                while ((jsonString = sr.ReadLine()) != null)
                {
                    Booking jsonBooking = JsonConvert.DeserializeObject<Booking>(jsonString);
                    jsonBookingList.Add(jsonBooking);
                }
                sr.Close();
            }

            return jsonBookingList;
        }

        static public List<Booking> GetBookingsForSpecificDayAndActivity(List<Booking> initialList, DateTime givenDay, string courtType)
        {
            List<Booking> updatedList = new List<Booking>();
            if (initialList.Count==0)
            {
                return updatedList;
            }
            foreach (var item in initialList)
            {
                if (item.Court.BookingDate.Date==givenDay && item.Court.Type == courtType)
                {
                    updatedList.Add(item);
                }
            }
            return updatedList;
        }

        static public int IsItVacant(List<Booking> bookingsForTheDay, DateTime startingValue, DateTime endingValue)
        {
            int occupiedBy = 0;

            foreach (var item in bookingsForTheDay)
            {
                if (startingValue<=item.Court.StartTime && endingValue>=item.Court.StartTime)
                {
                    occupiedBy++;
                }
                else if (startingValue>=item.Court.StartTime&&endingValue<=item.Court.EndTime)
                {
                    occupiedBy++;
                }
                else if (startingValue>=item.Court.StartTime&&endingValue>=item.Court.EndTime)
                {
                    occupiedBy++;
                }
            }
            return occupiedBy;
        }

    }
}
