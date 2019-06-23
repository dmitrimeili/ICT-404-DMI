namespace LectureDeFichier
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblContenu = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtcontenu = new System.Windows.Forms.TextBox();
            this.cmdReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(26, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(99, 17);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Nom du fichier";
            // 
            // lblContenu
            // 
            this.lblContenu.AutoSize = true;
            this.lblContenu.Location = new System.Drawing.Point(26, 90);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(61, 17);
            this.lblContenu.TabIndex = 1;
            this.lblContenu.Text = "Contenu";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(25, 29);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(100, 22);
            this.txtFile.TabIndex = 2;
            // 
            // txtcontenu
            // 
            this.txtcontenu.Location = new System.Drawing.Point(29, 133);
            this.txtcontenu.Multiline = true;
            this.txtcontenu.Name = "txtcontenu";
            this.txtcontenu.Size = new System.Drawing.Size(437, 228);
            this.txtcontenu.TabIndex = 3;
            this.txtcontenu.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cmdReadFile
            // 
            this.cmdReadFile.Location = new System.Drawing.Point(266, 384);
            this.cmdReadFile.Name = "cmdReadFile";
            this.cmdReadFile.Size = new System.Drawing.Size(200, 23);
            this.cmdReadFile.TabIndex = 4;
            this.cmdReadFile.Text = "Lire le fichier";
            this.cmdReadFile.UseVisualStyleBackColor = true;
            this.cmdReadFile.Click += new System.EventHandler(this.CmdReadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdReadFile);
            this.Controls.Add(this.txtcontenu);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblContenu);
            this.Controls.Add(this.lblFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtcontenu;
        private System.Windows.Forms.Button cmdReadFile;
    }
}

