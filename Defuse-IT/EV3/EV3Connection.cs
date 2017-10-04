
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Defuse_IT.EV3
{
    class EV3Connection
    {
        //TCP Socket Client
        internal TcpClient socketClient = new TcpClient();

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

        }

        //Read stream from Socket Server
        internal void readInput()
        {
            NetworkStream serverStream = socketClient.GetStream();
            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, socketClient.ReceiveBufferSize);
            string returndata = Encoding.ASCII.GetString(inStream);
        }
    }
}
