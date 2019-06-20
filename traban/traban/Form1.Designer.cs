namespace traban
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
            this.lblbase = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.grbmoteur = new System.Windows.Forms.GroupBox();
            this.rb16L = new System.Windows.Forms.RadioButton();
            this.rbdeserie = new System.Windows.Forms.RadioButton();
            this.cbtax = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.grbmoteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(31, 32);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(37, 13);
            this.lblbase.TabIndex = 0;
            this.lblbase.Text = "Base :";
            this.lblbase.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(68, 29);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 1;
            this.txtbase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbase.Leave += new System.EventHandler(this.txtbase_Leave);
            // 
            // grbmoteur
            // 
            this.grbmoteur.Controls.Add(this.rb16L);
            this.grbmoteur.Controls.Add(this.rbdeserie);
            this.grbmoteur.Location = new System.Drawing.Point(12, 95);
            this.grbmoteur.Name = "grbmoteur";
            this.grbmoteur.Size = new System.Drawing.Size(200, 100);
            this.grbmoteur.TabIndex = 2;
            this.grbmoteur.TabStop = false;
            this.grbmoteur.Text = "Moteur";
            // 
            // rb16L
            // 
            this.rb16L.AutoSize = true;
            this.rb16L.Location = new System.Drawing.Point(22, 55);
            this.rb16L.Name = "rb16L";
            this.rb16L.Size = new System.Drawing.Size(106, 17);
            this.rb16L.TabIndex = 1;
            this.rb16L.TabStop = true;
            this.rb16L.Text = "1,6 L : 2210 euro";
            this.rb16L.UseVisualStyleBackColor = true;
            this.rb16L.CheckedChanged += new System.EventHandler(this.rb16L_CheckedChanged);
            // 
            // rbdeserie
            // 
            this.rbdeserie.AutoSize = true;
            this.rbdeserie.Location = new System.Drawing.Point(22, 20);
            this.rbdeserie.Name = "rbdeserie";
            this.rbdeserie.Size = new System.Drawing.Size(95, 17);
            this.rbdeserie.TabIndex = 0;
            this.rbdeserie.TabStop = true;
            this.rbdeserie.Text = "1,4 L : de série";
            this.rbdeserie.UseVisualStyleBackColor = true;
            this.rbdeserie.CheckedChanged += new System.EventHandler(this.rbdeserie_CheckedChanged);
            // 
            // cbtax
            // 
            this.cbtax.AutoSize = true;
            this.cbtax.Location = new System.Drawing.Point(34, 273);
            this.cbtax.Name = "cbtax";
            this.cbtax.Size = new System.Drawing.Size(90, 17);
            this.cbtax.TabIndex = 3;
            this.cbtax.Text = "Taxes (6,8 %)";
            this.cbtax.UseVisualStyleBackColor = true;
            this.cbtax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remettre le formulaire à zero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(31, 404);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 13);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total :";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtax);
            this.Controls.Add(this.grbmoteur);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.lblbase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbmoteur.ResumeLayout(false);
            this.grbmoteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.GroupBox grbmoteur;
        private System.Windows.Forms.RadioButton rb16L;
        private System.Windows.Forms.RadioButton rbdeserie;
        private System.Windows.Forms.CheckBox cbtax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltotal;
    }
}

