namespace PressDetector
{
    partial class ComSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_bundRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_comName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_stopBit = new System.Windows.Forms.TextBox();
            this.m_dataBit = new System.Windows.Forms.TextBox();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_wndCheckMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_bundRate
            // 
            this.m_bundRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_bundRate.FormattingEnabled = true;
            this.m_bundRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "115200",
            "128000",
            "230400",
            "256000"});
            this.m_bundRate.Location = new System.Drawing.Point(263, 21);
            this.m_bundRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_bundRate.Name = "m_bundRate";
            this.m_bundRate.Size = new System.Drawing.Size(122, 25);
            this.m_bundRate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "波特率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "停止位";
            // 
            // m_comName
            // 
            this.m_comName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comName.FormattingEnabled = true;
            this.m_comName.Location = new System.Drawing.Point(63, 21);
            this.m_comName.Name = "m_comName";
            this.m_comName.Size = new System.Drawing.Size(140, 25);
            this.m_comName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "数据位";
            // 
            // m_stopBit
            // 
            this.m_stopBit.Location = new System.Drawing.Point(63, 59);
            this.m_stopBit.Name = "m_stopBit";
            this.m_stopBit.Size = new System.Drawing.Size(140, 23);
            this.m_stopBit.TabIndex = 6;
            this.m_stopBit.Text = "1";
            // 
            // m_dataBit
            // 
            this.m_dataBit.Location = new System.Drawing.Point(249, 58);
            this.m_dataBit.Name = "m_dataBit";
            this.m_dataBit.Size = new System.Drawing.Size(124, 23);
            this.m_dataBit.TabIndex = 7;
            this.m_dataBit.Text = "8";
            // 
            // m_btnOK
            // 
            this.m_btnOK.Location = new System.Drawing.Point(164, 152);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(122, 28);
            this.m_btnOK.TabIndex = 8;
            this.m_btnOK.Text = "确定";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Click);
            // 
            // m_wndCheckMethod
            // 
            this.m_wndCheckMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_wndCheckMethod.FormattingEnabled = true;
            this.m_wndCheckMethod.Items.AddRange(new object[] {
            "None",
            "Event",
            "ODD",
            "SPACE",
            "MARK"});
            this.m_wndCheckMethod.Location = new System.Drawing.Point(63, 94);
            this.m_wndCheckMethod.Name = "m_wndCheckMethod";
            this.m_wndCheckMethod.Size = new System.Drawing.Size(140, 25);
            this.m_wndCheckMethod.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "校验";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_dataBit);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ComSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_wndCheckMethod);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_stopBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_comName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_bundRate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口设置";
            this.Load += new System.EventHandler(this.ComSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_bundRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_comName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_stopBit;
        private System.Windows.Forms.TextBox m_dataBit;
        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.ComboBox m_wndCheckMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}