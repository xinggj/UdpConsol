using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace UDPSend
{
    public partial class UDPSendFrm : Form
    {
        public UDPSendFrm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Sockets.UdpClient udp = new System.Net.Sockets.UdpClient(int.Parse(textBox_Port.Text));
            string msg = cBx_cmd.SelectedItem + "_" + textBox_Value.Text;
            IPAddress addr = IPAddress.Parse(textBox_IP.Text);
            System.Net.IPEndPoint end = new System.Net.IPEndPoint(addr, int.Parse(textBox_Port.Text));
            byte[] bytes = System.Text.ASCIIEncoding.GetEncoding("gb2312").GetBytes(msg);
            int i = udp.Send(bytes, bytes.Length, end);
            udp.Close();

        }
        public static long IpToInt(string ip)
        {
            char[] separator = new char[] { '.' };
            string[] items = ip.Split(separator);
            return long.Parse(items[0]) << 24
                    | long.Parse(items[1]) << 16
                    | long.Parse(items[2]) << 8
                    | long.Parse(items[3]);
        }
    }
}
