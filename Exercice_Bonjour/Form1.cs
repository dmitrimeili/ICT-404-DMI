/*
 * Name : Meili Dmitri
 * project : Bonjour Qui
 * Date : 16.08.2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Bonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdBienvenu.Enabled = false;
            
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            /* dès que le page ce lance le bouton doit etre désactiver*/
            if (txtNom.TextLength >= 0)
            {
                cmdBienvenu.Enabled = true;
            }
           /* cmdQuitter.Image = Image.FromFile("bouton-quitter-png.png");*/
            

        }

        private void CmdBienvenu_Click(object sender, EventArgs e)
        {
            /*Au moment ou l'on clique sur le bouton, le lblbienvenu ecrit Bonjour+le nom inscrit et efface ce qu il s y trouve et désactive le bouton*/
            LblBienvenu.Text = "Bonjour " + txtNom.Text;
            txtNom.Text = "";
            cmdBienvenu.Enabled = false;
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
