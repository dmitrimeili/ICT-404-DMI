using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arche_de_noe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (lbxbord.Items.Count == 0)
            {
                cmdbordter.Enabled = false;

            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void cmdbordter_Click(object sender, EventArgs e)
        {
            if (lbxterre.Items.Count <= 1)
            {
                cmdterbord.Enabled = true;
            }
            else
            {
                cmdterbord.Enabled = false;
            }
        }

        private void lbxbord_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdterbord_Click(object sender, EventArgs e)
        {
            if(lbxterre.SelectedIndex==-1)
            {
                MessageBox.Show("Veuilliez selectioner un animal");
            }
            else
            {
                lbxbord.Items.Add(lbxterre.SelectedItem);
                lbxterre.Items.RemoveAt(lbxterre.SelectedIndex);
                
            }
            if (lbxbord.Items.Count >= 1)
            {
                cmdbordter.Enabled = true;
            }
            else// terbord
            {
                cmdbordter.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
