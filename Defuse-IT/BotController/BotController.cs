using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;

namespace Defuse_IT
{
    class BotController
    {
        internal int x;
        internal int y;
        Controller controller;


        public void start()
        {

        }

        void getController()
        {
            // SharpDX New Controller using Index Any (Any Controller)
            controller = new Controller(UserIndex.Any);

            if (controller == null)
            {
                Console.WriteLine("No XInput controller connected");
            }
            else
            {
                Console.WriteLine("Controller Connected, Type: " + controller.ToString());
            }        
        }

        void getInput()
        {
            //Get Current Controller State
            var state = controller.GetState();
            x = state.Gamepad.RightThumbX;
            y = state.Gamepad.RightThumbY;
        }

        void sendOutput()
        {

        }
    }
}
