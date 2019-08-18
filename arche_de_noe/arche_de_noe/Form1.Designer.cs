namespace arche_de_noe
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
            this.cmdterbord = new System.Windows.Forms.Button();
            this.cmdbordter = new System.Windows.Forms.Button();
            this.lblterre = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbxterre = new System.Windows.Forms.ListBox();
            this.lbxbord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdterbord
            // 
            this.cmdterbord.Location = new System.Drawing.Point(373, 175);
            this.cmdterbord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdterbord.Name = "cmdterbord";
            this.cmdterbord.Size = new System.Drawing.Size(100, 28);
            this.cmdterbord.TabIndex = 0;
            this.cmdterbord.Text = "===>";
            this.cmdterbord.UseVisualStyleBackColor = true;
            this.cmdterbord.Click += new System.EventHandler(this.cmdterbord_Click);
            // 
            // cmdbordter
            // 
            this.cmdbordter.Location = new System.Drawing.Point(373, 262);
            this.cmdbordter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdbordter.Name = "cmdbordter";
            this.cmdbordter.Size = new System.Drawing.Size(100, 28);
            this.cmdbordter.TabIndex = 1;
            this.cmdbordter.Text = "<===";
            this.cmdbordter.UseVisualStyleBackColor = true;
            this.cmdbordter.Click += new System.EventHandler(this.cmdbordter_Click);
            // 
            // lblterre
            // 
            this.lblterre.AutoSize = true;
            this.lblterre.Location = new System.Drawing.Point(88, 43);
            this.lblterre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblterre.Name = "lblterre";
            this.lblterre.Size = new System.Drawing.Size(99, 17);
            this.lblterre.TabIndex = 2;
            this.lblterre.Text = "Encore à terre";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(533, 43);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 17);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "A bord";
            // 
            // lbxterre
            // 
            this.lbxterre.FormattingEnabled = true;
            this.lbxterre.ItemHeight = 16;
            this.lbxterre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.lbxterre.Location = new System.Drawing.Point(92, 91);
            this.lbxterre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxterre.Name = "lbxterre";
            this.lbxterre.Size = new System.Drawing.Size(236, 404);
            this.lbxterre.TabIndex = 6;
            // 
            // lbxbord
            // 
            this.lbxbord.FormattingEnabled = true;
            this.lbxbord.ItemHeight = 16;
            this.lbxbord.Location = new System.Drawing.Point(537, 91);
            this.lbxbord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxbord.Name = "lbxbord";
            this.lbxbord.Size = new System.Drawing.Size(236, 404);
            this.lbxbord.TabIndex = 7;
            this.lbxbord.SelectedIndexChanged += new System.EventHandler(this.lbxbord_SelectedIndexChanged);
            this.lbxbord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxbord_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbxbord);
            this.Controls.Add(this.lbxterre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblterre);
            this.Controls.Add(this.cmdbordter);
            this.Controls.Add(this.cmdterbord);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Arche de Noé";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdterbord;
        private System.Windows.Forms.Button cmdbordter;
        private System.Windows.Forms.Label lblterre;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox lbxterre;
        private System.Windows.Forms.ListBox lbxbord;
    }
}

