namespace BlueSerial
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_recv = new System.Windows.Forms.TextBox();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.cb_com_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_baud_list = new System.Windows.Forms.ComboBox();
            this.cb_stop_list = new System.Windows.Forms.ComboBox();
            this.cb_data_list = new System.Windows.Forms.ComboBox();
            this.cb_parity_list = new System.Windows.Forms.ComboBox();
            this.btn_open_com = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clean_send = new System.Windows.Forms.Button();
            this.btn_clean_recv = new System.Windows.Forms.Button();
            this.cbox_hex_display = new System.Windows.Forms.CheckBox();
            this.cbox_send_hex = new System.Windows.Forms.CheckBox();
            this.cbox_send_line = new System.Windows.Forms.CheckBox();
            this.cbox_timer_send = new System.Windows.Forms.CheckBox();
            this.tb_period_send_time_ms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menu_top = new System.Windows.Forms.MenuStrip();
            this.ts_menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_open_file = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_calc = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_nodepad = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_cmd = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_regedit = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_screenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_mspaint = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_screenshot_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_notepad_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.label_recv_count = new System.Windows.Forms.Label();
            this.label_send_count = new System.Windows.Forms.Label();
            this.cbox_rts = new System.Windows.Forms.CheckBox();
            this.cbox_dtr = new System.Windows.Forms.CheckBox();
            this.activateTc1 = new System.Windows.Forms.Button();
            this.chose_project = new System.Windows.Forms.ComboBox();
            this.menu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_recv
            // 
            this.tb_recv.BackColor = System.Drawing.Color.Black;
            this.tb_recv.ForeColor = System.Drawing.Color.Lime;
            this.tb_recv.Location = new System.Drawing.Point(4, 42);
            this.tb_recv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_recv.Multiline = true;
            this.tb_recv.Name = "tb_recv";
            this.tb_recv.ReadOnly = true;
            this.tb_recv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_recv.Size = new System.Drawing.Size(746, 430);
            this.tb_recv.TabIndex = 0;
            // 
            // tb_send
            // 
            this.tb_send.AllowDrop = true;
            this.tb_send.Location = new System.Drawing.Point(4, 520);
            this.tb_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_send.Multiline = true;
            this.tb_send.Name = "tb_send";
            this.tb_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_send.Size = new System.Drawing.Size(746, 148);
            this.tb_send.TabIndex = 1;
            // 
            // cb_com_list
            // 
            this.cb_com_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_com_list.FormattingEnabled = true;
            this.cb_com_list.Location = new System.Drawing.Point(765, 44);
            this.cb_com_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_com_list.Name = "cb_com_list";
            this.cb_com_list.Size = new System.Drawing.Size(292, 26);
            this.cb_com_list.TabIndex = 2;
            this.cb_com_list.SelectedIndexChanged += new System.EventHandler(this.Cb_com_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口选择";
            // 
            // cb_baud_list
            // 
            this.cb_baud_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baud_list.FormattingEnabled = true;
            this.cb_baud_list.Location = new System.Drawing.Point(876, 104);
            this.cb_baud_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_baud_list.Name = "cb_baud_list";
            this.cb_baud_list.Size = new System.Drawing.Size(180, 26);
            this.cb_baud_list.TabIndex = 4;
            this.cb_baud_list.SelectedIndexChanged += new System.EventHandler(this.Cb_baud_list_SelectedIndexChanged);
            // 
            // cb_stop_list
            // 
            this.cb_stop_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stop_list.FormattingEnabled = true;
            this.cb_stop_list.Location = new System.Drawing.Point(876, 160);
            this.cb_stop_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_stop_list.Name = "cb_stop_list";
            this.cb_stop_list.Size = new System.Drawing.Size(180, 26);
            this.cb_stop_list.TabIndex = 5;
            this.cb_stop_list.SelectedIndexChanged += new System.EventHandler(this.Cb_stop_list_SelectedIndexChanged);
            // 
            // cb_data_list
            // 
            this.cb_data_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_data_list.FormattingEnabled = true;
            this.cb_data_list.Location = new System.Drawing.Point(876, 219);
            this.cb_data_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_data_list.Name = "cb_data_list";
            this.cb_data_list.Size = new System.Drawing.Size(180, 26);
            this.cb_data_list.TabIndex = 6;
            this.cb_data_list.SelectedIndexChanged += new System.EventHandler(this.Cb_data_list_SelectedIndexChanged);
            // 
            // cb_parity_list
            // 
            this.cb_parity_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parity_list.FormattingEnabled = true;
            this.cb_parity_list.Location = new System.Drawing.Point(876, 276);
            this.cb_parity_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_parity_list.Name = "cb_parity_list";
            this.cb_parity_list.Size = new System.Drawing.Size(180, 26);
            this.cb_parity_list.TabIndex = 7;
            this.cb_parity_list.SelectedIndexChanged += new System.EventHandler(this.Cb_parity_list_SelectedIndexChanged);
            // 
            // btn_open_com
            // 
            this.btn_open_com.Location = new System.Drawing.Point(876, 330);
            this.btn_open_com.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_open_com.Name = "btn_open_com";
            this.btn_open_com.Size = new System.Drawing.Size(182, 34);
            this.btn_open_com.TabIndex = 8;
            this.btn_open_com.Text = "打开串口";
            this.btn_open_com.UseVisualStyleBackColor = true;
            this.btn_open_com.Click += new System.EventHandler(this.Btn_open_com_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "奇偶校验";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "串口操作";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(765, 590);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(112, 36);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // btn_clean_send
            // 
            this.btn_clean_send.Location = new System.Drawing.Point(765, 634);
            this.btn_clean_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clean_send.Name = "btn_clean_send";
            this.btn_clean_send.Size = new System.Drawing.Size(112, 36);
            this.btn_clean_send.TabIndex = 15;
            this.btn_clean_send.Text = "清除发送";
            this.btn_clean_send.UseVisualStyleBackColor = true;
            this.btn_clean_send.Click += new System.EventHandler(this.Btn_clean_send_Click);
            // 
            // btn_clean_recv
            // 
            this.btn_clean_recv.Location = new System.Drawing.Point(876, 382);
            this.btn_clean_recv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clean_recv.Name = "btn_clean_recv";
            this.btn_clean_recv.Size = new System.Drawing.Size(182, 34);
            this.btn_clean_recv.TabIndex = 16;
            this.btn_clean_recv.Text = "清除接收";
            this.btn_clean_recv.UseVisualStyleBackColor = true;
            this.btn_clean_recv.Click += new System.EventHandler(this.Btn_clean_recv_Click);
            // 
            // cbox_hex_display
            // 
            this.cbox_hex_display.AutoSize = true;
            this.cbox_hex_display.Checked = true;
            this.cbox_hex_display.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_hex_display.Location = new System.Drawing.Point(876, 450);
            this.cbox_hex_display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_hex_display.Name = "cbox_hex_display";
            this.cbox_hex_display.Size = new System.Drawing.Size(124, 22);
            this.cbox_hex_display.TabIndex = 17;
            this.cbox_hex_display.Text = "16进制显示";
            this.cbox_hex_display.UseVisualStyleBackColor = true;
            this.cbox_hex_display.CheckedChanged += new System.EventHandler(this.Cbox_hex_display_CheckedChanged);
            // 
            // cbox_send_hex
            // 
            this.cbox_send_hex.AutoSize = true;
            this.cbox_send_hex.Checked = true;
            this.cbox_send_hex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_send_hex.Location = new System.Drawing.Point(4, 681);
            this.cbox_send_hex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_send_hex.Name = "cbox_send_hex";
            this.cbox_send_hex.Size = new System.Drawing.Size(124, 22);
            this.cbox_send_hex.TabIndex = 18;
            this.cbox_send_hex.Text = "16进制发送";
            this.cbox_send_hex.UseVisualStyleBackColor = true;
            this.cbox_send_hex.CheckedChanged += new System.EventHandler(this.cbox_send_hex_CheckedChanged);
            // 
            // cbox_send_line
            // 
            this.cbox_send_line.AutoSize = true;
            this.cbox_send_line.Location = new System.Drawing.Point(140, 681);
            this.cbox_send_line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_send_line.Name = "cbox_send_line";
            this.cbox_send_line.Size = new System.Drawing.Size(106, 22);
            this.cbox_send_line.TabIndex = 19;
            this.cbox_send_line.Text = "发送新行";
            this.cbox_send_line.UseVisualStyleBackColor = true;
            // 
            // cbox_timer_send
            // 
            this.cbox_timer_send.AutoSize = true;
            this.cbox_timer_send.Location = new System.Drawing.Point(256, 681);
            this.cbox_timer_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_timer_send.Name = "cbox_timer_send";
            this.cbox_timer_send.Size = new System.Drawing.Size(106, 22);
            this.cbox_timer_send.TabIndex = 21;
            this.cbox_timer_send.Text = "定时发送";
            this.cbox_timer_send.UseVisualStyleBackColor = true;
            this.cbox_timer_send.CheckedChanged += new System.EventHandler(this.Cbox_timer_send_CheckedChanged);
            // 
            // tb_period_send_time_ms
            // 
            this.tb_period_send_time_ms.Location = new System.Drawing.Point(374, 678);
            this.tb_period_send_time_ms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_period_send_time_ms.Name = "tb_period_send_time_ms";
            this.tb_period_send_time_ms.Size = new System.Drawing.Size(73, 28);
            this.tb_period_send_time_ms.TabIndex = 22;
            this.tb_period_send_time_ms.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 686);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "ms";
            // 
            // menu_top
            // 
            this.menu_top.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_top.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_file,
            this.ts_menu_tool,
            this.ts_menu_screenshot_tool,
            this.ts_menu_notepad_tool});
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menu_top.Size = new System.Drawing.Size(1077, 36);
            this.menu_top.TabIndex = 24;
            // 
            // ts_menu_file
            // 
            this.ts_menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_open_file,
            this.ts_menu_save_as});
            this.ts_menu_file.Name = "ts_menu_file";
            this.ts_menu_file.Size = new System.Drawing.Size(62, 32);
            this.ts_menu_file.Text = "文件";
            // 
            // ts_menu_open_file
            // 
            this.ts_menu_open_file.Name = "ts_menu_open_file";
            this.ts_menu_open_file.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_open_file.Text = "打开";
            this.ts_menu_open_file.Click += new System.EventHandler(this.Ts_menu_open_file_Click);
            // 
            // ts_menu_save_as
            // 
            this.ts_menu_save_as.Name = "ts_menu_save_as";
            this.ts_menu_save_as.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_save_as.Text = "另存为";
            this.ts_menu_save_as.Click += new System.EventHandler(this.Ts_menu_save_as_Click);
            // 
            // ts_menu_tool
            // 
            this.ts_menu_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_calc,
            this.ts_menu_nodepad,
            this.ts_menu_cmd,
            this.ts_menu_regedit,
            this.ts_menu_screenshot,
            this.ts_menu_mspaint});
            this.ts_menu_tool.Name = "ts_menu_tool";
            this.ts_menu_tool.Size = new System.Drawing.Size(62, 32);
            this.ts_menu_tool.Text = "工具";
            // 
            // ts_menu_calc
            // 
            this.ts_menu_calc.Name = "ts_menu_calc";
            this.ts_menu_calc.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_calc.Text = "计算器";
            this.ts_menu_calc.Click += new System.EventHandler(this.Ts_menu_calc_Click);
            // 
            // ts_menu_nodepad
            // 
            this.ts_menu_nodepad.Name = "ts_menu_nodepad";
            this.ts_menu_nodepad.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_nodepad.Text = "记事本";
            this.ts_menu_nodepad.Click += new System.EventHandler(this.Ts_menu_nodepad_Click);
            // 
            // ts_menu_cmd
            // 
            this.ts_menu_cmd.Name = "ts_menu_cmd";
            this.ts_menu_cmd.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_cmd.Text = "命令行";
            this.ts_menu_cmd.Click += new System.EventHandler(this.Ts_menu_cmd_Click);
            // 
            // ts_menu_regedit
            // 
            this.ts_menu_regedit.Name = "ts_menu_regedit";
            this.ts_menu_regedit.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_regedit.Text = "注册表";
            this.ts_menu_regedit.Click += new System.EventHandler(this.Ts_menu_regedit_Click);
            // 
            // ts_menu_screenshot
            // 
            this.ts_menu_screenshot.Name = "ts_menu_screenshot";
            this.ts_menu_screenshot.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_screenshot.Text = "截图";
            this.ts_menu_screenshot.Click += new System.EventHandler(this.Ts_menu_screenshot_Click);
            // 
            // ts_menu_mspaint
            // 
            this.ts_menu_mspaint.Name = "ts_menu_mspaint";
            this.ts_menu_mspaint.Size = new System.Drawing.Size(164, 34);
            this.ts_menu_mspaint.Text = "画图";
            this.ts_menu_mspaint.Click += new System.EventHandler(this.Ts_menu_mspaint_Click);
            // 
            // ts_menu_screenshot_tool
            // 
            this.ts_menu_screenshot_tool.Name = "ts_menu_screenshot_tool";
            this.ts_menu_screenshot_tool.Size = new System.Drawing.Size(62, 32);
            this.ts_menu_screenshot_tool.Text = "截图";
            this.ts_menu_screenshot_tool.Click += new System.EventHandler(this.Ts_menu_screenshot_tool_Click);
            // 
            // ts_menu_notepad_tool
            // 
            this.ts_menu_notepad_tool.Name = "ts_menu_notepad_tool";
            this.ts_menu_notepad_tool.Size = new System.Drawing.Size(80, 32);
            this.ts_menu_notepad_tool.Text = "记事本";
            this.ts_menu_notepad_tool.Click += new System.EventHandler(this.Ts_menu_notepad_tool_Click);
            // 
            // label_recv_count
            // 
            this.label_recv_count.AutoSize = true;
            this.label_recv_count.Location = new System.Drawing.Point(536, 687);
            this.label_recv_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_recv_count.Name = "label_recv_count";
            this.label_recv_count.Size = new System.Drawing.Size(35, 18);
            this.label_recv_count.TabIndex = 25;
            this.label_recv_count.Text = "R:0";
            // 
            // label_send_count
            // 
            this.label_send_count.AutoSize = true;
            this.label_send_count.Location = new System.Drawing.Point(639, 687);
            this.label_send_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_send_count.Name = "label_send_count";
            this.label_send_count.Size = new System.Drawing.Size(35, 18);
            this.label_send_count.TabIndex = 26;
            this.label_send_count.Text = "S:0";
            // 
            // cbox_rts
            // 
            this.cbox_rts.AutoSize = true;
            this.cbox_rts.Location = new System.Drawing.Point(765, 393);
            this.cbox_rts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_rts.Name = "cbox_rts";
            this.cbox_rts.Size = new System.Drawing.Size(61, 22);
            this.cbox_rts.TabIndex = 27;
            this.cbox_rts.Text = "RTS";
            this.cbox_rts.UseVisualStyleBackColor = true;
            this.cbox_rts.CheckedChanged += new System.EventHandler(this.Cbox_rts_CheckedChanged);
            // 
            // cbox_dtr
            // 
            this.cbox_dtr.AutoSize = true;
            this.cbox_dtr.Location = new System.Drawing.Point(765, 450);
            this.cbox_dtr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_dtr.Name = "cbox_dtr";
            this.cbox_dtr.Size = new System.Drawing.Size(61, 22);
            this.cbox_dtr.TabIndex = 28;
            this.cbox_dtr.Text = "DTR";
            this.cbox_dtr.UseVisualStyleBackColor = true;
            this.cbox_dtr.CheckedChanged += new System.EventHandler(this.Cbox_dtr_CheckedChanged);
            // 
            // activateTc1
            // 
            this.activateTc1.Location = new System.Drawing.Point(888, 480);
            this.activateTc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activateTc1.Name = "activateTc1";
            this.activateTc1.Size = new System.Drawing.Size(112, 36);
            this.activateTc1.TabIndex = 29;
            this.activateTc1.Text = "1车激活";
            this.activateTc1.UseVisualStyleBackColor = true;
            // 
            // chose_project
            // 
            this.chose_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chose_project.FormattingEnabled = true;
            this.chose_project.Location = new System.Drawing.Point(764, 486);
            this.chose_project.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chose_project.Name = "chose_project";
            this.chose_project.Size = new System.Drawing.Size(114, 26);
            this.chose_project.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 736);
            this.Controls.Add(this.chose_project);
            this.Controls.Add(this.activateTc1);
            this.Controls.Add(this.cbox_dtr);
            this.Controls.Add(this.cbox_rts);
            this.Controls.Add(this.label_send_count);
            this.Controls.Add(this.label_recv_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_period_send_time_ms);
            this.Controls.Add(this.cbox_timer_send);
            this.Controls.Add(this.cbox_send_line);
            this.Controls.Add(this.cbox_send_hex);
            this.Controls.Add(this.cbox_hex_display);
            this.Controls.Add(this.btn_clean_recv);
            this.Controls.Add(this.btn_clean_send);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_open_com);
            this.Controls.Add(this.cb_parity_list);
            this.Controls.Add(this.cb_data_list);
            this.Controls.Add(this.cb_stop_list);
            this.Controls.Add(this.cb_baud_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_com_list);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.tb_recv);
            this.Controls.Add(this.menu_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_top;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BCom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu_top.ResumeLayout(false);
            this.menu_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.ComboBox cb_com_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_baud_list;
        private System.Windows.Forms.ComboBox cb_stop_list;
        private System.Windows.Forms.ComboBox cb_data_list;
        private System.Windows.Forms.ComboBox cb_parity_list;
        private System.Windows.Forms.Button btn_open_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clean_send;
        private System.Windows.Forms.Button btn_clean_recv;
        private System.Windows.Forms.CheckBox cbox_hex_display;
        private System.Windows.Forms.TextBox tb_recv;
        private System.Windows.Forms.CheckBox cbox_send_hex;
        private System.Windows.Forms.CheckBox cbox_send_line;
        private System.Windows.Forms.CheckBox cbox_timer_send;
        private System.Windows.Forms.TextBox tb_period_send_time_ms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menu_top;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_tool;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_calc;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_nodepad;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_cmd;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_regedit;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_screenshot;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_mspaint;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_screenshot_tool;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_notepad_tool;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_file;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_save_as;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_open_file;
        private System.Windows.Forms.Label label_recv_count;
        private System.Windows.Forms.Label label_send_count;
        private System.Windows.Forms.CheckBox cbox_rts;
        private System.Windows.Forms.CheckBox cbox_dtr;
        private System.Windows.Forms.Button activateTc1;
        private System.Windows.Forms.ComboBox chose_project;
    }
}

