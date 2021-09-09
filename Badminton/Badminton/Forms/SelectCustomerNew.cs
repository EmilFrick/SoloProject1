using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Badminton.Classes;
using Badminton.Repository;

namespace Badminton.Forms
{
    public partial class SelectCustomerNew : Form
    {
        public SelectCustomerNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(txtFirstNameInput.Text, txtLastNameInput.Text, txtPhoneInput.Text, txtEmailInput.Text, txtAddressInput.Text, txtPostalCodeInput.Text);
            CustomerRepo.AddCustomerToRepo(customer);
            Customer.SetPlaceholderCustomer(customer);
            CreateNewCustomertGoToCreateBooking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Customer> customerList = CustomerRepo.ReadCustomerRepo();
        }

        private void CreateNewCustomertGoToCreateBooking()
        {
            HelperMethods.GoToMethod(new Form1());
        }



    }
}
