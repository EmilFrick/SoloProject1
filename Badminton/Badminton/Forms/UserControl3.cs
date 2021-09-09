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
    public partial class txtCourtDetails : UserControl
    {
        public txtCourtDetails()
        {
            InitializeComponent();
        }



        #region Props
        private string _gameType;
        private string _bookingDate;
        private string _startingTime;
        private string _endingTime;
        private string _courtNumber;


        [Category("Custom Props")]
        public string GameType
        {
            get { return _gameType; }
            set { _gameType = value; lblCourtType.Text = value; }
        }

        [Category("Custom Props")]
        public string BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; lblCourtDate.Text = value; }
        }

        [Category("Custom Props")]
        public string StartingTime
        {
            get { return _startingTime; }
            set { _startingTime = value; lblCourtTimeFrom.Text = value; }
        }
        
        [Category("Custom Props")]
        public string EndingTime
        {
            get { return _endingTime; }
            set { _endingTime = value; lblCourtTimeTo.Text = value; }
        }
        
        [Category("Custom Props")]
        public string CourtNumber
        {
            get { return _courtNumber; }
            set { _courtNumber = value; lblCourtNumber.Text = value; }
        }

        #endregion

    }
}
