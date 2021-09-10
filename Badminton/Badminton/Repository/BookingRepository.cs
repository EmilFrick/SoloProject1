using Badminton.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Badminton.Repository
{
    class BookingRepository
    {

        public static void AddBookingToRepo(Customer customer, Court court)
        {
            Booking addBookingToRepo = new Booking(customer, court);
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

        static public List<Booking> ReadBookingRepo7Days()
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
                    if (jsonBooking.Court.BookingDate < DateTime.Now.AddDays(7))
                    {
                        if (jsonBooking.Court.BookingDate >= DateTime.Today)
                        {
                            jsonBookingList.Add(jsonBooking);
                        }
                    }
                }
                sr.Close();
            }

            return jsonBookingList;
        }


        static public List<Booking> GetBookingsForSpecificActivity(List<Booking> initialList, string courtType)
        {
            List<Booking> updatedList = new List<Booking>();
            if (initialList.Count == 0)
            {
                return updatedList;
            }
            foreach (var item in initialList)
            {
                if (item.Court.Type == courtType)
                {
                    updatedList.Add(item);
                }
            }
            return updatedList;
        }
        static public List<Booking> FetchCertainBookingsByDay(List<Booking> initialList, DateTime givenDay)
        {
            List<Booking> updatedList = new List<Booking>();
            if (initialList.Count == 0)
            {
                return updatedList;
            }
            foreach (var item in initialList)
            {
                if (item.Court.BookingDate.Date.Date == givenDay.Date)
                {
                    updatedList.Add(item);
                }
            }
            return updatedList;
        }
        static public List<Booking> GetBookingsForSpecificDayAndActivity(List<Booking> initialList, DateTime givenDay, string courtType)
        {
            List<Booking> updatedList = new List<Booking>();
            if (initialList.Count == 0)
            {
                return updatedList;
            }
            foreach (var item in initialList)
            {
                if (item.Court.BookingDate.Date == givenDay && item.Court.Type == courtType)
                {
                    updatedList.Add(item);
                }
            }
            return updatedList;
        }

        static public List<Booking> GetBookingsForSpecificActivityAndCourtID(List<Booking> initialList, string courtType, int courtID)
        {
            List<Booking> updatedList = new List<Booking>();
            if (initialList.Count == 0)
            {
                return updatedList;
            }
            foreach (var item in initialList)
            {
                if (item.Court.CortNumber == courtID && item.Court.Type == courtType)
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
                if (startingValue <= item.Court.StartTime && endingValue >= item.Court.StartTime)
                {
                    occupiedBy++;
                }
                else if (startingValue >= item.Court.StartTime && endingValue <= item.Court.EndTime)
                {
                    occupiedBy++;
                }
                else if (startingValue >= item.Court.StartTime && endingValue >= item.Court.EndTime)
                {
                    occupiedBy++;
                }
            }
            return occupiedBy;
        }

        static public List<Booking> GenereateSelectionList(Label choice, List<Booking> listOfBookings)
        {
            switch (choice.Name)
            {
                case "lblAll":
                    break;

                case "lblTennisAll":
                    listOfBookings = GetBookingsForSpecificActivity(listOfBookings, "Tennis");
                    break;

                case "lblTennisCourt1":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Tennis", 1);
                    break;

                case "lblTennisCourt2":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Tennis", 2);
                    break;

                case "lblSquashAll":
                    listOfBookings = GetBookingsForSpecificActivity(listOfBookings, "Squash");
                    break;

                case "lblSquashCourt1":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Squash", 1);
                    break;

                case "lblSquashCourt2":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Squash", 2);
                    break;

                case "lblBadmintonAll":
                    listOfBookings = GetBookingsForSpecificActivity(listOfBookings, "Badminton");
                    break;

                case "lblBadmintonCourt1":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Badminton", 1);
                    break;

                case "lblBadmintonCourt2":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Badminton", 2);
                    break;

                case "lblBadmintonCourt3":
                    listOfBookings = GetBookingsForSpecificActivityAndCourtID(listOfBookings, "Badminton", 3);
                    break;

                default:
                    break;
            }
            return listOfBookings;

        }
    }


}

