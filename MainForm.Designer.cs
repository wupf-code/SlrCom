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
            this.slr_com_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slr_baud_list = new System.Windows.Forms.ComboBox();
            this.slr_stop_list = new System.Windows.Forms.ComboBox();
            this.slr_data_list = new System.Windows.Forms.ComboBox();
            this.slr_parity_list = new System.Windows.Forms.ComboBox();
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
            this.ts_menu_screenshot_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_notepad_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.label_recv_count = new System.Windows.Forms.Label();
            this.label_send_count = new System.Windows.Forms.Label();
            this.cbox_rts = new System.Windows.Forms.CheckBox();
            this.cbox_dtr = new System.Windows.Forms.CheckBox();
            this.activateTc2_f1 = new System.Windows.Forms.Button();
            this.chose_project = new System.Windows.Forms.ComboBox();
            this.activateTc2_f2 = new System.Windows.Forms.Button();
            this.activate1_f1 = new System.Windows.Forms.Button();
            this.activate1_f6 = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.menu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_recv
            // 
            this.tb_recv.BackColor = System.Drawing.Color.Black;
            this.tb_recv.ForeColor = System.Drawing.Color.Lime;
            this.tb_recv.Location = new System.Drawing.Point(3, 28);
            this.tb_recv.Multiline = true;
            this.tb_recv.Name = "tb_recv";
            this.tb_recv.ReadOnly = true;
            this.tb_recv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_recv.Size = new System.Drawing.Size(499, 288);
            this.tb_recv.TabIndex = 0;
            // 
            // tb_send
            // 
            this.tb_send.AllowDrop = true;
            this.tb_send.Location = new System.Drawing.Point(3, 347);
            this.tb_send.Multiline = true;
            this.tb_send.Name = "tb_send";
            this.tb_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_send.Size = new System.Drawing.Size(499, 100);
            this.tb_send.TabIndex = 1;
            // 
            // slr_com_list
            // 
            this.slr_com_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slr_com_list.FormattingEnabled = true;
            this.slr_com_list.Location = new System.Drawing.Point(510, 29);
            this.slr_com_list.Name = "slr_com_list";
            this.slr_com_list.Size = new System.Drawing.Size(196, 20);
            this.slr_com_list.TabIndex = 2;
            this.slr_com_list.SelectedIndexChanged += new System.EventHandler(this.Cb_com_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口选择";
            // 
            // slr_baud_list
            // 
            this.slr_baud_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slr_baud_list.FormattingEnabled = true;
            this.slr_baud_list.Location = new System.Drawing.Point(584, 69);
            this.slr_baud_list.Name = "slr_baud_list";
            this.slr_baud_list.Size = new System.Drawing.Size(121, 20);
            this.slr_baud_list.TabIndex = 4;
            this.slr_baud_list.SelectedIndexChanged += new System.EventHandler(this.Cb_baud_list_SelectedIndexChanged);
            // 
            // slr_stop_list
            // 
            this.slr_stop_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slr_stop_list.FormattingEnabled = true;
            this.slr_stop_list.Location = new System.Drawing.Point(584, 107);
            this.slr_stop_list.Name = "slr_stop_list";
            this.slr_stop_list.Size = new System.Drawing.Size(121, 20);
            this.slr_stop_list.TabIndex = 5;
            this.slr_stop_list.SelectedIndexChanged += new System.EventHandler(this.Cb_stop_list_SelectedIndexChanged);
            // 
            // slr_data_list
            // 
            this.slr_data_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slr_data_list.FormattingEnabled = true;
            this.slr_data_list.Location = new System.Drawing.Point(584, 146);
            this.slr_data_list.Name = "slr_data_list";
            this.slr_data_list.Size = new System.Drawing.Size(121, 20);
            this.slr_data_list.TabIndex = 6;
            this.slr_data_list.SelectedIndexChanged += new System.EventHandler(this.Cb_data_list_SelectedIndexChanged);
            // 
            // slr_parity_list
            // 
            this.slr_parity_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slr_parity_list.FormattingEnabled = true;
            this.slr_parity_list.Location = new System.Drawing.Point(584, 184);
            this.slr_parity_list.Name = "slr_parity_list";
            this.slr_parity_list.Size = new System.Drawing.Size(121, 20);
            this.slr_parity_list.TabIndex = 7;
            this.slr_parity_list.SelectedIndexChanged += new System.EventHandler(this.Cb_parity_list_SelectedIndexChanged);
            // 
            // btn_open_com
            // 
            this.btn_open_com.Location = new System.Drawing.Point(584, 220);
            this.btn_open_com.Name = "btn_open_com";
            this.btn_open_com.Size = new System.Drawing.Size(121, 23);
            this.btn_open_com.TabIndex = 8;
            this.btn_open_com.Text = "打开串口";
            this.btn_open_com.UseVisualStyleBackColor = true;
            this.btn_open_com.Click += new System.EventHandler(this.Btn_open_com_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "奇偶校验";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "串口操作";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(510, 393);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 24);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // btn_clean_send
            // 
            this.btn_clean_send.Location = new System.Drawing.Point(510, 423);
            this.btn_clean_send.Name = "btn_clean_send";
            this.btn_clean_send.Size = new System.Drawing.Size(75, 24);
            this.btn_clean_send.TabIndex = 15;
            this.btn_clean_send.Text = "清除发送";
            this.btn_clean_send.UseVisualStyleBackColor = true;
            this.btn_clean_send.Click += new System.EventHandler(this.Btn_clean_send_Click);
            // 
            // btn_clean_recv
            // 
            this.btn_clean_recv.Location = new System.Drawing.Point(584, 255);
            this.btn_clean_recv.Name = "btn_clean_recv";
            this.btn_clean_recv.Size = new System.Drawing.Size(121, 23);
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
            this.cbox_hex_display.Location = new System.Drawing.Point(584, 300);
            this.cbox_hex_display.Name = "cbox_hex_display";
            this.cbox_hex_display.Size = new System.Drawing.Size(84, 16);
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
            this.cbox_send_hex.Location = new System.Drawing.Point(3, 454);
            this.cbox_send_hex.Name = "cbox_send_hex";
            this.cbox_send_hex.Size = new System.Drawing.Size(84, 16);
            this.cbox_send_hex.TabIndex = 18;
            this.cbox_send_hex.Text = "16进制发送";
            this.cbox_send_hex.UseVisualStyleBackColor = true;
            this.cbox_send_hex.CheckedChanged += new System.EventHandler(this.cbox_send_hex_CheckedChanged);
            // 
            // cbox_send_line
            // 
            this.cbox_send_line.AutoSize = true;
            this.cbox_send_line.Location = new System.Drawing.Point(93, 454);
            this.cbox_send_line.Name = "cbox_send_line";
            this.cbox_send_line.Size = new System.Drawing.Size(72, 16);
            this.cbox_send_line.TabIndex = 19;
            this.cbox_send_line.Text = "发送新行";
            this.cbox_send_line.UseVisualStyleBackColor = true;
            // 
            // cbox_timer_send
            // 
            this.cbox_timer_send.AutoSize = true;
            this.cbox_timer_send.Location = new System.Drawing.Point(171, 454);
            this.cbox_timer_send.Name = "cbox_timer_send";
            this.cbox_timer_send.Size = new System.Drawing.Size(72, 16);
            this.cbox_timer_send.TabIndex = 21;
            this.cbox_timer_send.Text = "定时发送";
            this.cbox_timer_send.UseVisualStyleBackColor = true;
            this.cbox_timer_send.CheckedChanged += new System.EventHandler(this.Cbox_timer_send_CheckedChanged);
            // 
            // tb_period_send_time_ms
            // 
            this.tb_period_send_time_ms.Location = new System.Drawing.Point(249, 452);
            this.tb_period_send_time_ms.Name = "tb_period_send_time_ms";
            this.tb_period_send_time_ms.Size = new System.Drawing.Size(50, 21);
            this.tb_period_send_time_ms.TabIndex = 22;
            this.tb_period_send_time_ms.Text = "200";
            this.tb_period_send_time_ms.TextChanged += new System.EventHandler(this.tb_period_send_time_ms_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "ms";
            // 
            // menu_top
            // 
            this.menu_top.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_file,
            this.ts_menu_screenshot_tool,
            this.ts_menu_notepad_tool});
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu_top.Size = new System.Drawing.Size(718, 24);
            this.menu_top.TabIndex = 24;
            // 
            // ts_menu_file
            // 
            this.ts_menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_open_file,
            this.ts_menu_save_as});
            this.ts_menu_file.Name = "ts_menu_file";
            this.ts_menu_file.Size = new System.Drawing.Size(44, 22);
            this.ts_menu_file.Text = "文件";
            // 
            // ts_menu_open_file
            // 
            this.ts_menu_open_file.Name = "ts_menu_open_file";
            this.ts_menu_open_file.Size = new System.Drawing.Size(112, 22);
            this.ts_menu_open_file.Text = "打开";
            this.ts_menu_open_file.Click += new System.EventHandler(this.Ts_menu_open_file_Click);
            // 
            // ts_menu_save_as
            // 
            this.ts_menu_save_as.Name = "ts_menu_save_as";
            this.ts_menu_save_as.Size = new System.Drawing.Size(112, 22);
            this.ts_menu_save_as.Text = "另存为";
            this.ts_menu_save_as.Click += new System.EventHandler(this.Ts_menu_save_as_Click);
            // 
            // ts_menu_screenshot_tool
            // 
            this.ts_menu_screenshot_tool.Name = "ts_menu_screenshot_tool";
            this.ts_menu_screenshot_tool.Size = new System.Drawing.Size(44, 22);
            this.ts_menu_screenshot_tool.Text = "介绍";
            this.ts_menu_screenshot_tool.Click += new System.EventHandler(this.ts_menu_screenshot_tool_Click);
            // 
            // ts_menu_notepad_tool
            // 
            this.ts_menu_notepad_tool.Name = "ts_menu_notepad_tool";
            this.ts_menu_notepad_tool.Size = new System.Drawing.Size(12, 22);
            // 
            // label_recv_count
            // 
            this.label_recv_count.AutoSize = true;
            this.label_recv_count.Location = new System.Drawing.Point(357, 458);
            this.label_recv_count.Name = "label_recv_count";
            this.label_recv_count.Size = new System.Drawing.Size(23, 12);
            this.label_recv_count.TabIndex = 25;
            this.label_recv_count.Text = "R:0";
            // 
            // label_send_count
            // 
            this.label_send_count.AutoSize = true;
            this.label_send_count.Location = new System.Drawing.Point(426, 458);
            this.label_send_count.Name = "label_send_count";
            this.label_send_count.Size = new System.Drawing.Size(23, 12);
            this.label_send_count.TabIndex = 26;
            this.label_send_count.Text = "S:0";
            // 
            // cbox_rts
            // 
            this.cbox_rts.AutoSize = true;
            this.cbox_rts.Location = new System.Drawing.Point(510, 262);
            this.cbox_rts.Name = "cbox_rts";
            this.cbox_rts.Size = new System.Drawing.Size(42, 16);
            this.cbox_rts.TabIndex = 27;
            this.cbox_rts.Text = "RTS";
            this.cbox_rts.UseVisualStyleBackColor = true;
            this.cbox_rts.CheckedChanged += new System.EventHandler(this.Cbox_rts_CheckedChanged);
            // 
            // cbox_dtr
            // 
            this.cbox_dtr.AutoSize = true;
            this.cbox_dtr.Location = new System.Drawing.Point(510, 300);
            this.cbox_dtr.Name = "cbox_dtr";
            this.cbox_dtr.Size = new System.Drawing.Size(42, 16);
            this.cbox_dtr.TabIndex = 28;
            this.cbox_dtr.Text = "DTR";
            this.cbox_dtr.UseVisualStyleBackColor = true;
            this.cbox_dtr.CheckedChanged += new System.EventHandler(this.Cbox_dtr_CheckedChanged);
            // 
            // activateTc2_f1
            // 
            this.activateTc2_f1.Location = new System.Drawing.Point(592, 320);
            this.activateTc2_f1.Name = "activateTc2_f1";
            this.activateTc2_f1.Size = new System.Drawing.Size(103, 24);
            this.activateTc2_f1.TabIndex = 29;
            this.activateTc2_f1.Text = "6车激活1车向前";
            this.activateTc2_f1.UseVisualStyleBackColor = true;
            this.activateTc2_f1.Click += new System.EventHandler(this.activateTc2_f1_Click);
            // 
            // chose_project
            // 
            this.chose_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chose_project.FormattingEnabled = true;
            this.chose_project.Location = new System.Drawing.Point(510, 322);
            this.chose_project.Name = "chose_project";
            this.chose_project.Size = new System.Drawing.Size(77, 20);
            this.chose_project.TabIndex = 30;
            // 
            // activateTc2_f2
            // 
            this.activateTc2_f2.Location = new System.Drawing.Point(592, 349);
            this.activateTc2_f2.Name = "activateTc2_f2";
            this.activateTc2_f2.Size = new System.Drawing.Size(103, 24);
            this.activateTc2_f2.TabIndex = 31;
            this.activateTc2_f2.Text = "6车激活6车向前";
            this.activateTc2_f2.UseVisualStyleBackColor = true;
            this.activateTc2_f2.Click += new System.EventHandler(this.activateTc2_f2_Click);
            // 
            // activate1_f1
            // 
            this.activate1_f1.Location = new System.Drawing.Point(592, 379);
            this.activate1_f1.Name = "activate1_f1";
            this.activate1_f1.Size = new System.Drawing.Size(103, 24);
            this.activate1_f1.TabIndex = 32;
            this.activate1_f1.Text = "1车激活1车向前";
            this.activate1_f1.UseVisualStyleBackColor = true;
            this.activate1_f1.Click += new System.EventHandler(this.activate1_f1_Click);
            // 
            // activate1_f6
            // 
            this.activate1_f6.Location = new System.Drawing.Point(592, 409);
            this.activate1_f6.Name = "activate1_f6";
            this.activate1_f6.Size = new System.Drawing.Size(103, 24);
            this.activate1_f6.TabIndex = 33;
            this.activate1_f6.Text = "1车激活6车向前";
            this.activate1_f6.UseVisualStyleBackColor = true;
            this.activate1_f6.Click += new System.EventHandler(this.activate1_f6_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(610, 471);
            this.version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(83, 12);
            this.version.TabIndex = 34;
            this.version.Text = "version: V1.1";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 501);
            this.Controls.Add(this.version);
            this.Controls.Add(this.activate1_f6);
            this.Controls.Add(this.activate1_f1);
            this.Controls.Add(this.activateTc2_f2);
            this.Controls.Add(this.chose_project);
            this.Controls.Add(this.activateTc2_f1);
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
            this.Controls.Add(this.slr_parity_list);
            this.Controls.Add(this.slr_data_list);
            this.Controls.Add(this.slr_stop_list);
            this.Controls.Add(this.slr_baud_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slr_com_list);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.tb_recv);
            this.Controls.Add(this.menu_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_top;
            this.Name = "MainForm";
            this.Text = "SlrCom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menu_top.ResumeLayout(false);
            this.menu_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.ComboBox slr_com_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox slr_baud_list;
        private System.Windows.Forms.ComboBox slr_stop_list;
        private System.Windows.Forms.ComboBox slr_data_list;
        private System.Windows.Forms.ComboBox slr_parity_list;
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
        private System.Windows.Forms.ToolStripMenuItem ts_menu_screenshot_tool;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_notepad_tool;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_file;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_save_as;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_open_file;
        private System.Windows.Forms.Label label_recv_count;
        private System.Windows.Forms.Label label_send_count;
        private System.Windows.Forms.CheckBox cbox_rts;
        private System.Windows.Forms.CheckBox cbox_dtr;
        private System.Windows.Forms.Button activateTc2_f1;
        private System.Windows.Forms.ComboBox chose_project;
        private System.Windows.Forms.Button activateTc2_f2;
        private System.Windows.Forms.Button activate1_f1;
        private System.Windows.Forms.Button activate1_f6;
        private System.Windows.Forms.Label version;
    }
}

