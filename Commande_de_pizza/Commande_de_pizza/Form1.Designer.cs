namespace Commande_de_pizza
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
            this.rbextra = new System.Windows.Forms.RadioButton();
            this.rbfine = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.rbepaisse = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txttable = new System.Windows.Forms.TextBox();
            this.cmdcommander = new System.Windows.Forms.Button();
            this.lbltable = new System.Windows.Forms.Label();
            this.grppate = new System.Windows.Forms.GroupBox();
            this.txtcommande = new System.Windows.Forms.TextBox();
            this.lblcommander = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbextra
            // 
            this.rbextra.AutoSize = true;
            this.rbextra.Location = new System.Drawing.Point(107, 116);
            this.rbextra.Name = "rbextra";
            this.rbextra.Size = new System.Drawing.Size(72, 17);
            this.rbextra.TabIndex = 0;
            this.rbextra.TabStop = true;
            this.rbextra.Text = "Extra-Fine";
            this.rbextra.UseVisualStyleBackColor = true;
            this.rbextra.CheckedChanged += new System.EventHandler(this.rbextra_CheckedChanged);
            // 
            // rbfine
            // 
            this.rbfine.AutoSize = true;
            this.rbfine.Location = new System.Drawing.Point(107, 139);
            this.rbfine.Name = "rbfine";
            this.rbfine.Size = new System.Drawing.Size(45, 17);
            this.rbfine.TabIndex = 1;
            this.rbfine.TabStop = true;
            this.rbfine.Text = "Fine";
            this.rbfine.UseVisualStyleBackColor = true;
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Location = new System.Drawing.Point(107, 162);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(64, 17);
            this.rbnormal.TabIndex = 2;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Normale";
            this.rbnormal.UseVisualStyleBackColor = true;
            // 
            // rbepaisse
            // 
            this.rbepaisse.AutoSize = true;
            this.rbepaisse.Location = new System.Drawing.Point(107, 185);
            this.rbepaisse.Name = "rbepaisse";
            this.rbepaisse.Size = new System.Drawing.Size(62, 17);
            this.rbepaisse.TabIndex = 3;
            this.rbepaisse.TabStop = true;
            this.rbepaisse.Text = "Epaisse";
            this.rbepaisse.UseVisualStyleBackColor = true;
            this.rbepaisse.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(300, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(300, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(300, 163);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(300, 186);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txttable
            // 
            this.txttable.Location = new System.Drawing.Point(107, 12);
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(40, 20);
            this.txttable.TabIndex = 8;
            this.txttable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdcommander
            // 
            this.cmdcommander.Location = new System.Drawing.Point(300, 295);
            this.cmdcommander.Name = "cmdcommander";
            this.cmdcommander.Size = new System.Drawing.Size(75, 23);
            this.cmdcommander.TabIndex = 9;
            this.cmdcommander.Text = "Commander";
            this.cmdcommander.UseVisualStyleBackColor = true;
            this.cmdcommander.Click += new System.EventHandler(this.cmdcommander_Click);
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Location = new System.Drawing.Point(66, 15);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(34, 13);
            this.lbltable.TabIndex = 10;
            this.lbltable.Text = "Table";
            this.lbltable.Click += new System.EventHandler(this.label1_Click);
            // 
            // grppate
            // 
            this.grppate.Location = new System.Drawing.Point(94, 99);
            this.grppate.Name = "grppate";
            this.grppate.Size = new System.Drawing.Size(115, 116);
            this.grppate.TabIndex = 11;
            this.grppate.TabStop = false;
            this.grppate.Text = "Pâte";
            // 
            // txtcommande
            // 
            this.txtcommande.BackColor = System.Drawing.Color.Yellow;
            this.txtcommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcommande.Location = new System.Drawing.Point(94, 338);
            this.txtcommande.Multiline = true;
            this.txtcommande.Name = "txtcommande";
            this.txtcommande.Size = new System.Drawing.Size(286, 84);
            this.txtcommande.TabIndex = 12;
            this.txtcommande.TextChanged += new System.EventHandler(this.txtcommande_TextChanged);
            // 
            // lblcommander
            // 
            this.lblcommander.AutoSize = true;
            this.lblcommander.Location = new System.Drawing.Point(104, 305);
            this.lblcommander.Name = "lblcommander";
            this.lblcommander.Size = new System.Drawing.Size(60, 13);
            this.lblcommander.TabIndex = 13;
            this.lblcommander.Text = "Commande";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.lblcommander);
            this.Controls.Add(this.txtcommande);
            this.Controls.Add(this.lbltable);
            this.Controls.Add(this.cmdcommander);
            this.Controls.Add(this.txttable);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbepaisse);
            this.Controls.Add(this.rbnormal);
            this.Controls.Add(this.rbfine);
            this.Controls.Add(this.rbextra);
            this.Controls.Add(this.grppate);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbextra;
        private System.Windows.Forms.RadioButton rbfine;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.RadioButton rbepaisse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.Button cmdcommander;
        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.GroupBox grppate;
        private System.Windows.Forms.TextBox txtcommande;
        private System.Windows.Forms.Label lblcommander;
    }
}

