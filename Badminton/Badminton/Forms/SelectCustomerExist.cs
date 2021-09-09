using Badminton.Classes;
using Badminton.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton.Forms
{
    public partial class SelectCustomerExist : Form
    {
        public SelectCustomerExist()
        {
            InitializeComponent();
            List<Customer> listAllCustomer = new List<Customer>();
            listAllCustomer = CustomerRepo.ReadCustomerRepo();
            foreach (var item in listAllCustomer)
            {
                string listEntry = $"{item.firstName},{item.lastName}," +
                    $"{item.phone},{item.email},{item.adress},{item.postalCode}";
                listBox1.Items.Add(listEntry);
            }
        }

        private void ListBoxEntrySaveGoToBooking(object sender, EventArgs e)
        {
            string getEntry = listBox1.SelectedItem.ToString();
            string[] getEntryArr = getEntry.Split(',');
            Customer customer = new Customer(getEntryArr[0], getEntryArr[1], getEntryArr[2], getEntryArr[3],
                getEntryArr[4], getEntryArr[5]);
            Customer.SetPlaceholderCustomer(customer);

            HelperMethods.GoToMethod(new Form1());
        }
    }

}
