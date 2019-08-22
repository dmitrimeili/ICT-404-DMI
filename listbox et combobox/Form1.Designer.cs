namespace listbox_et_combobox
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
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lblNbEcoles = new System.Windows.Forms.Label();
            this.txtNbEcole = new System.Windows.Forms.TextBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo1
            // 
            this.cbo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(41, 55);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(178, 24);
            this.cbo1.TabIndex = 0;
            // 
            // cbo2
            // 
            this.cbo2.ForeColor = System.Drawing.Color.Fuchsia;
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(41, 368);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(178, 24);
            this.cbo2.TabIndex = 1;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(337, 56);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(106, 23);
            this.cmdAjouter.TabIndex = 2;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(337, 133);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(106, 23);
            this.cmdEffacer.TabIndex = 3;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            this.cmdEffacer.Click += new System.EventHandler(this.CmdEffacer_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(337, 213);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(106, 23);
            this.cmdSupprimer.TabIndex = 4;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdSupprimer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(337, 369);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(106, 23);
            this.cmdQuitter.TabIndex = 5;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // lst1
            // 
            this.lst1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 16;
            this.lst1.Location = new System.Drawing.Point(42, 144);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(177, 180);
            this.lst1.TabIndex = 6;
            // 
            // lst2
            // 
            this.lst2.ForeColor = System.Drawing.Color.Blue;
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 16;
            this.lst2.Location = new System.Drawing.Point(573, 56);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(176, 180);
            this.lst2.TabIndex = 7;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // lblNbEcoles
            // 
            this.lblNbEcoles.AutoSize = true;
            this.lblNbEcoles.Location = new System.Drawing.Point(593, 307);
            this.lblNbEcoles.Name = "lblNbEcoles";
            this.lblNbEcoles.Size = new System.Drawing.Size(140, 17);
            this.lblNbEcoles.TabIndex = 8;
            this.lblNbEcoles.Text = "écoles sélectionnées";
            this.lblNbEcoles.Click += new System.EventHandler(this.lblNbEcoles_Click);
            // 
            // txtNbEcole
            // 
            this.txtNbEcole.Location = new System.Drawing.Point(573, 348);
            this.txtNbEcole.Name = "txtNbEcole";
            this.txtNbEcole.Size = new System.Drawing.Size(176, 22);
            this.txtNbEcole.TabIndex = 9;
            this.txtNbEcole.TextChanged += new System.EventHandler(this.txtNbEcole_TextChanged);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(337, 286);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(106, 23);
            this.cmdAnnuler.TabIndex = 10;
            this.cmdAnnuler.Text = "Annuler tout";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.txtNbEcole);
            this.Controls.Add(this.lblNbEcoles);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.cbo1);
            this.Name = "Form1";
            this.Text = "ListBox et ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Label lblNbEcoles;
        private System.Windows.Forms.TextBox txtNbEcole;
        private System.Windows.Forms.Button cmdAnnuler;
    }
}

