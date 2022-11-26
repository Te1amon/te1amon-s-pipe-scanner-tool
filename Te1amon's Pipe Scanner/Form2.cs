using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Te1amon_s_Pipe_Scanner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", textBox1.Text, PipeDirection.Out))
            {
                namedPipeClientStream.Connect();
                using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
                {
                    streamWriter.Write(richTextBox1.Text);
                    streamWriter.Dispose();
                }
                namedPipeClientStream.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
