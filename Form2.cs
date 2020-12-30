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
    public partial class Form2 : Form
    {
        string punkte;
        public string Punkte
        {
            set
            {
                punkte = value;
                label1.Text = value;
            }
            get { return punkte; }
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
