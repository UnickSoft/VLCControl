using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace VLCControl
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 port = 4444;
            TcpClient client = new TcpClient("127.0.0.1", port);
            NetworkStream stream = client.GetStream();
            textBox1.AppendText("Sent help command\r\n");
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("help\n");
            stream.Write(data, 0, data.Length);

            data = new Byte[2560];
            String responseData = String.Empty;            
            Int32 bytes = 0;
            while (client.Available > 0)
            {                
                bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                textBox1.AppendText(responseData);
            }
            stream.Close();
            client.Close();
        }
    }
}
