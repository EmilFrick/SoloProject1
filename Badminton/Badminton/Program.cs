using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton
{
    //string jsonString = JsonSerializer.Serialize(weatherForecast);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms.MainMenu run = new Forms.MainMenu();
            Application.Run(run);
        }
    }
}

