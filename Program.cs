using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
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

            if (!isStillRunning())
            {
                Application.Run(new ConnectMe());
                Configs.AdminRelauncher();
            }
            else
            {
                MessageBox.Show("Previous process still running.",
                   "Application Halted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
            }


        }
        static bool isStillRunning()
        {
            string procName = Process.GetCurrentProcess().ProcessName;
            // get the list of all processes by that name

            Process[] processes = Process.GetProcessesByName(procName);

            if (processes.Length > 1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
