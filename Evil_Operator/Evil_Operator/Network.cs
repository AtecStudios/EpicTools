using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
namespace Evil_Operator
{
    class Packet
    {
        public byte[] buffer;
        public byte[] bRecv, bSend;
        public string strRecv, strSend;
        public bool TF = false;// if true then send if false then recieve
        public Packet()
        {
            bSend = new byte[1000];
        }
        ~Packet()
        {
        }
        public void Toggle()
        {
            TF = TF==true?false:true;
        }
        public void ClearBuffer()
        {
            Array.Clear(buffer, 0, buffer.Length);
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
        public Packet packet = new Packet();
        public TcpClient cSocket = new TcpClient();
        public NetworkStream cStream;
        public TcpListener sSocket;
        public Network()
        {
            
        }

        public void Start()
        {
            ListenTCP();
            AcceptTCP();
            ListenStop();
            cStream = cSocket.GetStream();
            Console.WriteLine("Stream created.");            
        }
        public void ListenTCP()
        {
            sSocket = new TcpListener(IPAddress.Any, 8888);
            sSocket.Start();
            Console.WriteLine("Server started listening for incoming connecting.");
        }
        public void ListenStop()
        {
            sSocket.Stop();
            Console.WriteLine("Stopped listening for connections.");
        }

        public void AcceptTCP()
        {
            cSocket = sSocket.AcceptTcpClient();
            Console.WriteLine("Connection found at:" + cSocket.Client.RemoteEndPoint.AddressFamily.ToString());
        }
        public void Reset()
        {
            Disconnect();
            Start();
        }
        public void Recv()
        {
            packet.bRecv =  new byte[cStream.Read(packet.buffer, 0, cSocket.ReceiveBufferSize)];
            Array.Copy(packet.buffer, packet.bRecv, packet.bRecv.Length);
            packet.ConvertRecvtoString();
            Console.WriteLine("Recv:" + packet.strRecv);
        }
        public void Send()
        {
            packet.ConvertSendtoByte();
            cStream.Write(packet.bSend, 0, packet.bSend.Length);
            cStream.Flush();
            Console.WriteLine("Sent:" + packet.strSend);
        }
        public void CloseServerSocket()
        {
            sSocket.Stop();
            sSocket = null;
            Console.WriteLine("Closed server socket.");
        }
        public void CloseClientSocket()
        {
            cSocket.Close();
            cSocket = null;
            Console.WriteLine("Closed client socket.");
        }
        public void CloseStream()
        {
            cStream.Close();
            cStream = null;
            Console.WriteLine("Closed stream.");
        }
        public void Disconnect()
        {
            Console.WriteLine("Closed");
            CloseStream();
            CloseServerSocket();
            CloseClientSocket();
        }
        ~Network()
        {
            Disconnect();
        }
    }
}

