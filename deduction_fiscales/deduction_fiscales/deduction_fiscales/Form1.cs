using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deduction_fiscales
{
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Déduction_Load(object sender, EventArgs e)
        
        {
            boxdeducjeune.Text = "900";
            boxdeductransport.Text = "650";
            boxrabais.Text = "0";
            resultat.Text = " ";

        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultat_Click(object sender, EventArgs e)
        {
            
        }

        private void bouton_calcul_Click(object sender, EventArgs e)
        {
            float Jean;
            resultat.Text = "Revenu imposable: fr. calcul";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
