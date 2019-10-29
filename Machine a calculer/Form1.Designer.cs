namespace Machine_a_calculer
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSub = new System.Windows.Forms.Button();
            this.cmdMult = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.lblFormule = new System.Windows.Forms.Label();
            this.txtNbTwo = new System.Windows.Forms.TextBox();
            this.txtNbOne = new System.Windows.Forms.TextBox();
            this.cmdAnswer = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.cmdCE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(42, 117);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // cmdSub
            // 
            this.cmdSub.Location = new System.Drawing.Point(182, 117);
            this.cmdSub.Name = "cmdSub";
            this.cmdSub.Size = new System.Drawing.Size(75, 23);
            this.cmdSub.TabIndex = 1;
            this.cmdSub.Text = "-";
            this.cmdSub.UseVisualStyleBackColor = true;
            this.cmdSub.Click += new System.EventHandler(this.CmdSub_Click);
            // 
            // cmdMult
            // 
            this.cmdMult.Location = new System.Drawing.Point(330, 117);
            this.cmdMult.Name = "cmdMult";
            this.cmdMult.Size = new System.Drawing.Size(75, 23);
            this.cmdMult.TabIndex = 2;
            this.cmdMult.Text = "X";
            this.cmdMult.UseVisualStyleBackColor = true;
            this.cmdMult.Click += new System.EventHandler(this.CmdMult_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(470, 117);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(75, 23);
            this.cmdDiv.TabIndex = 3;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            this.cmdDiv.Click += new System.EventHandler(this.CmdDiv_Click);
            // 
            // lblFormule
            // 
            this.lblFormule.AutoSize = true;
            this.lblFormule.Location = new System.Drawing.Point(258, 49);
            this.lblFormule.Name = "lblFormule";
            this.lblFormule.Size = new System.Drawing.Size(20, 17);
            this.lblFormule.TabIndex = 5;
            this.lblFormule.Text = "...";
            // 
            // txtNbTwo
            // 
            this.txtNbTwo.Location = new System.Drawing.Point(401, 49);
            this.txtNbTwo.Name = "txtNbTwo";
            this.txtNbTwo.Size = new System.Drawing.Size(100, 22);
            this.txtNbTwo.TabIndex = 6;
            this.txtNbTwo.TextChanged += new System.EventHandler(this.TxtNbTwo_TextChanged);
            // 
            // txtNbOne
            // 
            this.txtNbOne.Location = new System.Drawing.Point(42, 49);
            this.txtNbOne.Name = "txtNbOne";
            this.txtNbOne.Size = new System.Drawing.Size(100, 22);
            this.txtNbOne.TabIndex = 7;
            this.txtNbOne.TextChanged += new System.EventHandler(this.TxtNbOne_TextChanged);
            // 
            // cmdAnswer
            // 
            this.cmdAnswer.Location = new System.Drawing.Point(42, 209);
            this.cmdAnswer.Name = "cmdAnswer";
            this.cmdAnswer.Size = new System.Drawing.Size(75, 23);
            this.cmdAnswer.TabIndex = 8;
            this.cmdAnswer.Text = "=";
            this.cmdAnswer.UseVisualStyleBackColor = true;
            this.cmdAnswer.Click += new System.EventHandler(this.CmdAnswer_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.lblAnswer.Location = new System.Drawing.Point(211, 215);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 32);
            this.lblAnswer.TabIndex = 9;
            // 
            // cmdCE
            // 
            this.cmdCE.Location = new System.Drawing.Point(426, 354);
            this.cmdCE.Name = "cmdCE";
            this.cmdCE.Size = new System.Drawing.Size(75, 23);
            this.cmdCE.TabIndex = 10;
            this.cmdCE.Text = "CE";
            this.cmdCE.UseVisualStyleBackColor = true;
            this.cmdCE.Click += new System.EventHandler(this.CmdCE_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(355, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdCE);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.cmdAnswer);
            this.Controls.Add(this.txtNbOne);
            this.Controls.Add(this.txtNbTwo);
            this.Controls.Add(this.lblFormule);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMult);
            this.Controls.Add(this.cmdSub);
            this.Controls.Add(this.cmdAdd);
            this.Name = "Form1";
            this.Text = "Machine a calculer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSub;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Label lblFormule;
        private System.Windows.Forms.TextBox txtNbTwo;
        private System.Windows.Forms.TextBox txtNbOne;
        private System.Windows.Forms.Button cmdAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button cmdCE;
        private System.Windows.Forms.ListBox listBox1;
    }
}

