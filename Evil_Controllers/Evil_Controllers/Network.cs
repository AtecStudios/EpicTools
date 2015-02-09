using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Evil_Controllers
{
    class Packet
    {
        public byte[] buffer;
        public byte[] bRecv, bSend;
        public string strRecv, strSend;
        public bool TF=false,TEF=false;
        public Packet()
        {
            bSend = new byte[1000];
        }
        ~Packet()
        {
        }
        public void ToggleECFlag()
        {
            TEF = TEF == true ? false : true;
        }
        public void Toggle()
        {
            TF = TF == true ? false : true;
        }
        public void ClearBuffer()
        {
            Array.Clear(buffer, 0, buffer.Length);
        }
        public void ClearRecvString()
        {
            strRecv = "";
        }
        public void ClearSendString()
        {
            strSend = "";
        }
        public void ConvertRecvtoString()
        {
            strRecv = System.Text.Encoding.ASCII.GetString(bRecv);
        }
        public void ConvertSendtoString()
        {
            strSend = System.Text.Encoding.ASCII.GetString(bSend);
        }
        public void ConvertRecvtoByte()
        {
            bRecv = System.Text.Encoding.ASCII.GetBytes(strRecv);
        }
        public void ConvertSendtoByte()
        {
            bSend = System.Text.Encoding.ASCII.GetBytes(strSend);
        }
    }

    class Network
    {
        public Packet packet;
        public IPAddress IP;
        public TcpClient cSocket;
        public NetworkStream cStream;

        public Network()
        {
            packet = new Packet();
        }
        public void Connect()
        {
            EC_Console.WriteToConsole("Attempting to connect to IP:" + IP.ToString());
            cSocket = new TcpClient();
            try
            {
                cSocket.Connect(IP, 8888);
                EC_Console.WriteToConsole("Connected to server.");
                cStream = cSocket.GetStream();
                EC_Console.WriteToConsole("Created stream.");
                if(packet.buffer == null)
                {
                    packet.buffer = new byte[cSocket.ReceiveBufferSize];
                    EC_Console.WriteToConsole("Created buffer. Ready to send and recieve.");
                }
            }
            catch(Exception ex)
            {
                EC_Console.WriteToConsole("Exception thrown: " + ex.ToString());
                EC_Console.WriteToConsole("Maybe no server online?");
            }
        }
        public void Send()
        {
            packet.ConvertSendtoByte();
            cStream.Write(packet.bSend, 0, packet.bSend.Length);
            cStream.Flush();
            packet.ConvertSendtoString();
        }
        public void Recv()
        {
            packet.bRecv =  new byte[cStream.Read(packet.buffer, 0, cSocket.ReceiveBufferSize)];
            Array.Copy(packet.buffer, packet.bRecv, packet.bRecv.Length);
            packet.ConvertRecvtoString();
        }
        void CloseClientSocket()
        {
            cSocket.Close();
            cSocket = null;
            EC_Console.WriteToConsole("Closed client socket connection.");
        }
        void CloseStreamSocket()
        {
            cStream.Close();
            cStream = null;
            EC_Console.WriteToConsole("Closed stream.");
        }
        public void Disconnect()
        {
            if (cStream != null)
            {
                if (cSocket != null )
                {
                    CloseClientSocket();
                }
                else
                {
                    EC_Console.WriteToConsole("No socket open to close.");
                }
                CloseStreamSocket();
            }
            else
            {
                EC_Console.WriteToConsole("No stream open to close.");
            }
        }
    }
}
