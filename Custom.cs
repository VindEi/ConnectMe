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
        ConnectMe ConnectMe = new ConnectMe();
        public Custom()
        {
            InitializeComponent();
        }

        private void Custom_Load(object sender, EventArgs e)
        {

        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {


            string DnsServer = MainDnsTxt.Text;
            string DnsServer2 = SecendDnstxt.Text;
            NetworkManagement.SetDNS(DnsServer, DnsServer2);
            this.Close();


        }
    }
}
