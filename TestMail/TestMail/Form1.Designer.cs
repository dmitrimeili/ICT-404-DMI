namespace TestMail
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
            this.chkarobase = new System.Windows.Forms.CheckBox();
            this.chkPointPresent = new System.Windows.Forms.CheckBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmdverifier = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblavant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkarobase
            // 
            this.chkarobase.AutoSize = true;
            this.chkarobase.Location = new System.Drawing.Point(134, 168);
            this.chkarobase.Name = "chkarobase";
            this.chkarobase.Size = new System.Drawing.Size(82, 17);
            this.chkarobase.TabIndex = 0;
            this.chkarobase.Text = "\"@\"présent";
            this.chkarobase.UseVisualStyleBackColor = true;
            // 
            // chkPointPresent
            // 
            this.chkPointPresent.AutoSize = true;
            this.chkPointPresent.Location = new System.Drawing.Point(134, 243);
            this.chkPointPresent.Name = "chkPointPresent";
            this.chkPointPresent.Size = new System.Drawing.Size(127, 17);
            this.chkPointPresent.TabIndex = 1;
            this.chkPointPresent.Text = "\".\"présent après \"@\"";
            this.chkPointPresent.UseVisualStyleBackColor = true;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(98, 60);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(75, 13);
            this.lblmail.TabIndex = 2;
            this.lblmail.Text = "Email à vérifier";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(179, 60);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(285, 20);
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // cmdverifier
            // 
            this.cmdverifier.Location = new System.Drawing.Point(553, 60);
            this.cmdverifier.Name = "cmdverifier";
            this.cmdverifier.Size = new System.Drawing.Size(75, 23);
            this.cmdverifier.TabIndex = 4;
            this.cmdverifier.Text = "Vérifier";
            this.cmdverifier.UseVisualStyleBackColor = true;
            this.cmdverifier.Click += new System.EventHandler(this.cmdverifier_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblavant
            // 
            this.lblavant.AutoSize = true;
            this.lblavant.Location = new System.Drawing.Point(176, 194);
            this.lblavant.Name = "lblavant";
            this.lblavant.Size = new System.Drawing.Size(107, 13);
            this.lblavant.TabIndex = 8;
            this.lblavant.Text = "caractère(s) avant @";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "caractère(s) après @";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblavant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmdverifier);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.chkPointPresent);
            this.Controls.Add(this.chkarobase);
            this.Name = "Form1";
            this.Text = "Vérification d\'Email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkarobase;
        private System.Windows.Forms.CheckBox chkPointPresent;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button cmdverifier;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblavant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

