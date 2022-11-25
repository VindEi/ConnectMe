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

namespace ConnectMe
{

    public partial class ConnectMe : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int hwnd, int wParam, int lparam);
        Custom CustomForm;

 
        public ConnectMe()
        {
            InitializeComponent();
        }
        private void ConnectMe_Load(object sender, EventArgs e)
        {
            CustomForm = new Custom();

        }

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            if (ConnectionBtn.Text == "Connect")
            {
                if (DnsBox.SelectedItem != null)
                {
                    if (DnsBox.SelectedItem == "Cloudflare")
                    {
                        string DnsServer = "1.1.1.1";
                        string DnsServer2 = "1.0.0.1";

                        NetworkManagement.SetDNS(DnsServer, DnsServer2);
                        ConnectionBtn.Text = "Disconnect";
                    }
                    if (DnsBox.SelectedItem == "Cisco")
                    {
                        string DnsServer = "208.67.222.222";
                        string DnsServer2 = "208.67.220.220";

                        NetworkManagement.SetDNS(DnsServer, DnsServer2);
                        ConnectionBtn.Text = "Disconnect";
                    }
                    if (DnsBox.SelectedItem == "Google")
                    {
                        string DnsServer = "8.8.8.8";
                        string DnsServer2 = "8.8.4.4";

                        NetworkManagement.SetDNS(DnsServer, DnsServer2);
                        ConnectionBtn.Text = "Disconnect";
                    }
                    if (DnsBox.SelectedItem == "Electro")
                    {
                        string DnsServer = "78.157.42.100";
                        string DnsServer2 = "78.157.42.101";

                        NetworkManagement.SetDNS(DnsServer, DnsServer2);
                        ConnectionBtn.Text = "Disconnect";
                    }
                    if (DnsBox.SelectedItem == "Custom")
                    {
                        CustomForm.ShowDialog();
                        ConnectionBtn.Text = "Disconnect";

                    }


                }
                else if (DnsBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select An Item", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ConnectionBtn.Text == "Disconnect")
            {
                NetworkManagement.UnsetDNS();
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
                NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Im Still Here :)", ToolTipIcon.Info);
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
            BtnCurrentDns.Text = NetworkManagement.GetCurrentDns();
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

        private void defualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkManagement.UnsetDNS();
            NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Connected Back To Defualt", ToolTipIcon.Info);
        }

        private void cloudflareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Connected To CloudFlare Dns", ToolTipIcon.Info);
            string DnsServer = "1.1.1.1";
            string DnsServer2 = "1.0.0.1";

            NetworkManagement.SetDNS(DnsServer, DnsServer2);
        }

        private void ciscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Connected To Cisco Dns", ToolTipIcon.Info);
            string DnsServer = "208.67.222.222";
            string DnsServer2 = "208.67.220.220";

            NetworkManagement.SetDNS(DnsServer, DnsServer2);
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Connected To Google Dns", ToolTipIcon.Info);
            string DnsServer = "8.8.8.8";
            string DnsServer2 = "8.8.4.4";

            NetworkManagement.SetDNS(DnsServer, DnsServer2);
        }

        private void electroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(1000, "ConnectMe", "Connected To Electro Dns", ToolTipIcon.Info);

            string DnsServer = "78.157.42.100";
            string DnsServer2 = "78.157.42.101";

            NetworkManagement.SetDNS(DnsServer, DnsServer2);
        }
    }

}
