using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_a_calculer
{
    public partial class Form1 : Form
    {
        double Base;
        double addition;
        float answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            lblFormule.Text = "+";
        }

        private void TxtNbOne_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtNbTwo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CmdAnswer_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtNbOne.Text, out Base))
            {
                MessageBox.Show("Veuillez entrez des chiffres svp");
                txtNbOne.Focus();
                return;
            }
            else if (!double.TryParse(txtNbTwo.Text, out Base))
            {
                MessageBox.Show("Veuillez entrez des chiffres svp");
                txtNbTwo.Focus();
                return;
            }
            else
            {
                float NbOne = (float)Convert.ToDouble(txtNbOne.Text);
                float NbTwo = (float)Convert.ToDouble(txtNbTwo.Text);
                
                
                
                if (lblFormule.Text == "+")
                {
                    answer = NbOne + NbTwo;
                    lblAnswer.Text = answer.ToString();
                }
                if (lblFormule.Text == "-")
                {
                    answer = NbOne - NbTwo;
                    lblAnswer.Text = answer.ToString();
                }
                if (lblFormule.Text == "X")
                {
                    answer = NbOne * NbTwo;
                    lblAnswer.Text = answer.ToString();
                }
                if (lblFormule.Text == "/")
                {
                    answer = NbOne / NbTwo;
                     
                    lblAnswer.Text = answer.ToString("F2");
                }
            }
        }

        private void CmdSub_Click(object sender, EventArgs e)
        {
            lblFormule.Text = "-";
        }

        private void CmdMult_Click(object sender, EventArgs e)
        {
            lblFormule.Text = "X";
        }

        private void CmdDiv_Click(object sender, EventArgs e)
        {
            lblFormule.Text = "/";
        }

        private void CmdCE_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
