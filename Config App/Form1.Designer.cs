namespace Config_App
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
            this.labelURL = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelAPN = new System.Windows.Forms.Label();
            this.textBoxAPN = new System.Windows.Forms.TextBox();
            this.groupBoxGPRS = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectDataType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbWIFI = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbGPRS = new System.Windows.Forms.RadioButton();
            this.groupBoxWIFI = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSSID = new System.Windows.Forms.TextBox();
            this.textBoxLocalHost = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelSSID = new System.Windows.Forms.Label();
            this.labelLocalHost = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBeaconFlag = new System.Windows.Forms.CheckBox();
            this.comboBoxRFSensitivity = new System.Windows.Forms.ComboBox();
            this.comboBoxRFBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxRFChannel = new System.Windows.Forms.ComboBox();
            this.labelRFSensitivity = new System.Windows.Forms.Label();
            this.labelRFBaudRate = new System.Windows.Forms.Label();
            this.labelRFChannel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelReaderID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.groupBoxGPRS.SuspendLayout();
            this.groupBoxSelectDataType.SuspendLayout();
            this.groupBoxWIFI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(11, 28);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(28, 15);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(473, 405);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(554, 405);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(45, 22);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(299, 23);
            this.textBoxURL.TabIndex = 3;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // labelAPN
            // 
            this.labelAPN.AutoSize = true;
            this.labelAPN.Location = new System.Drawing.Point(8, 52);
            this.labelAPN.Name = "labelAPN";
            this.labelAPN.Size = new System.Drawing.Size(31, 15);
            this.labelAPN.TabIndex = 4;
            this.labelAPN.Text = "APN";
            // 
            // textBoxAPN
            // 
            this.textBoxAPN.Location = new System.Drawing.Point(45, 49);
            this.textBoxAPN.Name = "textBoxAPN";
            this.textBoxAPN.Size = new System.Drawing.Size(157, 23);
            this.textBoxAPN.TabIndex = 5;
            // 
            // groupBoxGPRS
            // 
            this.groupBoxGPRS.Controls.Add(this.labelURL);
            this.groupBoxGPRS.Controls.Add(this.textBoxURL);
            this.groupBoxGPRS.Controls.Add(this.labelAPN);
            this.groupBoxGPRS.Controls.Add(this.textBoxAPN);
            this.groupBoxGPRS.Enabled = false;
            this.groupBoxGPRS.Location = new System.Drawing.Point(25, 117);
            this.groupBoxGPRS.Name = "groupBoxGPRS";
            this.groupBoxGPRS.Size = new System.Drawing.Size(427, 89);
            this.groupBoxGPRS.TabIndex = 6;
            this.groupBoxGPRS.TabStop = false;
            this.groupBoxGPRS.Text = "GPRS Details";
            // 
            // groupBoxSelectDataType
            // 
            this.groupBoxSelectDataType.Controls.Add(this.radioButton2);
            this.groupBoxSelectDataType.Controls.Add(this.rbWIFI);
            this.groupBoxSelectDataType.Controls.Add(this.rbBoth);
            this.groupBoxSelectDataType.Controls.Add(this.rbGPRS);
            this.groupBoxSelectDataType.Location = new System.Drawing.Point(27, 55);
            this.groupBoxSelectDataType.Name = "groupBoxSelectDataType";
            this.groupBoxSelectDataType.Size = new System.Drawing.Size(425, 56);
            this.groupBoxSelectDataType.TabIndex = 7;
            this.groupBoxSelectDataType.TabStop = false;
            this.groupBoxSelectDataType.Text = "Select Data Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(287, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 19);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "USB";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbWIFI
            // 
            this.rbWIFI.AutoSize = true;
            this.rbWIFI.Location = new System.Drawing.Point(97, 22);
            this.rbWIFI.Name = "rbWIFI";
            this.rbWIFI.Size = new System.Drawing.Size(46, 19);
            this.rbWIFI.TabIndex = 1;
            this.rbWIFI.TabStop = true;
            this.rbWIFI.Text = "Wifi";
            this.rbWIFI.UseVisualStyleBackColor = true;
            this.rbWIFI.CheckedChanged += new System.EventHandler(this.rbWIFI_CheckedChanged);
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(151, 22);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(130, 19);
            this.rbBoth.TabIndex = 8;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both GPRS and WiFi";
            this.rbBoth.UseVisualStyleBackColor = true;
            this.rbBoth.CheckedChanged += new System.EventHandler(this.rbBoth_CheckedChanged);
            // 
            // rbGPRS
            // 
            this.rbGPRS.AutoSize = true;
            this.rbGPRS.Location = new System.Drawing.Point(25, 22);
            this.rbGPRS.Name = "rbGPRS";
            this.rbGPRS.Size = new System.Drawing.Size(53, 19);
            this.rbGPRS.TabIndex = 0;
            this.rbGPRS.TabStop = true;
            this.rbGPRS.Text = "GPRS";
            this.rbGPRS.UseVisualStyleBackColor = true;
            this.rbGPRS.CheckedChanged += new System.EventHandler(this.rbGPRS_CheckedChanged);
            // 
            // groupBoxWIFI
            // 
            this.groupBoxWIFI.Controls.Add(this.textBoxPassword);
            this.groupBoxWIFI.Controls.Add(this.textBoxSSID);
            this.groupBoxWIFI.Controls.Add(this.textBoxLocalHost);
            this.groupBoxWIFI.Controls.Add(this.labelPassword);
            this.groupBoxWIFI.Controls.Add(this.labelSSID);
            this.groupBoxWIFI.Controls.Add(this.labelLocalHost);
            this.groupBoxWIFI.Enabled = false;
            this.groupBoxWIFI.Location = new System.Drawing.Point(25, 241);
            this.groupBoxWIFI.Name = "groupBoxWIFI";
            this.groupBoxWIFI.Size = new System.Drawing.Size(427, 113);
            this.groupBoxWIFI.TabIndex = 8;
            this.groupBoxWIFI.TabStop = false;
            this.groupBoxWIFI.Text = "WiFi Details";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 83);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(289, 23);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.UseWaitCursor = true;
            // 
            // textBoxSSID
            // 
            this.textBoxSSID.Location = new System.Drawing.Point(77, 54);
            this.textBoxSSID.Name = "textBoxSSID";
            this.textBoxSSID.Size = new System.Drawing.Size(289, 23);
            this.textBoxSSID.TabIndex = 12;
            // 
            // textBoxLocalHost
            // 
            this.textBoxLocalHost.Location = new System.Drawing.Point(77, 22);
            this.textBoxLocalHost.Name = "textBoxLocalHost";
            this.textBoxLocalHost.Size = new System.Drawing.Size(289, 23);
            this.textBoxLocalHost.TabIndex = 11;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelSSID
            // 
            this.labelSSID.AutoSize = true;
            this.labelSSID.Location = new System.Drawing.Point(11, 57);
            this.labelSSID.Name = "labelSSID";
            this.labelSSID.Size = new System.Drawing.Size(30, 15);
            this.labelSSID.TabIndex = 9;
            this.labelSSID.Text = "SSID";
            // 
            // labelLocalHost
            // 
            this.labelLocalHost.AutoSize = true;
            this.labelLocalHost.Location = new System.Drawing.Point(11, 28);
            this.labelLocalHost.Name = "labelLocalHost";
            this.labelLocalHost.Size = new System.Drawing.Size(60, 15);
            this.labelLocalHost.TabIndex = 0;
            this.labelLocalHost.Text = "LocalHost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBeaconFlag);
            this.groupBox2.Controls.Add(this.comboBoxRFSensitivity);
            this.groupBox2.Controls.Add(this.comboBoxRFBaudRate);
            this.groupBox2.Controls.Add(this.comboBoxRFChannel);
            this.groupBox2.Controls.Add(this.labelRFSensitivity);
            this.groupBox2.Controls.Add(this.labelRFBaudRate);
            this.groupBox2.Controls.Add(this.labelRFChannel);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.labelInterval);
            this.groupBox2.Controls.Add(this.labelReaderID);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(547, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 237);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader Details";
            // 
            // checkBoxBeaconFlag
            // 
            this.checkBoxBeaconFlag.AutoSize = true;
            this.checkBoxBeaconFlag.Location = new System.Drawing.Point(99, 212);
            this.checkBoxBeaconFlag.Name = "checkBoxBeaconFlag";
            this.checkBoxBeaconFlag.Size = new System.Drawing.Size(90, 19);
            this.checkBoxBeaconFlag.TabIndex = 19;
            this.checkBoxBeaconFlag.Text = "Beacon Flag";
            this.checkBoxBeaconFlag.UseVisualStyleBackColor = true;
            // 
            // comboBoxRFSensitivity
            // 
            this.comboBoxRFSensitivity.FormattingEnabled = true;
            this.comboBoxRFSensitivity.Location = new System.Drawing.Point(98, 183);
            this.comboBoxRFSensitivity.Name = "comboBoxRFSensitivity";
            this.comboBoxRFSensitivity.Size = new System.Drawing.Size(106, 23);
            this.comboBoxRFSensitivity.TabIndex = 18;
            // 
            // comboBoxRFBaudRate
            // 
            this.comboBoxRFBaudRate.FormattingEnabled = true;
            this.comboBoxRFBaudRate.Location = new System.Drawing.Point(98, 152);
            this.comboBoxRFBaudRate.Name = "comboBoxRFBaudRate";
            this.comboBoxRFBaudRate.Size = new System.Drawing.Size(106, 23);
            this.comboBoxRFBaudRate.TabIndex = 17;
            // 
            // comboBoxRFChannel
            // 
            this.comboBoxRFChannel.FormattingEnabled = true;
            this.comboBoxRFChannel.Location = new System.Drawing.Point(98, 121);
            this.comboBoxRFChannel.Name = "comboBoxRFChannel";
            this.comboBoxRFChannel.Size = new System.Drawing.Size(106, 23);
            this.comboBoxRFChannel.TabIndex = 16;
            // 
            // labelRFSensitivity
            // 
            this.labelRFSensitivity.AutoSize = true;
            this.labelRFSensitivity.Location = new System.Drawing.Point(16, 186);
            this.labelRFSensitivity.Name = "labelRFSensitivity";
            this.labelRFSensitivity.Size = new System.Drawing.Size(76, 15);
            this.labelRFSensitivity.TabIndex = 15;
            this.labelRFSensitivity.Text = "RF Sensitivity";
            // 
            // labelRFBaudRate
            // 
            this.labelRFBaudRate.AutoSize = true;
            this.labelRFBaudRate.Location = new System.Drawing.Point(7, 152);
            this.labelRFBaudRate.Name = "labelRFBaudRate";
            this.labelRFBaudRate.Size = new System.Drawing.Size(85, 15);
            this.labelRFBaudRate.TabIndex = 14;
            this.labelRFBaudRate.Text = "RF Baud Width";
            // 
            // labelRFChannel
            // 
            this.labelRFChannel.AutoSize = true;
            this.labelRFChannel.Location = new System.Drawing.Point(25, 124);
            this.labelRFChannel.Name = "labelRFChannel";
            this.labelRFChannel.Size = new System.Drawing.Size(67, 15);
            this.labelRFChannel.TabIndex = 13;
            this.labelRFChannel.Text = "RF Channel";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 23);
            this.textBox5.TabIndex = 11;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(39, 74);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(46, 15);
            this.labelInterval.TabIndex = 12;
            this.labelInterval.Text = "Interval";
            // 
            // labelReaderID
            // 
            this.labelReaderID.AutoSize = true;
            this.labelReaderID.Location = new System.Drawing.Point(28, 31);
            this.labelReaderID.Name = "labelReaderID";
            this.labelReaderID.Size = new System.Drawing.Size(57, 15);
            this.labelReaderID.TabIndex = 11;
            this.labelReaderID.Text = "Reader ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 23);
            this.textBox4.TabIndex = 10;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "COM3"});
            this.comboBoxPort.Location = new System.Drawing.Point(346, 406);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(93, 23);
            this.comboBoxPort.TabIndex = 10;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(314, 409);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 15);
            this.labelPort.TabIndex = 11;
            this.labelPort.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxWIFI);
            this.Controls.Add(this.groupBoxSelectDataType);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.groupBoxGPRS);
            this.Name = "Form1";
            this.Text = "Configuration Device";
            this.groupBoxGPRS.ResumeLayout(false);
            this.groupBoxGPRS.PerformLayout();
            this.groupBoxSelectDataType.ResumeLayout(false);
            this.groupBoxSelectDataType.PerformLayout();
            this.groupBoxWIFI.ResumeLayout(false);
            this.groupBoxWIFI.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelURL;
        private Button buttonRead;
        private Button buttonWrite;
        private TextBox textBoxURL;
        private Label labelAPN;
        private TextBox textBoxAPN;
        private GroupBox groupBoxGPRS;
        private GroupBox groupBoxSelectDataType;
        private RadioButton rbWIFI;
        private RadioButton rbGPRS;
        private RadioButton rbBoth;
        private RadioButton radioButton2;
        private GroupBox groupBoxWIFI;
        private Label labelPassword;
        private Label labelSSID;
        private Label labelLocalHost;
        private TextBox textBoxPassword;
        private TextBox textBoxSSID;
        private TextBox textBoxLocalHost;
        private GroupBox groupBox2;
        private Label labelReaderID;
        private TextBox textBox4;
        private Label labelRFSensitivity;
        private Label labelRFBaudRate;
        private Label labelRFChannel;
        private TextBox textBox5;
        private Label labelInterval;
        private ComboBox comboBoxRFChannel;
        private ComboBox comboBoxRFSensitivity;
        private ComboBox comboBoxRFBaudRate;
        private CheckBox checkBoxBeaconFlag;
        private ComboBox comboBoxPort;
        private Label labelPort;
    }
}