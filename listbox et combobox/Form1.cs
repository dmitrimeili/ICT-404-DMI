/*
 * Project: Listbox et Combobox
 * Date: 20.08.2019
 * Name: Meili Dmitri
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


namespace listbox_et_combobox
{
    public partial class Form1 : Form
    {
        int nbecole = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbo1.Items.Add("Swisscom");
            cbo1.Items.Add("Salt");
            cbo1.Items.Add("Sunrise");

            lst1.Items.Add("CEPM");
            lst1.Items.Add("CPNV");
            lst1.Items.Add("ECL");
            lst1.Items.Add("EPCL");
            lst1.Items.Add("EPSIC");
            lst1.Items.Add("ETML");

            cbo2.Items.Add("Gymnase de Bugnon");
            cbo2.Items.Add("Gymnase de Beaulieu");
            cbo2.Items.Add("Gymnase d'Yverdon");

            

        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {

            
            if (cbo1.SelectedIndex == -1 && cbo2.SelectedIndex == -1 && lst1.SelectedIndex==-1)/*si aucun element n est selectionner*/
            {
                MessageBox.Show("veuillez selectionner une école","error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbo1.SelectedIndex >= 0)/*si un element est selectionner dans cbo1*/
            {
                
                if (lst2.Items.Contains(cbo1.SelectedItem))/*si l élement sélectionner est deja dans lst2*/
                {
                    MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else/*ajout des élement sélectionner*/
                {
                    lst2.Items.Add(cbo1.SelectedItem);
                    cbo1.SelectedIndex = -1;
                    nbecole++;
                    txtNbEcole.Text =nbecole.ToString() ;
                }
            }
            if (cbo2.SelectedIndex >= 0)/*si un element est selectionner dans cbo2*/
            {
                if (lst2.Items.Contains(cbo2.SelectedItem))/*si l élement sélectionner est deja dans lst2*/
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else/*ajout des élement sélectionner*/
                {
                    lst2.Items.Add(cbo2.SelectedItem);
                    cbo2.SelectedIndex = -1;
                    nbecole++;
                    txtNbEcole.Text = nbecole.ToString();
                }
            }
            if(lst1.SelectedIndex>= 0)/*si un element est selectionner dans lst1*/
            {
                if (lst2.Items.Contains(lst1.SelectedItem))
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else/*ajout des élement sélectionner*/
                {
                    lst2.Items.Add(lst1.SelectedItem);
                    lst1.SelectedIndex = -1;
                    nbecole++;
                    txtNbEcole.Text = nbecole.ToString();
                }
            }
            
        }

        private void CmdEffacer_Click(object sender, EventArgs e)
        {
            
            lst2.Items.RemoveAt(lst2.SelectedIndex);//pour effacer
            nbecole--;
            txtNbEcole.Text = nbecole.ToString();
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {
            lst2.Items.Clear();//pour supprimer
            nbecole = 0;
            txtNbEcole.Text = nbecole.ToString();
        }

        private void CmdQuitter_Click(object sender, EventArgs e)//pour quitter
        {
            DialogResult dialogResult=MessageBox.Show("voulez vous quitter le programme?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
