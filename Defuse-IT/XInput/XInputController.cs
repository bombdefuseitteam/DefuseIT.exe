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
            //Get Previous State
            var previousState = controller.GetState();
            EV3.EV3Connection tcp = new EV3.EV3Connection();
            tcp.initConnection(1337);
            

            //Do This:
            while (controller.IsConnected && listenToController)
            {
                var state = controller.GetState();
                if (previousState.PacketNumber != state.PacketNumber && !state.Gamepad.Buttons.ToString().Contains("None"))
                {
                    tcp.sendOutput(state.Gamepad.Buttons.ToString());
                }

                if (previousState.PacketNumber != state.PacketNumber)
                {
                    tcp.sendOutput(state.Gamepad.LeftThumbX.ToString());
                    tcp.sendOutput(state.Gamepad.LeftThumbY.ToString());
                    tcp.sendOutput(state.Gamepad.RightTrigger.ToString());
                }

            }
        }

    }
}
