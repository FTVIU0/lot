using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lot_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //int Sdata = this.serialPort1.ReadByte();
            string text = string.Empty;
            byte[] result = new byte[serialPort1.BytesToRead];
            serialPort1.Read(result, 0, serialPort1.BytesToRead);
            text = Convert.ToString(System.Text.Encoding.ASCII.GetString(result));//将字节转换为ASCII码
            this.textBox1.Invoke(
                new MethodInvoker(
                    delegate
                    {
                        //this.textBox1.AppendText(Sdata.ToString());
                        textBox1.Text += text + " ";//将数据添加到TextBox

                    }
                    )
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }
    }
}
