using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MCAdmin
{
    class ServerControl
    {
        private static Socket sock = new Socket(SocketType.Stream, ProtocolType.Tcp);
        private static void writeData(String data)
        {
            try
            {
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 14579);
                sock.ReceiveTimeout = 5000;
                sock.Connect(serverAddress);
                int toSendLen = Encoding.ASCII.GetByteCount(data);
                byte[] toSendBytes = Encoding.ASCII.GetBytes(data);
                byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
                sock.Send(toSendLenBytes);
                sock.Send(toSendBytes);
                sock.Receive(new byte[8192]);
                sock.Disconnect(true);
            } catch (Exception e)
            {
                MessageBox.Show("MCAdmin could not connect to the server, or did not receive a reply back from the server. The current action cannot be executed. If you are receiving this error, make sure that:\n\n1. The server is running\n2. The server is not vanilla\n3. The server is running the MCAdmin plugin (run the command /mcadmin in game)\n4. If the server is remote, you have typed in the correct IP.\n\nIf all of these are true, then please submit a ticket to us on GitHub with the following information:\n" + e.Message,
                    "MCAdmin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void sendCommand(String command)
        {
            writeData(String.Format("COMMAND {0}", command));
        }

        public static void banUser(String username)
        {
            writeData(String.Format("BAN {0}", username));
        }

        public static void kickUser(String username)
        {
            writeData(String.Format("KICK {0}", username));
        }

    }
}
