namespace UDPSend
{
    partial class UDPSendFrm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDPSendFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBx_cmd = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(104, 144);
            this.textBox_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(116, 23);
            this.textBox_Value.TabIndex = 7;
            this.textBox_Value.Text = "黄文磊_123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "取值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "命令：";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(104, 80);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(116, 23);
            this.textBox_Port.TabIndex = 9;
            this.textBox_Port.Text = "1123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口：";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(104, 49);
            this.textBox_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(116, 23);
            this.textBox_IP.TabIndex = 10;
            this.textBox_IP.Text = "198.168.1.198";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "地址：";
            // 
            // cBx_cmd
            // 
            this.cBx_cmd.FormattingEnabled = true;
            this.cBx_cmd.Items.AddRange(new object[] {
            "CUSER",
            "SWUE",
            "SWI",
            "SWN",
            "SWB",
            "SWQ",
            "SWT",
            "SWC",
            "SWF",
            "SWP",
            "CALL"});
            this.cBx_cmd.Location = new System.Drawing.Point(104, 112);
            this.cBx_cmd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBx_cmd.Name = "cBx_cmd";
            this.cBx_cmd.Size = new System.Drawing.Size(116, 25);
            this.cBx_cmd.TabIndex = 12;
            this.cBx_cmd.Text = "CUSER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cBx_cmd);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Value);
            this.groupBox1.Controls.Add(this.textBox_Port);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 233);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // UDPSendFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 254);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UDPSendFrm";
            this.Text = "UDPSend";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBx_cmd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

