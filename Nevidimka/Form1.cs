using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nevidimka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Text = "Невидим";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label1.Text = "Видим";
        }
    }
}
