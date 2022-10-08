using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectMe
{
    public partial class Custom : Form
    {
        ConnectMe connectMe = new ConnectMe();
        public Custom()
        {
            InitializeComponent();
        }

        private void Custom_FormClosed(object sender, FormClosedEventArgs e)
        {

          
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(ConnectMe.IsDirect = true)
            {
                string DnsServer = MainDnsTxt.Text;
                string DnsServer2 = SecendDnstxt.Text;
                NetworkManagement.SetDNS(DnsServer, DnsServer2);
                this.Close();
            }
            else
            {
                DnsCmd.DnsServer = MainDnsTxt.Text;
                DnsCmd.DnsServer2 = SecendDnstxt.Text;
                DnsCmd.DnsConnect();
                this.Close();
            }
            
        }

        private void Custom_Load(object sender, EventArgs e)
        {

        }
    }
}
