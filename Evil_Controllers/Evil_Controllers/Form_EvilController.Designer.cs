namespace Evil_Controllers
{
    partial class Form_EvilController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                if(netThread.IsAlive)
                {
                    netThread.Abort();
                }
                
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b_connect = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.b_disconnect = new System.Windows.Forms.Button();
            this.g_connect = new System.Windows.Forms.GroupBox();
            this.g_dialog = new System.Windows.Forms.GroupBox();
            this.g_buttontype = new System.Windows.Forms.GroupBox();
            this.bt_msg_info = new System.Windows.Forms.Button();
            this.b_msg_warning = new System.Windows.Forms.Button();
            this.b_msg_error = new System.Windows.Forms.Button();
            this.g_spam = new System.Windows.Forms.GroupBox();
            this.l_numberofboxes = new System.Windows.Forms.Label();
            this.cb_msg_infinite = new System.Windows.Forms.CheckBox();
            this.nud_spam_tospam = new System.Windows.Forms.NumericUpDown();
            this.tb_msg_toshow = new System.Windows.Forms.TextBox();
            this.b_msg_show = new System.Windows.Forms.Button();
            this.g_key = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.g_mouse = new System.Windows.Forms.GroupBox();
            this.b_mouse_apply = new System.Windows.Forms.Button();
            this.b_mouse_rmb = new System.Windows.Forms.Button();
            this.b_mouse_lmb = new System.Windows.Forms.Button();
            this.g_mouse_location = new System.Windows.Forms.GroupBox();
            this.cb_mouse_loc_inverty = new System.Windows.Forms.CheckBox();
            this.cb_mouse_loc_invertx = new System.Windows.Forms.CheckBox();
            this.cb_mouse_loc_scany = new System.Windows.Forms.CheckBox();
            this.cb_mouse_loc_scanx = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_mouse_loc_randompulse = new System.Windows.Forms.NumericUpDown();
            this.cb_mouse_loc_random = new System.Windows.Forms.CheckBox();
            this.g_mouse_speed = new System.Windows.Forms.GroupBox();
            this.cb_mouse_speed_random = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_mouse_speed_maxval = new System.Windows.Forms.NumericUpDown();
            this.nud_mouse_speed_minval = new System.Windows.Forms.NumericUpDown();
            this.cb_mouse_speed_grade = new System.Windows.Forms.CheckBox();
            this.nud_mouse_speed_Speed = new System.Windows.Forms.NumericUpDown();
            this.g_CMD = new System.Windows.Forms.GroupBox();
            this.cb_cmd_msgtosend = new System.Windows.Forms.ComboBox();
            this.b_remotecmd_send = new System.Windows.Forms.Button();
            this.g_status = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.l_status_version = new System.Windows.Forms.Label();
            this.g_status_console = new System.Windows.Forms.GroupBox();
            this.lb_console = new System.Windows.Forms.ListBox();
            this.l_status_online = new System.Windows.Forms.Label();
            this.l_status_pintime = new System.Windows.Forms.Label();
            this.l_status_ip = new System.Windows.Forms.Label();
            this.l_status_pc_name = new System.Windows.Forms.Label();
            this.l_status_c_os = new System.Windows.Forms.Label();
            this.l_status_c_error = new System.Windows.Forms.Label();
            this.l_status_c_p_s = new System.Windows.Forms.Label();
            this.g_clientstatus = new System.Windows.Forms.GroupBox();
            this.l_status_p_total = new System.Windows.Forms.Label();
            this.l_status_c_p_r = new System.Windows.Forms.Label();
            this.l_status_p_r = new System.Windows.Forms.Label();
            this.l_status_p_s = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.g_connect.SuspendLayout();
            this.g_dialog.SuspendLayout();
            this.g_buttontype.SuspendLayout();
            this.g_spam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_spam_tospam)).BeginInit();
            this.g_key.SuspendLayout();
            this.g_mouse.SuspendLayout();
            this.g_mouse_location.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_loc_randompulse)).BeginInit();
            this.g_mouse_speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_maxval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_minval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_Speed)).BeginInit();
            this.g_CMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.g_status_console.SuspendLayout();
            this.g_clientstatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(181, 16);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 1;
            this.b_connect.Text = "Connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(11, 20);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(164, 20);
            this.tb_ip.TabIndex = 2;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // b_disconnect
            // 
            this.b_disconnect.Location = new System.Drawing.Point(262, 16);
            this.b_disconnect.Name = "b_disconnect";
            this.b_disconnect.Size = new System.Drawing.Size(75, 23);
            this.b_disconnect.TabIndex = 4;
            this.b_disconnect.Text = "Disconnect";
            this.b_disconnect.UseVisualStyleBackColor = true;
            this.b_disconnect.Click += new System.EventHandler(this.b_disconnect_Click);
            // 
            // g_connect
            // 
            this.g_connect.Controls.Add(this.tb_ip);
            this.g_connect.Controls.Add(this.b_disconnect);
            this.g_connect.Controls.Add(this.b_connect);
            this.g_connect.Location = new System.Drawing.Point(12, 3);
            this.g_connect.Name = "g_connect";
            this.g_connect.Size = new System.Drawing.Size(343, 48);
            this.g_connect.TabIndex = 5;
            this.g_connect.TabStop = false;
            this.g_connect.Text = "Connect";
            // 
            // g_dialog
            // 
            this.g_dialog.Controls.Add(this.g_buttontype);
            this.g_dialog.Controls.Add(this.g_spam);
            this.g_dialog.Controls.Add(this.tb_msg_toshow);
            this.g_dialog.Controls.Add(this.b_msg_show);
            this.g_dialog.Location = new System.Drawing.Point(246, 325);
            this.g_dialog.Name = "g_dialog";
            this.g_dialog.Size = new System.Drawing.Size(228, 196);
            this.g_dialog.TabIndex = 7;
            this.g_dialog.TabStop = false;
            this.g_dialog.Text = "Dialog Box";
            // 
            // g_buttontype
            // 
            this.g_buttontype.Controls.Add(this.bt_msg_info);
            this.g_buttontype.Controls.Add(this.b_msg_warning);
            this.g_buttontype.Controls.Add(this.b_msg_error);
            this.g_buttontype.Location = new System.Drawing.Point(11, 45);
            this.g_buttontype.Name = "g_buttontype";
            this.g_buttontype.Size = new System.Drawing.Size(107, 100);
            this.g_buttontype.TabIndex = 10;
            this.g_buttontype.TabStop = false;
            this.g_buttontype.Text = "Button Type";
            // 
            // bt_msg_info
            // 
            this.bt_msg_info.Location = new System.Drawing.Point(6, 15);
            this.bt_msg_info.Name = "bt_msg_info";
            this.bt_msg_info.Size = new System.Drawing.Size(93, 23);
            this.bt_msg_info.TabIndex = 1;
            this.bt_msg_info.Text = "Info";
            this.bt_msg_info.UseVisualStyleBackColor = true;
            this.bt_msg_info.Click += new System.EventHandler(this.bt_msg_info_Click);
            // 
            // b_msg_warning
            // 
            this.b_msg_warning.Location = new System.Drawing.Point(6, 43);
            this.b_msg_warning.Name = "b_msg_warning";
            this.b_msg_warning.Size = new System.Drawing.Size(93, 23);
            this.b_msg_warning.TabIndex = 6;
            this.b_msg_warning.Text = "Warning";
            this.b_msg_warning.UseVisualStyleBackColor = true;
            this.b_msg_warning.Click += new System.EventHandler(this.b_msg_warning_Click);
            // 
            // b_msg_error
            // 
            this.b_msg_error.Location = new System.Drawing.Point(6, 71);
            this.b_msg_error.Name = "b_msg_error";
            this.b_msg_error.Size = new System.Drawing.Size(93, 23);
            this.b_msg_error.TabIndex = 4;
            this.b_msg_error.Text = "Error";
            this.b_msg_error.UseVisualStyleBackColor = true;
            this.b_msg_error.Click += new System.EventHandler(this.b_msg_error_Click);
            // 
            // g_spam
            // 
            this.g_spam.Controls.Add(this.l_numberofboxes);
            this.g_spam.Controls.Add(this.cb_msg_infinite);
            this.g_spam.Controls.Add(this.nud_spam_tospam);
            this.g_spam.Location = new System.Drawing.Point(124, 45);
            this.g_spam.Name = "g_spam";
            this.g_spam.Size = new System.Drawing.Size(95, 100);
            this.g_spam.TabIndex = 9;
            this.g_spam.TabStop = false;
            this.g_spam.Text = "Spam Options";
            // 
            // l_numberofboxes
            // 
            this.l_numberofboxes.AutoSize = true;
            this.l_numberofboxes.Location = new System.Drawing.Point(3, 48);
            this.l_numberofboxes.Name = "l_numberofboxes";
            this.l_numberofboxes.Size = new System.Drawing.Size(88, 13);
            this.l_numberofboxes.TabIndex = 9;
            this.l_numberofboxes.Text = "Number of Boxes";
            // 
            // cb_msg_infinite
            // 
            this.cb_msg_infinite.AutoSize = true;
            this.cb_msg_infinite.BackColor = System.Drawing.Color.Red;
            this.cb_msg_infinite.Location = new System.Drawing.Point(6, 19);
            this.cb_msg_infinite.Name = "cb_msg_infinite";
            this.cb_msg_infinite.Size = new System.Drawing.Size(87, 17);
            this.cb_msg_infinite.TabIndex = 8;
            this.cb_msg_infinite.Text = "Infinite Spam";
            this.cb_msg_infinite.UseVisualStyleBackColor = false;
            // 
            // nud_spam_tospam
            // 
            this.nud_spam_tospam.Location = new System.Drawing.Point(6, 71);
            this.nud_spam_tospam.Name = "nud_spam_tospam";
            this.nud_spam_tospam.Size = new System.Drawing.Size(83, 20);
            this.nud_spam_tospam.TabIndex = 7;
            // 
            // tb_msg_toshow
            // 
            this.tb_msg_toshow.Location = new System.Drawing.Point(11, 19);
            this.tb_msg_toshow.Name = "tb_msg_toshow";
            this.tb_msg_toshow.Size = new System.Drawing.Size(208, 20);
            this.tb_msg_toshow.TabIndex = 2;
            this.tb_msg_toshow.Text = "Message To Show";
            // 
            // b_msg_show
            // 
            this.b_msg_show.Location = new System.Drawing.Point(11, 151);
            this.b_msg_show.Name = "b_msg_show";
            this.b_msg_show.Size = new System.Drawing.Size(206, 34);
            this.b_msg_show.TabIndex = 3;
            this.b_msg_show.Text = "Show";
            this.b_msg_show.UseVisualStyleBackColor = true;
            this.b_msg_show.Click += new System.EventHandler(this.b_msg_show_Click);
            // 
            // g_key
            // 
            this.g_key.Controls.Add(this.button11);
            this.g_key.Controls.Add(this.label4);
            this.g_key.Controls.Add(this.label3);
            this.g_key.Controls.Add(this.label2);
            this.g_key.Location = new System.Drawing.Point(361, 3);
            this.g_key.Name = "g_key";
            this.g_key.Size = new System.Drawing.Size(451, 48);
            this.g_key.TabIndex = 8;
            this.g_key.TabStop = false;
            this.g_key.Text = "Danger Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 16);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(220, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Breaks Some Functions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(293, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(364, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destory";
            // 
            // g_mouse
            // 
            this.g_mouse.Controls.Add(this.b_mouse_apply);
            this.g_mouse.Controls.Add(this.b_mouse_rmb);
            this.g_mouse.Controls.Add(this.b_mouse_lmb);
            this.g_mouse.Controls.Add(this.g_mouse_location);
            this.g_mouse.Controls.Add(this.g_mouse_speed);
            this.g_mouse.Location = new System.Drawing.Point(12, 260);
            this.g_mouse.Name = "g_mouse";
            this.g_mouse.Size = new System.Drawing.Size(228, 261);
            this.g_mouse.TabIndex = 10;
            this.g_mouse.TabStop = false;
            this.g_mouse.Text = "Mouse";
            // 
            // b_mouse_apply
            // 
            this.b_mouse_apply.Location = new System.Drawing.Point(6, 213);
            this.b_mouse_apply.Name = "b_mouse_apply";
            this.b_mouse_apply.Size = new System.Drawing.Size(216, 42);
            this.b_mouse_apply.TabIndex = 14;
            this.b_mouse_apply.Text = "Apply";
            this.b_mouse_apply.UseVisualStyleBackColor = true;
            this.b_mouse_apply.Click += new System.EventHandler(this.b_mouse_apply_Click);
            // 
            // b_mouse_rmb
            // 
            this.b_mouse_rmb.Location = new System.Drawing.Point(119, 183);
            this.b_mouse_rmb.Name = "b_mouse_rmb";
            this.b_mouse_rmb.Size = new System.Drawing.Size(102, 23);
            this.b_mouse_rmb.TabIndex = 13;
            this.b_mouse_rmb.Text = "RMB";
            this.b_mouse_rmb.UseVisualStyleBackColor = true;
            // 
            // b_mouse_lmb
            // 
            this.b_mouse_lmb.Location = new System.Drawing.Point(7, 183);
            this.b_mouse_lmb.Name = "b_mouse_lmb";
            this.b_mouse_lmb.Size = new System.Drawing.Size(103, 23);
            this.b_mouse_lmb.TabIndex = 12;
            this.b_mouse_lmb.Text = "LMB";
            this.b_mouse_lmb.UseVisualStyleBackColor = true;
            // 
            // g_mouse_location
            // 
            this.g_mouse_location.Controls.Add(this.cb_mouse_loc_inverty);
            this.g_mouse_location.Controls.Add(this.cb_mouse_loc_invertx);
            this.g_mouse_location.Controls.Add(this.cb_mouse_loc_scany);
            this.g_mouse_location.Controls.Add(this.cb_mouse_loc_scanx);
            this.g_mouse_location.Controls.Add(this.label7);
            this.g_mouse_location.Controls.Add(this.nud_mouse_loc_randompulse);
            this.g_mouse_location.Controls.Add(this.cb_mouse_loc_random);
            this.g_mouse_location.Location = new System.Drawing.Point(96, 19);
            this.g_mouse_location.Name = "g_mouse_location";
            this.g_mouse_location.Size = new System.Drawing.Size(126, 157);
            this.g_mouse_location.TabIndex = 11;
            this.g_mouse_location.TabStop = false;
            this.g_mouse_location.Text = "Location";
            // 
            // cb_mouse_loc_inverty
            // 
            this.cb_mouse_loc_inverty.AutoSize = true;
            this.cb_mouse_loc_inverty.Location = new System.Drawing.Point(7, 94);
            this.cb_mouse_loc_inverty.Name = "cb_mouse_loc_inverty";
            this.cb_mouse_loc_inverty.Size = new System.Drawing.Size(63, 17);
            this.cb_mouse_loc_inverty.TabIndex = 11;
            this.cb_mouse_loc_inverty.Text = "Invert Y";
            this.cb_mouse_loc_inverty.UseVisualStyleBackColor = true;
            // 
            // cb_mouse_loc_invertx
            // 
            this.cb_mouse_loc_invertx.AutoSize = true;
            this.cb_mouse_loc_invertx.Location = new System.Drawing.Point(7, 73);
            this.cb_mouse_loc_invertx.Name = "cb_mouse_loc_invertx";
            this.cb_mouse_loc_invertx.Size = new System.Drawing.Size(63, 17);
            this.cb_mouse_loc_invertx.TabIndex = 10;
            this.cb_mouse_loc_invertx.Text = "Invert X";
            this.cb_mouse_loc_invertx.UseVisualStyleBackColor = true;
            // 
            // cb_mouse_loc_scany
            // 
            this.cb_mouse_loc_scany.AutoSize = true;
            this.cb_mouse_loc_scany.Location = new System.Drawing.Point(7, 54);
            this.cb_mouse_loc_scany.Name = "cb_mouse_loc_scany";
            this.cb_mouse_loc_scany.Size = new System.Drawing.Size(61, 17);
            this.cb_mouse_loc_scany.TabIndex = 9;
            this.cb_mouse_loc_scany.Text = "Scan Y";
            this.cb_mouse_loc_scany.UseVisualStyleBackColor = true;
            // 
            // cb_mouse_loc_scanx
            // 
            this.cb_mouse_loc_scanx.AutoSize = true;
            this.cb_mouse_loc_scanx.Location = new System.Drawing.Point(7, 34);
            this.cb_mouse_loc_scanx.Name = "cb_mouse_loc_scanx";
            this.cb_mouse_loc_scanx.Size = new System.Drawing.Size(61, 17);
            this.cb_mouse_loc_scanx.TabIndex = 8;
            this.cb_mouse_loc_scanx.Text = "Scan X";
            this.cb_mouse_loc_scanx.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Random Pulse";
            // 
            // nud_mouse_loc_randompulse
            // 
            this.nud_mouse_loc_randompulse.Location = new System.Drawing.Point(5, 133);
            this.nud_mouse_loc_randompulse.Name = "nud_mouse_loc_randompulse";
            this.nud_mouse_loc_randompulse.Size = new System.Drawing.Size(89, 20);
            this.nud_mouse_loc_randompulse.TabIndex = 1;
            // 
            // cb_mouse_loc_random
            // 
            this.cb_mouse_loc_random.AutoSize = true;
            this.cb_mouse_loc_random.Location = new System.Drawing.Point(7, 16);
            this.cb_mouse_loc_random.Name = "cb_mouse_loc_random";
            this.cb_mouse_loc_random.Size = new System.Drawing.Size(87, 17);
            this.cb_mouse_loc_random.TabIndex = 0;
            this.cb_mouse_loc_random.Text = "Random Loc";
            this.cb_mouse_loc_random.UseVisualStyleBackColor = true;
            // 
            // g_mouse_speed
            // 
            this.g_mouse_speed.Controls.Add(this.cb_mouse_speed_random);
            this.g_mouse_speed.Controls.Add(this.label6);
            this.g_mouse_speed.Controls.Add(this.label5);
            this.g_mouse_speed.Controls.Add(this.nud_mouse_speed_maxval);
            this.g_mouse_speed.Controls.Add(this.nud_mouse_speed_minval);
            this.g_mouse_speed.Controls.Add(this.cb_mouse_speed_grade);
            this.g_mouse_speed.Controls.Add(this.nud_mouse_speed_Speed);
            this.g_mouse_speed.Location = new System.Drawing.Point(8, 19);
            this.g_mouse_speed.Name = "g_mouse_speed";
            this.g_mouse_speed.Size = new System.Drawing.Size(82, 157);
            this.g_mouse_speed.TabIndex = 0;
            this.g_mouse_speed.TabStop = false;
            this.g_mouse_speed.Text = "Speed";
            // 
            // cb_mouse_speed_random
            // 
            this.cb_mouse_speed_random.AutoSize = true;
            this.cb_mouse_speed_random.Location = new System.Drawing.Point(6, 57);
            this.cb_mouse_speed_random.Name = "cb_mouse_speed_random";
            this.cb_mouse_speed_random.Size = new System.Drawing.Size(66, 17);
            this.cb_mouse_speed_random.TabIndex = 6;
            this.cb_mouse_speed_random.Text = "Random";
            this.cb_mouse_speed_random.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Min Value";
            // 
            // nud_mouse_speed_maxval
            // 
            this.nud_mouse_speed_maxval.Location = new System.Drawing.Point(6, 133);
            this.nud_mouse_speed_maxval.Name = "nud_mouse_speed_maxval";
            this.nud_mouse_speed_maxval.Size = new System.Drawing.Size(65, 20);
            this.nud_mouse_speed_maxval.TabIndex = 3;
            // 
            // nud_mouse_speed_minval
            // 
            this.nud_mouse_speed_minval.Location = new System.Drawing.Point(6, 92);
            this.nud_mouse_speed_minval.Name = "nud_mouse_speed_minval";
            this.nud_mouse_speed_minval.Size = new System.Drawing.Size(65, 20);
            this.nud_mouse_speed_minval.TabIndex = 2;
            // 
            // cb_mouse_speed_grade
            // 
            this.cb_mouse_speed_grade.AutoSize = true;
            this.cb_mouse_speed_grade.Location = new System.Drawing.Point(6, 38);
            this.cb_mouse_speed_grade.Name = "cb_mouse_speed_grade";
            this.cb_mouse_speed_grade.Size = new System.Drawing.Size(66, 17);
            this.cb_mouse_speed_grade.TabIndex = 1;
            this.cb_mouse_speed_grade.Text = "Gradient";
            this.cb_mouse_speed_grade.UseVisualStyleBackColor = true;
            // 
            // nud_mouse_speed_Speed
            // 
            this.nud_mouse_speed_Speed.Location = new System.Drawing.Point(6, 14);
            this.nud_mouse_speed_Speed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_mouse_speed_Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nud_mouse_speed_Speed.Name = "nud_mouse_speed_Speed";
            this.nud_mouse_speed_Speed.Size = new System.Drawing.Size(66, 20);
            this.nud_mouse_speed_Speed.TabIndex = 0;
            this.nud_mouse_speed_Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // g_CMD
            // 
            this.g_CMD.Controls.Add(this.cb_cmd_msgtosend);
            this.g_CMD.Controls.Add(this.b_remotecmd_send);
            this.g_CMD.Location = new System.Drawing.Point(818, 4);
            this.g_CMD.Name = "g_CMD";
            this.g_CMD.Size = new System.Drawing.Size(310, 47);
            this.g_CMD.TabIndex = 11;
            this.g_CMD.TabStop = false;
            this.g_CMD.Text = "Remote CMD";
            // 
            // cb_cmd_msgtosend
            // 
            this.cb_cmd_msgtosend.FormattingEnabled = true;
            this.cb_cmd_msgtosend.Items.AddRange(new object[] {
            "taskkill",
            "color a4"});
            this.cb_cmd_msgtosend.Location = new System.Drawing.Point(6, 18);
            this.cb_cmd_msgtosend.Name = "cb_cmd_msgtosend";
            this.cb_cmd_msgtosend.Size = new System.Drawing.Size(244, 21);
            this.cb_cmd_msgtosend.TabIndex = 12;
            // 
            // b_remotecmd_send
            // 
            this.b_remotecmd_send.Location = new System.Drawing.Point(256, 17);
            this.b_remotecmd_send.Name = "b_remotecmd_send";
            this.b_remotecmd_send.Size = new System.Drawing.Size(48, 23);
            this.b_remotecmd_send.TabIndex = 1;
            this.b_remotecmd_send.Text = "Send";
            this.b_remotecmd_send.UseVisualStyleBackColor = true;
            // 
            // g_status
            // 
            this.g_status.Location = new System.Drawing.Point(520, 328);
            this.g_status.Name = "g_status";
            this.g_status.Size = new System.Drawing.Size(288, 193);
            this.g_status.TabIndex = 14;
            this.g_status.TabStop = false;
            this.g_status.Text = "Endgame";
            // 
            // l_status_version
            // 
            this.l_status_version.AutoSize = true;
            this.l_status_version.ForeColor = System.Drawing.Color.Red;
            this.l_status_version.Location = new System.Drawing.Point(9, 172);
            this.l_status_version.Name = "l_status_version";
            this.l_status_version.Size = new System.Drawing.Size(97, 13);
            this.l_status_version.TabIndex = 1;
            this.l_status_version.Text = "Client Version: N/A";
            // 
            // g_status_console
            // 
            this.g_status_console.Controls.Add(this.lb_console);
            this.g_status_console.Location = new System.Drawing.Point(7, 19);
            this.g_status_console.Name = "g_status_console";
            this.g_status_console.Size = new System.Drawing.Size(303, 150);
            this.g_status_console.TabIndex = 2;
            this.g_status_console.TabStop = false;
            this.g_status_console.Text = "Console";
            // 
            // lb_console
            // 
            this.lb_console.FormattingEnabled = true;
            this.lb_console.Location = new System.Drawing.Point(5, 19);
            this.lb_console.Name = "lb_console";
            this.lb_console.Size = new System.Drawing.Size(298, 121);
            this.lb_console.TabIndex = 0;
            // 
            // l_status_online
            // 
            this.l_status_online.AutoSize = true;
            this.l_status_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_status_online.ForeColor = System.Drawing.Color.Red;
            this.l_status_online.Location = new System.Drawing.Point(60, 413);
            this.l_status_online.Name = "l_status_online";
            this.l_status_online.Size = new System.Drawing.Size(199, 37);
            this.l_status_online.TabIndex = 3;
            this.l_status_online.Text = "Client Offline";
            // 
            // l_status_pintime
            // 
            this.l_status_pintime.AutoSize = true;
            this.l_status_pintime.ForeColor = System.Drawing.Color.Red;
            this.l_status_pintime.Location = new System.Drawing.Point(9, 232);
            this.l_status_pintime.Name = "l_status_pintime";
            this.l_status_pintime.Size = new System.Drawing.Size(54, 13);
            this.l_status_pintime.TabIndex = 4;
            this.l_status_pintime.Text = "Ping: N/A";
            // 
            // l_status_ip
            // 
            this.l_status_ip.AutoSize = true;
            this.l_status_ip.ForeColor = System.Drawing.Color.Red;
            this.l_status_ip.Location = new System.Drawing.Point(9, 194);
            this.l_status_ip.Name = "l_status_ip";
            this.l_status_ip.Size = new System.Drawing.Size(43, 13);
            this.l_status_ip.TabIndex = 5;
            this.l_status_ip.Text = "IP: N/A";
            // 
            // l_status_pc_name
            // 
            this.l_status_pc_name.AutoSize = true;
            this.l_status_pc_name.ForeColor = System.Drawing.Color.Red;
            this.l_status_pc_name.Location = new System.Drawing.Point(8, 206);
            this.l_status_pc_name.Name = "l_status_pc_name";
            this.l_status_pc_name.Size = new System.Drawing.Size(107, 13);
            this.l_status_pc_name.TabIndex = 6;
            this.l_status_pc_name.Text = "PC Client Name: N/A";
            // 
            // l_status_c_os
            // 
            this.l_status_c_os.AutoSize = true;
            this.l_status_c_os.ForeColor = System.Drawing.Color.Red;
            this.l_status_c_os.Location = new System.Drawing.Point(9, 219);
            this.l_status_c_os.Name = "l_status_c_os";
            this.l_status_c_os.Size = new System.Drawing.Size(77, 13);
            this.l_status_c_os.TabIndex = 7;
            this.l_status_c_os.Text = "Client OS: N/A";
            // 
            // l_status_c_error
            // 
            this.l_status_c_error.AutoSize = true;
            this.l_status_c_error.ForeColor = System.Drawing.Color.Red;
            this.l_status_c_error.Location = new System.Drawing.Point(8, 245);
            this.l_status_c_error.Name = "l_status_c_error";
            this.l_status_c_error.Size = new System.Drawing.Size(55, 13);
            this.l_status_c_error.TabIndex = 8;
            this.l_status_c_error.Text = "Error: N/A";
            // 
            // l_status_c_p_s
            // 
            this.l_status_c_p_s.AutoSize = true;
            this.l_status_c_p_s.ForeColor = System.Drawing.Color.Red;
            this.l_status_c_p_s.Location = new System.Drawing.Point(9, 366);
            this.l_status_c_p_s.Name = "l_status_c_p_s";
            this.l_status_c_p_s.Size = new System.Drawing.Size(103, 13);
            this.l_status_c_p_s.TabIndex = 9;
            this.l_status_c_p_s.Text = "Client Packets Sent:";
            // 
            // g_clientstatus
            // 
            this.g_clientstatus.Controls.Add(this.l_status_p_total);
            this.g_clientstatus.Controls.Add(this.l_status_c_p_r);
            this.g_clientstatus.Controls.Add(this.l_status_p_r);
            this.g_clientstatus.Controls.Add(this.l_status_p_s);
            this.g_clientstatus.Controls.Add(this.l_status_c_p_s);
            this.g_clientstatus.Controls.Add(this.l_status_c_error);
            this.g_clientstatus.Controls.Add(this.l_status_c_os);
            this.g_clientstatus.Controls.Add(this.l_status_pc_name);
            this.g_clientstatus.Controls.Add(this.l_status_ip);
            this.g_clientstatus.Controls.Add(this.l_status_pintime);
            this.g_clientstatus.Controls.Add(this.l_status_online);
            this.g_clientstatus.Controls.Add(this.g_status_console);
            this.g_clientstatus.Controls.Add(this.l_status_version);
            this.g_clientstatus.Location = new System.Drawing.Point(818, 57);
            this.g_clientstatus.Name = "g_clientstatus";
            this.g_clientstatus.Size = new System.Drawing.Size(316, 458);
            this.g_clientstatus.TabIndex = 9;
            this.g_clientstatus.TabStop = false;
            this.g_clientstatus.Text = "Client Stats";
            // 
            // l_status_p_total
            // 
            this.l_status_p_total.AutoSize = true;
            this.l_status_p_total.ForeColor = System.Drawing.Color.Red;
            this.l_status_p_total.Location = new System.Drawing.Point(9, 299);
            this.l_status_p_total.Name = "l_status_p_total";
            this.l_status_p_total.Size = new System.Drawing.Size(134, 13);
            this.l_status_p_total.TabIndex = 13;
            this.l_status_p_total.Text = "Total Packets Transmitted:";
            // 
            // l_status_c_p_r
            // 
            this.l_status_c_p_r.AutoSize = true;
            this.l_status_c_p_r.ForeColor = System.Drawing.Color.Red;
            this.l_status_c_p_r.Location = new System.Drawing.Point(9, 353);
            this.l_status_c_p_r.Name = "l_status_c_p_r";
            this.l_status_c_p_r.Size = new System.Drawing.Size(127, 13);
            this.l_status_c_p_r.TabIndex = 12;
            this.l_status_c_p_r.Text = "Client Packets Revieved:";
            // 
            // l_status_p_r
            // 
            this.l_status_p_r.AutoSize = true;
            this.l_status_p_r.ForeColor = System.Drawing.Color.Red;
            this.l_status_p_r.Location = new System.Drawing.Point(9, 334);
            this.l_status_p_r.Name = "l_status_p_r";
            this.l_status_p_r.Size = new System.Drawing.Size(98, 13);
            this.l_status_p_r.TabIndex = 11;
            this.l_status_p_r.Text = "Packets Recieved:";
            // 
            // l_status_p_s
            // 
            this.l_status_p_s.AutoSize = true;
            this.l_status_p_s.ForeColor = System.Drawing.Color.Red;
            this.l_status_p_s.Location = new System.Drawing.Point(9, 321);
            this.l_status_p_s.Name = "l_status_p_s";
            this.l_status_p_s.Size = new System.Drawing.Size(74, 13);
            this.l_status_p_s.TabIndex = 10;
            this.l_status_p_s.Text = "Packets Sent:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(124, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 166);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 166);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Shut Down";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sleep";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Hibernate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Shut Down";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Restart";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Reconnect";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 106);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 132);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "Uninstall";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Lime;
            this.button11.Location = new System.Drawing.Point(6, 15);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 26);
            this.button11.TabIndex = 4;
            this.button11.Text = "Slow";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // Form_EvilController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.g_status);
            this.Controls.Add(this.g_CMD);
            this.Controls.Add(this.g_mouse);
            this.Controls.Add(this.g_clientstatus);
            this.Controls.Add(this.g_key);
            this.Controls.Add(this.g_dialog);
            this.Controls.Add(this.g_connect);
            this.Name = "Form_EvilController";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form_EvilController_Load);
            this.g_connect.ResumeLayout(false);
            this.g_connect.PerformLayout();
            this.g_dialog.ResumeLayout(false);
            this.g_dialog.PerformLayout();
            this.g_buttontype.ResumeLayout(false);
            this.g_spam.ResumeLayout(false);
            this.g_spam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_spam_tospam)).EndInit();
            this.g_key.ResumeLayout(false);
            this.g_key.PerformLayout();
            this.g_mouse.ResumeLayout(false);
            this.g_mouse_location.ResumeLayout(false);
            this.g_mouse_location.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_loc_randompulse)).EndInit();
            this.g_mouse_speed.ResumeLayout(false);
            this.g_mouse_speed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_maxval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_minval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mouse_speed_Speed)).EndInit();
            this.g_CMD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.g_status_console.ResumeLayout(false);
            this.g_clientstatus.ResumeLayout(false);
            this.g_clientstatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Button b_disconnect;
        private System.Windows.Forms.GroupBox g_connect;
        private System.Windows.Forms.GroupBox g_dialog;
        private System.Windows.Forms.GroupBox g_buttontype;
        private System.Windows.Forms.Button bt_msg_info;
        private System.Windows.Forms.Button b_msg_warning;
        private System.Windows.Forms.Button b_msg_error;
        private System.Windows.Forms.GroupBox g_spam;
        private System.Windows.Forms.Label l_numberofboxes;
        private System.Windows.Forms.CheckBox cb_msg_infinite;
        private System.Windows.Forms.NumericUpDown nud_spam_tospam;
        private System.Windows.Forms.TextBox tb_msg_toshow;
        private System.Windows.Forms.Button b_msg_show;
        private System.Windows.Forms.GroupBox g_key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox g_mouse;
        private System.Windows.Forms.GroupBox g_mouse_speed;
        private System.Windows.Forms.NumericUpDown nud_mouse_speed_maxval;
        private System.Windows.Forms.NumericUpDown nud_mouse_speed_minval;
        private System.Windows.Forms.CheckBox cb_mouse_speed_grade;
        private System.Windows.Forms.NumericUpDown nud_mouse_speed_Speed;
        private System.Windows.Forms.CheckBox cb_mouse_speed_random;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox g_mouse_location;
        private System.Windows.Forms.CheckBox cb_mouse_loc_inverty;
        private System.Windows.Forms.CheckBox cb_mouse_loc_invertx;
        private System.Windows.Forms.CheckBox cb_mouse_loc_scany;
        private System.Windows.Forms.CheckBox cb_mouse_loc_scanx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_mouse_loc_randompulse;
        private System.Windows.Forms.CheckBox cb_mouse_loc_random;
        private System.Windows.Forms.Button b_mouse_apply;
        private System.Windows.Forms.Button b_mouse_rmb;
        private System.Windows.Forms.Button b_mouse_lmb;
        private System.Windows.Forms.GroupBox g_CMD;
        private System.Windows.Forms.Button b_remotecmd_send;
        private System.Windows.Forms.ComboBox cb_cmd_msgtosend;
        private System.Windows.Forms.GroupBox g_status;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label l_status_version;
        private System.Windows.Forms.GroupBox g_status_console;
        private System.Windows.Forms.ListBox lb_console;
        private System.Windows.Forms.Label l_status_online;
        private System.Windows.Forms.Label l_status_pintime;
        private System.Windows.Forms.Label l_status_ip;
        private System.Windows.Forms.Label l_status_pc_name;
        private System.Windows.Forms.Label l_status_c_os;
        private System.Windows.Forms.Label l_status_c_error;
        private System.Windows.Forms.Label l_status_c_p_s;
        private System.Windows.Forms.GroupBox g_clientstatus;
        private System.Windows.Forms.Label l_status_c_p_r;
        private System.Windows.Forms.Label l_status_p_r;
        private System.Windows.Forms.Label l_status_p_s;
        private System.Windows.Forms.Label l_status_p_total;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

