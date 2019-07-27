using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace highandlow
{
    public partial class Form1 : Form
    {
        long kazu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kazu++;
            label1.Text = kazu.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kazu--;
            button2.Text = "こんにちは";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "?";
            label2.Text = "5より大きいか小さいか";
            kazu = 2;

        }
    }
}
