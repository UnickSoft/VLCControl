namespace VLCControl
{
    partial class mainForm
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
            this.tabCommandLine = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbCommand = new System.Windows.Forms.TextBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_runVLC = new System.Windows.Forms.Button();
            this.tabCommandLine.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCommandLine
            // 
            this.tabCommandLine.Controls.Add(this.tabPage2);
            this.tabCommandLine.Location = new System.Drawing.Point(12, 6);
            this.tabCommandLine.Name = "tabCommandLine";
            this.tabCommandLine.SelectedIndex = 0;
            this.tabCommandLine.Size = new System.Drawing.Size(538, 243);
            this.tabCommandLine.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txbLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Command line";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txbCommand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 32);
            this.panel1.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(453, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbCommand
            // 
            this.txbCommand.Location = new System.Drawing.Point(3, 4);
            this.txbCommand.Name = "txbCommand";
            this.txbCommand.Size = new System.Drawing.Size(444, 22);
            this.txbCommand.TabIndex = 4;
            this.txbCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbCommand_KeyUp);
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(3, 3);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(524, 170);
            this.txbLog.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(137, 255);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 39);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_runVLC
            // 
            this.btn_runVLC.Location = new System.Drawing.Point(16, 255);
            this.btn_runVLC.Name = "btn_runVLC";
            this.btn_runVLC.Size = new System.Drawing.Size(102, 39);
            this.btn_runVLC.TabIndex = 4;
            this.btn_runVLC.Text = "Run VLC";
            this.btn_runVLC.UseVisualStyleBackColor = true;
            this.btn_runVLC.Click += new System.EventHandler(this.btn_runVLC_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 302);
            this.Controls.Add(this.btn_runVLC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tabCommandLine);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.tabCommandLine.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCommandLine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbCommand;
        private System.Windows.Forms.Button btn_runVLC;
    }
}

