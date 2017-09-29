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
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.label_version = new MetroFramework.Controls.MetroLabel();
            this.controllerStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.robotLabel = new System.Windows.Forms.Label();
            this.robotStatus = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.webcamStatus = new System.Windows.Forms.Label();
            this.webcamLabel = new System.Windows.Forms.Label();
            this.startConnect = new System.Windows.Forms.Button();
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
            this.label_version.Location = new System.Drawing.Point(6, 398);
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
            this.robotLabel.Location = new System.Drawing.Point(12, 80);
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
            this.robotStatus.Location = new System.Drawing.Point(11, 97);
            this.robotStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.robotStatus.Name = "robotStatus";
            this.robotStatus.Size = new System.Drawing.Size(92, 23);
            this.robotStatus.TabIndex = 6;
            this.robotStatus.Text = "OFFLINE";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(12, 227);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(96, 17);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "Controller Y:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(12, 210);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(98, 17);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "Controller X:";
            // 
            // webcamStatus
            // 
            this.webcamStatus.AutoSize = true;
            this.webcamStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.webcamStatus.Location = new System.Drawing.Point(11, 159);
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
            this.webcamLabel.Location = new System.Drawing.Point(12, 142);
            this.webcamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.webcamLabel.Name = "webcamLabel";
            this.webcamLabel.Size = new System.Drawing.Size(119, 17);
            this.webcamLabel.TabIndex = 11;
            this.webcamLabel.Text = "Webcam Status";
            // 
            // startConnect
            // 
            this.startConnect.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startConnect.Location = new System.Drawing.Point(60, 323);
            this.startConnect.Name = "startConnect";
            this.startConnect.Size = new System.Drawing.Size(257, 61);
            this.startConnect.TabIndex = 13;
            this.startConnect.Text = "Start";
            this.startConnect.UseVisualStyleBackColor = true;
            this.startConnect.Click += new System.EventHandler(this.startConnect_Click);
            // 
            // DefuseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 432);
            this.Controls.Add(this.startConnect);
            this.Controls.Add(this.webcamStatus);
            this.Controls.Add(this.webcamLabel);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
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
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label webcamStatus;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Button startConnect;
    }
}

