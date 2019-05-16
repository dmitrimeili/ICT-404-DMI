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
            float revan;
            // revan = float.Parse(textBox1.Text);0.
            if (!float.TryParse(textBox1.Text, out revan))
            {
                MessageBox.Show("erreur");
                textBox1.Focus();
                return;
            }
            if (revan < 20000)
            {
                MessageBox.Show("le revenu annuelle dois être superieur a 20000 CHF ");
                textBox1.Focus();
                return;
            }
            
            float Cofam;
            if (!float.TryParse(textBox2.Text, out Cofam))
            {
                MessageBox.Show("erreur");
                textBox2.Focus();
                return;
            }
            if (Cofam > 10)
            {
                MessageBox.Show("Coefficient familial entre 1 et 10");
                textBox2.Focus();
                return;
            }

            //Cofam = float.Parse(textBox2.Text);0.
           
            float res;
            res = revan / Cofam;
            float dedujeune;
            dedujeune = float.Parse(boxdeducjeune.Text);
            float dedutrans;
            dedutrans = float.Parse(boxdeductransport.Text);
            float rabaisfid;
            rabaisfid = float.Parse(boxrabais.Text);
            if ((dedujeune+dedutrans) >= res && dedujeune < 0 && dedutrans<0)
            {
                MessageBox.Show("les deductions doivent etre positives et inferieur au resultat");
                return;
            }
                if (rabais.Checked == true)
            {
                
                res = res - (res / 100 * rabaisfid);
            }
            if (deduction_j.Checked == true)
            {
                
                res = res - dedujeune;
            }
            if (deduction_t.Checked == true)
            {
                res = res - dedutrans;
            }
            
                
            
            resultat.Text = "Revenu imposable: "+res.ToString("C3");
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
