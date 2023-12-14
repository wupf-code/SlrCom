using ApeFree.CodePlus.Algorithm.CRC;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueSerial.Utils
{
    static class Utils
    {
        //支持的波特率、停止位，数据位，奇偶校验位
        public static int[] baudRateList = { 1382400,460800,230400,115200,38400,19200,9600};
        public static StopBits[] stopBitList = { StopBits.One, StopBits.None, StopBits.OnePointFive,StopBits.Two };
        public static int[] dataBitList = { 8,7,6,5};
        public static Parity[] parityList = { Parity.None,Parity.Odd,Parity.Even,Parity.Mark,Parity.Space};
        public static string logFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
        private static string logFilePath = Path.Combine(logFolderPath, $"error_{DateTime.Now:yyyyMMdd}.log");

        //将日志写入文件中
        public static void LogError(string errorMessage)
        {
            try
            {
                // 使用 StreamWriter 追加模式打开或创建日志文件
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    // 记录当前日期和时间，以及错误信息
                    sw.WriteLine($"{DateTime.Now} : {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // 处理日志记录失败的异常
                Console.WriteLine($"Error logging exception: {ex.Message}");
            }
        }

        public static string convertBytesToHexString(byte[] bytesArray, int type)
        {

            StringBuilder sb = new StringBuilder();
            string hexString = BitConverter.ToString(bytesArray).Replace("-", " ");
            if(!check(bytesArray, type))
            {
                LogError(hexString);
            }
            return hexString;
        }

        private static bool check(byte[] bytesArray, int type)  //type 为0 代表苏11, 1为苏6
        {
            byte[] inData = new byte[bytesArray.Length - 4];
            if (type == 0 && bytesArray.Length != 21)
            {
                return false;
            }
            Array.Copy(bytesArray, 1, inData, 0, inData.Length);
            var crc = new Crc(CrcModel.CRC16_CCITT);
            byte[] result = crc.Calculate(inData);
            if (result[0] == bytesArray[bytesArray.Length -2] && result[1] == bytesArray[bytesArray.Length - 1]) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string convertToHexString(string str)
        {
            string hexString = "";
            char[] strChars = str.ToCharArray();
            foreach (char c in strChars)
            {
                hexString += Convert.ToByte(c).ToString("X2") + " ";
            }
            if (hexString.EndsWith(" "))
            {
                hexString = hexString.Substring(0, hexString.LastIndexOf(" "));
            }
            return hexString;
        }

        public static string convertHexStringToCommonString(string hexString)
        {
            if (hexString.Length == 0)
            {
                return "";
            }
            string commonString = "";

            if (hexString.EndsWith(" "))
            {
                hexString = hexString.Substring(0, hexString.LastIndexOf(" "));
            }
            //过滤掉非hex形式的字符
            for (int i=0;i<hexString.ToCharArray().Length;i++)
            {
                char s = hexString[i];
                if ((s >= '0' && s <= '9')|| (s >= 'A' && s <= 'F'))
                {
                    hexString = hexString.Substring(i);
                    break;
                }
            }
            String[] hexBytes = hexString.Split(' ');
            foreach (string hex in hexBytes)
            {
                int value = Convert.ToInt32(hex, 16);
                commonString += Convert.ToChar(value);
            }
            return commonString;
        }

        public static byte[] convertHexStringToBytes(string hexString)
        {
            try {
                String[] hexBytes = hexString.Split(' ');
                byte[] bytes = new byte[hexBytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    int value = Convert.ToInt32(hexBytes[i], 16);
                    bytes[i] = Convert.ToByte(value);
                }
                return bytes;
            }
            catch (Exception)
            {
                MessageBox.Show("16进制的格式不对，请重试");
                return null;
            }
        }


    }
}
