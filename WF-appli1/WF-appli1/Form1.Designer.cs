namespace WF_appli1
{
    partial class Form1
    {//Partie 2 de la partition Form
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
            this.bHello = new System.Windows.Forms.Button();
            this.tBvaleur = new System.Windows.Forms.TextBox();
            this.bAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bHello
            // 
            this.bHello.Location = new System.Drawing.Point(79, 169);
            this.bHello.Name = "bHello";
            this.bHello.Size = new System.Drawing.Size(167, 70);
            this.bHello.TabIndex = 0;
            this.bHello.Text = "Hello Speedy";
            this.bHello.UseVisualStyleBackColor = true;
            this.bHello.Click += new System.EventHandler(this.bHello_Click);
            // 
            // tBvaleur
            // 
            this.tBvaleur.Location = new System.Drawing.Point(124, 74);
            this.tBvaleur.Name = "tBvaleur";
            this.tBvaleur.Size = new System.Drawing.Size(226, 26);
            this.tBvaleur.TabIndex = 1;
            this.tBvaleur.TextChanged += new System.EventHandler(this.tBvaleur_TextChanged);
            this.tBvaleur.Enter += new System.EventHandler(this.tBvaleur_Enter);
            // 
            // bAffiche
            // 
            this.bAffiche.Location = new System.Drawing.Point(275, 169);
            this.bAffiche.Name = "bAffiche";
            this.bAffiche.Size = new System.Drawing.Size(171, 81);
            this.bAffiche.TabIndex = 2;
            this.bAffiche.Text = "Affiche le contenu de la textBox";
            this.bAffiche.UseVisualStyleBackColor = true;
            this.bAffiche.Click += new System.EventHandler(this.bAffiche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(479, 303);
            this.Controls.Add(this.bAffiche);
            this.Controls.Add(this.tBvaleur);
            this.Controls.Add(this.bHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bHello;
        private System.Windows.Forms.TextBox tBvaleur;
        private System.Windows.Forms.Button bAffiche;
    }
}

