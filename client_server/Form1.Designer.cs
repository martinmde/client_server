namespace client_server
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFastStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelAuth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetProjects = new System.Windows.Forms.Button();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonIncChapter = new System.Windows.Forms.Button();
            this.buttonReduceChapter = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGetReq = new System.Windows.Forms.Button();
            this.textBoxRequirements = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtClientStatus = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnTestCom = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(57, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1124, 373);
            this.tabControl2.TabIndex = 9;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1116, 344);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "initialization";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(162, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 277);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFastStart);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtHost);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "host,port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFastStart
            // 
            this.btnFastStart.Location = new System.Drawing.Point(56, 179);
            this.btnFastStart.Name = "btnFastStart";
            this.btnFastStart.Size = new System.Drawing.Size(240, 23);
            this.btnFastStart.TabIndex = 17;
            this.btnFastStart.Text = "connect,auth,bmm580";
            this.btnFastStart.UseVisualStyleBackColor = true;
            this.btnFastStart.Click += new System.EventHandler(this.btnFastStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "no connection to host yet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "port number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "host IP address";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(162, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(58, 22);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 49);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(89, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelAuth);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnAuth);
            this.tabPage3.Controls.Add(this.txtUsername);
            this.tabPage3.Controls.Add(this.txtPassword);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(334, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "authenticate";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(85, 188);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(141, 17);
            this.labelAuth.TabIndex = 14;
            this.labelAuth.Text = "not authenticated yet";
            this.labelAuth.TextChanged += new System.EventHandler(this.labelAuth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "username";
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(106, 143);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(115, 23);
            this.btnAuth.TabIndex = 11;
            this.btnAuth.Text = "authenticate";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(23, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(114, 22);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Text = "mac1rt";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetProjects);
            this.tabPage2.Controls.Add(this.listBoxProjects);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetProjects
            // 
            this.btnGetProjects.Location = new System.Drawing.Point(98, 45);
            this.btnGetProjects.Name = "btnGetProjects";
            this.btnGetProjects.Size = new System.Drawing.Size(126, 30);
            this.btnGetProjects.TabIndex = 2;
            this.btnGetProjects.Text = "get projects";
            this.btnGetProjects.UseVisualStyleBackColor = true;
            this.btnGetProjects.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(73, 81);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(164, 84);
            this.listBoxProjects.TabIndex = 1;
            this.listBoxProjects.SelectedIndexChanged += new System.EventHandler(this.listBoxProjects_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "no connection to host yet";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonIncChapter);
            this.tabPage5.Controls.Add(this.buttonReduceChapter);
            this.tabPage5.Controls.Add(this.buttonDown);
            this.tabPage5.Controls.Add(this.buttonUp);
            this.tabPage5.Controls.Add(this.checkedListBox1);
            this.tabPage5.Controls.Add(this.btnGetReq);
            this.tabPage5.Controls.Add(this.textBoxRequirements);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1116, 344);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "working view";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonIncChapter
            // 
            this.buttonIncChapter.Location = new System.Drawing.Point(769, 191);
            this.buttonIncChapter.Name = "buttonIncChapter";
            this.buttonIncChapter.Size = new System.Drawing.Size(75, 29);
            this.buttonIncChapter.TabIndex = 17;
            this.buttonIncChapter.Text = "-->";
            this.buttonIncChapter.UseVisualStyleBackColor = true;
            // 
            // buttonReduceChapter
            // 
            this.buttonReduceChapter.Location = new System.Drawing.Point(571, 191);
            this.buttonReduceChapter.Name = "buttonReduceChapter";
            this.buttonReduceChapter.Size = new System.Drawing.Size(75, 29);
            this.buttonReduceChapter.TabIndex = 16;
            this.buttonReduceChapter.Text = "<--";
            this.buttonReduceChapter.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(654, 221);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(105, 34);
            this.buttonDown.TabIndex = 15;
            this.buttonDown.Text = "paste before";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(667, 157);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(70, 34);
            this.buttonUp.TabIndex = 14;
            this.buttonUp.Text = "cut";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(52, 144);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(483, 157);
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnGetReq
            // 
            this.btnGetReq.Location = new System.Drawing.Point(209, 85);
            this.btnGetReq.Name = "btnGetReq";
            this.btnGetReq.Size = new System.Drawing.Size(143, 33);
            this.btnGetReq.TabIndex = 10;
            this.btnGetReq.Text = "get requirements";
            this.btnGetReq.UseVisualStyleBackColor = true;
            this.btnGetReq.Click += new System.EventHandler(this.btnGetReq_Click);
            // 
            // textBoxRequirements
            // 
            this.textBoxRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequirements.Location = new System.Drawing.Point(920, 64);
            this.textBoxRequirements.Multiline = true;
            this.textBoxRequirements.Name = "textBoxRequirements";
            this.textBoxRequirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequirements.Size = new System.Drawing.Size(99, 180);
            this.textBoxRequirements.TabIndex = 9;
            this.textBoxRequirements.WordWrap = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnTestCom);
            this.tabPage6.Controls.Add(this.btnSend);
            this.tabPage6.Controls.Add(this.txtClientStatus);
            this.tabPage6.Controls.Add(this.txtMessage);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1116, 344);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "debug view/traditional";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(229, 55);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtClientStatus
            // 
            this.txtClientStatus.Location = new System.Drawing.Point(175, 201);
            this.txtClientStatus.Multiline = true;
            this.txtClientStatus.Name = "txtClientStatus";
            this.txtClientStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientStatus.Size = new System.Drawing.Size(887, 118);
            this.txtClientStatus.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(175, 84);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(887, 98);
            this.txtMessage.TabIndex = 6;
            // 
            // btnTestCom
            // 
            this.btnTestCom.Location = new System.Drawing.Point(343, 55);
            this.btnTestCom.Name = "btnTestCom";
            this.btnTestCom.Size = new System.Drawing.Size(192, 23);
            this.btnTestCom.TabIndex = 9;
            this.btnTestCom.Text = "test comm";
            this.btnTestCom.UseVisualStyleBackColor = true;
            this.btnTestCom.Click += new System.EventHandler(this.btnTestCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 469);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "theClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetProjects;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtClientStatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox textBoxRequirements;
        private System.Windows.Forms.Button btnFastStart;
        private System.Windows.Forms.Button btnGetReq;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonIncChapter;
        private System.Windows.Forms.Button buttonReduceChapter;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button btnTestCom;
    }
}

