using Defuse_IT.XInput;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Defuse_IT
{

    
    public partial class DefuseUI : MetroForm
    {

        internal bool EV3Alive;
        XInputController con = new XInputController();
        public DefuseUI()
        {
            InitializeComponent();
            con.getController();
            statusController();
            statusEV3();
        }



        void addVLC()
        {
        }

        void statusEV3()
        {
            Ping sendping = new Ping();
            var reply = sendping.Send(Properties.Settings.Default.IPAdress);

            if (reply.Status == IPStatus.Success)
            {
                EV3Alive = true;
                robotStatus.Text = "ONLINE";
                robotStatus.ForeColor = System.Drawing.Color.Green;

            }

        }

        void statusController()
        {
            if (con.IsConnected)
            {
                statusLabel.Text = "ONLINE";
                statusLabel.ForeColor = System.Drawing.Color.Green;
            }
        }

        void DefuseUI_Load(object sender, EventArgs e)
        {
        

        }

        void WebcamVLC_Enter(object sender, EventArgs e)
        {

        }

        private void startConnect_Click(object sender, EventArgs e)
        {
            con.getState();
            con.listenToController = true;
        }
    }
}
