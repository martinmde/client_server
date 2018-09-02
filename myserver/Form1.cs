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

        public deserver()
        {
            InitializeComponent();
        }

        private void get_projectnames() {

            int counter = 0;
            string line;

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
                    counter++;
                }

                file.Close();
            }
            catch (Exception)
            {
                txtStatus.Text += "file not found" + "\r\n";
                txtStatus.Text += @"c:\client_server\projects.txt";
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

        }

        private void deserver_DataReceived(object sender, SimpleTCP.Message e)
        {
            void p()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said {0}", e.MessageString));
            }
            txtStatus.Invoke((MethodInvoker)p);
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
