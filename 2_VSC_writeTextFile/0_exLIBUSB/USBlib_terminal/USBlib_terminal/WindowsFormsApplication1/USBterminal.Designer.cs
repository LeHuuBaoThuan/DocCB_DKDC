namespace WindowsFormsApplication1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.terminalBox = new System.Windows.Forms.TextBox();
            this.sendData1 = new System.Windows.Forms.Button();
            this.sendTextBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(97, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(91, 22);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Start";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.init_Click);
            // 
            // terminalBox
            // 
            this.terminalBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.terminalBox.Location = new System.Drawing.Point(18, 86);
            this.terminalBox.Multiline = true;
            this.terminalBox.Name = "terminalBox";
            this.terminalBox.Size = new System.Drawing.Size(156, 172);
            this.terminalBox.TabIndex = 2;
            // 
            // sendData1
            // 
            this.sendData1.Enabled = false;
            this.sendData1.Location = new System.Drawing.Point(18, 301);
            this.sendData1.Name = "sendData1";
            this.sendData1.Size = new System.Drawing.Size(75, 23);
            this.sendData1.TabIndex = 5;
            this.sendData1.Text = "data send";
            this.sendData1.UseVisualStyleBackColor = true;
            this.sendData1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendTextBox1
            // 
            this.sendTextBox1.Location = new System.Drawing.Point(18, 264);
            this.sendTextBox1.Name = "sendTextBox1";
            this.sendTextBox1.Size = new System.Drawing.Size(156, 20);
            this.sendTextBox1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(188, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 348);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sendTextBox1);
            this.Controls.Add(this.sendData1);
            this.Controls.Add(this.terminalBox);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "STM32 usblib bulk terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox terminalBox;
        private System.Windows.Forms.Button sendData1;
        private System.Windows.Forms.TextBox sendTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

