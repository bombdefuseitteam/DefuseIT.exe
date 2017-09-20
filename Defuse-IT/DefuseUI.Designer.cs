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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(213, 111);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 0;
            this.metroUserControl1.UseSelectable = true;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(933, 609);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(97, 20);
            this.label_version.TabIndex = 1;
            this.label_version.Text = "Version: 1.0.0.1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(312, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DefuseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "DefuseUI";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefuseUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroLabel label_version;
        private System.Windows.Forms.Button button1;
    }
}

