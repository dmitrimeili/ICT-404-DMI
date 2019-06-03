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
        string crevettes;
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
            string garniture = "";
            if (!int.TryParse(txttable.Text, out NBtable))
            {
                MessageBox.Show("veuillez introduire un numero de table ");
                return;
            }
            //pate
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
            //garnitures
            
            if (chkanchois.Checked == true)
            {
               
                garniture = garniture + "anchois, ";
            }
           
            if (chkcapre.Checked == true)
            {
                garniture = garniture + "câpres, ";
            }
         
            if (chkjambom.Checked == true )
            {
                garniture = garniture + "jambon, ";
            }
            if (chkcrevette.Checked == true)
            {
                garniture = garniture + "crevettes, ";
            }
            
           

            txtcommande.Text = "Pour la " + NBtable+": pâte "+pate+" avec "+garniture.Substring(0,garniture.Length-2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbextra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
