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
        public Fenetre()
        {
            InitializeComponent();
        }

        private void Fenêtre_Load(object sender, EventArgs e)
            
        {
            Rectangle scr = Screen.GetBounds(this);

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
            this.Location = new Point(scr.Y,0 );
        }
    }
}
