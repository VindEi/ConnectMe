using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;



namespace ConnectMe
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
            Application.Run(new ConnectMe());

            // soo this check if it should run the app (i want it to be admin & only 1 instance of the app launched)
            // the app runs alr the functions dont work
            // go c# then js 





        }
    }
}
