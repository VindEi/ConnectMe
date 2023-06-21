using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string Path = Application.StartupPath + @"\Dns.txt";
            if (File.Exists(Path) == false)
            {
                File.CreateText(Path);    
                MessageBox.Show("Applied Some Changes; Restarting The Application","Restart",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
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
