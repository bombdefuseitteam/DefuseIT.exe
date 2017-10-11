using SharpDX.XInput;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Defuse_IT.XInput
{
    class XInputController
    {
        internal bool IsConnected = false;
        internal bool listenToController = false;

        Controller controller;

        internal void getController()
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
                    controller = selectController;
                    MessageBox.Show("XINPUT Device Found! ID = " + selectController.UserIndex);
                    IsConnected = true;
                    break;
                }
            }     
        }
        internal void getState(object sender, DoWorkEventArgs e)
        {
            var previousState = controller.GetState();
            EV3.EV3Connection tcp = new EV3.EV3Connection();
            tcp.initConnection(1337);          

            while (controller.IsConnected && listenToController)
            {
                var state = controller.GetState();
                var cState = state.Gamepad;

                //X
                int LeftThumbX = 0;
                LeftThumbX = cState.LeftThumbX;
                //RTrigger Forward
                int RTrigger = 0;
                RTrigger = cState.RightTrigger;
                //LTrigger Backwards
                int LTrigger = 0;
                LTrigger = cState.LeftTrigger;

                #region Niks te zien hier
                                //PLUS
                                if (LeftThumbX > 0 && LeftThumbX <= 3000)
                                    LeftThumbX = 0;

                                if (LeftThumbX > 3000 && LeftThumbX <= 5000)
                                    LeftThumbX = 0;

                                if (LeftThumbX > 5000 && LeftThumbX <= 8000)
                                    LeftThumbX = 12;

                                if (LeftThumbX > 8000 && LeftThumbX <= 11000)
                                    LeftThumbX = 13;

                                if (LeftThumbX > 11000 && LeftThumbX <= 14000)
                                    LeftThumbX = 14;

                                if (LeftThumbX > 14000 && LeftThumbX <= 17000)
                                    LeftThumbX = 15;

                                if (LeftThumbX > 17000 && LeftThumbX <= 20000)
                                    LeftThumbX = 16;

                                if (LeftThumbX > 20000 && LeftThumbX <= 23000)
                                    LeftThumbX = 17;

                                if (LeftThumbX > 23000 && LeftThumbX <= 26000)
                                    LeftThumbX = 18;

                                if (LeftThumbX > 26000 && LeftThumbX <= 29000)
                                    LeftThumbX = 19;

                                if (LeftThumbX > 29000 && LeftThumbX <= 35000)
                                    LeftThumbX = 20;

                                //MINUS
                                if (LeftThumbX < 0 && LeftThumbX >= -3000)
                                    LeftThumbX = 0;

                                if (LeftThumbX < -3000 && LeftThumbX >= -5000)
                                    LeftThumbX = 0;

                                if (LeftThumbX < -5000 && LeftThumbX >= -8000)
                                    LeftThumbX = 2;

                                if (LeftThumbX < -8000 && LeftThumbX >= -11000)
                                    LeftThumbX = 3;

                                if (LeftThumbX < -11000 && LeftThumbX >= -14000)
                                    LeftThumbX = 4;

                                if (LeftThumbX < -14000 && LeftThumbX >= -17000)
                                    LeftThumbX = 5;

                                if (LeftThumbX < -17000 && LeftThumbX >= -20000)
                                    LeftThumbX = 6;

                                if (LeftThumbX < -20000 && LeftThumbX >= -23000)
                                    LeftThumbX = 7;

                                if (LeftThumbX < -23000 && LeftThumbX >= -26000)
                                    LeftThumbX = 8;

                                if (LeftThumbX < -26000 && LeftThumbX >= -29000)
                                    LeftThumbX = 9;

                                if (LeftThumbX < -29000 && LeftThumbX >= -35000)
                                    LeftThumbX = 10;

                #endregion

                if (LeftThumbX > 0)
                {
                    tcp.sendOutput("X = " + LeftThumbX);
                    Thread.Sleep(100);
                }
                if (RTrigger > 0)
                {
                    tcp.sendOutput("F = " + RTrigger);
                    Thread.Sleep(100);
                }

                if (LTrigger > 0)
                {
                    tcp.sendOutput("B = " + LTrigger);
                    Thread.Sleep(100);
                }


                if (!cState.Buttons.ToString().ToLower().Contains("none")
                    && cState.Buttons.ToString().ToLower().Contains("b"))
                {
                    tcp.sendOutput("BB");
                    Thread.Sleep(100);
                }

                if (!cState.Buttons.ToString().ToLower().Contains("none")
                    && cState.Buttons.ToString().ToLower().Contains("y"))
                {
                    tcp.sendOutput("Y");
                    Thread.Sleep(100);
                }


                //Input Stream

            }
        }

    }
}
