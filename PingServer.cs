using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ConnectMe
{
    public partial class PingServer : Form
    {
        public PingServer()
        {
            InitializeComponent();

        }
        private void TxtHost_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtHost.Text) || TxtHost.Text == "")
            {
                MessageBox.Show("Please use valid IP or web address!!","Invalid Ip or web address",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnCheckPing_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply Replay;
            string Host;
            Host = TxtHost.Text;
            Replay = ping.Send(Host);

            if (Replay.Status == IPStatus.Success)
            {
                lblResult.Text = "Ping to " + Host.ToString() + "[" + Replay.Address.ToString() + "]" + " Successful"
                   + " Response delay = " + Replay.RoundtripTime.ToString() + " ms" + "\n";
            }
        }
        private void TxtHost_TextChanged(object sender, EventArgs e)
        {
        }

        private void PingServer_Load(object sender, EventArgs e)
        {

        }
    }
}
