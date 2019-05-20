namespace Fenetre_blue_rouge
{
    partial class Fenetre
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
            this.HautGauche = new System.Windows.Forms.Button();
            this.HautDroite = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.Rouge = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.BasGauche = new System.Windows.Forms.Button();
            this.BasDroite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HautGauche
            // 
            this.HautGauche.Location = new System.Drawing.Point(12, 12);
            this.HautGauche.Name = "HautGauche";
            this.HautGauche.Size = new System.Drawing.Size(89, 23);
            this.HautGauche.TabIndex = 0;
            this.HautGauche.Text = "Haut/Gauche";
            this.HautGauche.UseVisualStyleBackColor = true;
            this.HautGauche.Click += new System.EventHandler(this.HautGauche_Click);
            // 
            // HautDroite
            // 
            this.HautDroite.Location = new System.Drawing.Point(405, 12);
            this.HautDroite.Name = "HautDroite";
            this.HautDroite.Size = new System.Drawing.Size(75, 23);
            this.HautDroite.TabIndex = 1;
            this.HautDroite.Text = "Haut/Droite";
            this.HautDroite.UseVisualStyleBackColor = true;
            this.HautDroite.Click += new System.EventHandler(this.HautDroite_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(206, 90);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(75, 23);
            this.blue.TabIndex = 2;
            this.blue.Text = "Bleu";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // Rouge
            // 
            this.Rouge.Location = new System.Drawing.Point(206, 119);
            this.Rouge.Name = "Rouge";
            this.Rouge.Size = new System.Drawing.Size(75, 23);
            this.Rouge.TabIndex = 3;
            this.Rouge.Text = "Rouge";
            this.Rouge.UseVisualStyleBackColor = true;
            this.Rouge.Click += new System.EventHandler(this.Rouge_Click);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(206, 186);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(75, 23);
            this.Stats.TabIndex = 4;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(206, 241);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 5;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            // 
            // BasGauche
            // 
            this.BasGauche.Location = new System.Drawing.Point(12, 359);
            this.BasGauche.Name = "BasGauche";
            this.BasGauche.Size = new System.Drawing.Size(75, 23);
            this.BasGauche.TabIndex = 6;
            this.BasGauche.Text = "Bas/Gauche";
            this.BasGauche.UseVisualStyleBackColor = true;
            // 
            // BasDroite
            // 
            this.BasDroite.Location = new System.Drawing.Point(405, 359);
            this.BasDroite.Name = "BasDroite";
            this.BasDroite.Size = new System.Drawing.Size(75, 23);
            this.BasDroite.TabIndex = 7;
            this.BasDroite.Text = "Bas/Droite";
            this.BasDroite.UseVisualStyleBackColor = true;
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 400);
            this.Controls.Add(this.BasDroite);
            this.Controls.Add(this.BasGauche);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.Rouge);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.HautDroite);
            this.Controls.Add(this.HautGauche);
            this.Name = "Fenetre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre";
            this.Load += new System.EventHandler(this.Fenêtre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HautGauche;
        private System.Windows.Forms.Button HautDroite;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button Rouge;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button BasGauche;
        private System.Windows.Forms.Button BasDroite;
    }
}

