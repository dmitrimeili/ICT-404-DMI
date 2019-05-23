using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenetre_blue_rouge
{
    public partial class Fenetre : Form
    {
        Rectangle scr;
        int X = 0;
        int Y = 0;
        public Fenetre()
        {
            InitializeComponent();
        }

        private void Fenêtre_Load(object sender, EventArgs e)
            
        {
           
            scr = Screen.GetBounds(this);
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;

        }

        private void blue_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Blue;
        }

        private void Rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void HautGauche_Click(object sender, EventArgs e)
        {      
            
            this.Location = new Point(0,0);

        }

        private void HautDroite_Click(object sender, EventArgs e)
        {
           
            
            this.Location = new Point(X,0);
        }

        private void BasGauche_Click(object sender, EventArgs e)
        {
           
            this.Location = new Point(0, Y);

        }

        private void BasDroite_Click(object sender, EventArgs e)
        {
           
           
            this.Location = new Point(X, Y);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {

        }

        private void Fenetre_Resize(object sender, EventArgs e)
        {
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;
            HautDroite.Location = new Point(this.Width -103  ,this.Height - this.Height+12);
            BasDroite.Location = new Point(this.Width - 103, this.Height-80);
            BasGauche.Location = new Point(this.Width - this.Width+12, this.Height - 80);
            blue.Location = new Point();// il faut encore replacer les case du milieu
        }
    }
}
