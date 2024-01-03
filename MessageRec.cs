using ApeFree.CodePlus.Algorithm.CRC;
using System;
using static BlueSerial.Utils.Utils;


namespace SlrCom
{
    internal class MessageRec
    {
        public string Content { get; set; }
        public bool IsChecksumValid { get; private set; }
        public MessageRec(byte[] content, int type)
        {
            Content = convertBytesToHexString(content, type);
        }
        public string convertBytesToHexString(byte[] bytesArray, int type)
        {

            string hexString = BitConverter.ToString(bytesArray).Replace("-", " ");
            IsChecksumValid = ValidateChecksum(bytesArray, type);
            if (!IsChecksumValid)
            {
                LogError(hexString);
            }
            return hexString;
        }

        private static bool ValidateChecksum(byte[] bytesArray, int type)  //type 为0 代表苏11, 1为苏6
        {
            byte[] inData = new byte[bytesArray.Length - 4];
            if (bytesArray[0] != 0xf2 || bytesArray[bytesArray.Length - 1] != 0xf6)
            {
                return false;
            }
            if (type == 0 && bytesArray.Length != 21)
            {
                return false;
            }
            if (type == 1 && bytesArray.Length != 21)
            {
                return false;
            }
            Array.Copy(bytesArray, 1, inData, 0, inData.Length);
            var crc = new Crc(CrcModel.CRC16_CCITT_FALSE);
            byte[] result = crc.Calculate(inData);
            if (result[0] == bytesArray[bytesArray.Length - 3] && result[1] == bytesArray[bytesArray.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
