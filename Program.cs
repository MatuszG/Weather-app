using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_app
{
    static class Program
    {
        public static string apiKey = System.Configuration.ConfigurationManager.AppSettings["API_KEY"];
        public static string apiUrl = System.Configuration.ConfigurationManager.AppSettings["API_URL"];

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}
