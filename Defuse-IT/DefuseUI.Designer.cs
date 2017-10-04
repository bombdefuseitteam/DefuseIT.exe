namespace Defuse_IT
{
    partial class DefuseUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefuseUI));
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.label_version = new MetroFramework.Controls.MetroLabel();
            this.controllerStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.robotLabel = new System.Windows.Forms.Label();
            this.robotStatus = new System.Windows.Forms.Label();
            this.webcamStatus = new System.Windows.Forms.Label();
            this.webcamLabel = new System.Windows.Forms.Label();
            this.startConnect = new System.Windows.Forms.Button();
            this.vlcStream = new AxAXVLC.AxVLCPlugin2();
            this.sendTest = new System.Windows.Forms.Button();
            this.debugLog = new System.Windows.Forms.ListBox();
            this.tcpLabel = new System.Windows.Forms.Label();
            this.tcpStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vlcStream)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(213, 111);
            this.metroUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 7);
            this.metroUserControl1.TabIndex = 0;
            this.metroUserControl1.UseSelectable = true;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(6, 447);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(97, 20);
            this.label_version.TabIndex = 1;
            this.label_version.Text = "Version: 1.0.0.1";
            // 
            // controllerStatusLabel
            // 
            this.controllerStatusLabel.AutoSize = true;
            this.controllerStatusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerStatusLabel.Location = new System.Drawing.Point(12, 15);
            this.controllerStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.controllerStatusLabel.Name = "controllerStatusLabel";
            this.controllerStatusLabel.Size = new System.Drawing.Size(129, 17);
            this.controllerStatusLabel.TabIndex = 2;
            this.controllerStatusLabel.Text = "Controller Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(11, 29);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 23);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "OFFLINE";
            // 
            // robotLabel
            // 
            this.robotLabel.AutoSize = true;
            this.robotLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotLabel.Location = new System.Drawing.Point(179, 15);
            this.robotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.robotLabel.Name = "robotLabel";
            this.robotLabel.Size = new System.Drawing.Size(136, 17);
            this.robotLabel.TabIndex = 5;
            this.robotLabel.Text = "EV3 Robot Status";
            // 
            // robotStatus
            // 
            this.robotStatus.AutoSize = true;
            this.robotStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.robotStatus.Location = new System.Drawing.Point(178, 32);
            this.robotStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.robotStatus.Name = "robotStatus";
            this.robotStatus.Size = new System.Drawing.Size(92, 23);
            this.robotStatus.TabIndex = 6;
            this.robotStatus.Text = "OFFLINE";
            // 
            // webcamStatus
            // 
            this.webcamStatus.AutoSize = true;
            this.webcamStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.webcamStatus.Location = new System.Drawing.Point(11, 81);
            this.webcamStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.webcamStatus.Name = "webcamStatus";
            this.webcamStatus.Size = new System.Drawing.Size(92, 23);
            this.webcamStatus.TabIndex = 12;
            this.webcamStatus.Text = "OFFLINE";
            // 
            // webcamLabel
            // 
            this.webcamLabel.AutoSize = true;
            this.webcamLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamLabel.Location = new System.Drawing.Point(12, 64);
            this.webcamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.webcamLabel.Name = "webcamLabel";
            this.webcamLabel.Size = new System.Drawing.Size(119, 17);
            this.webcamLabel.TabIndex = 11;
            this.webcamLabel.Text = "Webcam Status";
            // 
            // startConnect
            // 
            this.startConnect.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startConnect.Location = new System.Drawing.Point(15, 377);
            this.startConnect.Name = "startConnect";
            this.startConnect.Size = new System.Drawing.Size(88, 31);
            this.startConnect.TabIndex = 13;
            this.startConnect.Text = "XInput";
            this.startConnect.UseVisualStyleBackColor = true;
            this.startConnect.Click += new System.EventHandler(this.startConnect_Click);
            // 
            // vlcStream
            // 
            this.vlcStream.Enabled = true;
            this.vlcStream.Location = new System.Drawing.Point(342, 32);
            this.vlcStream.Name = "vlcStream";
            this.vlcStream.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlcStream.OcxState")));
            this.vlcStream.Size = new System.Drawing.Size(408, 341);
            this.vlcStream.TabIndex = 16;
            // 
            // sendTest
            // 
            this.sendTest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendTest.Location = new System.Drawing.Point(108, 377);
            this.sendTest.Name = "sendTest";
            this.sendTest.Size = new System.Drawing.Size(88, 31);
            this.sendTest.TabIndex = 18;
            this.sendTest.Text = "Msg";
            this.sendTest.UseVisualStyleBackColor = true;
            this.sendTest.Click += new System.EventHandler(this.sendTest_Click);
            // 
            // debugLog
            // 
            this.debugLog.FormattingEnabled = true;
            this.debugLog.ItemHeight = 16;
            this.debugLog.Location = new System.Drawing.Point(15, 111);
            this.debugLog.Name = "debugLog";
            this.debugLog.Size = new System.Drawing.Size(300, 260);
            this.debugLog.TabIndex = 19;
            // 
            // tcpLabel
            // 
            this.tcpLabel.AutoSize = true;
            this.tcpLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpLabel.Location = new System.Drawing.Point(179, 64);
            this.tcpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcpLabel.Name = "tcpLabel";
            this.tcpLabel.Size = new System.Drawing.Size(87, 17);
            this.tcpLabel.TabIndex = 20;
            this.tcpLabel.Text = "TCP Status";
            // 
            // tcpStatus
            // 
            this.tcpStatus.AutoSize = true;
            this.tcpStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tcpStatus.Location = new System.Drawing.Point(178, 81);
            this.tcpStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcpStatus.Name = "tcpStatus";
            this.tcpStatus.Size = new System.Drawing.Size(92, 23);
            this.tcpStatus.TabIndex = 21;
            this.tcpStatus.Text = "OFFLINE";
            // 
            // DefuseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 477);
            this.Controls.Add(this.tcpStatus);
            this.Controls.Add(this.tcpLabel);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.sendTest);
            this.Controls.Add(this.vlcStream);
            this.Controls.Add(this.startConnect);
            this.Controls.Add(this.webcamStatus);
            this.Controls.Add(this.webcamLabel);
            this.Controls.Add(this.robotStatus);
            this.Controls.Add(this.robotLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.controllerStatusLabel);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.metroUserControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DefuseUI";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefuseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcStream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroLabel label_version;
        private System.Windows.Forms.Label controllerStatusLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label robotLabel;
        private System.Windows.Forms.Label robotStatus;
        private AxAXVLC.AxVLCPlugin2 VLC;
        private System.Windows.Forms.Label webcamStatus;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Button startConnect;
        private AxAXVLC.AxVLCPlugin2 vlcStream;
        private System.Windows.Forms.Button sendTest;
        private System.Windows.Forms.ListBox debugLog;
        private System.Windows.Forms.Label tcpLabel;
        private System.Windows.Forms.Label tcpStatus;
    }
}

