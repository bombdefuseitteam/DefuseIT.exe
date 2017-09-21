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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebcamVLC = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.WebcamVLC)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(160, 90);
            this.metroUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(6, 6);
            this.metroUserControl1.TabIndex = 0;
            this.metroUserControl1.UseSelectable = true;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(700, 495);
            this.label_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(91, 19);
            this.label_version.TabIndex = 1;
            this.label_version.Text = "Version: 1.0.0.1";
            // 
            // controllerStatusLabel
            // 
            this.controllerStatusLabel.AutoSize = true;
            this.controllerStatusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerStatusLabel.Location = new System.Drawing.Point(4, 10);
            this.controllerStatusLabel.Name = "controllerStatusLabel";
            this.controllerStatusLabel.Size = new System.Drawing.Size(104, 13);
            this.controllerStatusLabel.TabIndex = 2;
            this.controllerStatusLabel.Text = "Controller Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(4, 23);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 18);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "OFFLINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EV3 Robot Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "OFFLINE";
            // 
            // WebcamVLC
            // 
            this.WebcamVLC.Enabled = true;
            this.WebcamVLC.Location = new System.Drawing.Point(18, 114);
            this.WebcamVLC.Name = "WebcamVLC";
            this.WebcamVLC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WebcamVLC.OcxState")));
            this.WebcamVLC.Size = new System.Drawing.Size(754, 364);
            this.WebcamVLC.TabIndex = 7;
            // 
            // DefuseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 518);
            this.Controls.Add(this.WebcamVLC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.controllerStatusLabel);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.metroUserControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DefuseUI";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefuseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebcamVLC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroLabel label_version;
        private System.Windows.Forms.Label controllerStatusLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AxAXVLC.AxVLCPlugin2 VLC;
        private AxAXVLC.AxVLCPlugin2 WebcamVLC;
    }
}

