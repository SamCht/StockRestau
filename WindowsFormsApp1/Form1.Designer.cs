namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.nomR = new System.Windows.Forms.TextBox();
            this.nomAj = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.prixAj = new System.Windows.Forms.TextBox();
            this.qteAj = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.nomSup = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recherche Plat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomR
            // 
            this.nomR.Location = new System.Drawing.Point(106, 70);
            this.nomR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomR.Name = "nomR";
            this.nomR.Size = new System.Drawing.Size(141, 22);
            this.nomR.TabIndex = 1;
            this.nomR.Text = "Nom";
            // 
            // nomAj
            // 
            this.nomAj.Location = new System.Drawing.Point(107, 156);
            this.nomAj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomAj.Name = "nomAj";
            this.nomAj.Size = new System.Drawing.Size(141, 22);
            this.nomAj.TabIndex = 2;
            this.nomAj.Text = "Nom ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter Plat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prixAj
            // 
            this.prixAj.Location = new System.Drawing.Point(106, 182);
            this.prixAj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prixAj.Name = "prixAj";
            this.prixAj.Size = new System.Drawing.Size(141, 22);
            this.prixAj.TabIndex = 4;
            this.prixAj.Text = "Prix";
            // 
            // qteAj
            // 
            this.qteAj.Location = new System.Drawing.Point(107, 208);
            this.qteAj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qteAj.Name = "qteAj";
            this.qteAj.Size = new System.Drawing.Size(141, 22);
            this.qteAj.TabIndex = 5;
            this.qteAj.Text = "Quantité";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 287);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Supprimer Plat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nomSup
            // 
            this.nomSup.Location = new System.Drawing.Point(107, 300);
            this.nomSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomSup.Name = "nomSup";
            this.nomSup.Size = new System.Drawing.Size(140, 22);
            this.nomSup.TabIndex = 7;
            this.nomSup.Text = "Nom";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 412);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(407, 54);
            this.button4.TabIndex = 8;
            this.button4.Text = "Afficher tous les plats";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(254, 500);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 54);
            this.button5.TabIndex = 9;
            this.button5.Text = "Quitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 565);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nomSup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.qteAj);
            this.Controls.Add(this.prixAj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nomAj);
            this.Controls.Add(this.nomR);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomR;
        private System.Windows.Forms.TextBox nomAj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox prixAj;
        private System.Windows.Forms.TextBox qteAj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nomSup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

