using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ecriture_dans_fichier_texte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEcrire_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(txtNomFichier.Text);
            for (int line = 0; line < txtContenu.Lines.Count();line ++)
            {
                file.WriteLine(txtContenu.Lines[line]);
            }
            file.Close();
        }
    }
}
