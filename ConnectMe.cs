using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using ConnectMe.DNS;
using ConnectMe.Updates;


namespace ConnectMe
{

    public partial class ConnectMe : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int hwnd, int wParam, int lparam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int LeftRect, int TopRect, int RightRect, int BottomRect, int Width, int Height);

        public ConnectMe()
        {
            InitializeComponent();
        }
        private void ConnectMe_Load(object sender, EventArgs e)
        {
            Configs.PathChecker();
            DnsManager.TxtReader();
            ConnectMeloadin();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            ConnectionBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ConnectionBtn.Width, ConnectionBtn.Height, 5, 5));
            DnsBox.Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, DnsBox.Width, DnsBox.Height, 3, 3));
            Configs.Run();
        }
        public void ConnectMeloadin()
        {
            DnsBox.Items.Clear();
            DnsManager.MrDns(DnsBox);
            Configs.SetDefaults(Item1, Item2, Item3, Item4, Item5);
            Configs.ThemesManager(this);
            Updater.CheckForUpdates();
        }
        private void ConnectionBtn_Click(object sender, EventArgs e)
        {

            if (ConnectionBtn.Text == "Connect")
            {
                if (DnsBox.SelectedItem != null)
                {
                    DnsManager.SetDns(DnsBox.SelectedItem.ToString(), ConnectionBtn);
                    NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {DnsBox.SelectedText.ToString()}", ToolTipIcon.Info);
                }
                else if (DnsBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select An Item", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ConnectionBtn.Text == "Disconnect")
            {

                DnsManager.UnsetDNS();
                ConnectionBtn.Text = "Connect";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            NotifyIcon.Visible = false;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            NotifyIcon.Visible = false;
        }

        private void ConnectMe_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(300, "ConnectMe", "Im Still Here :)", ToolTipIcon.Info);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { NotifyIcon.Visible = false; }
        }

        private void ToolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCurrentDns_Click(object sender, EventArgs e)
        {
            BtnCurrentDns.Text = DnsManager.GetCurrentDns();
        }

        private void BtnPingFormOpen_Click(object sender, EventArgs e)
        {
            PingServer pingfrm = new PingServer();
            pingfrm.Show();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {


        }
        private void BtnDirect_ButtonSpecPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }

        private void BtnCMD_ButtonSpecPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }
        private void Wifi_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ConnectMe_Move(object sender, EventArgs e)
        {

        }
        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                PingReply Replay;
                string Host;
                Host = "Google.com";
                Replay = ping.Send(Host);
                if (Replay.Status == IPStatus.Success)
                {
                    NotifyIcon.ShowBalloonTip(300, "ConnectMe", "Ping to " + Host.ToString() + "[" + Replay.Address.ToString() + "]" + " Successful"
                       + " Response delay = " + Replay.RoundtripTime.ToString() + " ms" + "\n", ToolTipIcon.Info);

                }
            }
            catch
            {
                NotifyIcon.ShowBalloonTip(300, "ConnectMe", "Failed (No network connection or invalid server) ", ToolTipIcon.Info);

            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            using (Setting Settingform = new Setting())
            {
                Settingform.ShowDialog();
            }
        }

        private void CmStrip_Opening(object sender, CancelEventArgs e)
        {

        }
        private void defualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DnsManager.UnsetDNS();
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", "Connected Back To Defualt", ToolTipIcon.Info);
        }
        private void Item1_Click(object sender, EventArgs e)
        {
            DnsManager.SetDns(Item1.Text, ConnectionBtn);
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {Item1.Text}", ToolTipIcon.Info);
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            DnsManager.SetDns(Item2.Text, ConnectionBtn);
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {Item2.Text}", ToolTipIcon.Info);
        }

        private void Item3_Click(object sender, EventArgs e)
        {
            DnsManager.SetDns(Item3.Text, ConnectionBtn);
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {Item3.Text}", ToolTipIcon.Info);
        }

        private void Item4_Click(object sender, EventArgs e)
        {
            DnsManager.SetDns(Item4.Text, ConnectionBtn);
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {Item4.Text}", ToolTipIcon.Info);
        }

        private void Item5_Click(object sender, EventArgs e)
        {
            DnsManager.SetDns(Item5.Text, ConnectionBtn);
            NotifyIcon.ShowBalloonTip(300, "ConnectMe", $"Connected To {Item5.Text}", ToolTipIcon.Info);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DnsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConnectMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        public ComboBox DnsBoxMain { get { return DnsBox; } }
        public Button BtnConnect { get { return ConnectionBtn; } }
        public Button BtnRefresh { get { return BtnCurrentDns; } }
        public ToolStrip TsMain { get { return MainToolStrip; } }
        public ContextMenuStrip Cmsrip { get { return CmStrip; } }
        public ContextMenuStrip CmConnect { get { return ConnectCmStrip; } }
        public ToolStripButton btnexit { get { return ExitBtn; } }
        public ToolStripButton btnMini { get { return MinimizeBtn; } }
        public ToolStripButton btnSetting { get { return SettingBtn; } }
        public ToolStripButton btnpingfrm { get { return BtnPingFormOpen; } }
        


    }

}
