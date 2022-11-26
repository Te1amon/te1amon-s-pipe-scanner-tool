using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Te1amon_s_Pipe_Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public FileSystemWatcher watcher = new FileSystemWatcher();

        public string[] listOfPipes;

        public int PipeCount = 0;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                // select somethign idot
            }
            else
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Te1amon's Pipe Scanner/Tool - " + PipeCount + " pipes found";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfPipes = Directory.GetFiles("\\\\.\\pipe\\");
            this.listBox1.Items.Clear();
            this.listBox1.Refresh();
            string[] array = this.listOfPipes;
            for (int i = 0; i < array.Length; i++)
            {
                string item = array[i];
                this.listBox1.Items.Add(item);
            }
            PipeCount = this.listBox1.Items.Count;
        }

        private void executeCodeUsingNamedPipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 lol = new Form2();
            lol.Show();
        }
    }
}
