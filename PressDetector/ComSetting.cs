using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;

namespace PressDetector
{
    public partial class ComSetting : Form
    {
        public dbdriver m_dbh { get; set; } = null;
        private bool m_bNeedInsert = false;
        private Int32 m_rowid = 0;
        public ComSetting()
        {
            InitializeComponent();
        }
        public void LoadData(dbdriver dbh)
        {
            this.m_dbh = dbh;
            this.m_comName.Items.Clear();
            String[] names = SerialPort.GetPortNames();
            foreach (String i in names)
            {
                this.m_comName.Items.Add(i);
            }
            ArrayList result = m_dbh.Query("select rowid,com,bund,stop,parity,databit from setting limit 0,1");
            if (result.Count > 0)
            {
                Hashtable row = (Hashtable)result[0];
                string name = Convert.ToString(row["com"]);
                for (int i = 0; i < this.m_comName.Items.Count; i++)
                {
                    if (this.m_comName.Items[i].ToString() == name)
                    {
                        this.m_comName.SelectedIndex = i;
                        break;
                    }
                }
                this.m_bundRate.SelectedIndex = Convert.ToInt32(row["bund"]);
                this.m_wndCheckMethod.SelectedIndex = Convert.ToInt32(row["parity"]);
                this.m_stopBit.Text = Convert.ToString(row["stop"]);
                this.m_dataBit.Text = Convert.ToString(row["databit"]);
                this.m_rowid = Convert.ToInt32(row["rowid"]);
            }
            else
            {
                this.m_bNeedInsert = true;
                if (this.m_comName.Items.Count > 0)
                {
                    this.m_comName.SelectedIndex = 0;
                }
                this.m_bundRate.SelectedIndex = 3;
                this.m_wndCheckMethod.SelectedIndex = 0;
            }
        }
        private void m_btnOK_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                string comName = this.GetComName();
                if (m_bNeedInsert)
                {
                    sql = "insert into setting(com,bund,stop,parity,databit) values(" +
                        comName + "," +
                        this.m_bundRate.SelectedIndex.ToString() + "," +
                        this.m_stopBit.Text + "," +
                        this.m_wndCheckMethod.SelectedIndex.ToString() + "," +
                        this.m_dataBit.Text + ")";

                }
                else
                {
                    sql = "update setting set com = '" +
                        comName + "', bund = " +
                        this.m_bundRate.SelectedIndex.ToString() + ",stop= " +
                        this.m_stopBit.Text + ",parity=" +
                        this.m_wndCheckMethod.SelectedIndex.ToString() + ",databit=" +
                        this.m_dataBit.Text +
                        " where rowid = " + this.m_rowid.ToString();
                }
                this.m_dbh.begin();
                int count = this.m_dbh.update(sql);
                this.m_dbh.end();
                if (count == 0)
                {
                    MessageBox.Show("保存配置失败了，请检查data.db是否在当前目录下");
                } else
                {
                    m_bNeedInsert = false;
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.Close();
        }

        private void ComSetting_Load(object sender, EventArgs e)
        {
            
        }

        public int GetBund()
        {
            return Convert.ToInt32(this.m_bundRate.Items[this.m_bundRate.SelectedIndex].ToString());
        }

        public Parity GetParity()
        {
            string name = this.m_wndCheckMethod.Items[this.m_wndCheckMethod.SelectedIndex].ToString();
            if(name == "Even")
            {
                return Parity.Even;
            } else if(name == "Odd")
            {
                return Parity.Odd;
            } else if(name == "Space")
            {
                return Parity.Space;
            } else if(name == "Mark")
            {
                return Parity.Mark;
            }
            else
            {
                return Parity.None;
            }
        }

        public int GetStopBit()
        {
            return Convert.ToInt32(m_stopBit.Text);
        }
        public int GetDataBit()
        {
            return Convert.ToInt32(this.m_dataBit.Text);
        }
        public string GetComName()
        {
            return this.m_comName.Items[this.m_comName.SelectedIndex].ToString();
        }
    }
}
