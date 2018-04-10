namespace PPEprogramme
{
    partial class FenetreProgramme
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
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.lblCSV = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.tbrepertoire = new System.Windows.Forms.TextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSupprimer = new System.Windows.Forms.CheckBox();
            this.btnRepertoire = new System.Windows.Forms.Button();
            this.btnLancer = new System.Windows.Forms.Button();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AutoSize = true;
            this.lblRepertoire.Location = new System.Drawing.Point(12, 23);
            this.lblRepertoire.Name = "lblRepertoire";
            this.lblRepertoire.Size = new System.Drawing.Size(118, 13);
            this.lblRepertoire.TabIndex = 0;
            this.lblRepertoire.Text = "Répertoire des fichiers :";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(16, 65);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(111, 13);
            this.lblCSV.TabIndex = 1;
            this.lblCSV.Text = "Fichier csv à intégrer :";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(16, 184);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 2;
            this.lblClasse.Text = "Classe :";
            // 
            // tbrepertoire
            // 
            this.tbrepertoire.Location = new System.Drawing.Point(181, 23);
            this.tbrepertoire.Name = "tbrepertoire";
            this.tbrepertoire.Size = new System.Drawing.Size(100, 20);
            this.tbrepertoire.TabIndex = 3;
            this.tbrepertoire.TextChanged += new System.EventHandler(this.tbrepertoire_TextChanged);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(181, 65);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(247, 94);
            this.checkedListBox.TabIndex = 4;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkBoxSupprimer
            // 
            this.checkBoxSupprimer.AutoSize = true;
            this.checkBoxSupprimer.Location = new System.Drawing.Point(15, 216);
            this.checkBoxSupprimer.Name = "checkBoxSupprimer";
            this.checkBoxSupprimer.Size = new System.Drawing.Size(313, 17);
            this.checkBoxSupprimer.TabIndex = 6;
            this.checkBoxSupprimer.Text = "Suppression de tous les élèves de la classe avant intégration";
            this.checkBoxSupprimer.UseVisualStyleBackColor = true;
            this.checkBoxSupprimer.CheckedChanged += new System.EventHandler(this.checkBoxSupprimer_CheckedChanged);
            // 
            // btnRepertoire
            // 
            this.btnRepertoire.Location = new System.Drawing.Point(353, 23);
            this.btnRepertoire.Name = "btnRepertoire";
            this.btnRepertoire.Size = new System.Drawing.Size(75, 23);
            this.btnRepertoire.TabIndex = 7;
            this.btnRepertoire.Text = "Parcourir";
            this.btnRepertoire.UseVisualStyleBackColor = true;
            this.btnRepertoire.Click += new System.EventHandler(this.btnRepertoire_Click);
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(246, 249);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(132, 23);
            this.btnLancer.TabIndex = 8;
            this.btnLancer.Text = "Lancer intégration";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(181, 184);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasse.TabIndex = 9;
            this.comboBoxClasse.Text = "Choisir une classe";
            
            // 
            // FenetreProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 284);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.btnRepertoire);
            this.Controls.Add(this.checkBoxSupprimer);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.tbrepertoire);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.lblRepertoire);
            this.Name = "FenetreProgramme";
            this.Text = "Alimentation de la base de données : Nouvelle classe";
            this.Load += new System.EventHandler(this.FenetreProgramme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox tbrepertoire;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.CheckBox checkBoxSupprimer;
        private System.Windows.Forms.Button btnRepertoire;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.ComboBox comboBoxClasse;
    }
}

