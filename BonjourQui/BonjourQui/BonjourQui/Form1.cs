using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonjourQui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "bienvenue "+textBox1.Text;
            textBox1.Text = "";
            btbienvenue.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if()
            btbienvenue.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btbienvenue.Enabled = false;
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Close();
        
 
        }
    }
}
