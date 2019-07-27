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
        long kazu = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HIGHボタンが押されたとき
            kazu++;
            label1.Text = kazu.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LOWボタンが押されたとき
            kazu--;
            button2.Text = "こんにちは";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //起動時の初期処理
            label1.Text = "?";
            label2.Text = "5より大きいか小さいか";
            kazu = 2;

        }
    }
}
