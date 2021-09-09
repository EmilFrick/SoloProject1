﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Badminton.Classes;

namespace Badminton.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Customer placeholderCustomer = Customer.GetPlaceholderCustomer();
            if (placeholderCustomer != null)
            {
                DisplayPlaceholderCustomer();
                showCustomerInfo1.Show();
            }
            Court placeholderCourt = Court.GetPlaceholderCourt();

            if (placeholderCourt != null)
            {
                if (placeholderCourt.Type != "uppgifter saknas")
                {
                    DisplayPlaceholderCourt();
                    ShowCourtPlaceHolder.Show();
                }
            }

        }

        private void DisplayPlaceholderCustomer()
        {
            showCustomerInfo1.FirstName= $"{Customer.placeholderCustomer.firstName}";
            showCustomerInfo1.LastName= $"{Customer.placeholderCustomer.lastName}";
            showCustomerInfo1.Phone= $"{Customer.placeholderCustomer.phone}";
            showCustomerInfo1.Email= $"{Customer.placeholderCustomer.email}";
            showCustomerInfo1.Adress= $"{Customer.placeholderCustomer.adress}";
            showCustomerInfo1.PostalCode= $"{Customer.placeholderCustomer.postalCode}";
        }

        private void DisplayPlaceholderCourt()
        {
            ShowCourtPlaceHolder.GameType = $"{Court.placeholderCourt.Type}";
            ShowCourtPlaceHolder.BookingDate= $"{Court.placeholderCourt.BookingDate.ToString("d MMMM")}";
            ShowCourtPlaceHolder.StartingTime= $"{Court.placeholderCourt.StartTime.ToString("H:mm")}";
            ShowCourtPlaceHolder.EndingTime= $"{Court.placeholderCourt.EndTime.ToString("H:mm")}";
        }

        private void CreateBookingGoToSelectCustomer(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SelectCustomer());
        }

        private void CreateCustomerGoToSelectCourt(object sender, EventArgs e)
        {
            HelperMethods.GoToMethod(new SelectCourt());
        }

        private void PlaceTheBookingBtnClick(object sender, EventArgs e)
        {

            if (Customer.GetPlaceholderCustomer() != null && Court.GetPlaceholderCourt() != null)
            {
                Repository.BookingRepository.AddBookingToRepo(Customer.GetPlaceholderCustomer(), Court.GetPlaceholderCourt());
            }

            HelperMethods.GoToMethod(new MainMenu());
        }
    }
}
