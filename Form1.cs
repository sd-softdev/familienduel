using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familien_Duell
{
    public partial class Form1 : Form
    {
        public string punktestand_team2 { get; private set; }
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Punkte = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                return;
            form2.Punkte = ((TextBox)sender).Text;
        }
    }
}
