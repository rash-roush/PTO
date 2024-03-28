using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace YourNamespace // Replace with your actual namespace
{
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
            Application.Run(new YourMainForm()); // Replace 'YourMainForm' with the actual name of your main form
        }
    }
}
