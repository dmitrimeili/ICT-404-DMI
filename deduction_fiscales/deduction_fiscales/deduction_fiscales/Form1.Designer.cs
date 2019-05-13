namespace deduction_fiscales
{
    partial class Deduction
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
            this.deduction_j = new System.Windows.Forms.CheckBox();
            this.deduction_t = new System.Windows.Forms.CheckBox();
            this.rabais = new System.Windows.Forms.CheckBox();
            this.revenu_ab = new System.Windows.Forms.Label();
            this.CF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxdeducjeune = new System.Windows.Forms.TextBox();
            this.boxrabais = new System.Windows.Forms.TextBox();
            this.boxdeductransport = new System.Windows.Forms.TextBox();
            this.bouton_calcul = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deduction_j
            // 
            this.deduction_j.AutoSize = true;
            this.deduction_j.Location = new System.Drawing.Point(98, 178);
            this.deduction_j.Name = "deduction_j";
            this.deduction_j.Size = new System.Drawing.Size(104, 17);
            this.deduction_j.TabIndex = 2;
            this.deduction_j.Text = "Déduction jeune";
            this.deduction_j.UseVisualStyleBackColor = true;
            // 
            // deduction_t
            // 
            this.deduction_t.AutoSize = true;
            this.deduction_t.Location = new System.Drawing.Point(98, 220);
            this.deduction_t.Name = "deduction_t";
            this.deduction_t.Size = new System.Drawing.Size(119, 17);
            this.deduction_t.TabIndex = 4;
            this.deduction_t.Text = "Déduction transport";
            this.deduction_t.UseVisualStyleBackColor = true;
            // 
            // rabais
            // 
            this.rabais.AutoSize = true;
            this.rabais.Location = new System.Drawing.Point(98, 263);
            this.rabais.Name = "rabais";
            this.rabais.Size = new System.Drawing.Size(109, 17);
            this.rabais.TabIndex = 6;
            this.rabais.Text = "Rabais fidélité (%)";
            this.rabais.UseVisualStyleBackColor = true;
            // 
            // revenu_ab
            // 
            this.revenu_ab.AutoSize = true;
            this.revenu_ab.Location = new System.Drawing.Point(50, 28);
            this.revenu_ab.Name = "revenu_ab";
            this.revenu_ab.Size = new System.Drawing.Size(101, 13);
            this.revenu_ab.TabIndex = 3;
            this.revenu_ab.Text = "Revenu annuel brut";
            // 
            // CF
            // 
            this.CF.AutoSize = true;
            this.CF.Location = new System.Drawing.Point(50, 78);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(91, 13);
            this.CF.TabIndex = 4;
            this.CF.Text = "Coéfficient familial";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 1;
            // 
            // boxdeducjeune
            // 
            this.boxdeducjeune.Location = new System.Drawing.Point(252, 175);
            this.boxdeducjeune.Name = "boxdeducjeune";
            this.boxdeducjeune.Size = new System.Drawing.Size(63, 20);
            this.boxdeducjeune.TabIndex = 3;
            this.boxdeducjeune.Text = "900";
            this.boxdeducjeune.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // boxrabais
            // 
            this.boxrabais.Location = new System.Drawing.Point(252, 260);
            this.boxrabais.Name = "boxrabais";
            this.boxrabais.Size = new System.Drawing.Size(63, 20);
            this.boxrabais.TabIndex = 7;
            this.boxrabais.Text = "0";
            this.boxrabais.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // boxdeductransport
            // 
            this.boxdeductransport.Location = new System.Drawing.Point(252, 218);
            this.boxdeductransport.Name = "boxdeductransport";
            this.boxdeductransport.Size = new System.Drawing.Size(63, 20);
            this.boxdeductransport.TabIndex = 5;
            this.boxdeductransport.Text = "650";
            // 
            // bouton_calcul
            // 
            this.bouton_calcul.Location = new System.Drawing.Point(178, 325);
            this.bouton_calcul.Name = "bouton_calcul";
            this.bouton_calcul.Size = new System.Drawing.Size(112, 23);
            this.bouton_calcul.TabIndex = 8;
            this.bouton_calcul.Text = "Calcul";
            this.bouton_calcul.UseVisualStyleBackColor = true;
            this.bouton_calcul.Click += new System.EventHandler(this.bouton_calcul_Click);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat.Location = new System.Drawing.Point(105, 394);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(46, 24);
            this.resultat.TabIndex = 9;
            this.resultat.Text = ". . . ";
            this.resultat.Click += new System.EventHandler(this.resultat_Click);
            // 
            // Deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.bouton_calcul);
            this.Controls.Add(this.boxdeductransport);
            this.Controls.Add(this.boxrabais);
            this.Controls.Add(this.boxdeducjeune);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CF);
            this.Controls.Add(this.revenu_ab);
            this.Controls.Add(this.rabais);
            this.Controls.Add(this.deduction_t);
            this.Controls.Add(this.deduction_j);
            this.Name = "Deduction";
            this.Text = "Déduction";
            this.Load += new System.EventHandler(this.Déduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox deduction_j;
        private System.Windows.Forms.CheckBox deduction_t;
        private System.Windows.Forms.CheckBox rabais;
        private System.Windows.Forms.Label revenu_ab;
        private System.Windows.Forms.Label CF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox boxdeducjeune;
        private System.Windows.Forms.TextBox boxrabais;
        private System.Windows.Forms.TextBox boxdeductransport;
        private System.Windows.Forms.Button bouton_calcul;
        private System.Windows.Forms.Label resultat;
    }
}

