namespace WF_appli2
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
            this.bAugmenter = new System.Windows.Forms.Button();
            this.bReduire = new System.Windows.Forms.Button();
            this.bImage = new System.Windows.Forms.Button();
            this.bCouleur = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAugmenter
            // 
            this.bAugmenter.Location = new System.Drawing.Point(130, 186);
            this.bAugmenter.Name = "bAugmenter";
            this.bAugmenter.Size = new System.Drawing.Size(116, 82);
            this.bAugmenter.TabIndex = 0;
            this.bAugmenter.Text = "Augmenter la taille de la fenêtre";
            this.bAugmenter.UseVisualStyleBackColor = true;
            this.bAugmenter.Click += new System.EventHandler(this.bAugmenter_Click);
            // 
            // bReduire
            // 
            this.bReduire.Location = new System.Drawing.Point(642, 183);
            this.bReduire.Name = "bReduire";
            this.bReduire.Size = new System.Drawing.Size(131, 85);
            this.bReduire.TabIndex = 1;
            this.bReduire.Text = "Réduire la taille de la fenêtre";
            this.bReduire.UseVisualStyleBackColor = true;
            this.bReduire.Click += new System.EventHandler(this.bReduire_Click);
            // 
            // bImage
            // 
            this.bImage.Location = new System.Drawing.Point(130, 328);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(116, 78);
            this.bImage.TabIndex = 2;
            this.bImage.Text = "Mettre une image en fond";
            this.bImage.UseVisualStyleBackColor = true;
            this.bImage.Click += new System.EventHandler(this.bImage_Click);
            // 
            // bCouleur
            // 
            this.bCouleur.Location = new System.Drawing.Point(397, 328);
            this.bCouleur.Name = "bCouleur";
            this.bCouleur.Size = new System.Drawing.Size(128, 78);
            this.bCouleur.TabIndex = 3;
            this.bCouleur.Text = "Modifier la couleur de fond";
            this.bCouleur.UseVisualStyleBackColor = true;
            this.bCouleur.Click += new System.EventHandler(this.bCouleur_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.Location = new System.Drawing.Point(642, 328);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(131, 78);
            this.bRectangle.TabIndex = 4;
            this.bRectangle.Text = "Dessiner un rectangle";
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            this.bRectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.bRectangle_Paint);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(299, 242);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(323, 26);
            this.tB1.TabIndex = 5;
            this.tB1.TextChanged += new System.EventHandler(this.tB1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 564);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.bRectangle);
            this.Controls.Add(this.bCouleur);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.bReduire);
            this.Controls.Add(this.bAugmenter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAugmenter;
        private System.Windows.Forms.Button bReduire;
        private System.Windows.Forms.Button bImage;
        private System.Windows.Forms.Button bCouleur;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.TextBox tB1;
    }
}

