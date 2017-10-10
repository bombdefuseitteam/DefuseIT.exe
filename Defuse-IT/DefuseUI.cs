using Defuse_IT.XInput;
using Defuse_IT.EV3;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;


namespace Defuse_IT
{
    public partial class DefuseUI : MetroForm
    {
        internal bool EV3Alive;
        XInputController con = new XInputController();
        EV3Connection tcpcon = new EV3Connection();


        public DefuseUI()
        {
            //Init UI
            InitializeComponent();
            //Init Controller
            con.getController();
            //Init TCP Client
            statusController();
            //Check if EV3 status
            statusEV3();
            //TCP Connection
            StatusTCP();
        }

        void StatusTCP()
        {
            tcpcon.initConnection(1337);
            if (tcpcon.socketClient.Connected)
            {
                tcpStatus.Text = "ONLINE";
                tcpStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        //Ping EV3 to check if its online
        internal void statusEV3()
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

        //Check Controller Status
        internal void statusController()
        {
            if (con.IsConnected)
            {
                statusLabel.Text = "ONLINE";
                statusLabel.ForeColor = System.Drawing.Color.Green;
            }
        }

        //Load with UI
        void DefuseUI_Load(object sender, EventArgs e)
        {
        

        }


        //Start Connection with Controller
        private void startConnect_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker_1 = new BackgroundWorker();
            con.listenToController = true;
            worker_1.DoWork += con.getState;
            worker_1.RunWorkerAsync();
        }

        private void tcpButton_Click(object sender, EventArgs e)
        {
            tcpcon.initConnection(1337);
        }

        private void sendTest_Click(object sender, EventArgs e)
        {
            tcpcon.sendOutput("["+System.DateTime.Now + "]" + " Message: Test");
        }
    }
}
