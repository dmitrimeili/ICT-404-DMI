namespace Exercice_Bonjour
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
            this.lblNom = new System.Windows.Forms.Label();
            this.LblBienvenu = new System.Windows.Forms.Label();
            this.cmdBienvenu = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(66, 58);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(214, 46);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Votre nom";
            // 
            // LblBienvenu
            // 
            this.LblBienvenu.AutoSize = true;
            this.LblBienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenu.Location = new System.Drawing.Point(66, 191);
            this.LblBienvenu.Name = "LblBienvenu";
            this.LblBienvenu.Size = new System.Drawing.Size(56, 46);
            this.LblBienvenu.TabIndex = 1;
            this.LblBienvenu.Text = "...";
            // 
            // cmdBienvenu
            // 
            this.cmdBienvenu.Location = new System.Drawing.Point(298, 328);
            this.cmdBienvenu.Name = "cmdBienvenu";
            this.cmdBienvenu.Size = new System.Drawing.Size(259, 64);
            this.cmdBienvenu.TabIndex = 2;
            this.cmdBienvenu.Text = "Bienvenu";
            this.cmdBienvenu.UseVisualStyleBackColor = true;
            this.cmdBienvenu.Click += new System.EventHandler(this.CmdBienvenu_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(298, 58);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(242, 46);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackgroundImage = global::Exercice_Bonjour.Properties.Resources.bouton_quitter_png;
            this.cmdQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdQuitter.Location = new System.Drawing.Point(622, 320);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(85, 72);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cmdBienvenu);
            this.Controls.Add(this.LblBienvenu);
            this.Controls.Add(this.lblNom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bonjour  Qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label LblBienvenu;
        private System.Windows.Forms.Button cmdBienvenu;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button cmdQuitter;
    }
}

