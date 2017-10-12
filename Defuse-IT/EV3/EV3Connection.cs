
using System.Management.Instrumentation;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using Defuse_IT.XInput;

namespace Defuse_IT.EV3
{
    internal class EV3Connection
    {
        //TCP Socket Client
        internal TcpClient socketClient = new TcpClient();
        XInputController con = new XInputController();
        internal string returnData;


        internal void initConnection(int port)
        {
            //IP + PORT TCP Client
            try
            {
                socketClient.Connect(Properties.Settings.Default.IPAdress, port);
                
            }
            catch (System.Exception e)
            {

                MessageBox.Show("Error TCP Connection! " + e);
            }

        }

        //send String Output to Socket Server Stream
        internal void sendOutput(string output)
        {
            NetworkStream serverStream = socketClient.GetStream();
            byte[] outStream = Encoding.ASCII.GetBytes(output);

            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

    }
}
