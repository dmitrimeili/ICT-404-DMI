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
        public Fenetre()
        {
            InitializeComponent();
        }

        private void Fenêtre_Load(object sender, EventArgs e)
            
        {
           
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
            Rectangle scr = Screen.GetBounds(this.Bounds);
            MessageBox.Show(scr.X.ToString());
            MessageBox.Show(scr.Y.ToString());
            MessageBox.Show(scr.Width.ToString());
            MessageBox.Show(scr.Height.ToString());

        }
    }
}
