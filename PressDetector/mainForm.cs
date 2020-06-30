using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressDetector
{
    public partial class mainForm : Form
    {
        private SerialPortClient m_comClient;
        private dbdriver m_db;
        private ComSetting m_comSettingDlg;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            String connstr = @"Data Source=|DataDirectory|\data.db;Pooling=true;FailIfMissing=true";
            //初始化数据库
            if (false == System.IO.File.Exists(Application.StartupPath + @"\data.db"))
            {
                MessageBox.Show("缺少数据文件");
            }
            this.m_db= new dbdriver(connstr);

            //初始化html界面
            String url = Application.StartupPath + @"\assets\index.html";
            if (false == System.IO.File.Exists(url))
            {
                MessageBox.Show("缺少Assets下的界面文件");
            } else
            {
                this.m_webClient.Navigate(url);
                this.m_webClient.ObjectForScripting = this; // 可以js中可以通过 window.external. 访问 this中的方法
            }

            //初始化串口配置
            m_comSettingDlg = new ComSetting();
            m_comSettingDlg.LoadData(this.m_db);
            this.m_comClient = new SerialPortClient();
            this.m_comClient.Setting(m_comSettingDlg.GetComName(),
                    m_comSettingDlg.GetBund(),
                    m_comSettingDlg.GetDataBit(),
                    m_comSettingDlg.GetStopBit(),
                    m_comSettingDlg.GetParity()
                    );

        }

        private void m_btnConnect_Click(object sender, EventArgs e)
        {
            if(SerialPortClient.m_isRuning)
            {
                DialogResult res = MessageBox.Show("串口监控运行中，是否停止？", "警告", MessageBoxButtons.OKCancel);
                if(res == DialogResult.OK)
                {
                    m_comClient.stop();
                    this.m_sStatus.Text = "未连接";
                    this.m_sStatus.ForeColor = Color.Gray;
                    m_btnConnect.Text = "连接设备";
                    m_hTimer.Stop();
                }
            } else
            {
                string com = m_comSettingDlg.GetComName();
                this.m_sStatus.Text = "已连接[" + com + "]";
                this.m_sStatus.ForeColor = Color.Green;
                this.m_comClient.run();
                m_btnConnect.Text = "断开连接";
                m_hTimer.Start();
            }
        }

        private void m_btnSetting_Click(object sender, EventArgs e)
        {
            m_comSettingDlg.ShowDialog(this);
            this.m_comClient.Setting(m_comSettingDlg.GetComName(),
            m_comSettingDlg.GetBund(),
            m_comSettingDlg.GetDataBit(),
            m_comSettingDlg.GetStopBit(),
            m_comSettingDlg.GetParity()
            );
        }
        
        private object[] ParseParam(string msg)
        {
            string pos = msg.Substring(0, msg.Length - 1); //前面表示
            string status = msg.Substring((msg.Length - 1), 1); // 最后一位
            object[] param = new object[2];
            param[0] = Convert.ToInt32(pos);
            param[1] = status == "1" ? 100 : 0;
            return param;
        }
        public void OnApplicationIdle(object sender, EventArgs e)
        {
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(SerialPortClient.m_isRuning)
            {
                m_db.close();
                m_comClient.stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string msg = this.m_comClient.PopMessage();
            if (msg != null)
            {
                Console.WriteLine("strat process message:" + msg);
                object[] Objects = this.ParseParam(msg);
                this.m_webClient.Document.InvokeScript("showPress", Objects);
            }
        }
    }
}
