using ConnectMe.DNS;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace ConnectMe
{
    public partial class Setting : Form
    {
        AddDns addDns;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            addDns = new AddDns();


            DnsManager.MrDns(comboBox1);
            comboBox1.Items.Add("Null");

            DnsManager.MrDns(comboBox2);
            comboBox2.Items.Add("Null");

            DnsManager.MrDns(comboBox3);
            comboBox3.Items.Add("Null");

            DnsManager.MrDns(comboBox4);
            comboBox4.Items.Add("Null");

            DnsManager.MrDns(comboBox5);
            comboBox5.Items.Add("Null");

            DnsManager.MrDns(comboBox6);

            if (Properties.Settings.Default.Mode == "Dark")
            {
                ModeSwitchBar.Value = 2;
            }
            else if (Properties.Settings.Default.Mode == "Light")
            {
                ModeSwitchBar.Value = 1;
            }
            if (Properties.Settings.Default.AutoStart == true)
            {
                startup.Checked = true;
            }
            else
            {
                startup.Checked = false;
            }

        }
        private bool IsCbNullorIsEqualToNull(ComboBox Cm)
        {
            if (Cm.SelectedIndex != -1)
            {

                try
                {
                    if (Cm.SelectedItem.ToString().ToLower() == "null")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    return true;
                }

            }
            else
            {
                return true;
            }

        }
        private void savecustombtn_Click(object sender, EventArgs e)
        {


            if (!IsCbNullorIsEqualToNull(comboBox1))
            {
                Properties.Settings.Default.Item1 = comboBox1.SelectedItem.ToString();
                Properties.Settings.Default.Item1IsOn = true;
            }
            else
            {
                Properties.Settings.Default.Item1IsOn = false;
            }

            if (!IsCbNullorIsEqualToNull(comboBox2))
            {
                Properties.Settings.Default.Item2 = comboBox2.SelectedItem.ToString();
                Properties.Settings.Default.Item2IsOn = true;
            }
            else
            {
                Properties.Settings.Default.Item2IsOn = false;
            }

            if (!IsCbNullorIsEqualToNull(comboBox3))
            {
                Properties.Settings.Default.Item3 = comboBox3.SelectedItem.ToString();
                Properties.Settings.Default.Item3IsOn = true;
            }
            else
            {
                Properties.Settings.Default.Item3IsOn = false;
            }

            if (!IsCbNullorIsEqualToNull(comboBox4))
            {
                Properties.Settings.Default.Item4 = comboBox4.SelectedItem.ToString();
                Properties.Settings.Default.Item4IsOn = true;
            }
            else
            {
                Properties.Settings.Default.Item4IsOn = false;
            }

            if (!IsCbNullorIsEqualToNull(comboBox5))
            {
                Properties.Settings.Default.Item5 = comboBox5.SelectedItem.ToString();
                Properties.Settings.Default.Item5IsOn = true;
            }
            else
            {
                Properties.Settings.Default.Item5IsOn = false;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Changes Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!IsCbNullorIsEqualToNull(comboBox6))
            {
                DnsManager.RemoveDns(comboBox6.SelectedItem.ToString());
                MessageBox.Show("Dns Removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Remove What?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void OpnFrmBtn_Click(object sender, EventArgs e)
        {
            addDns.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ModeSwitchBar_Scroll(object sender, EventArgs e)
        {

        }

        private void ModeSwitchBar_ValueChanged(object sender, EventArgs e)
        {
            if (ModeSwitchBar.Value == 1)
            {
                Properties.Settings.Default.Mode = "Light";


            }
            else if (ModeSwitchBar.Value == 2)
            {
                Properties.Settings.Default.Mode = "Dark";

            }


        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Some changes need a restart take effect", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnDnsDefaults_Click(object sender, EventArgs e)
        {
            string url = @"https://raw.githubusercontent.com/vindye/ConnectMe/master/Dns.txt";
            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            string messege = "Note that by clicking yes you will lose all your dns and download the default dns file(containing 5 dns)";
            DialogResult = MessageBox.Show(messege, "Are You Sure You Want To Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                client.DownloadFileAsync(new Uri(url), DnsManager.Path);
            }

        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LIGHTlbl_Click(object sender, EventArgs e)
        {

        }

        private void startup_CheckedChanged(object sender, EventArgs e)
        {
            if (startup.Checked)
            {
                Properties.Settings.Default.AutoStart = true;
                Configs.RegisterInStartup(true);
            }
            else
            {
                Properties.Settings.Default.AutoStart = false;
                Configs.RegisterInStartup(false);
            }
        }
    }

}
