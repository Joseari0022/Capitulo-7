using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();
        private void addBtn_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(califBox.Text));
            listBox.Items.Add(califBox.Text);
            foreach (int n in list)
            {
                maxBox.Text = list.Max().ToString();
                minBox.Text = list.Min().ToString();
                promBox.Text = list.Average().ToString();
            }
        }
    }
}
