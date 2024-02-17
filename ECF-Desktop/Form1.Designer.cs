
namespace ECF_Desktop
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
            this.panelTitre = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitreSortie = new System.Windows.Forms.Label();
            this.labelTitreEntre = new System.Windows.Forms.Label();
            this.labelTitreNomPrenom = new System.Windows.Forms.Label();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(227)))));
            this.panelTitre.Controls.Add(this.panel2);
            this.panelTitre.Controls.Add(this.labelTitreSortie);
            this.panelTitre.Controls.Add(this.labelTitreEntre);
            this.panelTitre.Controls.Add(this.labelTitreNomPrenom);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(1254, 50);
            this.panelTitre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 3);
            this.panel2.TabIndex = 3;
            // 
            // labelTitreSortie
            // 
            this.labelTitreSortie.AutoSize = true;
            this.labelTitreSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreSortie.Location = new System.Drawing.Point(1106, 8);
            this.labelTitreSortie.Name = "labelTitreSortie";
            this.labelTitreSortie.Size = new System.Drawing.Size(85, 31);
            this.labelTitreSortie.TabIndex = 2;
            this.labelTitreSortie.Text = "Sortie";
            // 
            // labelTitreEntre
            // 
            this.labelTitreEntre.AutoSize = true;
            this.labelTitreEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreEntre.Location = new System.Drawing.Point(677, 8);
            this.labelTitreEntre.Name = "labelTitreEntre";
            this.labelTitreEntre.Size = new System.Drawing.Size(79, 31);
            this.labelTitreEntre.TabIndex = 1;
            this.labelTitreEntre.Text = "Entre";
            // 
            // labelTitreNomPrenom
            // 
            this.labelTitreNomPrenom.AutoSize = true;
            this.labelTitreNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreNomPrenom.Location = new System.Drawing.Point(59, 8);
            this.labelTitreNomPrenom.Name = "labelTitreNomPrenom";
            this.labelTitreNomPrenom.Size = new System.Drawing.Size(298, 31);
            this.labelTitreNomPrenom.TabIndex = 0;
            this.labelTitreNomPrenom.Text = "Nom Prénom du patient";
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.AutoSize = true;
            this.panelList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelList.Location = new System.Drawing.Point(0, 50);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(1254, 50);
            this.panelList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 711);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelTitre);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelTitreSortie;
        private System.Windows.Forms.Label labelTitreEntre;
        private System.Windows.Forms.Label labelTitreNomPrenom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelList;
    }
}

