using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MyToolBox
{
    public partial class NetworkForm : Form
    {
        public NetworkForm()
        {
            InitializeComponent();
            this.button1_Click(null, null);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            string hostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = ipEntry.AddressList;
            this.textBox1.AppendText(hostName + Environment.NewLine + Environment.NewLine);
            foreach(var ip in addr)
            {
                this.textBox1.AppendText(ip.ToString() + Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
