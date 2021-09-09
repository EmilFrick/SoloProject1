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
    public partial class btnBackToMainMenu : UserControl
    {
        public btnBackToMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm;
            currentForm.Hide();
            MainMenu backToPage = new MainMenu();
            backToPage.Closed += (s, args) => currentForm.Close();
            backToPage.Show();
        }
    }
}
