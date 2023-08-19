using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 1;
            for (int n = int.Parse(textBox1.Text); n >= 1; n -= 1)
            {
                s *= n;

                listBox1.Items.Add(s);
            }

                    
        }
    }
}
