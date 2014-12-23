namespace UdpDemo
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP：";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(122, 36);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 21);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "198.168.1.198";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port：";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(122, 91);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 21);
            this.textBox_Port.TabIndex = 1;
            this.textBox_Port.Text = "1123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Command：";
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(122, 135);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(100, 21);
            this.textBox_cmd.TabIndex = 1;
            this.textBox_cmd.Text = "CUSER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Value：";
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(122, 175);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(100, 21);
            this.textBox_Value.TabIndex = 1;
            this.textBox_Value.Text = "黄文磊_123";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1041, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Button button1;
    }
}
