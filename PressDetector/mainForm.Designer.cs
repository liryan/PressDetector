namespace PressDetector
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.m_toolsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btnPlay = new System.Windows.Forms.Button();
            this.m_btnConnect = new System.Windows.Forms.Button();
            this.m_btnSetting = new System.Windows.Forms.Button();
            this.m_sCount = new System.Windows.Forms.Label();
            this.m_sStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_webClient = new System.Windows.Forms.WebBrowser();
            this.m_hTimer = new System.Windows.Forms.Timer(this.components);
            this.m_toolsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_toolsPanel
            // 
            this.m_toolsPanel.Controls.Add(this.panel1);
            this.m_toolsPanel.Controls.Add(this.m_sCount);
            this.m_toolsPanel.Controls.Add(this.m_sStatus);
            this.m_toolsPanel.Controls.Add(this.label1);
            this.m_toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.m_toolsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_toolsPanel.Name = "m_toolsPanel";
            this.m_toolsPanel.Size = new System.Drawing.Size(1045, 49);
            this.m_toolsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.m_btnPlay);
            this.panel1.Controls.Add(this.m_btnConnect);
            this.panel1.Controls.Add(this.m_btnSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(735, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 49);
            this.panel1.TabIndex = 5;
            // 
            // m_btnPlay
            // 
            this.m_btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.m_btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_btnPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnPlay.Location = new System.Drawing.Point(55, 8);
            this.m_btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btnPlay.Name = "m_btnPlay";
            this.m_btnPlay.Size = new System.Drawing.Size(77, 31);
            this.m_btnPlay.TabIndex = 7;
            this.m_btnPlay.Text = "播放历史";
            this.m_btnPlay.UseVisualStyleBackColor = true;
            // 
            // m_btnConnect
            // 
            this.m_btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_btnConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_btnConnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnConnect.Location = new System.Drawing.Point(139, 8);
            this.m_btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btnConnect.Name = "m_btnConnect";
            this.m_btnConnect.Size = new System.Drawing.Size(77, 31);
            this.m_btnConnect.TabIndex = 6;
            this.m_btnConnect.Text = "连接设备";
            this.m_btnConnect.UseVisualStyleBackColor = false;
            this.m_btnConnect.Click += new System.EventHandler(this.m_btnConnect_Click);
            // 
            // m_btnSetting
            // 
            this.m_btnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnSetting.Location = new System.Drawing.Point(222, 8);
            this.m_btnSetting.Name = "m_btnSetting";
            this.m_btnSetting.Size = new System.Drawing.Size(85, 31);
            this.m_btnSetting.TabIndex = 5;
            this.m_btnSetting.Text = "串口设置";
            this.m_btnSetting.UseVisualStyleBackColor = true;
            this.m_btnSetting.Click += new System.EventHandler(this.m_btnSetting_Click);
            // 
            // m_sCount
            // 
            this.m_sCount.AutoSize = true;
            this.m_sCount.Location = new System.Drawing.Point(166, 13);
            this.m_sCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_sCount.Name = "m_sCount";
            this.m_sCount.Size = new System.Drawing.Size(56, 17);
            this.m_sCount.TabIndex = 3;
            this.m_sCount.Text = "检测点数";
            // 
            // m_sStatus
            // 
            this.m_sStatus.AutoSize = true;
            this.m_sStatus.ForeColor = System.Drawing.Color.Gray;
            this.m_sStatus.Location = new System.Drawing.Point(67, 13);
            this.m_sStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_sStatus.Name = "m_sStatus";
            this.m_sStatus.Size = new System.Drawing.Size(44, 17);
            this.m_sStatus.TabIndex = 2;
            this.m_sStatus.Text = "未连接";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "链接状态";
            // 
            // m_webClient
            // 
            this.m_webClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_webClient.Location = new System.Drawing.Point(0, 49);
            this.m_webClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_webClient.MinimumSize = new System.Drawing.Size(24, 28);
            this.m_webClient.Name = "m_webClient";
            this.m_webClient.Size = new System.Drawing.Size(1045, 616);
            this.m_webClient.TabIndex = 2;
            // 
            // m_hTimer
            // 
            this.m_hTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 665);
            this.Controls.Add(this.m_webClient);
            this.Controls.Add(this.m_toolsPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "PressDetector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.m_toolsPanel.ResumeLayout(false);
            this.m_toolsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_toolsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_sCount;
        private System.Windows.Forms.Label m_sStatus;
        private System.Windows.Forms.WebBrowser m_webClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_btnConnect;
        private System.Windows.Forms.Button m_btnSetting;
        private System.Windows.Forms.Button m_btnPlay;
        private System.Windows.Forms.Timer m_hTimer;
    }
}

