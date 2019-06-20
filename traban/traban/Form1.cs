using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traban
{
    public partial class Form1 : Form
    {
        double Base;
        double rajout = 2210;
        double total;
        public Form1()
        {
        
            InitializeComponent();
           
            rbdeserie.Checked = true;
            txtbase.Text = Base.ToString();
            
            Base = 12300;
            txtbase.Text = Base.ToString();
            lbltotal.Text = "Total : "+total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbdeserie_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(txtbase.Text, out Base))
            {
                lbltotal.Text = Base.ToString();
            }
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbase.Text, out Base))
            {
                MessageBox.Show("Veuillez entrez des chiffres svp");
                txtbase.Focus();
                return;
            }
            rbdeserie.Checked = true;
            txtbase.Text = Base.ToString();

            Base = 12300;
            txtbase.Text = Base.ToString();
            cbtax.Checked = false;
            lbltotal.Text = "Total : " + Base;
            

        }

        private void txtbase_Leave(object sender, EventArgs e)
        {
            if (Base < 10000)
            {
                MessageBox.Show("la somme doit être suppérieure a 10000");
                txtbase.Focus();
                return;
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb16L_CheckedChanged(object sender, EventArgs e)
        {
            if (rb16L.Checked == true)
            {
                
                
                
                Base = Base + rajout;
                lbltotal.Text = "Total : " + Base;
                
            }
            else
            {
                Base -= rajout;
                lbltotal.Text = "Total : " + Base;
            }
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtax.Checked)
            {
                Base = Base + Base*6.8/100;
               
            }
            else
            {
                Base = Base - Base * 6.8 / 100;
               
            }
            lbltotal.Text = "Total : " + Base;
        }
    }
    }

