namespace Ecriture_dans_fichier_texte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdEcrire = new System.Windows.Forms.Button();
            this.lblNomFichier = new System.Windows.Forms.Label();
            this.lblContenu = new System.Windows.Forms.Label();
            this.txtNomFichier = new System.Windows.Forms.TextBox();
            this.txtContenu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdEcrire
            // 
            this.cmdEcrire.Location = new System.Drawing.Point(63, 344);
            this.cmdEcrire.Name = "cmdEcrire";
            this.cmdEcrire.Size = new System.Drawing.Size(224, 23);
            this.cmdEcrire.TabIndex = 0;
            this.cmdEcrire.Text = "Ecrire dans le fichier";
            this.cmdEcrire.UseVisualStyleBackColor = true;
            this.cmdEcrire.Click += new System.EventHandler(this.CmdEcrire_Click);
            // 
            // lblNomFichier
            // 
            this.lblNomFichier.AutoSize = true;
            this.lblNomFichier.Location = new System.Drawing.Point(63, 25);
            this.lblNomFichier.Name = "lblNomFichier";
            this.lblNomFichier.Size = new System.Drawing.Size(99, 17);
            this.lblNomFichier.TabIndex = 1;
            this.lblNomFichier.Text = "Nom du fichier";
            // 
            // lblContenu
            // 
            this.lblContenu.AutoSize = true;
            this.lblContenu.Location = new System.Drawing.Point(63, 112);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(61, 17);
            this.lblContenu.TabIndex = 2;
            this.lblContenu.Text = "Contenu";
            // 
            // txtNomFichier
            // 
            this.txtNomFichier.Location = new System.Drawing.Point(63, 59);
            this.txtNomFichier.Name = "txtNomFichier";
            this.txtNomFichier.Size = new System.Drawing.Size(100, 22);
            this.txtNomFichier.TabIndex = 3;
            // 
            // txtContenu
            // 
            this.txtContenu.Location = new System.Drawing.Point(63, 154);
            this.txtContenu.Multiline = true;
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(397, 168);
            this.txtContenu.TabIndex = 4;
            this.txtContenu.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.txtNomFichier);
            this.Controls.Add(this.lblContenu);
            this.Controls.Add(this.lblNomFichier);
            this.Controls.Add(this.cmdEcrire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEcrire;
        private System.Windows.Forms.Label lblNomFichier;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.TextBox txtNomFichier;
        private System.Windows.Forms.TextBox txtContenu;
    }
}

