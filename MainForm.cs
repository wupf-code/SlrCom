
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BlueSerial.Utils.Utils;




namespace BlueSerial
{

    public partial class MainForm : Form
    {
        private ArrayList comList = new ArrayList();//串口列表
        private ArrayList scanComList = new ArrayList();//串口列表
        private static SerialPort mSerialPort;
        private Thread receiveThread=null,scanComThread=null,periodSendThread;
        private delegate void SafeCallDelegate(byte[] text);
        private int sendByteCount = 0;
        private ArrayList projectList =  new ArrayList{ "苏11", "苏6" };
        private List<byte> receivedBytes = new List<byte>();
        private long  receiveLength = 0;
        private readonly float x; //定义当前窗体的宽度
        private readonly float y; //定义当前窗体的高度

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0) setTag(con);
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    var mytag = con.Tag.ToString().Split(';');
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx); //宽度
                    con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy); //高度
                    con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx); //左边距
                    con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy); //顶边距
                    var currentSize = Convert.ToSingle(mytag[4]) * newy; //字体大小                   
                    if (currentSize > 0) con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    con.Focus();
                    if (con.Controls.Count > 0) setControls(newx, newy, con);
                }
        }


        /// <summary>
        /// 重置窗体布局
        /// </summary>
        private void ReWinformLayout()
        {
            var newx = Width / x;
            var newy = Height / y;
            setControls(newx, newy, this);

        }
        public MainForm()
        {
            InitializeComponent();

            x = Width; y = Height;
            setTag(this);

            initView();
            serialPortListInit();
            
            scanComThread = new Thread(new ThreadStart(scanComTask));
            scanComThread.Start();
            

        }


        private void initView()
        {
            slr_baud_list.DataSource = baudRateList;
            slr_data_list.DataSource = dataBitList;
            slr_parity_list.DataSource = parityList;
            slr_parity_list.SelectedIndex = 2;
            slr_stop_list.DataSource = stopBitList;
            slr_baud_list.SelectedIndex = 5;
            chose_project.DataSource = projectList;
            chose_project.SelectedIndex = 0; 
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(tvRecvDragEnterEventHandler);
            // 确保 log 文件夹存在
            if (!Directory.Exists(logFolderPath))
            {
                Directory.CreateDirectory(logFolderPath);
            }
            //LogError("123123123123");
        }

        private void tvRecvDragEnterEventHandler(object obj, DragEventArgs args)
        {
           
            try
            {
                string dataString = (string)args.Data.GetData(DataFormats.StringFormat);
                tb_send.Text = dataString;
            }
            catch
            {

            }

        }

        private void scanComTask()
        {
            while (true)
            {
                scanComList.Clear();
                foreach (string portName in SerialPort.GetPortNames())
                {
                    scanComList.Add(portName);
                }
                if (comList.Count != scanComList.Count)
                {
                    slr_com_list.DataSource = scanComList;
                }
                Thread.Sleep(2000);
            }
        }

        private void serialPortListInit()
        {
            if (comList.Count > 0)
            {
                comList.Clear();
            }
            foreach (string portName in SerialPort.GetPortNames())
            {
                comList.Add(portName);
            }

            if (comList.Count == 0)
            {
                MessageBox.Show("没有搜索到串口");
                slr_com_list.DataSource = comList;
                return;
            }
            slr_com_list.DataSource = comList;

            if (slr_com_list.SelectedIndex > comList.Count || slr_com_list.SelectedIndex < 0)
            {
                //MessageBox.Show("串口丢失");
                return;
            }
            mSerialPort = new SerialPort(comList[slr_com_list.SelectedIndex].ToString());
            if (!mSerialPort.IsOpen)
            {
                try
                {
                    btn_open_com.Text = "打开串口";
                    btn_open_com.ForeColor = Color.Black;
                }
                catch (Exception)
                {
                    MessageBox.Show("串口"+mSerialPort.PortName+"被占用，无法打开，请关闭占用串口的程序");
                }
                
            }
            

            mSerialPort.BaudRate = baudRateList[slr_baud_list.SelectedIndex];
            mSerialPort.DataBits = dataBitList[slr_data_list.SelectedIndex];
            mSerialPort.Parity = parityList[slr_parity_list.SelectedIndex];
            mSerialPort.StopBits = stopBitList[slr_stop_list.SelectedIndex];
            mSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int bytesToRead = sp.BytesToRead;
            byte[] byteArray = new byte[bytesToRead];
            sp.Read(byteArray, 0, bytesToRead);
            //string indata = sp.ReadExisting();
            receiveThread = new Thread(new ParameterizedThreadStart(displayReceiveData));
            //receiveThread.Start(indata);
            receiveThread.Start(byteArray);
        }
        private void displayReceiveData(object obj)
        {
            if (tb_recv.InvokeRequired)
            {
                var d = new SafeCallDelegate(displayReceiveData);
                Invoke(d, new object[] { obj });
                //Invoke(d, new object[] { obj[0] })
            }
            else
            {
                byte[] byteArray = (byte[])obj;
                foreach (byte b in byteArray)
                {
                    if (b == 0xf2)
                    {   
                        if(receivedBytes.Count >= 21) // 开始新消息
                        {
                            HandleCompleteMessage(receivedBytes.ToArray());
                            receivedBytes.Clear();
                        }
                       
                        receivedBytes.Add(b);
                    }
                    else if (b == 0Xf6)
                    {
                        receivedBytes.Add(b);
                        if(receivedBytes.Count >= 21)
                        {
                            // 处理完整的消息
                            byte[] completeMessage = receivedBytes.ToArray();
                            // 处理 completeMessage
                            HandleCompleteMessage(completeMessage);
                            receivedBytes.Clear();
                        }
                    }
                    else
                    {
                        // 添加字节到当前消息
                        receivedBytes.Add(b);
                    }
                }

            }

        }
        private void HandleCompleteMessage(byte[] byteArray)
        {
            if (cbox_hex_display.Checked)
            {
                string dispalyString = convertBytesToHexString(byteArray, chose_project.SelectedIndex);
                receiveLength += (dispalyString.Length) / 3;
                tb_recv.AppendText(dispalyString + "\r\n");
                label_recv_count.Text = "R:" + receiveLength;
            }
            else
            {
                string hexString = BitConverter.ToString(byteArray).Replace("-", " ");
                receiveLength += (hexString.Length) / 3;
                tb_recv.AppendText(hexString + "\r\n");
                label_recv_count.Text = "R:" + (receiveLength);

            }
        }
        


