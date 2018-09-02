using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SimpleTCP;

namespace myserver
{
    public partial class deserver : Form
    {
        List<string> projectsList = new List<string> { };
        int num_projects = 0;

        List<string[]> users_passwordsList = new List<string[]> { };

        public deserver()
        {
            InitializeComponent();
        }

        private void get_projectnames() {

            num_projects = 0;
            string line;
            txtStatus.Text += "\r\n";
            txtStatus.Text += "projects" + "\r\n";
            txtStatus.Text += "------------" + "\r\n";
            // Read the file and display it line by line.  
            try
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\client_server\projects.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (line != "(none)")
                    {
                        projectsList.Add(line);
                        txtStatus.Text +=line+"\r\n";
                    }
                    num_projects++;
                }// while
                projectsList.Add("(none)");

                file.Close();
            }
            catch (Exception)
            {
                txtStatus.Text += "file not found" + "\r\n";
                txtStatus.Text += @"c:\client_server\projects.txt";
                throw;
            }
            
            
            
        } // get_projectnames




        private void get_passwords()
        {

            int counter = 0;
            string line;
            txtStatus.Text += "\r\n";
            txtStatus.Text += "users" + "\r\n";
            txtStatus.Text += "------------" + "\r\n";
            // Read the file and display it line by line.  
            try
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\client_server\passwords.txt");
                while ((line = file.ReadLine()) != null)
                {
                    String[] entries = line.Split(' ');
                    if (entries[0] != "(none)")
                    {
                        users_passwordsList.Add(entries);
                        txtStatus.Text += entries[0] + "\r\n";
                    }
                    counter++;
                }

                file.Close();
            }
            catch (Exception)
            {
                txtStatus.Text += "file not found" + "\r\n";
                txtStatus.Text += @"c:\client_server\passwords.txt";
                throw;
            }



        } // get_projectnames












        SimpleTcpServer server;


        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server starting" + "\r\n";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));

            get_projectnames();
            get_passwords();
        }

        private void deserver_DataReceived(object sender, SimpleTCP.Message e)
        {
            void p()
            {
                txtServerMessage.Text += "received "+e.MessageString+"\r\n";
                
            }
            txtServerMessage.Invoke((MethodInvoker)p);

            if(e.MessageString.StartsWith("get projects"))
            {
                for(int i=0;i<num_projects;i++) e.ReplyLine(projectsList[i]);
                e.ReplyLine("(none)");

            }
            else e.ReplyLine(e.MessageString); // default answer

        }


        private void deserver_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += deserver_DataReceived;
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                txtStatus.Clear();
            }
        }
    }
}
