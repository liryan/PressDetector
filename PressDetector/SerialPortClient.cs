using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;

namespace PressDetector
{

    public class SerialPortClient
    {
        public static volatile bool m_isRuning = false;
        private static Stack<string> stackData = new Stack<string>();
        private static Object ObjectLocker = new Object();
        // com口配置
        private string setComName = "COM1";
        private int setBundRate = 9600;
        private int setDataBit = 8;
        private int setStopBit = 1;
        private Parity setChk = Parity.None;
        private Thread m_hReadThread;
        // 串口实例
        private static SerialPort m_port;
        public SerialPortClient()
        {
        }

        public string PopMessage()
        {
            lock(ObjectLocker)
            {
                if(stackData.Count > 0)
                {
                    return stackData.Pop();
                }
                else
                {
                    return null;
                }
            }
        }

        public void PushMessage(String msg)
        {
            lock (ObjectLocker)
            {
                stackData.Push(msg);
            }
        }
        public void Setting(string portName, int boudRate = 9600, int dataBit = 8, int stopBit = 1, Parity chk = Parity.None)
        {
            this.setComName = portName;
            this.setBundRate = boudRate;
            this.setDataBit = dataBit;
            this.setStopBit = stopBit;
            this.setChk = chk;
        }
        private void OpenPort()
        {
            m_port = new SerialPort();
            m_port.PortName = this.setComName;
            m_port.BaudRate = this.setBundRate;
            m_port.DataBits = this.setDataBit;
            m_port.StopBits = (StopBits)this.setStopBit;
            m_port.Parity = this.setChk;
            m_port.ReadTimeout = 500;
            m_port.WriteTimeout = 500;
            m_port.Open();
        }


        public void play()
        {

        }

        /**
         * 启动读取线程
         */
        public void run()
        {
            this.OpenPort();
            m_hReadThread = new Thread(new ParameterizedThreadStart(readData));
            m_hReadThread.Start(this);
        }
        public void stop()
        {
            m_isRuning = false;
            m_hReadThread.Join();
        }
        private static void readData(object obj)
        {
            SerialPortClient self = (SerialPortClient)obj;
            m_isRuning = true;
            Console.WriteLine("Com thread has start..");
            while(m_isRuning)
            {
                try
                {
                    string message = m_port.ReadLine();
                    message = message.Replace("\n", string.Empty);
                    message = message.Replace("\r", string.Empty);
                    if(message.Length > 0)
                    {
                        self.PushMessage(message);
                        Console.WriteLine("has recve message:" + message);
                    }
                }
                catch (TimeoutException) { }
            }
            m_port.Close();
        }
    }
}
