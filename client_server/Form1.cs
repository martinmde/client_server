using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;


namespace client_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient Client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;
        }

        // the function below is handed over to the client object
        // and acts as EventHandler,  see SimpleTcpClient.cs
        // The client object knows nothing about the txtStatus box, 
        // 
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            void p(){
                txtStatus.Text += e.MessageString;
            };
            txtStatus.Invoke((MethodInvoker)p);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromMilliseconds(1));
           
        }
    }
}
