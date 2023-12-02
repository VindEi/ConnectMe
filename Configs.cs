using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace ConnectMe
{
    internal class Configs
    {
        public static List<Theme> Themes = new List<Theme>();
        public static void SetDefaults(ToolStripMenuItem item1, ToolStripMenuItem item2, ToolStripMenuItem item3, ToolStripMenuItem item4, ToolStripMenuItem item5)
        {
            if (Properties.Settings.Default.Item1IsOn)
            {
                item1.Visible = true;
                item1.Text = Properties.Settings.Default.Item1;

            }
            else { item1.Visible = false; }
            if (Properties.Settings.Default.Item2IsOn)
            {
                item2.Visible = true;
                item2.Text = Properties.Settings.Default.Item2;
            }
            else { item2.Visible = false; }
            if (Properties.Settings.Default.Item3IsOn)
            {
                item3.Visible = true;
                item3.Text = Properties.Settings.Default.Item3;
            }
            else { item3.Visible = false; }
            if (Properties.Settings.Default.Item4IsOn)
            {
                item4.Visible = true;
                item4.Text = Properties.Settings.Default.Item4;
            }
            else { item4.Visible = false; }
            if (Properties.Settings.Default.Item5IsOn)
            {
                item5.Visible = true;
                item5.Text = Properties.Settings.Default.Item5;
            }
            else { item5.Visible = false; }
        }
        public static void PathChecker()
        {

            string OldPath = Application.StartupPath + @"\Dns.txt";
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ConnectMe\Dns.txt";
            if (File.Exists(OldPath))
            {
                File.Move(OldPath, Path);
                MessageBox.Show("Applied Some Changes; Restarting The Application", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ConnectMe");
                File.CreateText(Path);
                MessageBox.Show("Applied Some Changes; Restarting The Application", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

        }


        public static bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public static bool IsSingleInstance()
        {
            string procName = Process.GetCurrentProcess().ProcessName;
            // get the list of all processes by that name

            Process[] processes = Process.GetProcessesByName(procName);

            if (processes.Length > 1)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Relaunch()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                Process.Start(startInfo);

                // Close the current instance of the application
                Environment.Exit(1);
            }
            catch 
            { 
            Application.Exit();
            }
        }
        public static void Run()
        {
            if (IsAdmin())
            {
                if (!IsSingleInstance())
                {
                    MessageBox.Show("Instance already running");
                    Environment.Exit(1);
                }

            }
            else if (!IsAdmin())
            {
                if (MessageBox.Show("This program must be run as an administrator! \n\n Relaunch as Admin? (No = Exit)", ("Admin Privilages Needed!"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Relaunch();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
        public static void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ConnectMe", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ConnectMe");
            }
        }

        public static void ThemesManager(ConnectMe frm)
        {

            string mode = Properties.Settings.Default.Mode.ToLower(); ;
            Themes.Add(new Theme("Dark", Color.FromArgb(41, 44, 51), Color.FromArgb(69, 74, 86), Color.White, true));
            Themes.Add(new Theme("Light", Color.FromArgb(3, 110, 142), Color.FromArgb(250, 250, 250), Color.Black, false));
            foreach (Theme Mode in Themes)
            {

                if (mode.Contains(Mode.ThemeName.ToLower()))
                {
                    frm.BackColor = Mode.MainColor;
                    frm.DnsBoxMain.BackColor = Mode.SecondryColor;
                    frm.BtnRefresh.BackColor = Mode.SecondryColor;
                    frm.BtnConnect.BackColor = Mode.SecondryColor;
                    frm.TsMain.BackColor = Mode.SecondryColor;
                    frm.Cmsrip.BackColor = Mode.SecondryColor;
                    frm.CmConnect.BackColor = Mode.SecondryColor;

                    frm.ForeColor = Mode.TextColor;
                    frm.DnsBoxMain.ForeColor = Mode.TextColor;
                    frm.BtnRefresh.ForeColor = Mode.TextColor;
                    frm.BtnConnect.ForeColor = Mode.TextColor;
                    frm.Cmsrip.ForeColor = Mode.TextColor;
                    frm.CmConnect.ForeColor = Mode.TextColor;
                    frm.TsMain.ForeColor = Mode.TextColor;
                    frm.btnpingfrm.ForeColor = Mode.TextColor;
                    if (!Mode.IsDark)
                    {
                        frm.btnexit.Image = Properties.Resources.logout_dark;
                        frm.btnMini.Image = Properties.Resources.compress_dark;
                        frm.btnSetting.Image = Properties.Resources.setting_dark;
                    }
                    else
                    {
                        frm.btnexit.Image = Properties.Resources.Logout_16;
                        frm.btnMini.Image = Properties.Resources.Compress_16;
                        frm.btnSetting.Image = Properties.Resources.settings_144px;
                    }
                    break;

                }

            }
        }

    }
}
