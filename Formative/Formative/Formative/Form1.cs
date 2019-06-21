using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formative
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
            
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            
            cboArticle.Items.Add("Pain");
            cboArticle.Items.Add("Beurre");
            cboArticle.Items.Add("Lait");
            cboArticle.Items.Add("Confiture");
            cboArticle.Items.Add("Fromage");
            cboArticle.Items.Add("Oeufs");
            cboArticle.Items.Add("Farine");
            cboArticle.Items.Add("Sucre");
            cboArticle.Items.Add("Viande");
   
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            int quantite;
            string ajout;
            if (cboArticle.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez un article");
                return;
            }
            else if (txtQuantite.Text==""||!int.TryParse(txtQuantite.Text, out quantite))
            {
                MessageBox.Show("Introduisez une quantité");
                return;
            }
            else
            {
               
                lstCourses.Items.Add(cboArticle.SelectedItem+": "+quantite.ToString());
                ajout = cboArticle.SelectedItem.ToString();
                cboArticle.Items.Remove(ajout);
                txtQuantite.Text = "";
                cboArticle.SelectedIndex = -1;
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            string article;
            int longueur;

            if (lstCourses.SelectedIndex != -1)
            {
                article = lstCourses.SelectedItem.ToString();
                lstCourses.Items.Remove(article);
                longueur = article.IndexOf(":");
                article =article.Substring(0, longueur);
                cboArticle.Items.Add(article);
               
            }
            else
            {
                MessageBox.Show("Veulliez selectionner un article");
            }
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore disponible");
        }
    }
}
