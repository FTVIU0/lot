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
            int Sdata = this.serialPort1.ReadByte();

            this.textBox1.Invoke(
                new MethodInvoker(
                    delegate
                    {
                        this.textBox1.AppendText(Sdata.ToString());


            
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
