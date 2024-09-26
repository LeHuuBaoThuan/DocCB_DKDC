namespace WriteTextFile_Sens
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboxCOM = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.cboxData = new System.Windows.Forms.ComboBox();
            this.cboxStopB = new System.Windows.Forms.ComboBox();
            this.cboxParB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxRTS = new System.Windows.Forms.CheckBox();
            this.chboxDTR = new System.Windows.Forms.CheckBox();
            this.cboxDataB = new System.Windows.Forms.ComboBox();
            this.txtBoxDataIN = new System.Windows.Forms.TextBox();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbLengthRX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxCOM
            // 
            this.cboxCOM.FormattingEnabled = true;
            this.cboxCOM.Location = new System.Drawing.Point(133, 45);
            this.cboxCOM.Name = "cboxCOM";
            this.cboxCOM.Size = new System.Drawing.Size(121, 28);
            this.cboxCOM.TabIndex = 0;
            // 
            // cboxBaud
            // 
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cboxBaud.Location = new System.Drawing.Point(133, 79);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(121, 28);
            this.cboxBaud.TabIndex = 1;
            this.cboxBaud.Text = "115200";
            // 
            // cboxData
            // 
            this.cboxData.FormattingEnabled = true;
            this.cboxData.Location = new System.Drawing.Point(32690, 32535);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(10521, 28);
            this.cboxData.TabIndex = 3;
            // 
            // cboxStopB
            // 
            this.cboxStopB.FormattingEnabled = true;
            this.cboxStopB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cboxStopB.Location = new System.Drawing.Point(133, 147);
            this.cboxStopB.Name = "cboxStopB";
            this.cboxStopB.Size = new System.Drawing.Size(121, 28);
            this.cboxStopB.TabIndex = 4;
            this.cboxStopB.Text = "One";
            // 
            // cboxParB
            // 
            this.cboxParB.FormattingEnabled = true;
            this.cboxParB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cboxParB.Location = new System.Drawing.Point(133, 181);
            this.cboxParB.Name = "cboxParB";
            this.cboxParB.Size = new System.Drawing.Size(121, 28);
            this.cboxParB.TabIndex = 5;
            this.cboxParB.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parity Bit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chboxRTS);
            this.groupBox1.Controls.Add(this.chboxDTR);
            this.groupBox1.Controls.Add(this.cboxDataB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxParB);
            this.groupBox1.Controls.Add(this.cboxStopB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxBaud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxCOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 276);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // chboxRTS
            // 
            this.chboxRTS.AutoSize = true;
            this.chboxRTS.Location = new System.Drawing.Point(173, 232);
            this.chboxRTS.Name = "chboxRTS";
            this.chboxRTS.Size = new System.Drawing.Size(100, 24);
            this.chboxRTS.TabIndex = 13;
            this.chboxRTS.Text = "RTS Ena";
            this.chboxRTS.UseVisualStyleBackColor = true;
            this.chboxRTS.CheckedChanged += new System.EventHandler(this.chboxRTS_CheckedChanged_1);
            // 
            // chboxDTR
            // 
            this.chboxDTR.AutoSize = true;
            this.chboxDTR.Location = new System.Drawing.Point(15, 232);
            this.chboxDTR.Name = "chboxDTR";
            this.chboxDTR.Size = new System.Drawing.Size(101, 24);
            this.chboxDTR.TabIndex = 12;
            this.chboxDTR.Text = "DTR Ena";
            this.chboxDTR.UseVisualStyleBackColor = true;
            this.chboxDTR.CheckedChanged += new System.EventHandler(this.chboxDTR_CheckedChanged);
            // 
            // cboxDataB
            // 
            this.cboxDataB.FormattingEnabled = true;
            this.cboxDataB.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cboxDataB.Location = new System.Drawing.Point(133, 113);
            this.cboxDataB.Name = "cboxDataB";
            this.cboxDataB.Size = new System.Drawing.Size(121, 28);
            this.cboxDataB.TabIndex = 11;
            this.cboxDataB.Text = "8";
            // 
            // txtBoxDataIN
            // 
            this.txtBoxDataIN.Location = new System.Drawing.Point(18, 34);
            this.txtBoxDataIN.Multiline = true;
            this.txtBoxDataIN.Name = "txtBoxDataIN";
            this.txtBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxDataIN.Size = new System.Drawing.Size(255, 86);
            this.txtBoxDataIN.TabIndex = 16;
            this.txtBoxDataIN.WordWrap = false;
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived_1);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(166, 97);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(107, 20);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "Disconnected";
            // 
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(153, 32);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(120, 49);
            this.btnDiscon.TabIndex = 14;
            this.btnDiscon.Text = "Disconnect";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 49);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnDiscon);
            this.groupBox2.Location = new System.Drawing.Point(33, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 146);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Controls.Add(this.txtBoxDataIN);
            this.groupBox3.Location = new System.Drawing.Point(33, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 240);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rx Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbLengthRX);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(164, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 85);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // lbLengthRX
            // 
            this.lbLengthRX.AutoSize = true;
            this.lbLengthRX.Location = new System.Drawing.Point(42, 52);
            this.lbLengthRX.Name = "lbLengthRX";
            this.lbLengthRX.Size = new System.Drawing.Size(27, 20);
            this.lbLengthRX.TabIndex = 15;
            this.lbLengthRX.Text = "00";
            this.lbLengthRX.Click += new System.EventHandler(this.lbLengthRX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Length RX:";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(18, 147);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(98, 85);
            this.btnClearData.TabIndex = 15;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(270, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "ĐO CẢM BIẾN  - FILE .txt";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(362, 85);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1070, 701);
            this.zedGraphControl1.TabIndex = 20;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 809);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Write TxtFile by Sens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCOM;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxData;
        private System.Windows.Forms.ComboBox cboxStopB;
        private System.Windows.Forms.ComboBox cboxParB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxDataIN;
        private System.Windows.Forms.ComboBox cboxDataB;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chboxRTS;
        private System.Windows.Forms.CheckBox chboxDTR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbLengthRX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

