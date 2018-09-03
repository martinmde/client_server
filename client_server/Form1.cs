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
using EasyEncryption;

enum command:int { GET_PROJECTS=666, AUTHENTICATE, GET_REQUIREMENTS } ;


namespace client_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int current_command=0;
        private int messagecount = 0;
        private String current_project = "";

        SimpleTcpClient Client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            }
            catch (Exception)
            {
                label6.Text = "ERROR: could not connect to host";
                label6.ForeColor = System.Drawing.Color.Red;
                //throw;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived_phase1;
        }

        // the function below is handed over to the client object
        // and acts as EventHandler,  see SimpleTcpClient.cs
        // The client object knows nothing about the txtStatus box, 
        // 
        private void Client_DataReceived_phase1(object sender, SimpleTCP.Message e)
        {
            messagecount++;

            void p(){
                txtClientStatus.Text += messagecount.ToString()+e.MessageString+"\r\n";
            };

            void q()
            {
                String[] projects = e.MessageString.Split((char) 0x13);
                int i = 0;
                while (projects[i] != "(none)")
                {
                    listBoxProjects.Items.Add(projects[i]);
                    i++;
                }
            };

            void r()
            {
                labelAuth.Text = "authenticated";
            };

            txtClientStatus.Invoke((MethodInvoker)p);

            if(current_command == (int)command.GET_PROJECTS)
            {
                
                listBoxProjects.Invoke((MethodInvoker)q);
                
            }

            if (current_command == (int)command.AUTHENTICATE)
            {
                if (e.MessageString.StartsWith("authenticated"))
                    labelAuth.Invoke((MethodInvoker)r);

            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SimpleTCP.Message newmessage= Client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromMilliseconds(1));
            // Client_DataReceived will handle the reply
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SimpleTCP.Message newmessage = Client.WriteLineAndGetReply("get projects "+txtUsername.Text, TimeSpan.FromMilliseconds(1));
            current_command = (int) command.GET_PROJECTS;
            label3.Text = "click to choose";
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            String encrypt_pw = EasyEncryption.SHA.ComputeSHA1Hash(txtPassword.Text);
            txtPassword.Clear(); // clear ASAP
            SimpleTCP.Message newmessage = Client.WriteLineAndGetReply("authenticate "+txtUsername.Text+" "+ encrypt_pw, TimeSpan.FromMilliseconds(1));
            current_command = (int)command.AUTHENTICATE;
        }

        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show( listBoxProjects.Items[listBoxProjects.SelectedIndex].ToString(),"choose project" , MessageBoxButtons.OKCancel );

            if (result == DialogResult.OK)
            {
                current_project = listBoxProjects.Items[listBoxProjects.SelectedIndex].ToString();
                
            }
            else current_project = "";

        }

        private void labelAuth_TextChanged(object sender, EventArgs e)
        {
            label3.Text = labelAuth.Text;
        }


        private void Client_DataReceived_phase2(object sender, SimpleTCP.Message e)
        {
            messagecount++;

            void p()
            {
                txtClientStatus.Text += messagecount.ToString() + e.MessageString + "\r\n";
            };

            txtClientStatus.Invoke((MethodInvoker)p);

            
            void q()
            {
                String[] requirements = e.MessageString.Split((char)0x13);
                int i = 0;
                while (requirements[i] != "(none)")
                {
                    txtClientStatus.Lines[i] = requirements[i];
                    i++;
                }
            };



            if (current_command == (int)command.GET_REQUIREMENTS)
            {
                txtClientStatus.Invoke((MethodInvoker)q);

            }

        }


            private void tabControl2_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.TabIndex == 2)
            {
                Client.DataReceived -= Client_DataReceived_phase1;
                Client.DataReceived -= Client_DataReceived_phase2;

            }
            else
            {

                Client.DataReceived -= Client_DataReceived_phase2;
                Client.DataReceived -= Client_DataReceived_phase1;

            }

            SimpleTCP.Message newmessage = Client.WriteLineAndGetReply("get requirements "+ current_project+" "+txtUsername.Text, TimeSpan.FromMilliseconds(1));
            current_command = (int)command.GET_REQUIREMENTS;


        }
    }
}
