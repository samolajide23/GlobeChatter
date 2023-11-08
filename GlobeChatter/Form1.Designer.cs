namespace GlobeChatter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.changeLanguage = new System.Windows.Forms.Button();
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RemoteLanguageBox = new System.Windows.Forms.ListBox();
            this.Friend = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.changeLanguage);
            this.groupBox1.Controls.Add(this.LanguageBox);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Language";
            // 
            // changeLanguage
            // 
            this.changeLanguage.Location = new System.Drawing.Point(133, 71);
            this.changeLanguage.Name = "changeLanguage";
            this.changeLanguage.Size = new System.Drawing.Size(75, 23);
            this.changeLanguage.TabIndex = 8;
            this.changeLanguage.Text = "change";
            this.changeLanguage.UseVisualStyleBackColor = true;
            this.changeLanguage.Click += new System.EventHandler(this.changeLanguage_Click);
            // 
            // LanguageBox
            // 
            this.LanguageBox.FormattingEnabled = true;
            this.LanguageBox.Location = new System.Drawing.Point(70, 71);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(57, 23);
            this.LanguageBox.TabIndex = 7;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(70, 46);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 23);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(70, 17);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(100, 23);
            this.textLocalIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.RemoteLanguageBox);
            this.groupBox2.Controls.Add(this.Friend);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Language";
            // 
            // RemoteLanguageBox
            // 
            this.RemoteLanguageBox.FormattingEnabled = true;
            this.RemoteLanguageBox.ItemHeight = 15;
            this.RemoteLanguageBox.Location = new System.Drawing.Point(71, 73);
            this.RemoteLanguageBox.Name = "RemoteLanguageBox";
            this.RemoteLanguageBox.Size = new System.Drawing.Size(57, 19);
            this.RemoteLanguageBox.TabIndex = 5;
            // 
            // Friend
            // 
            this.Friend.Location = new System.Drawing.Point(6, -3);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(41, 23);
            this.Friend.TabIndex = 8;
            this.Friend.Text = "Friend";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(71, 44);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(100, 23);
            this.textRemotePort.TabIndex = 3;
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(71, 17);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(100, 23);
            this.textRemoteIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(495, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(98, 59);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(12, 409);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(508, 23);
            this.textMessage.TabIndex = 3;
            // 
            // listMessage
            // 
            this.listMessage.ItemHeight = 15;
            this.listMessage.Location = new System.Drawing.Point(12, 128);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(589, 274);
            this.listMessage.TabIndex = 6;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(526, 408);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 442);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "GlobeChatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textLocalPort;
        private TextBox textLocalIp;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textRemotePort;
        private TextBox textRemoteIP;
        private Label label4;
        private Label label3;
        private Button buttonConnect;
        private TextBox textMessage;
        private ListBox listMessage;
        private Button buttonSend;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label Friend;
        private Button changeLanguage;
        private TextBox textBox5;
        private ListBox RemoteLanguageBox;
        private Button button2;
        private ComboBox LanguageBox;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label label7;
    }
}