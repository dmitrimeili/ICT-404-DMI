using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commande_de_pizza
{
    public partial class Form1 : Form
    {
        int NBtable;
        string pate;
        string anchois;
        string capres;
        string jambon;
        string crevettes;// faire la commande pour les supoplément 
        public Form1()
        {
            InitializeComponent();
            txtcommande.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcommande_TextChanged(object sender, EventArgs e)
        {


           

          
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void cmdcommander_Click(object sender, EventArgs e) 
        {
            if (!int.TryParse(txttable.Text, out NBtable))
            {
                MessageBox.Show("veuillez introduire un numero de table ");
                return;
            }
            if (rbextra.Checked == true)
            {
                pate = "extra-fine";
            }
            if (rbfine.Checked == true)
            {
                pate = "fine";
            }
            if (rbnormal.Checked == true)
            {
                pate = "normale";
            }
            if (rbepaisse.Checked == true)
            {
                pate = "épaisse";
            }
            
            txtcommande.Text = "Pour la " + NBtable+": pâte "+pate+" avec";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbextra_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
