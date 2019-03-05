using System;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;

namespace ScaleReader
{
    /// <summary>
    /// 指令执行响应代理。
    /// </summary>
    /// <param name="response"></param>
    public delegate void ExecuteResponseHandle(string response);

    public class Rs232
    {
        /// <summary>
        /// 指令执行响应时触发该事件。
        /// </summary>
        public event ExecuteResponseHandle ExecuteResponse;

        public SerialPort SerialPort { get; }


        /// <summary>
        /// 初始化控制台新实例，配置串口。
        /// </summary>
        /// <param name="mPort">串口名。</param>
        /// <param name="mBaudrate">波特率。</param>
        public Rs232(string mPort, int mBaudrate)
        {
            SerialPort = new SerialPort
            {
                PortName = mPort,
                BaudRate = mBaudrate,
                Encoding = Encoding.ASCII,
                RtsEnable = false,
                DtrEnable = false
            };
            SerialPort.DataReceived += sms_port_DataReceived;
            SerialPort.ErrorReceived += sms_Port_ErrorReceived;
            SerialPort.ReceivedBytesThreshold = 1;
            if (!OpenPort())
            {
                throw new Exception("串口“" + mPort + "”尚未打开，请稍后再试！");
            }
        }

        /// <summary>
        /// 初始化控制台新实例，配置串口。
        /// </summary>
        /// <param name="mPort">串口名。</param>
        /// <param name="mBaudrate">波特率。</param>
        /// <param name="mDatabits">数据位。</param>
        /// <param name="mParity">奇偶校验。</param>
        /// <param name="mStopbits">停止位。</param>
        public Rs232(string mPort, int mBaudrate, int mDatabits, Parity mParity, StopBits mStopbits)
        {
            SerialPort = new SerialPort
            {
                PortName = mPort,
                BaudRate = mBaudrate,
                DataBits = mDatabits,
                Parity = mParity,
                StopBits = mStopbits,
                Encoding = Encoding.ASCII,
                RtsEnable = false,
                DtrEnable = false,
                ReceivedBytesThreshold = 1
            };
            SerialPort.DataReceived += sms_port_DataReceived;
            SerialPort.ErrorReceived += sms_Port_ErrorReceived;

            if (!OpenPort())
            {
                throw new Exception("串口“" + mPort + "”尚未打开，请稍后再试！");
            }
        }

        /// <summary>
        /// 初始化控制台新实例，配置串口。
        /// </summary>
        /// <param name="mPort">串口名。</param>
        /// <param name="mBaudrate">波特率。</param>
        /// <param name="mDatabits">数据位。</param>
        /// <param name="mParity">奇偶校验。</param>
        /// <param name="mStopbits">停止位。</param>
        /// <param name="mEncoding">字节编码。</param>
        /// <param name="mReadtimeout">读超时。</param>
        /// <param name="mWritetimeout">写超时。</param>
        /// <param name="mReadbuffersize">输入缓冲区大小。</param>
        /// <param name="mWritebuffersize">输出缓冲区大小。</param>
        public Rs232(string mPort, int mBaudrate, int mDatabits, Parity mParity, StopBits mStopbits,
            Encoding mEncoding, int mReadtimeout, int mWritetimeout, int mReadbuffersize, int mWritebuffersize)
        {
            SerialPort = new SerialPort
            {
                PortName = mPort,
                BaudRate = mBaudrate,
                DataBits = mDatabits,
                Parity = mParity,
                StopBits = mStopbits,
                ReadTimeout = mReadtimeout,
                WriteTimeout = mWritetimeout,
                ReadBufferSize = mReadbuffersize,
                WriteBufferSize = mWritebuffersize,
                Encoding = mEncoding,
                RtsEnable = false,
                DtrEnable = false
            };
            SerialPort.DataReceived += sms_port_DataReceived;
            SerialPort.ErrorReceived += sms_Port_ErrorReceived;
            SerialPort.ReceivedBytesThreshold = 1;
            if (!OpenPort())
            {
                throw new Exception("串口“" + mPort + "”尚未打开，请稍后再试！");
            }
        }

        /// <summary>
        /// 数据接收事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sms_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var reader = SerialPort.ReadLine();

            var reg = new Regex(@"(\d+(\.\d+)?)");
            var msg = reg.Match(reader).ToString();
            ExecuteResponse?.Invoke(msg);
        }

        /// <summary>
        /// 异常接收事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sms_Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ExecuteResponse?.Invoke(Enum.GetName(typeof(SerialError), e.EventType));
        }

        /// <summary>
        /// 打开串口。
        /// </summary>
        private bool OpenPort()
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
                SerialPort.Open();
            }
            else
            {
                SerialPort.Open(); // 打开串口
            }
            return SerialPort.IsOpen;
        }

        /// <summary>
        /// 关闭串口。
        /// </summary>
        public string ClosePort()
        {
            var comname = SerialPort.PortName;
            if (SerialPort.IsOpen)
                SerialPort.Close();
            SerialPort.Dispose();
            return comname;
        }

        /// <summary>
        /// 向串口写入数据。
        /// </summary>
        /// <param name="command">指令。</param>
        public void WritePort(string command)
        {
            if (!string.IsNullOrEmpty(command))
            {
                //_smsPort.Write(new byte[] { 37, BitConverter.GetBytes(command.ToCharArray(0, 1)[0])[0] }, 0, 2);
                SerialPort.WriteLine(command);
            }
            else
            {
                ExecuteResponse?.Invoke("请输入要执行的命令！");
            }
        }
    }
}