using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace VLCControl
{
    class VLCRemoteController
    {
        VLCRemoteController()
        {
            m_client = new TcpClient();
        }

        ~VLCRemoteController()
        {
            disconnect();
        }

        /**
         * Connect to VLC player
         * 
         * @return: true if success.
         * */
        public bool connect(String ip, Int32 port)
        {
            bool res = false;
            try
            {
                m_client = new TcpClient(ip, port);
                if (isSocketConnected())
                {
                    m_networkStream = m_client.GetStream();
                }
            }
            catch
            {
                Console.WriteLine("Error in VLCRemoteController::connect");
            }

            return res;
        }

        /**
         * Disconnect from VLC player.
         * */
        public void disconnect()
        {
            if (isSocketConnected())
            {
                m_client.Close();
                m_networkStream.Close();
            }
        }

        /**
         * Send raw command to VLC. This function add \n to the end.
         * */
        public bool sendCustomCommand(String command)
        {
            bool res = false;
            if (isSocketConnected())
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes(command + "\n");
                m_networkStream.Write(data, 0, data.Length);
                res = true;
            }

            return res;
        }

        /**
         * Return current buffer from VLC player.
         * */
        public String reciveAnswer()
        {
            String res = String.Empty;
            if (isSocketConnected())
            {
                const int chunkSize = 4048;
                Byte[] data = new Byte[chunkSize];
                while (m_client.Available > 0)
                {

                    Int32 readBytes = m_networkStream.Read(data, 0, data.Length);
                    res = res + System.Text.Encoding.UTF8.GetString(data, 0, readBytes);
                }
            }

            return res;
        }


        private bool isSocketConnected()
        {
            return m_client.Connected;
        }

        // This is client socket.
        private TcpClient m_client;

        // Stream for socket.
        private NetworkStream m_networkStream;
    }
}
