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
    public partial class ShowCustomerInfo : UserControl
    {
        public ShowCustomerInfo()
        {
            InitializeComponent();
        }


        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private string _adress;
        private string _postalCode;

        [Category("Customer Props")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; lblFirstNameInput.Text = value; }
        }


        [Category("Customer Props")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; lblLastNameInput.Text = value; }
        }

        [Category("Customer Props")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lblPhoneInput.Text = value; }
        }


        [Category("Customer Props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; lblEmailInput.Text = value; }
        }



        [Category("Customer Props")]
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; lblAddressInput.Text = value; }
        }


        [Category("Customer Props")]
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; lblPostalCodeInput.Text = value; }
        }


    }
}
