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

        public static bool IsDirect;
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
                        IsDirect = true;
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
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HIdeToTray_Click(object sender, EventArgs e)
        {

            this.Hide();


        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {

            }
            else
            {
                this.Show();
            }

        }

        private void ToolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void BtnPingFormOpen_Click(object sender, EventArgs e)
        {
            PingServer pingfrm = new PingServer();
            pingfrm.Show();
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

        private void BtnCurrentDns_Click(object sender, EventArgs e)
        {
            BtnCurrentDns.Text = NetworkManagement.GetCurrentDns();
        }

        private void BtnOpenUptadeFrm_Click(object sender, EventArgs e)
        {
            Update Updatefrm = new Update();
            Updatefrm.Show();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
