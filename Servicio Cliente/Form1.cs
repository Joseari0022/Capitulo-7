using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> client = new Queue<string>();
        private void atenderBtn_Click(object sender, EventArgs e)
        {
            queueBox.Items.RemoveAt(0);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            client.Enqueue(clientBox.Text);

            foreach (string s in client)
            {
                queueBox.Items.Add(s);
            }
            client.Dequeue();
        }
    }
}
