using SharpDX.XInput;
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
        public void getState()
        {
            //Get Previous State
            var previousState = controller.GetState();
            
            //Do This:
            while (controller.IsConnected && listenToController)
            {
                var state = controller.GetState();
                if (previousState.PacketNumber != state.PacketNumber)
                {
                    MessageBox.Show(state.Gamepad.ToString());
                    Thread.Sleep(30);
                }

                previousState = state;
            }
        }

    }
}
