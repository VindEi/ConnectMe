using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectMe.DNS;

namespace ConnectMe
{
    public partial class AddDns : Form
    {
        public AddDns()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                DnsManager.AddDns(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Yea Prob got added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }

        }

        private void AddDns_Load(object sender, EventArgs e)
        {

        }
    }
}
