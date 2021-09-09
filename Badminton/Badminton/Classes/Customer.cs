using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badminton.Classes
{
    [Serializable]
    public class Customer
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string phone { get; private set; }
        public string email { get; private set; }
        public string adress { get; private set; }
        public string postalCode { get; private set; }

        public static Customer placeholderCustomer;

        public Customer(string firstName, string lastName, string phone, string email, string adress, string postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.adress = adress;
            this.postalCode = postalCode;
        }

        public static void SetPlaceholderCustomer(Customer customer)
        {
            placeholderCustomer = customer;
        }

        public static Customer GetPlaceholderCustomer()
        {
            return placeholderCustomer;
        }

        public static string DisplayCustomerDetails(Customer customer)
        {
            string display = $"{customer.firstName}{Environment.NewLine}" +
                $"{customer.lastName}{Environment.NewLine}" +
                $"{customer.phone}{Environment.NewLine}" +
                $"{customer.email}{Environment.NewLine}" +
                $"{customer.adress}{Environment.NewLine}" +
                $"{customer.postalCode}";
            return display;
        }

        public static void ResetPlaceHolderCustomer()
        {
            placeholderCustomer.firstName = null;
            placeholderCustomer.lastName = null;
            placeholderCustomer.phone = null;
            placeholderCustomer.email = null;
            placeholderCustomer.adress = null;
            placeholderCustomer.postalCode = null;
            placeholderCustomer = null;
        }
    }
}
