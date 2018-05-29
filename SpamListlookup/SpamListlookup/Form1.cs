using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpamListlookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] BLS = new string[] { "zen.spamhaus.org" };

        //, "sbl-xbl.spamhaus.org", "bl.spamcop.net"
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Test();
                Test2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Test() {
            for (byte ipup = 149; ipup < 168; ipup++)   // lets make some test ip addresses to lookup on black list servers
            {
                TestMyApplication("91.90.8." + ipup, BLS);
            }
        }
        /// <summary>
        /// add by frank,test one ip.
        /// </summary>
        private void Test2()
        {
            string testIp = this.txb_ip.Text.Trim();
            TestMyApplication(testIp, BLS);
        }

        private void TestMyApplication(string Ipaddress, string[] BlackListServers)
        {  
            VerifyIP IP = new VerifyIP(Ipaddress, BlackListServers);    //create the lookup class.
            
            if (IP.IPAddr.Valid)    //Is the IP valid
            {
                ListViewItem NewIp = new ListViewItem(IP.IPAddr.AsString);  //Create List Item with the Ip address
                if (IP.BlackList.IsListed)  //Is the IP address listed?
                {
                    NewIp.SubItems.Add("Yes");  //add list sub item...
                    NewIp.Group = listView1.Groups[0];  //Add to black list group in the listview
                    NewIp.SubItems.Add(IP.BlackList.VerifiedOnServer);  //Add list sub item with the name of the black list server
                    NewIp.SubItems.Add(IP.Times);
                    NewIp.SubItems.Add(IP.Returncode);
                
                }
                else
                {
                    NewIp.SubItems.Add("No");  //add list sub item...
                    NewIp.Group = listView1.Groups[1];  //Add to white list group in the listview
                    NewIp.SubItems.Add(IP.Times);
                    NewIp.SubItems.Add(IP.Returncode);
                } 
                listView1.Items.Add(NewIp); // Add the Item to the listview
                listView1.Refresh();
                
                System.Windows.Forms.Application.DoEvents();

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

     
    }
}