private void Btn_open_com_Click(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                if (mSerialPort.IsOpen)
                {
                    try
                    {
                        mSerialPort.Close();
                        btn_open_com.Text = "打开串口";
                        btn_open_com.ForeColor = Color.Black;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("串口关闭失败");
                    }
                }
                else
                {
                    try
                    {
                        mSerialPort.Open();
                        btn_open_com.Text = "关闭串口";
                        btn_open_com.ForeColor = Color.Red;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("串口" + mSerialPort.PortName + "被占用，无法打开，请关闭占用串口的程序");
                        btn_open_com.Text = "打开串口";
                        btn_open_com.ForeColor = Color.Black;
                    }
                }

                
            }
            else
            {
                serialPortListInit();
            }

        }

        private void Btn_clean_send_Click(object sender, EventArgs e)
        {
            tb_send.Text = "";
            label_send_count.Text = "S:0";
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void sendData()
        {
            if (mSerialPort != null && mSerialPort.IsOpen)
            {
                if ((cbox_send_line.Checked == true) && (cbox_send_hex.Checked == true))
                {
                    //发送16进制新行  
                    byte[] bytes = convertHexStringToBytes(tb_send.Text);
                    if (bytes != null)
                    {
                        mSerialPort.Write(bytes, 0, bytes.Length);
                        byte[] newLine = { 0xd, 0xa };
                        mSerialPort.Write(newLine, 0, newLine.Length);
                        sendByteCount += (bytes.Length + newLine.Length);
                    }
                }
                else if ((cbox_send_line.Checked == true) && (cbox_send_hex.Checked == false))
                {
                    //发送普通字符串新行
                    mSerialPort.Write(tb_send.Text + "\r\n");
                    sendByteCount += (tb_send.Text.Length + 2);
                }
                else if ((cbox_send_line.Checked == false) && (cbox_send_hex.Checked == false))
                {
                    //发送普通字符串
                    mSerialPort.Write(tb_send.Text);
                    sendByteCount += tb_send.Text.Length;
                }
                else if ((cbox_send_line.Checked == false) && (cbox_send_hex.Checked == true))
                {
                    //发送16进制
                    byte[] bytes = convertHexStringToBytes(tb_send.Text);
                    if (bytes != null)
                    {
                        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        // 构造带时间戳的消息
                        string messageWithTimestamp = $"{timestamp}: {tb_send.Text}\r\n";
                        tb_recv.AppendText(messageWithTimestamp);
                        mSerialPort.Write(bytes, 0, bytes.Length);
                        sendByteCount += bytes.Length;
                    }
                    
                }
                else
                {
                    MessageBox.Show("不支持的操作！");
                }
                label_send_count.Text = "S:" + sendByteCount;

            }
            else
            {
                MessageBox.Show("尚未打开串口，请打开后再发送");
            }
        }

        private void Cb_com_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (mSerialPort != null)
            {
                if (mSerialPort.IsOpen)
                {
                    mSerialPort.Close();
                }
                btn_open_com.Text = "打开串口";
                btn_open_com.ForeColor = Color.Black;
                mSerialPort = null;
                serialPortListInit();
                
            }
            


        }

        private void Cb_baud_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                mSerialPort.BaudRate = baudRateList[slr_baud_list.SelectedIndex];
            }
        }

        private void Cb_stop_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                try
                {
                    mSerialPort.StopBits = stopBitList[slr_stop_list.SelectedIndex];
                    //mSerialPort.StopBits = stopBitList[slr_stop_list.SelectedIndex];
                }
                catch (Exception)
                {

                }
            }
        }

        private void Cb_data_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                mSerialPort.DataBits = dataBitList[slr_data_list.SelectedIndex];
            }
        }

        private void Cb_parity_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                mSerialPort.Parity = parityList[slr_parity_list.SelectedIndex];
            }
        }

        private void Cbox_hex_display_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_hex_display.Checked)
            {
                tb_recv.Text = convertToHexString(tb_recv.Text);
            }
            else {
                
                tb_recv.Text = convertHexStringToCommonString(tb_recv.Text);
            }
        }

        private void Cbox_timer_send_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbox_timer_send.Checked)
            {
                try
                {
                    Convert.ToInt32(tb_period_send_time_ms.Text);
                    periodSendThread = new Thread(new ThreadStart(periodSendTask));
                    periodSendThread.Start();
                }
                catch (Exception) {
                    MessageBox.Show("周期格式不正确");
                    cbox_timer_send.Checked = false;
                    return;
                }
                 
                
            }
            else
            {
                if (periodSendThread != null)
                {
                    try
                    {
                        periodSendThread.Abort();
                    } catch (Exception)
                    {
                        MessageBox.Show("周期发送结束失败，请重试！");
                    }
                    
                }
                
            }
            
        }


        private void Ts_menu_save_as_Click(object sender, EventArgs e)
        {
            Stream mStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "e:\\";
            saveFileDialog.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog()==DialogResult.OK&& saveFileDialog.FileName.Length > 0)
            {
                if ((mStream = saveFileDialog.OpenFile())!= null)
                {
                    StreamWriter writer = new StreamWriter(mStream);
                    writer.Write(tb_recv.Text);
                    writer.Flush();
                    writer.Close();
                    mStream.Close();
                    MessageBox.Show("存储文件成功！", "温馨提示");
                }
              
                
            }
        }

        private void Ts_menu_open_file_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                reader.Close();
                fileStream.Close();
                tb_send.Text = fileContent;
            }
            
        }

        private void Cbox_rts_CheckedChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                if (cbox_rts.Checked)
                {
                    mSerialPort.RtsEnable = true;
                }
                else
                {
                    mSerialPort.RtsEnable = false;
                }
            }
        }

        private void Cbox_dtr_CheckedChanged(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                if (cbox_dtr.Checked)
                {
                    mSerialPort.DtrEnable = true;
                }
                else 
                {
                    mSerialPort.DtrEnable = false;
                }
                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
        }

        private void cbox_send_hex_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activateTc2_f1_Click(object sender, EventArgs e)
        {
            if(chose_project.SelectedIndex == 0)
            {
                tb_send.Text = "fc 00 40 17 08 15 00 00 00 00 00 00 00 10 00 00 3d 38 f6";
            } 
            else if(chose_project.SelectedIndex == 1)
            {
                tb_send.Text = "fc 00 40 17 08 15 00 00 00 01 00 00 00 00 00 00 00 00 2b eb f6";
            }
        }

        private void activateTc2_f2_Click(object sender, EventArgs e)
        {
            if (chose_project.SelectedIndex == 0)
            {
                tb_send.Text = "fc 00 44 17 08 15 00 00 00 02 00 00 00 00 00 00 e3 1d f6";
            }
            else if (chose_project.SelectedIndex == 1)
            {
                tb_send.Text = "fc 00 40 17 08 15 00 00 00 02 00 00 00 00 00 00 00 00 06 af f6";
            }
        }

        private void activate1_f1_Click(object sender, EventArgs e)
        {
            if (chose_project.SelectedIndex == 0)
            {
                tb_send.Text = "fc 00 20 17 08 15 00 00 00 01 00 00 00 00 00 00 70 4a f6";
            }
            else if (chose_project.SelectedIndex == 1)
            {
                tb_send.Text = "fc 00 20 17 08 15 00 00 00 01 00 00 00 00 00 00 00 00 e1 d7 f6";
            }
        }

        private void activate1_f6_Click(object sender, EventArgs e)
        {
            if (chose_project.SelectedIndex == 0)
            {
                tb_send.Text = "fc 00 20 17 08 15 00 00 00 02 00 00 00 00 00 00 a8 c8 f6";
            }
            else if (chose_project.SelectedIndex == 1)
            {
                tb_send.Text = "fc 00 20 17 08 15 00 00 00 02 00 00 00 00 00 00 00 00 cc 93 f6";
            }
        }

        private void tb_period_send_time_ms_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ReWinformLayout();
        }

        
        private void periodSendTask()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                sendData();
                Thread.Sleep(Convert.ToInt32(tb_period_send_time_ms.Text));
            }
            
        }

        private void Btn_clean_recv_Click(object sender, EventArgs e)
        {
            tb_recv.Text = "";
            label_recv_count.Text = "R:0";
        }
    }
}
