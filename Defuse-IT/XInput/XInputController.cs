using SharpDX.XInput;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Defuse_IT.EV3;

namespace Defuse_IT.XInput
{
    internal class XInputController
    {
        internal bool IsConnected = false;
        internal bool ListenToController = false;
        internal string returnData;

        Controller _controller;
        internal void StartController()
        {
            BackgroundWorker worker1 = new BackgroundWorker();
            ListenToController = true;
            worker1.DoWork += GetState;
            worker1.RunWorkerAsync();
        }

       internal void StartListener()
        {
            BackgroundWorker worker2 = new BackgroundWorker();
            ListenToController = true;
            worker2.DoWork += Listen;
            worker2.RunWorkerAsync();
        }

        void Listen(object sender, DoWorkEventArgs e)
        {
            EV3Connection tcp = new EV3Connection();
            tcp.initConnection(1337);
            while (true)
            {
                tcp.sendOutput("[DefuseIT-UI] mode = RECEIVING");
                byte[] inStream = new byte[10025];

                NetworkStream serverStream = tcp.socketClient.GetStream();
                var count = serverStream.Read(inStream, 0, inStream.Length);
                returnData = Encoding.ASCII.GetString(inStream, 0, count);

                tcp.sendOutput("CLIENT: " + returnData);
            }

        }
        internal void GetController()
        {
            // Initialize XInput
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two),
                new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            //Get First Xinput Device
            foreach (var selectController in controllers)
            {
                //Check if Controller is Connected
                if (selectController.IsConnected)
                {
                    _controller = selectController;
                    IsConnected = true;
                    break;
                }
            }     
        }
        internal void GetState(object sender, DoWorkEventArgs e)
        {
            EV3Connection tcp = new EV3Connection();
            tcp.initConnection(1337);
            tcp.sendOutput("[DefuseIT-UI] mode = SENDING");

            while (_controller.IsConnected && ListenToController)
            {
                var state = _controller.GetState();
                var cState = state.Gamepad;

                //X
                var leftThumbX = 0;
                leftThumbX = cState.LeftThumbX;
                //RTrigger Forward
                var rTrigger = 0;
                rTrigger = cState.RightTrigger;
                //LTrigger Backwards
                var lTrigger = 0;
                lTrigger = cState.LeftTrigger;

                #region Niks te zien hier
                                //PLUS
                if (leftThumbX > 0 && leftThumbX <= 3000)
                    leftThumbX = 0;

                if (leftThumbX > 3000 && leftThumbX <= 5000)
                    leftThumbX = 0;

                if (leftThumbX > 5000 && leftThumbX <= 8000)
                    leftThumbX = 12;

                if (leftThumbX > 8000 && leftThumbX <= 11000)
                    leftThumbX = 13;

                if (leftThumbX > 11000 && leftThumbX <= 14000)
                    leftThumbX = 14;

                if (leftThumbX > 14000 && leftThumbX <= 17000)
                    leftThumbX = 15;

                if (leftThumbX > 17000 && leftThumbX <= 20000)
                    leftThumbX = 16;

                if (leftThumbX > 20000 && leftThumbX <= 23000)
                    leftThumbX = 17;

                if (leftThumbX > 23000 && leftThumbX <= 26000)
                    leftThumbX = 18;

                if (leftThumbX > 26000 && leftThumbX <= 29000)
                    leftThumbX = 19;

                if (leftThumbX > 29000 && leftThumbX <= 35000)
                    leftThumbX = 20;

                //MINUS
                if (leftThumbX < 0 && leftThumbX >= -3000)
                    leftThumbX = 0;

                if (leftThumbX < -3000 && leftThumbX >= -5000)
                    leftThumbX = 0;

                if (leftThumbX < -5000 && leftThumbX >= -8000)
                    leftThumbX = 2;

                if (leftThumbX < -8000 && leftThumbX >= -11000)
                    leftThumbX = 3;

                if (leftThumbX < -11000 && leftThumbX >= -14000)
                    leftThumbX = 4;

                if (leftThumbX < -14000 && leftThumbX >= -17000)
                    leftThumbX = 5;

                if (leftThumbX < -17000 && leftThumbX >= -20000)
                    leftThumbX = 6;

                if (leftThumbX < -20000 && leftThumbX >= -23000)
                    leftThumbX = 7;

                if (leftThumbX < -23000 && leftThumbX >= -26000)
                    leftThumbX = 8;

                if (leftThumbX < -26000 && leftThumbX >= -29000)
                    leftThumbX = 9;

                if (leftThumbX < -29000 && leftThumbX >= -35000)
                    leftThumbX = 10;

                #endregion

                if (leftThumbX > 0)
                {
                    tcp.sendOutput("X = " + leftThumbX);
                    Thread.Sleep(100);
                }
                if (rTrigger > 0 && leftThumbX < 1)
                {
                    tcp.sendOutput("F = " + (rTrigger * 2));
                    Thread.Sleep(100);
                }

                if (lTrigger > 0 && leftThumbX < 1)
                {
                    tcp.sendOutput("B = " + (lTrigger * 2));
                    Thread.Sleep(100);
                }


            }
        }

    }
}
